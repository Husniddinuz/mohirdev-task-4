using System;

class Calculator
{
    static void Main()
    {
        Console.WriteLine("Birinchi raqamni kiriting:");
        double num1 = Convert.ToDouble(Console.ReadLine());
        
        Console.WriteLine("Operatsiyani kiriting (+, -, *, /):");
        char operation = Console.ReadLine()[0];
        
        Console.WriteLine("Ikkinchi raqamni kiriting:");
        double num2 = Convert.ToDouble(Console.ReadLine());
        
        double result = 0;

        switch (operation)
        {
            case '+':
                result = num1 + num2;
                break;
            case '-':
                result = num1 - num2;
                break;
            case '*':
                result = num1 * num2;
                break;
            case '/':
                result = num1 / num2;
                break;
            default:
                Console.WriteLine("Noto'g'ri operatsiya!");
                return;
        }
        
        Console.WriteLine($"Natija: {result}");
    }
}
