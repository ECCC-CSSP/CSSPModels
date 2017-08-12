using CSSPEnums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSSPModels
{
    [NotMapped]
    public partial class TVTypeNamesAndPath
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

        public bool HasErrors { get; set; }
        public IEnumerable<ValidationResult> ValidationResults { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public TVTypeNamesAndPath()
        {
            ValidationResults = new List<ValidationResult>();
        }
        #endregion Constructors
    }
}
