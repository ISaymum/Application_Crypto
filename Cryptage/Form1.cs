using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;

namespace Cryptage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Cryptage personnel
        private void btnCrypter_Click(object sender, EventArgs e)
        {
            int cle = (int)CleCryptagePerso.Value;
            Cryptage_Personnel CryptMess = new Cryptage_Personnel(MessageACrypter.Text, cle);
            MessageCrypte.Text = CryptMess.CrypterMessage();
        }

        private void btnDecrypter_Click(object sender, EventArgs e)
        {
            int cle = (int)CleCryptagePerso.Value;
            Cryptage_Personnel DecryptMess = new Cryptage_Personnel(MessageCrypte.Text, cle);
            MessageDecrypte.Text = DecryptMess.DecrypterMessage();
        }

        /*--------------------------------------------------------------------------------------------------------------*/
        //Cryptage .Net MD5 
        private void btnCrypterMD5_Click(object sender, EventArgs e)
        {
            //Récupération du message à crypter
            byte[] data = UTF8Encoding.UTF8.GetBytes(MessageACrypter.Text);
            //Instanciation MD5
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                //Récupération de la clé 
                byte[] cle = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(CleCryptageMD5.Text));
                using (TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider()
                {
                    Key = cle,
                    Mode = CipherMode.ECB,
                    Padding = PaddingMode.PKCS7
                })
                {
                    ICryptoTransform transform = tripDes.CreateEncryptor();
                    byte[] results = transform.TransformFinalBlock(data, 0, data.Length);
                    //Affiche le message crypté après conversion
                    MessageCryptageMD5.Text = Convert.ToBase64String(results, 0, results.Length);
                }
            }
        }

        //Décryptage .Net MD5
        private void btnDecrypterMD5_Click(object sender, EventArgs e)
        {
            //Récupération du message à crypter
            byte[] data = Convert.FromBase64String(MessageCryptageMD5.Text);
            //Instanciation MD5
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                //Récupération de la clé 
                byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(CleCryptageMD5.Text));
                using (TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider()
                { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                {
                    ICryptoTransform transform = tripDes.CreateDecryptor();
                    byte[] results = transform.TransformFinalBlock(data, 0, data.Length);
                    //Affiche le message décrypté après conversion
                    MessageDecryptageMD5.Text= UTF8Encoding.UTF8.GetString(results);
                }
            }
        }
    }
}
