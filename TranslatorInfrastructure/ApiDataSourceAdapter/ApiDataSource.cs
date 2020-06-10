using System;
using System.Collections.Generic;
using System.Text;
using TranslatorApplication.Repositories;
using TranslatorDomain;

namespace TranslatorInfrastructure.ApiDataSourceAdapter
{
    public class ApiDataSource : ITranslateDataSource
    {
        public TranslationDomainModel TranslateMessage(TranslationDomainModel translation)
        {
            // create http client
            // call the endpoint to get the translated message

            translation.SetTranslatedMessage(translation.OriginalMessage + " - api datasource");
            return translation;
        }
    }
}
