// Decompiled with JetBrains decompiler
// Type: TrulyMail.Controls.NewMessageNotifier
// Assembly: TrulyMail.Controls, Version=1.0.4631.31187, Culture=neutral, PublicKeyToken=48de480a58101e47
// MVID: 2F8F86CD-8291-4A91-8225-9611555032EF
// Assembly location: C:\Users\John\Documents\Visual Studio 2010\Projects\TrulyMail\SupportFiles\TrulyMail.Controls.dll

using Microsoft.VisualBasic.CompilerServices;
using MontgomerySoftware.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Shapes;

namespace TrulyMail.Controls
{
  [DesignerGenerated]
  public partial class NewMessageNotifier : TaskbarNotifier, IComponentConnector
  {
    private static List<WeakReference> __ENCList = new List<WeakReference>();
    [AccessedThroughProperty("Rectangle1")]
    private Rectangle _Rectangle1;
    [AccessedThroughProperty("lblMessageText")]
    private Label _lblMessageText;
    [AccessedThroughProperty("ToolBarTray1")]
    private ToolBarTray _ToolBarTray1;
    [AccessedThroughProperty("btnHide")]
    private Button _btnHide;
    private bool _contentLoaded;

    [DebuggerNonUserCode]
    static NewMessageNotifier()
    {
    }

    [DebuggerNonUserCode]
    public NewMessageNotifier()
    {
      this.MouseDown += new MouseButtonEventHandler(this.UserControl_MouseDown);
      NewMessageNotifier.__ENCAddToList((object) this);
      this.InitializeComponent();
    }

    [DebuggerNonUserCode]
    private static void __ENCAddToList(object value)
    {
      lock (NewMessageNotifier.__ENCList)
      {
        if (NewMessageNotifier.__ENCList.Count == NewMessageNotifier.__ENCList.Capacity)
        {
          int index1 = 0;
          int num = checked (NewMessageNotifier.__ENCList.Count - 1);
          int index2 = 0;
          while (index2 <= num)
          {
            if (NewMessageNotifier.__ENCList[index2].IsAlive)
            {
              if (index2 != index1)
                NewMessageNotifier.__ENCList[index1] = NewMessageNotifier.__ENCList[index2];
              checked { ++index1; }
            }
            checked { ++index2; }
          }
          NewMessageNotifier.__ENCList.RemoveRange(index1, checked (NewMessageNotifier.__ENCList.Count - index1));
          NewMessageNotifier.__ENCList.Capacity = NewMessageNotifier.__ENCList.Count;
        }
        NewMessageNotifier.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
      }
    }

    public event NewMessageNotifier.ClickedEventHandler Clicked;

    public string MessageText
    {
      get => Conversions.ToString(this.lblMessageText.Content);
      set => this.lblMessageText.Content = (object) value;
    }

    private void btnHide_Click(object sender, RoutedEventArgs e) => this.ForceHidden();

    private void UserControl_MouseDown(object sender, MouseButtonEventArgs e)
    {
      NewMessageNotifier.ClickedEventHandler clickedEvent = this.ClickedEvent;
      if (clickedEvent == null)
        return;
      clickedEvent();
    }

    private void lblMessageText_MouseDown(object sender, MouseButtonEventArgs e)
    {
      NewMessageNotifier.ClickedEventHandler clickedEvent = this.ClickedEvent;
      if (clickedEvent == null)
        return;
      clickedEvent();
    }

    internal virtual Rectangle Rectangle1
    {
      [DebuggerNonUserCode] get => this._Rectangle1;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Rectangle1 = value;
    }

    internal virtual Label lblMessageText
    {
      [DebuggerNonUserCode] get => this._lblMessageText;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        MouseButtonEventHandler buttonEventHandler = new MouseButtonEventHandler(this.lblMessageText_MouseDown);
        if (this._lblMessageText != null)
          this._lblMessageText.MouseDown -= buttonEventHandler;
        this._lblMessageText = value;
        if (this._lblMessageText == null)
          return;
        this._lblMessageText.MouseDown += buttonEventHandler;
      }
    }

    internal virtual ToolBarTray ToolBarTray1
    {
      [DebuggerNonUserCode] get => this._ToolBarTray1;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._ToolBarTray1 = value;
    }

    internal virtual Button btnHide
    {
      [DebuggerNonUserCode] get => this._btnHide;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        RoutedEventHandler routedEventHandler = new RoutedEventHandler(this.btnHide_Click);
        if (this._btnHide != null)
          this._btnHide.Click -= routedEventHandler;
        this._btnHide = value;
        if (this._btnHide == null)
          return;
        this._btnHide.Click += routedEventHandler;
      }
    }

    [DebuggerNonUserCode]
    public void InitializeComponent()
    {
      if (this._contentLoaded)
        return;
      this._contentLoaded = true;
      Application.LoadComponent((object) this, new Uri("/TrulyMail.Controls;component/newmessagenotifier.xaml", UriKind.Relative));
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    [DebuggerNonUserCode]
    public void System_Windows_Markup_IComponentConnector_Connect(int connectionId, object target)
    {
      switch (connectionId)
      {
        case 1:
          this.Rectangle1 = (Rectangle) target;
          break;
        case 2:
          this.lblMessageText = (Label) target;
          break;
        case 3:
          this.ToolBarTray1 = (ToolBarTray) target;
          break;
        case 4:
          this.btnHide = (Button) target;
          break;
        default:
          this._contentLoaded = true;
          break;
      }
    }

    public delegate void ClickedEventHandler();
  }
}
