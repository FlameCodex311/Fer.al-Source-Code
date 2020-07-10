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

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class SBDataServer // TypeDefIndex: 13263
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
	public static SBDataServerConfig Config { get; } // 0x0000000180E12520-0x0000000180E126C0 

	// Nested types
	public class SDBCommands // TypeDefIndex: 13264
	{
		// Fields
		public const string CHANGE_PROPS = "CCG"; // Metadata: 0x007839EA
		public const string GET_SHEET = "GAX"; // Metadata: 0x007839F1
		public const string GET_ALL_PROJECTS = "GTS"; // Metadata: 0x007839F8
		public const string GET_NEW_ID = "GID"; // Metadata: 0x007839FF
		public const string POST_TO_GAME = "PTG"; // Metadata: 0x00783A06

		// Constructors
		public SDBCommands(); // 0x000000018036B6C0-0x000000018036B6D0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <OnGameUpdate>d__17 : IEnumerator<object> // TypeDefIndex: 13265
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <OnGameUpdate>d__17(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x0000000180E3B280-0x0000000180E3B3D0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x0000000180E3B3D0-0x0000000180E3B420
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass26_0 // TypeDefIndex: 13266
	{
		// Fields
		public Action<int> inCallback; // 0x10

		// Constructors
		public <>c__DisplayClass26_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <GetNewID>b__0(JSON inData); // 0x0000000180E3BC00-0x0000000180E3BCC0
		internal void <GetNewID>b__1(string inMessage); // 0x0000000180E3BCC0-0x0000000180E3BD50
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass27_0 // TypeDefIndex: 13267
	{
		// Fields
		public Action<bool> inCallback; // 0x10

		// Constructors
		public <>c__DisplayClass27_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <PostToGame>b__0(JSON inData); // 0x0000000180E3BD50-0x0000000180E3BDA0
		internal void <PostToGame>b__1(string inMessage); // 0x0000000180E3BDA0-0x0000000180E3BE30
	}

	// Constructors
	public SBDataServer(); // 0x000000018036B6C0-0x000000018036B6D0
	static SBDataServer(); // 0x00000001803581E0-0x00000001803581F0

	// Methods
	private static void sendData(string command, string json, delegateNetworkData callBack = null, delegateNetworkFail failCallBack = null); // 0x0000000180E12B40-0x0000000180E12DF0
	public static void fabrikaCallReturn(bool success, string token); // 0x0000000180E12460-0x0000000180E12520
	private static void callSbDataServer(string command, string json); // 0x0000000180E121B0-0x0000000180E12460
	[IteratorStateMachine] // 0x0000000180112F80-0x0000000180112FD0
	private static IEnumerator OnGameUpdate(); // 0x0000000180E11960-0x0000000180E119B0
	public void OnDestroy(); // 0x00000001803581E0-0x00000001803581F0
	public static void LoadCompleted(); // 0x0000000180E114F0-0x0000000180E11960
	public static void GetAllProjectSchemas(delegateNetworkData callBack = null, delegateNetworkFail failCallBack = null); // 0x0000000180E10F10-0x0000000180E10F90
	public static void GetAllProjectsSummary(delegateNetworkData callback = null, delegateNetworkFail failCallback = null); // 0x0000000180E10F90-0x0000000180E11010
	public static void GetSheet(string sheetName, delegateNetworkData callBack = null, delegateNetworkFail failCallBack = null); // 0x0000000180E111D0-0x0000000180E114F0
	public static void ChangeProperty(string sheetName, SBPROP prop, string comment = "" /* Metadata: 0x007839DA */, delegateNetworkData callBack = null, delegateNetworkFail failCallBack = null); // 0x0000000180E10A70-0x0000000180E10F10
	public static void AddProperty(string sheetName, SBPROP prop, string comment = "" /* Metadata: 0x007839DE */, delegateNetworkData callback = null, delegateNetworkFail failCallback = null); // 0x0000000180E0FFB0-0x0000000180E10450
	public static void QueueChange(string sheetName, SBPROP prop); // 0x0000000180E11C30-0x0000000180E12070
	public static void GetNewID(Action<int> inCallback); // 0x0000000180E11010-0x0000000180E111D0
	public static void PostToGame(Action<bool> inCallback); // 0x0000000180E11A70-0x0000000180E11C30
	public static void PostToGame(delegateNetworkData callback = null, delegateNetworkFail failCallback = null); // 0x0000000180E119B0-0x0000000180E11A70
	public static void WriteQueue(string comments = "" /* Metadata: 0x007839E2 */, delegateNetworkData callBack = null, delegateNetworkFail failCallBack = null); // 0x0000000180E12070-0x0000000180E121B0
	private static void processQueue(); // 0x0000000180E126C0-0x0000000180E129D0
	private static void ChangeProperties(int projectId, string sheetName, List<SBPROP> props, string comment = "" /* Metadata: 0x007839E6 */, delegateNetworkData callBack = null, delegateNetworkFail failCallBack = null); // 0x0000000180E10450-0x0000000180E10A70
	private static void queueReturn(JSON dataObj = null); // 0x0000000180E129D0-0x0000000180E12B40
}

