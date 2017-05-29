using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSSPModels
{
    public partial class TideLocation
    {
        #region Properties in DB
        public string TideLocationID { get; set; }
        public int Zone { get; set; }
        public string Name { get; set; }
        public string Prov { get; set; }
        public int sid { get; set; }
        public float Lat { get; set; }
        public float Lng { get; set; }
        #endregion Properties in DB

        #region Properties not in DB
        [NotMapped]
        public IEnumerable<ValidationResult> ValidationResults { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public TideLocation()
        {
            // empty for now
        }
        #endregion Constructors
    }
}
