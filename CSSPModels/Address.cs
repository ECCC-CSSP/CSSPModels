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
        [Range(1, -1)]
        [CSSPExist(TypeName = "TVItem", Plurial = "s", FieldID = "TVItemID")]
        public int? AddressTVItemID { get; set; }
        [CSSPEnumType]
        public AddressTypeEnum AddressType { get; set; }
        [Range(1, -1)]
        [CSSPExist(TypeName = "TVItem", Plurial = "s", FieldID = "TVItemID")]
        public int CountryTVItemID { get; set; }
        [Range(1, -1)]
        [CSSPExist(TypeName = "TVItem", Plurial = "s", FieldID = "TVItemID")]
        public int ProvinceTVItemID { get; set; }
        [Range(1, -1)]
        [CSSPExist(TypeName = "TVItem", Plurial = "s", FieldID = "TVItemID")]
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
        [Range(1, -1)]
        [CSSPExist(TypeName = "TVItem", Plurial = "s", FieldID = "TVItemID")]
        public int LastUpdateContactTVItemID { get; set; }

        public virtual TVItem AddressTVItem { get; set; }
        public virtual TVItem CountryTVItem { get; set; }
        public virtual TVItem MunicipalityTVItem { get; set; }
        public virtual TVItem ProvinceTVItem { get; set; }
        #endregion Properties in DB

        #region Properties not in DB
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
