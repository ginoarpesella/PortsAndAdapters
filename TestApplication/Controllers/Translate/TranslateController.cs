using System;
using System.Collections.Generic;
using System.Text;
using TranslatorApplication.Commands.Translate;

namespace TestConsoleApplication.Controllers.Translate
{
    public class TranslateController
    {
        private readonly ITranslateLogic _translateLogic;

        public TranslateController(ITranslateLogic translateLogic)
        {
            _translateLogic = translateLogic;
        }

        public TranslateResponse TranslateMyMessage(TranslateRequest request)
        {
            if (request != null && !string.IsNullOrEmpty(request.SomeMetaData))
            {
                TranslateLogicResponse response = _translateLogic.TranslanteMyMessagePlease(request.MessageToTranslate);
                return new TranslateResponse
                {
                    TranslatedMessage = response.Message,
                    UserStats = 12
                };
            }

            throw new Exception("Bad Request");
        }
    }
}
