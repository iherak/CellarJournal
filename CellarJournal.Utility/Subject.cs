using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CellarJournal.Utility
{
    public abstract class Subject
    {
        List<IObserver> _listObs = new List<IObserver>();

        public void addObserver(IObserver inObs)
        {
            _listObs.Add(inObs);
        }

        public void notifyObservers()
        {
            foreach (IObserver obs in _listObs)
                obs.UpdateEx();
        }
    }
}
