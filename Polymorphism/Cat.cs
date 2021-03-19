using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms; //needed for Messagebox

namespace Polymorphism
{
    class Cat : Animal
    {
        //field
        private string _name;

        //constructor
        public Cat(string name)
            :base("Cat")
        {
            _name = name;
        }

        //Name property
        public string Name
        {
            get { return _name; }
            set { _name = value; }

        }

        //MakeSound Method
        public override void MakeSound()
        {
            MessageBox.Show("Meow");
        }

    }
}
