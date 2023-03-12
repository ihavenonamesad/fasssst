namespace CA_W3
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
            this.Prime_lbl = new System.Windows.Forms.Label();
            this.Fact_lbl = new System.Windows.Forms.Label();
            this.Comb_lbl = new System.Windows.Forms.Label();
            this.Prime_txt = new System.Windows.Forms.TextBox();
            this.Fact_txt = new System.Windows.Forms.TextBox();
            this.Comb_txt = new System.Windows.Forms.TextBox();
            this.Prime_btn = new System.Windows.Forms.Button();
            this.Fact_btn = new System.Windows.Forms.Button();
            this.CombN_lbl = new System.Windows.Forms.Label();
            this.CombC_lbl = new System.Windows.Forms.Label();
            this.CombR_lbl = new System.Windows.Forms.Label();
            this.CombR_txt = new System.Windows.Forms.TextBox();
            this.Comb_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Prime_lbl
            // 
            this.Prime_lbl.AutoSize = true;
            this.Prime_lbl.Location = new System.Drawing.Point(72, 57);
            this.Prime_lbl.Name = "Prime_lbl";
            this.Prime_lbl.Size = new System.Drawing.Size(55, 13);
            this.Prime_lbl.TabIndex = 0;
            this.Prime_lbl.Text = "Cek Prime";
            // 
            // Fact_lbl
            // 
            this.Fact_lbl.AutoSize = true;
            this.Fact_lbl.Location = new System.Drawing.Point(72, 88);
            this.Fact_lbl.Name = "Fact_lbl";
            this.Fact_lbl.Size = new System.Drawing.Size(70, 13);
            this.Fact_lbl.TabIndex = 1;
            this.Fact_lbl.Text = "Find Factorial";
            // 
            // Comb_lbl
            // 
            this.Comb_lbl.AutoSize = true;
            this.Comb_lbl.Location = new System.Drawing.Point(72, 115);
            this.Comb_lbl.Name = "Comb_lbl";
            this.Comb_lbl.Size = new System.Drawing.Size(88, 13);
            this.Comb_lbl.TabIndex = 2;
            this.Comb_lbl.Text = "Find Combination";
            this.Comb_lbl.Click += new System.EventHandler(this.label3_Click);
            // 
            // Prime_txt
            // 
            this.Prime_txt.Location = new System.Drawing.Point(170, 57);
            this.Prime_txt.Name = "Prime_txt";
            this.Prime_txt.Size = new System.Drawing.Size(100, 20);
            this.Prime_txt.TabIndex = 3;
            // 
            // Fact_txt
            // 
            this.Fact_txt.Location = new System.Drawing.Point(170, 88);
            this.Fact_txt.Name = "Fact_txt";
            this.Fact_txt.Size = new System.Drawing.Size(100, 20);
            this.Fact_txt.TabIndex = 4;
            // 
            // Comb_txt
            // 
            this.Comb_txt.Location = new System.Drawing.Point(170, 115);
            this.Comb_txt.Name = "Comb_txt";
            this.Comb_txt.Size = new System.Drawing.Size(56, 20);
            this.Comb_txt.TabIndex = 5;
            // 
            // Prime_btn
            // 
            this.Prime_btn.Location = new System.Drawing.Point(300, 57);
            this.Prime_btn.Name = "Prime_btn";
            this.Prime_btn.Size = new System.Drawing.Size(75, 23);
            this.Prime_btn.TabIndex = 6;
            this.Prime_btn.Text = "Check Prime";
            this.Prime_btn.UseVisualStyleBackColor = true;
            this.Prime_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // Fact_btn
            // 
            this.Fact_btn.Location = new System.Drawing.Point(300, 90);
            this.Fact_btn.Name = "Fact_btn";
            this.Fact_btn.Size = new System.Drawing.Size(100, 23);
            this.Fact_btn.TabIndex = 7;
            this.Fact_btn.Text = "Check Factorial";
            this.Fact_btn.UseVisualStyleBackColor = true;
            this.Fact_btn.Click += new System.EventHandler(this.Fact_btn_Click);
            // 
            // CombN_lbl
            // 
            this.CombN_lbl.AutoSize = true;
            this.CombN_lbl.Location = new System.Drawing.Point(187, 142);
            this.CombN_lbl.Name = "CombN_lbl";
            this.CombN_lbl.Size = new System.Drawing.Size(13, 13);
            this.CombN_lbl.TabIndex = 8;
            this.CombN_lbl.Text = "n";
            // 
            // CombC_lbl
            // 
            this.CombC_lbl.AutoSize = true;
            this.CombC_lbl.Location = new System.Drawing.Point(232, 122);
            this.CombC_lbl.Name = "CombC_lbl";
            this.CombC_lbl.Size = new System.Drawing.Size(14, 13);
            this.CombC_lbl.TabIndex = 9;
            this.CombC_lbl.Text = "C";
            // 
            // CombR_lbl
            // 
            this.CombR_lbl.AutoSize = true;
            this.CombR_lbl.Location = new System.Drawing.Point(272, 142);
            this.CombR_lbl.Name = "CombR_lbl";
            this.CombR_lbl.Size = new System.Drawing.Size(10, 13);
            this.CombR_lbl.TabIndex = 10;
            this.CombR_lbl.Text = "r";
            // 
            // CombR_txt
            // 
            this.CombR_txt.Location = new System.Drawing.Point(252, 119);
            this.CombR_txt.Name = "CombR_txt";
            this.CombR_txt.Size = new System.Drawing.Size(57, 20);
            this.CombR_txt.TabIndex = 11;
            // 
            // Comb_btn
            // 
            this.Comb_btn.Location = new System.Drawing.Point(329, 119);
            this.Comb_btn.Name = "Comb_btn";
            this.Comb_btn.Size = new System.Drawing.Size(115, 23);
            this.Comb_btn.TabIndex = 12;
            this.Comb_btn.Text = "Check Combination";
            this.Comb_btn.UseVisualStyleBackColor = true;
            this.Comb_btn.Click += new System.EventHandler(this.Comb_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Comb_btn);
            this.Controls.Add(this.CombR_txt);
            this.Controls.Add(this.CombR_lbl);
            this.Controls.Add(this.CombC_lbl);
            this.Controls.Add(this.CombN_lbl);
            this.Controls.Add(this.Fact_btn);
            this.Controls.Add(this.Prime_btn);
            this.Controls.Add(this.Comb_txt);
            this.Controls.Add(this.Fact_txt);
            this.Controls.Add(this.Prime_txt);
            this.Controls.Add(this.Comb_lbl);
            this.Controls.Add(this.Fact_lbl);
            this.Controls.Add(this.Prime_lbl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Prime_lbl;
        private System.Windows.Forms.Label Fact_lbl;
        private System.Windows.Forms.Label Comb_lbl;
        private System.Windows.Forms.TextBox Prime_txt;
        private System.Windows.Forms.TextBox Fact_txt;
        private System.Windows.Forms.TextBox Comb_txt;
        private System.Windows.Forms.Button Prime_btn;
        private System.Windows.Forms.Button Fact_btn;
        private System.Windows.Forms.Label CombN_lbl;
        private System.Windows.Forms.Label CombC_lbl;
        private System.Windows.Forms.Label CombR_lbl;
        private System.Windows.Forms.TextBox CombR_txt;
        private System.Windows.Forms.Button Comb_btn;
    }
}

