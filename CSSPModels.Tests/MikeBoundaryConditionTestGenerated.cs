using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System.Globalization;
using System.Transactions;
using System.Collections.Generic;
using CSSPModels.Resources;
using Microsoft.EntityFrameworkCore.Metadata;
using System.Reflection;
using CSSPEnums;
using System.ComponentModel.DataAnnotations;

namespace CSSPModels.Tests
{
    public partial class MikeBoundaryConditionTest : SetupData
    {
        [TestMethod]
        public void MikeBoundaryCondition_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "MikeBoundaryConditionID", "MikeBoundaryConditionTVItemID", "MikeBoundaryConditionCode", "MikeBoundaryConditionName", "MikeBoundaryConditionLength_m", "MikeBoundaryConditionFormat", "MikeBoundaryConditionLevelOrVelocity", "WebTideDataSet", "NumberOfWebTideNodes", "WebTideDataFromStartToEndDate", "TVType", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() { "MikeBoundaryConditionTVText", "LastUpdateContactTVText", "MikeBoundaryConditionLevelOrVelocityText", "WebTideDataSetText", "TVTypeText", "HasErrors",  }.OrderBy(c => c).ToList();

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
        public void MikeBoundaryCondition_Navigation_Test()
        {
            List<string> foreignNameList = new List<string>() {  }.OrderBy(c => c).ToList();
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
        public void MikeBoundaryCondition_Has_ValidationResults_Test()
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
               Assert.IsNotNull(ModelsRes.MikeBoundaryConditionMikeBoundaryConditionTVText);
               Assert.IsNotNull(ModelsRes.MikeBoundaryConditionLastUpdateContactTVText);
               Assert.IsNotNull(ModelsRes.MikeBoundaryConditionMikeBoundaryConditionLevelOrVelocityText);
               Assert.IsNotNull(ModelsRes.MikeBoundaryConditionWebTideDataSetText);
               Assert.IsNotNull(ModelsRes.MikeBoundaryConditionTVTypeText);
               Assert.IsNotNull(ModelsRes.MikeBoundaryConditionHasErrors);
        }
        [TestMethod]
        public void MikeBoundaryCondition_Every_Property_Has_Get_Set_Test()
        {
               int val1 = 45;
               mikeBoundaryCondition.MikeBoundaryConditionID = val1;
               Assert.AreEqual(val1, mikeBoundaryCondition.MikeBoundaryConditionID);
               int val2 = 45;
               mikeBoundaryCondition.MikeBoundaryConditionTVItemID = val2;
               Assert.AreEqual(val2, mikeBoundaryCondition.MikeBoundaryConditionTVItemID);
               string val3 = "Some text";
               mikeBoundaryCondition.MikeBoundaryConditionCode = val3;
               Assert.AreEqual(val3, mikeBoundaryCondition.MikeBoundaryConditionCode);
               string val4 = "Some text";
               mikeBoundaryCondition.MikeBoundaryConditionName = val4;
               Assert.AreEqual(val4, mikeBoundaryCondition.MikeBoundaryConditionName);
               double val5 = 87.9D;
               mikeBoundaryCondition.MikeBoundaryConditionLength_m = val5;
               Assert.AreEqual(val5, mikeBoundaryCondition.MikeBoundaryConditionLength_m);
               string val6 = "Some text";
               mikeBoundaryCondition.MikeBoundaryConditionFormat = val6;
               Assert.AreEqual(val6, mikeBoundaryCondition.MikeBoundaryConditionFormat);
               MikeBoundaryConditionLevelOrVelocityEnum val7 = (MikeBoundaryConditionLevelOrVelocityEnum)3;
               mikeBoundaryCondition.MikeBoundaryConditionLevelOrVelocity = val7;
               Assert.AreEqual(val7, mikeBoundaryCondition.MikeBoundaryConditionLevelOrVelocity);
               WebTideDataSetEnum val8 = (WebTideDataSetEnum)3;
               mikeBoundaryCondition.WebTideDataSet = val8;
               Assert.AreEqual(val8, mikeBoundaryCondition.WebTideDataSet);
               int val9 = 45;
               mikeBoundaryCondition.NumberOfWebTideNodes = val9;
               Assert.AreEqual(val9, mikeBoundaryCondition.NumberOfWebTideNodes);
               string val10 = "Some text";
               mikeBoundaryCondition.WebTideDataFromStartToEndDate = val10;
               Assert.AreEqual(val10, mikeBoundaryCondition.WebTideDataFromStartToEndDate);
               TVTypeEnum val11 = (TVTypeEnum)3;
               mikeBoundaryCondition.TVType = val11;
               Assert.AreEqual(val11, mikeBoundaryCondition.TVType);
               DateTime val12 = new DateTime(2010, 3, 4);
               mikeBoundaryCondition.LastUpdateDate_UTC = val12;
               Assert.AreEqual(val12, mikeBoundaryCondition.LastUpdateDate_UTC);
               int val13 = 45;
               mikeBoundaryCondition.LastUpdateContactTVItemID = val13;
               Assert.AreEqual(val13, mikeBoundaryCondition.LastUpdateContactTVItemID);
               string val14 = "Some text";
               mikeBoundaryCondition.MikeBoundaryConditionTVText = val14;
               Assert.AreEqual(val14, mikeBoundaryCondition.MikeBoundaryConditionTVText);
               string val15 = "Some text";
               mikeBoundaryCondition.LastUpdateContactTVText = val15;
               Assert.AreEqual(val15, mikeBoundaryCondition.LastUpdateContactTVText);
               string val16 = "Some text";
               mikeBoundaryCondition.MikeBoundaryConditionLevelOrVelocityText = val16;
               Assert.AreEqual(val16, mikeBoundaryCondition.MikeBoundaryConditionLevelOrVelocityText);
               string val17 = "Some text";
               mikeBoundaryCondition.WebTideDataSetText = val17;
               Assert.AreEqual(val17, mikeBoundaryCondition.WebTideDataSetText);
               string val18 = "Some text";
               mikeBoundaryCondition.TVTypeText = val18;
               Assert.AreEqual(val18, mikeBoundaryCondition.TVTypeText);
               bool val19 = true;
               mikeBoundaryCondition.HasErrors = val19;
               Assert.AreEqual(val19, mikeBoundaryCondition.HasErrors);
               IEnumerable<ValidationResult> val60 = new List<ValidationResult>().AsEnumerable();
               mikeBoundaryCondition.ValidationResults = val60;
               Assert.AreEqual(val60, mikeBoundaryCondition.ValidationResults);
        }
    }
}
