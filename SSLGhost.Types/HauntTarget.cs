using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Web.Mvc;

namespace SSLGhost.Types
{
    public class HauntTarget
    {
        [Required]
        public string HumanName { get; set; }

        [Required]
        public int DaysToHaunt { get; set; }
    }
}
