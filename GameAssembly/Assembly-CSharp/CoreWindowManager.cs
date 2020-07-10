/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unitilities.Tuples;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class CoreWindowManager : CoreManagerBase<CoreWindowManager> // TypeDefIndex: 13508
{
	// Fields
	private static Dictionary<Type, string> _typeNames; // 0x00
	protected Dictionary<string, UI_Window> _windows; // 0x60
	protected List<Queue<QueuedWindow>> _queuedWindows; // 0x68
	protected List<UI_Window> _openQueuedWindows; // 0x70
	protected List<Tuple<int, string>> _loadingQueuedWindowIDs; // 0x78
	protected List<string> _loadingWindows; // 0x80
	protected UI_Panel _focusedPanel; // 0x88
	protected List<UI_Panel> _focusStack; // 0x90

	// Properties
	public IEnumerable<UI_Window> Windows { get; } // 0x0000000180F3DE70-0x0000000180F3DEC0 
	public Dictionary<string, UI_Window> WindowsDict { get; } // 0x0000000180369B40-0x0000000180369B50 

	// Nested types
	public enum UILayer // TypeDefIndex: 13509
	{
		Window = 0,
		Overlay = 10,
		Popup = 20
	}

	public enum QueuePriority // TypeDefIndex: 13510
	{
		Lowest = 0,
		Low = 5,
		Medium = 10,
		High = 15,
		Highest = 20
	}

	public struct QueuedWindow // TypeDefIndex: 13511
	{
		// Fields
		public string windowID; // 0x00
		public Action<UI_Window> OnWindowOpenedCallback; // 0x08
		public int priority; // 0x10
		public bool animate; // 0x14
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass38_0 // TypeDefIndex: 13512
	{
		// Fields
		public string inTitle; // 0x10
		public string inMessage; // 0x18
		public string inOkBtnText; // 0x20
		public Action inOkCallback; // 0x28

		// Constructors
		public <>c__DisplayClass38_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <QueueOkWindow>b__0(UI_Window popup); // 0x0000000180F53290-0x0000000180F53370
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass39_0 // TypeDefIndex: 13513
	{
		// Fields
		public string inTitle; // 0x10
		public string inMessage; // 0x18
		public string inYesBtnText; // 0x20
		public string inNoBtnText; // 0x28
		public Action<bool> inResponseCallback; // 0x30

		// Constructors
		public <>c__DisplayClass39_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <QueueYesNoWindow>b__0(UI_Window popup); // 0x0000000180F53370-0x0000000180F53460
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass44_0<T> // TypeDefIndex: 13514
		where T : UI_Window
	{
		// Fields
		public T loadedWindow;

		// Constructors
		public <>c__DisplayClass44_0();

		// Methods
		internal void <OpenBundledWindow>b__0(T inLoadedWindow);
		internal bool <OpenBundledWindow>b__1();
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <OpenBundledWindow>d__44<T> : IEnumerator<object> // TypeDefIndex: 13515
		where T : UI_Window
	{
		// Fields
		private int <>1__state;
		private object <>2__current;
		public string inWindowID;
		private <>c__DisplayClass44_0<T> <>8__1;
		public bool inAnimate;
		public Action<T> inOnWindowOpenedCallback;

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; }
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; }

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <OpenBundledWindow>d__44(int <>1__state);

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose();
		private bool MoveNext();
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset();
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass45_0<T> // TypeDefIndex: 13516
		where T : UI_Window
	{
		// Fields
		public GameObject loadedWindowObj;

		// Constructors
		public <>c__DisplayClass45_0();

		// Methods
		internal void <LoadBundledWindow>b__0(GameObject inLoadedWindow);
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <LoadBundledWindow>d__45<T> : IEnumerator<object> // TypeDefIndex: 13517
		where T : UI_Window
	{
		// Fields
		private int <>1__state;
		private object <>2__current;
		public string inWindowID;
		private <>c__DisplayClass45_0<T> <>8__1;
		public Action<T> inOnWindowLoadedCallback;

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; }
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; }

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <LoadBundledWindow>d__45(int <>1__state);

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose();
		private bool MoveNext();
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset();
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass47_0 // TypeDefIndex: 13518
	{
		// Fields
		public CoreWindowManager <>4__this; // 0x10
		public QueuedWindow inQueuedWindow; // 0x18

		// Constructors
		public <>c__DisplayClass47_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <OpenQueuedWindow>b__0(UI_Window loadedWindow); // 0x0000000180F536A0-0x0000000180F53760
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass48_0 // TypeDefIndex: 13519
	{
		// Fields
		public int i; // 0x10
		public CoreWindowManager <>4__this; // 0x18

		// Constructors
		public <>c__DisplayClass48_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <OnQueuedWindowClosed>b__0(); // 0x0000000180F53760-0x0000000180F53830
	}

	// Constructors
	public CoreWindowManager(); // 0x0000000180F3DD50-0x0000000180F3DE70
	static CoreWindowManager(); // 0x0000000180F3DCF0-0x0000000180F3DD50

	// Methods
	private static string GetTypeName(Type inType); // 0x0000000180F3C850-0x0000000180F3C960
	public override void Init(); // 0x000000018036B6C0-0x000000018036B6D0
	public override void Deinit(); // 0x000000018036B6C0-0x000000018036B6D0
	public static T GetWindow<T>()
		where T : UI_Window;
	public static UI_Window GetWindow(string inWindowID); // 0x0000000180F3C960-0x0000000180F3C9C0
	public static T GetWindow<T>(string inWindowID)
		where T : UI_Window;
	public static UI_Panel GetFocusedWindow(); // 0x0000000180F3C7B0-0x0000000180F3C850
	public static bool ExistsOrIsLoading(string inWindowID); // 0x0000000180F3C390-0x0000000180F3C500
	public static void OpenWindow(string inWindowID, Action<UI_Window> inOnWindowOpenedCallback = null); // 0x0000000180F3CF40-0x0000000180F3CFB0
	public static void OpenWindow<T>(string inWindowID, Action<T> inOnWindowOpenedCallback = null, bool inAnimate = true /* Metadata: 0x00783DFC */)
		where T : UI_Window;
	public static void OpenWindow<T>(Action<T> inOnWindowOpenedCallback = null, bool inAnimate = true /* Metadata: 0x00783DFD */)
		where T : UI_Window;
	public static void CloseWindow(string inWindowID, bool inAnimate = true /* Metadata: 0x00783DFE */); // 0x0000000180F3C1F0-0x0000000180F3C2B0
	public static void CloseWindow<T>(bool inAnimate = true /* Metadata: 0x00783DFF */);
	public static void ShowWindow<T>()
		where T : UI_Window;
	public static void HideWindow<T>()
		where T : UI_Window;
	public static void CloseAllWindows(UI_Window inExceptionWindow = null, bool inIgnoreWindowLayer = false /* Metadata: 0x00783E00 */, bool inIgnoreOverlayLayer = false /* Metadata: 0x00783E01 */, bool inIgnorePopupLayer = false /* Metadata: 0x00783E02 */); // 0x0000000180F3BE40-0x0000000180F3C1F0
	public static void RemoveWindow(UI_Window inWindow); // 0x0000000180F3DB30-0x0000000180F3DC40
	public static T ToggleWindow<T>()
		where T : UI_Window;
	public static T ToggleWindow<T>(string inWindowID, bool inAnimate = true /* Metadata: 0x00783E03 */)
		where T : UI_Window;
	public static void QueueWindow(string inWindowID, QueuePriority inPriority = QueuePriority.Low /* Metadata: 0x00783E04 */, Action<UI_Window> inOnWindowOpenedCallback = null, bool inAnimate = true /* Metadata: 0x00783E08 */); // 0x0000000180F3D1E0-0x0000000180F3D2A0
	public static void QueueWindow<T>(QueuePriority inPriority = QueuePriority.Low /* Metadata: 0x00783E09 */, Action<UI_Window> inOnWindowOpenedCallback = null, bool inAnimate = true /* Metadata: 0x00783E0D */);
	public static void QueueOkWindow(string inMessage, QueuePriority inPriority = QueuePriority.Low /* Metadata: 0x00783E0E */, Action inOkCallback = null, bool inAnimate = true /* Metadata: 0x00783E12 */); // 0x0000000180F3D050-0x0000000180F3D0E0
	public static void QueueOkWindow(string inTitle, string inMessage, QueuePriority inPriority = QueuePriority.Low /* Metadata: 0x00783E13 */, Action inOkCallback = null, bool inAnimate = true /* Metadata: 0x00783E17 */); // 0x0000000180F3CFB0-0x0000000180F3D050
	public static void QueueOkWindow(string inTitle, string inMessage, string inOkBtnText, QueuePriority inPriority = QueuePriority.Low /* Metadata: 0x00783E18 */, Action inOkCallback = null, bool inAnimate = true /* Metadata: 0x00783E1C */); // 0x0000000180F3D0E0-0x0000000180F3D1E0
	public static void QueueYesNoWindow(string inTitle, string inMessage, string inYesBtnText, string inNoBtnText, QueuePriority inPriority = QueuePriority.Low /* Metadata: 0x00783E1D */, Action<bool> inResponseCallback = null, bool inAnimate = true /* Metadata: 0x00783E21 */); // 0x0000000180F3D520-0x0000000180F3D630
	public static void FocusPanel(UI_Panel inPanelToFocus, bool inReplaceCurrentPanel = false /* Metadata: 0x00783E22 */); // 0x0000000180F3C500-0x0000000180F3C7B0
	public static void DefocusPanel(UI_Panel inPanelToFocus); // 0x0000000180F3C2B0-0x0000000180F3C390
	private static void RemoveWindow(string inWindowID); // 0x0000000180F3DC40-0x0000000180F3DCF0
	private static void AddWindow(UI_Window inWindow); // 0x0000000180F3BD70-0x0000000180F3BE40
	[IteratorStateMachine] // 0x00000001800B59A0-0x00000001800B59F0
	private static IEnumerator OpenBundledWindow<T>(string inWindowID, Action<T> inOnWindowOpenedCallback = null, bool inAnimate = true /* Metadata: 0x00783E23 */)
		where T : UI_Window;
	[IteratorStateMachine] // 0x00000001800B5B20-0x00000001800B5B70
	private static IEnumerator LoadBundledWindow<T>(string inWindowID, Action<T> inOnWindowLoadedCallback = null)
		where T : UI_Window;
	private void QueueWindow(QueuedWindow inQueuedWindow); // 0x0000000180F3D2A0-0x0000000180F3D520
	private void OpenQueuedWindow(QueuedWindow inQueuedWindow); // 0x0000000180F3CC80-0x0000000180F3CF40
	private void OnQueuedWindowClosed(UI_Window inWindow); // 0x0000000180F3C9C0-0x0000000180F3CC80
	private bool QueuedWindowIsOpen(int inPriority); // 0x0000000180F3D7C0-0x0000000180F3D8B0
	private bool QueuedWindowIsLoading(int inPriority); // 0x0000000180F3D630-0x0000000180F3D7C0
	private void RemoveQueuedWindowFromLoading(string inWindowID); // 0x0000000180F3DA40-0x0000000180F3DB30
	private void RefreshFocusedPanel(); // 0x0000000180F3D8B0-0x0000000180F3DA40
}

