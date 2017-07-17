using CSSPEnums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSSPModels
{
    public partial class Contact
    {
        #region Properties in DB
        [Key]
        public int ContactID { get; set; }
        [Range(1, -1)]
        [CSSPExist(TypeName = "TVItem", Plurial = "s", FieldID = "TVItemID")]
        public int ContactTVItemID { get; set; }
        [StringLength(255, MinimumLength = 6)]
        public string LoginEmail { get; set; }
        [StringLength(100)]
        public string FirstName { get; set; }
        [StringLength(100)]
        public string LastName { get; set; }
        [CSSPAllowNull]
        [StringLength(50)]
        public string Initial { get; set; }
        [StringLength(100)]
        public string WebName { get; set; }
        [CSSPAllowNull]
        [CSSPEnumType]
        public ContactTitleEnum? ContactTitle { get; set; }
        public bool IsAdmin { get; set; }
        public bool EmailValidated { get; set; }
        public bool Disabled { get; set; }
        public bool IsNew { get; set; }
        [CSSPAllowNull]
        public string SamplingPlanner_ProvincesTVItemID { get; set; }
        [CSSPAfter(Year = 1980)]
        public DateTime LastUpdateDate_UTC { get; set; }
        [Range(1, -1)]
        [CSSPExist(TypeName = "TVItem", Plurial = "s", FieldID = "TVItemID")]
        public int LastUpdateContactTVItemID { get; set; }

        public virtual ICollection<ContactLogin> ContactLogins { get; set; }
        public virtual ICollection<ContactPreference> ContactPreferences { get; set; }
        public virtual ICollection<ContactShortcut> ContactShortcuts { get; set; }
        public virtual TVItem ContactTVItem { get; set; }
        //public virtual AspNetUser IdNavigation { get; set; }
        #endregion Properties in DB

        #region Properties not in DB
        [NotMapped]
        [Required]
        [Range(1, -1)]
        public int ParentTVItemID { get; set; }
        [NotMapped]
        public IEnumerable<ValidationResult> ValidationResults { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public Contact()
        {
            ContactLogins = new HashSet<ContactLogin>();
            ContactPreferences = new HashSet<ContactPreference>();
            ContactShortcuts = new HashSet<ContactShortcut>();
        }
        #endregion Constructors
    }
}
