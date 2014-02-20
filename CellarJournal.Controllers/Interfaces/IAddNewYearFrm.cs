namespace CellarJournal.Controllers
{
    public interface IAddNewYearFrm : IBaseInterface
    {
        //int ShowEx();

        int GetYear();

        void Error(string p);
    }
}
