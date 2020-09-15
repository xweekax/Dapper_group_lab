﻿using System;
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
            IDbConnection db = new SqlConnection("Server=GQJSN13\\SQLEXPRESS;Database=DapperOverflow;user id=newuser;password=abc123");
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
            IDbConnection db = new SqlConnection("Server=GQJSN13\\SQLEXPRESS;Database=DapperOverflow;user id=newuser;password=abc123");
            List<Question> questionlist = db.GetAll<Question>().ToList();
            return questionlist;
        }
        public static Question Read(long _id)
        {
            IDbConnection db = new SqlConnection("Server=GQJSN13\\SQLEXPRESS;Database=DapperOverflow;user id=newuser;password=abc123");
            Question question = db.Get<Question>(_id);
            return question;
        }

        public static Question Update(long _id, string _username, string _title, string _detail)
        {
            IDbConnection db = new SqlConnection("Server=GQJSN13\\SQLEXPRESS;Database=DapperOverflow;user id=newuser;password=abc123");
            Question question = new Question() { id = _id, Username = _username, Title = _title, Detail = _detail };

            Question newquestion = Read(_id);
            newquestion.Detail = _detail;
            newquestion.Username = _username;
            newquestion.Title = _title;
            db.Update(newquestion);

            return newquestion;
        }

        public static void Delete(long _id)
        {
            IDbConnection db = new SqlConnection("Server=GQJSN13\\SQLEXPRESS;Database=DapperOverflow;user id=newuser;password=abc123");
            db.Delete(new Question() {id = _id});
        }
        public static List<Question> Search(string search)
        {
            IDbConnection db = new SqlConnection("Server=GQJSN13\\SQLEXPRESS;Database=DapperOverflow;user id=newuser;password=abc123");
            List<Question> questionlist = db.Query<Question>($"SELECT id, Title, Username, Posted FROM Question WHERE Detail LIKE '%{search}%'").AsList();
            return questionlist;
        }
    }
}
