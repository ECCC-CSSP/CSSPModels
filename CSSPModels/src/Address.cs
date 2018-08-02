/*
 * Manually edited by Charles LeBlanc 
 * 
 */
using CSSPEnums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSSPModels
{
    public partial class Address : LastUpdate
    {
        #region Properties in DB
        [Key]
        [CSSPDisplayEN(DisplayEN = "Address ID")]
        [CSSPDisplayFR(DisplayFR = "Address ID")]
        [CSSPDescriptionEN(DescriptionEN = @"Contains the unique ""identifier on each row of the Addresses table")]
        [CSSPDescriptionFR(DescriptionFR = @"Contient l'identifiant unique sur chaque ligne du tableau Adresses")]
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
        [StringLength(200)]
        [CSSPAllowNull]
        public string StreetName { get; set; }
        [StringLength(50)]
        [CSSPAllowNull]
        public string StreetNumber { get; set; }
        [CSSPEnumType]
        [CSSPAllowNull]
        public StreetTypeEnum? StreetType { get; set; }
        [StringLength(11, MinimumLength = 6)]
        [CSSPAllowNull]
        public string PostalCode { get; set; }
        [StringLength(200, MinimumLength = 10)]
        [CSSPAllowNull]
        public string GoogleAddressText { get; set; }
        #endregion Properties in DB

        #region Properties not in DB
        [NotMapped]
        [CSSPAllowNull]
        public AddressWeb AddressWeb { get; set; }
        [NotMapped]
        [CSSPAllowNull]
        public AddressReport AddressReport { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public Address() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class AddressWeb
    {
        #region Properties for web information
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "AddressTVItemID", FillReturnField = "", FillNeedLanguage = true)]
        public TVItemLanguage AddressTVItemLanguage { get; set; }
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "CountryTVItemID", FillReturnField = "", FillNeedLanguage = true)]
        public TVItemLanguage CountryTVItemLanguage { get; set; }
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "ProvinceTVItemID", FillReturnField = "", FillNeedLanguage = true)]
        public TVItemLanguage ProvinceTVItemLanguage { get; set; }
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "MunicipalityTVItemID", FillReturnField = "", FillNeedLanguage = true)]
        public TVItemLanguage MunicipalityTVItemLanguage { get; set; }
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "", FillNeedLanguage = true)]
        public TVItemLanguage LastUpdateContactTVItemLanguage { get; set; }
        [CSSPEnumTypeText(EnumTypeName = "AddressTypeEnum", EnumType = "AddressType")]
        [CSSPAllowNull]
        public string AddressTypeText { get; set; }
        [CSSPEnumTypeText(EnumTypeName = "StreetTypeEnum", EnumType = "StreetType")]
        [CSSPAllowNull]
        public string StreetTypeText { get; set; }
        #endregion Properties for web information

        #region Constructors
        public AddressWeb()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class AddressReport
    {
        #region Properties for report information
        [CSSPAllowNull]
        public string AddressReportTest { get; set; }
        #endregion Properties for report information

        #region Constructors
        public AddressReport()
        {
        }
        #endregion Constructors
    }
}
