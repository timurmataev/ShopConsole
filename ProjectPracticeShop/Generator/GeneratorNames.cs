using ProjectPracticeShop.Items;
using ProjectPracticeShop.Objects;

namespace ProjectPracticeShop.Generator;

public class GeneratorNames
{
    private readonly Random _random;
    private readonly PropertiesGame _game;
    private readonly NamesAlcohol _alcohol;

    public void GeneratorNamesGames(int quantity)
    {
        for (int i = 0; i < quantity; i++)
        {
            int choiceName = _random.Next(_game.namesOfGames.Length);
            int choiceType = _random.Next(_game.typesOfGames.Length);
            int choiceManufacturer = _random.Next(_game.manufacturersOfGames.Length);

            var game = new ProductGame
            {
                Name = _game.namesOfGames[choiceName],
                Type = _game.typesOfGames[choiceType],
                Manufacturer = _game.manufacturersOfGames[choiceManufacturer],
                Price = _random.Next(100, 999),
                Id = _random.Next(10000, 19999),
            };

            game.PrintGame();
        }
    }

    public void GeneratorNamesAlcohol(int quantity)
    {
        for (int i = 0; i < quantity; i++)
        {
            int choiceName = _random.Next(_alcohol.namesOfAlcohol.Length);
            int choiceManufacturer = _random.Next(_alcohol.manufacturerOfAlcohol.Length);

            var alcohol = new ProductAlcohol
            {
                Name = _alcohol.namesOfAlcohol[choiceName],
                Manufacturer = _alcohol.manufacturerOfAlcohol[choiceManufacturer],
                Price = _random.Next(500, 2000),
                Id = _random.Next(10000, 19999),
                AlcoholPower = _random.Next(20, 60)
            };

            alcohol.PrintAlcohol();
        }
    }
}
