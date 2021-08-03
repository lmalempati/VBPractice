using System;

namespace ShippingZoneInfo
{
    public delegate void DelCalcFee(decimal price, ref decimal fee);
    class Program
    {
        static void Main(string[] args)
        {
            string ZoneName;
            do
            {
                Console.WriteLine("Enter Zone name.");
                ZoneName = Console.ReadLine();
                DestinationZone theZone = DestinationZone.ShippingDestinationZone(ZoneName);
                decimal price = 0.0M;
                decimal fee = 0.0M;
                if (theZone != null)
                {
                    if (theZone is DestinationZone1)
                    {
                        (theZone as DestinationZone1).PrintZoneName();
                    }
                    Console.WriteLine("Enter price.");
                    try
                    {
                        decimal.TryParse(Console.ReadLine(), out price);
                    }
                    catch (Exception)
                    {

                    }

                    DelCalcFee CalFee = theZone.CalcShippingFee;
                    if (theZone.IsHighRiskZone)
                    {
                        // anonymous delegate example
                        CalFee += delegate (decimal thePrice, ref decimal theFee)
                        {
                            theFee += 25;
                        };
                    }
                    CalFee(price, ref fee);
                    Console.WriteLine($"Total fee: {fee}");
                }
                else
                    Console.WriteLine("Hmm, you seem to have entered incorrect zone, please enter a valid zone");

            } while (ZoneName != "exit");

        }
    }
}
