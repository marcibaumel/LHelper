using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LHelper.Models
{
   public class JapaneseWordsModel
    {
        public int Id { get; set; }
        public string Word { get; set; }
        public string Translate { get; set; }
        public string HelpSentence { get; set; }
    }
}
