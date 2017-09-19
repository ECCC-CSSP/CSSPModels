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
    public partial class PolSourceObsInfoChildTest
    {
        #region Variables
        #endregion Variables

        #region Properties
        private PolSourceObsInfoChild polSourceObsInfoChild { get; set; }
        #endregion Properties

        #region Constructors
        public PolSourceObsInfoChildTest()
        {
            polSourceObsInfoChild = new PolSourceObsInfoChild();
        }
        #endregion Constructors

        #region Tests
        [TestMethod]
        public void PolSourceObsInfoChild_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "PolSourceObsInfo", "PolSourceObsInfoChildStart", "PolSourceObsInfoText", "PolSourceObsInfoChildStartText", "HasErrors",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(PolSourceObsInfoChild).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
            {
                Assert.AreEqual(propertyInfo.Name, propNameList[index]);
                index += 1;
            }

            Assert.AreEqual(propNameList.Count, index);
        }
        [TestMethod]
        public void PolSourceObsInfoChild_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(PolSourceObsInfoChild).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void PolSourceObsInfoChild_Every_Property_Has_A_Resource_OK()
        {
               Assert.IsNotNull(CSSPModelsRes.PolSourceObsInfoChildPolSourceObsInfo);
               Assert.IsNotNull(CSSPModelsRes.PolSourceObsInfoChildPolSourceObsInfoChildStart);
               Assert.IsNotNull(CSSPModelsRes.PolSourceObsInfoChildPolSourceObsInfoText);
               Assert.IsNotNull(CSSPModelsRes.PolSourceObsInfoChildPolSourceObsInfoChildStartText);
               Assert.IsNotNull(CSSPModelsRes.PolSourceObsInfoChildHasErrors);
        }
        [TestMethod]
        public void PolSourceObsInfoChild_Every_Property_Has_Get_Set_Test()
        {
               PolSourceObsInfoEnum val1 = (PolSourceObsInfoEnum)3;
               polSourceObsInfoChild.PolSourceObsInfo = val1;
               Assert.AreEqual(val1, polSourceObsInfoChild.PolSourceObsInfo);
               PolSourceObsInfoEnum val2 = (PolSourceObsInfoEnum)3;
               polSourceObsInfoChild.PolSourceObsInfoChildStart = val2;
               Assert.AreEqual(val2, polSourceObsInfoChild.PolSourceObsInfoChildStart);
               string val3 = "Some text";
               polSourceObsInfoChild.PolSourceObsInfoText = val3;
               Assert.AreEqual(val3, polSourceObsInfoChild.PolSourceObsInfoText);
               string val4 = "Some text";
               polSourceObsInfoChild.PolSourceObsInfoChildStartText = val4;
               Assert.AreEqual(val4, polSourceObsInfoChild.PolSourceObsInfoChildStartText);
               bool val5 = true;
               polSourceObsInfoChild.HasErrors = val5;
               Assert.AreEqual(val5, polSourceObsInfoChild.HasErrors);
               IEnumerable<ValidationResult> val18 = new List<ValidationResult>().AsEnumerable();
               polSourceObsInfoChild.ValidationResults = val18;
               Assert.AreEqual(val18, polSourceObsInfoChild.ValidationResults);
        }
        #endregion Tests
    }
}
