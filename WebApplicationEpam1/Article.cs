using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplicationEpam1
{
    public class Article
    {
        public string Name { get; set; }
        public DateTime _DateTime { get; set; }
        public string Text { get; set; }

        public Article(string name, DateTime dateTime, string text)
        {
            Name = name;
            _DateTime = dateTime;
            Text = text;
        }
    }
}