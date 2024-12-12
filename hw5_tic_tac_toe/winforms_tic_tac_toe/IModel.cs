using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winforms_tic_tac_toe
{
    public interface IModel
    {
        bool IsCrossTurn { get; set; }
        bool IsGameStarted { get; set; }
        List<string> GameState { get; set; }

        bool CheckWin();
        bool CheckTie();
    }
}
