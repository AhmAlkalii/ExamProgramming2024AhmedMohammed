namespace ExpenseManager
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
            this.button1 = new System.Windows.Forms.Button();
            this.pathbox = new System.Windows.Forms.TextBox();
            this.outputbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(674, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 43);
            this.button1.TabIndex = 0;
            this.button1.Text = "Read";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pathbox
            // 
            this.pathbox.Location = new System.Drawing.Point(64, 24);
            this.pathbox.Name = "pathbox";
            this.pathbox.Size = new System.Drawing.Size(604, 26);
            this.pathbox.TabIndex = 1;
            this.pathbox.Text = "C:\\Users\\E7490\\OneDrive\\Desktop\\Expense.txt";
            // 
            // outputbox
            // 
            this.outputbox.BackColor = System.Drawing.SystemColors.Menu;
            this.outputbox.Location = new System.Drawing.Point(12, 76);
            this.outputbox.Multiline = true;
            this.outputbox.Name = "outputbox";
            this.outputbox.Size = new System.Drawing.Size(658, 307);
            this.outputbox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Path:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(676, 91);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 39);
            this.button2.TabIndex = 4;
            this.button2.Text = "Total";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.outputbox);
            this.Controls.Add(this.pathbox);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox pathbox;
        private System.Windows.Forms.TextBox outputbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
    }
}

