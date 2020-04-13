    using System;

    namespace Deliverable1
    {
        class Program
        {
            static void Main(string[] args)
            { //Asks intial question
                Console.WriteLine("What kind of trip would you like to go on musical, tropical, " +
                   "or adventurous?");

                //Stores vacationType from user feedback
                string vacationType = Console.ReadLine();

               //Asks second question
                Console.WriteLine("How many are in your group?");

                //Stores answer from user feedback
                int groupSize = int.Parse(Console.ReadLine());

            string destination = "";
            string travelSuggestion = "";

            if (groupSize <= 2)
            {
                travelSuggestion = "First class flight";
            }
            else if (groupSize >= 3 || groupSize <= 5)
            {
                travelSuggestion = "Helicopter";
            }
            else if (groupSize >= 6)
            {
                travelSuggestion = "Charter flight";
            }       


            if (vacationType == "musical")
            {
                destination = "New Orleans";
            }
      else  if (vacationType == "tropical")
            {
                destination = "Beach Vacation in Mexico";
            }
          if (vacationType == "adventurous")
            { 
                                destination = "Whitewater Rafting the Grand Canyon";
                            }



            string result = "Since you're a group of " + groupSize + " going on a " + vacationType + " vacation you should take a " + travelSuggestion + " to a " + destination + ".";

            Console.WriteLine(result);

                

                }
            }
    }
