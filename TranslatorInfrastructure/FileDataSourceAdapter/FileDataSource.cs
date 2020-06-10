using System;
using System.Collections.Generic;
using System.Text;
using TranslatorApplication.Repositories;
using TranslatorDomain;

namespace TranslatorInfrastructure.FileDataSourceAdapter
{
    public class FileDataSource : ITranslateDataSource
    {
        public TranslationDomainModel TranslateMessage(TranslationDomainModel translation)
        {
            // read message from file

            translation.SetTranslatedMessage(translation.OriginalMessage + " - file datasource");
            return translation;
        }
    }
}
