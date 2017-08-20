using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace PlantFlashcards
{
    public class Questionaire
    {
        public Questionaire()
        {
            Score = new Score();
            Questions = new Questions();
        }

        public Score Score { get; set; }

        public Questions Questions { get; set; }

        public IOrderedEnumerable<Plant> RandomizePlantList(IList<Plant> plants)
        {
            var randomSeed = new Random();
            return plants.OrderBy(f => randomSeed.Next());
        }

        public void AskQuestion(Plant plant)
        {
            if (Questions.AskForFamilyName(plant)) Score.AddToScore();
            if (Questions.AskForGenus(plant)) Score.AddToScore();
            if (Questions.AskForSpecies(plant)) Score.AddToScore();
        }
    }

    public class Questions
    {
        public bool AskForFamilyName(Plant plant)
        {
            Console.WriteLine("What is " + plant.CommonName + "'s family name?");
            var answer = Console.ReadLine().ToLower().Trim();
            if (answer == plant.FamilyName.ToLower())
            {
                Console.WriteLine("Correct!");
                return true;
            }

            Console.WriteLine("Incorrect! It is " + plant.FamilyName + ".");
            return false;
        }

        public bool AskForGenus(Plant plant)
        {
            Console.WriteLine("What is " + plant.CommonName + "'s Genus?");
            var answer = Console.ReadLine();
            if (answer == plant.Genus)
            {
                Console.WriteLine("Correct!");
                return true;
            }

            Console.WriteLine("Incorrect! It is " + plant.Genus + ".");
            return false;
        }

        public bool AskForSpecies(Plant plant)
        {
            Console.WriteLine("What is " + plant.CommonName + "'s Species?");
            var answer = Console.ReadLine();
            if (answer == plant.Species)
            {
                Console.WriteLine("Correct!");
                return true;
            }

            Console.WriteLine("Incorrect! It is " + plant.Species + ".");
            return false;
        }
    }
}