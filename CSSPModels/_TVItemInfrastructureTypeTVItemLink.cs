using CSSPEnums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSSPModels
{
    [NotMapped]
    public partial class TVItemInfrastructureTypeTVItemLink
    {
        #region Properties in DB
        #endregion Properties in DB

        #region Properties not in DB
        public InfrastructureTypeEnum InfrastructureType { get; set; }
        public int? SeeOtherTVItemID { get; set; }

        public virtual TVItem TVItem { get; set; }
        public virtual List<TVItemLink> TVItemLinkList { get; set; }
        public virtual TVItemInfrastructureTypeTVItemLink FlowTo { get; set; }
        public IEnumerable<ValidationResult> ValidationResults { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public TVItemInfrastructureTypeTVItemLink()
        {
            TVItemLinkList = new List<TVItemLink>();
        }
        #endregion Constructors
    }
}
