using NUnit.Framework;
using BoredAPI_Client;
using BoredAPI_Client.Models;
using System.Diagnostics;

namespace UnitTests
{
    public class Tests
    {
        [Test]
        public void TestRandom()
        {
            ActivityProvider AP = new ActivityProvider();

            var res = AP.GetTasks(test: true);
            Assert.That(res != null);
            Assert.Pass();
        }
        [Test]
        public void TestType()
        {
            ActivityProvider AP = new ActivityProvider();
            ActivityModel act = new ActivityModel();
            act.Type = "Activity";

            var res = AP.GetTasks(act, test: true);
            Assert.That(res.Result[0].Type, Is.EqualTo("Activity"));
            Assert.Pass();
        }
        [Test]
        public void TestParticipants()
        {
            ActivityProvider AP = new ActivityProvider();
            ActivityModel act = new ActivityModel();
            act.Participants = 1;

            var res = AP.GetTasks(act, test: true);
            Assert.That(res.Result[0].Participants, Is.EqualTo(1));
            Assert.Pass();
        }
        [Test]
        public void TestKey()
        {
            ActivityProvider AP = new ActivityProvider();

            var res = AP.GetTaskByKey(2, test: true);
            Assert.That(res.Result.Key, Is.EqualTo(2));
            Assert.Pass();
        }
        [Test]
        public void TestPrice()
        {
            ActivityProvider AP = new ActivityProvider();
            ActivityModel act = new ActivityModel();
            act.Price = 0.1m;

            var res = AP.GetTasks(act, test: true);
            Assert.That(res.Result[0].Price, Is.EqualTo(0.1m));
            Assert.Pass();
        }
        [Test]
        public void TestAccess()
        {
            ActivityProvider AP = new ActivityProvider();
            ActivityModel act = new ActivityModel();
            act.Accessibility = 0.2m;

            var res = AP.GetTasks(act, test: true);
            Assert.That(res.Result[0].Accessibility, Is.EqualTo(0.2m));
            Debug.WriteLine(res.Result[0].GetActivityDetails());
            Assert.Pass();
        }
        [Test]
        public void TestAllParams()
        {
            ActivityProvider AP = new ActivityProvider();
            ActivityModel act = new ActivityModel();
            act.Type = "Chore";
            act.Participants = 1;
            act.AccessibilityMin = 0m;
            act.AccessibilityMax = 0.5m;
            act.PriceMin = 0.2m;
            act.PriceMax = 0.6m;

            var res = AP.GetTasks(act, test: true);
            Assert.That(res.Result[0].Type, Is.EqualTo("Chore"));
            Assert.That(res.Result[0].Participants, Is.EqualTo(1));
            Assert.That(res.Result[0].Accessibility, Is.LessThan(0.5m));
            Assert.That(res.Result[0].Accessibility, Is.GreaterThan(0m));
            Assert.That(res.Result[0].Price, Is.LessThan(0.6m));
            Assert.That(res.Result[0].Price, Is.GreaterThan(0.2m));
            Assert.Pass();
        }
        [Test]
        public void TestSpecificParams()
        {
            ActivityProvider AP = new ActivityProvider();
            ActivityModel act = new ActivityModel();
            act.Participants = 1;
            act.Price = 0.1m;
            act.Accessibility = 0.1m;

            var res = AP.GetTasks(act, test: true);
            Assert.That(res.Result[0].Participants, Is.EqualTo(1));
            Assert.That(res.Result[0].Price, Is.EqualTo(0.1m));
            Assert.That(res.Result[0].Accessibility, Is.EqualTo(0.1m));
            Assert.Pass();
        }
        [Test]
        public void TestMultipleResults()
        {
            ActivityProvider AP = new ActivityProvider();
            ActivityModel act = new ActivityModel();
            var res = AP.GetTasks(act, test: true, limit: 4);
            Assert.That(res.Result.Count, Is.EqualTo(4));
            Assert.Pass();
        }
    }
}