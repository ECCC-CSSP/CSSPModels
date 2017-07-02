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
    public partial class HydrometricDataValueTest
    {
        #region Variables
        #endregion Variables

        #region Properties
        private CSSPWebToolsDBContext db { get; set; }
        private HydrometricDataValue hydrometricDataValue { get; set; }
        private IEntityType entityType { get; set; }
        private string EntityName = "CSSPModels.HydrometricDataValue";
        #endregion Properties

        #region Constructors
        public HydrometricDataValueTest()
        {
            db = new CSSPWebToolsDBContext(DatabaseTypeEnum.MemoryNoDBShape);
            hydrometricDataValue = new HydrometricDataValue();
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
        // most of the tests are located under HydrometricDataValueTestGenerated.cs
        #endregion Tests
    }
}
