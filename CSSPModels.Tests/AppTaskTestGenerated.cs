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
    public partial class AppTaskTest
    {
        [TestMethod]
        public void AppTask_Properties_OK()
        {
            List<string> propNameList = new List<string>() { "AppTaskID", "TVItemID", "TVItemID2", "Command", "Status", "PercentCompleted", "Parameters", "Language", "StartDateTime_UTC", "EndDateTime_UTC", "EstimatedLength_second", "RemainingTime_second", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (IProperty propertyType in entityType.GetProperties().OrderBy(c => c.Name))
            {
                Assert.AreEqual(propNameList[index], propertyType.Name);
                index += 1;
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
        public void AppTask_Navigation_OK()
        {
            List<string> foreignNameList = new List<string>() { "TVItemIDNavigation", "TVItemID2Navigation",  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() { "AppTaskLanguages",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (string foreignName in (from c in entityType.GetForeignKeys() orderby c.DependentToPrincipal.Name select c.DependentToPrincipal.Name))
            {
                Assert.AreEqual(foreignNameList[index], foreignName);
                index += 1;
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
        public void AppTask_Has_ValidationResults_OK()
        {
             Assert.IsTrue(typeof(AppTask).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void AppTask_Every_Property_Has_A_Resource_OK()
        {
               Assert.IsNotNull(ModelsRes.AppTaskAppTaskID);
               Assert.IsNotNull(ModelsRes.AppTaskTVItemID);
               Assert.IsNotNull(ModelsRes.AppTaskTVItemID2);
               Assert.IsNotNull(ModelsRes.AppTaskCommand);
               Assert.IsNotNull(ModelsRes.AppTaskStatus);
               Assert.IsNotNull(ModelsRes.AppTaskPercentCompleted);
               Assert.IsNotNull(ModelsRes.AppTaskParameters);
               Assert.IsNotNull(ModelsRes.AppTaskLanguage);
               Assert.IsNotNull(ModelsRes.AppTaskStartDateTime_UTC);
               Assert.IsNotNull(ModelsRes.AppTaskEndDateTime_UTC);
               Assert.IsNotNull(ModelsRes.AppTaskEstimatedLength_second);
               Assert.IsNotNull(ModelsRes.AppTaskRemainingTime_second);
               Assert.IsNotNull(ModelsRes.AppTaskLastUpdateDate_UTC);
               Assert.IsNotNull(ModelsRes.AppTaskLastUpdateContactTVItemID);
               Assert.IsNotNull(ModelsRes.AppTaskAppTaskLanguages);
               Assert.IsNotNull(ModelsRes.AppTaskTVItemIDNavigation);
               Assert.IsNotNull(ModelsRes.AppTaskTVItemID2Navigation);
        }
    }
}
