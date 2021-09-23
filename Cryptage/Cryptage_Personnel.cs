using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cryptage
{
    class Cryptage_Personnel
    {
        //variables
        private string texte;
        private int cle;

        //Constructeurs
        public Cryptage_Personnel(string messageCryptage, int cleCryptage)
        {
            this.texte = messageCryptage;
            this.cle = cleCryptage;


        }

        //Fonction qui permet le décalage des lettres afin de crypter un message
        public string CrypterMessage()
        {
            //Récupération texte
            char[] nouveauMessage = texte.ToCharArray();
            //Boucle qui permet de parcourir la chaine de caractères du message à crypter
            for (int i=0; i<nouveauMessage.Length; i++)
            {
                char alphabetCryptage = nouveauMessage[i];
                alphabetCryptage = (char)(alphabetCryptage + cle);

                nouveauMessage[i] = alphabetCryptage;

            }
            return new string(nouveauMessage);
        }

        //Fonction permettant d'enlever le décalage des lettres effectuées précédemment et ainsi décrypter le messsage
        public string DecrypterMessage()
        {
            //récupération texte
            char[] nouveauMessage = texte.ToCharArray();
            //Boucle qui permet de parcourir la chaine de caractères du message à crypter
            for (int i=0; i<nouveauMessage.Length; i++)
            {
                char alphabetCryptage = nouveauMessage[i];
                alphabetCryptage = (char)(alphabetCryptage - cle);

                nouveauMessage[i] = alphabetCryptage;
            }
            return new string(nouveauMessage);
        }
    }
}
