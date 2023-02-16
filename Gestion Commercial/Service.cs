using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Commercial
{
    internal class Service
    {
        public string nom { get; set; }
        public Commercial[] tab = new Commercial[10];

        public int effectif { get; set; }

        public Service(string nom)
        {
            this.nom = nom;
        }
        internal void ajouterCom(Commercial test)
        {
            tab[effectif] = test;
            effectif++;
        }

        public void AfficherCommerciaux()
        {
            Console.WriteLine($"Liste des commerciaux :");
            for (int i = 0; i < effectif; i++)
            {
                Console.WriteLine("\n" + tab[i]);
            }
            Console.WriteLine("------------------------------");
        }

        public void ReturnPlusAge()
        {
            Commercial comAge = this.tab[0];
            
            foreach (Commercial com in this.tab)
            {
                if (com != null && com.AnneeNaissance < comAge.AnneeNaissance)
                {
                    comAge = com;
                }
            }
            Console.WriteLine($"Le plus âgé :\n{comAge} \nService : {this.nom}");
        }
    }
} 

