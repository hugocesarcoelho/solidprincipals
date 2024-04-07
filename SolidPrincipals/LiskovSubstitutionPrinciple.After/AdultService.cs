namespace LiskovSubstitutionPrinciple.Before
{
    public class AdultService : HumanService
    {
        public void PrepareDinner()
        {
            throw new NotImplementedException();
        }

        public void Work()
        {
            throw new NotImplementedException();
        }
    }
}
