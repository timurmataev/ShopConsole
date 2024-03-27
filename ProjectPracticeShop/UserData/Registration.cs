using ProjectPracticeShop.Delegates;
using ProjectPracticeShop.Interfaces;

namespace ProjectPracticeShop.UserData;

public class Registration : IRegistration, IActionForDelegates
{
    private string _name = "Undefined";
    private int _age = 0;
    private int _password = 0;
    private DelegatesAction.MassageAction? _massage;

    public void Name(string name)
    {
        if (name is not string)
            throw new Exception("Name not set");

        _name = name;
    }

    public void Age(int age)
    {
        if (age < 1 || age > 110)
            throw new Exception("Range violation");

        _age = age;
    }

    public void Password(int password)
    {
        if (password < 9999)
            throw new Exception("More than four numbers");

        _password = password;
    }

    public void Addition(DelegatesAction.MassageAction massage)
    {
        _massage += massage;
    }

    public void Deletion(DelegatesAction.MassageAction massage)
    {
        _massage -= massage;
    }
}
