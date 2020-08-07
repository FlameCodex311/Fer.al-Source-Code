/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class CoreLoadingManager : CoreManagerBase<CoreLoadingManager> // TypeDefIndex: 11126
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
	public static bool ProgressScreenIsVisible { get; } // 0x0000000180A6E190-0x0000000180A6E2A0 
	public static bool IsLoading { get; } // 0x0000000180A6E070-0x0000000180A6E100 
	public static bool LoadPending { get; set; } // 0x0000000180A6E100-0x0000000180A6E190 0x0000000180A6E330-0x0000000180A6E400
	public static bool QueueMessages { get; set; } // 0x0000000180A6E2A0-0x0000000180A6E330 0x0000000180A6E400-0x0000000180A6E4A0

	// Nested types
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <LoadLevel>d__28 : IEnumerator<object> // TypeDefIndex: 11127
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public string inLevelNameAdditive; // 0x20
		public CoreLoadingManager <>4__this; // 0x28
		public string inLevelName; // 0x30

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <LoadLevel>d__28(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x0000000180A7B2B0-0x0000000180A7B3C0
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x0000000180A7B3C0-0x0000000180A7B410
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <LoadLevel>d__29 : IEnumerator<object> // TypeDefIndex: 11128
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public CoreLoadingManager <>4__this; // 0x20
		public string inLevelName; // 0x28
		public List<string> inLevelNameAdditives; // 0x30

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <LoadLevel>d__29(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x0000000180A7B410-0x0000000180A7B620
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x0000000180A7B620-0x0000000180A7B670
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <LoadNextLevel>d__30 : IEnumerator<object> // TypeDefIndex: 11129
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public CoreLoadingManager <>4__this; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <LoadNextLevel>d__30(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x0000000180A7B670-0x0000000180A7B9B0
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x0000000180A7B9B0-0x0000000180A7BA00
	}

	// Constructors
	public CoreLoadingManager(); // 0x0000000180A6E000-0x0000000180A6E070

	// Methods
	public override void Init(); // 0x0000000180A6D660-0x0000000180A6D7E0
	public override void MStart(); // 0x0000000180A6DC60-0x0000000180A6DCB0
	public override void MOnDestroy(); // 0x0000000180A6DB60-0x0000000180A6DC60
	public override void MUpdate(); // 0x0000000180A6DCB0-0x0000000180A6DDE0
	public static void HideProgressScreen(); // 0x0000000180A6D590-0x0000000180A6D660
	public static void ShowProgressScreen(Action inOnAnimCompleteCallback = null); // 0x0000000180A6DF20-0x0000000180A6E000
	private void BackButtonOverride(); // 0x00000001803774A0-0x00000001803774B0
	private void OnLoadingUIOpened(Message inMessage); // 0x0000000180A6DE70-0x0000000180A6DF20
	private void OnLoadingUIClosed(Message inMessage); // 0x0000000180A6DDE0-0x0000000180A6DE70
	public static void Close(); // 0x0000000180A6D440-0x0000000180A6D590
	[IteratorStateMachine] // 0x0000000180242EC0-0x0000000180242F10
	public IEnumerator LoadLevel(string inLevelName, string inLevelNameAdditive); // 0x0000000180A6D860-0x0000000180A6D8E0
	[IteratorStateMachine] // 0x00000001802443C0-0x0000000180244410
	public IEnumerator LoadLevel(string inLevelName, List<string> inLevelNameAdditives); // 0x0000000180A6D7E0-0x0000000180A6D860
	[IteratorStateMachine] // 0x0000000180244650-0x00000001802446A0
	private IEnumerator LoadNextLevel(); // 0x0000000180A6D8E0-0x0000000180A6D940
	private void CloseAllWindows(); // 0x00000001803774A0-0x00000001803774B0
	private void LoadingTimeout(); // 0x0000000180A6DA80-0x0000000180A6DB60
	private void LoadingStart(); // 0x0000000180A6D9A0-0x0000000180A6DA80
	private void LoadingFinish(); // 0x0000000180A6D940-0x0000000180A6D9A0
}

