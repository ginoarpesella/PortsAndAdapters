using System;
using System.Collections.Generic;
using System.Text;
using TranslatorApplication.Repositories;
using TranslatorDomain;

namespace TranslatorApplication.Commands.Translate
{
    // this is the port implementation
    public class TranslateLogic : ITranslateLogic
    {
        private readonly ITranslateDataSource _dataSource;

        public TranslateLogic(ITranslateDataSource dataSource)
        {
            _dataSource = dataSource;
        }

        public TranslateLogicResponse TranslanteMyMessagePlease(string msg)
        {
            TranslationDomainModel model = new TranslationDomainModel(msg);
            
            var result = _dataSource.TranslateMessage(model);
            TranslateLogicResponse response = new TranslateLogicResponse { 
                Message = $"Original message: '{result.OriginalMessage}' - Translated message: '{result.TranslatedMessage}'"
            };

            return response;
        }
    }
}
