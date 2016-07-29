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
    public class ComboBoxTestCases
    {
        // Finished The Test Code....
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
        public void VerifyCombo1Selected()
        {
            _guiToy.ClickComboDropDownArrow();
            _guiToy.SelectCombo1();
            _guiToy.ClickComboSetButton();
            string actual = _guiToy.ComboLabelText;
            string expected = "Combo 1 selected";
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void VerifyCombo2Selected()
        {
            _guiToy.ClickComboDropDownArrow();
            _guiToy.SelectCombo2();
            _guiToy.ClickComboSetButton();
            string actual = _guiToy.ComboLabelText;
            string expected = "Combo 2 selected";
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void VerifyCombo3Selected()
        {
            _guiToy.ClickComboDropDownArrow();
            _guiToy.SelectCombo3();
            _guiToy.ClickComboSetButton();
            string actual = _guiToy.ComboLabelText;
            string expected = "Combo 3 selected";
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void VerifyNothingIsSelectedInComboBox()
        {
            _guiToy.ClickComboSetButton();
            string actual = _guiToy.ComboLabelText;
            string expected = "Nothing selected";
            Assert.AreEqual(expected, actual);
        }
    }
}
