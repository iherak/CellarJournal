namespace CellarJournal.Model
{
	public abstract class Barrel : Container
	{
		private string _name;
	    public int Volume { get; private set; }

	    protected Barrel (int volume, int year, int inID)
            :base(year, inID)
		{
            if (checkVolume(volume))
	            Volume = volume;
            else
            {
                throw new VolumeError();
            }
		}

	    private bool checkVolume(int vol)
	    {
	        return vol > 0;
	    }

	    public string Name
	    {
	        get { return _name; }
            set { _name = value; }
	    }

        public int getBarrelVolume ()
        {
            return Volume;
        }
	}
}

