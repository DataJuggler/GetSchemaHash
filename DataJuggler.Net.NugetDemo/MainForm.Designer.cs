namespace DataJuggler.Net.NugetDemo
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ConnectionStringControl = new DataJuggler.Win.Controls.LabelTextBoxControl();
            this.GetSchemaHashButton = new System.Windows.Forms.Button();
            this.SchemaHashControl = new DataJuggler.Win.Controls.LabelTextBoxControl();
            this.CopyButton = new System.Windows.Forms.Button();
            this.CopyButton2 = new System.Windows.Forms.Button();
            this.CommitTextBox = new DataJuggler.Win.Controls.LabelTextBoxControl();
            this.GetCommitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ConnectionStringControl
            // 
            this.ConnectionStringControl.BackColor = System.Drawing.Color.Transparent;
            this.ConnectionStringControl.BottomMargin = 0;
            this.ConnectionStringControl.Editable = true;
            this.ConnectionStringControl.Encrypted = false;
            this.ConnectionStringControl.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConnectionStringControl.LabelBottomMargin = 0;
            this.ConnectionStringControl.LabelColor = System.Drawing.Color.LemonChiffon;
            this.ConnectionStringControl.LabelFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.ConnectionStringControl.LabelText = "Conn String:";
            this.ConnectionStringControl.LabelTopMargin = 0;
            this.ConnectionStringControl.LabelWidth = 160;
            this.ConnectionStringControl.Location = new System.Drawing.Point(27, 19);
            this.ConnectionStringControl.MultiLine = false;
            this.ConnectionStringControl.Name = "ConnectionStringControl";
            this.ConnectionStringControl.OnTextChangedListener = null;
            this.ConnectionStringControl.PasswordMode = false;
            this.ConnectionStringControl.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ConnectionStringControl.Size = new System.Drawing.Size(731, 32);
            this.ConnectionStringControl.TabIndex = 0;
            this.ConnectionStringControl.TextBoxBottomMargin = 0;
            this.ConnectionStringControl.TextBoxDisabledColor = System.Drawing.Color.LightGray;
            this.ConnectionStringControl.TextBoxEditableColor = System.Drawing.Color.White;
            this.ConnectionStringControl.TextBoxFont = new System.Drawing.Font("Verdana", 12F);
            this.ConnectionStringControl.TextBoxTopMargin = 0;
            // 
            // GetSchemaHashButton
            // 
            this.GetSchemaHashButton.BackColor = System.Drawing.Color.Transparent;
            this.GetSchemaHashButton.BackgroundImage = global::DataJuggler.Net.NugetDemo.Properties.Resources.WoodButtonWidth2560;
            this.GetSchemaHashButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GetSchemaHashButton.FlatAppearance.BorderSize = 0;
            this.GetSchemaHashButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.GetSchemaHashButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.GetSchemaHashButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GetSchemaHashButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GetSchemaHashButton.Location = new System.Drawing.Point(187, 58);
            this.GetSchemaHashButton.Name = "GetSchemaHashButton";
            this.GetSchemaHashButton.Size = new System.Drawing.Size(215, 39);
            this.GetSchemaHashButton.TabIndex = 1;
            this.GetSchemaHashButton.Text = "Get Schema Hash";
            this.GetSchemaHashButton.UseVisualStyleBackColor = false;
            this.GetSchemaHashButton.Click += new System.EventHandler(this.GetSchemaHashButton_Click);
            this.GetSchemaHashButton.MouseEnter += new System.EventHandler(this.Button_Enter);
            this.GetSchemaHashButton.MouseLeave += new System.EventHandler(this.Button_Leave);
            // 
            // SchemaHashControl
            // 
            this.SchemaHashControl.BackColor = System.Drawing.Color.Transparent;
            this.SchemaHashControl.BottomMargin = 0;
            this.SchemaHashControl.Editable = true;
            this.SchemaHashControl.Encrypted = false;
            this.SchemaHashControl.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SchemaHashControl.LabelBottomMargin = 0;
            this.SchemaHashControl.LabelColor = System.Drawing.Color.LemonChiffon;
            this.SchemaHashControl.LabelFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.SchemaHashControl.LabelText = "Schema Hash:";
            this.SchemaHashControl.LabelTopMargin = 0;
            this.SchemaHashControl.LabelWidth = 160;
            this.SchemaHashControl.Location = new System.Drawing.Point(27, 110);
            this.SchemaHashControl.MultiLine = false;
            this.SchemaHashControl.Name = "SchemaHashControl";
            this.SchemaHashControl.OnTextChangedListener = null;
            this.SchemaHashControl.PasswordMode = false;
            this.SchemaHashControl.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.SchemaHashControl.Size = new System.Drawing.Size(375, 32);
            this.SchemaHashControl.TabIndex = 2;
            this.SchemaHashControl.TextBoxBottomMargin = 0;
            this.SchemaHashControl.TextBoxDisabledColor = System.Drawing.Color.LightGray;
            this.SchemaHashControl.TextBoxEditableColor = System.Drawing.Color.White;
            this.SchemaHashControl.TextBoxFont = new System.Drawing.Font("Verdana", 12F);
            this.SchemaHashControl.TextBoxTopMargin = 0;
            // 
            // CopyButton
            // 
            this.CopyButton.BackColor = System.Drawing.Color.Transparent;
            this.CopyButton.BackgroundImage = global::DataJuggler.Net.NugetDemo.Properties.Resources.WoodButtonWidth2560Disabled;
            this.CopyButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CopyButton.FlatAppearance.BorderSize = 0;
            this.CopyButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.CopyButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.CopyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CopyButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CopyButton.ForeColor = System.Drawing.Color.DarkGray;
            this.CopyButton.Location = new System.Drawing.Point(408, 103);
            this.CopyButton.Name = "CopyButton";
            this.CopyButton.Size = new System.Drawing.Size(108, 39);
            this.CopyButton.TabIndex = 3;
            this.CopyButton.Text = "Copy";
            this.CopyButton.UseVisualStyleBackColor = false;
            this.CopyButton.EnabledChanged += new System.EventHandler(this.Button_EnableChanged);
            this.CopyButton.Click += new System.EventHandler(this.CopyButton_Click);
            this.CopyButton.MouseEnter += new System.EventHandler(this.Button_Enter);
            this.CopyButton.MouseLeave += new System.EventHandler(this.Button_Leave);
            // 
            // CopyButton2
            // 
            this.CopyButton2.BackColor = System.Drawing.Color.Transparent;
            this.CopyButton2.BackgroundImage = global::DataJuggler.Net.NugetDemo.Properties.Resources.WoodButtonWidth2560Disabled;
            this.CopyButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CopyButton2.FlatAppearance.BorderSize = 0;
            this.CopyButton2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.CopyButton2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.CopyButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CopyButton2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CopyButton2.ForeColor = System.Drawing.Color.DarkGray;
            this.CopyButton2.Location = new System.Drawing.Point(408, 212);
            this.CopyButton2.Name = "CopyButton2";
            this.CopyButton2.Size = new System.Drawing.Size(108, 39);
            this.CopyButton2.TabIndex = 6;
            this.CopyButton2.Text = "Copy";
            this.CopyButton2.UseVisualStyleBackColor = false;
            this.CopyButton2.EnabledChanged += new System.EventHandler(this.Button_EnableChanged);
            this.CopyButton2.Click += new System.EventHandler(this.CopyButton2_Click);
            this.CopyButton2.MouseEnter += new System.EventHandler(this.Button_Enter);
            this.CopyButton2.MouseLeave += new System.EventHandler(this.Button_Leave);
            // 
            // CommitTextBox
            // 
            this.CommitTextBox.BackColor = System.Drawing.Color.Transparent;
            this.CommitTextBox.BottomMargin = 0;
            this.CommitTextBox.Editable = true;
            this.CommitTextBox.Encrypted = false;
            this.CommitTextBox.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CommitTextBox.LabelBottomMargin = 0;
            this.CommitTextBox.LabelColor = System.Drawing.Color.LemonChiffon;
            this.CommitTextBox.LabelFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.CommitTextBox.LabelText = "Latest Commit:";
            this.CommitTextBox.LabelTopMargin = 0;
            this.CommitTextBox.LabelWidth = 160;
            this.CommitTextBox.Location = new System.Drawing.Point(27, 219);
            this.CommitTextBox.MultiLine = false;
            this.CommitTextBox.Name = "CommitTextBox";
            this.CommitTextBox.OnTextChangedListener = null;
            this.CommitTextBox.PasswordMode = false;
            this.CommitTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.CommitTextBox.Size = new System.Drawing.Size(375, 32);
            this.CommitTextBox.TabIndex = 5;
            this.CommitTextBox.TextBoxBottomMargin = 0;
            this.CommitTextBox.TextBoxDisabledColor = System.Drawing.Color.LightGray;
            this.CommitTextBox.TextBoxEditableColor = System.Drawing.Color.White;
            this.CommitTextBox.TextBoxFont = new System.Drawing.Font("Verdana", 12F);
            this.CommitTextBox.TextBoxTopMargin = 0;
            // 
            // GetCommitButton
            // 
            this.GetCommitButton.BackColor = System.Drawing.Color.Transparent;
            this.GetCommitButton.BackgroundImage = global::DataJuggler.Net.NugetDemo.Properties.Resources.WoodButtonWidth2560;
            this.GetCommitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GetCommitButton.FlatAppearance.BorderSize = 0;
            this.GetCommitButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.GetCommitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.GetCommitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GetCommitButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GetCommitButton.Location = new System.Drawing.Point(187, 167);
            this.GetCommitButton.Name = "GetCommitButton";
            this.GetCommitButton.Size = new System.Drawing.Size(215, 39);
            this.GetCommitButton.TabIndex = 4;
            this.GetCommitButton.Text = "Get Commit Hash";
            this.GetCommitButton.UseVisualStyleBackColor = false;
            this.GetCommitButton.Click += new System.EventHandler(this.GetCommitButton_Click);
            this.GetCommitButton.MouseEnter += new System.EventHandler(this.Button_Enter);
            this.GetCommitButton.MouseLeave += new System.EventHandler(this.Button_Leave);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::DataJuggler.Net.NugetDemo.Properties.Resources.Deep_Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 289);
            this.Controls.Add(this.CopyButton2);
            this.Controls.Add(this.CommitTextBox);
            this.Controls.Add(this.GetCommitButton);
            this.Controls.Add(this.CopyButton);
            this.Controls.Add(this.SchemaHashControl);
            this.Controls.Add(this.GetSchemaHashButton);
            this.Controls.Add(this.ConnectionStringControl);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DataJuggler.Net.Nuget Demo";
            this.ResumeLayout(false);

        }

        #endregion

        private Win.Controls.LabelTextBoxControl ConnectionStringControl;
        private System.Windows.Forms.Button GetSchemaHashButton;
        private Win.Controls.LabelTextBoxControl SchemaHashControl;
        private System.Windows.Forms.Button CopyButton;
        private System.Windows.Forms.Button CopyButton2;
        private Win.Controls.LabelTextBoxControl CommitTextBox;
        private System.Windows.Forms.Button GetCommitButton;
    }
}

