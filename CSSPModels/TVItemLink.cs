using CSSPEnums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSSPModels
{
    public partial class TVItemLink
    {
        #region Properties in DB
        public int TVItemLinkID { get; set; }
        public int FromTVItemID { get; set; }
        public int ToTVItemID { get; set; }
        public TVTypeEnum FromTVType { get; set; }
        public TVTypeEnum ToTVType { get; set; }
        public DateTime? StartDateTime_Local { get; set; }
        public DateTime? EndDateTime_Local { get; set; }
        public int Ordinal { get; set; }
        public int TVLevel { get; set; }
        public string TVPath { get; set; }
        public int? ParentTVItemLinkID { get; set; }
        [CSSPAfter(Year = 1980)]
        public DateTime LastUpdateDate_UTC { get; set; }
        [Range(1, -1)]
        [CSSPExist(TypeName = "TVItem", Plurial = "s", FieldID = "TVItemID")]
        public int LastUpdateContactTVItemID { get; set; }

        public virtual TVItem FromTVItem { get; set; }
        public virtual TVItemLink ParentTVItemLink { get; set; }
        public virtual ICollection<TVItemLink> InverseParentTVItemLink { get; set; }
        public virtual TVItem ToTVItem { get; set; }
        #endregion Properties in DB

        #region Properties not in DB
        [NotMapped]
        public IEnumerable<ValidationResult> ValidationResults { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public TVItemLink()
        {
            // empty for now
        }
        #endregion Constructors
    }
}
