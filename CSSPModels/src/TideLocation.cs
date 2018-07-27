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
    public partial class TideLocation : LastUpdate
    {
        #region Properties in DB
        [Key]
        [CSSPDisplayEN(DisplayEN = "TideLocation ID")]
        [CSSPDisplayFR(DisplayFR = "TideLocation ID")]
        [CSSPDescriptionEN(DescriptionEN = @"Contains the unique ""identifier on each row of the TideLocations table")]
        [CSSPDescriptionFR(DescriptionFR = @"Contient l'identifiant unique sur chaque ligne du tableau TideLocations")]
        public int TideLocationID { get; set; }
        [Range(0, 10000)]
        public int Zone { get; set; }
        [StringLength(100)]
        public string Name { get; set; }
        [StringLength(100)]
        public string Prov { get; set; }
        [Range(0, 100000)]
        public int sid { get; set; }
        [Range(-90.0D, 90.0D)]
        public double Lat { get; set; }
        [Range(-180.0D, 180.0D)]
        public double Lng { get; set; }
        #endregion Properties in DB

        #region Properties not in DB
        [NotMapped]
        [CSSPAllowNull]
        public TideLocationWeb TideLocationWeb { get; set; }
        [NotMapped]
        [CSSPAllowNull]
        public TideLocationReport TideLocationReport { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public TideLocation() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class TideLocationWeb
    {
        #region Properties for web information
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "TVText", FillNeedLanguage = true)]
        [CSSPAllowNull]
        public string LastUpdateContactTVText { get; set; }
        #endregion Properties for web information

        #region Constructors
        public TideLocationWeb()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class TideLocationReport
    {
        #region Properties for report information
        [CSSPAllowNull]
        public string TideLocationReportTest { get; set; }
        #endregion Properties for report information

        #region Constructors
        public TideLocationReport()
        {
        }
        #endregion Constructors
    }
}
