using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace PersonalDictionary
{
    [Table("Words")]
    public class Word
    {
        [MaxLength(250)]
        public string Turkish { get; set; }

        [MaxLength(250)]
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
