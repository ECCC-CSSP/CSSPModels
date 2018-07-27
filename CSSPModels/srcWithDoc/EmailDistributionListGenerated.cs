/*
 * Auto generated from the CSSPCodeWriter.proj by clicking on the [\srcWithDoc\[ModelClassName]Generated.cs] button
 *
 * Do not edit this file.
 *
 * Last generated on 2018 July 27 04:56
 * by leblancc on WMON01DTCHLEBL2 machine
 *
 */ 
using CSSPEnums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSSPModels
{
    /// <summary>
    /// > [!NOTE]
    /// > 
    /// > <para>**DB properties for table EmailDistributionLists** : [EmailDistributionListID](CSSPModels.EmailDistributionList.html#CSSPModels_EmailDistributionList_EmailDistributionListID), [CountryTVItemID](CSSPModels.EmailDistributionList.html#CSSPModels_EmailDistributionList_CountryTVItemID), [Ordinal](CSSPModels.EmailDistributionList.html#CSSPModels_EmailDistributionList_Ordinal), [LastUpdateDate_UTC](CSSPModels.EmailDistributionList.html#CSSPModels_EmailDistributionList_LastUpdateDate_UTC), [LastUpdateContactTVItemID](CSSPModels.EmailDistributionList.html#CSSPModels_EmailDistributionList_LastUpdateContactTVItemID), </para>
    /// > <para>**Other properties** : [EmailDistributionListWeb](CSSPModels.EmailDistributionList.html#CSSPModels_EmailDistributionList_EmailDistributionListWeb), [EmailDistributionListReport](CSSPModels.EmailDistributionList.html#CSSPModels_EmailDistributionList_EmailDistributionListReport), [HasErrors](CSSPModels.EmailDistributionList.html#CSSPModels_EmailDistributionList_HasErrors), [ValidationResults](CSSPModels.EmailDistributionList.html#CSSPModels_EmailDistributionList_ValidationResults), </para>
    /// > 
    /// > <para>**Used by [CSSPServices](CSSPServices.html)** : [EmailDistributionListService](CSSPServices.EmailDistributionListService.html)</para>
    /// > <para>**Return to [CSSPModels](CSSPModels.html)**</para>
    /// </summary>
    public partial class EmailDistributionList : LastUpdate
    {
        #region Properties in DB
        [Key]
        [CSSPDisplayEN(DisplayEN = "EmailDistributionList ID")]
        [CSSPDisplayFR(DisplayFR = "EmailDistributionList ID")]
        [CSSPDescriptionEN(DescriptionEN = @"Contains the unique ""identifier on each row of the EmailDistributionLists table")]
        [CSSPDescriptionFR(DescriptionFR = @"Contient l'identifiant unique sur chaque ligne du tableau EmailDistributionLists")]
        public int EmailDistributionListID { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>**AllowableTVTypeList is of type [CSSPEnums.TVTypeEnum](CSSPEnums.TVTypeEnum.html)**</para>
        /// > <para>6 == Country</para>
        /// > <para>[[CSSPExist](CSSPModels.CSSPExistAttribute.html)(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "6")]</para>
        /// </summary>
        [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "6")]
        public int CountryTVItemID { get; set; }
        [Range(0, 1000)]
        public int Ordinal { get; set; }
        #endregion Properties in DB

        #region Properties not in DB
        [NotMapped]
        [CSSPAllowNull]
        public EmailDistributionListWeb EmailDistributionListWeb { get; set; }
        [NotMapped]
        [CSSPAllowNull]
        public EmailDistributionListReport EmailDistributionListReport { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public EmailDistributionList() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class EmailDistributionListWeb
    {
        #region Properties for web information
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPFill](CSSPModels.CSSPFillAttribute.html)(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "CountryTVItemID", FillReturnField = "TVText", FillNeedLanguage = true)]</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "CountryTVItemID", FillReturnField = "TVText", FillNeedLanguage = true)]
        [CSSPAllowNull]
        public string CountryTVText { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPFill](CSSPModels.CSSPFillAttribute.html)(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "TVText", FillNeedLanguage = true)]</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "TVText", FillNeedLanguage = true)]
        [CSSPAllowNull]
        public string LastUpdateContactTVText { get; set; }
        #endregion Properties for web information

        #region Constructors
        public EmailDistributionListWeb()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class EmailDistributionListReport
    {
        #region Properties for report information
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        [CSSPAllowNull]
        public string EmailDistributionReportTest { get; set; }
        #endregion Properties for report information

        #region Constructors
        public EmailDistributionListReport()
        {
        }
        #endregion Constructors
    }
}