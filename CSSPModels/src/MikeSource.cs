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
    public partial class MikeSource : LastUpdate
    {
        #region Properties in DB
        [Key]
        [CSSPDisplayEN(DisplayEN = "MikeSource ID")]
        [CSSPDisplayFR(DisplayFR = "MikeSource ID")]
        [CSSPDescriptionEN(DescriptionEN = @"Contains the unique ""identifier on each row of the MikeSources table")]
        [CSSPDescriptionFR(DescriptionFR = @"Contient l'identifiant unique sur chaque ligne du tableau MikeSources")]
        public int MikeSourceID { get; set; }
        [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "14")]
        public int MikeSourceTVItemID { get; set; }
        public bool IsContinuous { get; set; }
        public bool Include { get; set; }
        public bool IsRiver { get; set; }
        [StringLength(50)]
        public string SourceNumberString { get; set; }
        #endregion Properties in DB

        #region Constructors
        public MikeSource() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class MikeSourceWeb : MikeSource
    {
        #region Properties for web information
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "MikeSourceTVItemID", FillReturnField = "", FillNeedLanguage = true)]
        public TVItemLanguage MikeSourceTVItemLanguage { get; set; }
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "", FillNeedLanguage = true)]
        public TVItemLanguage LastUpdateContactTVItemLanguage { get; set; }
        #endregion Properties for web information

        #region Constructors
        public MikeSourceWeb() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class MikeSourceReport : MikeSourceWeb
    {
        #region Properties for report information
        [CSSPAllowNull]
        public string MikeSourceReportTest { get; set; }
        #endregion Properties for report information

        #region Constructors
        public MikeSourceReport() : base()
        {
        }
        #endregion Constructors
    }
}
