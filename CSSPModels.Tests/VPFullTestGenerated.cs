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
    public partial class VPFullTest : SetupData
    {
        [TestMethod]
        public void VPFull_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "VPScenario", "AmbientList", "ResultList",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(VPFull).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
            {
                Assert.AreEqual(propertyInfo.Name, propNameList[index]);
                index += 1;
            }

            Assert.AreEqual(propNameList.Count, index);
        }
        [TestMethod]
        public void VPFull_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(VPFull).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void VPFull_Every_Property_Has_A_Resource_OK()
        {
               Assert.IsNotNull(ModelsRes.VPFullVPScenario);
               Assert.IsNotNull(ModelsRes.VPFullAmbientList);
               Assert.IsNotNull(ModelsRes.VPFullResultList);
        }
        [TestMethod]
        public void VPFull_Every_Property_Has_Get_Set_Test()
        {
               VPScenario val5 = new VPScenario();
               vPFull.VPScenario = val5;
               Assert.AreEqual(val5, vPFull.VPScenario);
               List<VPAmbient> val6 = new List<VPAmbient>();
               vPFull.AmbientList = val6;
               Assert.AreEqual(val6, vPFull.AmbientList);
               List<VPResult> val7 = new List<VPResult>();
               vPFull.ResultList = val7;
               Assert.AreEqual(val7, vPFull.ResultList);
               IEnumerable<ValidationResult> val12 = new List<ValidationResult>().AsEnumerable();
               vPFull.ValidationResults = val12;
               Assert.AreEqual(val12, vPFull.ValidationResults);
        }
    }
}
