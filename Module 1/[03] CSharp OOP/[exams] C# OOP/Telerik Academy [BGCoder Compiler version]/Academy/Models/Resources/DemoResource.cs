﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Models.Resources
{
    using Academy.Models.Resources.Abstract;

    internal class DemoResource : LectureResource
    {
        public DemoResource(string name, string url)
            : base(name, url)
        {
        }
    }
}
