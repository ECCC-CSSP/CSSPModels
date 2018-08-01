/*
 * Auto generated from the CSSPCodeWriter.proj by clicking on the [[ModelClassName]TestGenerated.cs] button
 *
 * Do not edit this file.
 *
 * Last generated on 2018 August 01 05:00
 * by leblancc on WMON01DTCHLEBL2 machine
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
    public partial class PolSourceInactiveReasonEnumTextAndIDTest
    {
        #region Variables
        #endregion Variables

        #region Properties
        private PolSourceInactiveReasonEnumTextAndID polSourceInactiveReasonEnumTextAndID { get; set; }
        #endregion Properties

        #region Constructors
        public PolSourceInactiveReasonEnumTextAndIDTest()
        {
            polSourceInactiveReasonEnumTextAndID = new PolSourceInactiveReasonEnumTextAndID();
        }
        #endregion Constructors

        #region Tests Functions public
        [TestMethod]
        public void PolSourceInactiveReasonEnumTextAndID_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "Text", "ID", "HasErrors",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(PolSourceInactiveReasonEnumTextAndID).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
            {
                Assert.AreEqual(propertyInfo.Name, propNameList[index]);
                index += 1;
            }

            Assert.AreEqual(propNameList.Count, index);
        }
        [TestMethod]
        public void PolSourceInactiveReasonEnumTextAndID_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(PolSourceInactiveReasonEnumTextAndID).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void PolSourceInactiveReasonEnumTextAndID_Every_Property_Has_A_Resource_OK()
        {
               Assert.IsNotNull(CSSPModelsRes.PolSourceInactiveReasonEnumTextAndIDText);
               Assert.IsNotNull(CSSPModelsRes.PolSourceInactiveReasonEnumTextAndIDID);
               Assert.IsNotNull(CSSPModelsRes.PolSourceInactiveReasonEnumTextAndIDHasErrors);
        }
        [TestMethod]
        public void PolSourceInactiveReasonEnumTextAndID_Every_Property_Has_Get_Set_Test()
        {
               string val1 = "Some text";
               polSourceInactiveReasonEnumTextAndID.Text = val1;
               Assert.AreEqual(val1, polSourceInactiveReasonEnumTextAndID.Text);
               int val2 = 45;
               polSourceInactiveReasonEnumTextAndID.ID = val2;
               Assert.AreEqual(val2, polSourceInactiveReasonEnumTextAndID.ID);
               bool val3 = true;
               polSourceInactiveReasonEnumTextAndID.HasErrors = val3;
               Assert.AreEqual(val3, polSourceInactiveReasonEnumTextAndID.HasErrors);
               IEnumerable<ValidationResult> val12 = new List<ValidationResult>().AsEnumerable();
               polSourceInactiveReasonEnumTextAndID.ValidationResults = val12;
               Assert.AreEqual(val12, polSourceInactiveReasonEnumTextAndID.ValidationResults);
        }
        #endregion Tests Functions public
    }
}
