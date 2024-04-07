using System;

class Program
{
    static void Main(string[] args)
    {
        // To Exceed the core requirements, I've added an extra qualification of the points which are the Levels, the user can level up every time they reach a certain number of points. This sistem also will increase as the user levels up. 
        GoalManager goalManager = new GoalManager();
        goalManager.Start();
    }
}