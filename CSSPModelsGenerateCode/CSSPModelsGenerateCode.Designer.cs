namespace CSSPModelsGenerateCode
{
    partial class CSSPModelsGenerateCode
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblStatusText = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblNote = new System.Windows.Forms.Label();
            this.butGenerateSetupOnce = new System.Windows.Forms.Button();
            this.butGenerateResOnce = new System.Windows.Forms.Button();
            this.butRunModelLint = new System.Windows.Forms.Button();
            this.butGenerateAllCodeFiles = new System.Windows.Forms.Button();
            this.richTextBoxStatus = new System.Windows.Forms.RichTextBox();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.richTextBoxStatus2 = new System.Windows.Forms.RichTextBox();
            this.butGenerateModelsWithHelp = new System.Windows.Forms.Button();
            this.textBoxCodeFileName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.textBoxCodeFileName);
            this.splitContainer1.Panel1.Controls.Add(this.panel2);
            this.splitContainer1.Panel1.Controls.Add(this.lblNote);
            this.splitContainer1.Panel1.Controls.Add(this.butGenerateModelsWithHelp);
            this.splitContainer1.Panel1.Controls.Add(this.butGenerateSetupOnce);
            this.splitContainer1.Panel1.Controls.Add(this.butGenerateResOnce);
            this.splitContainer1.Panel1.Controls.Add(this.butRunModelLint);
            this.splitContainer1.Panel1.Controls.Add(this.butGenerateAllCodeFiles);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1041, 671);
            this.splitContainer1.SplitterDistance = 108;
            this.splitContainer1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblStatusText);
            this.panel2.Controls.Add(this.lblStatus);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 77);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1041, 31);
            this.panel2.TabIndex = 30;
            // 
            // lblStatusText
            // 
            this.lblStatusText.AutoSize = true;
            this.lblStatusText.Location = new System.Drawing.Point(12, 9);
            this.lblStatusText.Name = "lblStatusText";
            this.lblStatusText.Size = new System.Drawing.Size(40, 13);
            this.lblStatusText.TabIndex = 3;
            this.lblStatusText.Text = "Status:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(66, 9);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 13);
            this.lblStatus.TabIndex = 4;
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNote.Location = new System.Drawing.Point(22, 43);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(494, 24);
            this.lblNote.TabIndex = 26;
            this.lblNote.Text = "Note: You will have to recompile the CSSPModels project.";
            // 
            // butGenerateSetupOnce
            // 
            this.butGenerateSetupOnce.Location = new System.Drawing.Point(337, 12);
            this.butGenerateSetupOnce.Name = "butGenerateSetupOnce";
            this.butGenerateSetupOnce.Size = new System.Drawing.Size(140, 23);
            this.butGenerateSetupOnce.TabIndex = 11;
            this.butGenerateSetupOnce.Text = "Generate Setup Once";
            this.butGenerateSetupOnce.UseVisualStyleBackColor = true;
            this.butGenerateSetupOnce.Click += new System.EventHandler(this.butGenerateSetupOnce_Click);
            // 
            // butGenerateResOnce
            // 
            this.butGenerateResOnce.Location = new System.Drawing.Point(167, 12);
            this.butGenerateResOnce.Name = "butGenerateResOnce";
            this.butGenerateResOnce.Size = new System.Drawing.Size(160, 23);
            this.butGenerateResOnce.TabIndex = 11;
            this.butGenerateResOnce.Text = "Generate Resources Once";
            this.butGenerateResOnce.UseVisualStyleBackColor = true;
            this.butGenerateResOnce.Click += new System.EventHandler(this.butGenerateResOnce_Click);
            // 
            // butRunModelLint
            // 
            this.butRunModelLint.Location = new System.Drawing.Point(485, 12);
            this.butRunModelLint.Name = "butRunModelLint";
            this.butRunModelLint.Size = new System.Drawing.Size(107, 23);
            this.butRunModelLint.TabIndex = 11;
            this.butRunModelLint.Text = "Run Model Lint";
            this.butRunModelLint.UseVisualStyleBackColor = true;
            this.butRunModelLint.Click += new System.EventHandler(this.butRunModelLint_Click);
            // 
            // butGenerateAllCodeFiles
            // 
            this.butGenerateAllCodeFiles.Location = new System.Drawing.Point(15, 12);
            this.butGenerateAllCodeFiles.Name = "butGenerateAllCodeFiles";
            this.butGenerateAllCodeFiles.Size = new System.Drawing.Size(143, 23);
            this.butGenerateAllCodeFiles.TabIndex = 11;
            this.butGenerateAllCodeFiles.Text = "Generate all code files";
            this.butGenerateAllCodeFiles.UseVisualStyleBackColor = true;
            this.butGenerateAllCodeFiles.Click += new System.EventHandler(this.butGenerateAllCodeFiles_Click);
            // 
            // richTextBoxStatus
            // 
            this.richTextBoxStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxStatus.Location = new System.Drawing.Point(0, 0);
            this.richTextBoxStatus.Name = "richTextBoxStatus";
            this.richTextBoxStatus.Size = new System.Drawing.Size(501, 559);
            this.richTextBoxStatus.TabIndex = 0;
            this.richTextBoxStatus.Text = "";
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.richTextBoxStatus);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.richTextBoxStatus2);
            this.splitContainer2.Size = new System.Drawing.Size(1041, 559);
            this.splitContainer2.SplitterDistance = 501;
            this.splitContainer2.TabIndex = 1;
            // 
            // richTextBoxStatus2
            // 
            this.richTextBoxStatus2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxStatus2.Location = new System.Drawing.Point(0, 0);
            this.richTextBoxStatus2.Name = "richTextBoxStatus2";
            this.richTextBoxStatus2.Size = new System.Drawing.Size(536, 559);
            this.richTextBoxStatus2.TabIndex = 0;
            this.richTextBoxStatus2.Text = "";
            // 
            // butGenerateModelsWithHelp
            // 
            this.butGenerateModelsWithHelp.Location = new System.Drawing.Point(803, 12);
            this.butGenerateModelsWithHelp.Name = "butGenerateModelsWithHelp";
            this.butGenerateModelsWithHelp.Size = new System.Drawing.Size(163, 23);
            this.butGenerateModelsWithHelp.TabIndex = 11;
            this.butGenerateModelsWithHelp.Text = "Generate Models With Help";
            this.butGenerateModelsWithHelp.UseVisualStyleBackColor = true;
            this.butGenerateModelsWithHelp.Click += new System.EventHandler(this.butGenerateModelsWithHelp_Click);
            // 
            // textBoxCodeFileName
            // 
            this.textBoxCodeFileName.Location = new System.Drawing.Point(803, 43);
            this.textBoxCodeFileName.Name = "textBoxCodeFileName";
            this.textBoxCodeFileName.Size = new System.Drawing.Size(163, 20);
            this.textBoxCodeFileName.TabIndex = 31;
            this.textBoxCodeFileName.Text = "Address";
            // 
            // CSSPModelsGenerateCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 671);
            this.Controls.Add(this.splitContainer1);
            this.Name = "CSSPModelsGenerateCode";
            this.Text = "CSSP Models Generate Code";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblStatusText;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.Button butGenerateAllCodeFiles;
        private System.Windows.Forms.RichTextBox richTextBoxStatus;
        private System.Windows.Forms.Button butGenerateSetupOnce;
        private System.Windows.Forms.Button butGenerateResOnce;
        private System.Windows.Forms.Button butRunModelLint;
        private System.Windows.Forms.TextBox textBoxCodeFileName;
        private System.Windows.Forms.Button butGenerateModelsWithHelp;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.RichTextBox richTextBoxStatus2;
    }
}

