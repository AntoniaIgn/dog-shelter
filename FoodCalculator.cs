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
    public partial class FoodCalculator : Form
    {
        public FoodCalculator()
        {
            InitializeComponent();
        }

        private void calcButton_Click(object sender, EventArgs e)
        {
            var kg = double.Parse(inputTextBox.Text);
            double result;
            Dog d;

            switch (comboBoxBreed.SelectedIndex)
            {
                case 0:
                    d = new Hound();
                    result = d.Feed(kg);
                    break;
                case 1:
                    d = new Retriever();
                    result = d.Feed(kg);
                    break;
                case 2:
                    d = new Sheepdog();
                    result = d.Feed(kg);
                    break;
                case 3:
                    d = new Spitz();
                    result = d.Feed(kg);
                    break;
                case 4:
                    d = new Terrier();
                    result = d.Feed(kg);
                    break;
                default:
                    d = new Dog();
                    result = d.Feed(kg);
                    break;
            }

            resultTextBox.Text = result.ToString();
        }
    }
}
