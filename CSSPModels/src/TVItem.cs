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
    public partial class TVItem : LastUpdate
    {
        #region Properties in DB
        [Key]
        [CSSPDisplayEN(DisplayEN = "TVItem ID")]
        [CSSPDisplayFR(DisplayFR = "TVItem ID")]
        [CSSPDescriptionEN(DescriptionEN = @"Contains the unique ""identifier on each row of the TVItems table")]
        [CSSPDescriptionFR(DescriptionFR = @"Contient l'identifiant unique sur chaque ligne du tableau TVItems")]
        public int TVItemID { get; set; }
        [Range(0, 100)]
        public int TVLevel { get; set; }
        [StringLength(250)]
        public string TVPath { get; set; }
        [CSSPEnumType]
        public TVTypeEnum TVType { get; set; }
        [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "1,2,3,4,5,6,7,9,10,11,12,13,14,15,16,17,18,19,20,21,31,79")]
        public int ParentID { get; set; }
        public bool IsActive { get; set; }
        #endregion Properties in DB

        #region Constructors
        public TVItem() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class TVItemWeb : TVItem
    {
        #region Properties for web information
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "TVItemID", FillReturnField = "", FillNeedLanguage = true)]
        public TVItemLanguage TVItemLanguage { get; set; }
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "", FillNeedLanguage = true)]
        public TVItemLanguage LastUpdateContactTVItemLanguage { get; set; }
        [CSSPEnumTypeText(EnumTypeName = "TVTypeEnum", EnumType = "TVType")]
        [CSSPAllowNull]
        public string TVTypeText { get; set; }
        #endregion Properties for web information

        #region Constructors
        public TVItemWeb() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class TVItemReport : TVItemWeb
    {
        #region Properties for report information
        [CSSPAllowNull]
        public string TVItemReportTest { get; set; }
        #endregion Properties for report information

        #region Constructors
        public TVItemReport() : base()
        {
        }
        #endregion Constructors
    }
}
