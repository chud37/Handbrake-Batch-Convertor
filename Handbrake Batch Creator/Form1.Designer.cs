namespace Handbrake_Batch_Creator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.folderSourceDIR = new System.Windows.Forms.FolderBrowserDialog();
            this.folderDestinationDIR = new System.Windows.Forms.FolderBrowserDialog();
            this.buttonCreateFiles = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.retainParentFolder = new System.Windows.Forms.CheckBox();
            this.buttonFindDestinationDIR = new System.Windows.Forms.Button();
            this.buttonFindSourceDIR = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.destinationDIR = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.sourceDIR = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.removeFileType = new System.Windows.Forms.Button();
            this.addFileType = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.comboFileTypes = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboAspectRatio = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numericNumberOfFiles = new System.Windows.Forms.NumericUpDown();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxHeight = new System.Windows.Forms.TextBox();
            this.textBoxWidth = new System.Windows.Forms.TextBox();
            this.checkBoxOverrideWH = new System.Windows.Forms.CheckBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.exampleOutput = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericNumberOfFiles)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // folderSourceDIR
            // 
            this.folderSourceDIR.ShowNewFolderButton = false;
            // 
            // folderDestinationDIR
            // 
            this.folderDestinationDIR.ShowNewFolderButton = false;
            // 
            // buttonCreateFiles
            // 
            this.buttonCreateFiles.Image = global::Handbrake_Batch_Creator.Properties.Resources.TriggerAction_16x;
            this.buttonCreateFiles.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCreateFiles.Location = new System.Drawing.Point(675, 336);
            this.buttonCreateFiles.Name = "buttonCreateFiles";
            this.buttonCreateFiles.Size = new System.Drawing.Size(132, 43);
            this.buttonCreateFiles.TabIndex = 13;
            this.buttonCreateFiles.Text = "Create Files";
            this.buttonCreateFiles.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonCreateFiles.UseVisualStyleBackColor = true;
            this.buttonCreateFiles.Click += new System.EventHandler(this.buttonCreateFiles_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Handbrake_Batch_Creator.Properties.Resources.handbrake_logo;
            this.pictureBox1.Location = new System.Drawing.Point(9, 336);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(42, 43);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.retainParentFolder);
            this.groupBox1.Controls.Add(this.buttonFindDestinationDIR);
            this.groupBox1.Controls.Add(this.buttonFindSourceDIR);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.destinationDIR);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.sourceDIR);
            this.groupBox1.Location = new System.Drawing.Point(9, 9);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(394, 224);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            // 
            // retainParentFolder
            // 
            this.retainParentFolder.AutoSize = true;
            this.retainParentFolder.Font = new System.Drawing.Font("Open Sans", 8F);
            this.retainParentFolder.Location = new System.Drawing.Point(12, 188);
            this.retainParentFolder.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.retainParentFolder.Name = "retainParentFolder";
            this.retainParentFolder.Size = new System.Drawing.Size(236, 19);
            this.retainParentFolder.TabIndex = 16;
            this.retainParentFolder.Text = "Retain each individual files parent folder";
            this.retainParentFolder.UseVisualStyleBackColor = true;
            this.retainParentFolder.CheckedChanged += new System.EventHandler(this.retainParentFolder_CheckedChanged);
            // 
            // buttonFindDestinationDIR
            // 
            this.buttonFindDestinationDIR.Image = global::Handbrake_Batch_Creator.Properties.Resources.FindinFiles_16x;
            this.buttonFindDestinationDIR.Location = new System.Drawing.Point(350, 130);
            this.buttonFindDestinationDIR.Name = "buttonFindDestinationDIR";
            this.buttonFindDestinationDIR.Size = new System.Drawing.Size(32, 29);
            this.buttonFindDestinationDIR.TabIndex = 15;
            this.buttonFindDestinationDIR.UseVisualStyleBackColor = true;
            this.buttonFindDestinationDIR.Click += new System.EventHandler(this.buttonFindDestinationDIR_Click_1);
            // 
            // buttonFindSourceDIR
            // 
            this.buttonFindSourceDIR.Image = global::Handbrake_Batch_Creator.Properties.Resources.FindinFiles_16x;
            this.buttonFindSourceDIR.Location = new System.Drawing.Point(350, 52);
            this.buttonFindSourceDIR.Name = "buttonFindSourceDIR";
            this.buttonFindSourceDIR.Size = new System.Drawing.Size(32, 29);
            this.buttonFindSourceDIR.TabIndex = 14;
            this.buttonFindSourceDIR.UseVisualStyleBackColor = true;
            this.buttonFindSourceDIR.Click += new System.EventHandler(this.buttonFindSourceDIR_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 103);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 22);
            this.label2.TabIndex = 12;
            this.label2.Text = "Destination Directory";
            // 
            // destinationDIR
            // 
            this.destinationDIR.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.destinationDIR.Location = new System.Drawing.Point(12, 130);
            this.destinationDIR.Margin = new System.Windows.Forms.Padding(5);
            this.destinationDIR.Name = "destinationDIR";
            this.destinationDIR.ReadOnly = true;
            this.destinationDIR.Size = new System.Drawing.Size(330, 29);
            this.destinationDIR.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 22);
            this.label1.TabIndex = 10;
            this.label1.Text = "Source Directory";
            // 
            // sourceDIR
            // 
            this.sourceDIR.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sourceDIR.Location = new System.Drawing.Point(12, 52);
            this.sourceDIR.Margin = new System.Windows.Forms.Padding(5);
            this.sourceDIR.Name = "sourceDIR";
            this.sourceDIR.ReadOnly = true;
            this.sourceDIR.Size = new System.Drawing.Size(330, 29);
            this.sourceDIR.TabIndex = 9;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.removeFileType);
            this.groupBox2.Controls.Add(this.addFileType);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.comboFileTypes);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.comboAspectRatio);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.numericNumberOfFiles);
            this.groupBox2.Location = new System.Drawing.Point(413, 9);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(394, 163);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            // 
            // removeFileType
            // 
            this.removeFileType.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeFileType.Location = new System.Drawing.Point(319, 131);
            this.removeFileType.Margin = new System.Windows.Forms.Padding(0);
            this.removeFileType.Name = "removeFileType";
            this.removeFileType.Size = new System.Drawing.Size(62, 23);
            this.removeFileType.TabIndex = 20;
            this.removeFileType.Text = "remove";
            this.removeFileType.UseVisualStyleBackColor = true;
            this.removeFileType.Click += new System.EventHandler(this.removeFileType_Click);
            // 
            // addFileType
            // 
            this.addFileType.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addFileType.Location = new System.Drawing.Point(266, 131);
            this.addFileType.Margin = new System.Windows.Forms.Padding(0);
            this.addFileType.Name = "addFileType";
            this.addFileType.Size = new System.Drawing.Size(47, 23);
            this.addFileType.TabIndex = 19;
            this.addFileType.Text = "add..";
            this.addFileType.UseVisualStyleBackColor = true;
            this.addFileType.Click += new System.EventHandler(this.addFileType_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 100);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 22);
            this.label5.TabIndex = 18;
            this.label5.Text = "Files to scan for";
            // 
            // comboFileTypes
            // 
            this.comboFileTypes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboFileTypes.FormattingEnabled = true;
            this.comboFileTypes.Items.AddRange(new object[] {
            "MP4",
            "MOV",
            "VOB"});
            this.comboFileTypes.Location = new System.Drawing.Point(202, 97);
            this.comboFileTypes.Name = "comboFileTypes";
            this.comboFileTypes.Size = new System.Drawing.Size(180, 30);
            this.comboFileTypes.TabIndex = 17;
            this.comboFileTypes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboFileTypes_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 64);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 22);
            this.label4.TabIndex = 16;
            this.label4.Text = "Aspect Ratio";
            // 
            // comboAspectRatio
            // 
            this.comboAspectRatio.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboAspectRatio.FormattingEnabled = true;
            this.comboAspectRatio.Items.AddRange(new object[] {
            "16:9",
            "4:3"});
            this.comboAspectRatio.Location = new System.Drawing.Point(202, 61);
            this.comboAspectRatio.Name = "comboAspectRatio";
            this.comboAspectRatio.Size = new System.Drawing.Size(180, 30);
            this.comboAspectRatio.TabIndex = 15;
            this.comboAspectRatio.SelectedIndexChanged += new System.EventHandler(this.comboAspectRatio_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 25);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(198, 22);
            this.label3.TabIndex = 14;
            this.label3.Text = "Number of files to create";
            // 
            // numericNumberOfFiles
            // 
            this.numericNumberOfFiles.Location = new System.Drawing.Point(340, 23);
            this.numericNumberOfFiles.Name = "numericNumberOfFiles";
            this.numericNumberOfFiles.Size = new System.Drawing.Size(42, 29);
            this.numericNumberOfFiles.TabIndex = 13;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.textBoxHeight);
            this.groupBox3.Controls.Add(this.textBoxWidth);
            this.groupBox3.Controls.Add(this.checkBoxOverrideWH);
            this.groupBox3.Location = new System.Drawing.Point(413, 172);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(394, 61);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(310, 22);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 22);
            this.label6.TabIndex = 23;
            this.label6.Text = "x";
            // 
            // textBoxHeight
            // 
            this.textBoxHeight.Location = new System.Drawing.Point(336, 19);
            this.textBoxHeight.Name = "textBoxHeight";
            this.textBoxHeight.ReadOnly = true;
            this.textBoxHeight.Size = new System.Drawing.Size(46, 29);
            this.textBoxHeight.TabIndex = 22;
            this.textBoxHeight.Text = "450";
            this.textBoxHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxWidth
            // 
            this.textBoxWidth.Location = new System.Drawing.Point(256, 19);
            this.textBoxWidth.Name = "textBoxWidth";
            this.textBoxWidth.ReadOnly = true;
            this.textBoxWidth.Size = new System.Drawing.Size(46, 29);
            this.textBoxWidth.TabIndex = 21;
            this.textBoxWidth.Text = "800";
            this.textBoxWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // checkBoxOverrideWH
            // 
            this.checkBoxOverrideWH.AutoSize = true;
            this.checkBoxOverrideWH.Font = new System.Drawing.Font("Open Sans", 8F);
            this.checkBoxOverrideWH.Location = new System.Drawing.Point(12, 26);
            this.checkBoxOverrideWH.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.checkBoxOverrideWH.Name = "checkBoxOverrideWH";
            this.checkBoxOverrideWH.Size = new System.Drawing.Size(212, 19);
            this.checkBoxOverrideWH.TabIndex = 20;
            this.checkBoxOverrideWH.Text = "Manually override width and height";
            this.checkBoxOverrideWH.UseVisualStyleBackColor = true;
            this.checkBoxOverrideWH.CheckedChanged += new System.EventHandler(this.checkBoxOverrideWH_CheckedChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel,
            this.toolStripProgressBar});
            this.statusStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.statusStrip1.Location = new System.Drawing.Point(0, 387);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(815, 22);
            this.statusStrip1.TabIndex = 23;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel.Text = "Ready";
            // 
            // toolStripProgressBar
            // 
            this.toolStripProgressBar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripProgressBar.Name = "toolStripProgressBar";
            this.toolStripProgressBar.Size = new System.Drawing.Size(100, 16);
            this.toolStripProgressBar.Visible = false;
            // 
            // exampleOutput
            // 
            this.exampleOutput.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exampleOutput.Location = new System.Drawing.Point(9, 267);
            this.exampleOutput.Multiline = true;
            this.exampleOutput.Name = "exampleOutput";
            this.exampleOutput.Size = new System.Drawing.Size(798, 63);
            this.exampleOutput.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 242);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 22);
            this.label7.TabIndex = 16;
            this.label7.Text = "Output Example";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 409);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.exampleOutput);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonCreateFiles);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Handbrake Batch Creator";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericNumberOfFiles)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FolderBrowserDialog folderSourceDIR;
        private System.Windows.Forms.FolderBrowserDialog folderDestinationDIR;
        private System.Windows.Forms.Button buttonCreateFiles;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonFindDestinationDIR;
        private System.Windows.Forms.Button buttonFindSourceDIR;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox destinationDIR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox sourceDIR;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboFileTypes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboAspectRatio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericNumberOfFiles;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxHeight;
        private System.Windows.Forms.TextBox textBoxWidth;
        private System.Windows.Forms.CheckBox checkBoxOverrideWH;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar;
        private System.Windows.Forms.Button removeFileType;
        private System.Windows.Forms.Button addFileType;
        private System.Windows.Forms.TextBox exampleOutput;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox retainParentFolder;
    }
}

