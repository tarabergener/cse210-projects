using System;
using System.Text.Json;

class Program
{
    static void Main(string[] args)
    {
        int selection = 0;
        int goalPicked = 0;

        while (selection != 6)
        {
            if (selection == 1)
            {
                if (goalPicked == 1)
                {
                    SimpleGoal sGoal = new SimpleGoal();
                    sGoal.SetName();
                    sGoal.SetDescription();
                    sGoal.SetPoints();
                    Console.WriteLine(sGoal.GetStringRepresentation());
                    Console.WriteLine();
                    

                } else if (goalPicked == 2) {
                    ChecklistGoal cGoal = new ChecklistGoal();
                    cGoal.SetName();
                    cGoal.SetDescription();
                    cGoal.SetPoints();
                    cGoal.SetBonus();
                    cGoal.SetTarget();
                    Console.WriteLine(cGoal.GetStringRepresentation());
                    Console.WriteLine();

                } else if (goalPicked == 3)
                {
                    EternalGoal eGoal = new EternalGoal();
                    eGoal.SetName();
                    eGoal.SetDescription();
                    eGoal.SetPoints();
                    Console.WriteLine(eGoal.GetStringRepresentation());
                    Console.WriteLine();

                }

                Console.WriteLine("1. Simple Goal");
                Console.WriteLine("2. Eternal Goal");
                Console.WriteLine("3. Checklist Goal");
                Console.WriteLine();
                Console.WriteLine("What kind of goal would you like to set?");
                string selectGoal = Console.ReadLine();
                goalPicked = int.Parse(selectGoal);
                Console.Clear();

            } else if (selection == 3) {

                string fileName = "GoalsProject.json";
                string jsonString = JsonSerializer.Serialize(goalPicked);
                File.WriteAllText(fileName, jsonString);

                Console.WriteLine(File.ReadAllText(fileName));

            } else if (selection == 5) {
                SimpleGoal sRecord = new SimpleGoal();
                sRecord.RecordEvent();

                ChecklistGoal cRecord = new ChecklistGoal();
                cRecord.RecordEvent();

                EternalGoal eRecord = new EternalGoal();
                eRecord.RecordEvent();
            } else {
                break;
            }

            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.WriteLine();

            Console.WriteLine("Please select from the following options:");
            string userInput = Console.ReadLine();
            selection = int.Parse(userInput);
            Console.Clear();
        }
    }
}