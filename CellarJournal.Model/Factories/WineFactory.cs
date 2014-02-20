using System;
using CellarJournal.Model.Repositories;

namespace CellarJournal.Model.Factories
{
    public class WineFactory
    {
        public static Wine createWine(string name, WineTypes type, int year, Container container)
        {
            Wine newWine;
            if (ContainerRepository.getInstance().containerExists(container.ID))
            {
                newWine = new Wine(name, type, year);
                newWine.addContainer(container);
                container.ContainingWine = newWine;
            }
            else throw new Exception();

            return newWine;
        }
    }
}
