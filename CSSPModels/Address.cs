using CSSPEnums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSSPModels
{
    /// <summary>
    /// >    Entity object for Addresses DB Table
    /// >   <c>[CSSPServices.AddressService] (CSSPServices.AddressService.html)</c>
    /// </summary>
    public partial class Address
    {
        #region Properties in DB
        /// <summary>
        /// > Unique DB ID for the Addresses DB Table
        /// </summary>
        [Key]
        public int AddressID { get; set; }
        /// <summary description="Relational ID to the TVItems DB Table pointing to the Address">
        ///  Relational ID to the TVItems DB Table pointing to the Address
        ///  
        /// See also: <seealso cref="TVItem"/>
        /// </summary>
        // AllowableTVTypeList TVTypeEnum.Address
        [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "2")]
        public int AddressTVItemID { get; set; }
        /// <summary>
        /// Address type
        /// See Also: <c>[CSSPEnums.AddressTypeEnum] (CSSPEnums.AddressTypeEnum.html)</c>
        /// <remarks>
        /// <para>Allowable types</para>
        /// <code>
        ///     public enum AddressTypeEnum
        ///     {
        ///         Error = 0,
        ///         Mailing = 1,
        ///         Shipping = 2,
        ///         Civic = 3,
        ///     }
        /// </code>
        /// </remarks>
        /// </summary>
        [CSSPEnumType]
        public AddressTypeEnum AddressType { get; set; }
        /// <summary>
        /// >   Relational ID to the TVItems DB Table pointing to the Country
        /// >   
        /// >   CSSP Attribute:
        /// >   
        /// >   <code>[CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "6")]</code>
        /// </summary>
        // AllowableTVTypeList TVTypeEnum.Country
        [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "6")]
        public int CountryTVItemID { get; set; }
        /// <summary>
        ///     Relational ID to the TVItems DB Table pointing to the Province
        /// </summary>
        // AllowableTVTypeList TVTypeEnum.Province
        [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "18")]
        public int ProvinceTVItemID { get; set; }
        /// <summary>
        ///     Relational ID to the TVItems DB Table pointing to the Municipatlity
        /// </summary>
        // AllowableTVTypeList TVTypeEnum.Municipality
        [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "15")]
        public int MunicipalityTVItemID { get; set; }
        [CSSPAllowNull]
        [StringLength(200)]
        public string StreetName { get; set; }
        /// <summary>
        ///     Street number for the address
        /// </summary>
        [CSSPAllowNull]
        [StringLength(50)]
        public string StreetNumber { get; set; }
        /// <summary>
        /// <remarks>
        /// <para>Allowable types</para>
        /// <code>
        ///     public enum StreetTypeEnum
        ///     {
        ///         Error = 0,
        ///         Street = 1,
        ///         Road = 2,
        ///         Avenue = 3,
        ///         Crescent = 4,
        ///         Court = 5,
        ///         Alley = 6,
        ///         Drive = 7,
        ///         Blvd = 8,
        ///         Route = 9,
        ///     }
        /// </code>
        /// </remarks>
        /// </summary>
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
        // AllowableTVTypeList TVTypeEnum.Contact
        [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "5")]
        public int LastUpdateContactTVItemID { get; set; }
        #endregion Properties in DB

        #region Properties not in DB
        [NotMapped]
        // AllowableTVTypeList TVTypeEnum.Root, TVTypeEnum.Infrastructure, TVTypeEnum.Contact, TVTypeEnum.PolSourceSite
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
        public bool HasErrors { get; set; }
        [NotMapped]
        public IEnumerable<ValidationResult> ValidationResults { get; set; }
        #endregion Properties not id DB

        #region Constructors
        public Address()
        {
            ValidationResults = new List<ValidationResult>();
        }
        #endregion Constructors
    }
}
