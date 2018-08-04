/*
 * Auto generated from the CSSPCodeWriter.proj by clicking on the [[ModelClassName]TestGenerated.cs] button
 *
 * Do not edit this file.
 *
 * Last generated by Charles on CHARLES-PC machine
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
    public partial class OtherFilesToUploadTest
    {
        #region Variables
        #endregion Variables

        #region Properties
        private OtherFilesToUpload otherFilesToUpload { get; set; }
        #endregion Properties

        #region Constructors
        public OtherFilesToUploadTest()
        {
            otherFilesToUpload = new OtherFilesToUpload();
        }
        #endregion Constructors

        #region Tests Functions public
        [TestMethod]
        public void OtherFilesToUpload_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "Error", "MikeScenarioID", "TVFileList", "HasErrors",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(OtherFilesToUpload).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
            {
                Assert.AreEqual(propertyInfo.Name, propNameList[index]);
                index += 1;
            }

            Assert.AreEqual(propNameList.Count, index);
        }
        [TestMethod]
        public void OtherFilesToUpload_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(OtherFilesToUpload).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void OtherFilesToUpload_Every_Property_Has_Get_Set_Test()
        {
               string val1 = "Some text";
               otherFilesToUpload.Error = val1;
               Assert.AreEqual(val1, otherFilesToUpload.Error);
               int val2 = 45;
               otherFilesToUpload.MikeScenarioID = val2;
               Assert.AreEqual(val2, otherFilesToUpload.MikeScenarioID);
               List<TVFile> val3 = new List<TVFile>() { new TVFile(), new TVFile() };
               otherFilesToUpload.TVFileList = val3;
               Assert.AreEqual(val3, otherFilesToUpload.TVFileList);
               bool val4 = true;
               otherFilesToUpload.HasErrors = val4;
               Assert.AreEqual(val4, otherFilesToUpload.HasErrors);
               IEnumerable<ValidationResult> val15 = new List<ValidationResult>() { new ValidationResult("First Error Message") }.AsEnumerable();
               otherFilesToUpload.ValidationResults = val15;
               Assert.AreEqual(val15, otherFilesToUpload.ValidationResults);
        }
        #endregion Tests Functions public
    }
}
