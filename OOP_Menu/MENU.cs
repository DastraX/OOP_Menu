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
        public ConsoleColor BarvaPozadi = ConsoleColor.DarkYellow;
        public ConsoleColor BarvaKurzor = ConsoleColor.White;
        public ConsoleColor BarvaText = ConsoleColor.Yellow;
        public int sirka = 20;
        public string[] Polozky = new string[0];
        
        public void Zobrazení()
        {
            ZobrazOkraj();
            ZobrazNadpis(); 
        }

        private void ZobrazNadpis()
        {
            Console.BackgroundColor = BarvaPozadi;
            Console.ForegroundColor = BarvaText;
            Console.SetCursorPosition(9, 1);
            Console.Write("MENU");

        }

        private void ZobrazOkraj()
        {
            Console.BackgroundColor = BarvaPozadi;
            Console.BackgroundColor = BarvaOkraje;
            Console.Write("╔");
            Console.Write(new String('═', sirka));
            Console.WriteLine("╗");
            Console.Write("║");
            Console.Write(new String(' ', sirka));
            Console.WriteLine("║");
            Console.Write("╠");
            Console.Write(new String('═', sirka));
            Console.WriteLine("╣");
            Console.Write("║");
            Console.Write(new String(' ', sirka));
            Console.WriteLine("║");
            Console.Write("║");
            Console.Write(new String(' ', sirka));
            Console.WriteLine("║");
            Console.Write("║");
            Console.Write(new String(' ', sirka));
            Console.WriteLine("║");

            Console.Write("╚");
            Console.Write(new String('═', sirka));
            Console.Write("╝");
            

        }
    }
}
