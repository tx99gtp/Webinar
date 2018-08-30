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
    ///The EnterName recording.
    /// </summary>
    [TestModule("30fadd2e-6e0a-465b-a657-231a2c9a4daf", ModuleType.Recording, 1)]
    public partial class EnterName : ITestModule
    {
        /// <summary>
        /// Holds an instance of the WebinarDesktopRepository repository.
        /// </summary>
        public static WebinarDesktopRepository repo = WebinarDesktopRepository.Instance;

        static EnterName instance = new EnterName();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public EnterName()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static EnterName Instance
        {
            get { return instance; }
        }

#region Variables

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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'RxMainFrame.EnterYourName' at 73;14.", repo.RxMainFrame.EnterYourNameInfo, new RecordItemIndex(0));
            repo.RxMainFrame.EnterYourName.Click("73;14");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'Josh' with focus on 'RxMainFrame.EnterYourName'.", repo.RxMainFrame.EnterYourNameInfo, new RecordItemIndex(1));
            repo.RxMainFrame.EnterYourName.PressKeys("Josh");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'RxMainFrame.BtnSubmitUserName' at 23;14.", repo.RxMainFrame.BtnSubmitUserNameInfo, new RecordItemIndex(2));
            repo.RxMainFrame.BtnSubmitUserName.Click("23;14");
            Delay.Milliseconds(200);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
