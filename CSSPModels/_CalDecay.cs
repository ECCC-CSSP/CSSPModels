using CSSPEnums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSSPModels
{
    [NotMapped]
    public partial class CalDecay
    {
        #region Properties in DB
        #endregion Properties in DB

        #region Properties not in DB
        [Range(0, 255)]
        public string Error { get; set; }
        [Required]
        [Range(0.0D, -1.0D)]
        public double Decay { get; set; }

        public IEnumerable<ValidationResult> ValidationResults { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public CalDecay()
        {
            Error = "";
        }
        #endregion Constructors
    }
}
