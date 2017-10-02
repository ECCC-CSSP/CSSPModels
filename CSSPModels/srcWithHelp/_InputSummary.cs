using CSSPEnums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSSPModels
{
    [NotMapped]
    public partial class InputSummary : Error
    {
        #region Properties in DB
        #endregion Properties in DB

        #region Properties not in DB
        public string Error { get; set; }
        public string Summary { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public InputSummary() : base()
        {
        }
        #endregion Constructors
    }
}