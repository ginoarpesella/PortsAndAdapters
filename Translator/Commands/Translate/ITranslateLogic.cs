using System;
using System.Collections.Generic;
using System.Text;
using TranslatorDomain;

namespace TranslatorApplication.Commands.Translate
{
    public interface ITranslateLogic
    {
        TranslateLogicResponse TranslanteMyMessagePlease(string translation);
    }
}
