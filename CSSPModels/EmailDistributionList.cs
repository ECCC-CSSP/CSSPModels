using CSSPEnums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSSPModels
{
    public partial class EmailDistributionList
    {
        #region Properties in DB
        [Key]
        public int EmailDistributionListID { get; set; }
        [CSSPExist(TypeName = "TVItem", Plurial = "s", FieldID = "TVItemID", TVType = TVTypeEnum.Country)]
        public int CountryTVItemID { get; set; }
        [StringLength(100)]
        public string RegionName { get; set; }
        [Range(0, 1000)]
        public int Ordinal { get; set; }
        [CSSPAfter(Year = 1980)]
        public DateTime LastUpdateDate_UTC { get; set; }
        [CSSPExist(TypeName = "TVItem", Plurial = "s", FieldID = "TVItemID", TVType = TVTypeEnum.Contact)]
        public int LastUpdateContactTVItemID { get; set; }

        public virtual TVItem CountryTVItem { get; set; }
        public virtual ICollection<EmailDistributionListContact> EmailDistributionListContacts { get; set; }
        #endregion Properties in DB

        #region Properties not in DB
        [NotMapped]
        public IEnumerable<ValidationResult> ValidationResults { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public EmailDistributionList()
        {
            EmailDistributionListContacts = new HashSet<EmailDistributionListContact>();
        }
        #endregion Constructors
    }
}
