namespace CSVFileGridEditor
{
    partial class FormMain
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ButtonBrowse = new System.Windows.Forms.Button();
            this.TextBoxFile = new System.Windows.Forms.TextBox();
            this.buttonSaveAs = new System.Windows.Forms.Button();
            this.checkBoxFirstRowIsHeader = new System.Windows.Forms.CheckBox();
            this.comboBoxDelimiters = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 96);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1209, 551);
            this.dataGridView1.TabIndex = 0;
            // 
            // ButtonBrowse
            // 
            this.ButtonBrowse.Location = new System.Drawing.Point(1017, 9);
            this.ButtonBrowse.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonBrowse.Name = "ButtonBrowse";
            this.ButtonBrowse.Size = new System.Drawing.Size(100, 28);
            this.ButtonBrowse.TabIndex = 2;
            this.ButtonBrowse.Text = "Browe...";
            this.ButtonBrowse.UseVisualStyleBackColor = true;
            this.ButtonBrowse.Click += new System.EventHandler(this.ButtonBrowse_Click);
            // 
            // TextBoxFile
            // 
            this.TextBoxFile.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxFile.Location = new System.Drawing.Point(13, 13);
            this.TextBoxFile.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxFile.Name = "TextBoxFile";
            this.TextBoxFile.Size = new System.Drawing.Size(996, 22);
            this.TextBoxFile.TabIndex = 3;
            // 
            // buttonSaveAs
            // 
            this.buttonSaveAs.Location = new System.Drawing.Point(1017, 45);
            this.buttonSaveAs.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSaveAs.Name = "buttonSaveAs";
            this.buttonSaveAs.Size = new System.Drawing.Size(100, 28);
            this.buttonSaveAs.TabIndex = 2;
            this.buttonSaveAs.Text = "Save As...";
            this.buttonSaveAs.UseVisualStyleBackColor = true;
            this.buttonSaveAs.Click += new System.EventHandler(this.buttonSaveAs_Click);
            // 
            // checkBoxFirstRowIsHeader
            // 
            this.checkBoxFirstRowIsHeader.AutoSize = true;
            this.checkBoxFirstRowIsHeader.Location = new System.Drawing.Point(369, 51);
            this.checkBoxFirstRowIsHeader.Name = "checkBoxFirstRowIsHeader";
            this.checkBoxFirstRowIsHeader.Size = new System.Drawing.Size(146, 21);
            this.checkBoxFirstRowIsHeader.TabIndex = 4;
            this.checkBoxFirstRowIsHeader.Text = "First row is header";
            this.checkBoxFirstRowIsHeader.UseVisualStyleBackColor = true;
            // 
            // comboBoxDelimiters
            // 
            this.comboBoxDelimiters.FormattingEnabled = true;
            this.comboBoxDelimiters.Items.AddRange(new object[] {
            ",    Comma",
            ";    Semicolon",
            "     TAB",
            "     Space"});
            this.comboBoxDelimiters.Location = new System.Drawing.Point(217, 48);
            this.comboBoxDelimiters.Name = "comboBoxDelimiters";
            this.comboBoxDelimiters.Size = new System.Drawing.Size(121, 24);
            this.comboBoxDelimiters.TabIndex = 5;
            this.comboBoxDelimiters.SelectedIndexChanged += new System.EventHandler(this.comboBoxDelimiters_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Delimiter (enter if not in list):";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1214, 659);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxDelimiters);
            this.Controls.Add(this.checkBoxFirstRowIsHeader);
            this.Controls.Add(this.buttonSaveAs);
            this.Controls.Add(this.ButtonBrowse);
            this.Controls.Add(this.TextBoxFile);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormMain";
            this.Text = "CSV GridView Editor";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        internal System.Windows.Forms.Button ButtonBrowse;
        internal System.Windows.Forms.TextBox TextBoxFile;
        internal System.Windows.Forms.Button buttonSaveAs;
        private System.Windows.Forms.CheckBox checkBoxFirstRowIsHeader;
        private System.Windows.Forms.ComboBox comboBoxDelimiters;
        private System.Windows.Forms.Label label1;
    }
}