using System.Windows.Forms;

namespace Hotel
{
    partial class MainForm 
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel_slide = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button_room = new System.Windows.Forms.Button();
            this.button_reception = new System.Windows.Forms.Button();
            this.button_client = new System.Windows.Forms.Button();
            this.button_home = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel_slide);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button_room);
            this.panel1.Controls.Add(this.button_reception);
            this.panel1.Controls.Add(this.button_client);
            this.panel1.Controls.Add(this.button_home);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(175, 700);
            this.panel1.TabIndex = 0;
            // 
            // panel_slide
            // 
            this.panel_slide.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel_slide.Location = new System.Drawing.Point(145, 122);
            this.panel_slide.Name = "panel_slide";
            this.panel_slide.Size = new System.Drawing.Size(24, 112);
            this.panel_slide.TabIndex = 9;
            this.panel_slide.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_slide_Paint);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.Location = new System.Drawing.Point(0, 585);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 106);
            this.button1.TabIndex = 5;
            this.button1.Text = "Avis";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_room
            // 
            this.button_room.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_room.FlatAppearance.BorderSize = 0;
            this.button_room.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_room.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button_room.Image = global::Hotel.Properties.Resources.room;
            this.button_room.Location = new System.Drawing.Point(0, 475);
            this.button_room.Name = "button_room";
            this.button_room.Size = new System.Drawing.Size(175, 110);
            this.button_room.TabIndex = 4;
            this.button_room.Text = "Room";
            this.button_room.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_room.UseVisualStyleBackColor = true;
            this.button_room.Click += new System.EventHandler(this.button4_Click);
            // 
            // button_reception
            // 
            this.button_reception.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_reception.FlatAppearance.BorderSize = 0;
            this.button_reception.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_reception.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button_reception.Image = global::Hotel.Properties.Resources.reception;
            this.button_reception.Location = new System.Drawing.Point(0, 359);
            this.button_reception.Name = "button_reception";
            this.button_reception.Size = new System.Drawing.Size(175, 116);
            this.button_reception.TabIndex = 3;
            this.button_reception.Text = "Reception";
            this.button_reception.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_reception.UseVisualStyleBackColor = true;
            this.button_reception.Click += new System.EventHandler(this.button_reception_Click);
            // 
            // button_client
            // 
            this.button_client.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_client.FlatAppearance.BorderSize = 0;
            this.button_client.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_client.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button_client.Image = global::Hotel.Properties.Resources.personne;
            this.button_client.Location = new System.Drawing.Point(0, 243);
            this.button_client.Name = "button_client";
            this.button_client.Size = new System.Drawing.Size(175, 116);
            this.button_client.TabIndex = 2;
            this.button_client.Text = "Client";
            this.button_client.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_client.UseVisualStyleBackColor = true;
            this.button_client.Click += new System.EventHandler(this.button_client_Click);
            // 
            // button_home
            // 
            this.button_home.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_home.FlatAppearance.BorderSize = 0;
            this.button_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_home.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button_home.Image = global::Hotel.Properties.Resources.dar;
            this.button_home.Location = new System.Drawing.Point(0, 122);
            this.button_home.Name = "button_home";
            this.button_home.Size = new System.Drawing.Size(175, 121);
            this.button_home.TabIndex = 1;
            this.button_home.Text = "Home";
            this.button_home.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_home.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_home.UseVisualStyleBackColor = true;
            this.button_home.Click += new System.EventHandler(this.button_home_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(175, 122);
            this.panel3.TabIndex = 0;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Hotel.Properties.Resources.c_1;
            this.pictureBox1.Location = new System.Drawing.Point(0, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(142, 119);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(148, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(21, 694);
            this.panel4.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.guna2Button1);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.checkBox5);
            this.panel2.Controls.Add(this.checkBox4);
            this.panel2.Controls.Add(this.checkBox3);
            this.panel2.Controls.Add(this.checkBox2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.checkBox1);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(175, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(925, 700);
            this.panel2.TabIndex = 1;
            // 
            // guna2Button1
            // 
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.Black;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Image = global::Hotel.Properties.Resources.lotout;
            this.guna2Button1.Location = new System.Drawing.Point(802, 652);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(120, 45);
            this.guna2Button1.TabIndex = 10;
            this.guna2Button1.Text = "Lagout";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(895, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "X";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.checkBox5.Location = new System.Drawing.Point(24, 533);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(205, 22);
            this.checkBox5.TabIndex = 8;
            this.checkBox5.Text = "Have a sense of humor";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.checkBox4.Location = new System.Drawing.Point(24, 477);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(229, 22);
            this.checkBox4.TabIndex = 7;
            this.checkBox4.Text = "Empower hotel employees";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.checkBox3.Location = new System.Drawing.Point(24, 505);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(126, 22);
            this.checkBox3.TabIndex = 6;
            this.checkBox3.Text = "Get creative ";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.checkBox2.Location = new System.Drawing.Point(24, 449);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(177, 22);
            this.checkBox2.TabIndex = 5;
            this.checkBox2.Text = "Surver your guests ";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(30, 374);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 27);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tasks";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.checkBox1.Location = new System.Drawing.Point(24, 421);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(140, 22);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "To clean room";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Hotel.Properties.Resources._9ae54ef7_217d_4877_a614_4760325f9a9b_Park_Hyatt_New_York_Manhattan_Sky_Suite_Master_Bedroom;
            this.pictureBox2.Location = new System.Drawing.Point(24, 97);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(873, 257);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(945, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "X";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(219, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hotel  management system";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1100, 700);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button_room;
        private System.Windows.Forms.Button button_reception;
        private System.Windows.Forms.Button button_client;
        private System.Windows.Forms.Button button_home;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel_slide;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel4;
        private Label label4;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}