using GoogleApi;
namespace weatherApp
{
    public partial class weatherApp : Form
    {
        private const string APP_ID = "b69bb7fc2737c4c9e90c27ca9d826e02";
        public weatherApp()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            var address = "Stavanger, Norway";

            var locationService = new GoogleLocationService();
            var point = locationService.GetLatLongFromAddress(address);

            var latitude = point.Latitude;
            var longitude = point.Longitude;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}