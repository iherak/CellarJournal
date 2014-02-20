using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CellarJournal.Controllers.Interfaces
{
    public interface IChangeBarrelsFrm : IBaseInterface
    {
        string GetWineName();

        int GetBarrel();

        string GetChangeType();
    }
}
