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
    public class ListBoxTestCases
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
        public void VerifyList1Selected()
        {
            _guiToy.SelectListItem1();
            _guiToy.ClickSetButtonListBox();
            string actual = _guiToy.ListBoxLabelText;
            string expected = "List 1 selected";
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void VerifyList2Selected()
        {
            _guiToy.SelectListItem2();
            _guiToy.ClickSetButtonListBox();
            string actual = _guiToy.ListBoxLabelText;
            string expected = "List 2 selected";
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void VerifyList3Selected()
        {
            _guiToy.SelectListItem3();
            _guiToy.ClickSetButtonListBox();
            string actual = _guiToy.ListBoxLabelText;
            string expected = "List 3 selected";
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void VerifyList123Selected()
        {
            _guiToy.SelectListItem1();
            _guiToy.SelectListItem2();
            _guiToy.SelectListItem3();
            _guiToy.ClickSetButtonListBox();
            string actual = _guiToy.ListBoxLabelText;
            string expected = "List 1,2,3 selected";
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void VerifyList12Selected()
        {
            _guiToy.SelectListItem1();
            _guiToy.SelectListItem2();
            _guiToy.ClickSetButtonListBox();
            string actual = _guiToy.ListBoxLabelText;
            string expected = "List 1,2 selected";
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void VerifyList13Selected()
        {
            _guiToy.SelectListItem1();
            _guiToy.SelectListItem3();
            _guiToy.ClickSetButtonListBox();
            string actual = _guiToy.ListBoxLabelText;
            string expected = "List 1,3 selected";
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void VerifyList23Selected()
        {
            _guiToy.SelectListItem2();
            _guiToy.SelectListItem3();
            _guiToy.ClickSetButtonListBox();
            string actual = _guiToy.ListBoxLabelText;
            string expected = "List 2,3 selected";
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void VerifyNothingIsSelectedInListBox()
        {
            _guiToy.ClickSetButtonListBox();
            string expected = "Nothing selected";
            string actual = _guiToy.ListBoxLabelText;
            Assert.AreEqual(expected, actual);
        }
    }
}
