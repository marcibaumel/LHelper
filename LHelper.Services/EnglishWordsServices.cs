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
            if(CheckWord(englishWordsModel.Translate, englishWordsModel.Word)== true)
            {
                unitOfWork.englishWordsModels.Add(englishWordsModel);
                unitOfWork.SaveChanges();
            }          
        }

        public bool CheckWord(string Translate, string Word)
        {
            foreach(EnglishWordsModel englishWordsModel in unitOfWork.englishWordsModels)
            {
                if(englishWordsModel.Translate == Translate || englishWordsModel.Word == Word || englishWordsModel.Word == null && englishWordsModel.Translate== null)
                {
                    Console.WriteLine(englishWordsModel.Word);
                    return false;
                    
                }
               
            }
            return true;
        }


    }
}
