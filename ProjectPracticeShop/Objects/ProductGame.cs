using ProjectPracticeShop.Delegates;
using ProjectPracticeShop.Interfaces;

namespace ProjectPracticeShop.Objects;

public class ProductGame : IProduct<int, int>, IActionForDelegates
{
    private DelegatesAction.MassageAction? _massage;

    public string Name { get; set; }

    public string Manufacturer { get; set; }

    public int Price { get; set; }

    public int Id { get; set; }

    public string Type { get; set; }

    public ProductGame(string name = "Undefined", string type = "Undefined",
                       int price = 1, int id = 1, string manufacturer = "Undefined")
    {
        Name = name;
        Type = type;
        Price = price;
        Id = id;
        Manufacturer = manufacturer;
    }

    public void Addition(DelegatesAction.MassageAction massage)
    {
        _massage += massage;
    }

    public void Deletion(DelegatesAction.MassageAction massage)
    {
        _massage -= massage;
    }

    public void PrintGame()
    {
        _massage?.Invoke($"Название: {Name}\n" +
                         $"Жанр: {Type}\n" +
                         $"Цена: {Price}\n" +
                         $"Номер: {Id}\n" +
                         $"Производитель: {Manufacturer}\n");
    }
}
