﻿using CSSPEnums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSSPModels
{
    [NotMapped]
    public partial class PolyPoint
    {
        #region Properties in DB
        #endregion Properties in DB

        #region Properties not in DB
        [Range(-180.0f, 180.0f)]
        public float XCoord { get; set; }
        [Range(-90.0f, 90.0f)]
        public float YCoord { get; set; }
        public float Z { get; set; }

        public IEnumerable<ValidationResult> ValidationResults { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public PolyPoint()
        {
            // empty for now
        }
        #endregion Constructors
    }
}
