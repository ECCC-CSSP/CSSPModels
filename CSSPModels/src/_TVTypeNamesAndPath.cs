﻿/*
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
    public partial class TVTypeNamesAndPath : Error
    {
        #region Properties in DB
        #endregion Properties in DB

        #region Properties not in DB
        [StringLength(255, MinimumLength = 1)]
        public string TVTypeName { get; set; }
        [Range(1, -1)]
        public int Index { get; set; }
        [StringLength(255, MinimumLength = 1)]
        public string TVPath { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public TVTypeNamesAndPath() : base()
        {
        }
        #endregion Constructors
    }
}
