

#region using statements

using DataJuggler.Core.UltimateHelper;
using DataJuggler.Core.UltimateHelper.Objects;
using System;
using System.Collections.Generic;
using System.Net;
using System.Windows.Forms;
using System.Drawing;
using DataJuggler.Win.Controls.Interfaces;

#endregion

namespace DataJuggler.Net.NugetDemo
{

    #region class MainForm
    /// <summary>
    /// This form is used to test the GetDatbaseSchemaHash button
    /// </summary>
    public partial class MainForm : Form, ITextChanged
    {
        
        #region Private Variables
        private const string RepoUrl = "https://github.com/DataJuggler/DataTier.Net";
        #endregion
        
        #region Constructor
        /// <summary>
        /// Create a new instance of a 'MainForm' object.
        /// </summary>
        public MainForm()
        {
            // Create Controls
            InitializeComponent();

            // Init
            Init();
        }
        #endregion
        
        #region Events
            
            #region Button_EnableChanged(object sender, EventArgs e)
            /// <summary>
            /// event is fired when Button _ Enable Changed
            /// </summary>
            private void Button_EnableChanged(object sender, EventArgs e)
            {
                // cast the sender as a button
                Button button = sender as Button;

                // If the button object exists
                if (NullHelper.Exists(button))
                {
                    // if the button is enabled
                    if (button.Enabled)
                    {
                        // Use the enabled image
                        button.BackgroundImage = Properties.Resources.WoodButtonWidth2560;

                        // use black
                        button.ForeColor = Color.Black;
                    }
                    else
                    {
                        // Use the disabled image
                        button.BackgroundImage = Properties.Resources.WoodButtonWidth2560Disabled;

                        // use DarkGray
                        button.ForeColor = Color.DarkGray;
                    }
                }
            }
            #endregion
            
            #region Button_Enter(object sender, EventArgs e)
            /// <summary>
            /// event is fired when Button _ Enter
            /// </summary>
            private void Button_Enter(object sender, EventArgs e)
            {
                // Change the cursor to a hand
                Cursor = Cursors.Hand;
            }
            #endregion
            
            #region Button_Leave(object sender, EventArgs e)
            /// <summary>
            /// event is fired when Button _ Leave
            /// </summary>
            private void Button_Leave(object sender, EventArgs e)
            {
                // Change the cursor back to the default pointer
                Cursor = Cursors.Default;
            }
            #endregion

            #region CopyButton_Click(object sender, EventArgs e)
            /// <summary>
            /// event is fired when the 'CopyButton' is clicked.
            /// </summary>
            private void CopyButton_Click(object sender, EventArgs e)
            {
                // Copy to your clipboard
                Clipboard.SetText(SchemaHashControl.Text);

                // Show the user a message
                MessageBoxHelper.ShowMessage("The Schema Hash has been copied to your clipboard.", "Schema Hash Copied");
            }
            #endregion
            
            #region CopyButton2_Click(object sender, EventArgs e)
            /// <summary>
            /// event is fired when the 'CopyButton2' is clicked.
            /// </summary>
            private void CopyButton2_Click(object sender, EventArgs e)
            {
                // if the Text is set
                if (CommitTextBox.HasText)
                {
                    // Copy to your clipboard
                    Clipboard.SetText(CommitTextBox.Text);

                    // Show the user a message
                    MessageBoxHelper.ShowMessage("The Latest Commit Hash has been copied to your clipboard.", "Commit Hash Copied");
                }
                else
                {
                    // Show the user a message
                    MessageBoxHelper.ShowMessage("Get the commit text before clicking copy.", "Value Required");
                }
            }
            #endregion
            
