﻿using QuestPDF.Fluent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestPdfOtherExamples.Examples
{
    internal class ErrorExample : IQuestPdfExample
    {
        public Document GetDocument()
        {
            throw new NotImplementedException();
        }
    }
}
