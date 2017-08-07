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
        [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "1,6,18,3,19,20,4,8,9,10,12,11,13,14,15,31,16,23,17,40,26,22")]
        public int FromTVItemID { get; set; }
        [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "1,6,18,3,19,20,4,8,9,10,12,11,13,14,15,31,16,23,17,40,26,22")]
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
        [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "1,6,18,3,19,20,4,8,9,10,12,11,13,14,15,31,16,23,17,40,26,22")]
        public int? ParentTVItemLinkID { get; set; }
        [CSSPAfter(Year = 1980)]
        public DateTime LastUpdateDate_UTC { get; set; }
        [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "5")]
        public int LastUpdateContactTVItemID { get; set; }
        #endregion Properties in DB

        #region Properties not in DB
        [NotMapped]
        [StringLength(100)]
        [CSSPAllowNull]
        [CSSPEnumTypeText(EnumTypeName = "TVTypeEnum", EnumType = "FromTVType")]
        public string FromTVTypeText { get; set; }
        [NotMapped]
        [StringLength(100)]
        [CSSPAllowNull]
        [CSSPEnumTypeText(EnumTypeName = "TVTypeEnum", EnumType = "ToTVType")]
        public string ToTVTypeText { get; set; }
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
