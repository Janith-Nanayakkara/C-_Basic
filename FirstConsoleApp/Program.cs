using System;
public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Nothing is impossible. ");
        Console.WriteLine("The word itself says 'I'm possible!");
        Console.WriteLine("-Audrey Hepburn");
        //Single Line Comment
        Console.Write("Hello");//One Line Statement Not Brake
        /* Multi Line
         * Comment*/
        int salary = 90000;
        int tax = 15000;

        int netSalary = salary - tax;
        Console.WriteLine(netSalary);
      /*  int x = 10;
        int y = 3;
        int result = x / y;
        Console.WriteLine(result);*/
       // int x = 1;
       // int y = 2;
        int z = 3;

        //Console.WriteLine(x + y * z);

       // int x = 5;
      //  x = 8;
       // Console.WriteLine(x + 1);

     //   int x = 8;
        int y = 3;

      //  int result = x % y;
       // Console.WriteLine(result);
        int apples = 5;
        apples++;
        apples--;
        apples--;
        Console.WriteLine(apples);
      //  int x = 10;
      //  Console.WriteLine(x--);
        int x = 10;
        Console.WriteLine(--x);
    }
}