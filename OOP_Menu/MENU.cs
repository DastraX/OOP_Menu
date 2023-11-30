using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Menu
{
    public class Menu
    {
        public string Nadpis = "";
        public ConsoleColor BarvaOkraje = ConsoleColor.Black;
        public ConsoleColor BarvaPozadi = ConsoleColor.White;
        public ConsoleColor BarvaKurzor = ConsoleColor.White;
        public ConsoleColor BarvaText = ConsoleColor.Black;
        public ConsoleColor BarvaTextCursor = ConsoleColor.Black;
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

        public void ZobrazKurzor()
        {
            if (vybranapolozka >= 0)
            {
                Console.BackgroundColor = BarvaTextCursor;
                Console.ForegroundColor = BarvaKurzor;
                Console.SetCursorPosition(1, 3 + vybranapolozka);
                Console.Write(new String(' ', sirka));
            }    
        }

        public void ZobrazPolozky()
        {
            
            Console.SetCursorPosition(1, 3);
            for(int i = 0; i < Polozky.Length; i++)
            {
                if(i == vybranapolozka)
                {
                    Console.BackgroundColor = BarvaTextCursor;
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    Console.BackgroundColor = BarvaPozadi;
                    Console.ForegroundColor = BarvaText;
                }
                Console.SetCursorPosition(1,3 + i);
                Console.WriteLine(Polozky[i]);
            }
        }

        public void ZobrazNadpis()
        {
            Console.BackgroundColor = BarvaPozadi;
            Console.ForegroundColor = BarvaText;
            Console.SetCursorPosition(sirka/2-1, 1);
            Console.Write("MENU");

        }

        public void ZobrazOkraj()
        {
            Console.BackgroundColor = BarvaPozadi;
            Console.ForegroundColor = BarvaOkraje;
            Console.Write("╔");
            Console.Write(new String('═', sirka));
            Console.WriteLine("╗");
            Console.Write("║");
            Console.Write(new String(' ', sirka));
            Console.WriteLine("║");
            Console.Write("╠");
            Console.Write(new String('═', sirka));
            Console.WriteLine("╣");
            for(int i = 0; i < Polozky.Length; i++)
            {
                Console.Write("║");
                Console.Write(new String(' ', sirka));
                Console.WriteLine("║");
            }
            Console.Write("╚");
            Console.Write(new String('═', sirka));
            Console.Write("╝");
            

        }
    }
}
