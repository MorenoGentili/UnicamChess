using System;

namespace Chess.Model {
    public interface IClock {
        TimeSpan WhiteRemainingTime {get;}
        TimeSpan BlackRemainingTime {get;}
        Color CurrentTurn {get;}
        TimeSpan StartingTime {get;}

        void TurnOn();
        void Start();
        void Pause();
        void Reset();
        void EndCurrentTurn();
        event EventHandler<Color> TimeExpired;
        bool IsPaused { get; }
    }
}