namespace CEMAPharmacy
{
    public partial class App : Application
    {
        public App(PharmacyInventoryDbContext dbContext)
        {
            InitializeComponent();

            MainPage = new AppShell(dbContext);
        }
    }
}
