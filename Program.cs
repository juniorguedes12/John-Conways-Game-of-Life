using System;
using System.Text;
using System.Threading;

namespace GoL
{
    class Program
    {
        private static bool[,] board;
        private static int width = 64;
        private static int height = 32;

        static void Main(string[] args)
        {
            initializeBoard();

            initializeConsole();

            Thread thread = new Thread(musica);
            thread.Start();

            for (; ; )
            {
                Program.drawBoard();

                Program.updateBoard();

                Thread.Sleep(100);
            }

        }
        private static void initializeConsole()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();

            Console.CursorVisible = false;

            Console.BackgroundColor = ConsoleColor.DarkMagenta;
        }

        private static void initializeBoard()
        {
            var random = new Random();

            Program.board = new bool[Program.width, Program.height];
            for (var y = 0; y < Program.height; y++)
            {
                for (var x = 0; x < Program.width; x++)
                {
                    Program.board[x, y] = random.Next(2) == 0;
                }
            }
        }

        private static void drawBoard()
        {
            var builder = new StringBuilder();

            for (var y = 0; y < Program.height; y++)
            {
                for (var x = 0; x < Program.width; x++)
                {
                    char c = Program.board[x, y] ? 'O' : ' ';
                    builder.Append(c);
                }
                builder.Append('\n');
            }
            Console.SetCursorPosition(0, 0);
            Console.Write(builder.ToString());
        }

        private static void updateBoard()
        {
            bool[,] newBoard = new bool[Program.width, Program.height];

            for (var y = 0; y < Program.height; y++)
            {
                for (var x = 0; x < Program.width; x++)
                {
                    var n = countNeighbors(x, y);
                    var c = Program.board[x, y];

                    // Uma celula viva morre a nao ser que tenha exatamente 2 ou 3 vizin
                    // Uma celula morta continua morta a nao ser que tenha exatamente 3 vizin
                    newBoard[x, y] = c && (n == 2 || n == 3) || !c && n == 3;
                }
            }

            Program.board = newBoard;
        }

        private static int countNeighbors(int x, int y)
        {
            int value = 0;

            for (var j = -1; j <= 1; j++)
            {

                if (y + j >= Program.height)
                {
                    continue;
                }

                int k = (y + j + Program.height) % Program.height;

                for (var i = -1; i <= 1; i++)
                {
                    if (x + i >= Program.width)
                    {
                        continue;
                    }

                    int h = (x + i + Program.width) % Program.width;

                    value += Program.board[h, k] ? 1 : 0;
                }
            }

            return value - (Program.board[x, y] ? 1 : 0);
        }

        private static void musica()
        {
            for (; ; )
            {
                Console.Beep(658, 125);
                Console.Beep(1320, 500);
                Console.Beep(990, 250);
                Console.Beep(1056, 250);
                Console.Beep(1188, 250);
                Console.Beep(1320, 125);
                Console.Beep(1188, 125);
                Console.Beep(1056, 250);
                Console.Beep(990, 250);
                Console.Beep(880, 500);
                Console.Beep(880, 250);
                Console.Beep(1056, 250);
                Console.Beep(1320, 500);
                Console.Beep(1188, 250);
                Console.Beep(1056, 250);
                Console.Beep(990, 750);
                Console.Beep(1056, 250);
                Console.Beep(1188, 500);
                Console.Beep(1320, 500);
                Console.Beep(1056, 500);
                Console.Beep(880, 500);
                Console.Beep(880, 500);
           //     Thread.Sleep(250);
                Console.Beep(1188, 500);
                Console.Beep(1408, 250);
                Console.Beep(1760, 500);
                Console.Beep(1584, 250);
                Console.Beep(1408, 250);
                Console.Beep(1320, 750);
                Console.Beep(1056, 250);
                Console.Beep(1320, 500);
                Console.Beep(1188, 250);
                Console.Beep(1056, 250);
                Console.Beep(990, 500);
                Console.Beep(990, 250);
                Console.Beep(1056, 250);
                Console.Beep(1188, 500);
                Console.Beep(1320, 500);
                Console.Beep(1056, 500);
                Console.Beep(880, 500);
                Console.Beep(880, 500);
             //   Thread.Sleep(500);
                Console.Beep(1320, 500);
                Console.Beep(990, 250);
                Console.Beep(1056, 250);
                Console.Beep(1188, 250);
                Console.Beep(1320, 125);
                Console.Beep(1188, 125);
                Console.Beep(1056, 250);
                Console.Beep(990, 250);
                Console.Beep(880, 500);
                Console.Beep(880, 250);
                Console.Beep(1056, 250);
                Console.Beep(1320, 500);
                Console.Beep(1188, 250);
                Console.Beep(1056, 250);
                Console.Beep(990, 750);
                Console.Beep(1056, 250);
                Console.Beep(1188, 500);
                Console.Beep(1320, 500);
                Console.Beep(1056, 500);
                Console.Beep(880, 500);
                Console.Beep(880, 500);
               // Thread.Sleep(250);
                Console.Beep(1188, 500);
                Console.Beep(1408, 250);
                Console.Beep(1760, 500);
                Console.Beep(1584, 250);
                Console.Beep(1408, 250);
                Console.Beep(1320, 750);
                Console.Beep(1056, 250);
                Console.Beep(1320, 500);
                Console.Beep(1188, 250);
                Console.Beep(1056, 250);
                Console.Beep(990, 500);
                Console.Beep(990, 250);
                Console.Beep(1056, 250);
                Console.Beep(1188, 500);
                Console.Beep(1320, 500);
                Console.Beep(1056, 500);
                Console.Beep(880, 500);
                Console.Beep(880, 500);
                //Thread.Sleep(500);
                Console.Beep(660, 1000);
                Console.Beep(528, 1000);
                Console.Beep(594, 1000);
                Console.Beep(495, 1000);
                Console.Beep(528, 1000);
                Console.Beep(440, 1000);
                Console.Beep(419, 1000);
                Console.Beep(495, 1000);
                Console.Beep(660, 1000);
                Console.Beep(528, 1000);
                Console.Beep(594, 1000);
                Console.Beep(495, 1000);
                Console.Beep(528, 500);
                Console.Beep(660, 500);
                Console.Beep(880, 1000);
                Console.Beep(838, 2000);
                Console.Beep(660, 1000);
                Console.Beep(528, 1000);
                Console.Beep(594, 1000);
                Console.Beep(495, 1000);
                Console.Beep(528, 1000);
                Console.Beep(440, 1000);
                Console.Beep(419, 1000);
                Console.Beep(495, 1000);
                Console.Beep(660, 1000);
                Console.Beep(528, 1000);
                Console.Beep(594, 1000);
                Console.Beep(495, 1000);
                Console.Beep(528, 500);
                Console.Beep(660, 500);
                Console.Beep(880, 1000);
                Console.Beep(838, 2000);
            }
        }
    }
}