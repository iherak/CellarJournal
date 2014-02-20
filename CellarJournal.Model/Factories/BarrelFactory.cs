namespace CellarJournal.Model.Factories
{
    public class BarrelFactory
    {
        public static Barrel CreateInoxBarrel(int volume, int year)
        {
            if (!CheckPreconditions(volume, year))
                throw new CreateBarrelException();
            return new InoxBarrel(volume, year, IDs.ID());
        }

        public static Barrel CreateWoodenBarrel(int volume,int year, int makeYear, string woodType)
        {
            if(!CheckPreconditions(volume, year))
                throw new CreateBarrelException();
            return  new WoodenBarrel(IDs.ID(), volume, year, makeYear, woodType);
        }

        private static bool CheckPreconditions(int volume, int year)
        {
            if (volume < 0 || year < 0)
                return false;
            else
                return true;
        }
    }
}
