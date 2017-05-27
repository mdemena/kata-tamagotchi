using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TechTalk.SpecFlow;


namespace com.mdemena.katas.tamagotchi.Steps
{
    [Binding]
    public class FeedingTamagotchiSteps
    {
        private Entities.Tamagotchi _tamagotchi;
        private int _InitFood;

        [Given(@"I have a Tamagotchi")]
        public void GivenIHaveATamagotchi()
        {
            _tamagotchi = new Entities.Tamagotchi();

            _InitFood = _tamagotchi.Food;
        }
        
        [When(@"I feed it")]
        public void WhenIFeedIt()
        {
            _tamagotchi.FeedIt();
        }
        
        [Then(@"it's hungriness is decreased")]
        public void ThenItSHungrinessIsDecreased()
        {
            Assert.IsTrue(_InitFood < _tamagotchi.Food);
        }
        
        [Then(@"it's fullness is increased")]
        public void ThenItSFullnessIsIncreased()
        {
            Assert.IsTrue(_InitFood < _tamagotchi.Food);
        }
    }
}
