using System;
using System.Diagnostics;
using CellarJournal.Model;
using CellarJournal.Model.Factories;
using CellarJournal.Model.Repositories;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CellarJournal.Test
{
    [TestClass]
    public class WineRepositoryTest
    {
        [TestInitialize]
        public void InitTest()
        {
            new PrivateType(typeof(WineRepository)).SetStaticField("_wineRepository", null);
            new PrivateType(typeof(ContainerRepository)).SetStaticField("_containerRepository", null);
            new PrivateType(typeof(IDs)).SetStaticField("activeIDs", null);

        }

        [TestMethod]
        public void Test_AddOneWine()
        {
            WineRepository wineRep = WineRepository.getInstance();
            ContainerRepository barrRep = ContainerRepository.getInstance();
            Container barrel1 = BarrelFactory.CreateInoxBarrel(620, 2012);
            barrRep.addContainer(barrel1);
            Wine wine1 = WineFactory.createWine("Lokacija 1", WineTypes.ŠKRLET, 2012, barrel1);
            wineRep.addWine(wine1);
            Assert.AreEqual(1,wineRep.wineCount());
        }

        [TestMethod]
        [ExpectedException(typeof (WineDoesntExist))]
        public void Test_WineDoesntExist()
        {
            WineRepository wineRep = WineRepository.getInstance();
            ContainerRepository barrRep = ContainerRepository.getInstance();
            Container barrel1 = BarrelFactory.CreateInoxBarrel(620, 2012);
            barrRep.addContainer(barrel1);
            Wine wine1 = WineFactory.createWine("Lokacija 1", WineTypes.ŠKRLET, 2012, barrel1);

            wineRep.getWine("lokacija 1", 2011);
        }

        [TestMethod]
        public void Test_MultipleWinesWithDetails()
        {
            WineRepository wineRep = WineRepository.getInstance();
            ContainerRepository barrRep = ContainerRepository.getInstance();
            Container barrel1 = BarrelFactory.CreateInoxBarrel(620, 2012);
            Container barrel2 = BarrelFactory.CreateInoxBarrel(620, 2012);
            Container barrel3 = BarrelFactory.CreateInoxBarrel(480, 2012);
            Container barrel4 = BarrelFactory.CreateInoxBarrel(120, 2012);
            Container barrel5 = BarrelFactory.CreateInoxBarrel(130, 2012);
            Container barrel6 = BarrelFactory.CreateInoxBarrel(480, 2012);

            barrRep.addContainer(barrel1);
            barrRep.addContainer(barrel2);
            barrRep.addContainer(barrel3);
            barrRep.addContainer(barrel4);
            barrRep.addContainer(barrel5);
            barrRep.addContainer(barrel6);

            Wine wine1 = WineFactory.createWine("Lokacija 1", WineTypes.ŠKRLET, 2012, barrel1);
            Wine wine2 = WineFactory.createWine("Lokacija 2", WineTypes.ŠKRLET, 2012, barrel2);
            Wine wine3 = WineFactory.createWine("Lokacija 3", WineTypes.ŠKRLET, 2012, barrel3);
            Wine wine4 = WineFactory.createWine("Lokacija 1 - crno", WineTypes.FRANKOVKA, 2012, barrel4);
            Wine wine5 = WineFactory.createWine("Neko ime", WineTypes.GRASEVINA, 2012, barrel5);
            Wine wine6 = WineFactory.createWine("Jos jedno ime", WineTypes.GRASEVINA, 2012, barrel6);

            wineRep.addWine(wine1);
            wineRep.addWine(wine2);
            wineRep.addWine(wine3);
            wineRep.addWine(wine4);
            wineRep.addWine(wine5);
            wineRep.addWine(wine6);

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

            wine1.addPrize(new DateTime(2012, 11, 01), "Kutina", MedalTypes.GOLD);
            wine1.addPrize(new DateTime(2013, 01, 05), "Popovača", MedalTypes.GOLD);
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

            Assert.AreEqual(6, wineRep.wineCount());
        }

        [TestMethod]
        public void Test_AddContainerToWine()
        {
            WineRepository wineRep = WineRepository.getInstance();
            ContainerRepository barrRep = ContainerRepository.getInstance();

            Container barrel1 = BarrelFactory.CreateInoxBarrel(620, 2012);
            barrRep.addContainer(barrel1);

            Wine wine1 = WineFactory.createWine("Lokacija 1", WineTypes.ŠKRLET, 2012, barrel1);
            wineRep.addWine(wine1);

            Container barrel2 = BarrelFactory.CreateInoxBarrel(620, 2012);
            barrRep.addContainer(barrel2);
            wineRep.AddContainerToWine(wine1.Name, 2012, barrel2);
            
            Assert.AreEqual(barrel2, wine1.getLastContainer());
        }
    }
}
