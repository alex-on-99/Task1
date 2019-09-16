using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplicationEpam1
{
    public class Review
    {
        public string Name { get; set; }
        public DateTime _DateTime { get; set; }
        public string Text { get; set; }

        public Review(string name, string text)
        {
            Name = name;
            _DateTime = DateTime.Now;
            Text = text;
        }
    }
}