using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityRules_day14_Interface_Project.Fuctionality
{
    internal interface IUniversityRules
    {
        // Rules and Regulations Declare by Director ....

        // By Default They All are Abstract or Public ....
        void IdCard();
        void Timings();
        void Totalfess();
        void BookSConsultation();
    }
}
