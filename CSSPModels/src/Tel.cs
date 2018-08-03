﻿/*
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
    public partial class Tel : LastUpdate
    {
        #region Properties in DB
        [Key]
        [CSSPDisplayEN(DisplayEN = "Tel ID")]
        [CSSPDisplayFR(DisplayFR = "Tel ID")]
        [CSSPDescriptionEN(DescriptionEN = @"Contains the unique ""identifier on each row of the Tels table")]
        [CSSPDescriptionFR(DescriptionFR = @"Contient l'identifiant unique sur chaque ligne du tableau Tels")]
        public int TelID { get; set; }
        [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "21")]
        public int TelTVItemID { get; set; }
        [StringLength(50)]
        public string TelNumber { get; set; }
        [CSSPEnumType]
        public TelTypeEnum TelType { get; set; }
        #endregion Properties in DB

        #region Constructors
        public Tel() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class TelWeb : Tel
    {
        #region Properties for web information
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "TelTVItemID", FillReturnField = "", FillNeedLanguage = true)]
        public TVItemLanguage TelTVItemLanguage { get; set; }
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "", FillNeedLanguage = true)]
        public TVItemLanguage LastUpdateContactTVItemLanguage { get; set; }
        [CSSPEnumTypeText(EnumTypeName = "TelTypeEnum", EnumType = "TelType")]
        [CSSPAllowNull]
        public string TelTypeText { get; set; }
        #endregion Properties for web information

        #region Constructors
        public TelWeb() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class TelReport : TelWeb
    {
        #region Properties for report information
        [CSSPAllowNull]
        public string TelReportTest { get; set; }
        #endregion Properties for report information

        #region Constructors
        public TelReport() : base()
        {
        }
        #endregion Constructors
    }
}
