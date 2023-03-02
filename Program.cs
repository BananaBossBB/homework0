using System;

class Program {
    static void Main(string[] args)
    {   
        Console.Write("Input Password : ");
        string pw = Console.ReadLine();

        if (pw.Length <= 6)
        {

            Console.Write("Input Affiliattion : ");
            string affiliattion = Console.ReadLine();

                int password = int.Parse(pw);

                int num6 = (int)password/100000;
                password -= num6 * 100000;
                int num5 = (int)password/10000;
                password -= num5 * 10000;
                int num4 = (int)password/1000;
                password -= num4 * 1000;
                int num3 = (int)password/100;
                password -= num3 * 100;
                int num2 = (int)password/10;
                password -= num2 * 10;
                int num1 = (int)password/1;
                password -= num1 * 1;

                /*
                Console.WriteLine("num1 = {0}",num1);
                Console.WriteLine("num2 = {0}",num2);
                Console.WriteLine("num3 = {0}",num3);
                Console.WriteLine("num4 = {0}",num4);
                Console.WriteLine("num5 = {0}",num5);
                Console.WriteLine("num6 = {0}",num6);
                */

                switch(affiliattion)
                {
                    case "CIA":

                        //Console.WriteLine("In CIA");
                        if (num1 % 3 != 0)
                        {
                            Console.WriteLine("False");
                        }
                        else if (num2 == 1 || num2 == 3 || num2 == 5)
                        {
                            Console.WriteLine("False");
                        }
                        else if (num4 < 6 || num4 == 8)
                        {
                            Console.WriteLine("False");
                        }
                        else
                        {
                            Console.WriteLine("True");
                        }
                        break;

                    case "FBI":

                        //Console.WriteLine("In FBI");
                        if (num6 < 4 || num6 > 7)
                        {
                            Console.WriteLine("False");
                        }
                        else if (num3 % 2 != 0 || num3 == 6)
                        {
                            Console.WriteLine("False");
                        }
                        else if (num5 % 2 == 0)
                        {
                            Console.WriteLine("False");
                        }
                        else
                        {
                            Console.WriteLine("True");
                        }
                        break;

                    case "NSA":

                        //Console.WriteLine("In NSA");
                        if (num1 != 1 && num1 != 2 && num1 != 3 && num1 != 5 && num1 != 6) //(30 % num1 != 0)
                        {
                            Console.WriteLine("False");
                        }
                        else if (num3 % 3 != 0 || num3 % 2 == 0)
                        {
                            Console.WriteLine("False");
                        }
                        else if (num1 != 7 && num2 != 7 && num3 != 7 && num4 != 7 && num5 != 7 && num6 != 7)
                        {
                            Console.WriteLine("False");
                        }
                        else
                        {
                            Console.WriteLine("True");
                        }
                        break;

                    default:
                        Console.WriteLine("False");
                        break;
                    }
            }
        else
        {
            Console.WriteLine("False");
        }
        //Console.WriteLine(password);
        //Console.WriteLine(affiliattion);
    }
}
