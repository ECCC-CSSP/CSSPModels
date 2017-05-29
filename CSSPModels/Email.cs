using CSSPEnums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSSPModels
{
    public partial class Email
    {
        #region Properties in DB
        public int EmailID { get; set; }
        public int EmailTVItemID { get; set; }
        public string EmailAddress { get; set; }
        public EmailTypeEnum EmailType { get; set; }
        public DateTime LastUpdateDate_UTC { get; set; }
        public int LastUpdateContactTVItemID { get; set; }

        public virtual TVItem EmailTVItem { get; set; }
        #endregion Properties in DB

        #region Properties not in DB
        [NotMapped]
        public IEnumerable<ValidationResult> ValidationResults { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public Email()
        {
            // empty for now
        }
        #endregion Constructors
    }
}
