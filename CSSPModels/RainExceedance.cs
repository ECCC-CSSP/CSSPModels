using CSSPEnums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSSPModels
{
    public partial class RainExceedance
    {
        #region Properties in DB
        [Key]
        public int RainExceedanceID { get; set; }
        public bool YearRound { get; set; }
        [CSSPAfter(Year = 1980)]
        public DateTime? StartDate_Local { get; set; }
        [CSSPAfter(Year = 1980)]
        [CSSPBigger(OtherField = "StartDate")]
        public DateTime? EndDate_Local { get; set; }
        [Range(0.0D, 300.0D)]
        public double? RainMaximum_mm { get; set; }
        [Range(0.0D, 300.0D)]
        public double? RainExtreme_mm { get; set; }
        [Range(0, 30)]
        public int DaysPriorToStart { get; set; }
        public bool RepeatEveryYear { get; set; }
        [StringLength(250)]
        public string ProvinceTVItemIDs { get; set; }
        [StringLength(250)]
        public string SubsectorTVItemIDs { get; set; }
        [StringLength(250)]
        public string ClimateSiteTVItemIDs { get; set; }
        [StringLength(250)]
        public string EmailDistributionListIDs { get; set; }
        [CSSPAfter(Year = 1980)]
        public DateTime LastUpdateDate_UTC { get; set; }
        [Range(1, -1)]
        [CSSPExist(TypeName = "TVItem", Plurial = "s", FieldID = "TVItemID", TVType = TVTypeEnum.Contact)]
        public int LastUpdateContactTVItemID { get; set; }
        #endregion Properties in DB

        #region Properties not in DB
        [NotMapped]
        public IEnumerable<ValidationResult> ValidationResults { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public RainExceedance()
        {
            // empty for now
        }
        #endregion Constructors
    }
}
