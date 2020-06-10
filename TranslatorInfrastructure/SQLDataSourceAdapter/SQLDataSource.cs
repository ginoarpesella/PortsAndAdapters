using System;
using System.Collections.Generic;
using System.Text;
using TranslatorApplication.Repositories;
using TranslatorDomain;

namespace TranslatorInfrastructure.SQLDataSourceAdapter
{
    public class SQLDataSource : ITranslateDataSource
    {
        public SQLDataSource(/*DBContext MyDbContext*/)
        {

        }

        public TranslationDomainModel TranslateMessage(TranslationDomainModel translation)
        {
            // get translated text from SQL database
            //using (var context = new MyDbContext())
            //{     
            //      Perform data access using the context
            //}

            translation.SetTranslatedMessage(translation.OriginalMessage + " - SQL datasource");
            return translation;
        }
    }
}
