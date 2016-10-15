namespace WindowsFormsApplication2
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelPlus = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.labelEquals = new System.Windows.Forms.Label();
            this.textResult = new System.Windows.Forms.TextBox();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // labelPlus
            // 
            this.labelPlus.AutoSize = true;
            this.labelPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPlus.Location = new System.Drawing.Point(119, 47);
            this.labelPlus.Name = "labelPlus";
            this.labelPlus.Size = new System.Drawing.Size(25, 26);
            this.labelPlus.TabIndex = 1;
            this.labelPlus.Text = "+";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 83);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 2;
            // 
            // labelEquals
            // 
            this.labelEquals.AutoSize = true;
            this.labelEquals.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelEquals.Location = new System.Drawing.Point(54, 121);
            this.labelEquals.Name = "labelEquals";
            this.labelEquals.Size = new System.Drawing.Size(25, 26);
            this.labelEquals.TabIndex = 3;
            this.labelEquals.Text = "=";
            // 
            // textResult
            // 
            this.textResult.Location = new System.Drawing.Point(12, 151);
            this.textResult.Name = "textResult";
            this.textResult.Size = new System.Drawing.Size(100, 20);
            this.textResult.TabIndex = 4;
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCalculate.Location = new System.Drawing.Point(23, 199);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(109, 29);
            this.buttonCalculate.TabIndex = 5;
            this.buttonCalculate.Text = "Calculate";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 240);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.textResult);
            this.Controls.Add(this.labelEquals);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.labelPlus);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Summator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelPlus;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label labelEquals;
        private System.Windows.Forms.TextBox textResult;
        private System.Windows.Forms.Button buttonCalculate;
    }
}

