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
    public partial class BoxModelCalNumbTest
    {
        #region Variables
        #endregion Variables

        #region Properties
        private BoxModelCalNumb boxModelCalNumb { get; set; }
        #endregion Properties

        #region Constructors
        public BoxModelCalNumbTest()
        {
            boxModelCalNumb = new BoxModelCalNumb();
        }
        #endregion Constructors

        #region Tests
        [TestMethod]
        public void BoxModelCalNumb_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "Error", "BoxModelResultType", "CalLength_m", "CalRadius_m", "CalSurface_m2", "CalVolume_m3", "CalWidth_m", "FixLength", "FixWidth", "BoxModelResultTypeText", "HasErrors",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(BoxModelCalNumb).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
            {
                Assert.AreEqual(propertyInfo.Name, propNameList[index]);
                index += 1;
            }

            Assert.AreEqual(propNameList.Count, index);
        }
        [TestMethod]
        public void BoxModelCalNumb_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(BoxModelCalNumb).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void BoxModelCalNumb_Every_Property_Has_A_Resource_OK()
        {
               Assert.IsNotNull(CSSPModelsRes.BoxModelCalNumbError);
               Assert.IsNotNull(CSSPModelsRes.BoxModelCalNumbBoxModelResultType);
               Assert.IsNotNull(CSSPModelsRes.BoxModelCalNumbCalLength_m);
               Assert.IsNotNull(CSSPModelsRes.BoxModelCalNumbCalRadius_m);
               Assert.IsNotNull(CSSPModelsRes.BoxModelCalNumbCalSurface_m2);
               Assert.IsNotNull(CSSPModelsRes.BoxModelCalNumbCalVolume_m3);
               Assert.IsNotNull(CSSPModelsRes.BoxModelCalNumbCalWidth_m);
               Assert.IsNotNull(CSSPModelsRes.BoxModelCalNumbFixLength);
               Assert.IsNotNull(CSSPModelsRes.BoxModelCalNumbFixWidth);
               Assert.IsNotNull(CSSPModelsRes.BoxModelCalNumbBoxModelResultTypeText);
               Assert.IsNotNull(CSSPModelsRes.BoxModelCalNumbHasErrors);
        }
        [TestMethod]
        public void BoxModelCalNumb_Every_Property_Has_Get_Set_Test()
        {
               string val1 = "Some text";
               boxModelCalNumb.Error = val1;
               Assert.AreEqual(val1, boxModelCalNumb.Error);
               BoxModelResultTypeEnum val2 = (BoxModelResultTypeEnum)3;
               boxModelCalNumb.BoxModelResultType = val2;
               Assert.AreEqual(val2, boxModelCalNumb.BoxModelResultType);
               double val3 = 87.9D;
               boxModelCalNumb.CalLength_m = val3;
               Assert.AreEqual(val3, boxModelCalNumb.CalLength_m);
               double val4 = 87.9D;
               boxModelCalNumb.CalRadius_m = val4;
               Assert.AreEqual(val4, boxModelCalNumb.CalRadius_m);
               double val5 = 87.9D;
               boxModelCalNumb.CalSurface_m2 = val5;
               Assert.AreEqual(val5, boxModelCalNumb.CalSurface_m2);
               double val6 = 87.9D;
               boxModelCalNumb.CalVolume_m3 = val6;
               Assert.AreEqual(val6, boxModelCalNumb.CalVolume_m3);
               double val7 = 87.9D;
               boxModelCalNumb.CalWidth_m = val7;
               Assert.AreEqual(val7, boxModelCalNumb.CalWidth_m);
               bool val8 = true;
               boxModelCalNumb.FixLength = val8;
               Assert.AreEqual(val8, boxModelCalNumb.FixLength);
               bool val9 = true;
               boxModelCalNumb.FixWidth = val9;
               Assert.AreEqual(val9, boxModelCalNumb.FixWidth);
               string val10 = "Some text";
               boxModelCalNumb.BoxModelResultTypeText = val10;
               Assert.AreEqual(val10, boxModelCalNumb.BoxModelResultTypeText);
               bool val11 = true;
               boxModelCalNumb.HasErrors = val11;
               Assert.AreEqual(val11, boxModelCalNumb.HasErrors);
               IEnumerable<ValidationResult> val36 = new List<ValidationResult>().AsEnumerable();
               boxModelCalNumb.ValidationResults = val36;
               Assert.AreEqual(val36, boxModelCalNumb.ValidationResults);
        }
        #endregion Tests
    }
}
