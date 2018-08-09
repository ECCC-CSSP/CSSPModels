/*
 * Manually edited by Charles LeBlanc 
 * 
 */
using CSSPEnums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace CSSPModels
{
    [NotMapped]
    public partial class ContactSearch : Error
    {
        #region Properties in DB
        #endregion Properties in DB

        #region Properties not in DB
        [Range(1, -1)]
        public int ContactID { get; set; }
        [Range(1, -1)]
        public int ContactTVItemID { get; set; }
        [StringLength(255)]
        public string FullName { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public ContactSearch() : base()
        {
        }
        #endregion Constructors
    }
}
