using System;

class Program
{
    static void Main(string[] args)
    {
        //Added a method in GoalManager class to update the level based on the score and every 100 points, the level increases by 1.
        new GoalManager().Start();
    }
}