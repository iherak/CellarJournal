using System;
using System.Collections.Generic;
using System.Linq;
using CellarJournal.Controllers.Interfaces;
using CellarJournal.Model;
using CellarJournal.Model.Factories;
using CellarJournal.Model.Repositories;

namespace CellarJournal.Controllers
{
    public class MainController
    {
        private readonly WineRepository _wineRepository = WineRepository.getInstance();
        private readonly ContainerRepository _containerRepository = ContainerRepository.getInstance();
        private readonly GroupRepostitory _groupRepostitory = GroupRepostitory.getInstance();
        public List<int> _years = new List<int>();
        public int activeYear;
        public string selectedGroup = "";

        public MainController(IMainForm mainForm)
        {
            WineRepository.getInstance().addObserver(mainForm);
            ContainerRepository.getInstance().addObserver(mainForm);
        }

        public void UpdateList(IMainForm rMainForm)
        {
            List<Wine> wineList = _wineRepository.getAllWinesInYear(activeYear);

            rMainForm.Update(wineList);
        }

        public void DefaultModel()
        {
            activeYear = 2012;
            _years.Add(2012);
            _years.Add(2011);
            WineRepository wineRep = WineRepository.getInstance();
            ContainerRepository barrRep = ContainerRepository.getInstance();

            Container barrel1 = BarrelFactory.CreateInoxBarrel(620, 2012);
            Container barrel2 = BarrelFactory.CreateInoxBarrel(620, 2012);
            Container barrel3 = BarrelFactory.CreateInoxBarrel(480, 2012);
            Container barrel4 = BarrelFactory.CreateInoxBarrel(120, 2012);
            Container barrel5 = BarrelFactory.CreateInoxBarrel(130, 2012);
            Container barrel6 = BarrelFactory.CreateInoxBarrel(480, 2012);
            Container barrel7 = BarrelFactory.CreateInoxBarrel(480, 2012);
            Container barrel8 = BarrelFactory.CreateInoxBarrel(520, 2012);
            Container barrel9 = BarrelFactory.CreateInoxBarrel(620, 2012);
            
            Container barrel10 = BarrelFactory.CreateInoxBarrel(480, 2011);
            Container barrel11 = BarrelFactory.CreateInoxBarrel(480, 2011);


            barrRep.addContainer(barrel1);
            barrRep.addContainer(barrel2);
            barrRep.addContainer(barrel3);
            barrRep.addContainer(barrel4);
            barrRep.addContainer(barrel5);
            barrRep.addContainer(barrel6);
            barrRep.addContainer(barrel7);
            barrRep.addContainer(barrel8);
            barrRep.addContainer(barrel9);
            barrRep.addContainer(barrel10);
            barrRep.addContainer(barrel11);

            Wine wine1 = WineFactory.createWine("Lokacija 1", WineTypes.ŠKRLET, 2012, barrel1);
            Wine wine2 = WineFactory.createWine("Lokacija 2", WineTypes.ŠKRLET, 2012, barrel2);
            Wine wine3 = WineFactory.createWine("Lokacija 3", WineTypes.ŠKRLET, 2012, barrel3);
            Wine wine4 = WineFactory.createWine("Lokacija 1 - crno", WineTypes.FRANKOVKA, 2012, barrel4);
            Wine wine5 = WineFactory.createWine("Neko ime", WineTypes.GRASEVINA, 2012, barrel5);
            Wine wine6 = WineFactory.createWine("Jos jedno ime", WineTypes.GRASEVINA, 2012, barrel6);

            Wine wine7 = WineFactory.createWine("Lokacija 1", WineTypes.ŠKRLET, 2011, barrel10);
            Wine wine8 = WineFactory.createWine("Lokacija 2", WineTypes.ŠKRLET, 2011, barrel11);

            wineRep.addWine(wine1);
            wineRep.addWine(wine2);
            wineRep.addWine(wine3);
            wineRep.addWine(wine4);
            wineRep.addWine(wine5);
            wineRep.addWine(wine6);
            wineRep.addWine(wine7);
            wineRep.addWine(wine8);

            DateTime activityTime = new DateTime(2012, 11, 25);
            wine1.addActivity(activityTime, "Dodan sumpor");
            DateTime activityTime1 = new DateTime(2012, 10, 15);
            wine1.addActivity(activityTime1, "Dodan sumpor");
            DateTime activityTime2 = new DateTime(2012, 12, 01);
            wine1.addActivity(activityTime2, "Dodani kvasci");
            DateTime activityTime3 = new DateTime(2013, 01, 24);
            wine1.addActivity(activityTime3, "Dodana hrana");

            wine2.addActivity(activityTime, "Dodan sumpor");
            wine2.addActivity(activityTime1, "Dodan sumpor");
            wine2.addActivity(activityTime3, "Dodana hrana");

            wine3.addActivity(activityTime, "Dodan sumpor");
            wine3.addActivity(activityTime1, "Dodan sumpor");
            wine3.addActivity(activityTime3, "Dodana hrana");

            wine4.addActivity(activityTime, "Dodan sumpor");
            wine4.addActivity(activityTime1, "Dodan sumpor");
            wine4.addActivity(activityTime3, "Dodana hrana");

            wine1.addPrize(new DateTime(2012, 11, 01), "Kutina", MedalTypes.GOLD );
            wine1.addPrize(new DateTime(2013, 01 , 05), "Popovača", MedalTypes.GOLD);
            wine1.addPrize(new DateTime(2012, 01, 12), "Sisak", MedalTypes.SILVER);

            wine2.addPrize(new DateTime(2012, 11, 01), "Kutina", MedalTypes.GOLD);
            wine2.addPrize(new DateTime(2013, 01, 05), "Popovača", MedalTypes.GOLD);
            wine2.addPrize(new DateTime(2012, 01, 12), "Sisak", MedalTypes.BRONZE);

            wine3.addPrize(new DateTime(2012, 11, 01), "Kutina", MedalTypes.BRONZE);
            wine3.addPrize(new DateTime(2013, 01, 05), "Popovača", MedalTypes.GOLD);
            wine3.addPrize(new DateTime(2012, 01, 12), "Sisak", MedalTypes.SILVER);

            wine4.addPrize(new DateTime(2012, 11, 01), "Kutina", MedalTypes.GOLD);
            wine4.addPrize(new DateTime(2013, 01, 05), "Popovača", MedalTypes.GOLD);
            wine4.addPrize(new DateTime(2012, 01, 12), "Sisak", MedalTypes.GOLD);

            wine8.addPrize(new DateTime(2011, 11, 05), "Kutina", MedalTypes.GOLD);
            wine8.addPrize(new DateTime(2012, 01, 25), "Popovača", MedalTypes.GOLD);
            wine8.addPrize(new DateTime(2012, 05, 15), "Sisak", MedalTypes.SILVER);

            GroupRepostitory _groupRep = GroupRepostitory.getInstance();

            List<Wine> wines = _wineRepository.GetByType(WineTypes.ŠKRLET);
            List<Container> barrels = new List<Container>();
            barrels.AddRange(wines.Select(wine => wine.getLastContainer() as Barrel));
            _groupRep.AddGroup("Grupa Škrlet", barrels);

            //_wineRepository.ChangeContainer(wine2.Name, barrel9.ID, "Zatvoreni", 2012);
            _wineRepository.ChangeContainer(wine5.Name, barrel7.ID, "Otvoreni", 2012);
            _wineRepository.ChangeContainer(wine6.Name, barrel8.ID, "Zatvoreni", 2012);
        }

