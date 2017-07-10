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
    public partial class CSSPBiggerAttributeTest
    {
        #region Variables
        #endregion Variables

        #region Properties
        private CSSPWebToolsDBContext db { get; set; }
        private CSSPBiggerAttribute cSSPBiggerAttribute { get; set; }
        private IEntityType entityType { get; set; }
        private string EntityName = "CSSPModels.CSSPBiggerAttribute";
        #endregion Properties

        #region Constructors
        public CSSPBiggerAttributeTest()
        {
            db = new CSSPWebToolsDBContext(DatabaseTypeEnum.MemoryNoDBShape);
            cSSPBiggerAttribute = new CSSPBiggerAttribute();
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
        // most of the tests are located under CSSPBiggerAttributeTestGenerated.cs
        #endregion Tests
    }
}
