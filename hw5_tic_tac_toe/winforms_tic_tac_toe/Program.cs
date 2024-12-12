namespace winforms_tic_tac_toe
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            IModel model = new Model();
            TicTacToeForm view = new TicTacToeForm();
            Presenter presenter = new Presenter(view, model);

            Application.Run(view);
        }
    }
}