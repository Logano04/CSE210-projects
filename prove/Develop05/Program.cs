using System;

class Program
{
    static Goal Goal = new Goal();
    static Goals Goals = new Goals();
    static bool MenuSelect(int selection)
    {
        switch (selection)
        {
            case 1:
                Console.WriteLine("Which type of goal would you like to create?:");
                Console.WriteLine("1. Simple Goal");
                Console.WriteLine("2. Eternal Goal");
                Console.WriteLine("3. Checklist Goal");
                int goalTypeSelect = int.Parse(Console.ReadLine());
                if (goalTypeSelect == 1)
                {
                    SimpleGoal SimpleGoal = new SimpleGoal();
                    SimpleGoal.createGoal();
                    Goals.addGoal(SimpleGoal);

                }
                else if (goalTypeSelect == 2)
                {
                    EternalGoal EternalGoal = new EternalGoal();
                    EternalGoal.createGoal();
                    Goals.addGoal(EternalGoal);
                }
                else if (goalTypeSelect == 3)
                {
                    ChecklistGoal ChecklistGoal = new ChecklistGoal();
                    ChecklistGoal.createGoal();
                    Goals.addGoal(ChecklistGoal);
                }
                else
                {
                    Console.WriteLine("bruh");
                }
                break;
            case 2:
                Goals.displayGoals();
                break;
            case 3:
                Goals.WriteFile();
                break;
            case 4:
                Goals.ReadFile();
                break;
            case 5:
                Console.WriteLine("Record event for which goal?");
                Goals.listGoals();
                break;
            case 6:
                return false;
        }
        Goals.printPoints();
        return true;
    }
    static void Main(string[] args)
    {
        bool keepGoing = true;
        while (keepGoing)
        {
            Console.WriteLine("Menu Options");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            int userInput = int.Parse(Console.ReadLine());
            keepGoing = MenuSelect(userInput);
        }
    }
}