using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module08dz
{
    public class Test
    {
        int[] mas;

        public int SizeMas { private set; get; }
        public void Add(int number)
        {
            Array.Resize(ref mas, mas.Length + 1);
            mas[mas.Length - 1] = number;
            SizeMas = mas.Length;
        }
       
        public Test()
        {
            mas = new int[0];
            SizeMas = mas.Length;
        }

        public Test(int size)
        {
            mas = new int[size];
            SizeMas = mas.Length;
        }

        public void InSet(int number, int pos)
        {
            Array.Resize(ref mas, mas.Length + 1);

            int i;
            for (i = mas.Length - 1; i > pos && i > 0; i--)
            {
                mas[i] = mas[i - 1];
            }
            mas[i] = number;

            SizeMas = mas.Length;
        }


        public int this[int index]
        {
            get
            {
                return mas[index];
            }
            set
            {
                mas[index] = (int)Math.Pow(value, 2);
            }
        }
    }
}
