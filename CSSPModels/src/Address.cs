﻿/*
 * Manually edited by Charles LeBlanc 
 * 
 */
using CSSPEnums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace CSSPModels
{
    public partial class Address : LastUpdate
    {
        #region Properties in DB
        [Key]
        [CSSPDisplayEN(DisplayEN = "Address ID")]
        [CSSPDisplayFR(DisplayFR = "Address ID")]
        [CSSPDescriptionEN(DescriptionEN = @"Contains the unique ""identifier on each row of the Addresses table")]
        [CSSPDescriptionFR(DescriptionFR = @"Contient l'identifiant unique sur chaque ligne de la table Adresses")]
        public int AddressID { get; set; }
        [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "2")]
        [CSSPDisplayEN(DisplayEN = "Address TVItemID")]
        [CSSPDisplayFR(DisplayFR = "Address TVItemID")]
        [CSSPDescriptionEN(DescriptionEN = @"Link to the TVItems table with the unique identifier")]
        [CSSPDescriptionFR(DescriptionFR = @"Lien à la table TVItems avec l'identifiant unique")]
        public int AddressTVItemID { get; set; }
        [CSSPEnumType]
        [CSSPDisplayEN(DisplayEN = "Address type")]
        [CSSPDisplayFR(DisplayFR = "Type d'address")]
        [CSSPDescriptionEN(DescriptionEN = @"Address type")]
        [CSSPDescriptionFR(DescriptionFR = @"Type d'adresse")]
        public AddressTypeEnum AddressType { get; set; }
        [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "6")]
        [CSSPDisplayEN(DisplayEN = "Country")]
        [CSSPDisplayFR(DisplayFR = "Pays")]
        [CSSPDescriptionEN(DescriptionEN = @"Link to the TVItems table representing the country")]
        [CSSPDescriptionFR(DescriptionFR = @"Lien à la table TVItems représentant le pays")]
        public int CountryTVItemID { get; set; }
        [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "18")]
        [CSSPDisplayEN(DisplayEN = "Province")]
        [CSSPDisplayFR(DisplayFR = "Province")]
        [CSSPDescriptionEN(DescriptionEN = @"Link to the TVItems table representing the province")]
        [CSSPDescriptionFR(DescriptionFR = @"Lien à la table TVItems représentant la province")]
        public int ProvinceTVItemID { get; set; }
        [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "15")]
        [CSSPDisplayEN(DisplayEN = "Municipality")]
        [CSSPDisplayFR(DisplayFR = "Municipalité")]
        [CSSPDescriptionEN(DescriptionEN = @"Link to the TVItems table representing the municipality")]
        [CSSPDescriptionFR(DescriptionFR = @"Lien à la table TVItems représentant la municipalité")]
        public int MunicipalityTVItemID { get; set; }
        [StringLength(200)]
        [CSSPAllowNull]
        [CSSPDisplayEN(DisplayEN = "Street name")]
        [CSSPDisplayFR(DisplayFR = "Nom de la rue")]
        [CSSPDescriptionEN(DescriptionEN = @"Street name of the address")]
        [CSSPDescriptionFR(DescriptionFR = @"Nom de la rue de l'adresse")]
        public string StreetName { get; set; }
        [StringLength(50)]
        [CSSPAllowNull]
        [CSSPDisplayEN(DisplayEN = "Street number")]
        [CSSPDisplayFR(DisplayFR = "Numéro de la rue")]
        [CSSPDescriptionEN(DescriptionEN = @"Street number of the address")]
        [CSSPDescriptionFR(DescriptionFR = @"Numéro de la rue de l'adresse")]
        public string StreetNumber { get; set; }
        [CSSPEnumType]
        [CSSPAllowNull]
        [CSSPDisplayEN(DisplayEN = "Street type")]
        [CSSPDisplayFR(DisplayFR = "Type de rue")]
        [CSSPDescriptionEN(DescriptionEN = @"Street type of the address")]
        [CSSPDescriptionFR(DescriptionFR = @"Type de rue de l'adresse")]
        public StreetTypeEnum? StreetType { get; set; }
        [StringLength(11, MinimumLength = 6)]
        [CSSPAllowNull]
        [CSSPDisplayEN(DisplayEN = "Postal code")]
        [CSSPDisplayFR(DisplayFR = "Code postale")]
        [CSSPDescriptionEN(DescriptionEN = @"Postal code of the address")]
        [CSSPDescriptionFR(DescriptionFR = @"Code postale de l'adresse")]
        public string PostalCode { get; set; }
        [StringLength(200, MinimumLength = 10)]
        [CSSPAllowNull]
        [CSSPDisplayEN(DisplayEN = "Google address")]
        [CSSPDisplayFR(DisplayFR = "Adresse Google")]
        [CSSPDescriptionEN(DescriptionEN = @"Google address provided by Google Location Service")]
        [CSSPDescriptionFR(DescriptionFR = @"Adresse Google fourni par le service Google Location")]
        public string GoogleAddressText { get; set; }
        #endregion Properties in DB

        #region Constructors
        public Address() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class AddressExtraA : Address
    {
        #region Properties
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "AddressTVItemID", FillReturnField = "TVText", FillNeedLanguage = true, FillIsList = false)]
        [CSSPDisplayEN(DisplayEN = "Address TVText")]
        [CSSPDisplayFR(DisplayFR = "TVText de Address")]
        [CSSPDescriptionEN(DescriptionEN = @"Address TVText")]
        [CSSPDescriptionFR(DescriptionFR = @"TVText de Address")]
        public string AddressText { get; set; }
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "CountryTVItemID", FillReturnField = "TVText", FillNeedLanguage = true, FillIsList = false)]
        [CSSPDisplayEN(DisplayEN = "Country TVText")]
        [CSSPDisplayFR(DisplayFR = "TVText Pays")]
        [CSSPDescriptionEN(DescriptionEN = @"Country TVText")]
        [CSSPDescriptionFR(DescriptionFR = @"TVText Pays")]
        public string CountryText { get; set; }
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "ProvinceTVItemID", FillReturnField = "TVText", FillNeedLanguage = true, FillIsList = false)]
        [CSSPDisplayEN(DisplayEN = "Province TVText")]
        [CSSPDisplayFR(DisplayFR = "TVText Province")]
        [CSSPDescriptionEN(DescriptionEN = @"Province TVText")]
        [CSSPDescriptionFR(DescriptionFR = @"TVText Province")]
        public string ProvinceText { get; set; }
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "MunicipalityTVItemID", FillReturnField = "TVText", FillNeedLanguage = true, FillIsList = false)]
        [CSSPDisplayEN(DisplayEN = "Municipality TVText")]
        [CSSPDisplayFR(DisplayFR = "TVText Municipalité")]
        [CSSPDescriptionEN(DescriptionEN = @"Municipality TVText")]
        [CSSPDescriptionFR(DescriptionFR = @"TVText Municipalité")]
        public string MunicipalityText { get; set; }
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "TVText", FillNeedLanguage = true, FillIsList = false)]
        [CSSPDisplayEN(DisplayEN = "Last update contact TVText")]
        [CSSPDisplayFR(DisplayFR = "TVText Contact du dernière changement")]
        [CSSPDescriptionEN(DescriptionEN = @"Last update contact TVText")]
        [CSSPDescriptionFR(DescriptionFR = @"TVText Contact du dernière changement")]
        public string LastUpdateContactText { get; set; }
        [CSSPEnumTypeText(EnumTypeName = "AddressTypeEnum", EnumType = "AddressType")]
        [CSSPAllowNull]
        [CSSPDisplayEN(DisplayEN = "Address type text")]
        [CSSPDisplayFR(DisplayFR = "Texte du type d'adresse")]
        [CSSPDescriptionEN(DescriptionEN = @"Address type text")]
        [CSSPDescriptionFR(DescriptionFR = @"Texte du type d'adresse")]
        public string AddressTypeText { get; set; }
        [CSSPEnumTypeText(EnumTypeName = "StreetTypeEnum", EnumType = "StreetType")]
        [CSSPAllowNull]
        [CSSPDisplayEN(DisplayEN = "Street type text")]
        [CSSPDisplayFR(DisplayFR = "Texte du type de rue")]
        [CSSPDescriptionEN(DescriptionEN = @"Street type text")]
        [CSSPDescriptionFR(DescriptionFR = @"Texte du type de rue")]
        public string StreetTypeText { get; set; }
        #endregion Properties

        #region Constructors
        public AddressExtraA() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class AddressExtraB : AddressExtraA
    {
        #region Properties
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "AddressTVItemID", FillReturnField = "TVText", FillNeedLanguage = true, FillIsList = false)]
        [CSSPAllowNull]
        [CSSPDisplayEN(DisplayEN = "Report test")]
        [CSSPDisplayFR(DisplayFR = "Test report")]
        [CSSPDescriptionEN(DescriptionEN = @"Report test description")]
        [CSSPDescriptionFR(DescriptionFR = @"Description de test report")]
        public string AddressReportTest { get; set; }
        #endregion Properties

        #region Constructors
        public AddressExtraB() : base()
        {
        }
        #endregion Constructors
    }
}
