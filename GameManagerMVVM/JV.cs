using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameManagerMVVM
{
    public class JV : INotifyPropertyChanged
    {
        private string nom;
        private string genre;
        private int age;
        private double prix;
        public event PropertyChangedEventHandler PropertyChanged;


        public string Nom
        {
            get { return nom; }

            set
            {
                if (value != nom) //si la valeur a été modifiée dans ce cas, je la met à jour et j'annonce que la valeur a été changée.
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
