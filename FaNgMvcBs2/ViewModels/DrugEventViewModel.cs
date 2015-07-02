﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FdaService.Models.Drug.Event;

namespace FaNgMvcBs2.ViewModels
{
    public class DrugEventViewModel
    {
        public RootObject RootObject { get; set; }

        public List<SearchCriteria> SearchCriteria { get; set; }

        public string SearchCriteriaSelected { get; set; }

        public string SearchInfo { get; set; }

    }
}