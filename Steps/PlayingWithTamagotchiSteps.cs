using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TechTalk.SpecFlow;

namespace com.mdemena.katas.tamagotchi.Steps
{
    [Binding]
    public class PlayingWithTamagotchiSteps
    {
        private Entities.Tamagotchi _tamagotchi;
        private int _InitHappy;
        private int _InitTired;

        [Given(@"I have a Tamagotchi"), Scope(Tag = "playingWithTamagotchi")]
        public void GivenIHaveATamagotchi()
        {
            _tamagotchi = new Entities.Tamagotchi();

            _InitHappy = _tamagotchi.Happy;
            _InitTired = _tamagotchi.Tired;
        }

        [When(@"I play with it")]
        public void WhenIPlayWithIt()
        {
            _tamagotchi.Play();
        }
        
        [Then(@"it's happiness is increased")]
        public void ThenItSHappinessIsIncreased()
        {
            Assert.IsTrue(_InitHappy < _tamagotchi.Happy);
        }
        
        [Then(@"it's tiredness is increased")]
        public void ThenItSTirednessIsIncreased()
        {
            Assert.IsTrue(_InitTired < _tamagotchi.Tired);
        }
    }
}
