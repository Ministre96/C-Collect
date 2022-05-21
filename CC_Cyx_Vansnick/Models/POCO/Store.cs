using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CC_Cyx_Vansnick.Models.POCO
{
    public class Store
    {
        private int idStore;
        private string phoneNumber;
        private string street;
        private string number;
        private string city;
        private List<TimeSlot> timeSlots = new List<TimeSlot>();

        public List<TimeSlot> TimeSlots
        {
            get { return timeSlots; }
            set { timeSlots = value; }
        }


        public string City
        {
            get { return city; }
            set { city = value; }
        }

        public string Number
        {
            get { return number; }
            set { number = value; }
        }

        public string Street
        {
            get { return street; }
            set { street = value; }
        }

        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }

        public int IdStore
        {
            get { return idStore; }
            set { idStore = value; }
        }
        public Store()
        {

        }
        public Store(string ph, string s, string n, string c)
        {
            phoneNumber = ph;
            street = s;
            number = n;
            city = c;
        }
    }
}
