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
            Countryside blue = new Countryside();
            blue.launch();
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
        village First;
        village Last;
        village Temp;


            public void launch()
        {
            First = Maple;
            Last = Ajax;
            Maple.VillageName = "Maple";
            Maple.nextVillage = Toronto;
            Maple.previousVillage = null;
             Toronto.VillageName = "Toronto";
            Toronto.nextVillage = Ajax;
            Toronto.previousVillage = Maple;
            Ajax.VillageName = "Ajax";
            Ajax.nextVillage = null;
            Ajax.previousVillage = Toronto;

            Console.WriteLine (this.displayMap());
        }
        public string displayMap()
        {
            string listofCities = "";
            /* What problem do I need to Solve? */
            /* we need to print All the Cities in Our Area.*/

            listofCities = listofCities + First.VillageName + "----------";
            Temp = First.nextVillage;
            listofCities = listofCities + Temp.VillageName + "---------";


            return listofCities;
        }
    }
}
