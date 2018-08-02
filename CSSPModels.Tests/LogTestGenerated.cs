/*
 * Auto generated from the CSSPCodeWriter.proj by clicking on the [[ModelClassName]TestGenerated.cs] button
 *
 * Do not edit this file.
 *
 * Last generated by leblancc on WMON01DTCHLEBL2 machine
 *
 */ 
using System;
using System.Text;
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
    [TestClass]
    public partial class LogTest
    {
        #region Variables
        #endregion Variables

        #region Properties
        private Log log { get; set; }
        #endregion Properties

        #region Constructors
        public LogTest()
        {
            log = new Log();
        }
        #endregion Constructors

        #region Tests Functions public
        [TestMethod]
        public void Log_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "LogID", "TableName", "ID", "LogCommand", "Information", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() { "LogWeb", "LogReport", "HasErrors",  }.OrderBy(c => c).ToList();

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
               Assert.IsNotNull(CSSPModelsRes.LogLogID);
               Assert.IsNotNull(CSSPModelsRes.LogTableName);
               Assert.IsNotNull(CSSPModelsRes.LogID);
               Assert.IsNotNull(CSSPModelsRes.LogLogCommand);
               Assert.IsNotNull(CSSPModelsRes.LogInformation);
               Assert.IsNotNull(CSSPModelsRes.LogLastUpdateDate_UTC);
               Assert.IsNotNull(CSSPModelsRes.LogLastUpdateContactTVItemID);
               Assert.IsNotNull(CSSPModelsRes.LogHasErrors);
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
               bool val8 = true;
               log.HasErrors = val8;
               Assert.AreEqual(val8, log.HasErrors);
               IEnumerable<ValidationResult> val31 = new List<ValidationResult>() { new ValidationResult("First Error Message") }.AsEnumerable();
               log.ValidationResults = val31;
               Assert.AreEqual(val31, log.ValidationResults);
        }
        #endregion Tests Functions public
    }
}
