using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6apreltask
{
    internal abstract class Square : Figure
    {
        
        
            private int _side;

            protected Square(int side)
            {
                Side=side;

            }

            public int Side
            {
                get { return _side; }
                set
                {
                    if (value>0)
                        _side = value;
                }
            }
        }


    public override void CalcArea(int side)
    {
        int square = side*side;
    }

}

