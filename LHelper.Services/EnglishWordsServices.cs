using LHelper.DataAccess;
using LHelper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LHelper.Services
{
    public class EnglishWordsServices
    {
        private UnitOfWork unitOfWork;

        public EnglishWordsServices()
        {
            unitOfWork = new UnitOfWork();
        }

        public void AddANewEnglisWord(EnglishWordsModel englishWordsModel)
        {
            unitOfWork.englishWordsModels.Add(englishWordsModel);
            unitOfWork.SaveChanges();
        }


    }
}
