using CSSPEnums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSSPModels
{
    [NotMapped]
    public partial class FileItemList : Error
    {
        #region Properties in DB
        #endregion Properties in DB

        #region Properties not in DB
        [StringLength(255, MinimumLength = 1)]
        public string Text { get; set; }
        [StringLength(255, MinimumLength = 1)]
        public string FileName { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public FileItemList() : base()
        {
        }
        #endregion Constructors
    }
}
