﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Keeper.DotMudCore
{
    public struct IdentityInfo
    {
        public IdentityInfo(string username, bool isNew)
            : this()
        {
            this.Username = username;
            this.IsNew = isNew;
        }

        public string Username
        {
            get;
            private set;
        }

        public bool IsNew
        {
            get;
            private set;
        }
    }
}