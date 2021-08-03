using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCSharp
{
    public delegate double AddShippingFee(double Price);
    public delegate double AddRiskFee(double price);
    class ShippingChargesInfo
    {
        
        public double ShippingFee(double price)
        {
            return 0.0;
        }

        public void CalculateShippingFee()
        {
            string zone = Console.ReadLine();
            double price = double.Parse(Console.ReadLine());
            switch (zone)
            {
                case "zone1":
                    
                default:
                    break;
            }
        }
    }

    class Zone
    {
        double FeePercent;
        double RiskPercent;
    }
    class Zone1: Zone
    {

    }
        class Zone2: Zone
    {

    }
    class Zone3: Zone
    { }
    class Zone4 : Zone { }
}
