namespace App1
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Btn2 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.Btn1 = new System.Windows.Forms.Button();
            this.pB5 = new System.Windows.Forms.PictureBox();
            this.pB4 = new System.Windows.Forms.PictureBox();
            this.pB3 = new System.Windows.Forms.PictureBox();
            this.pB2 = new System.Windows.Forms.PictureBox();
            this.userUI1 = new Proje1.UserUI();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblPuan = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblSure = new System.Windows.Forms.Label();
            this.pB1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pB5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB2)).BeginInit();
            this.userUI1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pB1)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn2
            // 
            this.Btn2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Btn2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn2.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btn2.Location = new System.Drawing.Point(577, 429);
            this.Btn2.Name = "Btn2";
            this.Btn2.Size = new System.Drawing.Size(295, 112);
            this.Btn2.TabIndex = 1;
            this.Btn2.Text = "Seçenek 2";
            this.Btn2.UseVisualStyleBackColor = false;
            this.Btn2.Click += new System.EventHandler(this.Btn2_Click_1);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.button9.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button9.Location = new System.Drawing.Point(398, 461);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(101, 51);
            this.button9.TabIndex = 4;
            this.button9.Text = "BAŞLAT";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click_1);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(428, 515);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "label1";
            this.label3.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(428, 528);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "label5";
            this.label5.Visible = false;
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "Almanya 2.png");
            this.ımageList1.Images.SetKeyName(1, "Almanya 3.png");
            this.ımageList1.Images.SetKeyName(2, "Almanya 4.png");
            this.ımageList1.Images.SetKeyName(3, "Almanya.png");
            this.ımageList1.Images.SetKeyName(4, "Çin.png");
            this.ımageList1.Images.SetKeyName(5, "Fransa.png");
            this.ımageList1.Images.SetKeyName(6, "ht.png");
            this.ımageList1.Images.SetKeyName(7, "hu.png");
            this.ımageList1.Images.SetKeyName(8, "id.png");
            this.ımageList1.Images.SetKeyName(9, "ie.png");
            this.ımageList1.Images.SetKeyName(10, "il.png");
            this.ımageList1.Images.SetKeyName(11, "im.png");
            this.ımageList1.Images.SetKeyName(12, "in.png");
            this.ımageList1.Images.SetKeyName(13, "İngiltere 2.png");
            this.ımageList1.Images.SetKeyName(14, "İngiltere 3.png");
            this.ımageList1.Images.SetKeyName(15, "İngiltere 4.png");
            this.ımageList1.Images.SetKeyName(16, "İngiltere.png");
            this.ımageList1.Images.SetKeyName(17, "iq.png");
            this.ımageList1.Images.SetKeyName(18, "ir.png");
            this.ımageList1.Images.SetKeyName(19, "İspanya.png");
            this.ımageList1.Images.SetKeyName(20, "it.png");
            this.ımageList1.Images.SetKeyName(21, "İtalya.png");
            this.ımageList1.Images.SetKeyName(22, "Japonya.png");
            this.ımageList1.Images.SetKeyName(23, "je.png");
            this.ımageList1.Images.SetKeyName(24, "jm.png");
            this.ımageList1.Images.SetKeyName(25, "jo.png");
            this.ımageList1.Images.SetKeyName(26, "jp.png");
            this.ımageList1.Images.SetKeyName(27, "kg.png");
            this.ımageList1.Images.SetKeyName(28, "kh.png");
            this.ımageList1.Images.SetKeyName(29, "ki.png");
            this.ımageList1.Images.SetKeyName(30, "km.png");
            this.ımageList1.Images.SetKeyName(31, "kn.png");
            this.ımageList1.Images.SetKeyName(32, "kp.png");
            this.ımageList1.Images.SetKeyName(33, "kr.png");
            this.ımageList1.Images.SetKeyName(34, "ky.png");
            this.ımageList1.Images.SetKeyName(35, "kz.png");
            this.ımageList1.Images.SetKeyName(36, "la.png");
            this.ımageList1.Images.SetKeyName(37, "lb.png");
            this.ımageList1.Images.SetKeyName(38, "lc.png");
            this.ımageList1.Images.SetKeyName(39, "li.png");
            this.ımageList1.Images.SetKeyName(40, "lk.png");
            this.ımageList1.Images.SetKeyName(41, "ls.png");
            this.ımageList1.Images.SetKeyName(42, "lt.png");
            this.ımageList1.Images.SetKeyName(43, "lu.png");
            this.ımageList1.Images.SetKeyName(44, "lv.png");
            this.ımageList1.Images.SetKeyName(45, "ly.png");
            this.ımageList1.Images.SetKeyName(46, "ma.png");
            this.ımageList1.Images.SetKeyName(47, "mc.png");
            this.ımageList1.Images.SetKeyName(48, "me.png");
            this.ımageList1.Images.SetKeyName(49, "mf.png");
            this.ımageList1.Images.SetKeyName(50, "mg.png");
            this.ımageList1.Images.SetKeyName(51, "mh.png");
            this.ımageList1.Images.SetKeyName(52, "Mısır.png");
            this.ımageList1.Images.SetKeyName(53, "mk.png");
            this.ımageList1.Images.SetKeyName(54, "ml.png");
            this.ımageList1.Images.SetKeyName(55, "mm.png");
            this.ımageList1.Images.SetKeyName(56, "mo.png");
            this.ımageList1.Images.SetKeyName(57, "mp.png");
            this.ımageList1.Images.SetKeyName(58, "mq.png");
            this.ımageList1.Images.SetKeyName(59, "mr.png");
            this.ımageList1.Images.SetKeyName(60, "ms.png");
            this.ımageList1.Images.SetKeyName(61, "mt.png");
            this.ımageList1.Images.SetKeyName(62, "mu.png");
            this.ımageList1.Images.SetKeyName(63, "Polonya.png");
            this.ımageList1.Images.SetKeyName(64, "Türkiye.png");
            // 
            // Btn1
            // 
            this.Btn1.AutoEllipsis = true;
            this.Btn1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Btn1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn1.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btn1.Location = new System.Drawing.Point(46, 430);
            this.Btn1.Name = "Btn1";
            this.Btn1.Size = new System.Drawing.Size(295, 112);
            this.Btn1.TabIndex = 0;
            this.Btn1.Text = "Seçenek 1";
            this.Btn1.UseVisualStyleBackColor = false;
            this.Btn1.Click += new System.EventHandler(this.Btn1_Click);
            // 
            // pB5
            // 
            this.pB5.BackColor = System.Drawing.SystemColors.Control;
            this.pB5.Image = global::Proje1.Properties.Resources.RED;
            this.pB5.Location = new System.Drawing.Point(287, 380);
            this.pB5.Name = "pB5";
            this.pB5.Size = new System.Drawing.Size(50, 44);
            this.pB5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pB5.TabIndex = 17;
            this.pB5.TabStop = false;
            // 
            // pB4
            // 
            this.pB4.Image = global::Proje1.Properties.Resources.AWWm;
            this.pB4.Location = new System.Drawing.Point(577, 368);
            this.pB4.Name = "pB4";
            this.pB4.Size = new System.Drawing.Size(57, 56);
            this.pB4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pB4.TabIndex = 16;
            this.pB4.TabStop = false;
            // 
            // pB3
            // 
            this.pB3.Image = global::Proje1.Properties.Resources.RED;
            this.pB3.Location = new System.Drawing.Point(822, 382);
            this.pB3.Name = "pB3";
            this.pB3.Size = new System.Drawing.Size(50, 44);
            this.pB3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pB3.TabIndex = 15;
            this.pB3.TabStop = false;
            // 
            // pB2
            // 
            this.pB2.Image = global::Proje1.Properties.Resources.AWWm;
            this.pB2.Location = new System.Drawing.Point(46, 370);
            this.pB2.Name = "pB2";
            this.pB2.Size = new System.Drawing.Size(57, 56);
            this.pB2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pB2.TabIndex = 14;
            this.pB2.TabStop = false;
            // 
            // userUI1
            // 
            this.userUI1.ColorBottom = System.Drawing.Color.AliceBlue;
            this.userUI1.ColorTop = System.Drawing.Color.SkyBlue;
            this.userUI1.Controls.Add(this.label10);
            this.userUI1.Controls.Add(this.label9);
            this.userUI1.Controls.Add(this.label8);
            this.userUI1.Controls.Add(this.label7);
            this.userUI1.Controls.Add(this.label4);
            this.userUI1.Controls.Add(this.lblPuan);
            this.userUI1.Controls.Add(this.label2);
            this.userUI1.Controls.Add(this.label1);
            this.userUI1.Controls.Add(this.label6);
            this.userUI1.Controls.Add(this.lblSure);
            this.userUI1.Controls.Add(this.pB1);
            this.userUI1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.userUI1.Location = new System.Drawing.Point(0, 0);
            this.userUI1.Name = "userUI1";
            this.userUI1.Size = new System.Drawing.Size(938, 587);
            this.userUI1.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(411, 541);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 27);
            this.label10.TabIndex = 18;
            this.label10.Text = "label10";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(833, 80);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(24, 27);
            this.label9.TabIndex = 17;
            this.label9.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(833, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 27);
            this.label8.TabIndex = 16;
            this.label8.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(736, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 27);
            this.label7.TabIndex = 15;
            this.label7.Text = "Wrong =";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(725, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 27);
            this.label4.TabIndex = 14;
            this.label4.Text = "Correct =";
            // 
            // lblPuan
            // 
            this.lblPuan.AutoSize = true;
            this.lblPuan.BackColor = System.Drawing.Color.SkyBlue;
            this.lblPuan.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPuan.ForeColor = System.Drawing.Color.Black;
            this.lblPuan.Location = new System.Drawing.Point(192, 256);
            this.lblPuan.Name = "lblPuan";
            this.lblPuan.Size = new System.Drawing.Size(24, 27);
            this.lblPuan.TabIndex = 9;
            this.lblPuan.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.SkyBlue;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(45, 256);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 27);
            this.label2.TabIndex = 13;
            this.label2.Text = "Total Score =";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SkyBlue;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(13, 294);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 27);
            this.label1.TabIndex = 11;
            this.label1.Text = "Remaining Time =";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.SkyBlue;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(330, 320);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 30);
            this.label6.TabIndex = 10;
            this.label6.Text = ".";
            // 
            // lblSure
            // 
            this.lblSure.AutoSize = true;
            this.lblSure.BackColor = System.Drawing.Color.SkyBlue;
            this.lblSure.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSure.ForeColor = System.Drawing.Color.Black;
            this.lblSure.Location = new System.Drawing.Point(192, 294);
            this.lblSure.Name = "lblSure";
            this.lblSure.Size = new System.Drawing.Size(36, 27);
            this.lblSure.TabIndex = 12;
            this.lblSure.Text = "60";
            // 
            // pB1
            // 
            this.pB1.BackColor = System.Drawing.Color.SkyBlue;
            this.pB1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pB1.Location = new System.Drawing.Point(254, 12);
            this.pB1.Name = "pB1";
            this.pB1.Size = new System.Drawing.Size(455, 271);
            this.pB1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pB1.TabIndex = 5;
            this.pB1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 586);
            this.Controls.Add(this.pB5);
            this.Controls.Add(this.pB4);
            this.Controls.Add(this.pB3);
            this.Controls.Add(this.pB2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.Btn2);
            this.Controls.Add(this.Btn1);
            this.Controls.Add(this.userUI1);
            this.MaximumSize = new System.Drawing.Size(954, 625);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pB5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB2)).EndInit();
            this.userUI1.ResumeLayout(false);
            this.userUI1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pB1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn1;
        private System.Windows.Forms.Button Btn2;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pB1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblPuan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSure;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.PictureBox pB2;
        private System.Windows.Forms.PictureBox pB3;
        private System.Windows.Forms.PictureBox pB4;
        private System.Windows.Forms.PictureBox pB5;
        private Proje1.UserUI userUI1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
    }
}

