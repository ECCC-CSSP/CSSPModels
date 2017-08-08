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
    public partial class LogTest : SetupData
    {
        [TestMethod]
        public void Log_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "LogID", "TableName", "ID", "LogCommand", "Information", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() { "LastUpdateContactTVText", "LogCommandText",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(CSSPModels.Log).GetProperties().OrderBy(c => c.Name))
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
            foreach (PropertyInfo propertyInfo in typeof(Log).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void Log_Navigation_Test()
        {
            List<string> foreignNameList = new List<string>() {  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(Log).GetProperties())
            {
                if (propertyInfo.GetGetMethod().IsVirtual && !propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                {
                    Assert.IsTrue(foreignNameList.Contains(propertyInfo.Name));
                    index += 1;
                }
            }

            Assert.AreEqual(foreignNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(Log).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void Log_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(Log).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void Log_Every_Property_Has_A_Resource_OK()
        {
               Assert.IsNotNull(ModelsRes.LogLogID);
               Assert.IsNotNull(ModelsRes.LogTableName);
               Assert.IsNotNull(ModelsRes.LogID);
               Assert.IsNotNull(ModelsRes.LogLogCommand);
               Assert.IsNotNull(ModelsRes.LogInformation);
               Assert.IsNotNull(ModelsRes.LogLastUpdateDate_UTC);
               Assert.IsNotNull(ModelsRes.LogLastUpdateContactTVItemID);
               Assert.IsNotNull(ModelsRes.LogLastUpdateContactTVText);
               Assert.IsNotNull(ModelsRes.LogLogCommandText);
        }
        [TestMethod]
        public void Log_Every_Property_Has_Get_Set_Test()
        {
               int val1 = 45;
               log.LogID = val1;
               Assert.AreEqual(val1, log.LogID);
               string val2 = "Some text";
               log.TableName = val2;
               Assert.AreEqual(val2, log.TableName);
               int val3 = 45;
               log.ID = val3;
               Assert.AreEqual(val3, log.ID);
               LogCommandEnum val4 = (LogCommandEnum)3;
               log.LogCommand = val4;
               Assert.AreEqual(val4, log.LogCommand);
               string val5 = "Some text";
               log.Information = val5;
               Assert.AreEqual(val5, log.Information);
               DateTime val6 = new DateTime(2010, 3, 4);
               log.LastUpdateDate_UTC = val6;
               Assert.AreEqual(val6, log.LastUpdateDate_UTC);
               int val7 = 45;
               log.LastUpdateContactTVItemID = val7;
               Assert.AreEqual(val7, log.LastUpdateContactTVItemID);
               string val8 = "Some text";
               log.LastUpdateContactTVText = val8;
               Assert.AreEqual(val8, log.LastUpdateContactTVText);
               string val9 = "Some text";
               log.LogCommandText = val9;
               Assert.AreEqual(val9, log.LogCommandText);
               IEnumerable<ValidationResult> val30 = new List<ValidationResult>().AsEnumerable();
               log.ValidationResults = val30;
               Assert.AreEqual(val30, log.ValidationResults);
        }
    }
}
