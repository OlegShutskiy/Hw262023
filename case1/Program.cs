
Console.Write("Введите пятизначное число: ");
int a = Convert.ToInt32(Console.ReadLine());
bool b = true;
String text = Convert.ToString(a);
for (int i = 0; i < 2; i++)
{
    if (text[i] == text[text.Length - i - 1])
    {
        b = true;
    }
    else
    {
        b = false;
    }
}
if (b)
    Console.WriteLine($"число {a} - палиндром");
else
    Console.WriteLine($"Число {a} не - полиндром");

