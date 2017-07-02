using CSSPEnums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSSPModels
{
    [NotMapped]
    public partial class Coord
    {
        #region Properties in DB
        #endregion Properties in DB

        #region Properties not in DB
        [Required]
        [Range(-180.0f, 180.0f)]
        public float Lat { get; set; }
        [Required]
        [Range(-90.0f, 90.0f)]
        public float Lng { get; set; }
        [Required]
        [Range(0, 10000)]
        public int Ordinal { get; set; }

        public IEnumerable<ValidationResult> ValidationResults { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public Coord()
        {
            // empty for now
        }
        #endregion Constructors
    }
}
