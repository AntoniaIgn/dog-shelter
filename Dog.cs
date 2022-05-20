using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dogShelter
{
    public class Dog
    {
        public Dog(string name, string breed, double age, SexOptions sex, SizeOptions size, FurLengthOptions furLength, FurTypeOptions furType)
        {
            this.name = name;

        }

        //protected string name;
        public string name { get; set; }
        protected string breed;
        public string Breed { get { return breed; } set { breed = value; } }
        protected double age;
        public double Age { get { return age; } set { age = value; } }

        public Person Adopter { get; set; }

        public enum SexOptions { Female, Male};
        public enum SizeOptions { ExtraSmall, Small, Medium, Large, ExtraLarge};
        public enum FurLengthOptions { Short, Long};
        public enum FurTypeOptions { Straight, Curly};

        protected SexOptions _sex;
        public SexOptions Sex { get { return _sex; } set { _sex = value; } }

        protected SizeOptions _size;
        public SizeOptions Size { get { return _size; } set { _size = value; } }

        protected FurLengthOptions _length;
        public FurLengthOptions FurLength { get { return _length; } set { _length = value; } }

        protected FurTypeOptions _type;
        public FurTypeOptions FurType { get { return _type; } set { _type = value; } }

        /*private List<Dog> Dogs = new List<Dog>();
        private List<Dog> AdoptedDogs = new List<Dog>();*/

        public List<Dog> ListOfDogs = new List<Dog>(); //{ return Dogs; }
        public List<Dog> ListOfAdoptedDogs = new List<Dog>(); //{ return AdoptedDogs; }

        public void Register(int selectedBreed, string name, string breed, double age, SexOptions sex, SizeOptions size, FurLengthOptions furLength, FurTypeOptions furType)
        {
            Dog dog;
            switch (selectedBreed)
            {
                case 0:
                    dog = new Hound()
                    {
                        Name = name,
                        Breed = breed,
                        Age = age,
                        Sex = sex,
                        Size = size,
                        FurLength = furLength,
                        FurType = furType
                    };
                    break;
                case 1:
                    dog = new Retriever()
                    {
                        Name = name,
                        Breed = breed,
                        Age = age,
                        Sex = sex,
                        Size = size,
                        FurLength = furLength,
                        FurType = furType
                    };
                    break;
                case 2:
                    dog = new Sheepdog()
                    {
                        Name = name,
                        Breed = breed,
                        Age = age,
                        Sex = sex,
                        Size = size,
                        FurLength = furLength,
                        FurType = furType
                    };
                    break;
                case 3:
                    dog = new Spitz()
                    {
                        Name = name,
                        Breed = breed,
                        Age = age,
                        Sex = sex,
                        Size = size,
                        FurLength = furLength,
                        FurType = furType
                    };
                    break;
                case 4:
                    dog = new Terrier()
                    {
                        Name = name,
                        Breed = breed,
                        Age = age,
                        Sex = sex,
                        Size = size,
                        FurLength = furLength,
                        FurType = furType
                    };
                    break;
                default:
                    dog = new Dog()
                    {
                        Name = name,
                        Breed = breed,
                        Age = age,
                        Sex = sex,
                        Size = size,
                        FurLength = furLength,
                        FurType = furType
                    };
                    break;
            }
            /*Dog dog = new Dog
            {
                Name = name,
                Breed = breed,
                Age = age,
                Sex = sex,
                Size = size,
                FurLength = furLength,
                FurType = furType
            };*/
            ListOfDogs.Add(dog);
        }
        public void Adopt(Dog dog, Person person)
        {
            ListOfDogs.Remove(dog);
            ListOfAdoptedDogs.Add(dog);
            dog.Adopter = person;
        }

        /*public void Add(Dog dog)
        {
            ListOfDogs.Add(dog);
        }*/

        public virtual string[] HealthCare(Dog dog)
        {
            string[] needs = new string[3] {"wash", "nail-cut", ""};
            needs[1] = dog.FurLength == 0 ? "brush" : "trim";
            return needs;
        }

        public virtual double Feed(double kg)
        {
            // (kg*10*2.5)/2, защото количеството се разделя на две порции за деня
            return kg*5*2.5;
        }

        public List<Dog> Filter(string criterion)
        {
            var resultList = new List<Dog>();

            /*for (int i = 0; i < Dogs.Count; i++)
                if (Dogs[i].Sex.Equals(criterion))
                    resultList.Add(Dogs[i]);
                else if (Dogs[i].Breed.StartsWith(criterion))
                    resultList.Add(Dogs[i]);*/

            if (criterion == "female" || criterion == "male")
            {
                for(int i = 0; i < ListOfDogs.Count; i++)
                    if (ListOfDogs[i].Sex.Equals(criterion))
                        resultList.Add(ListOfDogs[i]);
            }

            for (int i = 0; i < ListOfDogs.Count; i++)
                if (ListOfDogs[i].Breed.StartsWith(criterion))
                    resultList.Add(ListOfDogs[i]);

            return resultList;
        }
    }
}
