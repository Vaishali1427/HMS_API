﻿using Data_Access_Layer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Logic_Layer.Services.ViewPatientHistory
{
    public interface IServiceViewPatientHistory
    {
        public List<string> GetSymptoms();
        public List<view_patient_history> GetPatientHistory();
    }
}
