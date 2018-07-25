using CSSPEnums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSSPModels
{
    [NotMapped]
    public partial class Query : Error
    {
        #region Properties in DB
        #endregion Properties in DB

        #region Properties not in DB
        public Type ModelType { get; set; }
        [CSSPEnumType]
        public LanguageEnum Language { get; set; }
        [StringLength(2)]
        public string Lang { get; set; }
        [Range(0, 1000000)]
        public int Skip { get; set; }
        [Range(1, 1000000)]
        public int Take { get; set; }
        [StringLength(200)]
        public string Order { get; set; }
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
        public Query() : base()
        {
            Language = LanguageEnum.en;
            Lang = "en";
            Skip = 0;
            Take = 100;
            Order = "";
            Where = "";
            EntityQueryDetailType = EntityQueryDetailTypeEnum.EntityOnly;
            EntityQueryType = EntityQueryTypeEnum.AsNoTracking;
            OrderList = new List<string>();
            WhereInfoList = new List<WhereInfo>();
        }
        #endregion Constructors
    }
}
