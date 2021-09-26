using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14._BorderControl
{
    class Robot : IIdentifiable
    {
        public string ID { get; }
        public string Model { get; }

        public Robot(string id, string model)
        {
            ID = id;
            Model = model;
        }
    }
}
