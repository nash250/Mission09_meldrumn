﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission09_meldrumn.Models
{
    // interface is a pattern/template for a class
    public interface IBookstoreRepository
    {
        IQueryable<Book> Books { get; }
    }
}
