using System;
using QLiro.Interfaces;

namespace QLiro.Logic
{
    public class SimulationGenerator : ISimulationGenerator
    {
        private int NumberOfGames { get; set; }
        private int NumberOfTimesCarPicked { get; set; }


        public decimal GetPercentageCorrectChoice(int numberOfGames, bool doorSwitched)
        {
            NumberOfGames = numberOfGames;
            NumberOfTimesCarPicked = 0;

            SimulateRequiredNumberOfGames(numberOfGames, doorSwitched);

            return Decimal.Divide(NumberOfTimesCarPicked, NumberOfGames);
        }

        private void SimulateRequiredNumberOfGames(int numberOfGames, bool doorSwitched)
        {
            for (int i = 0; i < numberOfGames; i++)
            {
                var game = new Game();
                if (!doorSwitched)
                {
                    EvaluateResultDoorNotSwitched(game);
                }
                else
                {
                    EvaluateResultIfDoorSwitched(game);
                }
            }
        }

        private void EvaluateResultIfDoorSwitched(Game game)
        {
            //count how many times will a car be behind one of the remaining doors
            if (game.ItemBehindDoor2 == Game.ItemType.Car || game.ItemBehindDoor3 == Game.ItemType.Car)
            {
                //then if we switch, we get the car, since monty removes the goat, so add to the count
                NumberOfTimesCarPicked += 1;
            }
        }

        private void EvaluateResultDoorNotSwitched(Game game)
        {
            if (game.ItemBehindDoor1 == Game.ItemType.Car)
            {
                NumberOfTimesCarPicked += 1;
            }
        }



    }
}
