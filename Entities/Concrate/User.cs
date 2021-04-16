﻿using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities;
using Entities.Concrate;

namespace Entities.Concrate
{
    public class User : IEntity
    {

        public int Id { get; set; }
        public string UserName { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }

    }
}
