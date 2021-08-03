using System;
using System.Collections.Generic;
using System.Text;

namespace ShippingZoneInfo
{
    // with this abstract class we impose the derived classes, what to implement at the minimum
    // Also, caller use this to refer to derived class's instances.
    public abstract class DestinationZone
    {
        public bool IsHighRiskZone;
        public abstract void CalcShippingFee(decimal price, ref decimal fee);
        public static DestinationZone ShippingDestinationZone(string ZoneName)
        {
            switch (ZoneName)
            {
                case "zone1":
                    return new DestinationZone1();
                case "zone2":
                    return new DestinationZone2();
                case "zone3":
                    return new DestinationZone3();
                case "zone4":
                    return new DestinationZone4();
                default:
                   return null;
            }
        }
    }

    public class DestinationZone1 : DestinationZone
    {
        public DestinationZone1()
        {
            this.IsHighRiskZone = false;
        }
        public override void CalcShippingFee(decimal price, ref decimal fee)
        {
            fee = price + 0.25M * price;
        }

        public void PrintZoneName()
        {
            Console.WriteLine("In Zone1");
        }
    }
    public class DestinationZone2 : DestinationZone
    {
        public DestinationZone2()
        {
            this.IsHighRiskZone = true;
        }
        public override void CalcShippingFee(decimal price, ref decimal fee)
        {
            fee = price + 0.12M * price;
        }
    }
    public class DestinationZone3 : DestinationZone
    {
        public DestinationZone3()
        {
            this.IsHighRiskZone = false;
        }
        public override void CalcShippingFee(decimal price, ref decimal fee)
        {
            fee = price + 0.08M * price;
        }
    }
    public class DestinationZone4 : DestinationZone
    {
        public DestinationZone4()
        {
            this.IsHighRiskZone = true;
        }
        public override void CalcShippingFee(decimal price, ref decimal fee)
        {
            fee = price + 0.04M * price;
        }
    }
}
