using System.Configuration.Assemblies;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Create a queue with these strings with the priority in parentheses: Fire(4), Work(3), Tim(2), and Pizza(2).
    // Expected Result: Pizza, Tim, Work, Fire.
    // Defect(s) Found: I have no idea if I wrote this correctly, but the order of the enqeues
    // are not in the right order. It says that the first item is different then expected.
    public void TestPriorityQueue_1()
    {
        List<string> Test_List = new();
        List<string> Expected_List = new List<string> {"Pizza", "Tim", "Work", "Fire"};

        var priorityQueue = new PriorityQueue();

        priorityQueue.Enqueue("Pizza", 2);
        priorityQueue.Enqueue("Tim", 2);
        priorityQueue.Enqueue("Work", 3);
        priorityQueue.Enqueue("Fire", 4);


        int Counter = 4;

        while (Counter != 0)
        {
            string Number = priorityQueue.Dequeue();
            Test_List.Add(Number);
            Counter -= 1;
        }

        CollectionAssert.AreEqual(Test_List, Expected_List);
    }

    [TestMethod]
    // Scenario: Create a queue with these strings with the priority in parentheses: First(10), Second(2),
    // Third(1), Fourth(7), Fifth(9), Sixth(8), Seventh(6), Eighth(5), Ninth(4), Tenth(3).
    // Expected Result: Third, Second, Tenth, Ninth, Eighth, Seventh, Fourth, Sixth, Fifth, First.
    // Defect(s) Found: I have no idea if I wrote this correctly, but the order of the enqeues 
    // are not in the right order.
    public void TestPriorityQueue_2()
    {
        List<string> Test_List = new();
        List<string> Expected_List = new List<string> {"Third", "Second", "Tenth", "Ninth", "Eighth", "Seventh", "Fourth", "Sixth", "Fifth", "First"};

        var priorityQueue = new PriorityQueue();

        priorityQueue.Enqueue("First", 10);
        priorityQueue.Enqueue("Second", 2);
        priorityQueue.Enqueue("Third", 1);
        priorityQueue.Enqueue("Fourth", 7);
        priorityQueue.Enqueue("Fifth", 9);
        priorityQueue.Enqueue("Sixth", 8);
        priorityQueue.Enqueue("Seventh", 6);
        priorityQueue.Enqueue("Eighth", 5);
        priorityQueue.Enqueue("Ninth", 4);
        priorityQueue.Enqueue("Tenth", 3);


        int Counter = 10;

        while (Counter != 0)
        {
            string Numberth = priorityQueue.Dequeue();
            Test_List.Add(Numberth);
            Counter -= 1;
        }

        CollectionAssert.AreEqual(Test_List, Expected_List);
    }

    // Add more test cases as needed below.
}