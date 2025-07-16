using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 1 - Run test cases and record any defects the test code finds in the comment above the test method.
// DO NOT MODIFY THE CODE IN THE TESTS in this file, just the comments above the tests. 
// Fix the code being tested to match requirements and make all tests pass. 

[TestClass]
public class TakingTurnsQueueTests
{
    [TestMethod]
    // Scenario: Create a queue with the following people and turns: Bob (2), Tim (5), Sue (3) and
    // run until the queue is empty
    // Expected Result: Bob, Tim, Sue, Bob, Tim, Sue, Tim, Sue, Tim, Tim
    // Defect(s) Found: 
    public void TestTakingTurnsQueue_FiniteRepetition()
    {   // Create the people with their respective turns
        var bob = new Person("Bob", 2);
        var tim = new Person("Tim", 5);
        var sue = new Person("Sue", 3);

        // Create the expected result array based on the input
        // Bob: 2 turns, Tim: 5 turns, Sue: 3 turns

        Person[] expectedResult = [bob, tim, sue, bob, tim, sue, tim, sue, tim, tim];
        // Initialize the TakingTurnsQueue with the people
        // and their turns

        var players = new TakingTurnsQueue();
        players.AddPerson(bob.Name, bob.Turns);
        players.AddPerson(tim.Name, tim.Turns);
        players.AddPerson(sue.Name, sue.Turns);
        // Run the queue until it is empty and verify the order of people
        // being returned matches the expected result

        int i = 0;
        while (players.Length > 0)
        {
            if (i >= expectedResult.Length)
            {
                Assert.Fail("Queue should have ran out of items by now.");
            }

            var person = players.GetNextPerson();
            Assert.AreEqual(expectedResult[i].Name, person.Name);
            i++;
        }
    }

    [TestMethod]
    // Scenario: Create a queue with the following people and turns: Bob (2), Tim (5), Sue (3)
    // After running 5 times, add George with 3 turns.  Run until the queue is empty.
    // Expected Result: Bob, Tim, Sue, Bob, Tim, Sue, Tim, George, Sue, Tim, George, Tim, George
    // Defect(s) Found: 
    public void TestTakingTurnsQueue_AddPlayerMidway()
    {
        // Create the people with their respective turns
        var bob = new Person("Bob", 2);
        var tim = new Person("Tim", 5);
        var sue = new Person("Sue", 3);
        var george = new Person("George", 3);
        // Create the expected result array based on the input
        // Bob: 2 turns, Tim: 5 turns, Sue: 3 turns, George: 3 turns

        Person[] expectedResult = [bob, tim, sue, bob, tim, sue, tim, george, sue, tim, george, tim, george];
        // Initialize the TakingTurnsQueue with the people
        // and their turns

        var players = new TakingTurnsQueue();
        players.AddPerson(bob.Name, bob.Turns);
        players.AddPerson(tim.Name, tim.Turns);
        players.AddPerson(sue.Name, sue.Turns);
        players.AddPerson(george.Name, george.Turns);
        // Run the queue for 5 turns and verify the order of people
        // being returned matches the expected result
        int i = 0;
        for (; i < 5; i++)
        {
            var person = players.GetNextPerson();
            Assert.AreEqual(expectedResult[i].Name, person.Name);
        }
   // After 5 turns, add George with 3 turns
        players.AddPerson("George", 3);
// Continue running the queue until it is empty and verify the order of people
        // being returned matches the expected result
        while (players.Length > 0)

        
        {
            if (i >= expectedResult.Length)
            {
                Assert.Fail("Queue should have ran out of items by now.");
            }

            var person = players.GetNextPerson();
            Assert.AreEqual(expectedResult[i].Name, person.Name);
            // Increment the index to check the next expected person

            i++;
        }
    }

