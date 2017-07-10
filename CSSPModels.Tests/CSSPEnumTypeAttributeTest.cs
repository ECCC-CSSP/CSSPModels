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
    public partial class CSSPEnumTypeAttributeTest
    {
        #region Variables
        #endregion Variables

        #region Properties
        private CSSPWebToolsDBContext db { get; set; }
        private CSSPEnumTypeAttribute cSSPEnumTypeAttribute { get; set; }
        private IEntityType entityType { get; set; }
        private string EntityName = "CSSPModels.CSSPEnumTypeAttribute";
        #endregion Properties

        #region Constructors
        public CSSPEnumTypeAttributeTest()
        {
            db = new CSSPWebToolsDBContext(DatabaseTypeEnum.MemoryNoDBShape);
            cSSPEnumTypeAttribute = new CSSPEnumTypeAttribute();
            foreach (IEntityType entityTypeTemp in db.Model.GetEntityTypes())
            {
                if (entityTypeTemp.Name == EntityName)
                {
                    entityType = entityTypeTemp;
                    break;
                }
            }
        }
        #endregion Constructors

        #region Tests
        // most of the tests are located under CSSPEnumTypeAttributeTestGenerated.cs
        #endregion Tests
    }
}
