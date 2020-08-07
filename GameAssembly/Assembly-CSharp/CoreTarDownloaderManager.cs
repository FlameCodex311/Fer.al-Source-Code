/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using UnityEngine;
using UnityEngine.Networking;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class CoreTarDownloaderManager : CoreManagerBase<CoreTarDownloaderManager> // TypeDefIndex: 11172
{
	// Fields
	private int _debugMaxConcurrent; // 0x60
	private bool _debugShowResults; // 0x64
	private Vector2 _debugScrollPos; // 0x68
	private Coroutine _downloadingRoutine; // 0x70
	private List<TarBundle> _tarBundles; // 0x78
	private TimeSpan? _lastEstimatedTime; // 0x80

	// Properties
	private float DownloadAverage { get; } // 0x0000000180AA4270-0x0000000180AA4430 
	private float ExtractAverage { get; } // 0x0000000180AA4430-0x0000000180AA45E0 

	// Nested types
	public enum TarBundleDownloadState // TypeDefIndex: 11173
	{
		Idle = 0,
		Downloading = 1,
		FinishedDownloading = 2,
		FailedDownloading = 3,
		Extracting = 4,
		FinishedExtracting = 5,
		FailedExtracting = 6,
		AlreadyCached = 7
	}

	private class TarBundle // TypeDefIndex: 11174
	{
		// Fields
		public string bundlePath; // 0x10
		public string bundleFileName; // 0x18
		public ManifestDef manifestDef; // 0x20
		public UnityWebRequest webRequest; // 0x28
		public bool useTGZ; // 0x30
		public float priorProgress; // 0x34
		public float priorLoggedProgress; // 0x38
		public int downloadAttemptCount; // 0x3C
		public int downloadFailures; // 0x40
		public float downloadTimer; // 0x44
		private static float? _downloadTimeout; // 0x00
		private int _extractLog; // 0x48
		private Thread _extractThread; // 0x50
		private bool _threadIsExtracting; // 0x58
		private bool _extractSucceeded; // 0x59
		public Stopwatch downloadStopwatch; // 0x60
		public Stopwatch extractStopwatch; // 0x68
		public TarBundleDownloadState state; // 0x70

		// Constructors
		public TarBundle(); // 0x0000000180AABD90-0x0000000180AABDA0

		// Methods
		public void BeginDownload(); // 0x0000000180AAAA20-0x0000000180AAABF0
		public void Update(); // 0x0000000180AABC20-0x0000000180AABD90
		private void UpdateDownload(); // 0x0000000180AAB650-0x0000000180AABAD0
		public void ClearWebRequest(); // 0x0000000180AAAD70-0x0000000180AAADA0
		public void BeginExtract(); // 0x0000000180AAABF0-0x0000000180AAAD70
		private void StartExtractThread(); // 0x0000000180AAB560-0x0000000180AAB650
		private static bool ExtractTarFile(string inPath, string inOutPath); // 0x0000000180AAADA0-0x0000000180AAB160
		private static bool ExtractTgzFile(string inPath, string inOutPath); // 0x0000000180AAB160-0x0000000180AAB560
		public void UpdateExtract(); // 0x0000000180AABAD0-0x0000000180AABC20
	}

	[Serializable]
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c // TypeDefIndex: 11175
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static Action<bool> <>9__15_0; // 0x08
		public static Action<bool> <>9__15_1; // 0x10

		// Constructors
		static <>c(); // 0x0000000180AB0120-0x0000000180AB0180
		public <>c(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <OnGUIMenu>b__15_0(bool inSuccess); // 0x00000001803774A0-0x00000001803774B0
		internal void <OnGUIMenu>b__15_1(bool inSuccess); // 0x00000001803774A0-0x00000001803774B0
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <DownloadTars>d__22 : IEnumerator<object> // TypeDefIndex: 11176
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public CoreTarDownloaderManager <>4__this; // 0x20
		public bool inUseTGZ; // 0x28
		public int inMaxConcurrent; // 0x2C
		public Action<bool> inResult; // 0x30
		private TimeSpan <totalDownloadTime>5__2; // 0x38
		private TimeSpan <totalExtractTime>5__3; // 0x40
		private TimeSpan <totalTime>5__4; // 0x48
		private List<TarBundle> <tarBundleQueue>5__5; // 0x50
		private List<TarBundle> <currentTarBundles>5__6; // 0x58

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <DownloadTars>d__22(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x0000000180AACE70-0x0000000180AADA20
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x0000000180AADA20-0x0000000180AADA70
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass23_0 // TypeDefIndex: 11177
	{
		// Fields
		public bool failed; // 0x10

		// Constructors
		public <>c__DisplayClass23_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <InitCoroutine>b__0(bool inSuccess); // 0x0000000180AB0110-0x0000000180AB0120
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <InitCoroutine>d__23 : IEnumerator<object> // TypeDefIndex: 11178
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public CoreTarDownloaderManager <>4__this; // 0x20
		private <>c__DisplayClass23_0 <>8__1; // 0x28

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <InitCoroutine>d__23(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x0000000180AAEAA0-0x0000000180AAEEF0
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x0000000180AAEEF0-0x0000000180AAEF40
	}

	// Constructors
	public CoreTarDownloaderManager(); // 0x0000000180AA41C0-0x0000000180AA4270

	// Methods
	public override bool HasInitCoroutine(); // 0x0000000180380B60-0x0000000180380B70
	public void OnGUI(); // 0x00000001803774A0-0x00000001803774B0
	private void OnWindow(int inID); // 0x0000000180AA4110-0x0000000180AA41C0
	private void OnGUIResults(); // 0x0000000180AA3DE0-0x0000000180AA4110
	private void OnGUIMenu(); // 0x0000000180AA3A80-0x0000000180AA3DE0
	private void OnGUIDownloading(); // 0x0000000180AA34E0-0x0000000180AA3A80
	public TimeSpan GetEstimatedTime(); // 0x0000000180AA2D70-0x0000000180AA2FD0
	public string GetTotalMBString(); // 0x0000000180AA32A0-0x0000000180AA3480
	public string GetCompletedMBString(); // 0x0000000180AA2B90-0x0000000180AA2D70
	public float GetProgressPercentage(); // 0x0000000180AA2FD0-0x0000000180AA32A0
	[IteratorStateMachine] // 0x0000000180252350-0x00000001802523A0
	private IEnumerator DownloadTars(bool inUseTGZ, int inMaxConcurrent, Action<bool> inResult); // 0x0000000180AA2B00-0x0000000180AA2B90
	[IteratorStateMachine] // 0x00000001802527E0-0x0000000180252830
	public override IEnumerator InitCoroutine(); // 0x0000000180AA3480-0x0000000180AA34E0
	public override void Deinit(); // 0x00000001803774A0-0x00000001803774B0
}

