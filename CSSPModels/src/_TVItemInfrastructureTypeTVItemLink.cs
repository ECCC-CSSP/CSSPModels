using CSSPEnums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSSPModels
{
    [NotMapped]
    public partial class TVItemInfrastructureTypeTVItemLink : Error
    {
        #region Properties in DB
        #endregion Properties in DB

        #region Properties not in DB
        [CSSPEnumType]
        public InfrastructureTypeEnum InfrastructureType { get; set; }
        [CSSPAllowNull]
        public int? SeeOtherTVItemID { get; set; }
        [StringLength(100)]
        [CSSPEnumTypeText(EnumTypeName = "InfrastructureTypeEnum", EnumType = "InfrastructureType")]
        [CSSPAllowNull]
        public string InfrastructureTypeText { get; set; }
        public virtual TVItem TVItem { get; set; }
        public virtual List<TVItemLink> TVItemLinkList { get; set; }
        public virtual TVItemInfrastructureTypeTVItemLink FlowTo { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public TVItemInfrastructureTypeTVItemLink() : base()
        {
            TVItemLinkList = new List<TVItemLink>();
        }
        #endregion Constructors
    }
}
