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
    public partial class CSSPMPNTableTest : SetupData
    {
        [TestMethod]
        public void CSSPMPNTable_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "Tube10", "Tube1_0", "Tube0_1", "MPN",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(CSSPMPNTable).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
            {
                Assert.AreEqual(propertyInfo.Name, propNameList[index]);
                index += 1;
            }

            Assert.AreEqual(propNameList.Count, index);
        }
        [TestMethod]
        public void CSSPMPNTable_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(CSSPMPNTable).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void CSSPMPNTable_Every_Property_Has_A_Resource_OK()
        {
               Assert.IsNotNull(ModelsRes.CSSPMPNTableTube10);
               Assert.IsNotNull(ModelsRes.CSSPMPNTableTube1_0);
               Assert.IsNotNull(ModelsRes.CSSPMPNTableTube0_1);
               Assert.IsNotNull(ModelsRes.CSSPMPNTableMPN);
        }
        [TestMethod]
        public void CSSPMPNTable_Every_Property_Has_Get_Set_Test()
        {
               int val1 = 45;
               cSSPMPNTable.Tube10 = val1;
               Assert.AreEqual(val1, cSSPMPNTable.Tube10);
               int val2 = 45;
               cSSPMPNTable.Tube1_0 = val2;
               Assert.AreEqual(val2, cSSPMPNTable.Tube1_0);
               int val3 = 45;
               cSSPMPNTable.Tube0_1 = val3;
               Assert.AreEqual(val3, cSSPMPNTable.Tube0_1);
               int val4 = 45;
               cSSPMPNTable.MPN = val4;
               Assert.AreEqual(val4, cSSPMPNTable.MPN);
               IEnumerable<ValidationResult> val15 = new List<ValidationResult>().AsEnumerable();
               cSSPMPNTable.ValidationResults = val15;
               Assert.AreEqual(val15, cSSPMPNTable.ValidationResults);
        }
    }
}
