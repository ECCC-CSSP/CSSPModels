/*
 * Auto generated from the CSSPModelsGenerateCode.proj
 *
 * Do not edit this file.
 *
 * Last generated by Charles LeBlanc
 *
 */ 
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
    [TestClass]
    public partial class AppTaskTest
    {
        #region Variables
        #endregion Variables

        #region Properties
        private AppTask appTask { get; set; }
        #endregion Properties

        #region Constructors
        public AppTaskTest()
        {
            appTask = new AppTask();
        }
        #endregion Constructors

        #region Tests
        [TestMethod]
        public void AppTask_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "AppTaskID", "TVItemID", "TVItemID2", "AppTaskCommand", "AppTaskStatus", "PercentCompleted", "Parameters", "Language", "StartDateTime_UTC", "EndDateTime_UTC", "EstimatedLength_second", "RemainingTime_second", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() { "TVItemTVText", "TVItem2TVText", "LastUpdateContactTVText", "AppTaskCommandText", "AppTaskStatusText", "LanguageText", "HasErrors",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(CSSPModels.AppTask).GetProperties().OrderBy(c => c.Name))
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
            foreach (PropertyInfo propertyInfo in typeof(AppTask).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void AppTask_Navigation_Test()
        {
            List<string> foreignNameList = new List<string>() {  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(AppTask).GetProperties())
            {
                if (propertyInfo.GetGetMethod().IsVirtual && !propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                {
                    Assert.IsTrue(foreignNameList.Contains(propertyInfo.Name));
                    index += 1;
                }
            }

            Assert.AreEqual(foreignNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(AppTask).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void AppTask_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(AppTask).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void AppTask_Every_Property_Has_A_Resource_OK()
        {
               Assert.IsNotNull(CSSPModelsRes.AppTaskAppTaskID);
               Assert.IsNotNull(CSSPModelsRes.AppTaskTVItemID);
               Assert.IsNotNull(CSSPModelsRes.AppTaskTVItemID2);
               Assert.IsNotNull(CSSPModelsRes.AppTaskAppTaskCommand);
               Assert.IsNotNull(CSSPModelsRes.AppTaskAppTaskStatus);
               Assert.IsNotNull(CSSPModelsRes.AppTaskPercentCompleted);
               Assert.IsNotNull(CSSPModelsRes.AppTaskParameters);
               Assert.IsNotNull(CSSPModelsRes.AppTaskLanguage);
               Assert.IsNotNull(CSSPModelsRes.AppTaskStartDateTime_UTC);
               Assert.IsNotNull(CSSPModelsRes.AppTaskEndDateTime_UTC);
               Assert.IsNotNull(CSSPModelsRes.AppTaskEstimatedLength_second);
               Assert.IsNotNull(CSSPModelsRes.AppTaskRemainingTime_second);
               Assert.IsNotNull(CSSPModelsRes.AppTaskLastUpdateDate_UTC);
               Assert.IsNotNull(CSSPModelsRes.AppTaskLastUpdateContactTVItemID);
               Assert.IsNotNull(CSSPModelsRes.AppTaskTVItemTVText);
               Assert.IsNotNull(CSSPModelsRes.AppTaskTVItem2TVText);
               Assert.IsNotNull(CSSPModelsRes.AppTaskLastUpdateContactTVText);
               Assert.IsNotNull(CSSPModelsRes.AppTaskAppTaskCommandText);
               Assert.IsNotNull(CSSPModelsRes.AppTaskAppTaskStatusText);
               Assert.IsNotNull(CSSPModelsRes.AppTaskLanguageText);
               Assert.IsNotNull(CSSPModelsRes.AppTaskHasErrors);
        }
        [TestMethod]
        public void AppTask_Every_Property_Has_Get_Set_Test()
        {
               int val1 = 45;
               appTask.AppTaskID = val1;
               Assert.AreEqual(val1, appTask.AppTaskID);
               int val2 = 45;
               appTask.TVItemID = val2;
               Assert.AreEqual(val2, appTask.TVItemID);
               int val3 = 45;
               appTask.TVItemID2 = val3;
               Assert.AreEqual(val3, appTask.TVItemID2);
               AppTaskCommandEnum val4 = (AppTaskCommandEnum)3;
               appTask.AppTaskCommand = val4;
               Assert.AreEqual(val4, appTask.AppTaskCommand);
               AppTaskStatusEnum val5 = (AppTaskStatusEnum)3;
               appTask.AppTaskStatus = val5;
               Assert.AreEqual(val5, appTask.AppTaskStatus);
               int val6 = 45;
               appTask.PercentCompleted = val6;
               Assert.AreEqual(val6, appTask.PercentCompleted);
               string val7 = "Some text";
               appTask.Parameters = val7;
               Assert.AreEqual(val7, appTask.Parameters);
               LanguageEnum val8 = (LanguageEnum)3;
               appTask.Language = val8;
               Assert.AreEqual(val8, appTask.Language);
               DateTime val9 = new DateTime(2010, 3, 4);
               appTask.StartDateTime_UTC = val9;
               Assert.AreEqual(val9, appTask.StartDateTime_UTC);
               DateTime val10 = new DateTime(2010, 3, 4);
               appTask.EndDateTime_UTC = val10;
               Assert.AreEqual(val10, appTask.EndDateTime_UTC);
               int val11 = 45;
               appTask.EstimatedLength_second = val11;
               Assert.AreEqual(val11, appTask.EstimatedLength_second);
               int val12 = 45;
               appTask.RemainingTime_second = val12;
               Assert.AreEqual(val12, appTask.RemainingTime_second);
               DateTime val13 = new DateTime(2010, 3, 4);
               appTask.LastUpdateDate_UTC = val13;
               Assert.AreEqual(val13, appTask.LastUpdateDate_UTC);
               int val14 = 45;
               appTask.LastUpdateContactTVItemID = val14;
               Assert.AreEqual(val14, appTask.LastUpdateContactTVItemID);
               string val15 = "Some text";
               appTask.TVItemTVText = val15;
               Assert.AreEqual(val15, appTask.TVItemTVText);
               string val16 = "Some text";
               appTask.TVItem2TVText = val16;
               Assert.AreEqual(val16, appTask.TVItem2TVText);
               string val17 = "Some text";
               appTask.LastUpdateContactTVText = val17;
               Assert.AreEqual(val17, appTask.LastUpdateContactTVText);
               string val18 = "Some text";
               appTask.AppTaskCommandText = val18;
               Assert.AreEqual(val18, appTask.AppTaskCommandText);
               string val19 = "Some text";
               appTask.AppTaskStatusText = val19;
               Assert.AreEqual(val19, appTask.AppTaskStatusText);
               string val20 = "Some text";
               appTask.LanguageText = val20;
               Assert.AreEqual(val20, appTask.LanguageText);
               bool val21 = true;
               appTask.HasErrors = val21;
               Assert.AreEqual(val21, appTask.HasErrors);
               IEnumerable<ValidationResult> val66 = new List<ValidationResult>().AsEnumerable();
               appTask.ValidationResults = val66;
               Assert.AreEqual(val66, appTask.ValidationResults);
        }
        #endregion Tests
    }
}
