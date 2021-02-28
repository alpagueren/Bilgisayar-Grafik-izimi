
namespace BilgisayarGrafikleriKisaSinav2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.xy = new System.Windows.Forms.CheckBox();
            this.xz = new System.Windows.Forms.CheckBox();
            this.yz = new System.Windows.Forms.CheckBox();
            this.xacıdon = new System.Windows.Forms.TextBox();
            this.yacıdon = new System.Windows.Forms.TextBox();
            this.zacıdon = new System.Windows.Forms.TextBox();
            this.olceklez = new System.Windows.Forms.TextBox();
            this.olcekley = new System.Windows.Forms.TextBox();
            this.olceklex = new System.Windows.Forms.TextBox();
            this.zotele = new System.Windows.Forms.TextBox();
            this.yotele = new System.Windows.Forms.TextBox();
            this.xotele = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 47);
            this.button1.TabIndex = 0;
            this.button1.Text = "Eksenleri Çiz (XYZ)";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 65);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(145, 47);
            this.button2.TabIndex = 1;
            this.button2.Text = "Cismin İzometrik İzdüşümünü Al";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 239);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(145, 84);
            this.button3.TabIndex = 3;
            this.button3.Text = "Ölçekle";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 141);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(145, 84);
            this.button4.TabIndex = 2;
            this.button4.Text = "Ötele";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(12, 442);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(145, 86);
            this.button5.TabIndex = 5;
            this.button5.Text = "Döndür";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(12, 339);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(145, 86);
            this.button6.TabIndex = 4;
            this.button6.Text = "Yansıt";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(12, 592);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(145, 47);
            this.button7.TabIndex = 6;
            this.button7.Text = "Formu Temizle";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // xy
            // 
            this.xy.AutoSize = true;
            this.xy.Location = new System.Drawing.Point(182, 339);
            this.xy.Name = "xy";
            this.xy.Size = new System.Drawing.Size(48, 21);
            this.xy.TabIndex = 7;
            this.xy.Text = "XY";
            this.xy.UseVisualStyleBackColor = true;
            // 
            // xz
            // 
            this.xz.AutoSize = true;
            this.xz.Location = new System.Drawing.Point(182, 373);
            this.xz.Name = "xz";
            this.xz.Size = new System.Drawing.Size(48, 21);
            this.xz.TabIndex = 8;
            this.xz.Text = "XZ";
            this.xz.UseVisualStyleBackColor = true;
            // 
            // yz
            // 
            this.yz.AutoSize = true;
            this.yz.Location = new System.Drawing.Point(182, 404);
            this.yz.Name = "yz";
            this.yz.Size = new System.Drawing.Size(48, 21);
            this.yz.TabIndex = 9;
            this.yz.Text = "YZ";
            this.yz.UseVisualStyleBackColor = true;
            // 
            // xacıdon
            // 
            this.xacıdon.Location = new System.Drawing.Point(196, 442);
            this.xacıdon.Name = "xacıdon";
            this.xacıdon.Size = new System.Drawing.Size(100, 22);
            this.xacıdon.TabIndex = 10;
            this.xacıdon.Text = "0";
            // 
            // yacıdon
            // 
            this.yacıdon.Location = new System.Drawing.Point(196, 470);
            this.yacıdon.Name = "yacıdon";
            this.yacıdon.Size = new System.Drawing.Size(100, 22);
            this.yacıdon.TabIndex = 11;
            this.yacıdon.Text = "0";
            // 
            // zacıdon
            // 
            this.zacıdon.Location = new System.Drawing.Point(196, 498);
            this.zacıdon.Name = "zacıdon";
            this.zacıdon.Size = new System.Drawing.Size(100, 22);
            this.zacıdon.TabIndex = 12;
            this.zacıdon.Text = "0";
            // 
            // olceklez
            // 
            this.olceklez.Location = new System.Drawing.Point(196, 295);
            this.olceklez.Name = "olceklez";
            this.olceklez.Size = new System.Drawing.Size(100, 22);
            this.olceklez.TabIndex = 15;
            // 
            // olcekley
            // 
            this.olcekley.Location = new System.Drawing.Point(196, 267);
            this.olcekley.Name = "olcekley";
            this.olcekley.Size = new System.Drawing.Size(100, 22);
            this.olcekley.TabIndex = 14;
            // 
            // olceklex
            // 
            this.olceklex.Location = new System.Drawing.Point(196, 239);
            this.olceklex.Name = "olceklex";
            this.olceklex.Size = new System.Drawing.Size(100, 22);
            this.olceklex.TabIndex = 13;
            // 
            // zotele
            // 
            this.zotele.Location = new System.Drawing.Point(196, 205);
            this.zotele.Name = "zotele";
            this.zotele.Size = new System.Drawing.Size(100, 22);
            this.zotele.TabIndex = 18;
            this.zotele.Text = "0";
            // 
            // yotele
            // 
            this.yotele.Location = new System.Drawing.Point(196, 177);
            this.yotele.Name = "yotele";
            this.yotele.Size = new System.Drawing.Size(100, 22);
            this.yotele.TabIndex = 17;
            this.yotele.Text = "0";
            // 
            // xotele
            // 
            this.xotele.Location = new System.Drawing.Point(196, 149);
            this.xotele.Name = "xotele";
            this.xotele.Size = new System.Drawing.Size(100, 22);
            this.xotele.TabIndex = 16;
            this.xotele.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(163, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 17);
            this.label1.TabIndex = 19;
            this.label1.Text = "X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(163, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 17);
            this.label2.TabIndex = 20;
            this.label2.Text = "Y";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(163, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 17);
            this.label3.TabIndex = 21;
            this.label3.Text = "Z";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(163, 298);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 17);
            this.label4.TabIndex = 24;
            this.label4.Text = "Z";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(163, 270);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 17);
            this.label5.TabIndex = 23;
            this.label5.Text = "Y";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(163, 242);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 17);
            this.label6.TabIndex = 22;
            this.label6.Text = "X";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(163, 501);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 17);
            this.label7.TabIndex = 27;
            this.label7.Text = "Z";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(163, 473);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 17);
            this.label8.TabIndex = 26;
            this.label8.Text = "Y";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(163, 445);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(17, 17);
            this.label9.TabIndex = 25;
            this.label9.Text = "X";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1057, 659);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.zotele);
            this.Controls.Add(this.yotele);
            this.Controls.Add(this.xotele);
            this.Controls.Add(this.olceklez);
            this.Controls.Add(this.olcekley);
            this.Controls.Add(this.olceklex);
            this.Controls.Add(this.zacıdon);
            this.Controls.Add(this.yacıdon);
            this.Controls.Add(this.xacıdon);
            this.Controls.Add(this.yz);
            this.Controls.Add(this.xz);
            this.Controls.Add(this.xy);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Bilgisayar Garfikleri Kısa Sınav 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.CheckBox xy;
        private System.Windows.Forms.CheckBox xz;
        private System.Windows.Forms.CheckBox yz;
        private System.Windows.Forms.TextBox xacıdon;
        private System.Windows.Forms.TextBox yacıdon;
        private System.Windows.Forms.TextBox zacıdon;
        private System.Windows.Forms.TextBox olceklez;
        private System.Windows.Forms.TextBox olcekley;
        private System.Windows.Forms.TextBox olceklex;
        private System.Windows.Forms.TextBox zotele;
        private System.Windows.Forms.TextBox yotele;
        private System.Windows.Forms.TextBox xotele;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}

