using System;


namespace Problem_04_Student
{
    public class Student
    {
        public event PropertyChangedEventHandler OnChange;
        private string name;
        private double age;

        public Student(string name, double age)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("name", "Name cannot be null or empty");
                }
                this.OnPropertyChange(this, new PropertyChangedEventArgs("Name",this.name,value));
                this.name = value;
                
            }
        }

        public double Age
        {
            get { return this.age; }
            set
            {
                if (value <=0)
                {
                    throw new ArgumentOutOfRangeException("age", "The age cannot be neggative or 0");
                }
                this.OnPropertyChange(this, new PropertyChangedEventArgs("Age",this.age, value));
                this.age = value;
            }
        }

        private void OnPropertyChange(object sender, PropertyChangedEventArgs args)
        {
            if (this.OnChange != null)
            {
                this.OnChange(sender, args);
            }
        }
    }
}
