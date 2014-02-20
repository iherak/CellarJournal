using System;
using CellarJournal.Model;
using CellarJournal.Model.Factories;
using CellarJournal.Model.Repositories;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CellarJournal.Test
{
    /// <summary>
    /// Summary description for UnitTest1
    /// </summary>
    [TestClass]
    public class BarrelRepositoryTest
    {
        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        //Use TestInitialize to run code before running each test 
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //    new PrivateType(typeof(WineRepository)).SetStaticField("_wineRepository", null);
        //}

        [TestInitialize]
        public void InitTest()
        {
            new PrivateType(typeof(WineRepository)).SetStaticField("_wineRepository", null);
            new PrivateType(typeof(ContainerRepository)).SetStaticField("_containerRepository", null);
            new PrivateType(typeof(IDs)).SetStaticField("activeIDs", null);

        }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void Test_AddingOneBarrel()
        {
            ContainerRepository barrRep = ContainerRepository.getInstance();

            Container newBarrel = BarrelFactory.CreateInoxBarrel(620, 2012);

            barrRep.addContainer(newBarrel);

            Assert.AreEqual(true, barrRep.containerExists(1));
        }

        [TestMethod]
        [ExpectedException(typeof(VolumeError))]
        public void Test_AddingOneBarrelFail()
        {
            ContainerRepository barrRep = ContainerRepository.getInstance();

            Container newBarrel = BarrelFactory.CreateInoxBarrel(0, 2012);

            barrRep.addContainer(newBarrel);

            Assert.AreEqual(true, barrRep.containerExists(1));
        }

        [TestMethod]
        public void Test_AddingMultipleBarrels()
        {
            ContainerRepository barrRep = ContainerRepository.getInstance();

            Container barrel1 = BarrelFactory.CreateInoxBarrel(620, 2012);
            Container barrel2 = BarrelFactory.CreateWoodenBarrel(220, 2012, 1982, "oak");
            Container barrel3 = BarrelFactory.CreateInoxBarrel(620, 2013);

            barrRep.addContainer(barrel1);
            barrRep.addContainer(barrel2);
            barrRep.addContainer(barrel3);

            Wine wine1 = new Wine("dobar", WineTypes.ŠKRLET, 2012);
            Wine wine2 = new Wine("dobar", WineTypes.ŠKRLET, 2011 );

            barrel1.ContainingWine = wine1;
            barrel2.ContainingWine = wine2;

            Assert.AreEqual(2, barrRep.Count(2012));
            Assert.AreEqual(true, barrRep.containerExists(1));
            Assert.AreEqual(0, barrRep.Count(2011));
            Assert.AreEqual(1, barrRep.Count(2013));
            Assert.AreEqual(2, barrRep.getActiveContainers(2012).Count);
        }

        [TestMethod]
        public void Test_DifferentBarrels()
        {
            ContainerRepository barrRep = ContainerRepository.getInstance();

            Container barrel1 = BarrelFactory.CreateInoxBarrel(620, 2012);
            Container barrel3 = BarrelFactory.CreateInoxBarrel(220, 2012);

            barrRep.addContainer(barrel1);
            barrRep.addContainer(barrel3);

            Assert.AreEqual(2, barrRep.getActiveContainers(2012).Count);
        }

        [TestMethod]
        public void Test_CompleteTest()
        {
            ContainerRepository barrRep = ContainerRepository.getInstance();

            Container barrel1 = BarrelFactory.CreateInoxBarrel(620, 2012);
            Container barrel2 = BarrelFactory.CreateInoxBarrel(620, 2012);
            Container barrel3 = BarrelFactory.CreateInoxBarrel(480, 2012);
            Container barrel4 = BarrelFactory.CreateInoxBarrel(120, 2012);

            barrRep.addContainer(barrel1);
            barrRep.addContainer(barrel2);
            barrRep.addContainer(barrel3);
            barrRep.addContainer(barrel4);

            Assert.AreEqual(4, barrRep.getActiveContainers(2012).Count);
        }

        [TestMethod]
        [ExpectedException(typeof (ContainerAlreadyExists))]
        public void Test_AddingSameBarrel()
        {
            ContainerRepository barrRep = ContainerRepository.getInstance();
            Container barrel1 = BarrelFactory.CreateInoxBarrel(620, 2012);

            barrRep.addContainer(barrel1);
            barrRep.addContainer(barrel1);
        }
    }
}
