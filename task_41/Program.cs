// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

Console.WriteLine("Для окончания ввода чисел введите *  ");


int count = 0;

int end = -1;


while (end != 0)
{
 Console.WriteLine("Введите число: ");
 

       string number = (Console.ReadLine());
      
       end = number.CompareTo("*");

    if (end == 0)

     {

        break;

     }


       int num = Int32.Parse(number);

     if (num > 0)

     {

      count++;

     }

}


Console.WriteLine($"Количество чисел больше 0 равно: {count}"); 






