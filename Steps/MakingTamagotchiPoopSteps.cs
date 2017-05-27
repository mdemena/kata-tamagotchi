using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TechTalk.SpecFlow;

namespace com.mdemena.katas.tamagotchi.Steps
{
    [Binding]
    public class MakingTamagotchiPoopSteps
    {
        private Entities.Tamagotchi _tamagotchi;
        private int _InitFood;

        [Given(@"I have a Tamagotchi"), Scope(Tag = "makingTamagotchiPoop")]
        public void GivenIHaveATamagotchi()
        {
            _tamagotchi = new Entities.Tamagotchi();

            _InitFood = _tamagotchi.Food;
        }

        [When(@"I make it poop")]
        public void WhenIMakeItPoop()
        {
            _tamagotchi.Poop();
        }
        
        [Then(@"it's fullness is decreased")]
        public void ThenItSFullnessIsDecreased()
        {
            Assert.IsTrue(_InitFood > _tamagotchi.Food);
        }
    }
}
