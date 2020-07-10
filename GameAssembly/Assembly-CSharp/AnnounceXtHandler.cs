/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Server;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

[MessageRouteHandler] // 0x00000001800B36B0-0x00000001800B36C0
public static class AnnounceXtHandler // TypeDefIndex: 11160
{
	// Fields
	private static float _sysAnnounceRandomTime; // 0x00

	// Nested types
	[Serializable]
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c // TypeDefIndex: 11161
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static Action<bool> <>9__1_0; // 0x08
		public static Action<bool> <>9__3_0; // 0x10

		// Constructors
		static <>c(); // 0x000000018104F630-0x000000018104F690
		public <>c(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <HandleSystemAnnounce>b__1_0(bool answer); // 0x000000018104D4C0-0x000000018104D5D0
		internal void <RandomTimerForRelogPopup>b__3_0(bool answer); // 0x000000018104D600-0x000000018104D6A0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <RandomTimerForRelogPopup>d__3 : IEnumerator<object> // TypeDefIndex: 11162
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public SystemAnnouncementMessage inMsg; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <RandomTimerForRelogPopup>d__3(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x000000018104B9A0-0x000000018104BE60
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x000000018104BE60-0x000000018104D4C0
	}

	// Constructors
	static AnnounceXtHandler(); // 0x000000018103D480-0x000000018103D4C0

	// Methods
	[MessageRoute] // 0x000000018011A150-0x000000018011A170
	public static void HandleSystemAnnounce(SystemAnnouncementMessage inMsg); // 0x000000018103CEB0-0x000000018103D380
	[MessageRoute] // 0x000000018011A1F0-0x000000018011A210
	public static void HandleSystemPopup(SystemPopupMessage inMsg); // 0x000000018103D380-0x000000018103D420
	[IteratorStateMachine] // 0x000000018011A380-0x000000018011A3D0
	private static IEnumerator RandomTimerForRelogPopup(SystemAnnouncementMessage inMsg); // 0x000000018103D420-0x000000018103D480
	private static void DoRelogForForcedRelogin(); // 0x000000018103CE20-0x000000018103CEB0
	private static void DoRelogForDrain(); // 0x000000018103CDE0-0x000000018103CE20
}

