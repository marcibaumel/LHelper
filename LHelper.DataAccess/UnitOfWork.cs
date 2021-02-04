using LHelper.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LHelper.DataAccess
{
    public class UnitOfWork: DbContext
    {
        public DbSet<EnglishWordsModel> englishWordsModels { get; set; }
        
        public DbSet<JapaneseWordsModel> japaneseWordsModels { get; set; }

        public UnitOfWork() : base("LHelperDBConnectionString") { }
    }
}
