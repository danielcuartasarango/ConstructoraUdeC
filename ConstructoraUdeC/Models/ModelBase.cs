﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ConstructoraUdeC.Models
{
    public class ModelBase
    {
        public DateTime CurrentDate
        {
            get { return DateTime.Now; }
        }

        private int userInSessionId;

        public int UserInSessionId
        {
            get { return userInSessionId; }
            set { userInSessionId = value; }
        }
    }
}