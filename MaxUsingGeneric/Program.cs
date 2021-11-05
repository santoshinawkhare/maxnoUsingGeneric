using System;

namespace MaxUsingGeneric
{
    class Program
    {
        static void Main(string[] args)
        {
             Console.WriteLine("Hello World!");

            /*Console.WriteLine("Maximum Int value ");
            int maxIntNumber = UC1.MaximumIntegerNumber(50, 150, 600);
            Console.WriteLine(maxIntNumber);*/


            /*Console.WriteLine("Maximum float value");
            UC2 find = new UC2();
            Console.WriteLine(find.MaximumFloatNumber(10.5f, 20.5f, 30.5f));*/

            /*Console.WriteLine("Maximum string name ");
            string maxString = UC3.MaximumString("Apple", "Peach", "Banana");
            Console.WriteLine(maxString);*/


            int maxNumber = UC4.findMaximum<int>(100, 300, 500);
            double maxdoubleNumber = UC4.findMaximum<double>(5.6, 3.5, 5.9);
            string maxStringName = UC4.findMaximum<string>("Apple", "Peach", "Banana");
            Console.WriteLine(maxNumber);
            Console.WriteLine(maxdoubleNumber);
            Console.WriteLine(maxStringName);

            Console.WriteLine("Generic value in use case 4 ");
            //int[] arr = { 11, 22, 33};
            UC4<int> obj = new UC4<int>(11, 22, 10);
            obj.maxMethod();

            UC4<double> genericDouble = new UC4<double>(1.2, 340.4, 44.36);
            genericDouble.maxMethod();

            UC4<string> genericString = new UC4<string>("apple", "mango", "grapes");
            genericString.maxMethod();
            Console.ReadLine();






            /* Console.WriteLine("Generic value in use case 5 ");

             UC5PrintMaxMethodToStdOut<int> generic = new UC5PrintMaxMethodToStdOut<int>(11, 3442, 44, 40, 56, 77);
             generic.printMaxValue();
             *//*
             // double[] doubleArray = { 1.2, 340.4, 44.36, 51.55, 67.78 };
            UC5PrintMaxMethodToStdOut<double> genericDouble = new UC5PrintMaxMethodToStdOut<double>({ 44.5,1.2, 340.4, 44.36,);
              genericDouble.printMaxValue();

             //string[] stringArray = { "apple", "mango", "grapes", "banana", "pineapple" };
            UC5PrintMaxMethodToStdOut<string> genericString = new UC5PrintMaxMethodToStdOut<string>("grapes", "banana", "pineapple");
            genericString.printMaxValue();
             *//*
             Console.ReadLine();*/

        }
    }




}
        
