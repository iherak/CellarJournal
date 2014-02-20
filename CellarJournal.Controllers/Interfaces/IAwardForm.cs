using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CellarJournal.Utility;

namespace CellarJournal.Controllers
{
    public interface IAwardForm : IBaseInterface, IObserver
    {
        void ShowEx(string wineName);
    }
}
