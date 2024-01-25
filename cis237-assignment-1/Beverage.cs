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
        //
        private string _id;
        //
        private string _name;
        //
        private string _pack;
        //
        private decimal _price;
        //
        private bool _active;

        /**************************************************************
         * Properties
         * ***********************************************************/
        //
        private string Id
        {
            get { return _id; }
            set { _id = value; }
        }  
        //
        private string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        //
        private string Pack
        {
            get { return _pack; }
            set { _pack = value; }
        }
        //
        private decimal Price
        {
            get { return _price; }
            set { _price = value; }
        }
        //
        private bool Active
        {
            get { return _active; }
            set { _active = value; }
        }

        /**************************************************************
         * Constructors
         * ***********************************************************/
        /// <summary>
        /// Used when creating an instance of the Beverage class
        /// </summary>
        /// <param name="passId"> Identifier for the beverage </param>
        /// <param name="passName"> Name of the beverage </param>
        /// <param name="passPack"> Packing type of the beverage </param>
        /// <param name="passPrice"> Price of the beverage </param>
        /// <param name="passActive"> Active status of the beverage </param>
        public Beverage(string passId, string passName, string passPack, decimal passPrice, bool passActive)
        {
            this._id = passId;
            this._name = passName;
            this._pack = passPack;
            this._price = passPrice;
            this._active = passActive;

        }

        /// <summary>
        /// Create a formatted line made of data involving a single beverage
        /// </summary>
        /// <returns> Concatenated string of all data points involved with one beverage </returns>
        public override string ToString()
        {
            //
            string beverageDataString = _id.PadRight(6) + _name.PadRight(55) + _pack.PadRight(20)
                                      + _price.ToString().PadLeft(6) + _active.ToString().PadRight(6);

            //
            return beverageDataString;
        }

    }

}
