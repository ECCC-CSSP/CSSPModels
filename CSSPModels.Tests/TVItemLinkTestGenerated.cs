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
    public partial class TVItemLinkTest
    {
        [TestMethod]
        public void TVItemLink_Properties_OK()
        {
            List<string> propNameList = new List<string>() { "TVItemLinkID", "FromTVItemID", "ToTVItemID", "FromTVType", "ToTVType", "StartDateTime_Local", "EndDateTime_Local", "Ordinal", "TVLevel", "TVPath", "ParentTVItemLinkID", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(CSSPModels.TVItemLink).GetProperties().OrderBy(c => c.Name))
            {
                if (!propertyInfo.GetGetMethod().IsVirtual
                    && propertyInfo.Name != "ValidationResults"
                    && !propertyInfo.CustomAttributes.Where(c => c.AttributeType.Name.Contains("NotMappedAttribute")).Any())
                {
                    Assert.AreEqual(propNameList[index], propertyInfo.Name);
                    index += 1;
                }
            }

            Assert.AreEqual(propNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(TVItemLink).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void TVItemLink_Navigation_OK()
        {
            List<string> foreignNameList = new List<string>() { "FromTVItem", "ParentTVItemLink", "ToTVItem",  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() { "InverseParentTVItemLink",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(TVItemLink).GetProperties())
            {
                if (propertyInfo.GetGetMethod().IsVirtual && !propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                {
                    Assert.IsTrue(foreignNameList.Contains(propertyInfo.Name));
                    index += 1;
                }
            }

            Assert.AreEqual(foreignNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(TVItemLink).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void TVItemLink_Has_ValidationResults_OK()
        {
             Assert.IsTrue(typeof(TVItemLink).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void TVItemLink_Every_Property_Has_A_Resource_OK()
        {
               Assert.IsNotNull(ModelsRes.TVItemLinkTVItemLinkID);
               Assert.IsNotNull(ModelsRes.TVItemLinkFromTVItemID);
               Assert.IsNotNull(ModelsRes.TVItemLinkToTVItemID);
               Assert.IsNotNull(ModelsRes.TVItemLinkFromTVType);
               Assert.IsNotNull(ModelsRes.TVItemLinkToTVType);
               Assert.IsNotNull(ModelsRes.TVItemLinkStartDateTime_Local);
               Assert.IsNotNull(ModelsRes.TVItemLinkEndDateTime_Local);
               Assert.IsNotNull(ModelsRes.TVItemLinkOrdinal);
               Assert.IsNotNull(ModelsRes.TVItemLinkTVLevel);
               Assert.IsNotNull(ModelsRes.TVItemLinkTVPath);
               Assert.IsNotNull(ModelsRes.TVItemLinkParentTVItemLinkID);
               Assert.IsNotNull(ModelsRes.TVItemLinkLastUpdateDate_UTC);
               Assert.IsNotNull(ModelsRes.TVItemLinkLastUpdateContactTVItemID);
               Assert.IsNotNull(ModelsRes.TVItemLinkFromTVItem);
               Assert.IsNotNull(ModelsRes.TVItemLinkParentTVItemLink);
               Assert.IsNotNull(ModelsRes.TVItemLinkInverseParentTVItemLink);
               Assert.IsNotNull(ModelsRes.TVItemLinkToTVItem);
        }
    }
}
