using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winforms_tic_tac_toe
{
    public class Model : IModel
    {
        public bool IsCrossTurn { get; set; } = true;
        public bool IsGameStarted { get; set; } = false;
        public List<string> GameState { get; set; } = Enumerable.Repeat(string.Empty, 9).ToList();

        private static readonly int[,] WinCombinations = new int[,]
        {
        {0, 1, 2}, {3, 4, 5}, {6, 7, 8},
        {0, 3, 6}, {1, 4, 7}, {2, 5, 8},
        {0, 4, 8}, {2, 4, 6}
        };

        public bool CheckWin()
        {
            for (int i = 0; i < WinCombinations.GetLength(0); i++)
            {
                int a = WinCombinations[i, 0];
                int b = WinCombinations[i, 1];
                int c = WinCombinations[i, 2];

                if (!string.IsNullOrEmpty(GameState[a]) &&
                    GameState[a] == GameState[b] &&
                    GameState[a] == GameState[c])
                {
                    return true;
                }
            }
            return false;
        }

        public bool CheckTie()
        {
            return GameState.All(cell => !string.IsNullOrEmpty(cell));
        }
    }
}
