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

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class CoreWindowManager : CoreManagerBase<CoreWindowManager> // TypeDefIndex: 11179
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
	public IEnumerable<UI_Window> Windows { get; } // 0x0000000180AAA9D0-0x0000000180AAAA20 
	public Dictionary<string, UI_Window> WindowsDict { get; } // 0x0000000180418970-0x0000000180418980 

	// Nested types
	public enum UILayer // TypeDefIndex: 11180
	{
		Window = 0,
		Overlay = 10,
		Popup = 20
	}

	public enum QueuePriority // TypeDefIndex: 11181
	{
		Lowest = 0,
		Low = 5,
		Medium = 10,
		High = 15,
		Highest = 20
	}

	public struct QueuedWindow // TypeDefIndex: 11182
	{
		// Fields
		public string windowID; // 0x00
		public Action<UI_Window> OnWindowOpenedCallback; // 0x08
		public int priority; // 0x10
		public bool animate; // 0x14
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass38_0 // TypeDefIndex: 11183
	{
		// Fields
		public string inTitle; // 0x10
		public string inMessage; // 0x18
		public string inOkBtnText; // 0x20
		public Action inOkCallback; // 0x28

		// Constructors
		public <>c__DisplayClass38_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <QueueOkWindow>b__0(UI_Window popup); // 0x0000000180568110-0x00000001805681F0
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass39_0 // TypeDefIndex: 11184
	{
		// Fields
		public string inTitle; // 0x10
		public string inMessage; // 0x18
		public string inYesBtnText; // 0x20
		public string inNoBtnText; // 0x28
		public Action<bool> inResponseCallback; // 0x30

		// Constructors
		public <>c__DisplayClass39_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <QueueYesNoWindow>b__0(UI_Window popup); // 0x00000001805681F0-0x00000001805682E0
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass44_0<T> // TypeDefIndex: 11185
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

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <OpenBundledWindow>d__44<T> : IEnumerator<object> // TypeDefIndex: 11186
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
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; }
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; }

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <OpenBundledWindow>d__44(int <>1__state);

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose();
		private bool MoveNext();
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset();
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass45_0<T> // TypeDefIndex: 11187
		where T : UI_Window
	{
		// Fields
		public GameObject loadedWindowObj;

		// Constructors
		public <>c__DisplayClass45_0();

		// Methods
		internal void <LoadBundledWindow>b__0(GameObject inLoadedWindow);
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <LoadBundledWindow>d__45<T> : IEnumerator<object> // TypeDefIndex: 11188
		where T : UI_Window
	{
		// Fields
		private int <>1__state;
		private object <>2__current;
		public string inWindowID;
		private <>c__DisplayClass45_0<T> <>8__1;
		public Action<T> inOnWindowLoadedCallback;

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; }
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; }

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <LoadBundledWindow>d__45(int <>1__state);

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose();
		private bool MoveNext();
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset();
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass47_0 // TypeDefIndex: 11189
	{
		// Fields
		public CoreWindowManager <>4__this; // 0x10
		public QueuedWindow inQueuedWindow; // 0x18

		// Constructors
		public <>c__DisplayClass47_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <OpenQueuedWindow>b__0(UI_Window loadedWindow); // 0x0000000180568550-0x0000000180568610
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass48_0 // TypeDefIndex: 11190
	{
		// Fields
		public int i; // 0x10
		public CoreWindowManager <>4__this; // 0x18

		// Constructors
		public <>c__DisplayClass48_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <OnQueuedWindowClosed>b__0(); // 0x0000000180568610-0x00000001805686E0
	}

	// Constructors
	public CoreWindowManager(); // 0x0000000180AAA8B0-0x0000000180AAA9D0
	static CoreWindowManager(); // 0x0000000180AAA850-0x0000000180AAA8B0

	// Methods
	private static string GetTypeName(Type inType); // 0x0000000180AA93B0-0x0000000180AA94C0
	public override void Init(); // 0x0000000180373240-0x0000000180373250
	public override void Deinit(); // 0x0000000180373240-0x0000000180373250
	public static T GetWindow<T>()
		where T : UI_Window;
	public static UI_Window GetWindow(string inWindowID); // 0x0000000180AA94C0-0x0000000180AA9520
	public static T GetWindow<T>(string inWindowID)
		where T : UI_Window;
	public static UI_Panel GetFocusedWindow(); // 0x0000000180AA9310-0x0000000180AA93B0
	public static bool ExistsOrIsLoading(string inWindowID); // 0x0000000180AA8F00-0x0000000180AA9070
	public static void OpenWindow(string inWindowID, Action<UI_Window> inOnWindowOpenedCallback = null); // 0x0000000180AA9AD0-0x0000000180AA9B40
	public static void OpenWindow<T>(string inWindowID, Action<T> inOnWindowOpenedCallback = null, bool inAnimate = true /* Metadata: 0x0077C8BB */)
		where T : UI_Window;
	public static void OpenWindow<T>(Action<T> inOnWindowOpenedCallback = null, bool inAnimate = true /* Metadata: 0x0077C8BC */)
		where T : UI_Window;
	public static void CloseWindow(string inWindowID, bool inAnimate = true /* Metadata: 0x0077C8BD */); // 0x0000000180AA8D60-0x0000000180AA8E20
	public static void CloseWindow<T>(bool inAnimate = true /* Metadata: 0x0077C8BE */);
	public static void ShowWindow<T>()
		where T : UI_Window;
	public static void HideWindow<T>()
		where T : UI_Window;
	public static void CloseAllWindows(UI_Window inExceptionWindow = null, bool inIgnoreWindowLayer = false /* Metadata: 0x0077C8BF */, bool inIgnoreOverlayLayer = false /* Metadata: 0x0077C8C0 */, bool inIgnorePopupLayer = false /* Metadata: 0x0077C8C1 */); // 0x0000000180AA89C0-0x0000000180AA8D60
	public static void RemoveWindow(UI_Window inWindow); // 0x0000000180AAA690-0x0000000180AAA7A0
	public static T ToggleWindow<T>()
		where T : UI_Window;
	public static T ToggleWindow<T>(string inWindowID, bool inAnimate = true /* Metadata: 0x0077C8C2 */)
		where T : UI_Window;
	public static void QueueWindow(string inWindowID, QueuePriority inPriority = QueuePriority.Low /* Metadata: 0x0077C8C3 */, Action<UI_Window> inOnWindowOpenedCallback = null, bool inAnimate = true /* Metadata: 0x0077C8C7 */); // 0x0000000180AA9D70-0x0000000180AA9E30
	public static void QueueWindow<T>(QueuePriority inPriority = QueuePriority.Low /* Metadata: 0x0077C8C8 */, Action<UI_Window> inOnWindowOpenedCallback = null, bool inAnimate = true /* Metadata: 0x0077C8CC */);
	public static void QueueOkWindow(string inMessage, QueuePriority inPriority = QueuePriority.Low /* Metadata: 0x0077C8CD */, Action inOkCallback = null, bool inAnimate = true /* Metadata: 0x0077C8D1 */); // 0x0000000180AA9BE0-0x0000000180AA9C70
	public static void QueueOkWindow(string inTitle, string inMessage, QueuePriority inPriority = QueuePriority.Low /* Metadata: 0x0077C8D2 */, Action inOkCallback = null, bool inAnimate = true /* Metadata: 0x0077C8D6 */); // 0x0000000180AA9B40-0x0000000180AA9BE0
	public static void QueueOkWindow(string inTitle, string inMessage, string inOkBtnText, QueuePriority inPriority = QueuePriority.Low /* Metadata: 0x0077C8D7 */, Action inOkCallback = null, bool inAnimate = true /* Metadata: 0x0077C8DB */); // 0x0000000180AA9C70-0x0000000180AA9D70
	public static void QueueYesNoWindow(string inTitle, string inMessage, string inYesBtnText, string inNoBtnText, QueuePriority inPriority = QueuePriority.Low /* Metadata: 0x0077C8DC */, Action<bool> inResponseCallback = null, bool inAnimate = true /* Metadata: 0x0077C8E0 */); // 0x0000000180AAA0A0-0x0000000180AAA1B0
	public static void FocusPanel(UI_Panel inPanelToFocus, bool inReplaceCurrentPanel = false /* Metadata: 0x0077C8E1 */); // 0x0000000180AA9070-0x0000000180AA9310
	public static void DefocusPanel(UI_Panel inPanelToFocus); // 0x0000000180AA8E20-0x0000000180AA8F00
	private static void RemoveWindow(string inWindowID); // 0x0000000180AAA7A0-0x0000000180AAA850
	private static void AddWindow(UI_Window inWindow); // 0x0000000180AA88F0-0x0000000180AA89C0
	[IteratorStateMachine] // 0x00000001802541B0-0x0000000180254200
	private static IEnumerator OpenBundledWindow<T>(string inWindowID, Action<T> inOnWindowOpenedCallback = null, bool inAnimate = true /* Metadata: 0x0077C8E2 */)
		where T : UI_Window;
	[IteratorStateMachine] // 0x0000000180254440-0x0000000180254490
	private static IEnumerator LoadBundledWindow<T>(string inWindowID, Action<T> inOnWindowLoadedCallback = null)
		where T : UI_Window;
	private void QueueWindow(QueuedWindow inQueuedWindow); // 0x0000000180AA9E30-0x0000000180AAA0A0
	private void OpenQueuedWindow(QueuedWindow inQueuedWindow); // 0x0000000180AA9760-0x0000000180AA9AD0
	private void OnQueuedWindowClosed(UI_Window inWindow); // 0x0000000180AA9520-0x0000000180AA9760
	private bool QueuedWindowIsOpen(int inPriority); // 0x0000000180AAA340-0x0000000180AAA420
	private bool QueuedWindowIsLoading(int inPriority); // 0x0000000180AAA1B0-0x0000000180AAA340
	private void RemoveQueuedWindowFromLoading(string inWindowID); // 0x0000000180AAA5A0-0x0000000180AAA690
	private void RefreshFocusedPanel(); // 0x0000000180AAA420-0x0000000180AAA5A0
}

