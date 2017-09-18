using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameManagerMVVM
{
    public class Client : INotifyPropertyChanged
    {
        private string nom;
        private string genre;
        private string type;
        private int age;
        private double prix;
        public event PropertyChangedEventHandler PropertyChanged;


        public string Nom
        {
            get { return nom; }

            set
            {
                if (value != nom)
                {
                    nom = value;
                    if (PropertyChanged != null)
                        PropertyChanged(this, new PropertyChangedEventArgs("Nom"));
                }
            }
        }

        public string Genre
        {
            get { return genre; }

            set
            {
                if(value != genre)
                {
                    genre = value;
                    if (PropertyChanged != null)
                        PropertyChanged(this, new PropertyChangedEventArgs("Genre"));
                }
            }
        }

        public string Type
        {
            get { return type; }

            set
            {
                if (value != type)
                {
                    type = value;
                    if (PropertyChanged != null)
                        PropertyChanged(this, new PropertyChangedEventArgs("Type"));
                }
            }
        }

        public int Age
        {
            get { return age; }

            set
            {
                if (value != age)
                {
                    age = value;
                    if (PropertyChanged != null)
                        PropertyChanged(this, new PropertyChangedEventArgs("Age"));
                }
            }
        }

        public double Prix
        {
            get { return prix; }

            set
            {
                if (value != prix)
                {
                    prix = value;
                    if (PropertyChanged != null)
                        PropertyChanged(this, new PropertyChangedEventArgs("Prix"));
                }
            }
        }
    }
}
