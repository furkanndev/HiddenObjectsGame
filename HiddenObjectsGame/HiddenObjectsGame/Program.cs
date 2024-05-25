using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiddenObjectsGame
{
    internal class Program
    {
        static void player()
        {

            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Your Name:");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;

        }

        static void fire(ref int x, ref int y)
        {
            Console.Write("X -Axis : ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Y -Axis : ");
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

        }

        static void draw_board(char[,] board)
        {
            for (int x = 1; x <= 20; x++)
            {
                int y = 1;
                Console.Write("\n");

                for (y = 1; y <= 20; y++)
                {
                    if (board[x, y] == 0)
                    {
                        Console.Write("X" + "  ");
                    }
                    else if (board[x, y] == '1')
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(board[x, y] + "  ");
                        Console.ResetColor();
                    }

                    else if (board[x, y] == '-')
                    {

                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write('O' + "  ");
                        Console.ResetColor();
                    }

                    else
                    {
                        Console.Write(board[x, y] + "  ");
                    }

                }
            }

        }

        static void ship_location(int[] ship_location)
        {
        a:
            Console.WriteLine();
            Console.Write("Ship's X axis : ");
            ship_location[0] = Convert.ToInt32(Console.ReadLine());




            Console.Write("Ship's Y axis : ");
            ship_location[1] = Convert.ToInt32(Console.ReadLine());
            Console.Write("For horizontal press [0] or for vertical press [1] :");
            ship_location[2] = Convert.ToInt32(Console.ReadLine());
            if (ship_location[2] != 1 && ship_location[2] != 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("!!Wrong Selection...");
                Console.ResetColor();
                goto a;
            }
        }


        static void ship_location_insert(char[,] board, int[] ship_location)
        {
            int i = -1;
            if (ship_location[2] == 0)
            {
                //horizontal
                while (i < ship_location[3] - 1)
                {
                    board[ship_location[1] - 1, ship_location[0] + i] = 'O';
                    i++;
                }
            }
            else
            {
                //vertical
                while (i < ship_location[3] - 1)
                {
                    board[ship_location[1] + i, ship_location[0] - 1] = 'O';
                    i++;
                }
            }

        }

        static void Main(string[] args)
        {
            //INTRO loading screen
            Console.Title = "Secret Objects Game";
            Console.WriteLine(" Loading Game Please Wait.... \n");

            Console.CursorVisible = false;
            Console.SetCursorPosition(1, 1);
            for (int i = 0; i <= 50; i++)
            {

                for (int j = 0; j < i; j++)
                {

                    string progressbar = "\u2551";
                    Console.Write(progressbar);

                }
                Console.Write(i + " /50");
                Console.SetCursorPosition(1, 1);
                Console.ForegroundColor = ConsoleColor.Green;
                System.Threading.Thread.Sleep(50);

            }
            System.Threading.Thread.Sleep(500);
            Console.Clear();
            Console.CursorVisible = true;
            //

            player();
            Console.Clear();
            Console.Write("\tGOOD LUCK :))");
            System.Threading.Thread.Sleep(1000);
            Console.Clear();

            //Main screen
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("         ***** Welcome To Secret Objects Game *****\n");
            Console.ResetColor();



            char[,] board = new char[21, 21];
            char[,] board_2 = new char[21, 21];

            //drawing board...
            draw_board(board);
            Console.WriteLine();

            //ship's lenght
            int[] ship1 = { 0, 0, 0, 3 };
            int[] ship2 = { 0, 0, 0, 4 };
            int[] ship3 = { 0, 0, 0, 5 };

            ship_location(ship1);
            ship_location(ship2);
            ship_location(ship3);


            ship_location_insert(board, ship1);
            ship_location_insert(board, ship2);
            ship_location_insert(board, ship3);


            Console.Clear();
            System.Threading.Thread.Sleep(500);




            //starting...
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("         ***** Welcome To Secret Objects Game *****\n");
            Console.ResetColor();

            draw_board(board_2);
            Console.WriteLine();

            int life, a, b, score;

            life = 0;
            a = 0;
            b = 0;
            score = 0;
            while (life < 100)
            {
                Console.WriteLine();
                fire(ref a, ref b);
                Console.Clear();
                Console.WriteLine();
                if (board[b - 1, a - 1] == 'O')
                {
                    board_2[b - 1, a - 1] = '1';
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("SCORE!!");
                    Console.ResetColor();
                    score = score + 5;   //isabet ederse +5 puan
                }
                else
                {
                    board_2[a - 1, b - 1] = '-';
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("!!MISSED!!");
                    Console.ResetColor();
                    score = score - 1;  // ıska ise -1 puan
                }
                draw_board(board_2);
                life++;

                Console.Write("\tYour Current Score: {0}", score);
            }

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.CursorVisible = false;
            Console.Write("\tYour Total Score: {0}", score);
            Console.ReadLine();
        }
    }
















}












