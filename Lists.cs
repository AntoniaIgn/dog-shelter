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
    public partial class Lists : Form
    {
        private Dog _dog = new Dog();
        public Lists()
        {
            InitializeComponent();

            //dogsListBox.DataSource = ;
        }

        private void Lists_Load(object sender, EventArgs e)
        {
            
            dogsListBox.Items.AddRange(_dog.ListOfDogs.ToArray());
        }
    }
}
