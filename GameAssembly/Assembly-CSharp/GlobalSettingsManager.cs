/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class GlobalSettingsManager : CoreGlobalSettingsManager // TypeDefIndex: 10311
{
	// Fields
	[Header] // 0x00000001800DC110-0x00000001800DC140
	public bool noAutoLoginInEditor; // 0xF8
	public bool autoPressLoginButton; // 0xF9
	[Header] // 0x00000001800DC2E0-0x00000001800DC310
	public bool forceOfflineMode; // 0xFA
	[RootSelector] // 0x00000001800DC550-0x00000001800DC5B0
	public string defaultSanctuaryLevelDefId; // 0x100
	[SetInstance] // 0x00000001800BDB50-0x00000001800BDB60
	public static GlobalSettingsManager instance; // 0x00
	private int _averageFPS; // 0x108

	// Properties
	public override string PostSplashScene { get; } // 0x00000001810580D0-0x0000000181058100 
	public override string ProjectDefine { get; } // 0x0000000181058160-0x0000000181058190 
	public override string DataServerProject { get; } // 0x0000000181058040-0x0000000181058070 
	public override string ProjectSVNURL { get; } // 0x0000000181058190-0x00000001810581C0 
	protected override string DevBaseURL { get; } // 0x0000000181058070-0x00000001810580A0 
	protected override string StageBaseURL { get; } // 0x0000000181058220-0x0000000181058250 
	protected override string StageAlternateBaseURL { get; } // 0x00000001810581F0-0x0000000181058220 
	protected override string ProdBaseURL { get; } // 0x0000000181058130-0x0000000181058160 
	protected override string ProdAlternateBaseURL { get; } // 0x0000000181058100-0x0000000181058130 
	protected override string DevSharedBaseURL { get; } // 0x00000001810580A0-0x00000001810580D0 
	protected override string StageSharedBaseURL { get; } // 0x0000000181058250-0x0000000181058280 
	protected override string SharedBaseURL { get; } // 0x00000001810581C0-0x00000001810581F0 

	// Nested types
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <SetAverageFps>d__31 : IEnumerator<object> // TypeDefIndex: 10312
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
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <SetAverageFps>d__31(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x0000000181065710-0x0000000181065870
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x0000000181065870-0x00000001810658C0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <SendFpsAnalytics>d__32 : IEnumerator<object> // TypeDefIndex: 10313
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public GlobalSettingsManager <>4__this; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <SendFpsAnalytics>d__32(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x0000000181064590-0x0000000181064990
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x0000000181064990-0x0000000181065710
	}

	// Constructors
	public GlobalSettingsManager(); // 0x0000000181057FE0-0x0000000181058040

	// Methods
	public override void MStart(); // 0x0000000181057D00-0x0000000181057E50
	[IteratorStateMachine] // 0x00000001800DC8F0-0x00000001800DC940
	private IEnumerator SetAverageFps(); // 0x0000000181057EB0-0x0000000181057F10
	[IteratorStateMachine] // 0x00000001800DCC30-0x00000001800DCC80
	private IEnumerator SendFpsAnalytics(); // 0x0000000181057E50-0x0000000181057EB0
	public Coroutine SetLanguage(SystemLanguage inNewLanguage, Action inCallback = null); // 0x0000000181057F10-0x0000000181057FE0
	public string GetPlatformString(); // 0x0000000181057C30-0x0000000181057D00
}

