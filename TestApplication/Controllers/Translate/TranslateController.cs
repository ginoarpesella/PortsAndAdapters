using System;
using System.Collections.Generic;
using System.Text;
using TranslatorApplication.Commands.Translate;

namespace TestConsoleApplication.Controllers.Translate
{
    //[Route("api/v1/[controller]")]
    public class TranslateController //: Controller
    {
        private readonly ITranslateLogic _translateLogic;

        public TranslateController(ITranslateLogic translateLogic)
        {
            _translateLogic = translateLogic;
        }

        //[HttpGet("translatemymessage")]
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
