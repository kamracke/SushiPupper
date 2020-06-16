using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCSharp
{
    class PropertiesClass
    {
        private string word;
        public int height;


        public string Word
        {
            get
            {
                return word;
            }
            private set
            {
                if (value == "")
                word = value;

            }
        }

        public int Height {
            get
            {
                return height;
            }
            set { if (value > 0) height = value; } }

        public PropertiesClass(string word, int height)
        {
            this.word = word;
            this.height = height;
        }

        public void SetWord(string value)
        {
            Word = value;
        }
    }
}
