using Gestion_Commercial;
using static System.Net.Mime.MediaTypeNames;

// Lenny Gomes

Categorie p1 = new Categorie("Salarié", "1");
Categorie p2 = new Categorie("Indépendant", "2");

Service s1 = new Service("National");
Service s2 = new Service("International");

Commercial c1 = new Commercial("Lenny", "Gomes", 2002, p1,s1);
Commercial c2 = new Commercial("Lenny", "Gromez", 2004, p2,s1);
Commercial c3 = new Commercial("David", "LaFarge", 1999, p1,s1);
Commercial c4 = new Commercial("Jean", "Yves", 1990, p1, s1);

s1.AfficherCommerciaux();
s1.ReturnPlusAge();