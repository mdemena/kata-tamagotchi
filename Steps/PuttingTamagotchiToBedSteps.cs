using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TechTalk.SpecFlow;

namespace com.mdemena.katas.tamagotchi.Steps
{
    [Binding]
    public class PuttingTamagotchiToBedSteps
    {
        private Entities.Tamagotchi _tamagotchi;
        private int _InitTired;

        [Given(@"I have a Tamagotchi"), Scope(Tag = "puttingTamagotchiToBed")]
        public void GivenIHaveATamagotchi()
        {
            _tamagotchi = new Entities.Tamagotchi();

            _InitTired = _tamagotchi.Tired;
        }

        [When(@"I put it to bed")]
        public void WhenIPutItToBed()
        {
            _tamagotchi.GoToBed();
        }
        
        [Then(@"it's tiredness is decreased")]
        public void ThenItSTirednessIsDecreased()
        {
            Assert.IsTrue(_InitTired > _tamagotchi.Tired);
        }
    }
}
