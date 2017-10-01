using CSSPEnums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSSPModels
{
    [NotMapped]
    public partial class AppTaskParameter : Error
    {
        #region Properties in DB
        #endregion Properties in DB

        #region Properties not in DB
        [StringLength(255)]
        public string Name { get; set; }
        [StringLength(255)]
        public string Value { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public AppTaskParameter() : base()
        {
        }
        #endregion Constructors
    }
}
