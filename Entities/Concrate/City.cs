using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities;
using Core.Entities.Concrate;
using Entities.Concrate;

namespace Entities.Concrate
{
    public class City : IEntity
    {
        public City()
        {
            Photos = new List<Photo>();
        }
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Photo> Photos { get; set; }
        public User User { get; set; }

    }
}
