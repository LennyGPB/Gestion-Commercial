using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Commercial
{
    class Commercial
    {
        public string nom { get; set; }
        public string prenom { get; set; }
        public int AnneeNaissance { get; set; }
        public Categorie categorie { get; set; }
        public Service service { get; set; }


        public Commercial(string nom, string prenom, int AnneeNaissance, Categorie categorie, Service service = null)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.AnneeNaissance = AnneeNaissance;
            this.categorie = categorie;
            this.service = service;
            if (service != null)
            {
                service.ajouterCom(this);
            }

        }

        public int ReturnAge()
        {
            int diff = DateTime.Now.Year - AnneeNaissance;
            return diff;
        }

        public void Compare(Commercial c)
        {
            if (nom == nom)
            {
                Console.WriteLine("2 commerciales ont le même nom");
            }
            if (prenom == prenom)
            {
                Console.WriteLine("2 commerciales ont le même prenom");
            }
            if ((nom == nom) && (prenom == prenom))
            {
                Console.WriteLine("2 commerciales ont le même prénom et le même nom");
            }
        }

        public override string ToString()
        {
            string conversion = $"{nom} / {prenom} / {AnneeNaissance} \n" + categorie.ToString();
            return conversion;
        }
    }


}
