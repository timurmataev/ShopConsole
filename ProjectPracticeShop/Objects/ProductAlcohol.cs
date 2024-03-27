using ProjectPracticeShop.Delegates;
using ProjectPracticeShop.Interfaces;

namespace ProjectPracticeShop.Objects;

public class ProductAlcohol : IProduct<int, int>, IActionForDelegates
{
    private DelegatesAction.MassageAction? _massage;

    public string Name { get; set; }

    public string Manufacturer { get; set; }

    public int Price { get; set; }

    public int Id { get; set; }

    public int AlcoholPower { get; set; }

    public ProductAlcohol(string name = "Undefined", string manufacturer = "Undefined",
                          int price = 1, int id = 1, int alcoholPower = 1)
    {
        Name = name;
        Manufacturer = manufacturer;
        Price = price;
        Id = id;
        AlcoholPower = alcoholPower;
    }

    public void Addition(DelegatesAction.MassageAction massage)
    {
        _massage += massage;
    }

    public void Deletion(DelegatesAction.MassageAction massage)
    {
        _massage -= massage;
    }

    public void PrintAlcohol()
    {
        _massage?.Invoke($"Название: {Name}\n" +
                         $"Производитель {Manufacturer}\n" +
                         $"Цена: {Price}\n" +
                         $"Номер: {Id}\n" +
                         $"Крепкость: {AlcoholPower}\n");
    }
}
