﻿using ApplictionData.Common;
using Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplictionData.Repositories
{
    public class AppointmentRepository : Repository<Appointment>
    {
        public AppointmentRepository(DbContext context) : base(context)
        {
        }
    }
}
