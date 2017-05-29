using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSSPModels
{
    public partial class MikeSource
    {
        #region Properties in DB
        public int MikeSourceID { get; set; }
        public int MikeSourceTVItemID { get; set; }
        public bool IsContinuous { get; set; }
        public bool Include { get; set; }
        public bool IsRiver { get; set; }
        public string SourceNumberString { get; set; }
        public DateTime LastUpdateDate_UTC { get; set; }
        public int LastUpdateContactTVItemID { get; set; }

        public virtual ICollection<MikeSourceStartEnd> MikeSourceStartEnds { get; set; }
        public virtual TVItem MikeSourceTVItem { get; set; }
        #endregion Properties in DB

        #region Properties not in DB
        [NotMapped]
        public IEnumerable<ValidationResult> ValidationResults { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public MikeSource()
        {
            MikeSourceStartEnds = new HashSet<MikeSourceStartEnd>();
        }
        #endregion Constructors

    }
}
