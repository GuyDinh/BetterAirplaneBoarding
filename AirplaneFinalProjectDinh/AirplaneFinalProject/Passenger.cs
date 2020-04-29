using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/***************************************************************
* Name        : Passenger
* Author      : Trong Dinh
* Created     : 3/31/2020
***************************************************************/

namespace AirplaneFinalProject
{
    class Passenger
    {
        private string _firstName;
        private string _lastName;
        private string _seat;
        /**************************************************************
        * Constructors
        ***************************************************************/
        /**************************************************************
        * Name: Passenger()
        * Description: Default no-arg constructor
        * Input parameters: none
        ***************************************************************/
        public Passenger()
        {
        }
        /**************************************************************
        * Name: Passenger()
        * Description: Constructor that accepts field one, field two and field three
        * Input: string inFirstName, string inLastName, string inSeat
        ***************************************************************/
        public Passenger(string inFirstName, string inLastName, string inSeat)
        {
            _firstName = inFirstName;
            _lastName = inLastName;
            _seat = inSeat;
        }
        /**************************************************************
        * Getters and Setters
        ***************************************************************/
        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }
        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }
        public string Seat
        {
            get { return _seat; }
            set { _seat = value; }
        }
    }
}
