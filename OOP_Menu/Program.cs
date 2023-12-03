using OOP_Menu;
Menu Menu = new Menu();
bool konec = false;

Menu.X = 10;
Menu.Y = 5;

Console.CursorVisible = false;
Menu.Polozky = new string[15];
for(int i = 0; i < Menu.Polozky.Length; i++)
{
    Menu.Polozky[i] = $"Položka {i + 1}";
}
Menu.vybranapolozka = 0;
Menu.Zobrazení();
do
{
    Console.Clear();
    Menu.Zobrazení();
    var klavesa = Console.ReadKey();
    if (klavesa.Key == ConsoleKey.UpArrow)
    {
        Menu.vybranapolozka--;
        if (Menu.vybranapolozka < 0)
        {
            Menu.vybranapolozka = Menu.Polozky.Length - 1;
            Console.Clear();
        }
    }
    else if (klavesa.Key == ConsoleKey.DownArrow)
    {
        Menu.vybranapolozka++;
        if (Menu.vybranapolozka > Menu.Polozky.Length - 1)
        {
            Menu.vybranapolozka = 0;
            Console.Clear();
        }
    }
    else if (klavesa.Key == ConsoleKey.Escape)
    {
        konec = true;
    }
} while (!konec);

Console.CursorVisible = false;
Console.SetCursorPosition(0, Menu.Polozky.Length + 3);