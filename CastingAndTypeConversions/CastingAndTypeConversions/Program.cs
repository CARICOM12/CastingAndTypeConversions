using System;

namespace CastingAndTypeConversions
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            {
                sbyte variableOne = -128;
                short variableTwo = variableOne;
                Console.WriteLine(variableTwo);

                int variableThree = variableOne;
                Console.WriteLine(variableThree);

                long variableFour = variableOne;
                Console.WriteLine(variableFour);

                float variableFive = variableOne;
                Console.WriteLine(variableFive);

                double variableSix = variableOne;
                Console.WriteLine(variableSix);

                decimal variableSeven = variableOne;
                Console.WriteLine(variableOne);
            }

            {
                byte variableOne = 255;
                short variableTwo = variableOne;
                Console.WriteLine(variableTwo);

                ushort variableThree = variableOne;
                Console.WriteLine(variableThree);

                int variableFour = variableOne;
                Console.WriteLine(variableFour);

                uint variableFive = variableOne;
                Console.WriteLine(variableFive);

                long variableSix = variableOne;
                Console.WriteLine(variableSix);

                ulong variableSeven = variableOne;
                Console.WriteLine(variableSeven);

                float variableEight = variableOne;
                Console.WriteLine(variableEight);

                double variableNine = variableOne;
                Console.WriteLine(variableNine);

                decimal variableTen = variableOne;
                Console.WriteLine(variableTen);
            }

            {
                short variableOne = 32767;
                int variableTwo = variableOne;
                Console.WriteLine(variableTwo);

                long variableThree = variableOne;
                Console.WriteLine(variableThree);

                float variableFour = variableOne;
                Console.WriteLine(variableFour);

                double variableFive = variableOne;
                Console.WriteLine(variableFive);

                decimal variableSix = variableOne;
                Console.WriteLine(variableSix);
            }

            {
                ushort variableOne = 65535;
                int variableTwo = variableOne;
                Console.WriteLine(variableOne);

                uint variableThree = variableOne;
                Console.WriteLine(variableThree);

                long variableFour = variableOne;
                Console.WriteLine(variableFour);

                ulong variableSix = variableOne;
                Console.WriteLine(variableSix);

                float variableSeven = variableOne;
                Console.WriteLine(variableSeven);

                double variableNine = variableOne;
                Console.WriteLine(variableOne);

                decimal variableTen = variableOne;
                Console.WriteLine(variableTen);
            }

            {
                int variableOne = -2147483648;
                long variableTwo = variableOne;
                Console.WriteLine(variableTwo);

                float variableThree = variableOne; //-2.147484E+09 почему так выводит на консоль
                Console.WriteLine(variableThree);

                double variableFour = variableOne;
                Console.WriteLine(variableFour);

                decimal variableFive = variableOne;
                Console.WriteLine(variableFive);
            }

            {
                uint variableOne = 4294967295;
                long variableTwo = variableOne;
                Console.WriteLine(variableTwo);

                ulong variableThree = variableOne;
                Console.WriteLine(variableThree);

                float variableFour = variableOne; //опять странный вывод
                Console.WriteLine(variableFour);

                double variableFive = variableOne;
                Console.WriteLine(variableFive);

                decimal variableSix = variableOne;
                Console.WriteLine(variableSix);
            }

            {
                long variableOne = -9223372036854775808;
                float variableTwo = variableOne; //снова странный вывод
                Console.WriteLine(variableTwo);

                double variableThree = variableOne;
                Console.WriteLine(variableThree); //снова

                decimal variableFour = variableOne;
                Console.WriteLine(variableFour);
            }

            {
                ulong variableOne = 18_446_744_073_709_551_615;
                float variableTwo = variableOne;
                Console.WriteLine(variableTwo);// снова

                double variableThree = variableOne;
                Console.WriteLine(variableThree);//снова

                decimal variableFour = variableOne;
                Console.WriteLine(variableFour);
            }

            {
                float variableOne = 12.3F;
                double variableTwo = variableOne;
                Console.WriteLine(variableTwo);
            }
        }
    }
}
