using System;
using System.Collections.Generic;

// Class for the Einstein Riddle
public class EinsteinRiddle
{
    // Properties to store the possible values for each category
    public string[] Colors { get; set; }
    public string[] Nationalities { get; set; }
    public string[] Drinks { get; set; }
    public string[] Cigarettes { get; set; }
    public string[] Pets { get; set; }

    // Constructor to initialize the properties 
    public EinsteinRiddle(string[] colors, string[] nationalities, string[] drinks, string[] cigarettes, string[] pets)
    {
        Colors = colors;
        Nationalities = nationalities;
        Drinks = drinks;
        Cigarettes = cigarettes;
        Pets = pets;
    }

    // Function to check the rules of the riddle
    public void CheckRules()
    {
        // List to store broken rules
        List<string> brokenRules = new List<string>();

        // Check each rule and add any broken ones to the list
        if (Nationalities[Array.IndexOf(Colors, "Red")] != "Brit")
            brokenRules.Add("The Brit lives in the Red house.");
        if (Pets[Array.IndexOf(Nationalities, "Swede")] != "Dogs")
            brokenRules.Add("The Swede keeps Dogs as pets.");
        if (Drinks[Array.IndexOf(Nationalities, "Dane")] != "Tea")
            brokenRules.Add("The Dane drinks Tea.");
        if (Array.IndexOf(Colors, "Green") != Array.IndexOf(Colors, "White") - 1)
            brokenRules.Add("The Green house is exactly to the left of the White house.");
        if (Drinks[Array.IndexOf(Colors, "Green")] != "Coffee")
            brokenRules.Add("The owner of the Green house drinks Coffee.");
        if (Pets[Array.IndexOf(Cigarettes, "Pall Mall")] != "Birds")
            brokenRules.Add("The person who smokes Pall Mall rears Birds.");
        if (Cigarettes[Array.IndexOf(Colors, "Yellow")] != "Dunhill")
            brokenRules.Add("The owner of the Yellow house smokes Dunhill.");
        if (Drinks[2] != "Milk")
            brokenRules.Add("The man living in the centre house drinks Milk.");
        if (Nationalities[0] != "Norwegian")
            brokenRules.Add("The Norwegian lives in the first house.");
        if (Math.Abs(Array.IndexOf(Cigarettes, "Blends") - Array.IndexOf(Pets, "Cats")) != 1)
            brokenRules.Add("The man who smokes Blends lives next to the one who keeps Cats.");

        // Check number of broken rules and print appropriate message
        if (brokenRules.Count == 0)
            Console.WriteLine("Success"); // All rules have been passed
        else if (brokenRules.Count == 10)
            Console.WriteLine("Failed"); // None of the rules have been passed
        else
        {
            Console.WriteLine("Fair"); // Some of the rules have been passed
            foreach (string rule in brokenRules)
                Console.WriteLine(rule); // Print out each broken rule
        }
    }
}

// Main program
class Program
{
    static void Main(string[] args)
    {
        // Define possible values for each category
        string[] colors = new string[] { "Yellow", "Blue", "Red", "Green", "White" };
        string[] nationalities = new string[] { "Norwegian", "Dane", "Brit", "German", "Swede" };
        string[] drinks = new string[] { "Water", "Tea", "Milk", "Coffee", "Beer" };
        string[] cigarettes = new string[] { "Dunhill", "Blends", "Pall Mall", "Prince", "Blue Master" };
        string[] pets = new string[] { "Cats", "Horse", "Birds", "Fish", "Dogs" };

        EinsteinRiddle riddle = new EinsteinRiddle(colors, nationalities, drinks, cigarettes, pets);
        riddle.CheckRules();
    }
}

