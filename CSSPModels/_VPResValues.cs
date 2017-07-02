using CSSPEnums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSSPModels
{
    [NotMapped]
    public partial class VPResValues
    {
        #region Properties in DB
        #endregion Properties in DB

        #region Properties not in DB
        [Required]
        [Range(0, -1)]
        public int Conc { get; set; }
        [Required]
        public double Dilu { get; set; }
        [Required]
        public double FarfieldWidth { get; set; }
        [Required]
        public double Distance { get; set; }
        [Required]
        public double TheTime { get; set; }
        [Required]
        public double Decay { get; set; }

        public IEnumerable<ValidationResult> ValidationResults { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public VPResValues()
        {
            // empty for now
        }
        #endregion Constructors
    }
}
