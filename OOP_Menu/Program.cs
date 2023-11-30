using OOP_Menu;
Menu Menu = new Menu();
bool konec = false;

Console.CursorVisible = false;
Menu.Polozky = new string[15];
for(int i = 0; i < Menu.Polozky.Length; i++)
{
    Menu.Polozky[i] = $"Položka {i + 1}";
}
Menu.vybranapolozka = 5;

do
{
    Menu.Zobrazení();
    var klavesa = Console.ReadKey();
    if (klavesa.Key == ConsoleKey.UpArrow)
    {
        Menu.vybranapolozka--;
        Console.Clear();
        Menu.Zobrazení();
        if (Menu.vybranapolozka < 0)
        {
            Menu.vybranapolozka = Menu.Polozky.Length - 1;
        }
        else if (klavesa.Key == ConsoleKey.DownArrow)
        {
            Menu.vybranapolozka++;
            Console.Clear();
            Menu.Zobrazení();
            if (Menu.vybranapolozka >= Menu.Polozky.Length)
            {
                Menu.vybranapolozka = 0;
            }
        }
        else if (klavesa.Key == ConsoleKey.Escape)
        {
            konec = true;
        }
    }
} while (!konec);

Console.CursorVisible = false;
Console.ReadKey();