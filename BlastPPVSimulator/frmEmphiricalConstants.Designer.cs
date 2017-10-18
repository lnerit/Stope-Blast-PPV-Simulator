namespace WindowsFormsApplication1
{
    partial class frmEmphiricalConstants
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
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.txtDistanceFromBlastToMeasurePoint = new System.Windows.Forms.TextBox();
            this.txtEmphiricalConstanta = new System.Windows.Forms.TextBox();
            this.txtEmphiricalConstantb = new System.Windows.Forms.TextBox();
            this.txtRockTransFactor = new System.Windows.Forms.TextBox();
            this.lblR = new System.Windows.Forms.Label();
            this.lblA = new System.Windows.Forms.Label();
            this.lblB = new System.Windows.Forms.Label();
            this.lblK = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.cmdClose = new System.Windows.Forms.Button();
            this.cmdSave = new System.Windows.Forms.Button();
            this.cmdModify = new System.Windows.Forms.Button();
            this.cmdAdd = new System.Windows.Forms.Button();
            this.txtLengthOfCharge = new System.Windows.Forms.TextBox();
            this.txtChargeConcentPerUnitLength = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox7.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.label2);
            this.groupBox7.Controls.Add(this.label1);
            this.groupBox7.Controls.Add(this.txtChargeConcentPerUnitLength);
            this.groupBox7.Controls.Add(this.txtLengthOfCharge);
            this.groupBox7.Controls.Add(this.txtDistanceFromBlastToMeasurePoint);
            this.groupBox7.Controls.Add(this.txtEmphiricalConstanta);
            this.groupBox7.Controls.Add(this.txtEmphiricalConstantb);
            this.groupBox7.Controls.Add(this.txtRockTransFactor);
            this.groupBox7.Controls.Add(this.lblR);
            this.groupBox7.Controls.Add(this.lblA);
            this.groupBox7.Controls.Add(this.lblB);
            this.groupBox7.Controls.Add(this.lblK);
            this.groupBox7.Location = new System.Drawing.Point(12, 12);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(410, 196);
            this.groupBox7.TabIndex = 6;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Emphirical Constants";
            // 
            // txtDistanceFromBlastToMeasurePoint
            // 
            this.txtDistanceFromBlastToMeasurePoint.Location = new System.Drawing.Point(242, 99);
            this.txtDistanceFromBlastToMeasurePoint.Name = "txtDistanceFromBlastToMeasurePoint";
            this.txtDistanceFromBlastToMeasurePoint.Size = new System.Drawing.Size(133, 20);
            this.txtDistanceFromBlastToMeasurePoint.TabIndex = 7;
            // 
            // txtEmphiricalConstanta
            // 
            this.txtEmphiricalConstanta.Location = new System.Drawing.Point(243, 73);
            this.txtEmphiricalConstanta.Name = "txtEmphiricalConstanta";
            this.txtEmphiricalConstanta.Size = new System.Drawing.Size(133, 20);
            this.txtEmphiricalConstanta.TabIndex = 6;
            // 
            // txtEmphiricalConstantb
            // 
            this.txtEmphiricalConstantb.Location = new System.Drawing.Point(243, 47);
            this.txtEmphiricalConstantb.Name = "txtEmphiricalConstantb";
            this.txtEmphiricalConstantb.Size = new System.Drawing.Size(133, 20);
            this.txtEmphiricalConstantb.TabIndex = 5;
            // 
            // txtRockTransFactor
            // 
            this.txtRockTransFactor.Location = new System.Drawing.Point(243, 21);
            this.txtRockTransFactor.Name = "txtRockTransFactor";
            this.txtRockTransFactor.Size = new System.Drawing.Size(133, 20);
            this.txtRockTransFactor.TabIndex = 4;
            // 
            // lblR
            // 
            this.lblR.AutoSize = true;
            this.lblR.Location = new System.Drawing.Point(9, 106);
            this.lblR.Name = "lblR";
            this.lblR.Size = new System.Drawing.Size(218, 13);
            this.lblR.TabIndex = 3;
            this.lblR.Text = "distance from blast to measuring point (m) R=";
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(8, 76);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(115, 13);
            this.lblA.TabIndex = 2;
            this.lblA.Text = "Emphirical Constant a=";
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Location = new System.Drawing.Point(9, 47);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(115, 13);
            this.lblB.TabIndex = 1;
            this.lblB.Text = "Emphirical Constant b=";
            // 
            // lblK
            // 
            this.lblK.AutoSize = true;
            this.lblK.Location = new System.Drawing.Point(9, 24);
            this.lblK.Name = "lblK";
            this.lblK.Size = new System.Drawing.Size(145, 13);
            this.lblK.TabIndex = 0;
            this.lblK.Text = "Rock Transmission Factor k=";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmdCancel);
            this.groupBox1.Controls.Add(this.cmdClose);
            this.groupBox1.Controls.Add(this.cmdSave);
            this.groupBox1.Controls.Add(this.cmdModify);
            this.groupBox1.Controls.Add(this.cmdAdd);
            this.groupBox1.Location = new System.Drawing.Point(12, 214);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(410, 56);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // cmdCancel
            // 
            this.cmdCancel.Location = new System.Drawing.Point(243, 19);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(73, 31);
            this.cmdCancel.TabIndex = 4;
            this.cmdCancel.Text = "Cancel";
            this.cmdCancel.UseVisualStyleBackColor = true;
            // 
            // cmdClose
            // 
            this.cmdClose.Location = new System.Drawing.Point(331, 19);
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.Size = new System.Drawing.Size(73, 31);
            this.cmdClose.TabIndex = 3;
            this.cmdClose.Text = "Close";
            this.cmdClose.UseVisualStyleBackColor = true;
            this.cmdClose.Click += new System.EventHandler(this.cmdClose_Click);
            // 
            // cmdSave
            // 
            this.cmdSave.Location = new System.Drawing.Point(164, 19);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(73, 31);
            this.cmdSave.TabIndex = 2;
            this.cmdSave.Text = "Save";
            this.cmdSave.UseVisualStyleBackColor = true;
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // cmdModify
            // 
            this.cmdModify.Location = new System.Drawing.Point(85, 19);
            this.cmdModify.Name = "cmdModify";
            this.cmdModify.Size = new System.Drawing.Size(73, 31);
            this.cmdModify.TabIndex = 1;
            this.cmdModify.Text = "Modify";
            this.cmdModify.UseVisualStyleBackColor = true;
            // 
            // cmdAdd
            // 
            this.cmdAdd.Location = new System.Drawing.Point(6, 19);
            this.cmdAdd.Name = "cmdAdd";
            this.cmdAdd.Size = new System.Drawing.Size(73, 31);
            this.cmdAdd.TabIndex = 0;
            this.cmdAdd.Text = "Add";
            this.cmdAdd.UseVisualStyleBackColor = true;
            // 
            // txtLengthOfCharge
            // 
            this.txtLengthOfCharge.Location = new System.Drawing.Point(243, 125);
            this.txtLengthOfCharge.Name = "txtLengthOfCharge";
            this.txtLengthOfCharge.Size = new System.Drawing.Size(133, 20);
            this.txtLengthOfCharge.TabIndex = 8;
            // 
            // txtChargeConcentPerUnitLength
            // 
            this.txtChargeConcentPerUnitLength.Location = new System.Drawing.Point(243, 151);
            this.txtChargeConcentPerUnitLength.Name = "txtChargeConcentPerUnitLength";
            this.txtChargeConcentPerUnitLength.Size = new System.Drawing.Size(133, 20);
            this.txtChargeConcentPerUnitLength.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "length of charge (m) L=";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(227, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "charge concentration per unit length (kg/m) q=";
            // 
            // frmEmphiricalConstants
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 272);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEmphiricalConstants";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmEmphiricalConstants";
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label lblR;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.Label lblK;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button cmdCancel;
        private System.Windows.Forms.Button cmdClose;
        private System.Windows.Forms.Button cmdSave;
        private System.Windows.Forms.Button cmdModify;
        private System.Windows.Forms.Button cmdAdd;
        private System.Windows.Forms.TextBox txtDistanceFromBlastToMeasurePoint;
        private System.Windows.Forms.TextBox txtEmphiricalConstanta;
        private System.Windows.Forms.TextBox txtEmphiricalConstantb;
        private System.Windows.Forms.TextBox txtRockTransFactor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtChargeConcentPerUnitLength;
        private System.Windows.Forms.TextBox txtLengthOfCharge;

    }
}