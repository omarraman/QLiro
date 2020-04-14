namespace QLiro.Interfaces
{
    public interface ISimulationGenerator
    {
        decimal GetPercentageCorrectChoice(int numberOfGames, bool doorSwitched);   
    }
}