using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237_assignment_1
{
    internal class Beverage
    {
        /**************************************************************
         * Backing Fields
         * ***********************************************************/
        private string _id;
        private string _name;
        private string _pack;
        private decimal _price;
        private bool _active;

        /**************************************************************
         * Properties
         * ***********************************************************/
        private string ID
        {
            get { return _id; }
            set { _id = value; }
        }        
        private string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        private string Pack
        {
            get { return _pack; }
            set { _pack = value; }
        }
        private decimal Price
        {
            get { return _price; }
            set { _price = value; }
        }
        private bool Active
        {
            get { return _active; }
            set { _active = value; }
        }

    }
}
