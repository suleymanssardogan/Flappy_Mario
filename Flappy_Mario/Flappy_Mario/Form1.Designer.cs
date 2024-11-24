namespace Flappy_Mario
{
    partial class Flappy_Mario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Flappy_Mario));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBoxup = new System.Windows.Forms.PictureBox();
            this.pictureBoxdown = new System.Windows.Forms.PictureBox();
            this.pictureBoxmario = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxdown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxmario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 30;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(59, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "label2";
            // 
            // pictureBoxup
            // 
            this.pictureBoxup.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxup.Image")));
            this.pictureBoxup.Location = new System.Drawing.Point(490, 12);
            this.pictureBoxup.Name = "pictureBoxup";
            this.pictureBoxup.Size = new System.Drawing.Size(180, 203);
            this.pictureBoxup.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxup.TabIndex = 2;
            this.pictureBoxup.TabStop = false;
            // 
            // pictureBoxdown
            // 
            this.pictureBoxdown.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxdown.Image")));
            this.pictureBoxdown.Location = new System.Drawing.Point(1068, 420);
            this.pictureBoxdown.Name = "pictureBoxdown";
            this.pictureBoxdown.Size = new System.Drawing.Size(196, 221);
            this.pictureBoxdown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxdown.TabIndex = 1;
            this.pictureBoxdown.TabStop = false;
            // 
            // pictureBoxmario
            // 
            this.pictureBoxmario.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxmario.Image")));
            this.pictureBoxmario.Location = new System.Drawing.Point(83, 335);
            this.pictureBoxmario.Name = "pictureBoxmario";
            this.pictureBoxmario.Size = new System.Drawing.Size(75, 70);
            this.pictureBoxmario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxmario.TabIndex = 0;
            this.pictureBoxmario.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(320, 315);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(118, 106);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // Flappy_Mario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1444, 691);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBoxup);
            this.Controls.Add(this.pictureBoxdown);
            this.Controls.Add(this.pictureBoxmario);
            this.Name = "Flappy_Mario";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Flappy_Mario_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Flappy_Mario_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxdown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxmario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBoxmario;
        private System.Windows.Forms.PictureBox pictureBoxdown;
        private System.Windows.Forms.PictureBox pictureBoxup;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

