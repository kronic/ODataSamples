﻿namespace Microsoft.Test.OData.Services.ODataWCFService.Vocabularies
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    [Serializable]
    [Flags]
    public enum CapabilitiesSearchExpressions
    {
        None = 0,
        And = 1,
        Or = 2,
        Not = 4,
        Phrase = 8,
        Group = 16
    }
}
