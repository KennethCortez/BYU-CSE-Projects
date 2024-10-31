using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    // Method to start the application
    public void Start()
    {
        Console.WriteLine("Welcome to the Goal Management System.");
        DisplayPlayerInfo();
    }

    // Method to display player information
    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"Current player score: {_score}");
    }

    // Method to list goal names
    public void ListGoalNames()
    {
        Console.WriteLine("List of goal names:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].ShortName}");
        }
    }

    // Method to list goal details
    public void ListGoalDetails()
    {
        Console.WriteLine("Goal details:");
        foreach (Goal goal in _goals)
        {
            Console.WriteLine(goal.GetDetailString());
        }
    }

    // Method to create a new goal and add it to the list
    public void CreateGoal(Goal newGoal)
    {
        _goals.Add(newGoal);
        Console.WriteLine($"Goal '{newGoal.ShortName}' created and added to the list.");
    }

    // Method to record an event and update the score
    public void RecordEvent(int goalIndex)
    {
        if (goalIndex < 0 || goalIndex >= _goals.Count)
        {
            Console.WriteLine("Invalid goal index.");
            return;
        }

        Goal goal = _goals[goalIndex];
        int pointsEarned = goal.RecordEvent();
        _score += pointsEarned;
        Console.WriteLine($"Event recorded for '{goal.ShortName}'. Points earned: {pointsEarned}. Total score: {_score}.");
    }

    // Method to save goals to a JSON file
    public void SaveGoals(string filename = "goals.json")
    {
        try
        {
            List<string> serializedGoals = new List<string>();
            foreach (var goal in _goals)
            {
                serializedGoals.Add(goal.Serialize());
            }

            string json = JsonSerializer.Serialize(serializedGoals);
            File.WriteAllText(filename, json);
            Console.WriteLine("Goals successfully saved to the file.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving goals: {ex.Message}");
        }
    }

    // Method to load goals from a JSON file
    public void LoadGoals(string filename = "goals.json")
    {
        try
        {
            if (!File.Exists(filename))
            {
                Console.WriteLine("The goals file does not exist.");
                return;
            }

            string json = File.ReadAllText(filename);
            List<string> serializedGoals = JsonSerializer.Deserialize<List<string>>(json);

            _goals.Clear();
            foreach (var goalJson in serializedGoals)
            {
                Goal goal = Goal.Deserialize(goalJson);
                _goals.Add(goal);
            }

            Console.WriteLine("Goals successfully loaded from the file.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading goals: {ex.Message}");
        }
    }
}