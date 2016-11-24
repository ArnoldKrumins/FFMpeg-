namespace ffmpegEncoding
{
    partial class frmMain
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
            this.cmbResolution = new System.Windows.Forms.ComboBox();
            this.lblResoultion = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbAspectRatio = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbScanning = new System.Windows.Forms.ComboBox();
            this.btnEncode = new System.Windows.Forms.Button();
            this.lblCreative = new System.Windows.Forms.Label();
            this.cmbCreative = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbEncoding = new System.Windows.Forms.ComboBox();
            this.lblOutput = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbResolution
            // 
            this.cmbResolution.FormattingEnabled = true;
            this.cmbResolution.Items.AddRange(new object[] {
            "HD",
            "SD"});
            this.cmbResolution.Location = new System.Drawing.Point(35, 199);
            this.cmbResolution.Name = "cmbResolution";
            this.cmbResolution.Size = new System.Drawing.Size(121, 24);
            this.cmbResolution.TabIndex = 0;
            // 
            // lblResoultion
            // 
            this.lblResoultion.AutoSize = true;
            this.lblResoultion.Location = new System.Drawing.Point(32, 179);
            this.lblResoultion.Name = "lblResoultion";
            this.lblResoultion.Size = new System.Drawing.Size(75, 17);
            this.lblResoultion.TabIndex = 1;
            this.lblResoultion.Text = "Resolution";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 233);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Aspect Ratio";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cmbAspectRatio
            // 
            this.cmbAspectRatio.FormattingEnabled = true;
            this.cmbAspectRatio.Items.AddRange(new object[] {
            "4:3",
            "16:9"});
            this.cmbAspectRatio.Location = new System.Drawing.Point(35, 253);
            this.cmbAspectRatio.Name = "cmbAspectRatio";
            this.cmbAspectRatio.Size = new System.Drawing.Size(121, 24);
            this.cmbAspectRatio.TabIndex = 2;
            this.cmbAspectRatio.SelectedIndexChanged += new System.EventHandler(this.cmbAspectRatio_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 288);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Scanning";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // cmbScanning
            // 
            this.cmbScanning.FormattingEnabled = true;
            this.cmbScanning.Items.AddRange(new object[] {
            "Progressive",
            "Interlaced"});
            this.cmbScanning.Location = new System.Drawing.Point(35, 308);
            this.cmbScanning.Name = "cmbScanning";
            this.cmbScanning.Size = new System.Drawing.Size(121, 24);
            this.cmbScanning.TabIndex = 4;
            // 
            // btnEncode
            // 
            this.btnEncode.Location = new System.Drawing.Point(436, 485);
            this.btnEncode.Name = "btnEncode";
            this.btnEncode.Size = new System.Drawing.Size(116, 35);
            this.btnEncode.TabIndex = 6;
            this.btnEncode.Text = "Encode";
            this.btnEncode.UseVisualStyleBackColor = true;
            this.btnEncode.Click += new System.EventHandler(this.btnEncode_Click);
            // 
            // lblCreative
            // 
            this.lblCreative.AutoSize = true;
            this.lblCreative.Location = new System.Drawing.Point(32, 108);
            this.lblCreative.Name = "lblCreative";
            this.lblCreative.Size = new System.Drawing.Size(60, 17);
            this.lblCreative.TabIndex = 8;
            this.lblCreative.Text = "Creative";
            // 
            // cmbCreative
            // 
            this.cmbCreative.FormattingEnabled = true;
            this.cmbCreative.Items.AddRange(new object[] {
            "AVI",
            "MOV",
            "MP4"});
            this.cmbCreative.Location = new System.Drawing.Point(35, 128);
            this.cmbCreative.Name = "cmbCreative";
            this.cmbCreative.Size = new System.Drawing.Size(121, 24);
            this.cmbCreative.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(200, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Encoding";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // cmbEncoding
            // 
            this.cmbEncoding.FormattingEnabled = true;
            this.cmbEncoding.Items.AddRange(new object[] {
            "MPEG2",
            "MPEG4",
            "WEBM"});
            this.cmbEncoding.Location = new System.Drawing.Point(203, 128);
            this.cmbEncoding.Name = "cmbEncoding";
            this.cmbEncoding.Size = new System.Drawing.Size(121, 24);
            this.cmbEncoding.TabIndex = 9;
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(32, 373);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(51, 17);
            this.lblOutput.TabIndex = 11;
            this.lblOutput.Text = "Output";
            this.lblOutput.Click += new System.EventHandler(this.label4_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(35, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(368, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "Only Select AVI/MPEG2 or  MP4/WEBM";
            this.label4.Click += new System.EventHandler(this.label4_Click_1);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 546);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbEncoding);
            this.Controls.Add(this.lblCreative);
            this.Controls.Add(this.cmbCreative);
            this.Controls.Add(this.btnEncode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbScanning);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbAspectRatio);
            this.Controls.Add(this.lblResoultion);
            this.Controls.Add(this.cmbResolution);
            this.Name = "frmMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbResolution;
        private System.Windows.Forms.Label lblResoultion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbScanning;
        private System.Windows.Forms.Button btnEncode;
        private System.Windows.Forms.Label lblCreative;
        private System.Windows.Forms.ComboBox cmbCreative;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbEncoding;
        private System.Windows.Forms.ComboBox cmbAspectRatio;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Label label4;
    }
}

