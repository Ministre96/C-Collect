using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CC_Cyx_Vansnick.Models.POCO
{
    public class TimeSlot
    {
        private DateTime date;
        private int maxSlot;
        private int slotTaken;

        public int SlotTaken
        {
            get { return slotTaken; }
            set { slotTaken = value; }
        }

        public int MaxSlot
        {
            get { return maxSlot; }
            set { maxSlot = value; }
        }

        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }
        public TimeSlot(DateTime d)
        {
            date = d;
            maxSlot = 4;
        }

    }
}
