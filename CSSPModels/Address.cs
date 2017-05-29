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
        public int AddressID { get; set; }
        public int AddressTVItemID { get; set; }
        public AddressTypeEnum AddressType { get; set; }
        public int CountryTVItemID { get; set; }
        public int ProvinceTVItemID { get; set; }
        public int MunicipalityTVItemID { get; set; }
        public string StreetName { get; set; }
        public string StreetNumber { get; set; }
        public StreetTypeEnum? StreetType { get; set; }
        public string PostalCode { get; set; }
        public string GoogleAddressText { get; set; }
        public DateTime LastUpdateDate_UTC { get; set; }
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
