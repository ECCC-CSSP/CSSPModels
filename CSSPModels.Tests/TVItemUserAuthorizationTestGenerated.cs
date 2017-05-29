using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System.Globalization;
using System.Transactions;
using System.Collections.Generic;
using CSSPModels.Resources;
using Microsoft.EntityFrameworkCore.Metadata;
using System.Reflection;

namespace CSSPModels.Tests
{
    public partial class TVItemUserAuthorizationTest
    {
        [TestMethod]
        public void TVItemUserAuthorization_Properties_OK()
        {
            List<string> propNameList = new List<string>() { "TVItemUserAuthorizationID", "ContactTVItemID", "TVItemID1", "TVItemID2", "TVItemID3", "TVItemID4", "TVAuth", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (IProperty propertyType in entityType.GetProperties().OrderBy(c => c.Name))
            {
                Assert.AreEqual(propNameList[index], propertyType.Name);
                index += 1;
            }

            Assert.AreEqual(propNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(TVItemUserAuthorization).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
            {
                foreach (CustomAttributeData customAttributeData in propertyInfo.CustomAttributes)
                {
                    if (customAttributeData.AttributeType.Name == "NotMappedAttribute")
                    {
                        Assert.AreEqual(propertyInfo.Name, propNameNotMappedList[index]);
                        index += 1;
                    }
                }
            }

            Assert.AreEqual(propNameNotMappedList.Count, index);

        }
        [TestMethod]
        public void TVItemUserAuthorization_Navigation_OK()
        {
            List<string> foreignNameList = new List<string>() { "ContactTVItem", "TVItemID1Navigation",  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (string foreignName in (from c in entityType.GetForeignKeys() orderby c.DependentToPrincipal.Name select c.DependentToPrincipal.Name))
            {
                Assert.AreEqual(foreignNameList[index], foreignName);
                index += 1;
            }

            Assert.AreEqual(foreignNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(TVItemUserAuthorization).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
            {
                if (propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                {
                    Assert.IsTrue(foreignNameCollectionList.Contains(propertyInfo.Name));
                    index += 1;
                }
            }

            Assert.AreEqual(foreignNameCollectionList.Count, index);

        }
        [TestMethod]
        public void TVItemUserAuthorization_Has_ValidationResults_OK()
        {
             Assert.IsTrue(typeof(TVItemUserAuthorization).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void TVItemUserAuthorization_Every_Property_Has_A_Resource_OK()
        {
               Assert.IsNotNull(ModelsRes.TVItemUserAuthorizationTVItemUserAuthorizationID);
               Assert.IsNotNull(ModelsRes.TVItemUserAuthorizationContactTVItemID);
               Assert.IsNotNull(ModelsRes.TVItemUserAuthorizationTVItemID1);
               Assert.IsNotNull(ModelsRes.TVItemUserAuthorizationTVItemID2);
               Assert.IsNotNull(ModelsRes.TVItemUserAuthorizationTVItemID3);
               Assert.IsNotNull(ModelsRes.TVItemUserAuthorizationTVItemID4);
               Assert.IsNotNull(ModelsRes.TVItemUserAuthorizationTVAuth);
               Assert.IsNotNull(ModelsRes.TVItemUserAuthorizationLastUpdateDate_UTC);
               Assert.IsNotNull(ModelsRes.TVItemUserAuthorizationLastUpdateContactTVItemID);
               Assert.IsNotNull(ModelsRes.TVItemUserAuthorizationContactTVItem);
               Assert.IsNotNull(ModelsRes.TVItemUserAuthorizationTVItemID1Navigation);
        }
    }
}
