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
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property, AllowMultiple = false, Inherited = true)]
    public class CSSPTypeAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            return true;
        }
    }

    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property, AllowMultiple = false, Inherited = true)]
    public class CSSPObjectExistAttribute : ValidationAttribute
    {
        public string TableName { get; set; }

        public override bool IsValid(object value)
        {
            return true;
        }
    }

    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property, AllowMultiple = false, Inherited = true)]
    public class CSSPDateAfterYear : ValidationAttribute
    {
        public int Year { get; set; }

        public override bool IsValid(object value)
        {
            return true;
        }
    }

    public partial class Address
    {
        #region Properties in DB
        [Key]
        public int AddressID { get; set; }
        [Required]
        [Range(1, -1)]
        [CSSPObjectExist(TableName = "TVItems")]
        public int AddressTVItemID { get; set; }
        [Required]
        [CSSPType]
        public AddressTypeEnum AddressType { get; set; }
        [Required]
        [Range(1, -1)]
        [CSSPObjectExist(TableName = "TVItems")]
        public int CountryTVItemID { get; set; }
        [Required]
        [Range(1, -1)]
        [CSSPObjectExist(TableName = "TVItems")]
        public int ProvinceTVItemID { get; set; }
        [Required]
        [Range(1, -1)]
        [CSSPObjectExist(TableName = "TVItems")]
        public int MunicipalityTVItemID { get; set; }
        [StringLength(200, MinimumLength = 1)]
        public string StreetName { get; set; }
        [StringLength(50, MinimumLength = 1)]
        public string StreetNumber { get; set; }
        [CSSPType]
        public StreetTypeEnum? StreetType { get; set; }
        [StringLength(11, MinimumLength = 6)]
        public string PostalCode { get; set; }
        [StringLength(200, MinimumLength = 1)]
        public string GoogleAddressText { get; set; }
        [Required]
        [CSSPDateAfterYear(Year = 1980)]
        public DateTime LastUpdateDate_UTC { get; set; }
        [Required]
        [Range(1, -1)]
        [CSSPObjectExist(TableName = "TVItems")]
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
