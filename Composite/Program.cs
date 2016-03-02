using System;
using System.Collections.Generic;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {   
            var maiya = new Meerkat("Maiya");
            var vassily = new Meerkat("Vassily");
            var yakov = new Meerkat("Yakov");
            var bogdan = new Meerkat("Bogdan");

            var sergei = new Meerkat("Sergei");
            var mostBeautiousSisterofSergei = new Meerkat("Beautious Sister Of Sergei");

            var brotherOfSergeiAlwaysWithTheScratching = new Meerkat("Scratching Brother of Sergei");
            var wifeOfScratchingBrother = new Meerkat("Wife of Scratching Brother");
            var scratchyBaby = new Meerkat("Baby of Scratching Brother");
            var familyMeThinksHasFleas = new Mob { Name = "Sergei Scratchy Extended Family", Members = { brotherOfSergeiAlwaysWithTheScratching, wifeOfScratchingBrother, scratchyBaby } };
            
            var sergeiFamily = new Mob {Name = "family of Sergei", Members = {sergei, mostBeautiousSisterofSergei, familyMeThinksHasFleas}}; //add familyMeThinksHasFleas into the extended sergeiFamily Mob
            
            var mothermabobOfBogdan = new Meerkat("Mothermabob of Bogdan");
            var fathermabobOfBogdan = new Meerkat("Fathermabob of Bogdan");
            var bogdanFamily = new Mob {Name = "family of Bogdan", Members = {bogdan, mothermabobOfBogdan, fathermabobOfBogdan}};


            var meerkovaVillagers = new Mob {Name = "Villagers", Members = {maiya, vassily, yakov, sergeiFamily, bogdanFamily}};
            
            meerkovaVillagers.InviteMyMostStupendousParty();

            Console.ReadLine();
        }
    }
}
