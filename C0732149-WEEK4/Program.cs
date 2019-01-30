using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C0732149_WEEK4
{
    class Program
    {
        static void Main(string[] args)
        {


        }
    }
           
    class village
    {
        //Node is an ADT
        //What Kind Of Data Do We Need In a Node?

        public village nextVillage;
        public village previousVillage;
        public string VillageName;
        public bool isAstrildeHere = false;
    }
    class Countryside
    {
        village Maple = new village();
        village Toronto = new village();
        village Ajax = new village();

            public void launch()
        {
            Maple.VillageName = "Maple";
            Maple.nextVillage = Toronto;
            Maple.previousVillage = null;
             Toronto.VillageName = "Toronto";
            Toronto.nextVillage = Ajax;
            Toronto.previousVillage = Maple;
            Ajax.VillageName = "Ajax";
            Ajax.nextVillage = null;
            Ajax.previousVillage = Toronto;

        }
    }
}
