using CSSPEnums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSSPModels
{
    [NotMapped]
    public partial class ContactOK : Error
    {
        #region Properties in DB
        #endregion Properties in DB

        #region Properties not in DB
        [StringLength(255)]
        public string Error { get; set; }
        [Range(1, -1)]
        public int ContactID { get; set; }
        [Range(1, -1)]
        public int ContactTVItemID { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public ContactOK() : base()
        {
        }
        #endregion Constructors
    }
}
