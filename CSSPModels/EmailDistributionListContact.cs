﻿using CSSPEnums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSSPModels
{
    public partial class EmailDistributionListContact
    {
        #region Properties in DB
        [Key]
        public int EmailDistributionListContactID { get; set; }
        [Range(1, -1)]
        [CSSPExist(TypeName = "EmailDistributionList", Plurial = "s", FieldID = "EmailDistributionListID")]
        public int EmailDistributionListID { get; set; }
        public bool IsCC { get; set; }
        [StringLength(20)]
        public string Agency { get; set; }
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
        [CSSPAfter(Year = 1980)]
        public DateTime LastUpdateDate_UTC { get; set; }
        [Range(1, -1)]
        [CSSPExist(TypeName = "TVItem", Plurial = "s", FieldID = "TVItemID", TVType = TVTypeEnum.Contact)]
        public int LastUpdateContactTVItemID { get; set; }

        public virtual EmailDistributionList EmailDistributionList { get; set; }
        #endregion Properties in DB

        #region Properties not in DB
        [NotMapped]
        public IEnumerable<ValidationResult> ValidationResults { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public EmailDistributionListContact()
        {
            // nothing for now
        }
        #endregion Constructors
    }
}
