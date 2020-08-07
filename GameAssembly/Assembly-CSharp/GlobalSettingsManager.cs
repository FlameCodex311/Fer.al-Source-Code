/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class GlobalSettingsManager : CoreGlobalSettingsManager // TypeDefIndex: 11801
{
	// Fields
	[Header] // 0x000000018026FAD0-0x000000018026FB00
	public bool noAutoLoginInEditor; // 0xF8
	public bool autoPressLoginButton; // 0xF9
	[Header] // 0x000000018026FC60-0x000000018026FC90
	public bool forceOfflineMode; // 0xFA
	[RootSelector] // 0x000000018026FDB0-0x000000018026FE10
	public string defaultSanctuaryLevelDefId; // 0x100
	[SetInstance] // 0x00000001801CEA70-0x00000001801CEA80
	public static GlobalSettingsManager instance; // 0x00
	private int _averageFPS; // 0x108

	// Properties
	public override string PostSplashScene { get; } // 0x0000000180683740-0x0000000180683770 
	public override string ProjectDefine { get; } // 0x00000001806837D0-0x0000000180683800 
	public override string DataServerProject { get; } // 0x00000001806836B0-0x00000001806836E0 
	public override string ProjectSVNURL { get; } // 0x0000000180683800-0x0000000180683830 
	protected override string DevBaseURL { get; } // 0x00000001806836E0-0x0000000180683710 
	protected override string StageBaseURL { get; } // 0x0000000180683890-0x00000001806838C0 
	protected override string StageAlternateBaseURL { get; } // 0x0000000180683860-0x0000000180683890 
	protected override string ProdBaseURL { get; } // 0x00000001806837A0-0x00000001806837D0 
	protected override string ProdAlternateBaseURL { get; } // 0x0000000180683770-0x00000001806837A0 
	protected override string DevSharedBaseURL { get; } // 0x0000000180683710-0x0000000180683740 
	protected override string StageSharedBaseURL { get; } // 0x00000001806838C0-0x00000001806838F0 
	protected override string SharedBaseURL { get; } // 0x0000000180683830-0x0000000180683860 

	// Nested types
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <SetAverageFps>d__31 : IEnumerator<object> // TypeDefIndex: 11802
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public GlobalSettingsManager <>4__this; // 0x20
		private float <iCount>5__2; // 0x28
		private float <iFps>5__3; // 0x2C
		private float <fTime>5__4; // 0x30
		private float <fTimer>5__5; // 0x34

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <SetAverageFps>d__31(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x000000018068DDF0-0x000000018068DF50
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x000000018068DF50-0x000000018068DFA0
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <SendFpsAnalytics>d__32 : IEnumerator<object> // TypeDefIndex: 11803
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public GlobalSettingsManager <>4__this; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <SendFpsAnalytics>d__32(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x000000018068CC70-0x000000018068D070
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x000000018068D070-0x000000018068DDF0
	}

	// Constructors
	public GlobalSettingsManager(); // 0x0000000180683650-0x00000001806836B0

	// Methods
	public override void MStart(); // 0x0000000180683370-0x00000001806834C0
	[IteratorStateMachine] // 0x0000000180270130-0x0000000180270180
	private IEnumerator SetAverageFps(); // 0x0000000180683520-0x0000000180683580
	[IteratorStateMachine] // 0x00000001802703B0-0x0000000180270400
	private IEnumerator SendFpsAnalytics(); // 0x00000001806834C0-0x0000000180683520
	public Coroutine SetLanguage(SystemLanguage inNewLanguage, Action inCallback = null); // 0x0000000180683580-0x0000000180683650
	public string GetPlatformString(); // 0x00000001806832A0-0x0000000180683370
}