    [TestMethod]
    // Scenario: Create a queue with the following people and turns: Bob (2), Tim (Forever), Sue (3)
    // Run 10 times.
    // Expected Result: Bob, Tim, Sue, Bob, Tim, Sue, Tim, Sue, Tim, Tim
    // Defect(s) Found: 
    public void TestTakingTurnsQueue_ForeverZero()
    // Create the people with their respective turns
    {
        var timTurns = 0;

        var bob = new Person("Bob", 2);
        var tim = new Person("Tim", timTurns);
        var sue = new Person("Sue", 3);
// Create the expected result array based on the input
        // Bob: 2 turns, Tim: Forever (0), Sue: 3 turns
        Person[] expectedResult = [bob, tim, sue, bob, tim, sue, tim, sue, tim, tim];
        // Initialize the TakingTurnsQueue with the people
        // and their turns

        var players = new TakingTurnsQueue();
        players.AddPerson(bob.Name, bob.Turns);
        players.AddPerson(tim.Name, tim.Turns);
        players.AddPerson(sue.Name, sue.Turns);
        // Run the queue for 10 turns and verify the order of people
        // being returned matches the expected result

        for (int i = 0; i < 10; i++)
        {
            var person = players.GetNextPerson();
            Assert.AreEqual(expectedResult[i].Name, person.Name);
        }

        // Verify that the people with infinite turns really do have infinite turns.
        var infinitePerson = players.GetNextPerson();
        Assert.AreEqual(timTurns, infinitePerson.Turns, "People with infinite turns should not have their turns parameter modified to a very big number. A very big number is not infinite.");
    }

    [TestMethod]
    // Scenario: Create a queue with the following people and turns: Tim (Forever), Sue (3)
    // Run 10 times.
    // Expected Result: Tim, Sue, Tim, Sue, Tim, Sue, Tim, Tim, Tim, Tim
    // Defect(s) Found: 
    public void TestTakingTurnsQueue_ForeverNegative()
    // Create the people with their respective turns
    // Tim has negative turns, which should be treated as infinite turns.
    {
        var timTurns = -3;
        var tim = new Person("Tim", timTurns);
        var sue = new Person("Sue", 3);
        // Create the expected result array based on the input
        // Tim: Forever (negative turns), Sue: 3 turns

        Person[] expectedResult = [tim, sue, tim, sue, tim, sue, tim, tim, tim, tim];
        // Initialize the TakingTurnsQueue with the people
        // and their turns

        var players = new TakingTurnsQueue();
        players.AddPerson(tim.Name, tim.Turns);
        players.AddPerson(sue.Name, sue.Turns);
        // Run the queue for 10 turns and verify the order of people
        // being returned matches the expected result

        for (int i = 0; i < 10; i++)
        {
            var person = players.GetNextPerson();
            Assert.AreEqual(expectedResult[i].Name, person.Name);
        }

        // Verify that the people with infinite turns really do have infinite turns.
        var infinitePerson = players.GetNextPerson();
        Assert.AreEqual(timTurns, infinitePerson.Turns, "People with infinite turns should not have their turns parameter modified to a very big number. A very big number is not infinite.");
    }

    [TestMethod]
    // Scenario: Try to get the next person from an empty queue
    // Expected Result: Exception should be thrown with appropriate error message.
    // Defect(s) Found: 
    public void TestTakingTurnsQueue_Empty()
    // Create an empty TakingTurnsQueue and try to get the next person
    // This should throw an InvalidOperationException with the message "No one in the queue."
    {
        var players = new TakingTurnsQueue();
        // Attempt to get the next person from an empty queue
        // This should throw an InvalidOperationException

        try
        {
            players.GetNextPerson();
            Assert.Fail("Exception should have been thrown.");
        }
        catch (InvalidOperationException e)
        {
            Assert.AreEqual("No one in the queue.", e.Message);
        }
        catch (AssertFailedException)
        {
            throw;
        }
        catch (Exception e)
        {
            Assert.Fail(
                 string.Format("Unexpected exception of type {0} caught: {1}",
                                e.GetType(), e.Message)
            );
        }
    }
}