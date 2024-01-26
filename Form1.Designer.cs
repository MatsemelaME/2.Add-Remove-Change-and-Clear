namespace _2.Add_Remove_Change_and_Clear
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
            this.btnADD = new System.Windows.Forms.Button();
            this.btnREMOVE = new System.Windows.Forms.Button();
            this.btnCHANGE = new System.Windows.Forms.Button();
            this.btnCLEAR = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnADD
            // 
            this.btnADD.Location = new System.Drawing.Point(111, 74);
            this.btnADD.Name = "btnADD";
            this.btnADD.Size = new System.Drawing.Size(75, 23);
            this.btnADD.TabIndex = 0;
            this.btnADD.Text = "Add";
            this.btnADD.UseVisualStyleBackColor = true;
            this.btnADD.Click += new System.EventHandler(this.btnADD_Click);
            // 
            // btnREMOVE
            // 
            this.btnREMOVE.Location = new System.Drawing.Point(111, 138);
            this.btnREMOVE.Name = "btnREMOVE";
            this.btnREMOVE.Size = new System.Drawing.Size(75, 23);
            this.btnREMOVE.TabIndex = 1;
            this.btnREMOVE.Text = "Remove";
            this.btnREMOVE.UseVisualStyleBackColor = true;
            this.btnREMOVE.Click += new System.EventHandler(this.btnREMOVE_Click);
            // 
            // btnCHANGE
            // 
            this.btnCHANGE.Location = new System.Drawing.Point(111, 186);
            this.btnCHANGE.Name = "btnCHANGE";
            this.btnCHANGE.Size = new System.Drawing.Size(75, 23);
            this.btnCHANGE.TabIndex = 2;
            this.btnCHANGE.Text = "Change";
            this.btnCHANGE.UseVisualStyleBackColor = true;
            this.btnCHANGE.Click += new System.EventHandler(this.btnCHANGE_Click);
            // 
            // btnCLEAR
            // 
            this.btnCLEAR.Location = new System.Drawing.Point(111, 254);
            this.btnCLEAR.Name = "btnCLEAR";
            this.btnCLEAR.Size = new System.Drawing.Size(75, 23);
            this.btnCLEAR.TabIndex = 3;
            this.btnCLEAR.Text = "Clear";
            this.btnCLEAR.UseVisualStyleBackColor = true;
            this.btnCLEAR.Click += new System.EventHandler(this.btnCLEAR_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(312, 76);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "Toyota",
            "Hyundai",
            "BMW",
            "Audi",
            "Kwid"});
            this.listBox1.Location = new System.Drawing.Point(312, 160);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 160);
            this.listBox1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(292, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "ADD,Remove,Change,Clear";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnCLEAR);
            this.Controls.Add(this.btnCHANGE);
            this.Controls.Add(this.btnREMOVE);
            this.Controls.Add(this.btnADD);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnADD;
        private System.Windows.Forms.Button btnREMOVE;
        private System.Windows.Forms.Button btnCHANGE;
        private System.Windows.Forms.Button btnCLEAR;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
    }
}

