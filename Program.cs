using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
    class Program
    {
        static void Main(string[] args)
         {

            Console.WriteLine("\t\t\t\tVirtual Pet!!\\t\t\t\t");


            //introduction for user to understand the program
            Console.WriteLine("You have been given a lovely virtual pet!.\nLuckily (or unlucky),for you,\nyour pet will never die because I have yet to understand the code to kill it.\nHave fun!");

            //request for user input
            Console.WriteLine("What is your pet's name");

            //section for user input
            String userNameInput = (Console.ReadLine());

            //location to create the new variable to link PetAction class to the main (?)
            PetAction nutrition = new PetAction();
            nutrition.feedPet = 50;
            Console.WriteLine(userNameInput+"'s nutrition is " + nutrition.feedPet);

            PetAction hydration = new PetAction();
            hydration.waterForPet = 50;
            Console.WriteLine(userNameInput+"'s hydration is " + hydration.waterForPet);

            PetAction petToy = new PetAction();
            petToy.giftForPet = 50;
            Console.WriteLine(userNameInput+"'s level of happy is " + petToy.giftForPet);

            //directions for the user to know what number to press to continue the game. 
            Console.WriteLine("Please select 1, 2, or 3");

            //infinite loop that will never end the game
            for (;;)
       {           
            //request for the user to pick a number
            int userNumber = int.Parse(Console.ReadLine());

                //various outcomes based on the user choice


                switch (userNumber)
                {
                    //Each line connects with a method in the PetAction.cs class
                    case 1:
                        Console.WriteLine(userNameInput + "'s nutrition level is " + nutrition.GiveFood());
                        Console.WriteLine(userNameInput + "'s level of hydration is " + hydration.GiveWater());
                        Console.WriteLine(userNameInput + "'s level of happy is " + petToy.GiveGift());
                        break;

                    case 2:
                        Console.WriteLine(userNameInput + "'s level of hydration is " + nutrition.GiveFood());
                        Console.WriteLine(userNameInput + "'s level of hydration is " + hydration.GiveWater());
                        Console.WriteLine(userNameInput + "'s level of happy is " + petToy.GiveGift());
                        break;

                    case 3:
                        Console.WriteLine(userNameInput + "'s level of hydration is " + nutrition.GiveFood());
                        Console.WriteLine(userNameInput + "'s level of hydration is " + hydration.GiveWater());
                        Console.WriteLine(userNameInput + "'s level of happy is " + petToy.GiveGift());
                        break;


                    //if the user does not pick a case, this default message will print for the request for another number
                    default:
                        Console.WriteLine("Invalid selection. Please select 1, 2, or 3");
                        break;
                }
                    }               
          }
    }
}
