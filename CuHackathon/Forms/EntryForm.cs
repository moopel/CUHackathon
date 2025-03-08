
using CuHackathon.C_Classes;

namespace CuHackathon.Forms
{
    public partial class EntryForm : Form
    {
        HeroForm childHeroForm;
        VillainForm childVillainForm;

        private string villainName, heroName;
        private string setting, winner;
        public string funcResult = String.Empty;

        public EntryForm()
        {
            InitializeComponent();
            FillChildForms();

            //
            villainName = "Joker"; heroName = "Batman";
            setting = "Gotham City"; winner = "Batman";
            Thread.SpinWait(1000);
            LoadData();
            //
        }

        private async void LoadData()
        {
            string taskString1 = "";
            string taskString2;
            string taskString3;
            try
            {
                taskString1 = await RunFlaskFunc("GenerateCrime");
                taskString2 = await RunFlaskFunc("GenerateHeroDescription");
                taskString3 = await RunFlaskFunc("GenerateFight");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }

            funcResult = taskString1;
        }

        private void FillChildForms()
        {
            HeroForm heroForm = new();
            heroForm.TopLevel = false;
            heroForm.FormBorderStyle = FormBorderStyle.None;
            heroForm.Dock = DockStyle.Fill;
            heroPanel.Controls.Add(heroForm);
            childHeroForm = heroForm;
            heroForm.Show();

            VillainForm villainForm = new();
            villainForm.TopLevel = false;
            villainForm.FormBorderStyle = FormBorderStyle.None;
            villainForm.Dock = DockStyle.Fill;
            villainPanel.Controls.Add(villainForm);
            childVillainForm = villainForm;
            villainForm.Show();
        }

        public async Task<string> RunFlaskFunc(string funcName)
        {
            string result = "";
            try
            {
                switch (funcName)
                {
                    case "GenerateCrime":
                        result = await PythonMedian.GenerateCrime(villainName);
                        break;
                    case "GenerateHeroDescription":
                        result = await PythonMedian.GenerateHeroDescription(heroName, villainName);
                        break;
                    case "GenerateFight":
                        result = await PythonMedian.GenerateFight(heroName, villainName, setting, winner);
                        break;
                    default:
                        result = "";
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return result;
        }

    }
}
