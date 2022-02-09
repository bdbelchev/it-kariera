using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._EventRealization
{
    public delegate void NameChangeEventHandler(object sender, NameChangeEventArgs args);

    class Dispatcher
    {
        private string name;
        public event NameChangeEventHandler NameChange;

        public string Name
        {
            get => name;
            set
            {
                name = value;
                OnNameChange(new NameChangeEventArgs(name));
            }
        }


        private void OnNameChange(NameChangeEventArgs args)
        {
            NameChange.Invoke(this, args);
        }
    }
}
