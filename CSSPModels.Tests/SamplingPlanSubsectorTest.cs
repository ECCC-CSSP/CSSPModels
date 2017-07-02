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
    public partial class SamplingPlanSubsectorTest
    {
        #region Variables
        #endregion Variables

        #region Properties
        private CSSPWebToolsDBContext db { get; set; }
        private SamplingPlanSubsector samplingPlanSubsector { get; set; }
        private IEntityType entityType { get; set; }
        private string EntityName = "CSSPModels.SamplingPlanSubsector";
        #endregion Properties

        #region Constructors
        public SamplingPlanSubsectorTest()
        {
            db = new CSSPWebToolsDBContext(DatabaseTypeEnum.MemoryNoDBShape);
            samplingPlanSubsector = new SamplingPlanSubsector();
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
        // most of the tests are located under SamplingPlanSubsectorTestGenerated.cs
        #endregion Tests
    }
}
