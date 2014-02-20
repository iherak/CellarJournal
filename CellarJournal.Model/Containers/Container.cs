using System.Collections.Generic;
using System.Linq;
using CellarJournal.Utility;

namespace CellarJournal.Model
{
    public abstract class Container
    {
        public int ID { get; private set; }
        private string _manufacturer;
        private Wine _containingWine = null;
        private List<int> _activeYear = new List<int>();

        protected Container(int year, int inID)
        {
            _activeYear.Add(year);
            ID = inID;
        }

        public int getActiveYear()
        {
            return _activeYear.Last();
        }

        public Wine ContainingWine
        {
            get { return _containingWine; }
            set { _containingWine = value;}
        }

        public string Manufacturer
        {
            get { return _manufacturer; }
            set { _manufacturer = value; }
        }
    }
}
