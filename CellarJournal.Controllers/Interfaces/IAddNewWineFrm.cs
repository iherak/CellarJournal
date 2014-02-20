using System.Collections.Generic;
using CellarJournal.Model;

namespace CellarJournal.Controllers
{
    public interface IAddNewWineFrm : IBaseInterface
    {
        int ShowEx(List<Container> emptyContainers);

        string GetName();

        WineTypes GetWineType();

        Container GetContainer();

        string GetDescription();

        void ErrorReport(System.Exception ex);
    }
}
