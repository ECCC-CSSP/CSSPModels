/*
 * Manually edited by Charles LeBlanc 
 * 
 */
using CSSPEnums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSSPModels
{
    [NotMapped]
    public partial class Vector : Error
    {
        #region Properties in DB
        #endregion Properties in DB

        #region Properties not in DB
        public virtual Node StartNode { get; set; }
        public virtual Node EndNode { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public Vector() : base()
        {
        }
        #endregion Constructors
    }
}
