using CSSPEnums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSSPModels
{
    [NotMapped]
    public partial class CSSPMPNTable
    {
        #region Properties in DB
        #endregion Properties in DB

        #region Properties not in DB
        [Required]
        [Range(0, 5)]
        public int Tube10 { get; set; }
        [Required]
        [Range(0, 5)]
        public int Tube1_0 { get; set; }
        [Required]
        [Range(0, 5)]
        public int Tube0_1 { get; set; }
        [Required]
        [Range(0, 100000000)]
        public int MPN { get; set; }

        public IEnumerable<ValidationResult> ValidationResults { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public CSSPMPNTable()
        {
            // empty for now
        }
        #endregion Constructors
    }
}
