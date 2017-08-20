using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace PlantFlashcards
{
    class Program
    {
        static void Main(string[] args)
        {
            var plantList = new List<Plant>();

            var poisonIvy = new Plant
            {
                CommonName = "poison ivy",
                FamilyName = "anacardiaceae",
                Genus = "rhus",
                Species = "radicans"
            };
            plantList.Add(poisonIvy);

            var commonPawpaw = new Plant
            {
                CommonName = "common pawpaw",
                FamilyName = "annonaceae",
                Genus = "asimina",
                Species = "triloba"
            };
            plantList.Add(commonPawpaw);

            var inkberry = new Plant
            {
                CommonName = "inkberry",
                FamilyName = "aquifoliaceae",
                Genus = "ilex",
                Species = "gabra"
            };
            plantList.Add(inkberry);

            var winterberry = new Plant
            {
                CommonName = "winterberry",
                FamilyName = "aquifoliaceae",
                Genus = "ilex ",
                Species = "verticillata"
            };
            plantList.Add(winterberry);

            var devilsWalkingStick = new Plant
            {
                CommonName = "devil's walking stick",
                FamilyName = "araliaceae",
                Genus = "aralia",
                Species = "spinosa"
            };
            plantList.Add(devilsWalkingStick);

            var goldenrod = new Plant
            {
                CommonName = "goldenrod",
                FamilyName = "asteraceae",
                Genus = "solidago",
                Species = "spp."
            };
            plantList.Add(goldenrod);

            var riverBirch = new Plant
            {
                CommonName = "river birch",
                FamilyName = "betulaceae",
                Genus = "betula",
                Species = "nigra"
            };
            plantList.Add(riverBirch);

            Plant japaneseBoxwood = new Plant
            {
                CommonName = "japanese boxwood",
                FamilyName = "buxaceae",
                Genus = "buxus",
                Species = "microphylla var. japonica"
            };
            plantList.Add(japaneseBoxwood);

            Plant floweringDogwood = new Plant
            {
                CommonName = "flowering dogwood",
                FamilyName = "cornaceae",
                Genus = "cornus",
                Species = "florida"
            };
            plantList.Add(floweringDogwood);

            var easternRedCedar = new Plant
            {
                CommonName = "eastern red cedar",
                FamilyName = "cupressaceae",
                Genus = "juniperus",
                Species = "virginiana"
            };
            plantList.Add(easternRedCedar);

            var commonPersimmon = new Plant
            {
                CommonName = "common persimmon",
                FamilyName = "ebenaceae",
                Genus = "diospyros",
                Species = "virginiana"
            };
            plantList.Add(commonPersimmon);

            var easternRedbud = new Plant
            {
                CommonName = "eastern red bud",
                FamilyName = "fabaceae",
                Genus = "cercis",
                Species = "canadensis"
            };
            plantList.Add(easternRedbud);

            var americanBeech = new Plant
            {
                CommonName = "american beech",
                FamilyName = "fagaceae",
                Genus = "fagus",
                Species = "grandifolia"
            };
            plantList.Add(americanBeech);

            var mountainWitchAlder = new Plant
            {
                CommonName = "mountain witch alder",
                FamilyName = "hamamelidaceae",
                Genus = "fothergilla",
                Species = "major and gardenii"
            };
            plantList.Add(mountainWitchAlder);

            var oakleafHydrangia = new Plant()
            {
                CommonName = "oakleaf hydrangea",
                FamilyName = "hydrangeaceae",
                Genus = "hydrangea",
                Species = "quercifolia"
            };
            plantList.Add(oakleafHydrangia);

            var pignutHickory = new Plant()
            {
                CommonName = "pignut hickory",
                FamilyName = "juglandaceae",
                Genus = "carya",
                Species = "glabra"
            };
            plantList.Add(pignutHickory);

            var sassafras = new Plant()
            {
                CommonName = "sassafras",
                FamilyName = "lauraceae",
                Genus = "sassafras",
                Species = "albidum"
            };
            plantList.Add(sassafras);

            var tulipPoplar = new Plant()
            {
                CommonName = "tulip poplar",
                FamilyName = "magnoliaceae",
                Genus = "liriodendron",
                Species = "tulipifera"
            };
            plantList.Add(tulipPoplar);

            var southernMagnolia = new Plant()
            {
                CommonName = "southern magnolia",
                FamilyName = "magnoliaceae",
                Genus = "magnolia",
                Species = "grandiflora"
            };
            plantList.Add(southernMagnolia);

            var sweetbayMagnolia = new Plant()
            {
                CommonName = "sweetbay magnolia",
                FamilyName = "magnoliaceae",
                Genus = "magnolia",
                Species = "virginiana"
            };
            plantList.Add(sweetbayMagnolia);

            var southernWaxMyrtle = new Plant()
            {
                CommonName = "southern wax myrtle",
                FamilyName = "myricaceae",
                Genus = "myrica",
                Species = "cerifera"
            };
            plantList.Add(southernWaxMyrtle);

            var blackGum = new Plant()
            {
                CommonName = "black gum",
                FamilyName = "nyssaceae",
                Genus = "nyssa",
                Species = "sylvatica"
            };
            plantList.Add(blackGum);

            var greenAsh = new Plant()
            {
                CommonName = "green ash",
                FamilyName = "oleaceae",
                Genus = "fraxinus",
                Species = "pennsylvanica"
            };
            plantList.Add(greenAsh);

            var longleafPine = new Plant()
            {
                CommonName = "longleaf pine",
                FamilyName = "pinaceae",
                Genus = "pinus",
                Species = "palustris"
            };
            plantList.Add(longleafPine);

            var loblollyPine = new Plant()
            {
                CommonName = "loblolly pine",
                FamilyName = "pinaceae",
                Genus = "pinus",
                Species = "taeda"
            };
            plantList.Add(loblollyPine);

            var serviceberry = new Plant()
            {
                CommonName = "serviceberry",
                FamilyName = "rosaceae",
                Genus = "amelanchier",
                Species = "arborea"
            };
            plantList.Add(serviceberry);

            var blackCherry = new Plant()
            {
                CommonName = "black cherry",
                FamilyName = "rosaceae",
                Genus = "prunus",
                Species = "serotina"
            };
            plantList.Add(blackCherry);

            var waterOak = new Plant()
            {
                CommonName = "water oak",
                FamilyName = "fagaceae",
                Genus = "quercus",
                Species = "nigra"
            };
            plantList.Add(waterOak);

            var rosemary = new Plant()
            {
                CommonName = "rosemarry",
                FamilyName = "laminaceae",
                Genus = "rosmarinus",
                Species = "officinalis"
            };
            plantList.Add(rosemary);

            var candyTuft = new Plant()
            {
                CommonName = "candytuft",
                FamilyName = "brassicaceae",
                Genus = "iberis",
                Species = "sempervirens"
            };
            plantList.Add(candyTuft);

            var purpleConeflower = new Plant()
            {
                CommonName = "purple coneflower",
                FamilyName = "aster",
                Genus = "asteraceae",
                Species = "echinacea purpurea"
            };
            plantList.Add(purpleConeflower);

            var americanSweetGum = new Plant()
            {
                CommonName = "american sweet gum",
                FamilyName = "hamamelidaceae",
                Genus = "liquidambar",
                Species = "styraciflua"
            };
            plantList.Add(americanSweetGum);

            var trumpetCreeper = new Plant()
            {
                CommonName = "trumpet creeper",
                FamilyName = "bignoniaceae",
                Genus = "campsis",
                Species = "radicans"
            };
            plantList.Add(trumpetCreeper);

            var crepeMyrtle = new Plant()
            {
                CommonName = "crepe myrtle",
                FamilyName = "lythraceae",
                Genus = "lagerstroemia",
                Species = "indica"
            };
            plantList.Add(crepeMyrtle);

            var virginiaCreeper = new Plant()
            {
                CommonName = "virginia creeper",
                FamilyName = "vitaceae",
                Genus = "parthenocissus",
                Species = "quinquefolia"
            };
            plantList.Add(virginiaCreeper);

            var pinOak = new Plant()
            {
                CommonName = "pin oak",
                FamilyName = "fagaceae",
                Genus = "quercus",
                Species = "palustris"
            };
            plantList.Add(pinOak);

            var whiteOak = new Plant()
            {
                CommonName = "white oak",
                FamilyName = "fagaceae",
                Genus = "quercus",
                Species = "alba"
            };
            plantList.Add(whiteOak);

            var sourWood = new Plant()
            {
                CommonName = "sour wood",
                FamilyName = "aracaceae",
                Genus = "oxydendron",
                Species = "arboreum"
            };
            plantList.Add(sourWood);

            var questionaire = new Questionaire();
            var randomList = questionaire.RandomizePlantList(plantList);

            foreach (var plant in randomList)
            {
                questionaire.AskQuestion(plant);
            }

            questionaire.Score.GetTotalScore();
        }
    }
}

/*
              Console.WriteLine("No. " + plantNumber);    //from foreach loop fixing
                plantQuestions.AskForFamilyName();
                if (plantQuestions.AskForFamilyName())
                {
                    score.AddToScore();
                }
                plantQuestions.AskForGenus();
                if (plantQuestions.AskForGenus())
                {
                    score.AddToScore();
                }
                plantQuestions.AskForSpecies();
                if (plantQuestions.AskForSpecies())
                {
                    score.AddToScore();
                }
                plantNumber++; 

            Console.WriteLine("You got " + score.GetTotalScore() + " out of " + score.GetPossibleScore() + " correct.");
           score.SetPossibleScore(plantList.Count() * 3);
            score.GetTotalScore();
*/
