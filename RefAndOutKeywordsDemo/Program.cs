using System;

namespace RefAndOutKeywordsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int ValueTypeNumber1 = 101;
            int ValueTypeNumber2 = 102;

            //assing value of ValueTypeNumber2 to ValueTypeNumber1
            ValueTypeNumber1 = ValueTypeNumber2;

            //change of ValueTypeNumber2
            ValueTypeNumber2 = 103;

            Console.WriteLine(ValueTypeNumber1); // Output "102"

            int referanceTypeNumber4=201;
            RefTransaction(1, 2, ref referanceTypeNumber4);
            Console.WriteLine(referanceTypeNumber4); // Output:204

            int referanceTypeNumber5 = 202;
            OutTransaction(1, 2, out referanceTypeNumber5);
            Console.WriteLine(referanceTypeNumber5); // Output 206

        }

        static void RefTransaction(int i,int j, ref int referanceTypeNumber4)
        {
            referanceTypeNumber4 = i + j + referanceTypeNumber4;
        }

        static void OutTransaction(int i, int j, out int referanceTypeNumber5)
        {
            //int referanceTypeNumber6;
            referanceTypeNumber5 = 203;
            referanceTypeNumber5 = i + j+ referanceTypeNumber5;
        }
    }
}
