// Decompiled with JetBrains decompiler
// Type: TrulyMail.Controls.My.MySettingsProperty
// Assembly: TrulyMail.Controls, Version=1.0.4631.31187, Culture=neutral, PublicKeyToken=48de480a58101e47
// MVID: 2F8F86CD-8291-4A91-8225-9611555032EF
// Assembly location: C:\Users\John\Documents\Visual Studio 2010\Projects\TrulyMail\SupportFiles\TrulyMail.Controls.dll

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace TrulyMail.Controls.My
{
  [HideModuleName]
  [CompilerGenerated]
  [DebuggerNonUserCode]
  [StandardModule]
  internal sealed class MySettingsProperty
  {
    [HelpKeyword("My.Settings")]
    internal static MySettings Settings
    {
      get
      {
        MySettings mySettings = MySettings.Default;
        return mySettings;
      }
    }
  }
}
