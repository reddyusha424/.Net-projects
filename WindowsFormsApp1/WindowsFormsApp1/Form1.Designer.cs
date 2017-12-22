namespace WindowsFormsApp1
{
    partial class calculator
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
            this.tbtSecondNumber = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSub = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btnDivision = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblCalcApp = new System.Windows.Forms.Label();
            this.tbtFirstNumber = new System.Windows.Forms.TextBox();
            this.lblFirstNumber = new System.Windows.Forms.Label();
            this.lblSecondNumber = new System.Windows.Forms.Label();
            this.tbtResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbtSecondNumber
            // 
            this.tbtSecondNumber.Location = new System.Drawing.Point(280, 138);
            this.tbtSecondNumber.Name = "tbtSecondNumber";
            this.tbtSecondNumber.Size = new System.Drawing.Size(100, 22);
            this.tbtSecondNumber.TabIndex = 5;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnAdd.ForeColor = System.Drawing.Color.Red;
            this.btnAdd.Location = new System.Drawing.Point(101, 253);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 31);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Addition";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSub
            // 
            this.btnSub.Location = new System.Drawing.Point(249, 253);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(92, 31);
            this.btnSub.TabIndex = 8;
            this.btnSub.Text = "Subtraction";
            this.btnSub.UseVisualStyleBackColor = true;
            this.btnSub.Click += new System.EventHandler(this.btnSub_Click);
            // 
            // btnMultiply
            // 
            this.btnMultiply.Location = new System.Drawing.Point(101, 349);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(75, 33);
            this.btnMultiply.TabIndex = 9;
            this.btnMultiply.Text = "Multiply";
            this.btnMultiply.UseVisualStyleBackColor = true;
            this.btnMultiply.Click += new System.EventHandler(this.btnMultiply_Click);
            // 
            // btnDivision
            // 
            this.btnDivision.Location = new System.Drawing.Point(249, 349);
            this.btnDivision.Name = "btnDivision";
            this.btnDivision.Size = new System.Drawing.Size(75, 33);
            this.btnDivision.TabIndex = 10;
            this.btnDivision.Text = "Division";
            this.btnDivision.UseVisualStyleBackColor = true;
            this.btnDivision.Click += new System.EventHandler(this.btnDivision_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(467, 253);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 31);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(467, 349);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 33);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblCalcApp
            // 
            this.lblCalcApp.AutoSize = true;
            this.lblCalcApp.Location = new System.Drawing.Point(311, 26);
            this.lblCalcApp.Name = "lblCalcApp";
            this.lblCalcApp.Size = new System.Drawing.Size(144, 17);
            this.lblCalcApp.TabIndex = 13;
            this.lblCalcApp.Text = "Calculator Application";
            this.lblCalcApp.Click += new System.EventHandler(this.label1_Click);
            // 
            // tbtFirstNumber
            // 
            this.tbtFirstNumber.Location = new System.Drawing.Point(280, 78);
            this.tbtFirstNumber.Name = "tbtFirstNumber";
            this.tbtFirstNumber.Size = new System.Drawing.Size(100, 22);
            this.tbtFirstNumber.TabIndex = 14;
            // 
            // lblFirstNumber
            // 
            this.lblFirstNumber.AutoSize = true;
            this.lblFirstNumber.Location = new System.Drawing.Point(84, 83);
            this.lblFirstNumber.Name = "lblFirstNumber";
            this.lblFirstNumber.Size = new System.Drawing.Size(89, 17);
            this.lblFirstNumber.TabIndex = 15;
            this.lblFirstNumber.Text = "First Number";
            // 
            // lblSecondNumber
            // 
            this.lblSecondNumber.AutoSize = true;
            this.lblSecondNumber.Location = new System.Drawing.Point(84, 143);
            this.lblSecondNumber.Name = "lblSecondNumber";
            this.lblSecondNumber.Size = new System.Drawing.Size(110, 17);
            this.lblSecondNumber.TabIndex = 16;
            this.lblSecondNumber.Text = "Second Number";
            // 
            // tbtResult
            // 
            this.tbtResult.Location = new System.Drawing.Point(453, 108);
            this.tbtResult.Name = "tbtResult";
            this.tbtResult.Size = new System.Drawing.Size(100, 22);
            this.tbtResult.TabIndex = 17;
            // 
            // calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(925, 452);
            this.Controls.Add(this.tbtResult);
            this.Controls.Add(this.lblSecondNumber);
            this.Controls.Add(this.lblFirstNumber);
            this.Controls.Add(this.tbtFirstNumber);
            this.Controls.Add(this.lblCalcApp);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDivision);
            this.Controls.Add(this.btnMultiply);
            this.Controls.Add(this.btnSub);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tbtSecondNumber);
            this.Name = "calculator";
            this.Text = "calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbtSecondNumber;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSub;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Button btnDivision;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblCalcApp;
        private System.Windows.Forms.TextBox tbtFirstNumber;
        private System.Windows.Forms.Label lblFirstNumber;
        private System.Windows.Forms.Label lblSecondNumber;
        private System.Windows.Forms.TextBox tbtResult;
    }
}

