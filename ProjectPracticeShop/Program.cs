using ProjectPracticeShop.Delegates;
using ProjectPracticeShop.Show;
using ProjectPracticeShop.UserData;

internal class Program
{
    static void Main(string[] args)
    {
        Registration registration = new();
        DelegatesAction.MassageAction massage;

        try
        {
            registration.Addition(Print.ColorRed);

            Console.WriteLine("\t=---- Магазин ----=\n");
            Console.WriteLine("=-- Регистрация --=");

            Console.Write("Имя: ");
            registration.Name(Console.ReadLine());
            Console.Write("Возраст: ");
            registration.Age(Convert.ToInt32(Console.ReadLine()));
            Console.Write("Пароль: ");
            registration.Password(Convert.ToInt32(Console.ReadLine()));

            Console.ReadKey();
            Console.Clear();

            int money = 0, quantity = 0;
            Console.WriteLine($"Количество монет: {money}\nКоличество покупок: {quantity}\n");

        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }


    }
}
