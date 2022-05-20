using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dogShelter
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void adoptButton_Click(object sender, EventArgs e)
        {
            var fr = new AdoptionForm();
            fr.ShowDialog();
        }

        private void timesheetButton_Click(object sender, EventArgs e)
        {
            var fr = new TimeTable();
            fr.ShowDialog();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            var fr = new RegistrationForm();
            
            fr.ShowDialog();
        }

        private void label_DoubleClick(object sender, EventArgs e)
        {
            var fr = new Lists();
            fr.ShowDialog();
        }

    }
}
