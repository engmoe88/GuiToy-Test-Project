using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestStack.White;
using TestStack.White.UIItems.WindowItems;
using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems;

namespace GuiToyTestCore
{
   
    public class Core
    {
        Application _guitoyApp;
        Window _guitoyWindow;

        string _appPathName = @"C:\Users\Mohammed\Desktop\GuiToy\GuiToy\bin\Debug\GuiToy.exe";
        string _windowname = "GuiToy";
        #region CheckBoxes
        SearchCriteria _checkBox2 = SearchCriteria.ByAutomationId("checkBox2");
        SearchCriteria _checkBox3 = SearchCriteria.ByAutomationId("checkBox3");
        SearchCriteria _checkBox1 = SearchCriteria.ByAutomationId("checkBox1");
        SearchCriteria _checkBoxSetButton = SearchCriteria.ByAutomationId("checkboxSetButton");
        SearchCriteria _checkBoxLabel = SearchCriteria.ByAutomationId("CheckboxLabel");
        #endregion
        #region Radios
        SearchCriteria _radioButton1 = SearchCriteria.ByAutomationId("radioButton1");
        SearchCriteria _radioButton2 = SearchCriteria.ByAutomationId("radioButton2");
        SearchCriteria _radioButton3 = SearchCriteria.ByAutomationId("radioButton3");
        SearchCriteria _radioSetButton = SearchCriteria.ByAutomationId("radioSetButton");
        SearchCriteria _radioLabel = SearchCriteria.ByAutomationId("radioLabel");
        #endregion
        #region ListBox
        SearchCriteria _listItem1 = SearchCriteria.ByText("list 1");
        SearchCriteria _listItem2 = SearchCriteria.ByText("list 2");
        SearchCriteria _listItem3 = SearchCriteria.ByText("list 3");
        SearchCriteria _listBoxSetButton = SearchCriteria.ByAutomationId("listSetButton");
        SearchCriteria _listBoxLabel = SearchCriteria.ByAutomationId("listLabel");
        #endregion
        #region ComboBox

        #endregion
        public void Open()
        {
            _guitoyApp = Application.Launch(_appPathName);
            _guitoyWindow = _guitoyApp.GetWindow(_windowname);
        }
        public void Close()
        {
            _guitoyApp.Close();
        }
        public void SelectListItem1()
        {
            _guitoyWindow.Get(_listItem1).Click();
        }
        public void SelectListItem2()
        {
            _guitoyWindow.Get(_listItem2).Click();
        }
        public void SelectListItem3()
        {
            _guitoyWindow.Get(_listItem3).Click();
        }
        public void ClickSetButtonListBox()
        {
            _guitoyWindow.Get<Button>(_listBoxSetButton).Click();
        }
        public string ListBoxLabelText
        {
            get
            {
                return _guitoyWindow.Get<Label>(_listBoxLabel).Text;
            }
        }

        public void SelectCheckBox2()
        {
            _guitoyWindow.Get<CheckBox>(_checkBox2).Select();
        }
        public void SelectCheckBox1()
        {
            _guitoyWindow.Get<CheckBox>(_checkBox1).Select();
        }
        public void SelectCheckBox3()
        {
            _guitoyWindow.Get<CheckBox>(_checkBox3).Select();
        }

        public void ClickCheckBoxSetButton()
        {
            _guitoyWindow.Get<Button>(_checkBoxSetButton).Click();
        }

        public string CheckBoxLabelText
        {
            get
            {
              return  _guitoyWindow.Get<Label>(_checkBoxLabel).Text;
            }
        }
        public void SelectRadioButton1()
        {
            _guitoyWindow.Get<RadioButton>(_radioButton1).Select();
        }
        public void SelectRadioButton2()
        {
            _guitoyWindow.Get<RadioButton>(_radioButton2).Select();
        }
        public void SelectRadioButton3()
        {
            _guitoyWindow.Get<RadioButton>(_radioButton3).Select();
        }
        public void ClickRadioSetButton()
        {
            _guitoyWindow.Get<Button>(_radioSetButton).Click();
        }

        public string GetRadioButtonLabelText
        {
            get { return _guitoyWindow.Get<Label>(_radioLabel).Text; }
        }

    }
}
