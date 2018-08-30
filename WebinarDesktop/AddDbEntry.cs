﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;
using Ranorex.Core.Repository;

namespace WebinarDesktop
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The AddDbEntry recording.
    /// </summary>
    [TestModule("4c9ea26c-08cd-420f-b070-5d438b78d37d", ModuleType.Recording, 1)]
    public partial class AddDbEntry : ITestModule
    {
        /// <summary>
        /// Holds an instance of the WebinarDesktopRepository repository.
        /// </summary>
        public static WebinarDesktopRepository repo = WebinarDesktopRepository.Instance;

        static AddDbEntry instance = new AddDbEntry();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public AddDbEntry()
        {
            varFname = "Josh";
            varLname = "Owen";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static AddDbEntry Instance
        {
            get { return instance; }
        }

#region Variables

        string _varFname;

        /// <summary>
        /// Gets or sets the value of variable varFname.
        /// </summary>
        [TestVariable("0d22e1db-57a2-4805-8be3-176cdafdc00f")]
        public string varFname
        {
            get { return _varFname; }
            set { _varFname = value; }
        }

        string _varLname;

        /// <summary>
        /// Gets or sets the value of variable varLname.
        /// </summary>
        [TestVariable("56c2dddd-53be-4b5e-935e-bd0a39421a6e")]
        public string varLname
        {
            get { return _varLname; }
            set { _varLname = value; }
        }

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "8.2")]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "8.2")]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'RxMainFrame.TestDatabase' at 41;7.", repo.RxMainFrame.TestDatabaseInfo, new RecordItemIndex(0));
            repo.RxMainFrame.TestDatabase.Click("41;7");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking Focus() on item 'RxMainFrame.FirstName'.", repo.RxMainFrame.FirstNameInfo, new RecordItemIndex(1));
            repo.RxMainFrame.FirstName.Focus();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$varFname' with focus on 'RxMainFrame.FirstName'.", repo.RxMainFrame.FirstNameInfo, new RecordItemIndex(2));
            repo.RxMainFrame.FirstName.PressKeys(varFname);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking Focus() on item 'RxMainFrame.LastName'.", repo.RxMainFrame.LastNameInfo, new RecordItemIndex(3));
            repo.RxMainFrame.LastName.Focus();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$varLname' with focus on 'RxMainFrame.LastName'.", repo.RxMainFrame.LastNameInfo, new RecordItemIndex(4));
            repo.RxMainFrame.LastName.PressKeys(varLname);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'RxMainFrame.Open' at 7;6.", repo.RxMainFrame.OpenInfo, new RecordItemIndex(5));
            repo.RxMainFrame.Open.Click("7;6");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'List1000.Testing' at 51;0.", repo.List1000.TestingInfo, new RecordItemIndex(6));
            repo.List1000.Testing.Click("51;0");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'RxMainFrame.RdbMale' at 6;8.", repo.RxMainFrame.RdbMaleInfo, new RecordItemIndex(7));
            repo.RxMainFrame.RdbMale.Click("6;8");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'RxMainFrame.BtnAddPerson' at 64;8.", repo.RxMainFrame.BtnAddPersonInfo, new RecordItemIndex(8));
            repo.RxMainFrame.BtnAddPerson.Click("64;8");
            Delay.Milliseconds(200);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
