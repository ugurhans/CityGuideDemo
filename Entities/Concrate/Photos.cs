﻿using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities;
using Entities.Concrate;

namespace Entities.Concrate
{
    public class Photo : IEntity
    {
        public int Id { get; set; }
        public int CityId { get; set; }
        public int PublicId { get; set; }
        public string Url { get; set; }
        public string Description { get; set; }
        public DateTime DateAdded { get; set; }
        public bool IsMain { get; set; }
    }
}
