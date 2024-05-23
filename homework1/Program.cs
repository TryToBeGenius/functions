// Задача 1: Напишите программу, которая бесконечно запрашивает целые числа с консоли. 
// Программа завершается при вводе символа ‘q’ или при вводе числа, сумма цифр которого чётная.
// 1.Запрос на ввод
// 2.Запрашивается он бесконечно
// 3.Условия ввода 1)Сумма цифр четная 2) quit by q в терминале


// while (true)
// {
//     Console.WriteLine("Введите число, или завершите q:");
//     string n = Console.ReadLine();
//     if (n == "q")
//     {
//         break;
//     }
//     if (ChetNeChet(n) == false)
//     {
//         break;
//     }  
// }



// bool ChetNeChet(int n)
// {
//     int sum = 0; 
//         while (n > 0)
//         {
//             sum = sum + (n % 10);
//             n = n / 10;
//             if (sum % 2 == 0)
//             {
//                 Console.WriteLine("Стоп");
//                 return false;
//                 break;
//             }
//             else
//             {
//                 return true;
//                 Console.WriteLine("Введите число или q");
//             }
//         }
//     else
//     {
//         break;
//     }
    
// }
// Я пытался решить сам но меня вымучила int.TryParse(input, out number) функция я не знал как её сделать и как ей воспользоваться
// Я так и не понял как чекнуть есть ли символы в введенной строке.


while (true)
{
    Console.Write("Введите число или 'q' для выхода: ");
    string input = Console.ReadLine(); 
    if (input == "q") 
    {
    break;
    }
    int number;
    if (int.TryParse(input, out number)) 
    {
        int sum = 0;
        while (number > 0)
        {
            sum += number % 10;
            number /= 10; 
        }
        if (sum % 2 == 0)
        {
            Console.WriteLine("[STOP]");
            break;
        }

    }
    else
    {
        Console.WriteLine("Некорректный ввод. Пожалуйста, введите целое числоили 'q'.");
    }
}