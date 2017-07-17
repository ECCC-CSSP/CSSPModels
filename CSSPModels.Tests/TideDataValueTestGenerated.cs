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
    public partial class TideDataValueTest
    {
        [TestMethod]
        public void TideDataValue_Properties_OK()
        {
            List<string> propNameList = new List<string>() { "TideDataValueID", "TideSiteTVItemID", "DateTime_Local", "Keep", "TideDataType", "StorageDataType", "Depth_m", "UVelocity_m_s", "VVelocity_m_s", "TideStart", "TideEnd", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(CSSPModels.TideDataValue).GetProperties().OrderBy(c => c.Name))
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
            foreach (PropertyInfo propertyInfo in typeof(TideDataValue).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void TideDataValue_Navigation_OK()
        {
            List<string> foreignNameList = new List<string>() { "TideSiteTVItem",  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(TideDataValue).GetProperties())
            {
                if (propertyInfo.GetGetMethod().IsVirtual && !propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                {
                    Assert.IsTrue(foreignNameList.Contains(propertyInfo.Name));
                    index += 1;
                }
            }

            Assert.AreEqual(foreignNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(TideDataValue).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void TideDataValue_Has_ValidationResults_OK()
        {
             Assert.IsTrue(typeof(TideDataValue).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void TideDataValue_Every_Property_Has_A_Resource_OK()
        {
               Assert.IsNotNull(ModelsRes.TideDataValueTideDataValueID);
               Assert.IsNotNull(ModelsRes.TideDataValueTideSiteTVItemID);
               Assert.IsNotNull(ModelsRes.TideDataValueDateTime_Local);
               Assert.IsNotNull(ModelsRes.TideDataValueKeep);
               Assert.IsNotNull(ModelsRes.TideDataValueTideDataType);
               Assert.IsNotNull(ModelsRes.TideDataValueStorageDataType);
               Assert.IsNotNull(ModelsRes.TideDataValueDepth_m);
               Assert.IsNotNull(ModelsRes.TideDataValueUVelocity_m_s);
               Assert.IsNotNull(ModelsRes.TideDataValueVVelocity_m_s);
               Assert.IsNotNull(ModelsRes.TideDataValueTideStart);
               Assert.IsNotNull(ModelsRes.TideDataValueTideEnd);
               Assert.IsNotNull(ModelsRes.TideDataValueLastUpdateDate_UTC);
               Assert.IsNotNull(ModelsRes.TideDataValueLastUpdateContactTVItemID);
               Assert.IsNotNull(ModelsRes.TideDataValueTideSiteTVItem);
        }
    }
}
