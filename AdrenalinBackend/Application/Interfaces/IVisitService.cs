﻿using Domain.DTOs.Visit;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IVisitService
    {
        Task<Visit> CreateVisit(VisitCreateDTO visit);
    }
}
