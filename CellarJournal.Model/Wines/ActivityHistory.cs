using System;
using System.Collections.Generic;
using System.Linq;

namespace CellarJournal.Model
{
	public class ActivityHistory
    {
        public List<KeyValuePair<DateTime, string>> _activities;

        public ActivityHistory()
        {
            _activities = new List<KeyValuePair<DateTime, string>>();
            //DateTime date = new DateTime();
            //string empty = "";
            //_activities.Add(new KeyValuePair<DateTime, string>(date, empty));
        }

		public void addActivity (DateTime time, string activity)
		{
            _activities.Add(new KeyValuePair<DateTime, string>(time, activity));
		}

        public string getActivity(DateTime time)
        {
            foreach (var keyValuePair in _activities)
            {
                if (keyValuePair.Key == time)
                {
                    return keyValuePair.Value;
                }
            }
            return "";
        }

        public void editActivity(DateTime time, string editedActivity)
        {
            bool found = false;
            List<KeyValuePair<DateTime, string>> list = new List<KeyValuePair<DateTime, string>>(_activities);
            for (int i = 0; i < _activities.Count; i++)
            {
                if (_activities[i].Key == time)
                {
                    _activities.Remove(_activities.First(item => item.Key.Equals(time)));
                    _activities.Add(new KeyValuePair<DateTime, string>(time, editedActivity));
                }
            }
            if (!found)
                    throw new Exception("Zapis na datum ne postoji!");
        }

	    public List<KeyValuePair<DateTime, string>> GetAllActivites()
	    {
	        return _activities;
	    }
    }
}

