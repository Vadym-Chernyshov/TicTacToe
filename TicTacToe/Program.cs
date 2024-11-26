using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TicTacToe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            //ім'я гравця, потім будемо змінювати його
            string namePlayer = "1-ий гравець";
            //символи гравця, потім будемо змінювати символ
            string player = "X";

            //максимальна кількість ходів
            sbyte maximumNumberOfMoves = 9;

            //перший ряд
            string position_1_1 = "1";
            string position_1_2 = "2";
            string position_1_3 = "3";
            //другий ряд
            string position_2_1 = "4";
            string position_2_2 = "5";
            string position_2_3 = "6";
            //третій ряд
            string position_3_1 = "7";
            string position_3_2 = "8";
            string position_3_3 = "9";                          

            for (int i = 0; i < maximumNumberOfMoves; i++)
            {
                //мітка для можливості при помилках, знову вводити дані гравцю
                startForPlayer:
                Console.WriteLine($"Ходить {namePlayer}. Оберіть позицію");
                Console.WriteLine(); //пустий рядок для красоти
                //шаблон поля
                Console.WriteLine($" {position_1_1} | {position_1_2} | {position_1_3}\n" +
                                  $"-----------\n" +
                                  $" {position_2_1} | {position_2_2} | {position_2_3}\n" +
                                  $"-----------\n" +
                                  $" {position_3_1} | {position_3_2} | {position_3_3}\n");
                //ввід користувача
                string userInput = Console.ReadLine();
                Console.WriteLine();
                switch (userInput)
                {
                    case "1": 
                        if (position_1_1 == "1") //якщо позиція вільна, даємо значення гравця
                            position_1_1 = player; 
                        else //якщо позиція не вільна то повертаємо гравця на етап вибору позиції
                        {
                            Console.WriteLine("Позиція зайнята. Спробуйте знову");
                            goto startForPlayer;
                        } 
                        break;
                    case "2":
                        if (position_1_2 == "2") //якщо позиція вільна, даємо значення гравця
                            position_1_2 = player;
                        else //якщо позиція не вільна то повертаємо гравця на етап вибору позиції
                        {
                            Console.WriteLine("Позиція зайнята. Спробуйте знову");
                            goto startForPlayer;
                        }
                        break;
                    case "3":
                        if (position_1_3 == "3") //якщо позиція вільна, даємо значення гравця
                            position_1_3 = player;
                        else //якщо позиція не вільна то повертаємо гравця на етап вибору позиції
                        {
                            Console.WriteLine("Позиція зайнята. Спробуйте знову");
                            goto startForPlayer;
                        }
                        break;
                    case "4":
                        if (position_2_1 == "4") //якщо позиція вільна, даємо значення гравця
                            position_2_1 = player;
                        else //якщо позиція не вільна то повертаємо гравця на етап вибору позиції
                        {
                            Console.WriteLine("Позиція зайнята. Спробуйте знову");
                            goto startForPlayer;
                        }
                        break;
                    case "5":
                        if (position_2_2 == "5") //якщо позиція вільна, даємо значення гравця
                            position_2_2 = player;
                        else //якщо позиція не вільна то повертаємо гравця на етап вибору позиції
                        {
                            Console.WriteLine("Позиція зайнята. Спробуйте знову");
                            goto startForPlayer;
                        }
                        break;
                    case "6":
                        if (position_2_3 == "6") //якщо позиція вільна, даємо значення гравця
                            position_2_3 = player;
                        else //якщо позиція не вільна то повертаємо гравця на етап вибору позиції
                        {
                            Console.WriteLine("Позиція зайнята. Спробуйте знову");
                            goto startForPlayer;
                        }
                        break;
                    case "7":
                        if (position_3_1 == "7") //якщо позиція вільна, даємо значення гравця
                            position_3_1 = player;
                        else //якщо позиція не вільна то повертаємо гравця на етап вибору позиції
                        {
                            Console.WriteLine("Позиція зайнята. Спробуйте знову");
                            goto startForPlayer;
                        }
                        break;
                    case "8":
                        if (position_3_2 == "8") //якщо позиція вільна, даємо значення гравця
                            position_3_2 = player;
                        else //якщо позиція не вільна то повертаємо гравця на етап вибору позиції
                        {
                            Console.WriteLine("Позиція зайнята. Спробуйте знову");
                            goto startForPlayer;
                        }
                        break;
                    case "9":
                        if (position_3_3 == "9") //якщо позиція вільна, даємо значення гравця
                            position_3_3 = player;
                        else //якщо позиція не вільна то повертаємо гравця на етап вибору позиції
                        {
                            Console.WriteLine("Позиція зайнята. Спробуйте знову");
                            goto startForPlayer;
                        }
                        break;
                    default: //неправильний ввід користувача
                        Console.WriteLine("Некоректний ввід. Спробуйте знову");
                        goto startForPlayer;
                }
                //перевірка перемоги
                // немає сенсу перевіряти перемогу, поки не наберуться необхідна кількість символів
                // X:3 0:2 тобто перевірку треба починати з 5 ітерації
                if (i >= 4) 
                {
                   if ((position_1_1 == player && position_1_2 == player && position_1_3 == player) || //горизонталь
                       (position_2_1 == player && position_2_2 == player && position_2_3 == player) ||
                       (position_3_1 == player && position_3_2 == player && position_3_3 == player) ||
                       (position_1_1 == player && position_2_1 == player && position_3_1 == player) || //вериткаль
                       (position_1_2 == player && position_2_2 == player && position_3_2 == player) ||
                       (position_1_3 == player && position_2_3 == player && position_3_3 == player) ||
                       (position_1_1 == player && position_2_2 == player && position_3_3 == player) || //діагональ
                       (position_1_3 == player && position_2_2 == player && position_3_1 == player))
                    {
                        Console.WriteLine($" {position_1_1} | {position_1_2} | {position_1_3}\n" +
                                          $"-----------\n" +
                                          $" {position_2_1} | {position_2_2} | {position_2_3}\n" +
                                          $"-----------\n" +
                                          $" {position_3_1} | {position_3_2} | {position_3_3}\n");

                        Console.WriteLine($"{namePlayer} переміг :-)");
                        break; //виходимо з циклу
                    }
                }
                //якщо на останній ітерації не визначений переможець, отримаємо нічию
                if (i == maximumNumberOfMoves - 1)
                {
                    Console.WriteLine("Нічия. Переможця нема");
                    break;
                }
                //міняємо гравця
                if (namePlayer == "1-ий гравець")
                {
                    namePlayer = "2-ий гравець";
                    player = "0";
                }
                else
                {
                    namePlayer = "1-ий гравець";
                    player = "X";
                }

            }
            Console.WriteLine("Кінець гри");
        }
    }
}
