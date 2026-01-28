using System;
using System.Data;

namespace InterfacesChallenge_Roman
{
    internal class Program
    {
        public static Player player = new Player(xPos: 7, yPos: 7, color: ConsoleColor.Blue);
        public static Enemy enemy = new Enemy(xPos: 10, yPos: 10, color: ConsoleColor.Red);

        static bool isPlaying = true;

        static void Main(string[] args)
        {
            Console.CursorVisible = false;

            while (isPlaying)
            {
                Draw();
                Input();
                Update();
            }
        }

        static void Draw()
        {
            Console.Clear();

            Console.SetCursorPosition(player._position._xPos, player._position._yPos);
            Console.BackgroundColor = player._color;
            Console.Write("P");
            Console.ResetColor();

            Console.SetCursorPosition(enemy._position._xPos, enemy._position._yPos);
            Console.BackgroundColor = enemy._color;
            Console.Write("E");
            Console.ResetColor();

            Console.SetCursorPosition(0, 20);
            Console.WriteLine("Press I for Aggressive, O for Passive, P for Random movement strategy for Enemy.");
            Console.WriteLine("Press M to move Enemy according to current strategy.");
            Console.WriteLine("Current Strategy: " + enemy.CurrentMoveStrategy.GetType().Name);
            Console.WriteLine("Press ESC to quit.");
        }

        static void Input()
        {
            ConsoleKeyInfo keyInfo = Console.ReadKey(true);

            enemy.ChangeStrategy(keyInfo);

            if(ConsoleKey.M == keyInfo.Key)
            {
                enemy.CurrentMoveStrategy.Move(enemy._position, player._position);
            }

            if (ConsoleKey.Escape == keyInfo.Key)
            {
                isPlaying = false;
            }
        }

        static void Update()
        {
            if(enemy._position._xPos < 0)
            {
                enemy._position._xPos = 0;
            }
            if(enemy._position._yPos < 0)
            {
                enemy._position._yPos = 0;
            }

            if (enemy._position._xPos == player._position._xPos && enemy._position._yPos == player._position._yPos)
            {
                isPlaying = false;
                Console.Clear();
                Console.WriteLine("Game Over! The enemy has caught the player.");
                Console.ReadKey(true);
            }
        }
    }
}
