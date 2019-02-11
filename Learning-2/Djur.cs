using System;
using System.Collections.Generic;
using System.Text;

namespace Learning_2
{
    class Djur
    {
        public string Name { get; set; }

        public virtual void Info()
        {
            Console.WriteLine("Djur: " + Name);//pokazivaet imya obeih klassov potomychto odno imya na dvoih
        }

        public override string ToString()
        {
            return base.ToString() + " Override";
        }
    }
}
