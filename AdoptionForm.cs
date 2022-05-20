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
    public partial class AdoptionForm : Form
    {
        private Dog _dog = new Dog();
        public AdoptionForm()
        {
            InitializeComponent();
        }

        private void FRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            var sex = _dog.Filter(FRadioButton.Name);

            dogsListBox.Items.Clear();
            dogsListBox.Items.AddRange(sex.ToArray());
        }
        private void MRdioButton_CheckedChanged(object sender, EventArgs e)
        {
            var sex = _dog.Filter(FRadioButton.Name);

            dogsListBox.Items.Clear();
            dogsListBox.Items.AddRange(sex.ToArray());
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            var breed = _dog.Filter(searchTextBox.Text);

            dogsListBox.Items.Clear();
            dogsListBox.Items.AddRange(breed.ToArray());
            
        }

        private void adoptButton_Click(object sender, EventArgs e)
        {
            var aName = adopterNameTextBox .Text;
            var aAddress = adopterAddressTextBox.Text;
            var aNumber = adopterNumberTextBox.Text;

            var dog = dogsListBox.SelectedItem as Dog;
            var adopter = new Person { Name = aName, Address = aAddress, PhoneNum = aNumber};

            _dog.Adopt(dog, adopter);
        }
    }
}
