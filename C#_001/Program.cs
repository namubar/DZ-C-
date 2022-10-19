// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите первое число: ");
int a=int.Parse (Console.ReadLine ()!);
Console.WriteLine("Введите второе число: ");
int b= int.Parse (Console.ReadLine ()!);
int max;
if (a!=b)
    {if (a>b) 
        {max =a;
        Console.WriteLine ("Max = "+ max);
        }
    else
        {max=b;
        Console.WriteLine ("Max = "+ max);
        }
}         
else 
{Console.WriteLine ("Числа равны");
} 