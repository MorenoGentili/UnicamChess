using System;
using System.Diagnostics;
using System.Threading;

namespace Chess.Model
{
    public class Clock : IClock
    {
      
        
        public TimeSpan TempoIniziale {
            get {
                return TimeSpan.Zero;
            }
        }
        private TimeSpan whiteRemainingTime;
        public TimeSpan WhiteRemainingTime
        {
            get
            {
                return whiteRemainingTime;
            }
            private set
            {
                whiteRemainingTime = value;
            }
        }

        private TimeSpan blackRemainingTime;
        public TimeSpan BlackRemainingTime
        {
            get
            {
                return blackRemainingTime;
            }
            private set
            {
                blackRemainingTime = value;
            }
        }

        private Color currentTurn = Color.White;
        public Color CurrentTurn
        {
            get
            {
                return currentTurn;
            }
            set
            {
                currentTurn = value;
            }
        }

        public event EventHandler<Color> TimeExpired;


        public void TurnOn()
        {
        }

        public void Start()
        {
        }

        private bool isPaused;
        public void Pause()
        {
        }
        public bool IsPaused {
            get {
                return isPaused;
            }
        }

        private TimeSpan startingTime;
        public TimeSpan StartingTime {
            get {
                return startingTime;
            }
        }

        public void EndCurrentTurn() {
        }

        public void Reset()
        {
           
        }

    }
}