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
    public partial class ClimateDataValueTest
    {
        #region Variables
        #endregion Variables

        #region Properties
        private CSSPWebToolsDBContext db { get; set; }
        private ClimateDataValue climateDataValue { get; set; }
        private IEntityType entityType { get; set; }
        private string EntityName = "CSSPModels.ClimateDataValue";
        #endregion Properties

        #region Constructors
        public ClimateDataValueTest()
        {
            db = new CSSPWebToolsDBContext(DatabaseTypeEnum.MemoryNoDBShape); // true == InMemory
            climateDataValue = new ClimateDataValue();
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
        // most of the test will generated and located under ClimateDataValueTestGenerated.cs
        #endregion Tests
    }
}
