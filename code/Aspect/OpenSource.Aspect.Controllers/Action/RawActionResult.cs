﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OpenSource.Aspect.Controllers
{
    public class RawActionResult: ActionResult
    {
        public string Content
        {
            get;
            set; 
        }
    }
}
