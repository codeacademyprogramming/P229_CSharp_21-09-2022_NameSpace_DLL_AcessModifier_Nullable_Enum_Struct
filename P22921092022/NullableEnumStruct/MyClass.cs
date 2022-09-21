using System;
using System.Collections.Generic;
using System.Text;

namespace NullableEnumStruct
{
    class MyClass
    {
        public WeekDay WeekDay;
        public WeekDay MyProperty { get; set; }

        public WeekDay Test(WeekDay weekDay)
        {
            return WeekDay.Monday;
        }
    }
}
