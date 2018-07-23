using CSSPEnums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSSPModels
{
    [NotMapped]
    public partial class DBTable : Error
    {
        #region Properties in DB
        #endregion Properties in DB

        #region Properties not in DB
        [StringLength(200, MinimumLength = 1)]
        public string TableName { get; set; }
        [StringLength(3, MinimumLength = 1)]
        public string Plurial { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public DBTable() : base()
        {
        }
        #endregion Constructors
    }
}
