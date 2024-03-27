using ProjectPracticeShop.Delegates;

namespace ProjectPracticeShop.Interfaces;

public interface IProduct<TId, TPrice>
{
    public string Name { get; set; }

    public string Manufacturer { get; set; }

    public TPrice Price { get; set; }

    public TId Id { get; set; }
}
