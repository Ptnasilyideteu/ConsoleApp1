using System;

while (true) 
 {

                try
    {
                    
      string s;
        Console.WriteLine("введите первое число: ");
        double num1 = double.Parse(Console.ReadLine());

        Console.WriteLine("введите второе число: ");

        double num2 = double.Parse(s = Console.ReadLine());


        double r;
        bool flag;

        flag = double.TryParse(s, out r);


                    double sum = num1 + num2;
                    Console.WriteLine($"cумма чисел {num1} и {num2} равна: {sum}");
        break;
                    

     }
             catch

       {
        Console.WriteLine("Неверный формат. Введите целое число.\n");
            
       }

 }


