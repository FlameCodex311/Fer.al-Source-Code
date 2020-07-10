/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class CoreLoadingManager : CoreManagerBase<CoreLoadingManager> // TypeDefIndex: 13455
{
	// Fields
	private static Action _onAnimCompleteCallback; // 0x00
	private float _loadingTimer; // 0x60
	private float _loadingTimeout; // 0x64
	private bool _isLoading; // 0x68
	private bool _loadPending; // 0x69
	private bool _queueMessages; // 0x6A
	private string _level; // 0x70
	private List<string> _levelAdditives; // 0x78

	// Properties
	public static bool ProgressScreenIsVisible { get; } // 0x0000000181313C10-0x0000000181313D20 
	public static bool IsLoading { get; } // 0x0000000181313AD0-0x0000000181313B70 
	public static bool LoadPending { get; set; } // 0x0000000181313B70-0x0000000181313C10 0x0000000181313DC0-0x0000000181313E90
	public static bool QueueMessages { get; set; } // 0x0000000181313D20-0x0000000181313DC0 0x0000000181313E90-0x0000000181313F30

	// Nested types
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <LoadLevel>d__28 : IEnumerator<object> // TypeDefIndex: 13456
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public string inLevelNameAdditive; // 0x20
		public CoreLoadingManager <>4__this; // 0x28
		public string inLevelName; // 0x30

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <LoadLevel>d__28(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x0000000181329790-0x00000001813298A0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x00000001813298A0-0x00000001813298F0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <LoadLevel>d__29 : IEnumerator<object> // TypeDefIndex: 13457
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public CoreLoadingManager <>4__this; // 0x20
		public string inLevelName; // 0x28
		public List<string> inLevelNameAdditives; // 0x30

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <LoadLevel>d__29(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x00000001813298F0-0x0000000181329B00
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x0000000181329B00-0x0000000181329B50
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <LoadNextLevel>d__30 : IEnumerator<object> // TypeDefIndex: 13458
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public CoreLoadingManager <>4__this; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <LoadNextLevel>d__30(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x0000000181329B50-0x0000000181329EA0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x0000000181329EA0-0x0000000181329EF0
	}

	// Constructors
	public CoreLoadingManager(); // 0x0000000181313A60-0x0000000181313AD0

	// Methods
	public override void Init(); // 0x00000001813130B0-0x0000000181313230
	public override void MStart(); // 0x00000001813136C0-0x0000000181313710
	public override void MOnDestroy(); // 0x00000001813135C0-0x00000001813136C0
	public override void MUpdate(); // 0x0000000181313710-0x0000000181313840
	public static void HideProgressScreen(); // 0x0000000181312FE0-0x00000001813130B0
	public static void ShowProgressScreen(Action inOnAnimCompleteCallback = null); // 0x0000000181313980-0x0000000181313A60
	private void BackButtonOverride(); // 0x00000001803581E0-0x00000001803581F0
	private void OnLoadingUIOpened(Message inMessage); // 0x00000001813138D0-0x0000000181313980
	private void OnLoadingUIClosed(Message inMessage); // 0x0000000181313840-0x00000001813138D0
	public static void Close(); // 0x0000000181312E90-0x0000000181312FE0
	[IteratorStateMachine] // 0x00000001801628F0-0x0000000180162940
	public IEnumerator LoadLevel(string inLevelName, string inLevelNameAdditive); // 0x00000001813132B0-0x0000000181313330
	[IteratorStateMachine] // 0x0000000180162C60-0x0000000180162CB0
	public IEnumerator LoadLevel(string inLevelName, List<string> inLevelNameAdditives); // 0x0000000181313230-0x00000001813132B0
	[IteratorStateMachine] // 0x0000000180163040-0x0000000180163090
	private IEnumerator LoadNextLevel(); // 0x0000000181313330-0x0000000181313390
	private void CloseAllWindows(); // 0x00000001803581E0-0x00000001803581F0
	private void LoadingTimeout(); // 0x00000001813134E0-0x00000001813135C0
	private void LoadingStart(); // 0x00000001813133F0-0x00000001813134E0
	private void LoadingFinish(); // 0x0000000181313390-0x00000001813133F0
}

