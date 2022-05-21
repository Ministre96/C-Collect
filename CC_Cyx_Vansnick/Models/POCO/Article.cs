using CC_Cyx_Vansnick.DAL;
using CC_Cyx_Vansnick.DAL.IDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CC_Cyx_Vansnick.Models.POCO
{
    public class Article
    {
        private int idArticle;
        private string name;
        private float price;
        private string type;
        

        public string Type
        {
            get { return type; }
            set { type = value; }
        }


        public float Price
        {
            get { return price; }
            set { price = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int IdArticle
        {
            get { return idArticle; }
            set { idArticle = value; }
        }
        public Article()
        {
            
        }
        public Article(string n, float p)
        {
            name = n;
            price = p;
        }
        public static List<Article> FindAllArticle(IArticlesDAL articlesDAL )
        {
            return articlesDAL.FindAllArticles();
        }
        public static Article FindById(int id, IArticlesDAL articlesDAL)
        {
            return articlesDAL.FindById(id);
        }
    }
}