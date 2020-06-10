using System;

namespace TranslatorDomain
{
    public class TranslationDomainModel
    {
        public readonly string OriginalMessage;
        public string TranslatedMessage { get; private set; }

        public TranslationDomainModel(string originalMessage)
        {
            OriginalMessage = originalMessage;
        }

        public void SetTranslatedMessage(string msg)
        {
            // do something special here
            TranslatedMessage = msg;
        }
    }
}
