using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CellarJournal.Utility;

namespace CellarJournal.Model.Repositories
{
    public class WineRepository : Subject
    {
        private static WineRepository _wineRepository = null;

        private List<Wine> _wines = new List<Wine>();

        public static WineRepository getInstance()
        {
            if (_wineRepository == null)
                _wineRepository = new WineRepository();
            return _wineRepository;
        }

        public void addWine(Wine newWine)
        {
            if (!wineExists(newWine.Name, newWine.Year))
            {
                _wines.Add(newWine);
                notifyObservers();
            }
            else
                throw new WineAlreadyExists();
        }

        public bool wineExists(string name, int year)
        {
            return _wines.Any(wine => wine.Year == year && wine.Name == name);
        }

        public int wineCount()
        {
            return _wines.Count;
        }

        public Wine getWine(string name, int year)
        {
            foreach (Wine wine in _wines)
            {
                if (wine.Name == name && wine.Year == year)
                    return wine;
            }
            throw new WineDoesntExist();
        }

        public List<Wine> getAllWinesInYear(int activeYear)
        {
            return _wines.Where(wine => wine.Year == activeYear).ToList();
        }

        public List<Wine> GetByType(WineTypes type)
        {
            return _wines.Where(wine => wine.Type == type).ToList();
        }

        public void AddDescription(string wineName,int year, string desc)
        {
            if (wineExists(wineName, year))
            {
                Wine wineToEdit = getWine(wineName, year);
                wineToEdit.Description = desc;
                notifyObservers();
            }
            else
            {
                throw new WineDoesntExist();
            }
        }

        public void AddActivity(string wineName, int year, DateTime time, string activity)
        {
            if (wineExists(wineName, year))
            {
                Wine wineToEdit = getWine(wineName, year);
                wineToEdit.addActivity(time, activity);
                notifyObservers();
            }
            else
            {
                throw new WineDoesntExist();
            }
        }

        public List<Award> GetAwards(string name, int year)
        {
            Wine wine = getWine(name, year);

            return wine.GetAwards();
        }

        public void AddContainerToWine(string selectedWineName, int activeYear, Container selectedBarrel)
        {
            Wine wine = getWine(selectedWineName, activeYear);
            wine.addContainer(selectedBarrel);

            notifyObservers();
        }

        public void AddAward(string name, int activeYear, DateTime time, string location, MedalTypes medal)
        {
            Wine wine = getWine(name, activeYear);
            wine.addPrize(time, location, medal);
            notifyObservers();
        }

        public void ChangeContainer(string selectedWineName, int selectedBarrelID, string changeType, int activeYear)
        {
            Wine selectedWine = _wineRepository.getWine(selectedWineName, activeYear);
            Container tempCont = ContainerRepository.getInstance().getContainer(selectedBarrelID);
            Barrel selectedBarrel = null;
            if (tempCont is Barrel)
                selectedBarrel = tempCont as Barrel;

            string activity = changeType + " pretok iz bačve " + selectedWine.getLastContainer().ID
                              + " u bačvu " + selectedBarrelID;

            ContainerRepository.getInstance().ChangeContainingWine(selectedBarrel, selectedWine);
            _wineRepository.AddContainerToWine(selectedWineName, activeYear, selectedBarrel);
            _wineRepository.AddActivity(selectedWineName, activeYear, DateTime.Now, activity);

            selectedBarrel.ContainingWine = selectedWine;
        }
    }
}
