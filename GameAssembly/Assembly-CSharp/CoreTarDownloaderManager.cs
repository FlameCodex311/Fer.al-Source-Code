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

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class CoreTarDownloaderManager : CoreManagerBase<CoreTarDownloaderManager> // TypeDefIndex: 13501
{
	// Fields
	private int _debugMaxConcurrent; // 0x60
	private bool _debugShowResults; // 0x64
	private Vector2 _debugScrollPos; // 0x68
	private Coroutine _downloadingRoutine; // 0x70
	private List<TarBundle> _tarBundles; // 0x78
	private TimeSpan? _lastEstimatedTime; // 0x80

	// Properties
	private float DownloadAverage { get; } // 0x0000000180F37530-0x0000000180F376F0 
	private float ExtractAverage { get; } // 0x0000000180F376F0-0x0000000180F378B0 

	// Nested types
	public enum TarBundleDownloadState // TypeDefIndex: 13502
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

	private class TarBundle // TypeDefIndex: 13503
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
		public TarBundle(); // 0x0000000180F4CD60-0x0000000180F4CD70

		// Methods
		public void BeginDownload(); // 0x0000000180F4B990-0x0000000180F4BB60
		public void Update(); // 0x0000000180F4CBF0-0x0000000180F4CD60
		private void UpdateDownload(); // 0x0000000180F4C620-0x0000000180F4CAA0
		public void ClearWebRequest(); // 0x0000000180F4BCE0-0x0000000180F4BD10
		public void BeginExtract(); // 0x0000000180F4BB60-0x0000000180F4BCE0
		private void StartExtractThread(); // 0x0000000180F4C530-0x0000000180F4C620
		private static bool ExtractTarFile(string inPath, string inOutPath); // 0x0000000180F4BD10-0x0000000180F4C100
		private static bool ExtractTgzFile(string inPath, string inOutPath); // 0x0000000180F4C100-0x0000000180F4C530
		public void UpdateExtract(); // 0x0000000180F4CAA0-0x0000000180F4CBF0
	}

	[Serializable]
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c // TypeDefIndex: 13504
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static Action<bool> <>9__15_0; // 0x08
		public static Action<bool> <>9__15_1; // 0x10

		// Constructors
		static <>c(); // 0x0000000180F53890-0x0000000180F53950
		public <>c(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <OnGUIMenu>b__15_0(bool inSuccess); // 0x00000001803581E0-0x00000001803581F0
		internal void <OnGUIMenu>b__15_1(bool inSuccess); // 0x00000001803581E0-0x00000001803581F0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <DownloadTars>d__22 : IEnumerator<object> // TypeDefIndex: 13505
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
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <DownloadTars>d__22(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x0000000180F4DB40-0x0000000180F4E730
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x0000000180F4E730-0x0000000180F4E780
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass23_0 // TypeDefIndex: 13506
	{
		// Fields
		public bool failed; // 0x10

		// Constructors
		public <>c__DisplayClass23_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <InitCoroutine>b__0(bool inSuccess); // 0x0000000180F53280-0x0000000180F53290
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <InitCoroutine>d__23 : IEnumerator<object> // TypeDefIndex: 13507
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public CoreTarDownloaderManager <>4__this; // 0x20
		private <>c__DisplayClass23_0 <>8__1; // 0x28

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <InitCoroutine>d__23(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x0000000180F4F930-0x0000000180F4FD90
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x0000000180F4FD90-0x0000000180F4FDE0
	}

	// Constructors
	public CoreTarDownloaderManager(); // 0x0000000180F37480-0x0000000180F37530

	// Methods
	public override bool HasInitCoroutine(); // 0x00000001803C29F0-0x00000001803C2A00
	public void OnGUI(); // 0x00000001803581E0-0x00000001803581F0
	private void OnWindow(int inID); // 0x0000000180F373D0-0x0000000180F37480
	private void OnGUIResults(); // 0x0000000180F37090-0x0000000180F373D0
	private void OnGUIMenu(); // 0x0000000180F36D30-0x0000000180F37090
	private void OnGUIDownloading(); // 0x0000000180F36790-0x0000000180F36D30
	public TimeSpan GetEstimatedTime(); // 0x0000000180F36000-0x0000000180F36260
	public string GetTotalMBString(); // 0x0000000180F36540-0x0000000180F36730
	public string GetCompletedMBString(); // 0x0000000180F35E20-0x0000000180F36000
	public float GetProgressPercentage(); // 0x0000000180F36260-0x0000000180F36540
	[IteratorStateMachine] // 0x0000000180174B90-0x0000000180174BE0
	private IEnumerator DownloadTars(bool inUseTGZ, int inMaxConcurrent, Action<bool> inResult); // 0x0000000180F35D90-0x0000000180F35E20
	[IteratorStateMachine] // 0x0000000180174F40-0x0000000180174F90
	public override IEnumerator InitCoroutine(); // 0x0000000180F36730-0x0000000180F36790
	public override void Deinit(); // 0x00000001803581E0-0x00000001803581F0
}

