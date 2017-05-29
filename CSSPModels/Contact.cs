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
        public int ContactID { get; set; }
        public string Id { get; set; }
        public int ContactTVItemID { get; set; }
        public string LoginEmail { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Initial { get; set; }
        public string WebName { get; set; }
        public ContactTitleEnum? ContactTitle { get; set; }
        public bool IsAdmin { get; set; }
        public bool EmailValidated { get; set; }
        public bool Disabled { get; set; }
        public bool IsNew { get; set; }
        public string SamplingPlanner_ProvincesTVItemID { get; set; }
        public DateTime LastUpdateDate_UTC { get; set; }
        public int LastUpdateContactTVItemID { get; set; }
              
        public virtual ICollection<ContactPreference> ContactPreferences { get; set; }
        public virtual ICollection<ContactShortcut> ContactShortcuts { get; set; }
        public virtual TVItem ContactTVItem { get; set; }
        public virtual AspNetUser IdNavigation { get; set; }
        #endregion Properties in DB

        #region Properties not in DB
        [NotMapped]
        [Required]
        [Range(6, 100)]
        public string Password { get; set; }
        [NotMapped]
        [Required]
        [Range(6, 100)]
        public string ConfirmPassword { get; set; }
        [NotMapped]
        [Required]
        [Range(1, -1)] // -1 == no upper limit
        public int ParentTVItemID { get; set; }
        [NotMapped]
        public IEnumerable<ValidationResult> ValidationResults { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public Contact()
        {
            ContactPreferences = new HashSet<ContactPreference>();
            ContactShortcuts = new HashSet<ContactShortcut>();
        }
        #endregion Constructors
    }
}
