using System;
using System.Collections.Generic;
using System.Text;
using TranslatorDomain;

namespace TranslatorApplication.Repositories
{
    // This is the structure our adapters need to follow
    public interface ITranslateDataSource
    {
        TranslationDomainModel TranslateMessage(TranslationDomainModel msg);
    }
}
