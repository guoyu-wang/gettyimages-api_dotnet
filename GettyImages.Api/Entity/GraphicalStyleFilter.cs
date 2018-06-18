﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GettyImages.Api.Entity
{
    public enum GraphicalStyleFilter
    {
        None = 0,
        [Description("include")] Include = 1,
        [Description("exclude")] Exclude = 2
    }
}
