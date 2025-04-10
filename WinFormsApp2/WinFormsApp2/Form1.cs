namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string country = txtCountry.Text;
            int athletes = int.Parse(txtAthletes.Text);
            int gold = int.Parse(txtGoldMedals.Text);
            int silver = int.Parse(txtSilverMedals.Text);
            int bronze = int.Parse(txtBronzeMedals.Text);

            CountryMedal countryMedal = new CountryMedal(country, athletes, gold, silver, bronze);
            lblResult.Text = countryMedal.GetInfo();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
