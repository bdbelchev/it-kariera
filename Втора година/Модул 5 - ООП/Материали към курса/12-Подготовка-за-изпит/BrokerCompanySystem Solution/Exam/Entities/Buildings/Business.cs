using System;

namespace BrokerCompanySystem.Entities.Buildings
{
    public class Business : Building
    {
        public Business(string name, string city, int stars, double rentAmount)
            : base(name, city, stars, rentAmount)
        {

        }
        public override string Name
        {
            get => base.Name;
            protected set
            {
                if (!value.EndsWith("Business"))
                {
                    throw new ArgumentException("Name of business buildings should end on Business!");
                }

                base.Name = value;
            }
        }
    }
}
