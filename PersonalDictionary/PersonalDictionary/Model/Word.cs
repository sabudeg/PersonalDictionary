using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace PersonalDictionary
{
    [Table("words")]
    public class Word
    {
        public string Turkish { get; set; }
        public string English { get; set; }

        public Word(string turkish, string english)
        {
            this.Turkish = turkish;
            this.English = english;
        }

        public Word()
        {

        }
    }
}
