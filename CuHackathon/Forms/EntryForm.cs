
namespace CuHackathon.Forms
{
    public partial class EntryForm : Form
    {
        HeroForm childHeroForm;
        VillainForm childVillainForm;

        public EntryForm()
        {
            InitializeComponent();
            FillChildForms();
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

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
