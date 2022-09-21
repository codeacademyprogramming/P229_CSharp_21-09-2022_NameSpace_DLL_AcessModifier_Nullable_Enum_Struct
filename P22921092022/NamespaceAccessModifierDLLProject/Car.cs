using System;
using System.Collections.Generic;
using System.Text;
using DemoNS;
using DemoNS.NestedDemoNS;

namespace NamespaceAccessModifierDLLProject
{
    class Car
    {
        public string Brand;

        public Car()
        {
            MyClass myClass = new MyClass();
        }
    }
}
