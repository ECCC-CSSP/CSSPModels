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
        [Key]
        public int TVItemLinkID { get; set; }
        [Range(1, -1)]
        [CSSPExist(TypeName = "TVItem", Plurial = "s", FieldID = "TVItemID", TVType = TVTypeEnum.Error)]
        public int FromTVItemID { get; set; }
        [Range(1, -1)]
        [CSSPExist(TypeName = "TVItem", Plurial = "s", FieldID = "TVItemID", TVType = TVTypeEnum.Error)]
        public int ToTVItemID { get; set; }
        [CSSPEnumType]
        public TVTypeEnum FromTVType { get; set; }
        [CSSPEnumType]
        public TVTypeEnum ToTVType { get; set; }
        [CSSPAfter(Year = 1980)]
        public DateTime? StartDateTime_Local { get; set; }
        [CSSPBigger(OtherField = "StartDateTime_Local")]
        [CSSPAfter(Year = 1980)]
        public DateTime? EndDateTime_Local { get; set; }
        [Range(0, 100)]
        public int Ordinal { get; set; }
        [Range(0, 100)]
        public int TVLevel { get; set; }
        [StringLength(250)]
        public string TVPath { get; set; }
        [Range(1, -1)]
        [CSSPExist(TypeName = "TVItem", Plurial = "s", FieldID = "TVItemID", TVType = TVTypeEnum.Error)]
        public int? ParentTVItemLinkID { get; set; }
        [CSSPAfter(Year = 1980)]
        public DateTime LastUpdateDate_UTC { get; set; }
        [Range(1, -1)]
        [CSSPExist(TypeName = "TVItem", Plurial = "s", FieldID = "TVItemID", TVType = TVTypeEnum.Contact)]
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
