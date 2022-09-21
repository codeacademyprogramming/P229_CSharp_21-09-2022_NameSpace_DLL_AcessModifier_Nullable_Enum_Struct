using System;
using System.Collections.Generic;
using System.Text;

namespace NullableEnumStruct
{
    struct Area
    {
        public int A;
        public int B { get; set; }

        public Area(int a,int b)
        {
            A = a;
            B = b;
        }

        public int CalculateArea()
        {
            return A * B;
        }
    }
}
