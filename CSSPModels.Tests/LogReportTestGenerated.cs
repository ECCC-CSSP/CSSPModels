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
    public partial class LogReportTest
    {
        #region Variables
        #endregion Variables

        #region Properties
        private LogReport logReport { get; set; }
        #endregion Properties

        #region Constructors
        public LogReportTest()
        {
            logReport = new LogReport();
        }
        #endregion Constructors

        #region Tests
        [TestMethod]
        public void LogReport_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "LogReportTest",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(LogReport).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
            {
                Assert.AreEqual(propertyInfo.Name, propNameList[index]);
                index += 1;
            }

            Assert.AreEqual(propNameList.Count, index);
        }
        [TestMethod]
        public void LogReport_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(LogReport).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void LogReport_Every_Property_Has_A_Resource_OK()
        {
               Assert.IsNotNull(CSSPModelsRes.LogReportLogReportTest);
        }
        [TestMethod]
        public void LogReport_Every_Property_Has_Get_Set_Test()
        {
               string val1 = "Some text";
               logReport.LogReportTest = val1;
               Assert.AreEqual(val1, logReport.LogReportTest);
        }
        #endregion Tests
    }
}