﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DapperOverflow.Models;

namespace DapperOverflow.Controllers
{
    public class QandAController : Controller
    {
        public IActionResult Index() //Displays ALL question
        {
            List<Question> list = Question.ReadAll();            
            return View(list);
        }

        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(string username, string title, string detail)
        {
            Question newquestion = Question.Create(username, title, detail);
            //newquestion.Add();
            return RedirectToAction("Index");
        }

        public IActionResult Search() 
        {
            List<Question> list = Question.ReadAll();
            return View(list);
        }
        public IActionResult Detail(long _id)
        {
            Question question = Question.Read(_id);
            return View(question);
        }
        public IActionResult Edit(long _id)
        {

            return View();
        }
    }
}
