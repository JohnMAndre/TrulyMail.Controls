// Decompiled with JetBrains decompiler
// Type: TrulyMail.Controls.My.MySettings
// Assembly: TrulyMail.Controls, Version=1.0.4631.31187, Culture=neutral, PublicKeyToken=48de480a58101e47
// MVID: 2F8F86CD-8291-4A91-8225-9611555032EF
// Assembly location: C:\Users\John\Documents\Visual Studio 2010\Projects\TrulyMail\SupportFiles\TrulyMail.Controls.dll

using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace TrulyMail.Controls.My
{
  [GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0")]
  [CompilerGenerated]
  [EditorBrowsable(EditorBrowsableState.Advanced)]
  internal sealed class MySettings : ApplicationSettingsBase
  {
    private static MySettings defaultInstance = (MySettings) SettingsBase.Synchronized((SettingsBase) new MySettings());

    [DebuggerNonUserCode]
    public MySettings()
    {
    }

    public static MySettings Default
    {
      get
      {
        MySettings defaultInstance = MySettings.defaultInstance;
        return defaultInstance;
      }
    }
  }
}
