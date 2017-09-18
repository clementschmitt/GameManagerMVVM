using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace GameManagerMVVM
{
    public class FicheJVViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public void NotifyPropertyChanged([CallerMemberName] string str="")
        {
            if(PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(str));
            }
        }

        private ObservableCollection<JV> fiches;

        public ObservableCollection<JV> Fiches
        {
            get { return fiches; }

            set
            {
                if (value != fiches)
                {
                    fiches = value;
                    NotifyPropertyChanged();
                }
            }
        }

        private JV ficheSelectionnee;

        public JV FicheSelectionnee
        {
            get { return ficheSelectionnee; }

            set
            {
                if(value != ficheSelectionnee)
                {
                    ficheSelectionnee = value;
                    NotifyPropertyChanged();
                }
            }
        }

        // Consctruteur
        public FicheJVViewModel()
        {
            fiches = new ObservableCollection<JV>();

            FicheSelectionnee = new JV()
            {
                Nom = "Far Cry 5",
                Genre = "FPS action-aventure",
                Age = 18,
                Prix = 69.99
            };

            fiches.Add(FicheSelectionnee);
        }

        private ICommand remiseAZeroDeLaFicheSelectionnee = new RelayCommand<JV>((jv) =>
        {
            jv.Nom = "";
            jv.Genre = "";
            jv.Prix = 0;
            jv.Age = 0;
        });

        public ICommand RemiseAZeroDeLaFicheSelectionnee
        {
            get { return remiseAZeroDeLaFicheSelectionnee; }
            
        }

        private ICommand ajoutFicheJV;
        private ICommand retraitFicheJV;
        private ICommand editionFicheJV;

        public ICommand AjoutFicheJV
        {
            get
            {
                if(ajoutFicheJV == null)
                {
                    ajoutFicheJV = new RelayCommand<Object>((obj) => Fiches.Add(new JV()));
                }
                return ajoutFicheJV;
            }
        }

        public ICommand RetraitFicheJV
        {
            get
            {
                if (retraitFicheJV == null)
                {
                    retraitFicheJV = new RelayCommand<JV>((jv) => Fiches.Remove(jv));
                }
                return retraitFicheJV;
            }
        }

        public ICommand EditionFicheJV
        {
            get
            {
                if (editionFicheJV == null)
                {
                    editionFicheJV = new RelayCommand<JV>((jv) => FicheSelectionnee = jv);
                }
                return editionFicheJV;
            }
        }
    }
}
