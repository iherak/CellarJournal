using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CellarJournal.Utility;

namespace CellarJournal.Controllers 
{
    public interface IJournalForm : IBaseInterface, IObserver
    {
        void ShowActivity();

        void ShowEx(string wineName);
    }
}
