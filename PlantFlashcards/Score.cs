using System;
using System.Net;

namespace PlantFlashcards
{
    public class Score
    {
        private int _totalScore;
        private int _possibleScore;

        public Score()
        {
            _totalScore = 0;
        }

        public void AddToScore()
        {
            _totalScore++;
        }

        public void SetPossibleScore(int possible)
        {
            _possibleScore = possible;
        }

        public int GetScore() => _totalScore;
        public int GetPossibleScore() => _possibleScore;
        public int GetTotalScore() => _totalScore / _possibleScore;
    }
}