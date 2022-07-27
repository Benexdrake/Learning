using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Einkaufsliste_Console
{
    public class Items
    {
        // Eine kleine Klasse mit der Anzahl von einem Produkt, dem Produktnamen, den Ladennamen und der Person die diese Items braucht.
        public int Anzahl { get; set; }
        public string Person { get; set; }
        public string ProduktName { get; set; }
        public string LadenName { get; set; }
    }
}
