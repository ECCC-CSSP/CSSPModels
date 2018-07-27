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
    public partial class PolSourceInactiveReasonEnumTextAndID : Error
    {
        #region Properties in DB
        #endregion Properties in DB

        #region Properties not in DB
        public string Text { get; set; }
        [Range(1, -1)]
        public int ID { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public PolSourceInactiveReasonEnumTextAndID() : base()
        {
        }
        #endregion Constructors
    }
}
