using System;
using System.Collections.Generic;

namespace Learning_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Djur djur = new Djur();
            Hund hund = new Hund();
            Svamp svamp = new Svamp();
            djur.Name = "Ett djur";

            hund.Name = "Gråhund";
            hund.Ben = 4;
            hund.Svans = "Yvig knor";
            hund.Nivå = 5;
            hund.Beskrivning = "kraftig käcke med hugtänder";

            svamp.Name = "Flugsvamp";
            svamp.Nivå = 2;
            svamp.Utsaende = "Röd med vita prickar";
            svamp.Beskrivning = "Giftig att äta";

            //djur.Info();
            //hund.Info();

            Console.WriteLine("Är hund et barn av djur: " + (hund is Djur));//eto proverka 
            (hund as Djur).Info();

            Console.WriteLine("-----------------");

            List<Djur> djuList = new List<Djur>();
            djuList.Add(hund);
            djuList.Add(djur);

            foreach (Djur item in djuList)
            {
                if (item is Hund)//Hund zdes dlya togo chtoby proverit hund
                {

                    item.Info();
                }
            }
            //Console.WriteLine(djur); // Toje chto Console.WriteLine(djur.ToString());
            Console.WriteLine("-----------------");
            List<IFarlig> farliga = new List<IFarlig>();
            farliga.Add(svamp);
            farliga.Add(hund);

            foreach (IFarlig item in farliga)
            {
                item.FarligIngo();
            }

            Console.ReadKey();
        }
    }
}
