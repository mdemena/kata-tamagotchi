using System;

namespace com.mdemena.katas.tamagotchi.Entities
{
    public class Tamagotchi
    {
        public int Food { get; set; }
        public int Happy { get; set; }
        public int Tired { get; set; }

        public Tamagotchi()
        {
            Food = 0;
            Happy = 50;
            Tired = 0;
        }

        public void FeedIt()
        {
            Food++;
        }

        internal void Play()
        {
            Happy++;
            Tired++;
        }

        internal void GoToBed()
        {
            Tired--;
        }

        internal void Poop()
        {
            Food--;
        }

        internal void TimePassed()
        {
            Food--;
            Happy--;
            Tired++;
        }
    }
}