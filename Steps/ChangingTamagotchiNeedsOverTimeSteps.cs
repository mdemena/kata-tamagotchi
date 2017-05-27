using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TechTalk.SpecFlow;

namespace com.mdemena.katas.tamagotchi.Steps
{
    [Binding]
    public class ChangingTamagotchiNeedsOverTimeSteps
    {
        private Entities.Tamagotchi _tamagotchi;
        private int _InitTired;
        private int _InitHappy;
        private int _InitFood;

        [Given(@"I have a Tamagotchi"), Scope(Tag = "changingTamagotchiNeedsOverTime")]
        public void GivenIHaveATamagotchi()
        {
            _tamagotchi = new Entities.Tamagotchi();

            _InitTired = _tamagotchi.Tired;
            _InitHappy = _tamagotchi.Happy;
            _InitFood = _tamagotchi.Food;
        }

        [When(@"time passes")]
        public void WhenTimePasses()
        {
            _tamagotchi.TimePassed();
        }

        [Then(@"it's tiredness is increased"), Scope(Tag = "changingTamagotchiNeedsOverTime")]
        public void ThenItSTirednessIsIncreased()
        {
            Assert.IsTrue(_InitTired < _tamagotchi.Tired);
        }

        [Then(@"it's hungriness is increased")]
        public void ThenItSHungrinessIsIncreased()
        {
            Assert.IsTrue(_InitFood > _tamagotchi.Food);
        }
        
        [Then(@"it's happiness is decreased")]
        public void ThenItSHappinessIsDecreased()
        {
            Assert.IsTrue(_InitHappy > _tamagotchi.Happy);
        }
    }
}
