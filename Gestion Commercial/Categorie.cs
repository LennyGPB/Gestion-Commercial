using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Commercial
{
    internal class Categorie
    {
        public string codeCategorie { get; set; }
        public string libCategorie { get; set; }

        public Categorie(string codeCategorie, string libCategorie)
        {
            this.codeCategorie = codeCategorie;
            this.libCategorie = libCategorie;
        }

        public override string ToString()
        {
            return $"Code de la Categorie : {codeCategorie}\nlibellé de la Catégorie : {libCategorie}" ;
        }
    }
}
