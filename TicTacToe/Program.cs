using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TicTacToe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            
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
            
            bool runningGame = true;            

            while (runningGame)
            {
                //якщо на останній ітерації не визначений переможець, отримаємо нічию
                if (maximumNumberOfMoves == 0)
                {
                    Console.WriteLine("Нічия. Переможця нема");
                    break;
                }
                if (player == "X") Console.WriteLine("Ходить 1-ий гравець. Оберіть позицію");
                else Console.WriteLine("Ходить 2-ий гравець. Оберіть позицію");
                
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
                        { position_1_1 = player; maximumNumberOfMoves--; }
                        else //якщо позиція не вільна то повертаємо гравця на етап вибору позиції
                        {
                            Console.WriteLine("Позиція зайнята. Спробуйте знову");
                            continue;
                        } 
                        break;
                    case "2":
                        if (position_1_2 == "2") //якщо позиція вільна, даємо значення гравця
                        { position_1_2 = player; maximumNumberOfMoves--; }
                        else //якщо позиція не вільна то повертаємо гравця на етап вибору позиції
                        {
                            Console.WriteLine("Позиція зайнята. Спробуйте знову");
                            continue;
                        }
                        break;
                    case "3":
                        if (position_1_3 == "3") //якщо позиція вільна, даємо значення гравця
                        { position_1_3 = player; maximumNumberOfMoves--; }
                        else //якщо позиція не вільна то повертаємо гравця на етап вибору позиції
                        {
                            Console.WriteLine("Позиція зайнята. Спробуйте знову");
                            continue;
                        }
                        break;
                    case "4":
                        if (position_2_1 == "4") //якщо позиція вільна, даємо значення гравця
                        { position_2_1 = player; maximumNumberOfMoves--; }
                        else //якщо позиція не вільна то повертаємо гравця на етап вибору позиції
                        {
                            Console.WriteLine("Позиція зайнята. Спробуйте знову");
                            continue;
                        }
                        break;
                    case "5":
                        if (position_2_2 == "5") //якщо позиція вільна, даємо значення гравця
                        { position_2_2 = player; maximumNumberOfMoves--; }
                        else //якщо позиція не вільна то повертаємо гравця на етап вибору позиції
                        {
                            Console.WriteLine("Позиція зайнята. Спробуйте знову");
                            continue;
                        }
                        break;
                    case "6":
                        if (position_2_3 == "6") //якщо позиція вільна, даємо значення гравця
                        { position_2_3 = player; maximumNumberOfMoves--; }
                        else //якщо позиція не вільна то повертаємо гравця на етап вибору позиції
                        {
                            Console.WriteLine("Позиція зайнята. Спробуйте знову");
                            continue;
                        }
                        break;
                    case "7":
                        if (position_3_1 == "7") //якщо позиція вільна, даємо значення гравця
                        { position_3_1 = player; maximumNumberOfMoves--; }
                        else //якщо позиція не вільна то повертаємо гравця на етап вибору позиції
                        {
                            Console.WriteLine("Позиція зайнята. Спробуйте знову");
                            continue;
                        }
                        break;
                    case "8":
                        if (position_3_2 == "8") //якщо позиція вільна, даємо значення гравця
                        { position_3_2 = player; maximumNumberOfMoves--; }
                        else //якщо позиція не вільна то повертаємо гравця на етап вибору позиції
                        {
                            Console.WriteLine("Позиція зайнята. Спробуйте знову");
                            continue;
                        }
                        break;
                    case "9":
                        if (position_3_3 == "9") //якщо позиція вільна, даємо значення гравця
                        { position_3_3 = player; maximumNumberOfMoves--; }
                        else //якщо позиція не вільна то повертаємо гравця на етап вибору позиції
                        {
                            Console.WriteLine("Позиція зайнята. Спробуйте знову");
                            continue;
                        }
                        break;
                    default: //неправильний ввід користувача
                        Console.WriteLine("Некоректний ввід. Спробуйте знову");
                        continue;
                }
                //перевірка перемоги                
                if    ((position_1_1 == player && position_1_2 == player && position_1_3 == player) || //горизонталь
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

                    if (player == "X") Console.WriteLine("1-ий гравець переміг");
                    else Console.WriteLine("2-ий гравець переміг");
                    runningGame = false; //виходимо з циклу
                }
                
                //міняємо гравця
                player = player == "X" ? "0" : "X";
            }
            Console.WriteLine("Кінець гри");
        }
    }
}
