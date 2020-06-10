using System;
using System.Collections.Generic;
using System.Text;

namespace TestConsoleApplication.Controllers.Translate
{
    public class TranslateRequest
    {
        public string MessageToTranslate { get; set; }
        public string SomeMetaData { get; set; }
    }
}
