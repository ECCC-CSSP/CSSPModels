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
    public partial class EmailDistributionListContact : LastUpdate
    {
        #region Properties in DB
        [Key]
        [CSSPDisplayEN(DisplayEN = "EmailDistributionListContact ID")]
        [CSSPDisplayFR(DisplayFR = "EmailDistributionListContact ID")]
        [CSSPDescriptionEN(DescriptionEN = @"Contains the unique ""identifier on each row of the EmailDistributionListContacts table")]
        [CSSPDescriptionFR(DescriptionFR = @"Contient l'identifiant unique sur chaque ligne du tableau EmailDistributionListContacts")]
        public int EmailDistributionListContactID { get; set; }
        [CSSPExist(ExistTypeName = "EmailDistributionList", ExistPlurial = "s", ExistFieldID = "EmailDistributionListID")]
        public int EmailDistributionListID { get; set; }
        public bool IsCC { get; set; }
        [StringLength(100)]
        public string Name { get; set; }
        [StringLength(200)]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        public bool CMPRainfallSeasonal { get; set; }
        public bool CMPWastewater { get; set; }
        public bool EmergencyWeather { get; set; }
        public bool EmergencyWastewater { get; set; }
        public bool ReopeningAllTypes { get; set; }
        #endregion Properties in DB

        #region Constructors
        public EmailDistributionListContact() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class EmailDistributionListContactWeb : EmailDistributionListContact
    {
        #region Properties for web information
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "", FillNeedLanguage = true)]
        public TVItemLanguage LastUpdateContactTVItemLanguage { get; set; }
        #endregion Properties for web information

        #region Constructors
        public EmailDistributionListContactWeb() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class EmailDistributionListContactReport : EmailDistributionListContactWeb
    {
        #region Properties for report information
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "TVText", FillNeedLanguage = true)]
        [CSSPAllowNull]
        public string EmailDistributionListContactReportTest { get; set; }
        #endregion Properties for report information

        #region Constructors
        public EmailDistributionListContactReport() : base()
        {
        }
        #endregion Constructors
    }
}
