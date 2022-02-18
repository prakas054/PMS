﻿using PMS.DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMS.BusinessLayer.Repository.Interafce
{
    public interface IAppointmentRepository
    {
        List<Appointment> GetAllAppointment();
        Appointment AddAppointment(Appointment appointment);
    }
}