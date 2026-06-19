namespace SectionB_Question2
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtIDNumber = new System.Windows.Forms.TextBox();
            this.cmbCitizenship = new System.Windows.Forms.ComboBox();
            this.btnValidateID = new System.Windows.Forms.Button();
            this.lblValidationResult = new System.Windows.Forms.Label();
            this.txtSummaryDisplay = new System.Windows.Forms.TextBox();
            this.btnGenerateProfile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(621, 54);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 22);
            this.txtName.TabIndex = 0;
            // 
            // txtIDNumber
            // 
            this.txtIDNumber.Location = new System.Drawing.Point(621, 103);
            this.txtIDNumber.MaxLength = 13;
            this.txtIDNumber.Name = "txtIDNumber";
            this.txtIDNumber.Size = new System.Drawing.Size(100, 22);
            this.txtIDNumber.TabIndex = 1;
            this.txtIDNumber.TextChanged += new System.EventHandler(this.txtIDNumber_TextChanged);
            // 
            // cmbCitizenship
            // 
            this.cmbCitizenship.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCitizenship.FormattingEnabled = true;
            this.cmbCitizenship.Location = new System.Drawing.Point(621, 144);
            this.cmbCitizenship.Name = "cmbCitizenship";
            this.cmbCitizenship.Size = new System.Drawing.Size(121, 24);
            this.cmbCitizenship.TabIndex = 2;
            // 
            // btnValidateID
            // 
            this.btnValidateID.BackColor = System.Drawing.Color.Green;
            this.btnValidateID.ForeColor = System.Drawing.SystemColors.Control;
            this.btnValidateID.Location = new System.Drawing.Point(621, 174);
            this.btnValidateID.Name = "btnValidateID";
            this.btnValidateID.Size = new System.Drawing.Size(121, 37);
            this.btnValidateID.TabIndex = 3;
            this.btnValidateID.Text = "Valdidate";
            this.btnValidateID.UseVisualStyleBackColor = false;
            this.btnValidateID.Click += new System.EventHandler(this.btnValidateID_Click_1);
            // 
            // lblValidationResult
            // 
            this.lblValidationResult.AutoSize = true;
            this.lblValidationResult.Location = new System.Drawing.Point(509, 215);
            this.lblValidationResult.Name = "lblValidationResult";
            this.lblValidationResult.Size = new System.Drawing.Size(17, 16);
            this.lblValidationResult.TabIndex = 4;
            this.lblValidationResult.Text = "\"\"";
            // 
            // txtSummaryDisplay
            // 
            this.txtSummaryDisplay.Location = new System.Drawing.Point(512, 243);
            this.txtSummaryDisplay.Multiline = true;
            this.txtSummaryDisplay.Name = "txtSummaryDisplay";
            this.txtSummaryDisplay.ReadOnly = true;
            this.txtSummaryDisplay.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSummaryDisplay.Size = new System.Drawing.Size(269, 182);
            this.txtSummaryDisplay.TabIndex = 5;
            // 
            // btnGenerateProfile
            // 
            this.btnGenerateProfile.BackColor = System.Drawing.Color.Green;
            this.btnGenerateProfile.ForeColor = System.Drawing.SystemColors.Control;
            this.btnGenerateProfile.Location = new System.Drawing.Point(378, 243);
            this.btnGenerateProfile.Name = "btnGenerateProfile";
            this.btnGenerateProfile.Size = new System.Drawing.Size(128, 41);
            this.btnGenerateProfile.TabIndex = 6;
            this.btnGenerateProfile.Text = "Generate Profile";
            this.btnGenerateProfile.UseVisualStyleBackColor = false;
            this.btnGenerateProfile.Click += new System.EventHandler(this.btnGenerateProfile_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(299, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(461, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "Home Affairs Digital identity Processor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(388, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "Enter your Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(388, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 18);
            this.label3.TabIndex = 10;
            this.label3.Text = "Enter your ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(388, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(193, 18);
            this.label4.TabIndex = 11;
            this.label4.Text = "Choose your Citizenship";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SectionB_Question2.Properties.Resources.Coat_of_arms_of_South_Africa_5c33a88346e0fb00013b521c_better;
            this.pictureBox1.Location = new System.Drawing.Point(48, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(334, 384);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnGenerateProfile);
            this.Controls.Add(this.txtSummaryDisplay);
            this.Controls.Add(this.lblValidationResult);
            this.Controls.Add(this.btnValidateID);
            this.Controls.Add(this.cmbCitizenship);
            this.Controls.Add(this.txtIDNumber);
            this.Controls.Add(this.txtName);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtIDNumber;
        private System.Windows.Forms.ComboBox cmbCitizenship;
        private System.Windows.Forms.Button btnValidateID;
        private System.Windows.Forms.Label lblValidationResult;
        private System.Windows.Forms.TextBox txtSummaryDisplay;
        private System.Windows.Forms.Button btnGenerateProfile;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

