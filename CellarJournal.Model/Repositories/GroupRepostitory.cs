using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CellarJournal.Utility;

namespace CellarJournal.Model.Repositories
{
    public class GroupRepostitory : Subject
    {
        private static GroupRepostitory _groupRepository = null;

        private Dictionary<string, List<Container>> _groups = new Dictionary<string, List<Container>>();

        public static GroupRepostitory getInstance()
        {
            if (_groupRepository == null)
                _groupRepository = new GroupRepostitory();
            return _groupRepository;
        }

        public void AddGroup(string name, List<Container> cList)
        {
            _groups.Add(name, cList);
            notifyObservers();
        }

        public List<Container> GetGroup(string name)
        {
            if(_groups.Count==0)
                _groups.Add("",null);
            return _groups[name];
        }

        public List<string> GetNames()
        {
            List<String> toReturn = new List<string>();
            if (_groups.Count == 0)
            {
                toReturn.Add("");
                return toReturn;
            }
            toReturn.Add("");
            toReturn.AddRange(_groups.Select(keyValuePair => keyValuePair.Key));
            return toReturn;
        }

        public void RemoveGroup(string name)
        {
            _groups.Remove(name);
        }
    }
}
