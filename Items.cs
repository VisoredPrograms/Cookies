using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cookie_Clicker
{
    public class Items
    {
        public int CookieAmount
        { get; set; }

        public double CookieCoins
        { get; set; }

        public int Upgrade
        { get; set; } = 1;

        public bool PurchasedClicker
        { get; set;}

        public bool PurchasedUpgrade
        { get; set; }
    }
}
