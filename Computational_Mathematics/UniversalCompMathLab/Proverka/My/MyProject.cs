// Decompiled with JetBrains decompiler
// Type: Proverka.My.MyProject
// Assembly: Proverka, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CEE704FC-3D12-4FFC-8D1B-D1F47A457B1E
// Assembly location: C:\Users\nekha\OneDrive\Рабочий стол\Proverka.exe

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Proverka.My
{
  [HideModuleName]
  [StandardModule]
  [GeneratedCode("MyTemplate", "8.0.0.0")]
  internal sealed class MyProject
  {
    private static readonly MyProject.ThreadSafeObjectProvider<MyComputer> m_ComputerObjectProvider = new MyProject.ThreadSafeObjectProvider<MyComputer>();
    private static readonly MyProject.ThreadSafeObjectProvider<MyApplication> m_AppObjectProvider = new MyProject.ThreadSafeObjectProvider<MyApplication>();
    private static readonly MyProject.ThreadSafeObjectProvider<User> m_UserObjectProvider = new MyProject.ThreadSafeObjectProvider<User>();
    private static MyProject.ThreadSafeObjectProvider<MyProject.MyForms> m_MyFormsObjectProvider = new MyProject.ThreadSafeObjectProvider<MyProject.MyForms>();
    private static readonly MyProject.ThreadSafeObjectProvider<MyProject.MyWebServices> m_MyWebServicesObjectProvider = new MyProject.ThreadSafeObjectProvider<MyProject.MyWebServices>();

    [HelpKeyword("My.Computer")]
    internal static MyComputer Computer
    {
      [DebuggerHidden] get
      {
        return MyProject.m_ComputerObjectProvider.GetInstance;
      }
    }

    [HelpKeyword("My.Application")]
    internal static MyApplication Application
    {
      [DebuggerHidden] get
      {
        return MyProject.m_AppObjectProvider.GetInstance;
      }
    }

    [HelpKeyword("My.User")]
    internal static User User
    {
      [DebuggerHidden] get
      {
        return MyProject.m_UserObjectProvider.GetInstance;
      }
    }

    [HelpKeyword("My.Forms")]
    internal static MyProject.MyForms Forms
    {
      [DebuggerHidden] get
      {
        return MyProject.m_MyFormsObjectProvider.GetInstance;
      }
    }

    [HelpKeyword("My.WebServices")]
    internal static MyProject.MyWebServices WebServices
    {
      [DebuggerHidden] get
      {
        return MyProject.m_MyWebServicesObjectProvider.GetInstance;
      }
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    [MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")]
    internal sealed class MyForms
    {
      public MainFormLab1 m_MainFormLab1;
      public MainFormLab2 m_MainFormLab2;
      public MainFormLab3 m_MainFormLab3;
      public MainFormLab4 m_MainFormLab4;
      public MainFormLab5 m_MainFormLab5;
      public MainFormLab6 m_MainFormLab6;
      public Plot m_Plot;
      public Proverka.Proverka m_Proverka;
      public SplashForm m_SplashForm;
      [ThreadStatic]
      private static Hashtable m_FormBeingCreated;

      public MainFormLab1 MainFormLab1
      {
        get
        {
          this.m_MainFormLab1 = MyProject.MyForms.Create__Instance__<MainFormLab1>(this.m_MainFormLab1);
          return this.m_MainFormLab1;
        }
        set
        {
          if (value == this.m_MainFormLab1)
            return;
          if (value != null)
            throw new ArgumentException("Property can only be set to Nothing");
          this.Dispose__Instance__<MainFormLab1>(ref this.m_MainFormLab1);
        }
      }

      public MainFormLab2 MainFormLab2
      {
        get
        {
          this.m_MainFormLab2 = MyProject.MyForms.Create__Instance__<MainFormLab2>(this.m_MainFormLab2);
          return this.m_MainFormLab2;
        }
        set
        {
          if (value == this.m_MainFormLab2)
            return;
          if (value != null)
            throw new ArgumentException("Property can only be set to Nothing");
          this.Dispose__Instance__<MainFormLab2>(ref this.m_MainFormLab2);
        }
      }

      public MainFormLab3 MainFormLab3
      {
        get
        {
          this.m_MainFormLab3 = MyProject.MyForms.Create__Instance__<MainFormLab3>(this.m_MainFormLab3);
          return this.m_MainFormLab3;
        }
        set
        {
          if (value == this.m_MainFormLab3)
            return;
          if (value != null)
            throw new ArgumentException("Property can only be set to Nothing");
          this.Dispose__Instance__<MainFormLab3>(ref this.m_MainFormLab3);
        }
      }

      public MainFormLab4 MainFormLab4
      {
        get
        {
          this.m_MainFormLab4 = MyProject.MyForms.Create__Instance__<MainFormLab4>(this.m_MainFormLab4);
          return this.m_MainFormLab4;
        }
        set
        {
          if (value == this.m_MainFormLab4)
            return;
          if (value != null)
            throw new ArgumentException("Property can only be set to Nothing");
          this.Dispose__Instance__<MainFormLab4>(ref this.m_MainFormLab4);
        }
      }

      public MainFormLab5 MainFormLab5
      {
        get
        {
          this.m_MainFormLab5 = MyProject.MyForms.Create__Instance__<MainFormLab5>(this.m_MainFormLab5);
          return this.m_MainFormLab5;
        }
        set
        {
          if (value == this.m_MainFormLab5)
            return;
          if (value != null)
            throw new ArgumentException("Property can only be set to Nothing");
          this.Dispose__Instance__<MainFormLab5>(ref this.m_MainFormLab5);
        }
      }

      public MainFormLab6 MainFormLab6
      {
        get
        {
          this.m_MainFormLab6 = MyProject.MyForms.Create__Instance__<MainFormLab6>(this.m_MainFormLab6);
          return this.m_MainFormLab6;
        }
        set
        {
          if (value == this.m_MainFormLab6)
            return;
          if (value != null)
            throw new ArgumentException("Property can only be set to Nothing");
          this.Dispose__Instance__<MainFormLab6>(ref this.m_MainFormLab6);
        }
      }

      public Plot Plot
      {
        get
        {
          this.m_Plot = MyProject.MyForms.Create__Instance__<Plot>(this.m_Plot);
          return this.m_Plot;
        }
        set
        {
          if (value == this.m_Plot)
            return;
          if (value != null)
            throw new ArgumentException("Property can only be set to Nothing");
          this.Dispose__Instance__<Plot>(ref this.m_Plot);
        }
      }

      public Proverka.Proverka Proverka
      {
        get
        {
          this.m_Proverka = MyProject.MyForms.Create__Instance__<Proverka.Proverka>(this.m_Proverka);
          return this.m_Proverka;
        }
        set
        {
          if (value == this.m_Proverka)
            return;
          if (value != null)
            throw new ArgumentException("Property can only be set to Nothing");
          this.Dispose__Instance__<Proverka.Proverka>(ref this.m_Proverka);
        }
      }

      public SplashForm SplashForm
      {
        get
        {
          this.m_SplashForm = MyProject.MyForms.Create__Instance__<SplashForm>(this.m_SplashForm);
          return this.m_SplashForm;
        }
        set
        {
          if (value == this.m_SplashForm)
            return;
          if (value != null)
            throw new ArgumentException("Property can only be set to Nothing");
          this.Dispose__Instance__<SplashForm>(ref this.m_SplashForm);
        }
      }

      [DebuggerHidden]
      private static T Create__Instance__<T>(T Instance) where T : Form, new()
      {
        if ((object) Instance != null && !Instance.IsDisposed)
          return Instance;
        if (MyProject.MyForms.m_FormBeingCreated != null)
        {
          if (MyProject.MyForms.m_FormBeingCreated.ContainsKey((object) typeof (T)))
            throw new InvalidOperationException(Utils.GetResourceString("WinForms_RecursiveFormCreate", new string[0]));
        }
        else
          MyProject.MyForms.m_FormBeingCreated = new Hashtable();
        MyProject.MyForms.m_FormBeingCreated.Add((object) typeof (T), (object) null);
        try
        {
          return new T();
        }
        catch (TargetInvocationException ex) when (
        {
          // ISSUE: unable to correctly present filter
          ProjectData.SetProjectError((Exception) ex);
          if (ex.InnerException != null)
          {
            SuccessfulFiltering;
          }
          else
            throw;
        }
        )
        {
          throw new InvalidOperationException(Utils.GetResourceString("WinForms_SeeInnerException", ex.InnerException.Message), ex.InnerException);
        }
        finally
        {
          MyProject.MyForms.m_FormBeingCreated.Remove((object) typeof (T));
        }
      }

      [DebuggerHidden]
      private void Dispose__Instance__<T>(ref T instance) where T : Form
      {
        instance.Dispose();
        instance = default (T);
      }

      [EditorBrowsable(EditorBrowsableState.Never)]
      [DebuggerHidden]
      public MyForms()
      {
      }

      [EditorBrowsable(EditorBrowsableState.Never)]
      public override bool Equals(object o)
      {
        return base.Equals(RuntimeHelpers.GetObjectValue(o));
      }

      [EditorBrowsable(EditorBrowsableState.Never)]
      public override int GetHashCode()
      {
        return base.GetHashCode();
      }

      [EditorBrowsable(EditorBrowsableState.Never)]
      internal new System.Type GetType()
      {
        return typeof (MyProject.MyForms);
      }

      [EditorBrowsable(EditorBrowsableState.Never)]
      public override string ToString()
      {
        return base.ToString();
      }
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    [MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
    internal sealed class MyWebServices
    {
      [EditorBrowsable(EditorBrowsableState.Never)]
      [DebuggerHidden]
      public override bool Equals(object o)
      {
        return base.Equals(RuntimeHelpers.GetObjectValue(o));
      }

      [DebuggerHidden]
      [EditorBrowsable(EditorBrowsableState.Never)]
      public override int GetHashCode()
      {
        return base.GetHashCode();
      }

      [DebuggerHidden]
      [EditorBrowsable(EditorBrowsableState.Never)]
      internal new System.Type GetType()
      {
        return typeof (MyProject.MyWebServices);
      }

      [EditorBrowsable(EditorBrowsableState.Never)]
      [DebuggerHidden]
      public override string ToString()
      {
        return base.ToString();
      }

      [DebuggerHidden]
      private static T Create__Instance__<T>(T instance) where T : new()
      {
        if ((object) instance == null)
          return new T();
        return instance;
      }

      [DebuggerHidden]
      private void Dispose__Instance__<T>(ref T instance)
      {
        instance = default (T);
      }

      [EditorBrowsable(EditorBrowsableState.Never)]
      [DebuggerHidden]
      public MyWebServices()
      {
      }
    }

    [ComVisible(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    internal sealed class ThreadSafeObjectProvider<T> where T : new()
    {
      internal T GetInstance
      {
        [DebuggerHidden] get
        {
          if ((object) MyProject.ThreadSafeObjectProvider<T>.m_ThreadStaticValue == null)
            MyProject.ThreadSafeObjectProvider<T>.m_ThreadStaticValue = new T();
          return MyProject.ThreadSafeObjectProvider<T>.m_ThreadStaticValue;
        }
      }

      [EditorBrowsable(EditorBrowsableState.Never)]
      [DebuggerHidden]
      public ThreadSafeObjectProvider()
      {
      }
    }
  }
}
