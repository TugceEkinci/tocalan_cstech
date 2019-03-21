namespace Cstech
{
    partial class OyunMain
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
            this.lblSira = new System.Windows.Forms.Label();
            this.lblAciklama = new System.Windows.Forms.Label();
            this.btnio = new System.Windows.Forms.Button();
            this.nudio = new System.Windows.Forms.NumericUpDown();
            this.btnYanlis = new System.Windows.Forms.Button();
            this.nudPuanim = new System.Windows.Forms.NumericUpDown();
            this.lblPuanim = new System.Windows.Forms.Label();
            this.btnpuanim = new System.Windows.Forms.Button();
            this.nudeksi = new System.Windows.Forms.NumericUpDown();
            this.lbleksi = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPuanim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudeksi)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSira
            // 
            this.lblSira.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSira.Location = new System.Drawing.Point(12, 9);
            this.lblSira.Name = "lblSira";
            this.lblSira.Size = new System.Drawing.Size(222, 66);
            this.lblSira.TabIndex = 2;
            this.lblSira.Text = "label 2";
            this.lblSira.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAciklama
            // 
            this.lblAciklama.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAciklama.Location = new System.Drawing.Point(16, 75);
            this.lblAciklama.Name = "lblAciklama";
            this.lblAciklama.Size = new System.Drawing.Size(218, 75);
            this.lblAciklama.TabIndex = 3;
            this.lblAciklama.Text = "label1";
            this.lblAciklama.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnio
            // 
            this.btnio.Location = new System.Drawing.Point(78, 240);
            this.btnio.Name = "btnio";
            this.btnio.Size = new System.Drawing.Size(75, 23);
            this.btnio.TabIndex = 4;
            this.btnio.Text = "button1";
            this.btnio.UseVisualStyleBackColor = true;
            this.btnio.Click += new System.EventHandler(this.btnio_Click);
            // 
            // nudio
            // 
            this.nudio.Location = new System.Drawing.Point(67, 153);
            this.nudio.Maximum = new decimal(new int[] {
            9876,
            0,
            0,
            0});
            this.nudio.Name = "nudio";
            this.nudio.Size = new System.Drawing.Size(120, 20);
            this.nudio.TabIndex = 5;
            this.nudio.Value = new decimal(new int[] {
            1234,
            0,
            0,
            0});
            // 
            // btnYanlis
            // 
            this.btnYanlis.Location = new System.Drawing.Point(159, 240);
            this.btnYanlis.Name = "btnYanlis";
            this.btnYanlis.Size = new System.Drawing.Size(75, 23);
            this.btnYanlis.TabIndex = 6;
            this.btnYanlis.Text = "Yanlış";
            this.btnYanlis.UseVisualStyleBackColor = true;
            // 
            // nudPuanim
            // 
            this.nudPuanim.Location = new System.Drawing.Point(19, 204);
            this.nudPuanim.Name = "nudPuanim";
            this.nudPuanim.Size = new System.Drawing.Size(53, 20);
            this.nudPuanim.TabIndex = 7;
            // 
            // lblPuanim
            // 
            this.lblPuanim.AutoSize = true;
            this.lblPuanim.Location = new System.Drawing.Point(16, 185);
            this.lblPuanim.Name = "lblPuanim";
            this.lblPuanim.Size = new System.Drawing.Size(60, 13);
            this.lblPuanim.TabIndex = 8;
            this.lblPuanim.Text = "Artı Puanım";
            // 
            // btnpuanim
            // 
            this.btnpuanim.Location = new System.Drawing.Point(159, 280);
            this.btnpuanim.Name = "btnpuanim";
            this.btnpuanim.Size = new System.Drawing.Size(75, 23);
            this.btnpuanim.TabIndex = 9;
            this.btnpuanim.Text = "Doğrula";
            this.btnpuanim.UseVisualStyleBackColor = true;
            // 
            // nudeksi
            // 
            this.nudeksi.Location = new System.Drawing.Point(171, 204);
            this.nudeksi.Name = "nudeksi";
            this.nudeksi.Size = new System.Drawing.Size(47, 20);
            this.nudeksi.TabIndex = 10;
            // 
            // lbleksi
            // 
            this.lbleksi.AutoSize = true;
            this.lbleksi.Location = new System.Drawing.Point(167, 185);
            this.lbleksi.Name = "lbleksi";
            this.lbleksi.Size = new System.Drawing.Size(65, 13);
            this.lbleksi.TabIndex = 11;
            this.lbleksi.Text = "Eksi Puanım";
            // 
            // OyunMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 305);
            this.Controls.Add(this.lbleksi);
            this.Controls.Add(this.nudeksi);
            this.Controls.Add(this.btnpuanim);
            this.Controls.Add(this.lblPuanim);
            this.Controls.Add(this.nudPuanim);
            this.Controls.Add(this.btnYanlis);
            this.Controls.Add(this.nudio);
            this.Controls.Add(this.btnio);
            this.Controls.Add(this.lblAciklama);
            this.Controls.Add(this.lblSira);
            this.Name = "OyunMain";
            this.Text = "OyunMain";
            this.Load += new System.EventHandler(this.OyunMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPuanim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudeksi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblSira;
        private System.Windows.Forms.Label lblAciklama;
        private System.Windows.Forms.Button btnio;
        private System.Windows.Forms.NumericUpDown nudio;
        private System.Windows.Forms.Button btnYanlis;
        private System.Windows.Forms.NumericUpDown nudPuanim;
        private System.Windows.Forms.Label lblPuanim;
        private System.Windows.Forms.Button btnpuanim;
        private System.Windows.Forms.NumericUpDown nudeksi;
        private System.Windows.Forms.Label lbleksi;
    }
}