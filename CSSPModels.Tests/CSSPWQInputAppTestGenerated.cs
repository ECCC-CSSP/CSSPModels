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
    public partial class CSSPWQInputAppTest
    {
        [TestMethod]
        public void CSSPWQInputApp_Properties_OK()
        {
            List<string> propNameList = new List<string>() { "AccessCode", "ActiveYear", "DailyDuplicatePrecisionCriteria", "IntertechDuplicatePrecisionCriteria", "IncludeLaboratoryQAQC", "ApprovalCode", "ApprovalDate",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(CSSPWQInputApp).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
            {
                Assert.AreEqual(propertyInfo.Name, propNameList[index]);
                index += 1;
            }

            Assert.AreEqual(propNameList.Count, index);
        }
        [TestMethod]
        public void CSSPWQInputApp_Has_ValidationResults_OK()
        {
             Assert.IsTrue(typeof(CSSPWQInputApp).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void CSSPWQInputApp_Every_Property_Has_A_Resource_OK()
        {
               Assert.IsNotNull(ModelsRes.CSSPWQInputAppAccessCode);
               Assert.IsNotNull(ModelsRes.CSSPWQInputAppActiveYear);
               Assert.IsNotNull(ModelsRes.CSSPWQInputAppDailyDuplicatePrecisionCriteria);
               Assert.IsNotNull(ModelsRes.CSSPWQInputAppIntertechDuplicatePrecisionCriteria);
               Assert.IsNotNull(ModelsRes.CSSPWQInputAppIncludeLaboratoryQAQC);
               Assert.IsNotNull(ModelsRes.CSSPWQInputAppApprovalCode);
               Assert.IsNotNull(ModelsRes.CSSPWQInputAppApprovalDate);
        }
    }
}
