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
    public partial class TideLocation : LastUpdate
    {
        #region Properties in DB
        [Key]
        [CSSPDisplayEN(DisplayEN = "TideLocation ID")]
        [CSSPDisplayFR(DisplayFR = "TideLocation ID")]
        [CSSPDescriptionEN(DescriptionEN = @"Contains the unique ""identifier on each row of the TideLocations table")]
        [CSSPDescriptionFR(DescriptionFR = @"Contient l'identifiant unique sur chaque ligne de la table TideLocations")]
        public int TideLocationID { get; set; }
        [Range(0, 10000)]
        [CSSPDisplayEN(DisplayEN = "Zone")]
        [CSSPDisplayFR(DisplayFR = "Zone")]
        [CSSPDescriptionEN(DescriptionEN = @"Zone")]
        [CSSPDescriptionFR(DescriptionFR = @"Zone")]
        public int Zone { get; set; }
        [StringLength(100)]
        [CSSPDisplayEN(DisplayEN = "Name")]
        [CSSPDisplayFR(DisplayFR = "Nom")]
        [CSSPDescriptionEN(DescriptionEN = @"Name")]
        [CSSPDescriptionFR(DescriptionFR = @"Nom")]
        public string Name { get; set; }
        [StringLength(100)]
        [CSSPDisplayEN(DisplayEN = "Province")]
        [CSSPDisplayFR(DisplayFR = "Province")]
        [CSSPDescriptionEN(DescriptionEN = @"Province")]
        [CSSPDescriptionFR(DescriptionFR = @"Province")]
        public string Prov { get; set; }
        [Range(0, 100000)]
        [CSSPDisplayEN(DisplayEN = "SID")]
        [CSSPDisplayFR(DisplayFR = "SID")]
        [CSSPDescriptionEN(DescriptionEN = @"SID")]
        [CSSPDescriptionFR(DescriptionFR = @"SID")]
        public int sid { get; set; }
        [Range(-90.0D, 90.0D)]
        [CSSPDisplayEN(DisplayEN = "Lat")]
        [CSSPDisplayFR(DisplayFR = "Lat")]
        [CSSPDescriptionEN(DescriptionEN = @"Latitude")]
        [CSSPDescriptionFR(DescriptionFR = @"Latitude")]
        public double Lat { get; set; }
        [Range(-180.0D, 180.0D)]
        [CSSPDisplayEN(DisplayEN = "Lng")]
        [CSSPDisplayFR(DisplayFR = "Lng")]
        [CSSPDescriptionEN(DescriptionEN = @"Longitude")]
        [CSSPDescriptionFR(DescriptionFR = @"Longitude")]
        public double Lng { get; set; }
        #endregion Properties in DB

        #region Constructors
        public TideLocation() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class TideLocationExtraA : TideLocation
    {
        #region Properties
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "TVText", FillNeedLanguage = true, FillIsList = false)]
        [CSSPDisplayEN(DisplayEN = "Last update contact name")]
        [CSSPDisplayFR(DisplayFR = "Nom du contact ayant fait le dernière changement")]
        [CSSPDescriptionEN(DescriptionEN = @"Last update contact name")]
        [CSSPDescriptionFR(DescriptionFR = @"Nom du contact ayant fait le dernière changement")]
        public string LastUpdateContactText { get; set; }
        #endregion Properties

        #region Constructors
        public TideLocationExtraA() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class TideLocationExtraB : TideLocationExtraA
    {
        #region Properties
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "TVText", FillNeedLanguage = true, FillIsList = false)]
        [CSSPAllowNull]
        [CSSPDisplayEN(DisplayEN = "Report test")]
        [CSSPDisplayFR(DisplayFR = "Test report")]
        [CSSPDescriptionEN(DescriptionEN = @"Report test description")]
        [CSSPDescriptionFR(DescriptionFR = @"Description de test report")]
        public string TideLocationReportTest { get; set; }
        #endregion Properties

        #region Constructors
        public TideLocationExtraB() : base()
        {
        }
        #endregion Constructors
    }
}
