using CuHackathon.C_Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuHackathon.Forms
{
    public partial class VillainForm : Form
    {
        public EntryForm parentForm;
        public VillainForm()
        {
            InitializeComponent();
        }

        private void GenerateVillainButton_Click(object sender, EventArgs e)
        {
            RandomVillain();
            villainBodyBox.Text = PythonMedian.GenerateCrime(parentForm.villainName).Result;
        }

        private async void RandomVillain()
        {
            parentForm.villainName = await PythonMedian.GenerateVillain();
        }
    }
}
