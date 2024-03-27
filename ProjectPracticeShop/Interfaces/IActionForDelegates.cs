using ProjectPracticeShop.Delegates;

namespace ProjectPracticeShop.Interfaces;

public interface IActionForDelegates
{
    public void Addition(DelegatesAction.MassageAction massage);

    public void Deletion(DelegatesAction.MassageAction massage);
}
