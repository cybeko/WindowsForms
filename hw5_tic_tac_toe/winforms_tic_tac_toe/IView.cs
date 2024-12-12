﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winforms_tic_tac_toe
{
    public interface IView
    {
        event EventHandler<EventArgs> StartButtonClick;

        void SetMessage(string message);
        void UpdateButton(int index, string text, bool isEnabled, Color backgroundColor);
        void ShowWinner(string winner);

        void ShowTie();
        void ResetGame();
    }
}
