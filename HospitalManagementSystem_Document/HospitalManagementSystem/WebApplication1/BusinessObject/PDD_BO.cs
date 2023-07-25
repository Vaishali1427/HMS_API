using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;



namespace BO
{

    public class PDD_BO // Declare Class Public to Access any where 
    {

        //Declaring User Registration Variables



        private string _id;
        private string _diagnosisid;
        private string _symptoms;
        private string _diagnosisprovided;
        private string _physician;

        private DateTime _dt;



        private string _followup;
        private DateTime _followupdate;
        private string _card;
        private string _mode;
        private string _bill;


        // Get and set values



        public string physician_id
        {

            get
            {

                return _id;

            }

            set
            {

                _id = value;

            }

        }
        public string diagnosisid
        {

            get
            {

                return _diagnosisid;

            }

            set
            {

                _diagnosisid = value;

            }

        }
        public string symptoms
        {

            get
            {

                return _symptoms;

            }

            set
            {

                _symptoms = value;

            }

        }
        public string diagnosisprovided
        {

            get
            {

                return _diagnosisprovided;

            }

            set
            {

                _diagnosisprovided = value;

            }

        }
        public string physician
        {

            get
            {

                return _physician;

            }



            set
            {

                _physician = value;

            }

        }

        public DateTime dt
        {

            get
            {

                return _dt;

            }



            set
            {

                _dt = value;

            }

        }



        public string followup
        {

            get
            {

                return _followup;

            }

            set
            {

                _followup = value;

            }

        }
        public DateTime followupdate
        {

            get
            {

                return _followupdate;

            }

            set
            {

                _followupdate = value;

            }

        }
        public string card
        {

            get
            {

                return _card;

            }

            set
            {

                _card = value;

            }

        }
        public string mode
        {

            get
            {

                return _mode;

            }

            set
            {

                _mode = value;

            }

        }
        public string bill
        {

            get
            {

                return _bill;

            }

            set
            {

                _bill = value;

            }

        }



    }

}
