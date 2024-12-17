using hw8;

namespace MillionaireGame
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            IModel model = new Model();
            IView view = new FormGame();
            Presenter presenter = new Presenter(model, view);

            Application.Run((Form)view);
        }
    }
}