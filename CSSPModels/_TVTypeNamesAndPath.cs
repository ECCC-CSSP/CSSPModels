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
        [Required]
        [Range(1, 255)]
        public string TVTypeName { get; set; }
        [Required]
        [Range(1, -1)]
        public int Index { get; set; }
        [Required]
        [Range(1, 255)]
        public string TVPath { get; set; }

        public IEnumerable<ValidationResult> ValidationResults { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public TVTypeNamesAndPath()
        {
            // empty for now
        }
        #endregion Constructors
    }
}
