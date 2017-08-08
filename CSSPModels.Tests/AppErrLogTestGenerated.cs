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
    public partial class AppErrLogTest : SetupData
    {
        [TestMethod]
        public void AppErrLog_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "AppErrLogID", "Tag", "LineNumber", "Source", "Message", "DateTime_UTC", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() { "LastUpdateContactTVText",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(CSSPModels.AppErrLog).GetProperties().OrderBy(c => c.Name))
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
            foreach (PropertyInfo propertyInfo in typeof(AppErrLog).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void AppErrLog_Navigation_Test()
        {
            List<string> foreignNameList = new List<string>() {  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(AppErrLog).GetProperties())
            {
                if (propertyInfo.GetGetMethod().IsVirtual && !propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                {
                    Assert.IsTrue(foreignNameList.Contains(propertyInfo.Name));
                    index += 1;
                }
            }

            Assert.AreEqual(foreignNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(AppErrLog).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void AppErrLog_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(AppErrLog).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void AppErrLog_Every_Property_Has_A_Resource_OK()
        {
               Assert.IsNotNull(ModelsRes.AppErrLogAppErrLogID);
               Assert.IsNotNull(ModelsRes.AppErrLogTag);
               Assert.IsNotNull(ModelsRes.AppErrLogLineNumber);
               Assert.IsNotNull(ModelsRes.AppErrLogSource);
               Assert.IsNotNull(ModelsRes.AppErrLogMessage);
               Assert.IsNotNull(ModelsRes.AppErrLogDateTime_UTC);
               Assert.IsNotNull(ModelsRes.AppErrLogLastUpdateDate_UTC);
               Assert.IsNotNull(ModelsRes.AppErrLogLastUpdateContactTVItemID);
               Assert.IsNotNull(ModelsRes.AppErrLogLastUpdateContactTVText);
        }
        [TestMethod]
        public void AppErrLog_Every_Property_Has_Get_Set_Test()
        {
               int val1 = 45;
               appErrLog.AppErrLogID = val1;
               Assert.AreEqual(val1, appErrLog.AppErrLogID);
               string val2 = "Some text";
               appErrLog.Tag = val2;
               Assert.AreEqual(val2, appErrLog.Tag);
               int val3 = 45;
               appErrLog.LineNumber = val3;
               Assert.AreEqual(val3, appErrLog.LineNumber);
               string val4 = "Some text";
               appErrLog.Source = val4;
               Assert.AreEqual(val4, appErrLog.Source);
               string val5 = "Some text";
               appErrLog.Message = val5;
               Assert.AreEqual(val5, appErrLog.Message);
               DateTime val6 = new DateTime(2010, 3, 4);
               appErrLog.DateTime_UTC = val6;
               Assert.AreEqual(val6, appErrLog.DateTime_UTC);
               DateTime val7 = new DateTime(2010, 3, 4);
               appErrLog.LastUpdateDate_UTC = val7;
               Assert.AreEqual(val7, appErrLog.LastUpdateDate_UTC);
               int val8 = 45;
               appErrLog.LastUpdateContactTVItemID = val8;
               Assert.AreEqual(val8, appErrLog.LastUpdateContactTVItemID);
               string val9 = "Some text";
               appErrLog.LastUpdateContactTVText = val9;
               Assert.AreEqual(val9, appErrLog.LastUpdateContactTVText);
               IEnumerable<ValidationResult> val30 = new List<ValidationResult>().AsEnumerable();
               appErrLog.ValidationResults = val30;
               Assert.AreEqual(val30, appErrLog.ValidationResults);
        }
    }
}
