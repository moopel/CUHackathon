
using CuHackathon.C_Classes;

namespace CuHackathon.Forms
{
    public partial class EntryForm : Form
    {
        HeroForm childHeroForm;
        VillainForm childVillainForm;

        public string villainName, heroName;
        public string setting, winner;
        public string funcResult = String.Empty;

        public EntryForm()
        {
            InitializeComponent();
            FillChildForms();
        }

        private async void LoadData()
        {
            string taskString1 = "";
            try
            {
                taskString1 = await RunFlaskFunc("GenerateCrime");
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
            villainForm.parentForm = this;
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
