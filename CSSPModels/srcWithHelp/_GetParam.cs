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
        [CSSPEnumType]
        public LanguageEnum Language { get; set; }
        [Range(0, -1)]
        public int Skip { get; set; }
        [Range(0, -1)]
        public int Take { get; set; }
        public bool OrderAscending { get; set; }
        public EntityQueryDetailTypeEnum EntityQueryDetailType { get; set; }
        public EntityQueryTypeEnum EntityQueryType { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public GetParam() : base()
        {
            Language = LanguageEnum.en;
            Skip = 0;
            Take = 100;
            OrderAscending = true;
            EntityQueryDetailType = EntityQueryDetailTypeEnum.EntityOnly;
            EntityQueryType = EntityQueryTypeEnum.AsNoTracking;
        }
        #endregion Constructors

        #region Functions public
        public GetParam FillProp(string lang = "en", int skip = 0, int take = 100, bool orderAscending = true,
                  EntityQueryDetailTypeEnum EntityQueryDetailType = EntityQueryDetailTypeEnum.EntityOnly,
                  EntityQueryTypeEnum EntityQueryType = EntityQueryTypeEnum.AsNoTracking)
        {
            GetParam getParam = new GetParam();

            getParam.Language = (lang == "fr" ? LanguageEnum.fr : LanguageEnum.en);
            getParam.Skip = skip;
            getParam.Take = take;
            getParam.OrderAscending = orderAscending;
            getParam.EntityQueryDetailType = EntityQueryDetailType;
            getParam.EntityQueryType = EntityQueryType;

            return getParam;
        }
        #endregion Functions public
    }
}
