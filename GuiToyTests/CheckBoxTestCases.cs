using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using GuiToyTestCore;
using System.Threading;

namespace GuiToyTests
{
   
    [TestFixture]
    public class CheckBoxTestCases
    {
        // Finished The Test Code...
        Core _guiToy = new Core();

        [SetUp]
        public void Setup()
        {   
            _guiToy.Open();
        }

        [TearDown]
        public void Close()
        {
            _guiToy.Close();
        }

        [Test]
        public void VerifyCheckBox2Selected()
        {
            _guiToy.SelectCheckBox2();
            _guiToy.ClickCheckBoxSetButton();
            string expected = "Check 2 selected";
            string actual = _guiToy.CheckBoxLabelText;
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void VerifyCheckBox1Selected()
        {
            _guiToy.SelectCheckBox1();
            _guiToy.ClickCheckBoxSetButton();
            string expected = "Check 1 selected";
            string actual = _guiToy.CheckBoxLabelText;
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void VerifyCheckBox3Selected()
        {
            _guiToy.SelectCheckBox3();
            _guiToy.ClickCheckBoxSetButton();
            string expected = "Check 3 selected";
            string actual = _guiToy.CheckBoxLabelText;
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void VerifyCheckBox123Selected()
        {
            _guiToy.SelectCheckBox1();
            _guiToy.SelectCheckBox2();
            _guiToy.SelectCheckBox3();
            _guiToy.ClickCheckBoxSetButton();
            string expected = "Check 1,2,3 selected";
            string actual = _guiToy.CheckBoxLabelText;
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void VerifyCheckBox12Selected()
        {
            _guiToy.SelectCheckBox1();
            _guiToy.SelectCheckBox2();
            _guiToy.ClickCheckBoxSetButton();
            string expected = "Check 1,2 selected";
            string actual = _guiToy.CheckBoxLabelText;
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void VerifyCheckBox13Selected()
        {
            _guiToy.SelectCheckBox1();
            _guiToy.SelectCheckBox3();
            _guiToy.ClickCheckBoxSetButton();
            string expected = "Check 1,3 selected";
            string actual = _guiToy.CheckBoxLabelText;
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void VerifyCheckBox23Selected()
        {
            _guiToy.SelectCheckBox2();
            _guiToy.SelectCheckBox3();
            _guiToy.ClickCheckBoxSetButton();
            string expected = "Check 2,3 selected";
            string actual = _guiToy.CheckBoxLabelText;
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void VerifyNothingIsSelectedInCheckBoxList()
        {
            _guiToy.ClickCheckBoxSetButton();
            string expected = "Nothing selected";
            string actual = _guiToy.CheckBoxLabelText;
            Assert.AreEqual(expected, actual);
        }
    }
}
