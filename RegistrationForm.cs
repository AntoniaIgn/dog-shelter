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
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();

            comboBoxSex.DataSource = Enum.GetValues(typeof(Dog.SexOptions));
            comboBoxSex.SelectedItem = null;
            comboBoxSize.DataSource = Enum.GetValues(typeof(Dog.SizeOptions));
            comboBoxSize.SelectedItem = null;
            comboBoxFurLength.DataSource = Enum.GetValues(typeof(Dog.FurLengthOptions));
            comboBoxFurLength.SelectedItem = null;
            comboBoxFurType.DataSource = Enum.GetValues(typeof(Dog.FurTypeOptions));
            comboBoxFurType.SelectedItem = null;
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            var dogName = nameTextBox.Text;
            var dogBreed = breedTextBox.Text;
            var dogAge = int.Parse(ageTextBox.Text);
            Dog dog = new Dog();

            Dog.SexOptions dogSex = (Dog.SexOptions) comboBoxSex.SelectedItem;           
            Dog.SizeOptions dogSize = (Dog.SizeOptions) comboBoxSize.SelectedItem;
            Dog.FurLengthOptions dogFurLength = (Dog.FurLengthOptions) comboBoxFurLength.SelectedItem;
            Dog.FurTypeOptions dogFurType = (Dog.FurTypeOptions) comboBoxFurType.SelectedItem;

            var selectedBreed = comboBoxBreed.SelectedIndex;

            dog.Register(selectedBreed, dogName, dogBreed, dogAge, dogSex, dogSize, dogFurLength, dogFurType);
            /*switch (comboBoxBreed.SelectedIndex)
            {
                case 0:
                    dog = new Hound()
                    {
                        Name = dogName,
                        Breed = dogBreed,
                        Age = dogAge,
                        Sex = dogSex,
                        Size = dogSize,
                        FurLength = dogFurLength,
                        FurType = dogFurType
                    };
                    break;
                case 1:
                    dog = new Retriever()
                    {
                        Name = dogName,
                        Breed = dogBreed,
                        Age = dogAge,
                        Sex = dogSex,
                        Size = dogSize,
                        FurLength = dogFurLength,
                        FurType = dogFurType
                    };
                    break;
                case 2:
                    dog = new Sheepdog()
                    {
                        Name = dogName,
                        Breed = dogBreed,
                        Age = dogAge,
                        Sex = dogSex,
                        Size = dogSize,
                        FurLength = dogFurLength,
                        FurType = dogFurType
                    };
                    break;
                case 3:
                    dog = new Spitz()
                    {
                        Name = dogName,
                        Breed = dogBreed,
                        Age = dogAge,
                        Sex = dogSex,
                        Size = dogSize,
                        FurLength = dogFurLength,
                        FurType = dogFurType
                    };
                    break;
                case 4:
                    dog = new Terrier()
                    {
                        Name = dogName,
                        Breed = dogBreed,
                        Age = dogAge,
                        Sex = dogSex,
                        Size = dogSize,
                        FurLength = dogFurLength,
                        FurType = dogFurType
                    };
                    break;
                default:
                    dog = new Dog()
                    {
                        Name = dogName,
                        Breed = dogBreed,
                        Age = dogAge,
                        Sex = dogSex,
                        Size = dogSize,
                        FurLength = dogFurLength,
                        FurType = dogFurType
                    };
                    break;
            }*/

            //dog.Add(dog);

            MessageBox.Show("Dog added successfully!");
            this.Close();
        }
    }
}