        public void AddNewYear(IAddNewYearFrm yearForm)
        {
            if (yearForm.ShowEx() == 1)
            {
                try
                {
                    activeYear = yearForm.GetYear();
                    _years.Add(activeYear);
                    _years.Sort();
                    _years.Reverse();

                }
                catch (Exception ex)
                {

                    yearForm.Error(ex.ToString());
                }
            }
        }

        public void AddWine(IAddNewWineFrm newWineForm)
        {
            List<Container> emptyContainers = _containerRepository.GetEmptyContainers(activeYear);

            try
            {

                if (newWineForm.ShowEx(emptyContainers) == 1)
                {
                    string name = newWineForm.GetName();
                    WineTypes type = newWineForm.GetWineType();
                    string desc = newWineForm.GetDescription();
                    Container container = newWineForm.GetContainer();

                    try
                    {
                        Wine newWine = WineFactory.createWine(name, type, activeYear, container);

                        if (desc != "")
                            newWine.Description = desc;

                        _wineRepository.addWine(newWine);

                    }
                    catch (Exception ex)
                    {

                        throw ex;
                    }
                }
            }
            catch (Exception exception)
            {
                newWineForm.ErrorReport(exception);
            }
        }

        public void AddInoxBarrel(IAddNewBarrelFrm addInoxForm)
        {
            if (addInoxForm.ShowEx() == 1)
            {
                int volume = addInoxForm.GetVolume();

                Barrel newBarrel = BarrelFactory.CreateInoxBarrel(volume, activeYear);

                _containerRepository.addContainer(newBarrel);
            }
        }

        public void AddWoodenBarrel(IAddNewWoodenBarrelFrm newWoodenForm)
        {
            if (newWoodenForm.ShowEx() == 1)
            {
                int volume = newWoodenForm.GetVolume();
                int makeYear = newWoodenForm.GetMakeYear();
                string wood = newWoodenForm.GetWoodType();

                Barrel newBarrel = BarrelFactory.CreateWoodenBarrel(volume, activeYear, makeYear, wood);

                _containerRepository.addContainer(newBarrel);
            }
        }

