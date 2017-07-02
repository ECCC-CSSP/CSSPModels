using CSSPEnums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSSPModels
{
    [NotMapped]
    public partial class SubsectorMWQMSampleYear
    {
        #region Properties in DB
        #endregion Properties in DB

        #region Properties not in DB
        [Required]
        [Range(1, -1)]
        public int SubsectorTVItemID { get; set; }
        public int Year { get; set; }
        public DateTime EarliestDate { get; set; }
        public DateTime LatestDate { get; set; }

        public IEnumerable<ValidationResult> ValidationResults { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public SubsectorMWQMSampleYear()
        {
            // empty for now
        }
        #endregion Constructors
    }
}
