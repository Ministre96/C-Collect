using CC_Cyx_Vansnick.DAL.IDAL;
using CC_Cyx_Vansnick.Models.POCO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace CC_Cyx_Vansnick.DAL
{
    public class ArticlesDAL : IArticlesDAL
    {
        public string ConnectionString { get; private set; }
        public ArticlesDAL(string connectionString)
        {
            ConnectionString = connectionString;
        }
        public List<Article> FindArticleByType(string type)
        {
            List<Article> articles = new List<Article>();
            string query = "SELECT * FROM dbo.[Article] WHERE Type = @Type";
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("Type", type);
                connection.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Article a = new Article();
                        a.IdArticle = reader.GetInt32("IdArticle");
                        a.Name = reader.GetString("Name");
                        a.Price = (float)reader.GetDouble("Price");
                        a.Type = reader.GetString("Type");
                        articles.Add(a);
                    }
                }
            }
            return articles;
        }
        public List<Article> FindArticleByResearch(string research)
        {
            List<Article> articles = new List<Article>();
            string query = "SELECT * FROM dbo.[Article] WHERE Name LIKE '@Research%'";
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("Research", research.ToUpper());
                connection.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Article a = new Article();
                        a.IdArticle = reader.GetInt32("IdArticle");
                        a.Name = reader.GetString("Name");
                        a.Price = (float)reader.GetDouble("Price");
                        a.Type = reader.GetString("Type");
                        articles.Add(a);
                    }
                }
            }
            return articles;
        }
        public List<Article> FindAllArticles()
        {
            List<Article> articles = new List<Article>();
            string query = "SELECT * FROM dbo.[Article]";
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                SqlCommand cmd = new SqlCommand(query, connection);
                connection.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Article a = new Article();
                        a.IdArticle = reader.GetInt32("IdArticle");
                        a.Name = reader.GetString("Name");
                        a.Price = (float)reader.GetDouble("Price");
                        a.Type = reader.GetString("Type");
                        articles.Add(a);
                    }
                }
            }
            return articles;
        }
        public Article FindById(int id)
        {
            Article a = new Article();
            string query = "SELECT * FROM dbo.[Article] WHERE IdArticle = @IdArticle";
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("IdArticle", id);
                connection.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        a.IdArticle = reader.GetInt32("IdArticle");
                        a.Name = reader.GetString("Name");
                        a.Price = (float)reader.GetDouble("Price");
                        a.Type = reader.GetString("Type");
                    }
                }
            }
            return a;
        }
    }
}
