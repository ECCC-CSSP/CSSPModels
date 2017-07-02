﻿using CSSPEnums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSSPModels
{
    [NotMapped]
    public partial class Vector
    {
        #region Properties in DB
        #endregion Properties in DB

        #region Properties not in DB

        public virtual Node StartNode { get; set; }
        public virtual Node EndNode { get; set; }
        public IEnumerable<ValidationResult> ValidationResults { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public Vector()
        {
        }
        #endregion Constructors
    }
}
