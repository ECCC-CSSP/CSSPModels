using CSSPEnums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSSPModels
{
    [NotMapped]
    public partial class BoxModelCalNumb
    {
        #region Properties in DB
        #endregion Properties in DB

        #region Properties not in DB
        [StringLength(255)]
        public string Error { get; set; }
        [CSSPEnumType]
        public BoxModelResultTypeEnum BoxModelResultType { get; set; }
        [Range(0.0D, -1.0D)]
        public double CalLength_m { get; set; }
        [Range(0.0D, -1.0D)]
        public double CalRadius_m { get; set; }
        [Range(0.0D, -1.0D)]
        public double CalSurface_m2 { get; set; }
        [Range(0.0D, -1.0D)]
        public double CalVolume_m3 { get; set; }
        [Range(0.0D, -1.0D)]
        public double CalWidth_m { get; set; }
        public bool FixLength { get; set; }
        public bool FixWidth { get; set; }

        public IEnumerable<ValidationResult> ValidationResults { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public BoxModelCalNumb()
        {
            // empty for now
        }
        #endregion Constructors
    }
}
