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
    public partial class CSSPExistAttributeTest
    {
        #region Variables
        #endregion Variables

        #region Properties
        private CSSPWebToolsDBContext db { get; set; }
        private CSSPExistAttribute cSSPExistAttribute { get; set; }
        private IEntityType entityType { get; set; }
        private string EntityName = "CSSPModels.CSSPExistAttribute";
        #endregion Properties

        #region Constructors
        public CSSPExistAttributeTest()
        {
            db = new CSSPWebToolsDBContext(DatabaseTypeEnum.MemoryNoDBShape);
            cSSPExistAttribute = new CSSPExistAttribute();
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
        // most of the tests are located under CSSPExistAttributeTestGenerated.cs
        #endregion Tests
    }
}
