using System;
using System.Collections.Generic;
using System.Text;
using TranslatorDomain;

namespace TranslatorApplication.Repositories
{
    public interface ITranslateDataSource
    {
        TranslationDomainModel TranslateMessage(TranslationDomainModel msg);
    }
}
