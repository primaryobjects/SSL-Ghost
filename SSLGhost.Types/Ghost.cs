using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace SSLGhost.Types
{
    public class Ghost
    {
        [Required]
        public string Name { get; set; }

        [Required, DataType(DataType.Password)]
        public string SkeletonKey { get; set; }

        public string Status { get; set; }
    }
}
