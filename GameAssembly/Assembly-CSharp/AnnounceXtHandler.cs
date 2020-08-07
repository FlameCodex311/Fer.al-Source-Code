/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Server;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

[MessageRouteHandler] // 0x00000001801CDAD0-0x00000001801CDAE0
public static class AnnounceXtHandler // TypeDefIndex: 12686
{
	// Fields
	private static float _sysAnnounceRandomTime; // 0x00

	// Nested types
	[Serializable]
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c // TypeDefIndex: 12687
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static Action <>9__1_0; // 0x08
		public static Action<bool> <>9__3_0; // 0x10

		// Constructors
		static <>c(); // 0x0000000182162850-0x00000001821628B0
		public <>c(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <HandleSystemAnnounce>b__1_0(); // 0x0000000182160210-0x0000000182160220
		internal void <RandomTimerForRelogPopup>b__3_0(bool answer); // 0x0000000182160220-0x00000001821602C0
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <RandomTimerForRelogPopup>d__3 : IEnumerator<object> // TypeDefIndex: 12688
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public SystemAnnouncementMessage inMsg; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <RandomTimerForRelogPopup>d__3(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x000000018215E780-0x000000018215EC30
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x000000018215EC30-0x0000000182160210
	}

	// Constructors
	static AnnounceXtHandler(); // 0x00000001821564E0-0x0000000182156520

	// Methods
	[MessageRoute] // 0x00000001801FD7A0-0x00000001801FD7C0
	public static void HandleSystemAnnounce(SystemAnnouncementMessage inMsg); // 0x0000000182156090-0x00000001821563E0
	[MessageRoute] // 0x00000001801FD9A0-0x00000001801FD9C0
	public static void HandleSystemPopup(SystemPopupMessage inMsg); // 0x00000001821563E0-0x0000000182156480
	[IteratorStateMachine] // 0x00000001801FDCC0-0x00000001801FDD10
	private static IEnumerator RandomTimerForRelogPopup(SystemAnnouncementMessage inMsg); // 0x0000000182156480-0x00000001821564E0
	private static void DoRelogForForcedRelogin(); // 0x0000000182156000-0x0000000182156090
	private static void DoRelogForDrain(); // 0x0000000182155FC0-0x0000000182156000
}

