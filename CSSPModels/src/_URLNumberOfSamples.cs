using CSSPEnums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSSPModels
{
    [NotMapped]
    public partial class URLNumberOfSamples : Error
    {
        #region Properties in DB
        #endregion Properties in DB

        #region Properties not in DB
        [StringLength(255, MinimumLength = 1)]
        public string url { get; set; }
        public int NumberOfSamples { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public URLNumberOfSamples() : base()
        {
        }
        #endregion Constructors
    }
}
