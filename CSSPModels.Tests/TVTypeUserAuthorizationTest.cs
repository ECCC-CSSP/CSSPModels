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
    public partial class TVTypeUserAuthorizationTest
    {
        #region Variables
        #endregion Variables

        #region Properties
        private CSSPWebToolsDBContext db { get; set; }
        private TVTypeUserAuthorization tVTypeUserAuthorization { get; set; }
        private IEntityType entityType { get; set; }
        private string EntityName = "CSSPModels.TVTypeUserAuthorization";
        #endregion Properties

        #region Constructors
        public TVTypeUserAuthorizationTest()
        {
            db = new CSSPWebToolsDBContext(DatabaseTypeEnum.MemoryNoDBShape);
            tVTypeUserAuthorization = new TVTypeUserAuthorization();
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
        // most of the tests are located under TVTypeUserAuthorizationTestGenerated.cs
        #endregion Tests
    }
}
