﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EOS_SDK._Data
{
    [AttributeUsage(AttributeTargets.Struct)]
    public class APIVersionAttribute : Attribute
    {
        public APIVersionAttribute(int APIVersion) 
        { 
        }
    }
}