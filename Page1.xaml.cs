namespace MainPageTests
{
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
        }

        public Page1(Shell shell)
        {
            Shell = shell;
            InitializeComponent();
        }

        public Shell? Shell { get; }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = Shell;
        }
    }
}