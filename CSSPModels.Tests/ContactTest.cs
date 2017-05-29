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
    public partial class ContactTest
    {
        #region Variables
        #endregion Variables

        #region Properties
        private CSSPWebToolsDBContext db { get; set; }
        private Contact contact { get; set; }
        private IEntityType entityType { get; set; }
        private string EntityName = "CSSPModels.Contact";
        #endregion Properties

        #region Constructors
        public ContactTest()
        {
            db = new CSSPWebToolsDBContext(DatabaseTypeEnum.MemoryNoDBShape); // true == InMemory
            contact = new Contact();
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
        // most of the test will generated and located under ContactTestGenerated.cs
        #endregion Tests
    }
}
