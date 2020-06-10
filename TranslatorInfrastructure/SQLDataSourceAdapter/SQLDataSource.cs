using System;
using System.Collections.Generic;
using System.Text;
using TranslatorApplication.Repositories;
using TranslatorDomain;

namespace TranslatorInfrastructure.SQLDataSourceAdapter
{
    public class SQLDataSource : ITranslateDataSource
    {
        public SQLDataSource(/*DBContext*/)
        {

        }

        public TranslationDomainModel TranslateMessage(TranslationDomainModel translation)
        {
            // get translated text from database

            translation.SetTranslatedMessage(translation.OriginalMessage + " - SQL datasource");
            return translation;
        }
    }
}
