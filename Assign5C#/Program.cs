namespace Assign5C_
{
    internal class Program
    {

        #region Qu5
        //static bool IsPrime(int num)
        //{
        //    if (num <= 1) return false;

        //    if (num == 2) return true;

        //    if (num % 2 == 0) return false;
        //}

        #endregion

        #region Qu6
        //static (int, int) MinMaxArray(ref int[]Arr)
        //{
        //    int Min = Arr.Min();

        //    int Max = Arr.Max();

        //    return (Min, Max);
        //}




        #endregion

        #region Qu7
        //static long Factorial(int n)
        //{
        //    long result = 1;

        //    for(int i = 1; i <= n; i++)
        //    {
        //        result *= i;

        //    }

        //    return result;
        //}





        #endregion

        #region Qu8
        //static void ChangeChar(StringBuilder name)
        //{
        //    name[0] = 'B';

        //    Console.WriteLine(name);
        //}




        #endregion
        static void Main(string[] args)
        {
            //Assignment5-C#
            #region Assignment5_C#
            #region Qu1. Explain the difference between passing(Value type parameters)by value and reference then write a suitable C# example.

            //1-Passing value type parameter by value: When I tried to made swapping this happen in function SumOfNumbers but swapping isn't happing in Number01&Number02 the values didn't change because I'm just took a copy from this value only and it was passing by value (input parameter).

            //static void SumOfNumbers(int X, int Y)
            //{

            //    int temp;

            //    temp = X; //2
            //    X = Y; //3
            //    Y = temp; //2

            //    Console.WriteLine(X); //3
            //    Console.WriteLine(Y); //2

            //}



            //int Number01 = 2;
            //int Number02 = 3;


            //SumOfNumbers(Number01, Number02);

            //Console.WriteLine($"Num01:{Number01}"); ///2
            //Console.WriteLine($"Num02:{Number02}"); ///3

            //2-Passing reference type parameter passing by value: When I tried to made a sawpping this happend in Number01,Nuber02 because X, Y had access on Number01,Nuber02 because those were Passing by reference (input, output parameters).

            //static void SumOfNumbers(ref int X, ref int Y)
            //{

            //    int temp;

            //    temp = X; //2
            //    X = Y; //3
            //    Y = temp; //2

            //    Console.WriteLine(X); //3
            //    Console.WriteLine(Y); //2

            //}


            //int Number01 = 2;
            //int Number02 = 3;


            //SumOfNumbers(ref Number01, ref Number02);

            //Console.WriteLine($"Num01:{Number01}"); //3
            //Console.WriteLine($"Num02:{Number02}"); //2

            #endregion

            #region Qu2.Explain the difference betwen passing (Reference type parameters) by value and by reference then write a suitable C# example.

            //1-Passing by Value at Reference type parameters: Passing by Value[Input parameter] When I called SumOfArray(Numbers) I sent it a reference of (Numbers) to (Arr) but when I change the value inside it the reference of (Arr) is changed. 


            //static void SumOfArray(int[] Arr)
            //{
            //    int Result = 0;

            //    Arr = new int[] { 4, 5, 6 };

            //    if (Arr?.Length > 0 )
            //    {

            //        for (int i = 0; i < Arr.Length; i++)
            //        {

            //            Result += Arr[i];


            //        }

            //        Console.WriteLine(Result);

            //    }
            //}



            //int[] Numbers = new int[] { 1, 2, 3}; //Passing by value[Input parametrs]

            // SumOfArray(Numbers);                 //SumOfArray(reference of Numbers)

            //1-Passing by reference at Reference type parameters: Passing by reference[Input & output parameter] When I called SumOfArray(Numbers) I sent it a Value of (Numbers) to (Arr) and togather became the same thing and  when I change the value inside(Arr) The value of Numbers changed also.


            //static void SumOfArray(ref int[] Arr)
            //{
            //    int Result = 0;

            //    Arr = new int[] { 4, 5, 6 };

            //    if (Arr?.Length > 0)
            //    {

            //        for (int i = 0; i < Arr.Length; i++)
            //        {

            //            Result += Arr[i];


            //        }

            //        Console.WriteLine(Result);

            //    }
            //}



            //int[] Numbers = new int[] { 1, 2, 3 }; //Passing by ref[Input&Output parametrs]

            //SumOfArray(ref Numbers);                 //SumOfArray(Value)
            #endregion

            #region Qu3.Write a C# Function that accept 4 parameters from user and return of summation and subtracting of two numbers.


            // static (int, int) SumSub(int Num01, int Num02, int Num03, int Num04)
            // {
            //     int Sum = Num01 + Num02;

            //     int Sub = Num01 - Num02;


            //     return (Sum, Sub);
            // }


            // Console.Write("Please Enter 4 numbers:");
            // int.TryParse(Console.ReadLine(), out int Num01);
            // int.TryParse(Console.ReadLine(), out int Num02);
            // int.TryParse(Console.ReadLine(), out int Num03);
            // int.TryParse(Console.ReadLine(), out int Num04);

            //(int, int) Result = SumSub(Num01, Num02, Num03, Num04);

            // Console.WriteLine(Result);


            //Console.WriteLine(Numbers);





            #endregion

            #region Qu4.Write a program in C# Sharp to create a function to calculate the sum of the individual digits of a given number. 
            //*********
            //Console.WriteLine("Enter a number:");

            //string input = Console.ReadLine();

            //if(int.TryParse(input, out int number))
            //{
            //    int sum = SumOfDigits(number);
            //    Console.WriteLine($"The sum of the digits of the number {number} is: {sum}");
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input: Please enter a valid number");
            //}


            //static int SumOfDigits(int num)
            //{
            //    int sum = 0;

            //    while (num > 0)
            //    {
            //        sum += num % 10;  //sum = sum + 25 %10 = 2.5
            //        num /= 10;
            //    }
            //    return sum;
            //}
            #endregion

            #region Qu5.Create a function named "IsPrime", Which receives an integer number and returns true if it is prime, or false if it is not.



            //Console.WriteLine("Please Enter Prime number");

            //string input = Console.ReadLine();

            //int.TryParse(input, out int numbers);

            //bool Result = IsPrime(numbers);

            //Console.WriteLine(Result);


            //The function above.
            #endregion

            #region Qu6. Create a function named MinMaxArray, to return the minimum and maximum values stroed in an array, using reference parameters.

            //int[] Numbers = new int[] { 1, 2, 3, 4 };


            //(int, int)Result = MinMaxArray(ref Numbers); //Input & Output Parameters


            //Console.WriteLine(Result);

            //The function above.


            #endregion

            #region Qu7.Create an iterative(non-recursive) function to calculate the factorial of the number specified as parameter.

            // Console.WriteLine("Please enter a number: ");

            // int.TryParse(Console.ReadLine(), out int n);

            //long Factor = Factorial(n);


            // Console.WriteLine($"Number: {n} Factorial: {Factor}");

            //The function above.


            #endregion

            #region Qu8.Create a function named "ChangeChar" to modify a letter in a certain position (0 based) of  astring it with a different letter.
            //Console.WriteLine("Please enter your name:");

            //StringBuilder name = new StringBuilder(Console.ReadLine());

            //ChangeChar(name);

            //The function above.




            #endregion


            #endregion
        }
    }
}
