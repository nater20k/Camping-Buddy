﻿using Capstone.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone.DAL
{
    public interface ICampgroundDAO
    {
        IList<Campground> GetCampgrounds(string parkId);

        //IList<Campground> CampgroundSelector(string campgroundSelection);

    }
}
