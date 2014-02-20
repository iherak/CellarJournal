using System.Collections.Generic;
using System.Linq;
using CellarJournal.Utility;

namespace CellarJournal.Model.Repositories
{
    public class ContainerRepository : Subject
    {
        private static ContainerRepository _containerRepository= null;

        private List<Container> _containers = new List<Container>();

        public static ContainerRepository getInstance()
        {
            if(_containerRepository == null)
                _containerRepository = new ContainerRepository();
            return _containerRepository;
        }

        public void addContainer(Container inContainer)
        {
            if (_containers.Contains(inContainer))
                throw new ContainerAlreadyExists();
            _containers.Add(inContainer);

            notifyObservers();
        }

        public bool containerExists (int ID)
        {
            return _containers.Any(cont => cont.ID == ID);
        }

        public int Count(int year)
        {
            return _containers.Count(container => container.getActiveYear() == year);
        }

        public List<Container> getActiveContainers(int year)
        {
            return _containers.Where(container => container.getActiveYear() == year).ToList();
        }

        public List<Container> GetEmptyContainers(int year)
        {
            return _containers.Where(container => container.ContainingWine == null).ToList();
        }

        public Container getContainer(int ID)
        {
            return _containers.First(container => container.ID == ID);
        }

        public void ChangeContainingWine(Barrel selectedBarrel, Wine selectedWine)
        {
            Container old=null;
            foreach (Container cont in _containers)
            {
                if (cont.ContainingWine == selectedWine)
                {
                    old = cont;
                    break;
                }
            }
            if (old != null)
            {
                old.ContainingWine = null;
                selectedBarrel.ContainingWine = selectedWine;
                notifyObservers();
            }
            else
            {
                throw new ContainerDoesntExist();
            }

        }
    }
}
