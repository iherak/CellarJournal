using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CellarJournal.Model;
using CellarJournal.Utility;

namespace CellarJournal.Controllers
{
    public interface IAddGroupForm : IBaseInterface
    {
        string GetName();

        WineTypes GetWineType();

        string GetBarrelType();
    }
}
