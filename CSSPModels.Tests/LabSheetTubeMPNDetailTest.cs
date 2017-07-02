using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System.Collections.Generic;
using CSSPModels;
using Microsoft.EntityFrameworkCore.Metadata;
using System.Reflection;
using CSSPEnums;

namespace CSSPModels.Tests
{
    [TestClass]
    public partial class LabSheetTubeMPNDetailTest
    {
        #region Variables
        #endregion Variables

        #region Properties
        private CSSPWebToolsDBContext db { get; set; }
        private LabSheetTubeMPNDetail labSheetTubeMPNDetail { get; set; }
        private IEntityType entityType { get; set; }
        private string EntityName = "CSSPModels.LabSheetTubeMPNDetail";
        #endregion Properties

        #region Constructors
        public LabSheetTubeMPNDetailTest()
        {
            db = new CSSPWebToolsDBContext(DatabaseTypeEnum.MemoryNoDBShape);
            labSheetTubeMPNDetail = new LabSheetTubeMPNDetail();
            foreach (IEntityType entityTypeTemp in db.Model.GetEntityTypes())
            {
                if (entityTypeTemp.Name == EntityName)
                {
                    entityType = entityTypeTemp;
                }
            }
        }
        #endregion Constructors

        #region Tests
        // most of the tests are located under LabSheetTubeMPNDetailTestGenerated.cs
        #endregion Tests
    }
}
