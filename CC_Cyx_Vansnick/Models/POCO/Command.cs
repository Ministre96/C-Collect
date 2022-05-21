using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CC_Cyx_Vansnick.Models.POCO
{
    public class Command
    {
        private int idCommand;
        private DateTime orderPickUp;
        private int nbrBox;
        private bool paid;
        private Dictionary<Article, int> articles;

        public Dictionary<Article, int> Articles
        {
            get { return articles; }
            set { articles = value; }
        }
        public bool Paid
        {
            get { return paid; }
            set { paid = value; }
        }

        public int NbrBox
        {
            get { return nbrBox; }
            set { nbrBox = value; }
        }

        public DateTime OrderPickUp
        {
            get { return orderPickUp; }
            set { orderPickUp = value; }
        }

        public int IdCommand
        {
            get { return idCommand; }
            set { idCommand = value; }
        }

        public Command()
        {
            articles = new Dictionary<Article, int>();
        }

    }
}
