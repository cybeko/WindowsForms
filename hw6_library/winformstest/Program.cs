namespace Library
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            IModel model = new Model();
            LibraryForm view = new LibraryForm();
            LibraryPresenter presenter = new LibraryPresenter(model, view);

            Application.Run(view);
        }
    }
}