namespace Hotel
{
    partial class Avis
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
            this.label_exit = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2MouseStateHandler1 = new Guna.UI2.WinForms.Guna2MouseStateHandler(this.components);
            this.guna2RatingStar1 = new Guna.UI2.WinForms.Guna2RatingStar();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.guna2RatingStar2 = new Guna.UI2.WinForms.Guna2RatingStar();
            this.guna2RatingStar3 = new Guna.UI2.WinForms.Guna2RatingStar();
            this.SuspendLayout();
            // 
            // label_exit
            // 
            this.label_exit.AutoSize = true;
            this.label_exit.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_exit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label_exit.Location = new System.Drawing.Point(818, 0);
            this.label_exit.Name = "label_exit";
            this.label_exit.Size = new System.Drawing.Size(24, 25);
            this.label_exit.TabIndex = 14;
            this.label_exit.Text = "X";
            this.label_exit.Click += new System.EventHandler(this.label_exit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft PhagsPa", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(69, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(719, 31);
            this.label1.TabIndex = 15;
            this.label1.Text = "Quel est votre niveau de satisfaction quant aux éléments suivants:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // guna2RatingStar1
            // 
            this.guna2RatingStar1.Location = new System.Drawing.Point(455, 169);
            this.guna2RatingStar1.Name = "guna2RatingStar1";
            this.guna2RatingStar1.RatingColor = System.Drawing.Color.Yellow;
            this.guna2RatingStar1.Size = new System.Drawing.Size(187, 37);
            this.guna2RatingStar1.TabIndex = 26;
            this.guna2RatingStar1.ValueChanged += new System.EventHandler(this.guna2RatingStar1_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(220, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 22);
            this.label2.TabIndex = 27;
            this.label2.Text = "L\'accueil dans l\'hôtel :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(161, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(269, 22);
            this.label3.TabIndex = 28;
            this.label3.Text = "Le processus de réservation:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(181, 346);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(249, 22);
            this.label4.TabIndex = 29;
            this.label4.Text = "La propreté des chambres:";
            // 
            // guna2RatingStar2
            // 
            this.guna2RatingStar2.Location = new System.Drawing.Point(455, 248);
            this.guna2RatingStar2.Name = "guna2RatingStar2";
            this.guna2RatingStar2.RatingColor = System.Drawing.Color.Yellow;
            this.guna2RatingStar2.Size = new System.Drawing.Size(187, 37);
            this.guna2RatingStar2.TabIndex = 30;
            // 
            // guna2RatingStar3
            // 
            this.guna2RatingStar3.Location = new System.Drawing.Point(455, 331);
            this.guna2RatingStar3.Name = "guna2RatingStar3";
            this.guna2RatingStar3.RatingColor = System.Drawing.Color.Yellow;
            this.guna2RatingStar3.Size = new System.Drawing.Size(187, 37);
            this.guna2RatingStar3.TabIndex = 31;
            // 
            // Avis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(843, 583);
            this.Controls.Add(this.guna2RatingStar3);
            this.Controls.Add(this.guna2RatingStar2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.guna2RatingStar1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_exit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Avis";
            this.Text = "Avis";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_exit;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2MouseStateHandler guna2MouseStateHandler1;
        private Guna.UI2.WinForms.Guna2RatingStar guna2RatingStar1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2RatingStar guna2RatingStar2;
        private Guna.UI2.WinForms.Guna2RatingStar guna2RatingStar3;
    }
}