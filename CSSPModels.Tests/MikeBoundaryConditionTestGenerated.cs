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
    public partial class MikeBoundaryConditionTest
    {
        [TestMethod]
        public void MikeBoundaryCondition_Properties_OK()
        {
            List<string> propNameList = new List<string>() { "MikeBoundaryConditionID", "MikeBoundaryConditionTVItemID", "MikeBoundaryConditionCode", "MikeBoundaryConditionName", "MikeBoundaryConditionLength_m", "MikeBoundaryConditionFormat", "MikeBoundaryConditionLevelOrVelocity", "WebTideDataSet", "NumberOfWebTideNodes", "WebTideDataFromStartToEndDate", "TVType", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(CSSPModels.MikeBoundaryCondition).GetProperties().OrderBy(c => c.Name))
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
            foreach (PropertyInfo propertyInfo in typeof(MikeBoundaryCondition).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void MikeBoundaryCondition_Navigation_OK()
        {
            List<string> foreignNameList = new List<string>() { "MikeBoundaryConditionTVItem",  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(MikeBoundaryCondition).GetProperties())
            {
                if (propertyInfo.GetGetMethod().IsVirtual && !propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                {
                    Assert.IsTrue(foreignNameList.Contains(propertyInfo.Name));
                    index += 1;
                }
            }

            Assert.AreEqual(foreignNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(MikeBoundaryCondition).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void MikeBoundaryCondition_Has_ValidationResults_OK()
        {
             Assert.IsTrue(typeof(MikeBoundaryCondition).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void MikeBoundaryCondition_Every_Property_Has_A_Resource_OK()
        {
               Assert.IsNotNull(ModelsRes.MikeBoundaryConditionMikeBoundaryConditionID);
               Assert.IsNotNull(ModelsRes.MikeBoundaryConditionMikeBoundaryConditionTVItemID);
               Assert.IsNotNull(ModelsRes.MikeBoundaryConditionMikeBoundaryConditionCode);
               Assert.IsNotNull(ModelsRes.MikeBoundaryConditionMikeBoundaryConditionName);
               Assert.IsNotNull(ModelsRes.MikeBoundaryConditionMikeBoundaryConditionLength_m);
               Assert.IsNotNull(ModelsRes.MikeBoundaryConditionMikeBoundaryConditionFormat);
               Assert.IsNotNull(ModelsRes.MikeBoundaryConditionMikeBoundaryConditionLevelOrVelocity);
               Assert.IsNotNull(ModelsRes.MikeBoundaryConditionWebTideDataSet);
               Assert.IsNotNull(ModelsRes.MikeBoundaryConditionNumberOfWebTideNodes);
               Assert.IsNotNull(ModelsRes.MikeBoundaryConditionWebTideDataFromStartToEndDate);
               Assert.IsNotNull(ModelsRes.MikeBoundaryConditionTVType);
               Assert.IsNotNull(ModelsRes.MikeBoundaryConditionLastUpdateDate_UTC);
               Assert.IsNotNull(ModelsRes.MikeBoundaryConditionLastUpdateContactTVItemID);
               Assert.IsNotNull(ModelsRes.MikeBoundaryConditionMikeBoundaryConditionTVItem);
        }
    }
}
