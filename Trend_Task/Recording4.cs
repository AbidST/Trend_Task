///////////////////////////////////////////////////////////////////////////////
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

namespace Trend_Task
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Recording4 recording.
    /// </summary>
    [TestModule("a758213e-6dc4-4ee2-a264-060339811bc6", ModuleType.Recording, 1)]
    public partial class Recording4 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the Trend_TaskRepository repository.
        /// </summary>
        public static Trend_TaskRepository repo = Trend_TaskRepository.Instance;

        static Recording4 instance = new Recording4();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Recording4()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Recording4 Instance
        {
            get { return instance; }
        }

#region Variables

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
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
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Down}{Down}{Down}{Down}{Down}{Down}' with focus on 'HttpsWwwTrendyolComUyelikcbEqhttps'.", repo.HttpsWwwTrendyolComUyelikcbEqhttps.SelfInfo, new RecordItemIndex(0));
            repo.HttpsWwwTrendyolComUyelikcbEqhttps.Self.EnsureVisible();
            Keyboard.Press("{Down}{Down}{Down}{Down}{Down}{Down}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'HttpsWwwTrendyolComUyelikcbEqhttps.CustomStampBoxWrapper' at 87;73.", repo.HttpsWwwTrendyolComUyelikcbEqhttps.CustomStampBoxWrapperInfo, new RecordItemIndex(1));
            repo.HttpsWwwTrendyolComUyelikcbEqhttps.CustomStampBoxWrapper.Click("87;73");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'HttpsWwwTrendyolComUyelikcbEqhttps.SomeDivTag' at 1028;592.", repo.HttpsWwwTrendyolComUyelikcbEqhttps.SomeDivTagInfo, new RecordItemIndex(2));
            repo.HttpsWwwTrendyolComUyelikcbEqhttps.SomeDivTag.Click("1028;592");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
