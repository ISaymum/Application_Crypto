namespace Cryptage
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnCrypter = new System.Windows.Forms.Button();
            this.MessageACrypter = new System.Windows.Forms.TextBox();
            this.MessageCrypte = new System.Windows.Forms.TextBox();
            this.btnDecrypter = new System.Windows.Forms.Button();
            this.MessageDecrypte = new System.Windows.Forms.TextBox();
            this.CleCryptagePerso = new System.Windows.Forms.NumericUpDown();
            this.lbMessage = new System.Windows.Forms.Label();
            this.lbCle = new System.Windows.Forms.Label();
            this.lbMessageCrypte = new System.Windows.Forms.Label();
            this.lbMessageDecrypte = new System.Windows.Forms.Label();
            this.CleCryptageMD5 = new System.Windows.Forms.TextBox();
            this.MessageCryptageMD5 = new System.Windows.Forms.TextBox();
            this.MessageDecryptageMD5 = new System.Windows.Forms.TextBox();
            this.btnCrypterMD5 = new System.Windows.Forms.Button();
            this.btnDecrypterMD5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CleCryptagePerso)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCrypter
            // 
            this.btnCrypter.BackColor = System.Drawing.Color.Sienna;
            this.btnCrypter.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrypter.Location = new System.Drawing.Point(217, 149);
            this.btnCrypter.Name = "btnCrypter";
            this.btnCrypter.Size = new System.Drawing.Size(237, 66);
            this.btnCrypter.TabIndex = 0;
            this.btnCrypter.Text = "Cryptage Personnel";
            this.btnCrypter.UseVisualStyleBackColor = false;
            this.btnCrypter.Click += new System.EventHandler(this.btnCrypter_Click);
            // 
            // MessageACrypter
            // 
            this.MessageACrypter.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.MessageACrypter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MessageACrypter.Location = new System.Drawing.Point(217, 57);
            this.MessageACrypter.Name = "MessageACrypter";
            this.MessageACrypter.Size = new System.Drawing.Size(571, 30);
            this.MessageACrypter.TabIndex = 1;
            // 
            // MessageCrypte
            // 
            this.MessageCrypte.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.MessageCrypte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MessageCrypte.Location = new System.Drawing.Point(217, 232);
            this.MessageCrypte.Name = "MessageCrypte";
            this.MessageCrypte.Size = new System.Drawing.Size(239, 30);
            this.MessageCrypte.TabIndex = 2;
            // 
            // btnDecrypter
            // 
            this.btnDecrypter.BackColor = System.Drawing.Color.Sienna;
            this.btnDecrypter.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecrypter.Location = new System.Drawing.Point(217, 280);
            this.btnDecrypter.Name = "btnDecrypter";
            this.btnDecrypter.Size = new System.Drawing.Size(237, 65);
            this.btnDecrypter.TabIndex = 4;
            this.btnDecrypter.Text = "Decryptage Personnel";
            this.btnDecrypter.UseVisualStyleBackColor = false;
            this.btnDecrypter.Click += new System.EventHandler(this.btnDecrypter_Click);
            // 
            // MessageDecrypte
            // 
            this.MessageDecrypte.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.MessageDecrypte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MessageDecrypte.Location = new System.Drawing.Point(217, 364);
            this.MessageDecrypte.Name = "MessageDecrypte";
            this.MessageDecrypte.Size = new System.Drawing.Size(239, 30);
            this.MessageDecrypte.TabIndex = 5;
            // 
            // CleCryptagePerso
            // 
            this.CleCryptagePerso.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CleCryptagePerso.Location = new System.Drawing.Point(217, 104);
            this.CleCryptagePerso.Name = "CleCryptagePerso";
            this.CleCryptagePerso.Size = new System.Drawing.Size(37, 27);
            this.CleCryptagePerso.TabIndex = 6;
            // 
            // lbMessage
            // 
            this.lbMessage.AutoSize = true;
            this.lbMessage.BackColor = System.Drawing.Color.Salmon;
            this.lbMessage.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMessage.Location = new System.Drawing.Point(12, 60);
            this.lbMessage.Name = "lbMessage";
            this.lbMessage.Size = new System.Drawing.Size(161, 25);
            this.lbMessage.TabIndex = 7;
            this.lbMessage.Text = "Message à crypter";
            // 
            // lbCle
            // 
            this.lbCle.AutoSize = true;
            this.lbCle.BackColor = System.Drawing.Color.Salmon;
            this.lbCle.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCle.Location = new System.Drawing.Point(12, 102);
            this.lbCle.Name = "lbCle";
            this.lbCle.Size = new System.Drawing.Size(114, 25);
            this.lbCle.TabIndex = 8;
            this.lbCle.Text = "Clé cryptage";
            // 
            // lbMessageCrypte
            // 
            this.lbMessageCrypte.AutoSize = true;
            this.lbMessageCrypte.BackColor = System.Drawing.Color.Salmon;
            this.lbMessageCrypte.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMessageCrypte.Location = new System.Drawing.Point(12, 235);
            this.lbMessageCrypte.Name = "lbMessageCrypte";
            this.lbMessageCrypte.Size = new System.Drawing.Size(140, 25);
            this.lbMessageCrypte.TabIndex = 10;
            this.lbMessageCrypte.Text = "Message crypté";
            // 
            // lbMessageDecrypte
            // 
            this.lbMessageDecrypte.AutoSize = true;
            this.lbMessageDecrypte.BackColor = System.Drawing.Color.Salmon;
            this.lbMessageDecrypte.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMessageDecrypte.Location = new System.Drawing.Point(12, 367);
            this.lbMessageDecrypte.Name = "lbMessageDecrypte";
            this.lbMessageDecrypte.Size = new System.Drawing.Size(160, 25);
            this.lbMessageDecrypte.TabIndex = 12;
            this.lbMessageDecrypte.Text = "Message décrypté";
            // 
            // CleCryptageMD5
            // 
            this.CleCryptageMD5.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.CleCryptageMD5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CleCryptageMD5.Location = new System.Drawing.Point(549, 104);
            this.CleCryptageMD5.Name = "CleCryptageMD5";
            this.CleCryptageMD5.Size = new System.Drawing.Size(239, 30);
            this.CleCryptageMD5.TabIndex = 13;
            // 
            // MessageCryptageMD5
            // 
            this.MessageCryptageMD5.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.MessageCryptageMD5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MessageCryptageMD5.Location = new System.Drawing.Point(549, 232);
            this.MessageCryptageMD5.Name = "MessageCryptageMD5";
            this.MessageCryptageMD5.Size = new System.Drawing.Size(239, 30);
            this.MessageCryptageMD5.TabIndex = 14;
            // 
            // MessageDecryptageMD5
            // 
            this.MessageDecryptageMD5.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.MessageDecryptageMD5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MessageDecryptageMD5.Location = new System.Drawing.Point(549, 364);
            this.MessageDecryptageMD5.Name = "MessageDecryptageMD5";
            this.MessageDecryptageMD5.Size = new System.Drawing.Size(239, 30);
            this.MessageDecryptageMD5.TabIndex = 15;
            // 
            // btnCrypterMD5
            // 
            this.btnCrypterMD5.BackColor = System.Drawing.Color.Sienna;
            this.btnCrypterMD5.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrypterMD5.Location = new System.Drawing.Point(549, 149);
            this.btnCrypterMD5.Name = "btnCrypterMD5";
            this.btnCrypterMD5.Size = new System.Drawing.Size(237, 66);
            this.btnCrypterMD5.TabIndex = 16;
            this.btnCrypterMD5.Text = "Cryptage MD5";
            this.btnCrypterMD5.UseVisualStyleBackColor = false;
            this.btnCrypterMD5.Click += new System.EventHandler(this.btnCrypterMD5_Click);
            // 
            // btnDecrypterMD5
            // 
            this.btnDecrypterMD5.BackColor = System.Drawing.Color.Sienna;
            this.btnDecrypterMD5.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecrypterMD5.Location = new System.Drawing.Point(549, 280);
            this.btnDecrypterMD5.Name = "btnDecrypterMD5";
            this.btnDecrypterMD5.Size = new System.Drawing.Size(237, 65);
            this.btnDecrypterMD5.TabIndex = 17;
            this.btnDecrypterMD5.Text = "Decryptage MD5";
            this.btnDecrypterMD5.UseVisualStyleBackColor = false;
            this.btnDecrypterMD5.Click += new System.EventHandler(this.btnDecrypterMD5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDecrypterMD5);
            this.Controls.Add(this.btnCrypterMD5);
            this.Controls.Add(this.MessageDecryptageMD5);
            this.Controls.Add(this.MessageCryptageMD5);
            this.Controls.Add(this.CleCryptageMD5);
            this.Controls.Add(this.lbMessageDecrypte);
            this.Controls.Add(this.lbMessageCrypte);
            this.Controls.Add(this.lbCle);
            this.Controls.Add(this.lbMessage);
            this.Controls.Add(this.CleCryptagePerso);
            this.Controls.Add(this.MessageDecrypte);
            this.Controls.Add(this.btnDecrypter);
            this.Controls.Add(this.MessageCrypte);
            this.Controls.Add(this.MessageACrypter);
            this.Controls.Add(this.btnCrypter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.CleCryptagePerso)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCrypter;
        private System.Windows.Forms.TextBox MessageACrypter;
        private System.Windows.Forms.TextBox MessageCrypte;
        private System.Windows.Forms.Button btnDecrypter;
        private System.Windows.Forms.TextBox MessageDecrypte;
        private System.Windows.Forms.NumericUpDown CleCryptagePerso;
        private System.Windows.Forms.Label lbMessage;
        private System.Windows.Forms.Label lbCle;
        private System.Windows.Forms.Label lbMessageCrypte;
        private System.Windows.Forms.Label lbMessageDecrypte;
        private System.Windows.Forms.TextBox CleCryptageMD5;
        private System.Windows.Forms.TextBox MessageCryptageMD5;
        private System.Windows.Forms.TextBox MessageDecryptageMD5;
        private System.Windows.Forms.Button btnCrypterMD5;
        private System.Windows.Forms.Button btnDecrypterMD5;
    }
}

