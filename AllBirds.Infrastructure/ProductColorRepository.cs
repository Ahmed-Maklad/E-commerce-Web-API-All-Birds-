﻿using AllBirds.Application.Contracts;
using AllBirds.Context;
using AllBirds.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllBirds.Infrastructure
{
    public class ProductColorRepository(AllBirdsContext context):GenericRepository<ProductColor, int>(context), IProductColorRepository
    {
    }
}
