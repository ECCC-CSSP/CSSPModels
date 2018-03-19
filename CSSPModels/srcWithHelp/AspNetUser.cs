using CSSPEnums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSSPModels
{
    public partial class AspNetUser : Error
    {
        #region Properties in DB
        [Key]
        [StringLength(128)]
        public string Id { get; set; }
        [StringLength(256)]
        [CSSPAllowNull]
        public string Email { get; set; }
        public bool EmailConfirmed { get; set; }
        [StringLength(256)]
        [CSSPAllowNull]
        public string PasswordHash { get; set; }
        [StringLength(256)]
        [CSSPAllowNull]
        public string SecurityStamp { get; set; }
        [StringLength(256)]
        [CSSPAllowNull]
        public string PhoneNumber { get; set; }
        public bool PhoneNumberConfirmed { get; set; }
        public bool TwoFactorEnabled { get; set; }
        [CSSPAfter(Year = 1980)]
        public DateTime? LockoutEndDateUtc { get; set; }
        public bool LockoutEnabled { get; set; }
        [Range(0, 10000)]
        public int AccessFailedCount { get; set; }
        [StringLength(256)]
        public string UserName { get; set; }
        #endregion Properties in DB

        #region Properties not in DB
        #endregion Properties not in DB

        #region Constructors
        public AspNetUser()
        {
        }
        #endregion Constructors
    }
}
