using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13._AnimalKingdom
{
    class Trainer
    {
        private IAnimal entity;

        public Trainer(IAnimal entity)
        {
            this.entity = entity;
        }

        public void Make()
        {
            entity.Perform();
        }
    }
}
