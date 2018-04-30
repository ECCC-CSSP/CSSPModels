using CSSPEnums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSSPModels
{
    public partial class MWQMLookupMPN : LastUpdate
    {
        #region Properties in DB
        [Key]
        [CSSPDisplayEN(DisplayEN = "MWQMLookupMPN ID")]
        [CSSPDisplayFR(DisplayFR = "MWQMLookupMPN ID")]
        [CSSPDescriptionEN(DescriptionEN = @"Contains the unique ""identifier on each row of the MWQMLookupMPNs table")]
        [CSSPDescriptionFR(DescriptionFR = @"Contient l'identifiant unique sur chaque ligne du tableau MWQMLookupMPNs")]
        public int MWQMLookupMPNID { get; set; }
        [Range(0, 5)]
        public int Tubes10 { get; set; }
        [Range(0, 5)]
        public int Tubes1 { get; set; }
        [Range(0, 5)]
        public int Tubes01 { get; set; }
        [Range(1, 10000)]
        public int MPN_100ml { get; set; }
        #endregion Properties in DB

        #region Properties not in DB
        [NotMapped]
        [CSSPAllowNull]
        public MWQMLookupMPNWeb MWQMLookupMPNWeb { get; set; }
        [NotMapped]
        [CSSPAllowNull]
        public MWQMLookupMPNReport MWQMLookupMPNReport { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public MWQMLookupMPN() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class MWQMLookupMPNWeb
    {
        #region Properties for web information
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "TVText", FillNeedLanguage = true)]
        [CSSPAllowNull]
        public string LastUpdateContactTVText { get; set; }
        #endregion Properties for web information

        #region Constructors
        public MWQMLookupMPNWeb()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class MWQMLookupMPNReport
    {
        #region Properties for report information
        [CSSPAllowNull]
        public string MWQMLookupMPNReportTest { get; set; }
        #endregion Properties for report information

        #region Constructors
        public MWQMLookupMPNReport()
        {
        }
        #endregion Constructors
    }
}
