namespace CalculatorApplication
{
    partial class FrmCalculator
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
            this.label1 = new System.Windows.Forms.Label();
            this.FirstNum = new System.Windows.Forms.Label();
            this.SecondNum = new System.Windows.Forms.Label();
            this.txtBoxInout1 = new System.Windows.Forms.TextBox();
            this.txtBoxInput2 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.lblDisplayTotal = new System.Windows.Forms.Label();
            this.btnEqual = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // FirstNum
            // 
            this.FirstNum.AutoSize = true;
            this.FirstNum.Font = new System.Drawing.Font("Carlito", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstNum.Location = new System.Drawing.Point(20, 25);
            this.FirstNum.Name = "FirstNum";
            this.FirstNum.Size = new System.Drawing.Size(143, 19);
            this.FirstNum.TabIndex = 1;
            this.FirstNum.Text = "Enter First Number:";
            // 
            // SecondNum
            // 
            this.SecondNum.AutoSize = true;
            this.SecondNum.Font = new System.Drawing.Font("Carlito", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SecondNum.Location = new System.Drawing.Point(20, 98);
            this.SecondNum.Name = "SecondNum";
            this.SecondNum.Size = new System.Drawing.Size(164, 19);
            this.SecondNum.TabIndex = 2;
            this.SecondNum.Text = "Enter Second Number:";
            // 
            // txtBoxInout1
            // 
            this.txtBoxInout1.BackColor = System.Drawing.Color.Honeydew;
            this.txtBoxInout1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxInout1.Location = new System.Drawing.Point(205, 22);
            this.txtBoxInout1.Name = "txtBoxInout1";
            this.txtBoxInout1.Size = new System.Drawing.Size(130, 26);
            this.txtBoxInout1.TabIndex = 3;
            // 
            // txtBoxInput2
            // 
            this.txtBoxInput2.BackColor = System.Drawing.Color.Honeydew;
            this.txtBoxInput2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxInput2.Location = new System.Drawing.Point(205, 91);
            this.txtBoxInput2.Name = "txtBoxInput2";
            this.txtBoxInput2.Size = new System.Drawing.Size(130, 26);
            this.txtBoxInput2.TabIndex = 4;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.Honeydew;
            this.comboBox1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.comboBox1.Location = new System.Drawing.Point(235, 54);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(72, 27);
            this.comboBox1.TabIndex = 5;
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.Font = new System.Drawing.Font("Carlito", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswer.Location = new System.Drawing.Point(121, 132);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(59, 18);
            this.lblAnswer.TabIndex = 6;
            this.lblAnswer.Text = "Answer:";
            // 
            // lblDisplayTotal
            // 
            this.lblDisplayTotal.AutoSize = true;
            this.lblDisplayTotal.Font = new System.Drawing.Font("Carlito", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplayTotal.Location = new System.Drawing.Point(201, 131);
            this.lblDisplayTotal.Name = "lblDisplayTotal";
            this.lblDisplayTotal.Size = new System.Drawing.Size(17, 19);
            this.lblDisplayTotal.TabIndex = 7;
            this.lblDisplayTotal.Text = "0";
            // 
            // btnEqual
            // 
            this.btnEqual.BackColor = System.Drawing.Color.Honeydew;
            this.btnEqual.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEqual.Location = new System.Drawing.Point(223, 158);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.Size = new System.Drawing.Size(100, 23);
            this.btnEqual.TabIndex = 8;
            this.btnEqual.Text = "Calculate";
            this.btnEqual.UseVisualStyleBackColor = false;
            // 
            // FrmCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(363, 193);
            this.Controls.Add(this.btnEqual);
            this.Controls.Add(this.lblDisplayTotal);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txtBoxInput2);
            this.Controls.Add(this.txtBoxInout1);
            this.Controls.Add(this.SecondNum);
            this.Controls.Add(this.FirstNum);
            this.Controls.Add(this.label1);
            this.Name = "FrmCalculator";
            this.Text = "FrmCalculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label FirstNum;
        private System.Windows.Forms.Label SecondNum;
        private System.Windows.Forms.TextBox txtBoxInout1;
        private System.Windows.Forms.TextBox txtBoxInput2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.Label lblDisplayTotal;
        private System.Windows.Forms.Button btnEqual;
    }
}

