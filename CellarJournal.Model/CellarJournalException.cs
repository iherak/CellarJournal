using System;

namespace CellarJournal.Model
{
    [Serializable]
    public class CellarJournalException : Exception
    {
    }

    [Serializable]
    public class WineDoesntExist : CellarJournalException
    {
    }

    [Serializable]
    class WineWithoutContainerException : CellarJournalException
    {
    }

    [Serializable]
    public class ContainerDoesntExist : CellarJournalException
    {
    }

    [Serializable]
    public class WrongWineType : CellarJournalException
    {
    }

    [Serializable]
    public class ContainerAlreadyExists : CellarJournalException
    {
    }

    [Serializable]
    public class WineAlreadyExists : CellarJournalException
    {
    }

    [Serializable]
    public class VolumeError : CellarJournalException
    {
    }

    [Serializable]
    public class NoPrizeException : CellarJournalException
    {
    }
    
    [Serializable]
    public class YearError : CellarJournalException
    {
    }

    [Serializable]
    public class CreateBarrelException : CellarJournalException
    {
    }

    [Serializable]
    public class NoWineTypeSelectedException : CellarJournalException
    {
    }
}
