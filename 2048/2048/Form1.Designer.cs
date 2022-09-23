
namespace _2048
{
    partial class A2048
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
            this.components = new System.ComponentModel.Container();
            this.Bbtn = new System.Windows.Forms.Button();
            this.WASD = new System.Windows.Forms.Button();
            this.Jbtn = new System.Windows.Forms.Button();
            this.Lbtn = new System.Windows.Forms.Button();
            this.Fbtn = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.score_lbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Bbtn
            // 
            this.Bbtn.Location = new System.Drawing.Point(67, 423);
            this.Bbtn.Name = "Bbtn";
            this.Bbtn.Size = new System.Drawing.Size(66, 63);
            this.Bbtn.TabIndex = 11;
            this.Bbtn.Text = "Balra";
            this.Bbtn.UseVisualStyleBackColor = true;
            this.Bbtn.Click += new System.EventHandler(this.Bbtn_Click);
            // 
            // WASD
            // 
            this.WASD.Location = new System.Drawing.Point(139, 423);
            this.WASD.Name = "WASD";
            this.WASD.Size = new System.Drawing.Size(66, 63);
            this.WASD.TabIndex = 12;
            this.WASD.Text = "WASD";
            this.WASD.UseVisualStyleBackColor = true;
            this.WASD.Click += new System.EventHandler(this.WASD_Click);
            // 
            // Jbtn
            // 
            this.Jbtn.Location = new System.Drawing.Point(211, 423);
            this.Jbtn.Name = "Jbtn";
            this.Jbtn.Size = new System.Drawing.Size(66, 63);
            this.Jbtn.TabIndex = 13;
            this.Jbtn.Text = "Jobbra";
            this.Jbtn.UseVisualStyleBackColor = true;
            this.Jbtn.Click += new System.EventHandler(this.Jbtn_Click);
            // 
            // Lbtn
            // 
            this.Lbtn.Location = new System.Drawing.Point(139, 492);
            this.Lbtn.Name = "Lbtn";
            this.Lbtn.Size = new System.Drawing.Size(66, 63);
            this.Lbtn.TabIndex = 14;
            this.Lbtn.Text = "Le";
            this.Lbtn.UseVisualStyleBackColor = true;
            this.Lbtn.Click += new System.EventHandler(this.Lbtn_Click);
            // 
            // Fbtn
            // 
            this.Fbtn.Location = new System.Drawing.Point(139, 354);
            this.Fbtn.Name = "Fbtn";
            this.Fbtn.Size = new System.Drawing.Size(66, 63);
            this.Fbtn.TabIndex = 15;
            this.Fbtn.Text = "Fel";
            this.Fbtn.UseVisualStyleBackColor = true;
            this.Fbtn.Click += new System.EventHandler(this.Fbtn_Click);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // score_lbl
            // 
            this.score_lbl.AutoSize = true;
            this.score_lbl.Location = new System.Drawing.Point(302, 529);
            this.score_lbl.Name = "score_lbl";
            this.score_lbl.Size = new System.Drawing.Size(13, 13);
            this.score_lbl.TabIndex = 16;
            this.score_lbl.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(212, 529);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Pontszámok:";
            // 
            // A2048
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 612);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.score_lbl);
            this.Controls.Add(this.Fbtn);
            this.Controls.Add(this.Lbtn);
            this.Controls.Add(this.Jbtn);
            this.Controls.Add(this.WASD);
            this.Controls.Add(this.Bbtn);
            this.Name = "A2048";
            this.Text = "2048";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Bbtn;
        private System.Windows.Forms.Button WASD;
        private System.Windows.Forms.Button Jbtn;
        private System.Windows.Forms.Button Lbtn;
        private System.Windows.Forms.Button Fbtn;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label score_lbl;
        private System.Windows.Forms.Label label1;
    }
}

