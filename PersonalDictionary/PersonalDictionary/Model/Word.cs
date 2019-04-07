using System;
using System.Collections.Generic;
using System.Text;

namespace PersonalDictionary
{
    class Word
    {
        public string turkish { get; set; }
        public string english { get; set; }

        public Word(string turkish, string english)
        {
            this.turkish = turkish;
            this.english = english;
        }
    }
}
