using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace LearnCSharp
{
    class Collections
    {
        const int a = 10;
        readonly int b;
        private decimal ROI = 7.5M;

        public decimal MyROI { get { return ROI; }

            set
            {
                if (value > 10) throw new Exception("Invalid ROI.");
            }
        }

        public Collections()
        {
            b = 100;
        }
        // ArrayList
        public static void SampleArrayList()
        {
            ArrayList al = new ArrayList();
            al.Add(new object());
            al.Add(2);
            al.Add(null);
            al.Add(true);

            foreach (var item in al)
            {
                Console.WriteLine($"item {al.IndexOf(item)}:" + item);// + item != null ? item.ToString(): "null");
            }

            List<Collections> li = new List<Collections>();
            Collections col = new Collections();
            li.Add(col);

            foreach (var item in li)
            {
                (col as Collections).print(null);
                col.ROI = 6.5M;
                // this line raises exception
                col.MyROI = 11M;
            }
                
        }

        public void print(System.Collections.Generic.Dictionary<string, int> dict)
        {
            Console.WriteLine("collections print");
        }

    }
}
