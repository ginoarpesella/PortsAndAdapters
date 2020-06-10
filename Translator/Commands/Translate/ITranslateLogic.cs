using System;
using System.Collections.Generic;
using System.Text;
using TranslatorDomain;

namespace TranslatorApplication.Commands.Translate
{
    // this will explain to the outside world how to interact with our application logic
    // port
    public interface ITranslateLogic
    {
        TranslateLogicResponse TranslanteMyMessagePlease(string translation);
    }
}
