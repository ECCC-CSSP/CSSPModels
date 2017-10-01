using CSSPEnums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSSPModels
{
    [NotMapped]
    public partial class TVFullText : Error
    {
        #region Properties in DB
        #endregion Properties in DB

        #region Properties not in DB
        [StringLength(255, MinimumLength = 1)]
        public string TVPath { get; set; }
        [StringLength(255, MinimumLength = 1)]
        public string FullText { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public TVFullText() : base()
        {
        }
        #endregion Constructors
    }
}
