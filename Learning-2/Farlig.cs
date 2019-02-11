using System;
using System.Collections.Generic;
using System.Text;

namespace Learning_2
{
    interface IFarlig
    {
        int Nivå { get; set; }

        string Beskrivning { get; set; }

        void FarligIngo();
    }
}
