namespace BMIanime
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new BMIanime.MVVM.Views.BMIView();
        }
    }
}
