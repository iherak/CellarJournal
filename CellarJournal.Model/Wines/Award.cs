using System;

namespace CellarJournal.Model
{
	public class Award
	{
        private DateTime _date;
        private string _location;
        private MedalTypes _medal;
        private string _otherInfo;

	    public Award(DateTime time, string location)
	    {
	        _date = time;
	        _location = location;
	    }

	    public Award (DateTime time, string location, MedalTypes medal)
		{
            _date = time;
            _location = location;
            _medal = medal;
	        switch (medal)
	        {
	                case MedalTypes.GOLD:
	                    _otherInfo = "ZLATNA MEDALJA! ";
                        break;
                    case MedalTypes.SILVER:
	                    _otherInfo = "SREBRNA MEDALJA! ";
	                    break;
                    case MedalTypes.BRONZE:
	                    _otherInfo = "BRONÈANA MEDALJA! ";
	                    break;
                    case MedalTypes.NONE:
	                    _otherInfo = "Bez medalje. ";
                        break;
	        }
		}

        public DateTime Date
        {
            get { return _date; }
            set { _date = value; }
        }

        public string Location
        {
            get { return _location; }
            set { _location = value; }
        }

        public MedalTypes Medal
        {
            get { return _medal; }
            set { _medal = value; }
        }

	    public string OtherInfo
        {
            get { return _otherInfo; }
            set { _otherInfo = value; }
        }
	}
}

