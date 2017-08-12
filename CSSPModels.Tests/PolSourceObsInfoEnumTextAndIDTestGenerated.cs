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
    public partial class PolSourceObsInfoEnumTextAndIDTest : SetupData
    {
        [TestMethod]
        public void PolSourceObsInfoEnumTextAndID_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "Text", "ID", "HasErrors",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(PolSourceObsInfoEnumTextAndID).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
            {
                Assert.AreEqual(propertyInfo.Name, propNameList[index]);
                index += 1;
            }

            Assert.AreEqual(propNameList.Count, index);
        }
        [TestMethod]
        public void PolSourceObsInfoEnumTextAndID_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(PolSourceObsInfoEnumTextAndID).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void PolSourceObsInfoEnumTextAndID_Every_Property_Has_A_Resource_OK()
        {
               Assert.IsNotNull(ModelsRes.PolSourceObsInfoEnumTextAndIDText);
               Assert.IsNotNull(ModelsRes.PolSourceObsInfoEnumTextAndIDID);
               Assert.IsNotNull(ModelsRes.PolSourceObsInfoEnumTextAndIDHasErrors);
        }
        [TestMethod]
        public void PolSourceObsInfoEnumTextAndID_Every_Property_Has_Get_Set_Test()
        {
               string val1 = "Some text";
               polSourceObsInfoEnumTextAndID.Text = val1;
               Assert.AreEqual(val1, polSourceObsInfoEnumTextAndID.Text);
               int val2 = 45;
               polSourceObsInfoEnumTextAndID.ID = val2;
               Assert.AreEqual(val2, polSourceObsInfoEnumTextAndID.ID);
               bool val3 = true;
               polSourceObsInfoEnumTextAndID.HasErrors = val3;
               Assert.AreEqual(val3, polSourceObsInfoEnumTextAndID.HasErrors);
               IEnumerable<ValidationResult> val12 = new List<ValidationResult>().AsEnumerable();
               polSourceObsInfoEnumTextAndID.ValidationResults = val12;
               Assert.AreEqual(val12, polSourceObsInfoEnumTextAndID.ValidationResults);
        }
    }
}
