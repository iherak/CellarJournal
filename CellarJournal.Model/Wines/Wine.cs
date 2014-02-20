using System;
using System.Collections.Generic;
using System.Linq;
using CellarJournal.Utility;

namespace CellarJournal.Model
{
	public class Wine
	{
	    private string _name;
	    private int _year;
	    private WineTypes _type;
	    private string _description = "";
	    private ActivityHistory _activities;
		private List<Award> _prizeHistory;
	    private List<Container> _containerHistory;
		
		public Wine (string name, WineTypes type, int year)
		{
            _name = name;
            _type = type;
		    _year = year;
		    _activities = new ActivityHistory();
            _prizeHistory = new List<Award>();
            _containerHistory = new List<Container>();
		}

	    public string Name
	    {
            get { return _name; }
            set { _name = value; }
	    }

	    public WineTypes Type
	    {
	        get { return _type; }
	        set { _type = value; }
        }

	    public int Year
	    {
            get { return _year; }
            set { _year = value; }
	    }

	    public string Description 
        {
            get { return _description; }
            set { _description = value; }
        }

	    public void addContainer(Container container)
	    {
            _containerHistory.Add(container);
	    }

	    public Container getLastContainer()
	    {
	        if (_containerHistory.Count == 0)
	            throw new WineWithoutContainerException();
	        return _containerHistory.Last();
	    }

	    public List<Container> getAllContainers()
	    {
	        return _containerHistory;
	    }

	    public void addActivity (DateTime time, string activity)
        {
            _activities.addActivity(time, activity);
        }

        public string getActivity(DateTime time)
        {
            return _activities.getActivity(time);
        }

	    public List<KeyValuePair<DateTime, string>> GetAllActivites()
	    {
	        return _activities.GetAllActivites();
	    }

	    public void addPrize(DateTime time, string location)
	    {
	        Award newPrize = new Award(time, location);
            _prizeHistory.Add(newPrize);
	    }

	    public void addPrize(DateTime time, string location, MedalTypes medal)
	    {
            Award newPrize = new Award(time, location, medal);
            _prizeHistory.Add(newPrize);
	    }

	    public List<Award> getPrize(MedalTypes medal)
	    {
	        return _prizeHistory.Where(prize => prize.Medal == medal).ToList();
	    }

	    public void addPrizeInfor(DateTime time, string info)
	    {
	        foreach (Award prize in _prizeHistory)
	        {
	            if (prize.Date == time)
	                prize.OtherInfo = info;
	        }
	    }

        public string getPrizeInfo(DateTime time)
        {
            foreach (Award prize in _prizeHistory)
            {
                if (prize.Date == time)
                    return prize.OtherInfo;
            }
            throw new NoPrizeException();
        }

	    public List<Award> GetAwards()
	    {
	        return _prizeHistory;
	    }
	}
}