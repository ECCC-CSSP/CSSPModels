﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSSPModels
{
    public partial class TideLocation
    {
        #region Properties in DB
        [Key]
        public int TideLocationID { get; set; }
        [Range(0, 10000)]
        public int Zone { get; set; }
        [StringLength(100)]
        public string Name { get; set; }
        [StringLength(100)]
        public string Prov { get; set; }
        [Range(0, 100000)]
        public int sid { get; set; }
        [Range(-90.0f, 90.0f)]
        public float Lat { get; set; }
        [Range(-180.0f, 180.0f)]
        public float Lng { get; set; }
        #endregion Properties in DB

        #region Properties not in DB
        [NotMapped]
        public IEnumerable<ValidationResult> ValidationResults { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public TideLocation()
        {
            // empty for now
        }
        #endregion Constructors
    }
}
