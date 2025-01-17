﻿using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Models
{
    public class Book
    {
       
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
      public string Id { get; set; }
        public string Name { get; set; }

        public string Author { get; set; }
        public string Category { get; set; }
        public double Price { get; set; }
       
    }
}
