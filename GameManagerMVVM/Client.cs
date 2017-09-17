using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PremiereUtilisationDataContext
{
    public class Client
    {
        private string nom;
        private string prenom;
        private string sexe;
        private int age;

        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public string Sexe { get => sexe; set => sexe = value; }
        public int Age { get => age; set => age = value; }
    }
}
