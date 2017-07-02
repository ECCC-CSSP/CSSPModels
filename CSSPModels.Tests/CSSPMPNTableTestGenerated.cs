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
    public partial class CSSPMPNTableTest
    {
        [TestMethod]
        public void CSSPMPNTable_Properties_OK()
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
        public void CSSPMPNTable_Has_ValidationResults_OK()
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
    }
}
