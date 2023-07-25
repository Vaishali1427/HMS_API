using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessObject
{
    public class PatientHistory_BO
    {
        private string _patient_id;
        private string _Fname;
        private string _lname;
        public string _symptom;
        public string symptom
        {
            get
            {
                return _symptom;
            }
            set
            {
                _symptom = value;
            }
        }
        public string patient_id
        {
            get
            {
                return _patient_id;
            }
            set
            {
                _patient_id = value;
            }
        }
        public string Fname
        {
            get
            {
                return _Fname;
            }
            set
            {
                _Fname = value;
            }
        }
        public string lname
        {
            get
            {
                return _lname;
            }
            set
            {
                _lname = value;
            }
        }

    }
}
