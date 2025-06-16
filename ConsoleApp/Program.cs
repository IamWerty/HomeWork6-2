Console.Write("Вітаю в зірковій прямокутній піраміді!\n Скільки поверхів ви хочете збудувати?\n");
int numberOfStars = Convert.ToInt16(Console.ReadLine());
string tower = "*";
for (int i = 0; i != numberOfStars; i++)
{
        Console.WriteLine(tower);
        tower += "*";
}