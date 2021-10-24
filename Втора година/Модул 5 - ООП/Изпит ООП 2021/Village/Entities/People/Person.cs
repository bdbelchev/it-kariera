using System;
using System.Text;

namespace Village
{
    public abstract class Person
    {
        private string name;
        private int age;

        protected Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public string Name
        {
            get { return name; }
            private set
            {
                if (value.Length < 3 || value.Length > 30)
                {
                    throw new ArgumentException("Name should be between 3 and 30 characters!");
                }

                name = value;
            }
        }

        public virtual int Age
        {
            get { return age; }
            protected set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Age should be 0 or positive!");
                }

                age = value;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Name: {Name}");
            sb.AppendLine($"Age: {Age} ");

            return sb.ToString().Trim();
        }
    }
}
