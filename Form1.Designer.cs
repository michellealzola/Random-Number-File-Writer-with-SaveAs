namespace Random_Number_File_Writer
{
    partial class frmRandomNumFileWriter
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
            this.diaSave = new System.Windows.Forms.SaveFileDialog();
            this.btnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tboxNum = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("NanumGothicCoding", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(65, 117);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(221, 55);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save to File";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("NanumGothicCoding", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "How many random numbers?";
            // 
            // tboxNum
            // 
            this.tboxNum.Font = new System.Drawing.Font("NanumGothicCoding", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxNum.Location = new System.Drawing.Point(311, 62);
            this.tboxNum.Name = "tboxNum";
            this.tboxNum.Size = new System.Drawing.Size(100, 26);
            this.tboxNum.TabIndex = 2;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("NanumGothicCoding", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(292, 117);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(119, 55);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Close";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmRandomNumFileWriter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 211);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.tboxNum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSave);
            this.Name = "frmRandomNumFileWriter";
            this.Text = "Random Number File Writer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SaveFileDialog diaSave;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tboxNum;
        private System.Windows.Forms.Button btnExit;
    }
}

