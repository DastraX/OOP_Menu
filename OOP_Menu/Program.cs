//Console.ForegroundColor = ConsoleColor.Green;
//Console.WriteLine("╔══════════════════╗");
//Console.WriteLine("║                  ║");
//Console.WriteLine("╠══════════════════╣");
//Console.WriteLine("║                  ║");
//Console.WriteLine("╠══════════════════╣");
//Console.WriteLine("║                  ║");
//Console.WriteLine("╠══════════════════╣");
//Console.WriteLine("║                  ║");
//Console.WriteLine("╚══════════════════╝");

//Console.ForegroundColor = ConsoleColor.Black;
//Console.SetCursorPosition(1, 1);
//Console.BackgroundColor = ConsoleColor.Yellow;
//Console.WriteLine("                  ");
//Console.SetCursorPosition(8, 1);
//Console.Write("MENU");

//Console.ForegroundColor = ConsoleColor.Black;
//Console.SetCursorPosition(1, 3);
//Console.BackgroundColor = ConsoleColor.Yellow;
//Console.WriteLine("                  ");
//Console.SetCursorPosition(6, 3);
//Console.Write("Položka 1");

//Console.ForegroundColor = ConsoleColor.Black;
//Console.SetCursorPosition(1, 5);
//Console.BackgroundColor = ConsoleColor.Yellow;
//Console.WriteLine("                  ");
//Console.SetCursorPosition(6, 5);
//Console.Write("Položka 2");

//Console.ForegroundColor = ConsoleColor.Black;
//Console.SetCursorPosition(1, 7);
//Console.BackgroundColor = ConsoleColor.Yellow;
//Console.WriteLine("                  ");
//Console.SetCursorPosition(6, 7);
//Console.Write("Položka 3");


using OOP_Menu;
Menu Menu = new Menu();

Console.CursorVisible = false;
Menu.Polozky = new string[15];
for(int i = 0; i < Menu.Polozky.Length; i++)
{
    Menu.Polozky[i] = $"Položka {i + 1}";
}
Menu.vybranapolozka = 3;

Menu.Zobrazení();
Console.CursorVisible = false;
Console.ReadKey();