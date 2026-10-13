using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectRepozitory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int playerHealth = 100, MaxHealth = 100, PosX = 0, PosY = 0, Journals = 10, enemyDamage = 0;
            Console.WriteLine(new string('#', 5));
            Console.WriteLine(new string('#', 5));
            Console.WriteLine(new string('#', 5));
            // отрисовка игрока
            Console.SetCursorPosition(PosX, PosY);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("V");
            Console.ResetColor();
            Console.SetCursorPosition(0, 3);
            //строка состояния игрока
            Console.WriteLine($"🖤: {playerHealth}/{MaxHealth} 📓: {Journals,-5}");
            // получение урона
            Console.Write("Введите урон\t");
            int.TryParse(Console.ReadLine(), out enemyDamage);
            playerHealth -= enemyDamage;
            if (playerHealth < 0) playerHealth = 0;
            Console.SetCursorPosition(0, 3);
            Console.WriteLine($"🖤: {playerHealth}/{MaxHealth} 📓: {Journals,5}");
            //перемещение игрока
            Console.Write("Введите направление движения: ");
            var key = Console.ReadKey();
            if (key.Key == ConsoleKey.D)
            {

                Console.SetCursorPosition(PosX, PosY);
                Console.WriteLine(new string('#', 5));
                PosX += 1;
                Console.SetCursorPosition(PosX, PosY);
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write("V");
                Console.ResetColor();
                Console.SetCursorPosition(0, 3);
            }
        }   
    }
}
