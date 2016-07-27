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
    public class RadioButtonTestCases
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
        public void VerifyRadio1Selected()
        {
            _guiToy.SelectRadioButton1();
            _guiToy.ClickRadioSetButton();
            string actual = _guiToy.GetRadioButtonLabelText;
            string expected = "Radio 1 selected";
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void VerifyRadio2Selected()
        {
            _guiToy.SelectRadioButton2();
            _guiToy.ClickRadioSetButton();
            string actual = _guiToy.GetRadioButtonLabelText;
            string expected = "Radio 2 selected";
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void VerifyRadio3Selected()
        {
            _guiToy.SelectRadioButton3();
            _guiToy.ClickRadioSetButton();
            string actual = _guiToy.GetRadioButtonLabelText;
            string expected = "Radio 3 selected";
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void VerifyNothingIsSelectedInRadioList()
        {
            _guiToy.ClickRadioSetButton();
            string expected = "Nothing selected";
            string actual = _guiToy.GetRadioButtonLabelText;
            Assert.AreEqual(expected, actual);
        }
    }
}
