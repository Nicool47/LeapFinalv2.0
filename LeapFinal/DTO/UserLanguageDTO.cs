using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LeapFinal.DTO
{
    public class UserLanguageDTO
    {
        public string UserEmailId { get; set; }
        public int LanguageId { get; set; }

        
        public int ProficiencyLevel { get; set; }
    }
}