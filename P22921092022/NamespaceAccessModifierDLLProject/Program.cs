using DemoNS;
using DemoNS.NestedDemoNS;
using System;
using DemoLibraryInternalSoloutions;
using DemoLibrary;

namespace NamespaceAccessModifierDLLProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Test test = new Test();
            MyClass myClass = new MyClass();

            Car car = new Car();

            DemoNS.Car car1 = new DemoNS.Car();

            DemoNS.Test test1 = new DemoNS.Test();

            Console.WriteLine();

            User user = new User();

            Product product = new Product();
        }
    }
}

namespace DemoNS 
{ 
    class Car : User
    {
        public Car()
        {
            Test = "";
        }
    }

    class Test : Product
    {
        public Test()
        {
            Code = "";
        }
    }

    namespace NestedDemoNS
    {
        class MyClass
        {

        }
    }
}

