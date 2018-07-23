using CSSPEnums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSSPModels
{
    [NotMapped]
    public partial class CalDecay : Error
    {
        #region Properties in DB
        #endregion Properties in DB

        #region Properties not in DB
        [StringLength(255)]
        [CSSPAllowNull]
        public string Error { get; set; }
        [Range(0.0D, -1.0D)]
        public double Decay { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public CalDecay() : base()
        {
            Error = "";
        }
        #endregion Constructors
    }
}
