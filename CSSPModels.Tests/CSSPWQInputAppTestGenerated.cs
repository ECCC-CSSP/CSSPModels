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
    public partial class CSSPWQInputAppTest : SetupData
    {
        [TestMethod]
        public void CSSPWQInputApp_Properties_Test()
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
        public void CSSPWQInputApp_Has_ValidationResults_Test()
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
        [TestMethod]
        public void CSSPWQInputApp_Every_Property_Has_Get_Set_Test()
        {
               string val1 = "Some text";
               cSSPWQInputApp.AccessCode = val1;
               Assert.AreEqual(val1, cSSPWQInputApp.AccessCode);
               string val2 = "Some text";
               cSSPWQInputApp.ActiveYear = val2;
               Assert.AreEqual(val2, cSSPWQInputApp.ActiveYear);
               double val3 = 87.9D;
               cSSPWQInputApp.DailyDuplicatePrecisionCriteria = val3;
               Assert.AreEqual(val3, cSSPWQInputApp.DailyDuplicatePrecisionCriteria);
               double val4 = 87.9D;
               cSSPWQInputApp.IntertechDuplicatePrecisionCriteria = val4;
               Assert.AreEqual(val4, cSSPWQInputApp.IntertechDuplicatePrecisionCriteria);
               bool val5 = true;
               cSSPWQInputApp.IncludeLaboratoryQAQC = val5;
               Assert.AreEqual(val5, cSSPWQInputApp.IncludeLaboratoryQAQC);
               string val6 = "Some text";
               cSSPWQInputApp.ApprovalCode = val6;
               Assert.AreEqual(val6, cSSPWQInputApp.ApprovalCode);
               DateTime val7 = new DateTime(2010, 3, 4);
               cSSPWQInputApp.ApprovalDate = val7;
               Assert.AreEqual(val7, cSSPWQInputApp.ApprovalDate);
               IEnumerable<ValidationResult> val24 = new List<ValidationResult>().AsEnumerable();
               cSSPWQInputApp.ValidationResults = val24;
               Assert.AreEqual(val24, cSSPWQInputApp.ValidationResults);
        }
    }
}
