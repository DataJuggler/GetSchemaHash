

#region using statements

using DataJuggler.Core.UltimateHelper;
using DataJuggler.Net;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

#endregion

namespace DataJuggler.Net.NugetDemo
{

    #region class MainForm
    /// <summary>
    /// This form is used to test the GetDatbaseSchemaHash button
    /// </summary>
    public partial class MainForm : Form
    {
        
        #region Private Variables
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

        #endregion

        #region Methods

            #region Init()
            /// <summary>
            /// This method  This method performs initializations for this object.
            /// </summary>
            public void Init()
            {
                // set the connection string value if set
                this.ConnectionStringControl.Text = ConfigurationHelper.ReadAppSetting("Connectionstring");
            }
        #endregion

        #endregion

    }
    #endregion

}
