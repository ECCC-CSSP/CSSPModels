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
    public partial class MWQMSampleLanguageTest
    {
        #region Variables
        #endregion Variables

        #region Properties
        private CSSPWebToolsDBContext db { get; set; }
        private MWQMSampleLanguage mWQMSampleLanguage { get; set; }
        private IEntityType entityType { get; set; }
        private string EntityName = "CSSPModels.MWQMSampleLanguage";
        #endregion Properties

        #region Constructors
        public MWQMSampleLanguageTest()
        {
            db = new CSSPWebToolsDBContext(DatabaseTypeEnum.MemoryNoDBShape);
            mWQMSampleLanguage = new MWQMSampleLanguage();
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
        // most of the tests are located under MWQMSampleLanguageTestGenerated.cs
        #endregion Tests
    }
}