        public void UpdateLabel(IMainForm mainForm)
        {
            List<Container> emptyCont = _containerRepository.GetEmptyContainers(activeYear);

            mainForm.UpdateLabel(emptyCont.Count);
        }

        public void AddDescription(IAddDescriptionFrm addDescFrm, string wineName)
        {
            if (addDescFrm.ShowEx() == 1)
            {
                string desc = addDescFrm.GetDescription();

                _wineRepository.AddDescription(wineName, activeYear, desc);
            }
        }

        public List<Container> GetEmptyContainers()
        {
            return _containerRepository.GetEmptyContainers(activeYear);
        }

        public void ShowList(IListEmptyContainers listForm)
        {
            ContainerRepository.getInstance().addObserver(listForm);

            listForm.ShowEx();
        }

        public void CreateGroup(IAddGroupForm groupForm, IMainForm mainForm)
        {
            _groupRepostitory.addObserver(mainForm);
            List<Container> barrels = new List<Container>();
            if (groupForm.ShowEx() == 1)
            {
                string name = groupForm.GetName();
                WineTypes wineType = groupForm.GetWineType();
                string barrelType = groupForm.GetBarrelType();

                if (wineType == WineTypes.NONE)
                {
                   barrels  = fetchBarrels(barrelType);
                }
                else if (barrelType == "")
                {
                    List<Wine> wines = _wineRepository.GetByType(wineType);
                    barrels.AddRange(wines.Select(wine => wine.getLastContainer() as Barrel));
                }
                else
                {
                    List<Container> barrels1 = fetchBarrels(barrelType);

                    barrels.AddRange(barrels1.Where(container => container.ContainingWine.Type == wineType));
                }
                _groupRepostitory.AddGroup(name, barrels);
            }

        }

        private List<Container> fetchBarrels(string barrelType)
        {
            List<Container> returnBarrels = new List<Container>();

            foreach (Wine wine in _wineRepository.getAllWinesInYear(activeYear))
            {
                if (wine.getLastContainer() is Barrel)
                {
                    Barrel barrel = wine.getLastContainer() as Barrel;
                    switch (barrelType)
                    {
                        case "Drvena":
                            if (barrel is WoodenBarrel)
                            {
                                returnBarrels.Add(barrel);
                            }
                            break;
                        case "Inox":
                            if (barrel is InoxBarrel)
                            {
                                returnBarrels.Add(barrel);
                            }
                            break;
                    }
                }
            }
            return returnBarrels;
        }

        public List<string> GetGroupNames()
        {
            return _groupRepostitory.GetNames();
        }

        public List<Wine> GetGroupWines()
        {
            if (selectedGroup == "")
                return null;
            else
            {
                List<Container> containers = _groupRepostitory.GetGroup(selectedGroup).Where(container => container.getActiveYear() == activeYear).ToList();
                containers = containers.Where(container => container.ContainingWine != null).ToList();
                List<Wine> groupWines = containers.Select(container => container.ContainingWine).ToList();
                return groupWines;
            }
        }

        public void Journal(IJournalForm journalForm, string wineName)
        {
            WineRepository.getInstance().addObserver(journalForm);

            journalForm.ShowEx(wineName);
        }

        public List<KeyValuePair<DateTime, string>> GetActivites(string wineName)
        {
            Wine wine = _wineRepository.getWine(wineName, activeYear);

            return wine.GetAllActivites();
        }

        public void AddActivity(string wineName, string p)
        {
            _wineRepository.AddActivity(wineName, activeYear, DateTime.Now, p);
        }

        public void Awards(IAwardForm awardForm, string wineName)
        {
            WineRepository.getInstance().addObserver(awardForm);

            awardForm.ShowEx(wineName);
        }

        public List<Award> GetAwardsInfo(string wineName)
        {
            return _wineRepository.GetAwards(wineName, activeYear);
        }

        public void AddAward(string name, DateTime time, string location, string info, MedalTypes medal)
        {
            _wineRepository.AddAward(name, activeYear, time, location, medal);
        }

        public List<Wine> GetWineByType(WineTypes type)
        {
            return _wineRepository.GetByType(type);
        }

        public void SearchWines(ISearchWineFrm searchForm)
        {
            _wineRepository.addObserver(searchForm);
            searchForm.ShowEx();
        }

        public List<Wine> GetAllWine()
        {
            return _wineRepository.getAllWinesInYear(activeYear);
        }

        public void ChangeBarrels(IChangeBarrelsFrm changeBarrelsForm)
        {
            if (changeBarrelsForm.ShowEx() == 1)
            {
                string selectedWineName = changeBarrelsForm.GetWineName();
                int selectedBarrelID = changeBarrelsForm.GetBarrel();
                string changeType = changeBarrelsForm.GetChangeType();

                _wineRepository.ChangeContainer(selectedWineName, selectedBarrelID, changeType, activeYear);
            }
        }
    }
}