
using System.Data;
using System.Security.Cryptography;

namespace Piano
{
    internal class Program
    {
        static int[] Octaveswitch(ConsoleKeyInfo key) {

            if (key.Key == ConsoleKey.F6) {

                int[] octave = new int[] { 1407, 1109, 1175, 1245, 1319, 1397, 1480, 1568, 1661, 1760, 1865, 1976 };
                int num = 6;
                return octave;


            }

            else if (key.Key == ConsoleKey.F7)
            {
                int[] octave2 = new int[] { 2093, 2217, 2349, 2489, 2637, 2794, 2960, 3136, 3322, 3520, 1865, 1976 };
                return octave2;
                
            }

            else
            {
                int[] Octavedef = new int[] { 1407, 1109, 1175, 1245, 1319, 1397, 1480, 1568, 1661, 1760, 1865, 1976 };
                return Octavedef;
            }
        }

        static void Beep(ConsoleKeyInfo key, int[] octave) {

            if (key.Key == ConsoleKey.C)
            {

                Console.Beep(octave[0], 500);
            }

            else if (key.Modifiers.HasFlag(ConsoleModifiers.Control) && key.Key == ConsoleKey.C){
                Console.Beep(octave[1], 500);
            }

            else if (key.Key == ConsoleKey.D)
            {
                Console.Beep(octave[2], 500);
            }

            else if (key.Modifiers.HasFlag(ConsoleModifiers.Control) && key.Key == ConsoleKey.E)
            {
                Console.Beep(octave[3], 500);
            }

            else if (key.Key == ConsoleKey.E)
            {
                Console.Beep(octave[4], 500);
            }

            else if ( key.Key == ConsoleKey.F)
            {
                Console.Beep(octave[5], 500);
            }

            else if (key.Modifiers.HasFlag(ConsoleModifiers.Control) && key.Key == ConsoleKey.F)
            {
                Console.Beep(octave[6], 500);
            }

            else if (key.Key == ConsoleKey.G)
            {
                Console.Beep(octave[7], 500);
            }

            else if (key.Modifiers.HasFlag(ConsoleModifiers.Control) &&  key.Key == ConsoleKey.G)
            {
                Console.Beep(octave[8], 500);
            }

            else if (key.Key == ConsoleKey.A)
            {
                Console.Beep(octave[9], 500);
            }

            else if (key.Modifiers.HasFlag(ConsoleModifiers.Control) && key.Key == ConsoleKey.B)
            {
                Console.Beep(octave[10], 500);
            }

            else if (key.Key == ConsoleKey.B)
            {
                Console.Beep(octave[11], 500);
            }




        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите октаву F6 или F7");
            ConsoleKeyInfo key = Console.ReadKey();
            int[] octave = Octaveswitch(key);
            do
            {



                Console.WriteLine("Введите ноту");
                key = Console.ReadKey();
                if (key.Key == ConsoleKey.F6 || key.Key == ConsoleKey.F7)
                {
                    Console.WriteLine("Октава изменена");
                    key = Console.ReadKey();
                    octave = Octaveswitch(key);
                }
                Beep(key, octave);
            } while (true);


        }
    }
}