namespace Calculator
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
            this.number7 = new System.Windows.Forms.Button();
            this.CancelAll = new System.Windows.Forms.Button();
            this.Multiply = new System.Windows.Forms.Button();
            this.Minus = new System.Windows.Forms.Button();
            this.Addition = new System.Windows.Forms.Button();
            this.number0 = new System.Windows.Forms.Button();
            this.number3 = new System.Windows.Forms.Button();
            this.Equal = new System.Windows.Forms.Button();
            this.number2 = new System.Windows.Forms.Button();
            this.number1 = new System.Windows.Forms.Button();
            this.number6 = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.number5 = new System.Windows.Forms.Button();
            this.number4 = new System.Windows.Forms.Button();
            this.Division = new System.Windows.Forms.Button();
            this.number9 = new System.Windows.Forms.Button();
            this.number8 = new System.Windows.Forms.Button();
            this.dot = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.TextBox();
            this.lcurrentOp = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // number7
            // 
            this.number7.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.number7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.number7.ForeColor = System.Drawing.SystemColors.Desktop;
            this.number7.Location = new System.Drawing.Point(22, 136);
            this.number7.Name = "number7";
            this.number7.Size = new System.Drawing.Size(86, 60);
            this.number7.TabIndex = 0;
            this.number7.Text = "7";
            this.number7.UseVisualStyleBackColor = false;
            this.number7.BackColorChanged += new System.EventHandler(this.Form1_Load);
            this.number7.Click += new System.EventHandler(this.n_Click);
            // 
            // CancelAll
            // 
            this.CancelAll.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.CancelAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelAll.ForeColor = System.Drawing.SystemColors.Desktop;
            this.CancelAll.Location = new System.Drawing.Point(390, 136);
            this.CancelAll.Name = "CancelAll";
            this.CancelAll.Size = new System.Drawing.Size(86, 60);
            this.CancelAll.TabIndex = 1;
            this.CancelAll.Text = "CE";
            this.CancelAll.UseVisualStyleBackColor = false;
            this.CancelAll.BackColorChanged += new System.EventHandler(this.Form1_Load);
            this.CancelAll.Click += new System.EventHandler(this.nce_Click);
            // 
            // Multiply
            // 
            this.Multiply.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Multiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Multiply.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Multiply.Location = new System.Drawing.Point(298, 202);
            this.Multiply.Name = "Multiply";
            this.Multiply.Size = new System.Drawing.Size(86, 60);
            this.Multiply.TabIndex = 2;
            this.Multiply.Text = "*";
            this.Multiply.UseVisualStyleBackColor = false;
            this.Multiply.BackColorChanged += new System.EventHandler(this.Form1_Load);
            this.Multiply.Click += new System.EventHandler(this.op_Click);
            // 
            // Minus
            // 
            this.Minus.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Minus.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Minus.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Minus.Location = new System.Drawing.Point(298, 274);
            this.Minus.Name = "Minus";
            this.Minus.Size = new System.Drawing.Size(86, 60);
            this.Minus.TabIndex = 3;
            this.Minus.Text = "-";
            this.Minus.UseVisualStyleBackColor = false;
            this.Minus.BackColorChanged += new System.EventHandler(this.Form1_Load);
            this.Minus.Click += new System.EventHandler(this.op_Click);
            // 
            // Addition
            // 
            this.Addition.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Addition.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Addition.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Addition.Location = new System.Drawing.Point(298, 345);
            this.Addition.Name = "Addition";
            this.Addition.Size = new System.Drawing.Size(86, 60);
            this.Addition.TabIndex = 4;
            this.Addition.Text = "+";
            this.Addition.UseVisualStyleBackColor = false;
            this.Addition.BackColorChanged += new System.EventHandler(this.Form1_Load);
            this.Addition.Click += new System.EventHandler(this.op_Click);
            // 
            // number0
            // 
            this.number0.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.number0.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.number0.ForeColor = System.Drawing.SystemColors.Desktop;
            this.number0.Location = new System.Drawing.Point(22, 345);
            this.number0.Name = "number0";
            this.number0.Size = new System.Drawing.Size(178, 60);
            this.number0.TabIndex = 5;
            this.number0.Text = "0";
            this.number0.UseVisualStyleBackColor = false;
            this.number0.BackColorChanged += new System.EventHandler(this.Form1_Load);
            this.number0.Click += new System.EventHandler(this.n_Click);
            // 
            // number3
            // 
            this.number3.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.number3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.number3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.number3.Location = new System.Drawing.Point(206, 274);
            this.number3.Name = "number3";
            this.number3.Size = new System.Drawing.Size(86, 60);
            this.number3.TabIndex = 6;
            this.number3.Text = "3";
            this.number3.UseVisualStyleBackColor = false;
            this.number3.BackColorChanged += new System.EventHandler(this.Form1_Load);
            this.number3.Click += new System.EventHandler(this.n_Click);
            // 
            // Equal
            // 
            this.Equal.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Equal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Equal.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Equal.Location = new System.Drawing.Point(390, 274);
            this.Equal.Name = "Equal";
            this.Equal.Size = new System.Drawing.Size(86, 132);
            this.Equal.TabIndex = 7;
            this.Equal.Text = "=";
            this.Equal.UseVisualStyleBackColor = false;
            this.Equal.BackColorChanged += new System.EventHandler(this.Form1_Load);
            this.Equal.Click += new System.EventHandler(this.nequal_Click);
            // 
            // number2
            // 
            this.number2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.number2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.number2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.number2.Location = new System.Drawing.Point(114, 274);
            this.number2.Name = "number2";
            this.number2.Size = new System.Drawing.Size(86, 60);
            this.number2.TabIndex = 8;
            this.number2.Text = "2";
            this.number2.UseVisualStyleBackColor = false;
            this.number2.BackColorChanged += new System.EventHandler(this.Form1_Load);
            this.number2.Click += new System.EventHandler(this.n_Click);
            // 
            // number1
            // 
            this.number1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.number1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.number1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.number1.Location = new System.Drawing.Point(22, 274);
            this.number1.Name = "number1";
            this.number1.Size = new System.Drawing.Size(86, 60);
            this.number1.TabIndex = 9;
            this.number1.Text = "1";
            this.number1.UseVisualStyleBackColor = false;
            this.number1.BackColorChanged += new System.EventHandler(this.Form1_Load);
            this.number1.Click += new System.EventHandler(this.n_Click);
            // 
            // number6
            // 
            this.number6.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.number6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.number6.ForeColor = System.Drawing.SystemColors.Desktop;
            this.number6.Location = new System.Drawing.Point(206, 202);
            this.number6.Name = "number6";
            this.number6.Size = new System.Drawing.Size(86, 60);
            this.number6.TabIndex = 10;
            this.number6.Text = "6";
            this.number6.UseVisualStyleBackColor = false;
            this.number6.BackColorChanged += new System.EventHandler(this.Form1_Load);
            this.number6.Click += new System.EventHandler(this.n_Click);
            // 
            // Cancel
            // 
            this.Cancel.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancel.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Cancel.Location = new System.Drawing.Point(390, 202);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(86, 60);
            this.Cancel.TabIndex = 11;
            this.Cancel.Text = "C";
            this.Cancel.UseVisualStyleBackColor = false;
            this.Cancel.BackColorChanged += new System.EventHandler(this.Form1_Load);
            this.Cancel.Click += new System.EventHandler(this.nc_Click);
            // 
            // number5
            // 
            this.number5.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.number5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.number5.ForeColor = System.Drawing.SystemColors.Desktop;
            this.number5.Location = new System.Drawing.Point(114, 202);
            this.number5.Name = "number5";
            this.number5.Size = new System.Drawing.Size(86, 60);
            this.number5.TabIndex = 12;
            this.number5.Text = "5";
            this.number5.UseVisualStyleBackColor = false;
            this.number5.BackColorChanged += new System.EventHandler(this.Form1_Load);
            this.number5.Click += new System.EventHandler(this.n_Click);
            // 
            // number4
            // 
            this.number4.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.number4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.number4.ForeColor = System.Drawing.SystemColors.Desktop;
            this.number4.Location = new System.Drawing.Point(22, 202);
            this.number4.Name = "number4";
            this.number4.Size = new System.Drawing.Size(86, 60);
            this.number4.TabIndex = 13;
            this.number4.Text = "4";
            this.number4.UseVisualStyleBackColor = false;
            this.number4.BackColorChanged += new System.EventHandler(this.Form1_Load);
            this.number4.Click += new System.EventHandler(this.n_Click);
            // 
            // Division
            // 
            this.Division.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Division.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Division.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Division.Location = new System.Drawing.Point(298, 136);
            this.Division.Name = "Division";
            this.Division.Size = new System.Drawing.Size(86, 60);
            this.Division.TabIndex = 14;
            this.Division.Text = "/";
            this.Division.UseVisualStyleBackColor = false;
            this.Division.BackColorChanged += new System.EventHandler(this.Form1_Load);
            this.Division.Click += new System.EventHandler(this.op_Click);
            // 
            // number9
            // 
            this.number9.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.number9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.number9.ForeColor = System.Drawing.SystemColors.Desktop;
            this.number9.Location = new System.Drawing.Point(206, 136);
            this.number9.Name = "number9";
            this.number9.Size = new System.Drawing.Size(86, 60);
            this.number9.TabIndex = 15;
            this.number9.Text = "9";
            this.number9.UseVisualStyleBackColor = false;
            this.number9.BackColorChanged += new System.EventHandler(this.Form1_Load);
            this.number9.Click += new System.EventHandler(this.n_Click);
            // 
            // number8
            // 
            this.number8.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.number8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.number8.ForeColor = System.Drawing.SystemColors.Desktop;
            this.number8.Location = new System.Drawing.Point(114, 136);
            this.number8.Name = "number8";
            this.number8.Size = new System.Drawing.Size(86, 60);
            this.number8.TabIndex = 16;
            this.number8.Text = "8";
            this.number8.UseVisualStyleBackColor = false;
            this.number8.BackColorChanged += new System.EventHandler(this.Form1_Load);
            this.number8.Click += new System.EventHandler(this.n_Click);
            // 
            // dot
            // 
            this.dot.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.dot.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dot.ForeColor = System.Drawing.SystemColors.Desktop;
            this.dot.Location = new System.Drawing.Point(206, 345);
            this.dot.Name = "dot";
            this.dot.Size = new System.Drawing.Size(86, 60);
            this.dot.TabIndex = 17;
            this.dot.Text = ".";
            this.dot.UseVisualStyleBackColor = false;
            this.dot.BackColorChanged += new System.EventHandler(this.Form1_Load);
            this.dot.Click += new System.EventHandler(this.n_Click);
            // 
            // textBox
            // 
            this.textBox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox.Location = new System.Drawing.Point(22, 73);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(454, 44);
            this.textBox.TabIndex = 18;
            this.textBox.Text = "0";
            this.textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lcurrentOp
            // 
            this.lcurrentOp.AutoSize = true;
            this.lcurrentOp.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lcurrentOp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lcurrentOp.Location = new System.Drawing.Point(22, 28);
            this.lcurrentOp.Name = "lcurrentOp";
            this.lcurrentOp.Size = new System.Drawing.Size(0, 32);
            this.lcurrentOp.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(489, 418);
            this.Controls.Add(this.lcurrentOp);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.dot);
            this.Controls.Add(this.number8);
            this.Controls.Add(this.number9);
            this.Controls.Add(this.Division);
            this.Controls.Add(this.number4);
            this.Controls.Add(this.number5);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.number6);
            this.Controls.Add(this.number1);
            this.Controls.Add(this.number2);
            this.Controls.Add(this.Equal);
            this.Controls.Add(this.number3);
            this.Controls.Add(this.number0);
            this.Controls.Add(this.Addition);
            this.Controls.Add(this.Minus);
            this.Controls.Add(this.Multiply);
            this.Controls.Add(this.CancelAll);
            this.Controls.Add(this.number7);
            this.ForeColor = System.Drawing.SystemColors.GrayText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button number7;
        private System.Windows.Forms.Button CancelAll;
        private System.Windows.Forms.Button Multiply;
        private System.Windows.Forms.Button Minus;
        private System.Windows.Forms.Button Addition;
        private System.Windows.Forms.Button number0;
        private System.Windows.Forms.Button number3;
        private System.Windows.Forms.Button Equal;
        private System.Windows.Forms.Button number2;
        private System.Windows.Forms.Button number1;
        private System.Windows.Forms.Button number6;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button number5;
        private System.Windows.Forms.Button number4;
        private System.Windows.Forms.Button Division;
        private System.Windows.Forms.Button number9;
        private System.Windows.Forms.Button number8;
        private System.Windows.Forms.Button dot;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Label lcurrentOp;
    }
}

