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
    public partial class TideLocationReportTest
    {
        #region Variables
        #endregion Variables

        #region Properties
        private TideLocationReport tideLocationReport { get; set; }
        #endregion Properties

        #region Constructors
        public TideLocationReportTest()
        {
            tideLocationReport = new TideLocationReport();
        }
        #endregion Constructors

        #region Tests
        [TestMethod]
        public void TideLocationReport_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "TideLocationReportTest",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(TideLocationReport).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
            {
                Assert.AreEqual(propertyInfo.Name, propNameList[index]);
                index += 1;
            }

            Assert.AreEqual(propNameList.Count, index);
        }
        [TestMethod]
        public void TideLocationReport_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(TideLocationReport).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void TideLocationReport_Every_Property_Has_A_Resource_OK()
        {
               Assert.IsNotNull(CSSPModelsRes.TideLocationReportTideLocationReportTest);
        }
        [TestMethod]
        public void TideLocationReport_Every_Property_Has_Get_Set_Test()
        {
               string val1 = "Some text";
               tideLocationReport.TideLocationReportTest = val1;
               Assert.AreEqual(val1, tideLocationReport.TideLocationReportTest);
        }
        #endregion Tests
    }
}
