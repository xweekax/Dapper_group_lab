using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Dapper.Contrib.Extensions;
using Dapper;

namespace DapperOverflow.Models
{
    [Table("Question")]
    public class Question
    {
        [Key]
        public long id { get; set; }
        public string Username { get; set; }
        public string Title { get; set; }
        public string Detail { get; set; }
        public DateTime Posted { get; set; }
        public string Category { get; set; }
        public string Tags { get; set; }
        public int Status { get; set; }

        public static Question Create(string _username, string _title, string _detail)
        {
            IDbConnection db = new SqlConnection("Server=.;Database=DapperOverflow;user id=dbuser;password=abc123");
            Question question = new Question() { Username = _username, Title = _title, Detail = _detail };
            question.Posted = DateTime.Now;
            question.Status = 0;
            question.Category = "test";
            question.Tags = "test";
            long _id = db.Insert<Question>(question);
            question.id = _id;
            return question;
        }

        public static List<Question> ReadAll()
        {
            IDbConnection db = new SqlConnection("Server=.;Database=DapperOverflow;user id=dbuser;password=abc123");
            List<Question> questionlist = db.GetAll<Question>().ToList();
            return questionlist;
        }
        public static Question Read(long _id)
        {
            IDbConnection db = new SqlConnection("Server=.;Database=DapperOverflow;user id=dbuser;password=abc123");
            Question question = db.Get<Question>(_id);
            return question;
        }

    }
}
