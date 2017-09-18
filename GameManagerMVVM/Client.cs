using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameManagerMVVM
{
    public class Client
    {
        private string nom;
        private string genre;
        private string type;
        private int age;
        private double prix;

        public string Nom { get => nom; set => nom = value; }
        public string Genre { get => genre; set => genre = value; }
        public string Type { get => type; set => type = value; }
        public int Age { get => age; set => age = value; }
        public double Prix { get => prix; set => prix = value; }
    }
}
