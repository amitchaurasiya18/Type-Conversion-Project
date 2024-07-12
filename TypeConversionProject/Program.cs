using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeConversionProject
{
    internal class Program
    {

        //public static void Calculate(int number1, int number2, out int additionResult, out int multiplicationResult)
        //{
        //    additionResult = number1 + number2;
        //    multiplicationResult = number1 * number2;
        //}

        //static int CalculateUsingRef(ref int number1, ref int number2, ref int number3)
        //{
        //    //int number3;
        //    number3 = number1+number2;
        //    int number4 = number1 * number2;  
        //    return number4;
        //}

        static void Main(string[] args)
        {
            string inputString = "Hello";
            bool result = int.TryParse(inputString, out int integerValue);
            Console.WriteLine("{0} , {1}",result,integerValue);

            //int inputNumber1 = 50;
            //int inputNumber2 = 60;
            //int inputNumber3 = 0;
            
            //Console.WriteLine("Addition is {0}, {1}", CalculateUsingRef(ref inputNumber1, ref inputNumber2, ref inputNumber3), inputNumber3);

            //int addition;
            //int multiplication;
            //Calculate(5, 6, out addition, out multiplication);
            //Console.WriteLine("Addition of two numbers is : {0}", addition);
            //Console.WriteLine("Multiplication of two numbers is : {0}", multiplication);

            // int -> float implicit type conversion
            //int inputNumber1 = Convert.ToInt32(Console.ReadLine());
            //int inputNumber2 = Convert.ToInt32(Console.ReadLine());
            //float result = inputNumber1 / inputNumber2;
            //Console.WriteLine("The Result is : {0}",result);

            // float -> double implicit type conversion
            //float inputNumber1 = Convert.ToSingle(Console.ReadLine());
            //float inputNumber2 = Convert.ToSingle(Console.ReadLine());
            //double result = inputNumber1 / inputNumber2;
            //Console.WriteLine("The Result is : {0}", result);

            // short -> int implicit type conversion
            //short inputNumber1 = Convert.ToSByte(Console.ReadLine());
            //short inputNumber2 = Convert.ToSByte(Console.ReadLine());
            //int result = inputNumber1 / inputNumber2;
            //Console.WriteLine("The Result is : {0}", result);

            //bool inputNumber1 = Convert.ToBoolean(Console.ReadLine());
            ////bool inputNumber2 = Convert.ToBoolean(Console.ReadLine());
            //int result = Convert.ToInt16(inputNumber1);
            //Console.WriteLine("The Result is : {0}", result);

            //long inputNumber2 = Convert.ToInt64(Console.ReadLine());
            //Console.WriteLine("{0}",(int)inputNumber2);

            //int inputInteger = int.Parse(Console.ReadLine());
            //string inputString = Console.ReadLine();

            //object inputObject = inputString;
            ////inputObject = inputString;

            //Console.WriteLine(inputObject.GetType());



        }
    }
}
