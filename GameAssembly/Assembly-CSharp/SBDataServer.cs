/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using WyrmTale;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class SBDataServer // TypeDefIndex: 10929
{
	// Fields
	private static Hashtable queryCallBack; // 0x00
	private static Dictionary<WWW, delegateNetworkData> queryFailCallBack; // 0x08
	private static WWW www; // 0x10
	private static string _command; // 0x18
	private static string _json; // 0x20
	private static delegateNetworkData _callback; // 0x28
	private static delegateNetworkFail _failCallback; // 0x30
	private static delegateNetworkData _callbackQueue; // 0x38
	private static Dictionary<int, Dictionary<string, List<SBPROP>>> _changePropQueue; // 0x40
	private static bool busy; // 0x48
	private static SBDataServerConfig _config; // 0x50
	private static int _queueIterator; // 0x58
	private static int _queueProcessingProjectId; // 0x5C
	private static string _queueProcessingSheet; // 0x60
	private static string _queueProcessingComments; // 0x68

	// Properties
	public static SBDataServerConfig Config { get; } // 0x00000001807443E0-0x0000000180744580 

	// Nested types
	public class SDBCommands // TypeDefIndex: 10930
	{
		// Fields
		public const string CHANGE_PROPS = "CCG"; // Metadata: 0x0077C4A5
		public const string GET_SHEET = "GAX"; // Metadata: 0x0077C4AC
		public const string GET_ALL_PROJECTS = "GTS"; // Metadata: 0x0077C4B3
		public const string GET_NEW_ID = "GID"; // Metadata: 0x0077C4BA
		public const string POST_TO_GAME = "PTG"; // Metadata: 0x0077C4C1

		// Constructors
		public SDBCommands(); // 0x0000000180373240-0x0000000180373250
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <OnGameUpdate>d__17 : IEnumerator<object> // TypeDefIndex: 10931
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <OnGameUpdate>d__17(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x0000000180749320-0x0000000180749470
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x0000000180749470-0x00000001807494C0
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass26_0 // TypeDefIndex: 10932
	{
		// Fields
		public Action<int> inCallback; // 0x10

		// Constructors
		public <>c__DisplayClass26_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <GetNewID>b__0(JSON inData); // 0x00000001807499F0-0x0000000180749AA0
		internal void <GetNewID>b__1(string inMessage); // 0x0000000180749AA0-0x0000000180749B30
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass27_0 // TypeDefIndex: 10933
	{
		// Fields
		public Action<bool> inCallback; // 0x10

		// Constructors
		public <>c__DisplayClass27_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <PostToGame>b__0(JSON inData); // 0x0000000180749B30-0x0000000180749B80
		internal void <PostToGame>b__1(string inMessage); // 0x0000000180749B80-0x0000000180749C10
	}

	// Constructors
	public SBDataServer(); // 0x0000000180373240-0x0000000180373250
	static SBDataServer(); // 0x00000001803774A0-0x00000001803774B0

	// Methods
	private static void sendData(string command, string json, delegateNetworkData callBack = null, delegateNetworkFail failCallBack = null); // 0x0000000180744A00-0x0000000180744CB0
	public static void fabrikaCallReturn(bool success, string token); // 0x0000000180744320-0x00000001807443E0
	private static void callSbDataServer(string command, string json); // 0x0000000180744070-0x0000000180744320
	[IteratorStateMachine] // 0x00000001801ECFE0-0x00000001801ED030
	private static IEnumerator OnGameUpdate(); // 0x0000000180743840-0x0000000180743890
	public void OnDestroy(); // 0x00000001803774A0-0x00000001803774B0
	public static void LoadCompleted(); // 0x00000001807433E0-0x0000000180743840
	public static void GetAllProjectSchemas(delegateNetworkData callBack = null, delegateNetworkFail failCallBack = null); // 0x0000000180742E40-0x0000000180742EC0
	public static void GetAllProjectsSummary(delegateNetworkData callback = null, delegateNetworkFail failCallback = null); // 0x0000000180742EC0-0x0000000180742F40
	public static void GetSheet(string sheetName, delegateNetworkData callBack = null, delegateNetworkFail failCallBack = null); // 0x00000001807430F0-0x00000001807433E0
	public static void ChangeProperty(string sheetName, SBPROP prop, string comment = "" /* Metadata: 0x0077C495 */, delegateNetworkData callBack = null, delegateNetworkFail failCallBack = null); // 0x00000001807429E0-0x0000000180742E40
	public static void AddProperty(string sheetName, SBPROP prop, string comment = "" /* Metadata: 0x0077C499 */, delegateNetworkData callback = null, delegateNetworkFail failCallback = null); // 0x0000000180741F90-0x00000001807423F0
	public static void QueueChange(string sheetName, SBPROP prop); // 0x0000000180743B10-0x0000000180743F30
	public static void GetNewID(Action<int> inCallback); // 0x0000000180742F40-0x00000001807430F0
	public static void PostToGame(Action<bool> inCallback); // 0x0000000180743950-0x0000000180743B10
	public static void PostToGame(delegateNetworkData callback = null, delegateNetworkFail failCallback = null); // 0x0000000180743890-0x0000000180743950
	public static void WriteQueue(string comments = "" /* Metadata: 0x0077C49D */, delegateNetworkData callBack = null, delegateNetworkFail failCallBack = null); // 0x0000000180743F30-0x0000000180744070
	private static void processQueue(); // 0x0000000180744580-0x0000000180744890
	private static void ChangeProperties(int projectId, string sheetName, List<SBPROP> props, string comment = "" /* Metadata: 0x0077C4A1 */, delegateNetworkData callBack = null, delegateNetworkFail failCallBack = null); // 0x00000001807423F0-0x00000001807429E0
	private static void queueReturn(JSON dataObj = null); // 0x0000000180744890-0x0000000180744A00
}

