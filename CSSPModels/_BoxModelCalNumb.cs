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
        [Range(0, 255)]
        public string Error { get; set; }
        [Required]
        public BoxModelResultTypeEnum BoxModelResultType { get; set; }
        [Required]
        [Range(0.0f, -1.0f)]
        public float CalLength_m { get; set; }
        [Required]
        [Range(0.0f, -1.0f)]
        public float CalRadius_m { get; set; }
        [Required]
        [Range(0.0f, -1.0f)]
        public float CalSurface_m2 { get; set; }
        [Required]
        [Range(0.0f, -1.0f)]
        public float CalVolume_m3 { get; set; }
        [Required]
        [Range(0.0f, -1.0f)]
        public float CalWidth_m { get; set; }
        [Required]
        public bool FixLength { get; set; }
        [Required]
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