            #region GetCommitButton_Click(object sender, EventArgs e)
            /// <summary>
            /// event is fired when the 'GetCommitButton' is clicked.
            /// </summary>
            private void GetCommitButton_Click(object sender, EventArgs e)
            {
                // local
                string commitRawText = "";

                try
                {
                    // get the client
                    using (var client = new WebClient())
                    {
                         // get the result
                        string webPageText = client.DownloadString(RepoUrl);

                        // If the webPageText string exists
                        if (TextHelper.Exists(webPageText))
                        {
                            // string we are looking for
                            string href = @"DataJuggler/DataTier.Net/commit/";

                            // parse the textLines
                            List<TextLine> textLines = WordParser.GetTextLines(webPageText);

                            // If the textLines collection exists and has one or more items
                            if (ListHelper.HasOneOrMoreItems(textLines))
                            {
                                // Iterate the collection of TextLine objects
                                foreach (TextLine textLine in textLines)
                                {
                                    // is this is the line we are looking for
                                    if (textLine.Text.Contains(href))
                                    {
                                        // get the full text
                                        commitRawText = textLine.Text;

                                        // break out of the loop
                                        break;
                                    }
                                }
                            }
                        }

                        // If the commitRawText string exists
                        if (TextHelper.Exists(commitRawText))
                        {
                            // convert to words
                            List<Word> words = WordParser.GetWords(commitRawText);

                            // If the words collection exists and has one or more items
                            if (ListHelper.HasOneOrMoreItems(words))
                            {
                                // local
                                bool nextWord = false;

                                // Iterate the collection of Word objects
                                foreach (Word word in words)
                                {
                                    // if the value for nextWord is true
                                    if ((nextWord) && (word.HasText) && (word.Text.Length > 7))
                                    {
                                        // set the commitText
                                        string commitText = word.Text;

                                        // Set the text
                                        this.CommitTextBox.Text = commitText.Substring(0, 7);

                                        // break out of the loop
                                        break;
                                    }
                                    else
                                    {
                                        // we must check for the word commit
                                        if (TextHelper.IsEqual("commit", word.Text))
                                        {
                                            // Set the value for the nextWord to true
                                            nextWord = true;
                                        }
                                    }
                                }
                            }
                        }
                    }  
                }
                catch (Exception error)
                {
                    // for debugging only
                    DebugHelper.WriteDebugError("GetCommitButton_Click", this.Name, error);
                }
            }
            #endregion
            
            #region GetSchemaHashButton_Click(object sender, EventArgs e)
            /// <summary>
            /// event is fired when the 'GetSchemaHashButton' is clicked.
            /// </summary>
            private void GetSchemaHashButton_Click(object sender, EventArgs e)
            {
                // create a database
                Database database = new Database();

                // paste in your connectionstring
                database.ConnectionString = ConnectionStringControl.Text;

                try
                {
                    // if the connecionstring exists
                    if (TextHelper.Exists(database.ConnectionString))
                    {
                        // Create a new instance of a 'SQLDatabaseConnector' object.
                        SQLDatabaseConnector connector = new SQLDatabaseConnector();

                        // set the connectionstring on the connector
                        connector.ConnectionString = database.ConnectionString;

                        // open the connection
                        connector.Open();

                        // get the schemaHash
                        string schemaHash = connector.GetDatabaseSchemaHash(database);

                        // close the connection
                        connector.Close();

                        // Display the result
                        this.SchemaHashControl.Text = schemaHash;
                    }
                    else
                    {
                        // Show the user a message
                        MessageBoxHelper.ShowMessage("You must paste in a connection string to continue.", "Connectionstring Required");
                    }
                }
                catch (Exception error)
                {
                    // Show the user a message
                    MessageBoxHelper.ShowMessage("An error occurred: " + error.ToString(), "Error");
                }
            }
            #endregion

            #region OnTextChanged(Control sender, string text)
            /// <summary>
            /// event is fired when On Text Changed
            /// </summary>
            public void OnTextChanged(Control sender, string text)
            {
                // Enable or disable controls
                UIEnable();
            }
            #endregion
            
        #endregion

        #region Methods

            #region Init()
            /// <summary>
            /// This method  This method performs initializations for this object.
            /// </summary>
            public void Init()
            {
                // Setup the listeners
                this.SchemaHashControl.OnTextChangedListener = this;
                this.SchemaHashControl.OnTextChangedListener = this;

                // set the connection string value if set
                this.ConnectionStringControl.Text = ConfigurationHelper.ReadAppSetting("Connectionstring");

                // Enable the controls
                UIEnable();
            }
        #endregion

            #region UIEnable()
            /// <summary>
            /// This method UI Enable
            /// </summary>
            public void UIEnable()
            {   
                // Enable the buttons if the text boxes have text
                this.CopyButton.Enabled = SchemaHashControl.HasText;
                this.CopyButton2.Enabled = CommitTextBox.HasText;
            }
        #endregion

        #endregion

    }
    #endregion

}
