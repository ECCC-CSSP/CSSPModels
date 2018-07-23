using CSSPEnums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSSPModels
{
    [NotMapped]
    public partial class GetParam : Error
    {
        #region Properties in DB
        #endregion Properties in DB

        #region Properties not in DB
        public Type ModelType { get; set; }
        [CSSPEnumType]
        public LanguageEnum Language { get; set; }
        [StringLength(2)]
        public string Lang { get; set; }
        [Range(0, -1)]
        public int Skip { get; set; }
        [Range(0, -1)]
        public int Take { get; set; }
        [StringLength(200)]
        public string OrderByNames { get; set; }
        [StringLength(200)]
        public string Where { get; set; }
        [CSSPEnumType]
        public EntityQueryDetailTypeEnum EntityQueryDetailType { get; set; }
        [CSSPEnumType]
        public EntityQueryTypeEnum EntityQueryType { get; set; }
        public virtual List<string> OrderList { get; set; }
        public virtual List<WhereInfo> WhereInfoList { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public GetParam() : base()
        {
            ModelType = null;
            Language = LanguageEnum.en;
            Lang = "";
            Skip = 0;
            Take = 100;
            OrderByNames = "";
            Where = "";
            EntityQueryDetailType = EntityQueryDetailTypeEnum.EntityOnly;
            EntityQueryType = EntityQueryTypeEnum.AsNoTracking;
            OrderList = new List<string>();
            WhereInfoList = new List<WhereInfo>();
        }
        #endregion Constructors
    }
}
