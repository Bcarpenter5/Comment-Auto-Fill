namespace autoComenter
{
    partial class Form1
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
            this.OpenICA = new System.Windows.Forms.OpenFileDialog();
            this.lbl_title = new System.Windows.Forms.Label();
            this.btn_skip = new System.Windows.Forms.Button();
            this.lbx_methods = new System.Windows.Forms.ListBox();
            this.btn_header = new System.Windows.Forms.Button();
            this.btn_comment = new System.Windows.Forms.Button();
            this.grbx_headerBlock = new System.Windows.Forms.GroupBox();
            this.txbx_projectName = new System.Windows.Forms.TextBox();
            this.lbl_projectName = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.txbx_name = new System.Windows.Forms.TextBox();
            this.btn_open = new System.Windows.Forms.Button();
            this.txbx_methodHolder = new System.Windows.Forms.TextBox();
            this.btn_writeToFile = new System.Windows.Forms.Button();
            this.grbx_headerBlock.SuspendLayout();
            this.SuspendLayout();
            // 
            // OpenICA
            // 
            this.OpenICA.FileName = "openFileDialog1";
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Segoe Script", 15F, System.Drawing.FontStyle.Italic);
            this.lbl_title.Location = new System.Drawing.Point(27, 25);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(408, 32);
            this.lbl_title.TabIndex = 0;
            this.lbl_title.Text = "Brandon Carpenter\'s ICA Commenter";
            // 
            // btn_skip
            // 
            this.btn_skip.Enabled = false;
            this.btn_skip.Location = new System.Drawing.Point(12, 191);
            this.btn_skip.Name = "btn_skip";
            this.btn_skip.Size = new System.Drawing.Size(195, 67);
            this.btn_skip.TabIndex = 1;
            this.btn_skip.Text = "Skip Method";
            this.btn_skip.UseVisualStyleBackColor = true;
            this.btn_skip.Click += new System.EventHandler(this.SkipComment);
            // 
            // lbx_methods
            // 
            this.lbx_methods.Enabled = false;
            this.lbx_methods.FormattingEnabled = true;
            this.lbx_methods.Location = new System.Drawing.Point(246, 60);
            this.lbx_methods.Name = "lbx_methods";
            this.lbx_methods.Size = new System.Drawing.Size(189, 238);
            this.lbx_methods.TabIndex = 2;
            // 
            // btn_header
            // 
            this.btn_header.Location = new System.Drawing.Point(220, 19);
            this.btn_header.Name = "btn_header";
            this.btn_header.Size = new System.Drawing.Size(188, 66);
            this.btn_header.TabIndex = 4;
            this.btn_header.Text = "Insert Block Header";
            this.btn_header.UseVisualStyleBackColor = true;
            this.btn_header.Click += new System.EventHandler(this.InsertHeader);
            // 
            // btn_comment
            // 
            this.btn_comment.Enabled = false;
            this.btn_comment.Location = new System.Drawing.Point(12, 97);
            this.btn_comment.Name = "btn_comment";
            this.btn_comment.Size = new System.Drawing.Size(197, 67);
            this.btn_comment.TabIndex = 5;
            this.btn_comment.Text = "Comment Top Method";
            this.btn_comment.UseVisualStyleBackColor = true;
            this.btn_comment.Click += new System.EventHandler(this.ComementFile);
            // 
            // grbx_headerBlock
            // 
            this.grbx_headerBlock.Controls.Add(this.txbx_projectName);
            this.grbx_headerBlock.Controls.Add(this.lbl_projectName);
            this.grbx_headerBlock.Controls.Add(this.lbl_name);
            this.grbx_headerBlock.Controls.Add(this.txbx_name);
            this.grbx_headerBlock.Controls.Add(this.btn_header);
            this.grbx_headerBlock.Enabled = false;
            this.grbx_headerBlock.Location = new System.Drawing.Point(12, 304);
            this.grbx_headerBlock.Name = "grbx_headerBlock";
            this.grbx_headerBlock.Size = new System.Drawing.Size(422, 92);
            this.grbx_headerBlock.TabIndex = 6;
            this.grbx_headerBlock.TabStop = false;
            this.grbx_headerBlock.Text = "Header Block";
            // 
            // txbx_projectName
            // 
            this.txbx_projectName.Location = new System.Drawing.Point(58, 60);
            this.txbx_projectName.Name = "txbx_projectName";
            this.txbx_projectName.Size = new System.Drawing.Size(127, 20);
            this.txbx_projectName.TabIndex = 8;
            // 
            // lbl_projectName
            // 
            this.lbl_projectName.AutoSize = true;
            this.lbl_projectName.Location = new System.Drawing.Point(9, 62);
            this.lbl_projectName.Name = "lbl_projectName";
            this.lbl_projectName.Size = new System.Drawing.Size(43, 13);
            this.lbl_projectName.TabIndex = 7;
            this.lbl_projectName.Text = "Project:";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(6, 29);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(38, 13);
            this.lbl_name.TabIndex = 6;
            this.lbl_name.Text = "Name:";
            // 
            // txbx_name
            // 
            this.txbx_name.Location = new System.Drawing.Point(50, 26);
            this.txbx_name.Name = "txbx_name";
            this.txbx_name.Size = new System.Drawing.Size(136, 20);
            this.txbx_name.TabIndex = 5;
            // 
            // btn_open
            // 
            this.btn_open.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btn_open.Location = new System.Drawing.Point(81, 127);
            this.btn_open.Name = "btn_open";
            this.btn_open.Size = new System.Drawing.Size(261, 131);
            this.btn_open.TabIndex = 7;
            this.btn_open.Text = "Open Code";
            this.btn_open.UseVisualStyleBackColor = true;
            this.btn_open.Click += new System.EventHandler(this.OpenCodeButton);
            // 
            // txbx_methodHolder
            // 
            this.txbx_methodHolder.Enabled = false;
            this.txbx_methodHolder.Location = new System.Drawing.Point(12, 65);
            this.txbx_methodHolder.Name = "txbx_methodHolder";
            this.txbx_methodHolder.Size = new System.Drawing.Size(196, 20);
            this.txbx_methodHolder.TabIndex = 8;
            // 
            // btn_writeToFile
            // 
            this.btn_writeToFile.Location = new System.Drawing.Point(18, 268);
            this.btn_writeToFile.Name = "btn_writeToFile";
            this.btn_writeToFile.Size = new System.Drawing.Size(178, 29);
            this.btn_writeToFile.TabIndex = 9;
            this.btn_writeToFile.Text = "Write";
            this.btn_writeToFile.UseVisualStyleBackColor = true;
            this.btn_writeToFile.Click += new System.EventHandler(this.WriteToFile);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 408);
            this.Controls.Add(this.btn_writeToFile);
            this.Controls.Add(this.txbx_methodHolder);
            this.Controls.Add(this.btn_open);
            this.Controls.Add(this.grbx_headerBlock);
            this.Controls.Add(this.btn_comment);
            this.Controls.Add(this.lbx_methods);
            this.Controls.Add(this.btn_skip);
            this.Controls.Add(this.lbl_title);
            this.Name = "Form1";
            this.Text = "Comenter";
            this.grbx_headerBlock.ResumeLayout(false);
            this.grbx_headerBlock.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog OpenICA;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Button btn_skip;
        private System.Windows.Forms.ListBox lbx_methods;
        private System.Windows.Forms.Button btn_header;
        private System.Windows.Forms.Button btn_comment;
        private System.Windows.Forms.GroupBox grbx_headerBlock;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.TextBox txbx_name;
        private System.Windows.Forms.TextBox txbx_projectName;
        private System.Windows.Forms.Label lbl_projectName;
        private System.Windows.Forms.Button btn_open;
        private System.Windows.Forms.TextBox txbx_methodHolder;
        private System.Windows.Forms.Button btn_writeToFile;
    }
}

