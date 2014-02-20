using System.Collections.Generic;
using CellarJournal.Model;
using CellarJournal.Utility;

namespace CellarJournal.Controllers
{
    public interface IMainForm : IObserver
    {
        void Show();

        void Update(List<Wine> wines);

        void UpdateLabel(int emptyCont);
    }
}
