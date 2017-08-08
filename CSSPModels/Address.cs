using CSSPEnums;
using CSSPModels.Resources;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace CSSPModels
{

    public partial class Address
    {
        #region Properties in DB
        [Key]
        public int AddressID { get; set; }
        [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "2")]
        public int AddressTVItemID { get; set; }
        [CSSPEnumType]
        public AddressTypeEnum AddressType { get; set; }
        [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "6")]
        public int CountryTVItemID { get; set; }
        [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "18")]
        public int ProvinceTVItemID { get; set; }
        [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "15")]
        public int MunicipalityTVItemID { get; set; }
        [CSSPAllowNull]
        [StringLength(200)]
        public string StreetName { get; set; }
        [CSSPAllowNull]
        [StringLength(50)]
        public string StreetNumber { get; set; }
        [CSSPAllowNull]
        [CSSPEnumType]
        public StreetTypeEnum? StreetType { get; set; }
        [CSSPAllowNull]
        [StringLength(11, MinimumLength = 6)]
        public string PostalCode { get; set; }
        [CSSPAllowNull]
        [StringLength(200, MinimumLength = 10)]
        public string GoogleAddressText { get; set; }
        [CSSPAfter(Year = 1980)]
        public DateTime LastUpdateDate_UTC { get; set; }
        [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "5")]
        public int LastUpdateContactTVItemID { get; set; }
        #endregion Properties in DB

        #region Properties not in DB
        [NotMapped]
        [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "1,10,5,17")]
        [CSSPFill(FillTypeName = "TVItem", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "AddressTVItemID", FillReturnField = "ParentID", FillNeedLanguage = false)]
        public int ParentTVItemID { get; set; }
        [NotMapped]
        [StringLength(200)]
        [CSSPAllowNull]
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "AddressTVItemID", FillReturnField = "TVText", FillNeedLanguage = true)]
        public string AddressTVText { get; set; }
        [NotMapped]
        [StringLength(200)]
        [CSSPAllowNull]
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "CountryTVItemID", FillReturnField = "TVText", FillNeedLanguage = true)]
        public string CountryTVText { get; set; }
        [NotMapped]
        [StringLength(200)]
        [CSSPAllowNull]
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "ProvinceTVItemID", FillReturnField = "TVText", FillNeedLanguage = true)]
        public string ProvinceTVText { get; set; }
        [NotMapped]
        [StringLength(200)]
        [CSSPAllowNull]
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "MunicipalityTVItemID", FillReturnField = "TVText", FillNeedLanguage = true)]
        public string MunicipalityTVText { get; set; }
        [NotMapped]
        [StringLength(200)]
        [CSSPAllowNull]
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "TVText", FillNeedLanguage = true)]
        public string LastUpdateContactTVText { get; set; }
        [NotMapped]
        [StringLength(100)]
        [CSSPAllowNull]
        [CSSPEnumTypeText(EnumTypeName = "AddressTypeEnum", EnumType = "AddressType")]
        public string AddressTypeText { get; set; }
        [NotMapped]
        [StringLength(100)]
        [CSSPAllowNull]
        [CSSPEnumTypeText(EnumTypeName = "StreetTypeEnum", EnumType = "StreetType")]
        public string StreetTypeText { get; set; }
        [NotMapped]
        public IEnumerable<ValidationResult> ValidationResults { get; set; }
        #endregion Properties not id DB

        #region Constructors
        public Address()
        {
            // empty for now
        }
        #endregion Constructors
    }
}
