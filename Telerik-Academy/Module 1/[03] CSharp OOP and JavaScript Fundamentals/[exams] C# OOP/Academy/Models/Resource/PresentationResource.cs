﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Models.Resource
{
    class PresentationResource:AbstractLectureResource
    {
        public PresentationResource(string name, string url) : base(name, url)
        {
        }
    }
}