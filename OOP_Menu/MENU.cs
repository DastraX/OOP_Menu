using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Menu
{
    public class Menu
    {

        public int X = 0;
        public int Y = 0;
        public string Nadpis = "";
        public ConsoleColor BarvaOkraje = ConsoleColor.Black;
        public ConsoleColor BarvaPozadi = ConsoleColor.White;
        public ConsoleColor BarvaText = ConsoleColor.Black;
        public ConsoleColor BarvaTextKurzor = ConsoleColor.Red;
        public ConsoleColor BarvaKurzor = ConsoleColor.Black;
        public int sirka = 14;
        public int vybranapolozka = 5;
        public string[] Polozky = new string[0];
        
        public void Zobrazení()
        {
            ZobrazOkraj();
            ZobrazNadpis();
            ZobrazPolozky();
            ZobrazKurzor();
        }

        private void ZobrazKurzor()
        {
            if (vybranapolozka >= 0)
            {
                Console.ForegroundColor = BarvaTextKurzor;
                Console.BackgroundColor = BarvaKurzor;
                Console.SetCursorPosition(X + 1, Y + 3 + vybranapolozka);
                Console.Write(new String(' ', sirka));
                Console.SetCursorPosition(X + 1, Y + 3 + vybranapolozka);
                Console.Write("Položka " + (vybranapolozka + 1));
            }
        }

        public void ZobrazPolozky()
        {


            for (int i = 0; i < Polozky.Length; i++)
            {
                Console.BackgroundColor = BarvaPozadi;
                Console.ForegroundColor = BarvaText;
                Console.SetCursorPosition(X + 1, Y + 3 + i);
                Console.Write(Polozky[i]);
            }
        }

        public void ZobrazNadpis()
        {
            Console.BackgroundColor = BarvaPozadi;
            Console.ForegroundColor = BarvaText;
            Console.SetCursorPosition(X + 3, Y + 1);
            Console.Write("MENU");

        }

        private void ZobrazOkraj()
        {
            Console.BackgroundColor = BarvaPozadi;
            Console.ForegroundColor = BarvaOkraje;
            ZobrazRadek('╔', '═', '╗', X, Y);
            ZobrazRadek('║', ' ', '║', X, Y + 1);
            ZobrazRadek('╠', '═', '╣', X, Y + 2);
            for (int i = 0; i < Polozky.Length; i++)
            {
                ZobrazRadek('║', ' ', '║', X, Y + 3 + i);
            }
            ZobrazRadek('╚', '═', '╝', X, Y + 3 + Polozky.Length);
        }

        private void ZobrazRadek(char levy, char stred, char pravy)
        {
            Console.Write(levy);
            Console.Write(new String(stred, sirka));
            Console.WriteLine(pravy);
        }

        private void ZobrazRadek(char levy, char stred, char pravy, int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(levy);
            Console.Write(new String(stred, sirka));
            Console.Write(pravy);
        }
    }
}