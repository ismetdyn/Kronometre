
namespace Proje5._25_Kronometre
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.tbSaat = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbDakika = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbSaniye = new System.Windows.Forms.TextBox();
            this.btnBaslat = new System.Windows.Forms.Button();
            this.tbnDurdur = new System.Windows.Forms.Button();
            this.btnDevamEt = new System.Windows.Forms.Button();
            this.btnSifirla = new System.Windows.Forms.Button();
            this.lSure = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Saat";
            // 
            // tbSaat
            // 
            this.tbSaat.Location = new System.Drawing.Point(64, 6);
            this.tbSaat.Name = "tbSaat";
            this.tbSaat.Size = new System.Drawing.Size(100, 22);
            this.tbSaat.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(197, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Dakika";
            // 
            // tbDakika
            // 
            this.tbDakika.Location = new System.Drawing.Point(247, 6);
            this.tbDakika.Name = "tbDakika";
            this.tbDakika.Size = new System.Drawing.Size(100, 22);
            this.tbDakika.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(391, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Saniye";
            // 
            // tbSaniye
            // 
            this.tbSaniye.Location = new System.Drawing.Point(441, 7);
            this.tbSaniye.Name = "tbSaniye";
            this.tbSaniye.Size = new System.Drawing.Size(100, 22);
            this.tbSaniye.TabIndex = 5;
            // 
            // btnBaslat
            // 
            this.btnBaslat.Location = new System.Drawing.Point(16, 60);
            this.btnBaslat.Name = "btnBaslat";
            this.btnBaslat.Size = new System.Drawing.Size(75, 23);
            this.btnBaslat.TabIndex = 6;
            this.btnBaslat.Text = "Başlat";
            this.btnBaslat.UseVisualStyleBackColor = true;
            this.btnBaslat.Click += new System.EventHandler(this.btnBaslat_Click);
            // 
            // tbnDurdur
            // 
            this.tbnDurdur.Location = new System.Drawing.Point(154, 60);
            this.tbnDurdur.Name = "tbnDurdur";
            this.tbnDurdur.Size = new System.Drawing.Size(75, 23);
            this.tbnDurdur.TabIndex = 7;
            this.tbnDurdur.Text = "Durdur";
            this.tbnDurdur.UseVisualStyleBackColor = true;
            this.tbnDurdur.Click += new System.EventHandler(this.tbnDurdur_Click);
            // 
            // btnDevamEt
            // 
            this.btnDevamEt.Location = new System.Drawing.Point(304, 60);
            this.btnDevamEt.Name = "btnDevamEt";
            this.btnDevamEt.Size = new System.Drawing.Size(75, 23);
            this.btnDevamEt.TabIndex = 8;
            this.btnDevamEt.Text = "Devam Et";
            this.btnDevamEt.UseVisualStyleBackColor = true;
            this.btnDevamEt.Click += new System.EventHandler(this.btnDevamEt_Click);
            // 
            // btnSifirla
            // 
            this.btnSifirla.Location = new System.Drawing.Point(466, 60);
            this.btnSifirla.Name = "btnSifirla";
            this.btnSifirla.Size = new System.Drawing.Size(75, 23);
            this.btnSifirla.TabIndex = 9;
            this.btnSifirla.Text = "Sıfırla";
            this.btnSifirla.UseVisualStyleBackColor = true;
            this.btnSifirla.Click += new System.EventHandler(this.btnSifirla_Click);
            // 
            // lSure
            // 
            this.lSure.AutoSize = true;
            this.lSure.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lSure.ForeColor = System.Drawing.Color.Red;
            this.lSure.Location = new System.Drawing.Point(190, 109);
            this.lSure.Name = "lSure";
            this.lSure.Size = new System.Drawing.Size(43, 58);
            this.lSure.TabIndex = 10;
            this.lSure.Text = "-";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 197);
            this.Controls.Add(this.lSure);
            this.Controls.Add(this.btnSifirla);
            this.Controls.Add(this.btnDevamEt);
            this.Controls.Add(this.tbnDurdur);
            this.Controls.Add(this.btnBaslat);
            this.Controls.Add(this.tbSaniye);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbDakika);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbSaat);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbSaat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbDakika;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbSaniye;
        private System.Windows.Forms.Button btnBaslat;
        private System.Windows.Forms.Button tbnDurdur;
        private System.Windows.Forms.Button btnDevamEt;
        private System.Windows.Forms.Button btnSifirla;
        private System.Windows.Forms.Label lSure;
        private System.Windows.Forms.Timer timer1;
    }
}

