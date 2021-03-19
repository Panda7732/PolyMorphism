using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms; //needed for messagebox

namespace Polymorphism
{
    class Dog : Animal
    {
        //field
        private string _name;

        //constructor
        public Dog(string name)
            : base("Dog")
        {
            _name = name;
        }

        //Name property
        public string Name
        {
            get { return _name; }
            set { _name = value; }

        }

        //MakeSound method
        public override void MakeSound()
        {
            MessageBox.Show("Woof! Woof!");
        }

    }
}
