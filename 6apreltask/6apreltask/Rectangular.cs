using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6apreltask
{
    public class Rectangular
    {
        private int _width;

        protected Rectangular(int width,int lenght)
        {
            Width=width;
            Lenght=lenght;
        }

        public int Width
        {
            get { return _width; }
            set
            {
                if (value>0)
                    _width = value;
            }
        }
            private int _lenght;

        

        public int Lenght
        {
            get { return _lenght; }
            set
            {
                if (value>0)
                    _lenght = value;
            }

        }
        public override void CalcArea(int lenght ,int width)
        { 
            int rec = lenght*width;
            Console.WriteLine(rec);
        }
    }
    }

