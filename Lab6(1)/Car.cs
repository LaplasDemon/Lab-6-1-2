using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_1_
{
    public class Car : ICar
    {
        public string mark { get; set; }
        private string color { get; set; }
        private string numb { get; set; }
        private int year { get; set; }
        private string owner { get; set; }
        public Car() 
        { 
            this.mark = "Temp Mark"; 
            this.color = "Temp COlor"; 
            this.numb = "Temp Numb"; 
            this.year = 1111; 
            this.owner = "Temp Owner"; 
        }

        public Car(string mr, string c, string n, int y, string ow)
        {
            if (mr.Length <= 0)
            {
                Console.WriteLine("Wrong mark\n"); return;
            }
            else
            if (c.Length <= 1)
            {
                Console.WriteLine("Wrong color\n"); return;
            }
            else
            if (n.Length <= 1)
            {
                Console.WriteLine("Wrong number\n"); return;
            }
            else
            if ((1900 > y) || (y > 2021))
            {
                Console.WriteLine("Wrong year\n"); return;
            }
            else
            if (ow.Length <= 1)
            {
                Console.WriteLine("Wrong owner\n"); return;
            }
            else
            {
                this.mark = mr;
                this.color = c;
                this.numb = n;
                this.year = y;
                this.owner = ow;
            }
        }

        public void showInfo()
        {
            Console.WriteLine(mark + " , " + color + " , " + numb + " , " + year + " , " + owner);
        }
    }
}
