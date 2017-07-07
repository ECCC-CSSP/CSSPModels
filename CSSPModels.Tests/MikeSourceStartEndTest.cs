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
    public partial class MikeSourceStartEndTest
    {
        #region Variables
        #endregion Variables

        #region Properties
        private CSSPWebToolsDBContext db { get; set; }
        private MikeSourceStartEnd mikeSourceStartEnd { get; set; }
        private IEntityType entityType { get; set; }
        private string EntityName = "CSSPModels.MikeSourceStartEnd";
        #endregion Properties

        #region Constructors
        public MikeSourceStartEndTest()
        {
            db = new CSSPWebToolsDBContext(DatabaseTypeEnum.MemoryNoDBShape);
            mikeSourceStartEnd = new MikeSourceStartEnd();
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
        // most of the tests are located under MikeSourceStartEndTestGenerated.cs
        #endregion Tests
    }
}
