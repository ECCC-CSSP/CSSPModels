﻿/*
 * Manually edited by Charles LeBlanc 
 * 
 */
using CSSPEnums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace CSSPModels
{
    [NotMapped]
    public partial class Search : Error
    {
        #region Properties in DB
        #endregion Properties in DB

        #region Properties not in DB
        [StringLength(255, MinimumLength = 1)]
        public string value { get; set; }
        [Range(1, -1)]
        public int id { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public Search() : base()
        {
        }
        #endregion Constructors
    }
}
