namespace CellarJournal.Controllers
{
    public interface IAddNewWoodenBarrelFrm : IAddNewBarrelFrm
    {
        int GetMakeYear();

        string GetWoodType();
    }
}
