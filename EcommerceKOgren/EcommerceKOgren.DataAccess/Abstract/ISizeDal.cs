﻿using EcommerceKOgren.DTO.DTOs;
using EcommerceKOgren.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceKOgren.DataAccess.Abstract
{
    public interface ISizeDal : IBaseRepository<Sizes>
    {
        IQueryable<SizeList> SizesList();
    }
}
