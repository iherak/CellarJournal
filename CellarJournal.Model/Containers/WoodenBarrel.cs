namespace CellarJournal.Model
{
    public class WoodenBarrel : Barrel
    {
        private int _makeYear;
        private string _woodType;

        public WoodenBarrel(int inID, int volume, int year, int makeYear, string woodType )
        : base(volume, year, inID)
        {
            _makeYear = makeYear;
            _woodType = woodType;
        }

        public int getMakeYear()
        {
            return _makeYear;
        }

        public string getWoodType()
        {
            return _woodType;
        }
    }
}
