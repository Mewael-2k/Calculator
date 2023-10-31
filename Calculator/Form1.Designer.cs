namespace Calculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtTotal = new TextBox();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn8 = new Button();
            btn6 = new Button();
            btn9 = new Button();
            btn0 = new Button();
            btn7 = new Button();
            btnPlus = new Button();
            btnMin = new Button();
            btnMul = new Button();
            btndiv = new Button();
            btnClear = new Button();
            btnEql = new Button();
            SuspendLayout();
            // 
            // txtTotal
            // 
            txtTotal.BackColor = Color.Orange;
            txtTotal.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            txtTotal.Location = new Point(24, 11);
            txtTotal.Margin = new Padding(4, 2, 4, 2);
            txtTotal.Multiline = true;
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(782, 134);
            txtTotal.TabIndex = 2;
            txtTotal.TextChanged += textBox1_TextChanged_1;
            // 
            // btn1
            // 
            btn1.BackColor = Color.Orange;
            btn1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn1.Location = new Point(20, 205);
            btn1.Margin = new Padding(4, 2, 4, 2);
            btn1.Name = "btn1";
            btn1.Size = new Size(121, 141);
            btn1.TabIndex = 3;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = false;
            btn1.Click += button1_Click;
            // 
            // btn2
            // 
            btn2.BackColor = Color.Orange;
            btn2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn2.Location = new Point(191, 205);
            btn2.Margin = new Padding(4, 2, 4, 2);
            btn2.Name = "btn2";
            btn2.Size = new Size(121, 141);
            btn2.TabIndex = 4;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = false;
            btn2.Click += btn2_Click;
            // 
            // btn3
            // 
            btn3.BackColor = Color.Orange;
            btn3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn3.Location = new Point(358, 205);
            btn3.Margin = new Padding(4, 2, 4, 2);
            btn3.Name = "btn3";
            btn3.Size = new Size(121, 141);
            btn3.TabIndex = 5;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = false;
            btn3.Click += btn3_Click;
            // 
            // btn4
            // 
            btn4.BackColor = Color.Orange;
            btn4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn4.Location = new Point(518, 205);
            btn4.Margin = new Padding(4, 2, 4, 2);
            btn4.Name = "btn4";
            btn4.Size = new Size(121, 141);
            btn4.TabIndex = 6;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = false;
            btn4.Click += btn4_Click;
            // 
            // btn5
            // 
            btn5.BackColor = Color.Orange;
            btn5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn5.Location = new Point(685, 205);
            btn5.Margin = new Padding(4, 2, 4, 2);
            btn5.Name = "btn5";
            btn5.Size = new Size(121, 141);
            btn5.TabIndex = 7;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = false;
            btn5.Click += btn5_Click;
            // 
            // btn8
            // 
            btn8.BackColor = Color.Orange;
            btn8.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn8.Location = new Point(358, 375);
            btn8.Margin = new Padding(4, 2, 4, 2);
            btn8.Name = "btn8";
            btn8.Size = new Size(121, 141);
            btn8.TabIndex = 8;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = false;
            btn8.Click += btn8_Click;
            // 
            // btn6
            // 
            btn6.BackColor = Color.Orange;
            btn6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn6.Location = new Point(20, 375);
            btn6.Margin = new Padding(4, 2, 4, 2);
            btn6.Name = "btn6";
            btn6.Size = new Size(121, 141);
            btn6.TabIndex = 9;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = false;
            btn6.Click += btn6_Click;
            // 
            // btn9
            // 
            btn9.BackColor = Color.Orange;
            btn9.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn9.Location = new Point(518, 375);
            btn9.Margin = new Padding(4, 2, 4, 2);
            btn9.Name = "btn9";
            btn9.Size = new Size(121, 141);
            btn9.TabIndex = 10;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = false;
            btn9.Click += button8_Click;
            // 
            // btn0
            // 
            btn0.BackColor = Color.Orange;
            btn0.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn0.Location = new Point(685, 375);
            btn0.Margin = new Padding(4, 2, 4, 2);
            btn0.Name = "btn0";
            btn0.Size = new Size(121, 141);
            btn0.TabIndex = 11;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = false;
            btn0.Click += btn0_Click;
            // 
            // btn7
            // 
            btn7.BackColor = Color.Orange;
            btn7.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn7.Location = new Point(191, 375);
            btn7.Margin = new Padding(4, 2, 4, 2);
            btn7.Name = "btn7";
            btn7.Size = new Size(121, 141);
            btn7.TabIndex = 12;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = false;
            btn7.Click += btn7_Click;
            // 
            // btnPlus
            // 
            btnPlus.BackColor = Color.Orange;
            btnPlus.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnPlus.Location = new Point(20, 548);
            btnPlus.Margin = new Padding(4, 2, 4, 2);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(121, 141);
            btnPlus.TabIndex = 13;
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = false;
            btnPlus.Click += btnPlus_Click;
            // 
            // btnMin
            // 
            btnMin.BackColor = Color.Orange;
            btnMin.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnMin.Location = new Point(191, 548);
            btnMin.Margin = new Padding(4, 2, 4, 2);
            btnMin.Name = "btnMin";
            btnMin.Size = new Size(121, 141);
            btnMin.TabIndex = 14;
            btnMin.Text = "-";
            btnMin.UseVisualStyleBackColor = false;
            btnMin.Click += btnMin_Click;
            // 
            // btnMul
            // 
            btnMul.BackColor = Color.Orange;
            btnMul.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnMul.Location = new Point(358, 548);
            btnMul.Margin = new Padding(4, 2, 4, 2);
            btnMul.Name = "btnMul";
            btnMul.Size = new Size(121, 141);
            btnMul.TabIndex = 15;
            btnMul.Text = "*";
            btnMul.UseVisualStyleBackColor = false;
            btnMul.Click += btnMul_Click;
            // 
            // btndiv
            // 
            btndiv.BackColor = Color.Orange;
            btndiv.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btndiv.Location = new Point(518, 548);
            btndiv.Margin = new Padding(4, 2, 4, 2);
            btndiv.Name = "btndiv";
            btndiv.Size = new Size(121, 141);
            btndiv.TabIndex = 16;
            btndiv.Text = "/";
            btndiv.UseVisualStyleBackColor = false;
            btndiv.Click += btndiv_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Orange;
            btnClear.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnClear.Location = new Point(685, 548);
            btnClear.Margin = new Padding(4, 2, 4, 2);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(121, 141);
            btnClear.TabIndex = 17;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnEql
            // 
            btnEql.BackColor = Color.Orange;
            btnEql.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnEql.Location = new Point(20, 730);
            btnEql.Margin = new Padding(4, 2, 4, 2);
            btnEql.Name = "btnEql";
            btnEql.Size = new Size(786, 141);
            btnEql.TabIndex = 18;
            btnEql.Text = "=";
            btnEql.UseVisualStyleBackColor = false;
            btnEql.Click += btnEql_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(826, 924);
            Controls.Add(btnEql);
            Controls.Add(btnClear);
            Controls.Add(btndiv);
            Controls.Add(btnMul);
            Controls.Add(btnMin);
            Controls.Add(btnPlus);
            Controls.Add(btn7);
            Controls.Add(btn0);
            Controls.Add(btn9);
            Controls.Add(btn6);
            Controls.Add(btn8);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(txtTotal);
            Margin = new Padding(4, 2, 4, 2);
            Name = "Form1";
            Text = "Mewael's Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTotal;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btn4;
        private Button btn5;
        private Button btn8;
        private Button btn6;
        private Button btn9;
        private Button btn0;
        private Button btn7;
        private Button btnPlus;
        private Button btnMin;
        private Button btnMul;
        private Button btndiv;
        private Button btnClear;
        private Button btnEql;
    }
}