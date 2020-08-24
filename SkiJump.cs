using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace SkiJump
{
    class Program
    {
        static void Main(string[] args)
        {
            var listContestants = new List<IContestant>();

            Console.WriteLine("Welcome to the Ski Jump Competition! Let's begin.");

            while (true)
            {
                Console.Write("Participant name: ");

                var inputName = Console.ReadLine()?.Trim().ToUpper();

                if (inputName != "")
                {
                    var contestant = Factory.CreateContestant();
                    contestant.Name = inputName;
                    listContestants.Add(contestant);

                    continue;
                }
                else
                {
                    {
                        if (listContestants.Count == 0)
                        {
                            Console.Write("Please enter at least one contestant: ");
                        }
                        else
                        {
                            break;
                        }
                    }
                }
            }

            Console.WriteLine("The tournament begins!");
            var roundCount = Factory.CreateRoundCount();
            var roundOrder = Factory.CreateRoundOrder();
            var roundScores = Factory.CreateRoundScores();

            while (true)
            {
                Console.Write("Enter 'jump' to begin round, otherwise you quit: ");
                if (Console.ReadLine() == "jump")
                {
                    var round = Factory.CreateRound(listContestants);
                    roundCount.Counter();
                    roundOrder.Order(round);
                    roundScores.Scores(round);

                    continue;
                }
                
                else
                {
                    break;
                }
            }
        }
    }
}
