﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    interface IChairBuilder
    {
        void CreateSit();
        void CreateLage();
        void CreateBack();
        Chair GetChair();
    }
}
