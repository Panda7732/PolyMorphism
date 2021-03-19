using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms; //Needed for messagebox

namespace Polymorphism
{
    class Animal
    {
        //field
        private string _species;

        //constructor
        public Animal(string species)
        {
            _species = species;
        }

        //species property
        public string species
        {
            get { return _species; }
            set { _species = value; }
        }

        //MakeSound method
        public virtual void MakeSound()
        {
            MessageBox.Show("Grrrrr");
        }

    }
}
