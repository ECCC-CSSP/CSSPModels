using CSSPEnums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSSPModels
{
    [NotMapped]
    public partial class LastUpdateAndContact : Error
    {
        #region Properties in DB
        #endregion Properties in DB

        #region Properties not in DB
        public string Err { get; set; }
        [CSSPAfter(Year = 1980)]
        public DateTime LastUpdateAndContactDate_UTC { get; set; }
        [Range(1, -1)]
        public int LastUpdateAndContactTVItemID { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public LastUpdateAndContact() : base()
        {
        }
        #endregion Constructors
    }
}
