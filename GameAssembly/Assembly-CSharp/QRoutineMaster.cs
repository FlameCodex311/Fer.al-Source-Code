/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class QRoutineMaster : MonoBehaviour // TypeDefIndex: 11229
{
	// Fields
	private static QRoutineMaster _instance; // 0x00
	private static QRoutineGroup _masterGroup; // 0x08
	private static QRoutineGroup _standardGroup; // 0x10
	private static QRoutine _currentActiveQRoutine; // 0x18
	private List<QRoutineGroup> _tempSubGroups; // 0x20

	// Properties
	private static QRoutineMaster Instance { get; } // 0x0000000180A30610-0x0000000180A30790 
	public static QRoutineGroup MasterGroup { get; } // 0x0000000180A30790-0x0000000180A308B0 
	public static QRoutineGroup StandardGroup { get; } // 0x0000000180A308B0-0x0000000180A30AB0 
	public static QRoutine CurrentActiveQRoutine { get; set; } // 0x0000000180A30550-0x0000000180A30610 0x0000000180A30AB0-0x0000000180A30B10

	// Constructors
	public QRoutineMaster(); // 0x0000000180A304F0-0x0000000180A30550
	static QRoutineMaster(); // 0x00000001803774A0-0x00000001803774B0

	// Methods
	[RuntimeInitializeOnLoadMethod] // 0x00000001801CF2D0-0x00000001801CF2E0
	private static void Init(); // 0x0000000180A2FF50-0x0000000180A2FFA0
	public static void CoreReset(); // 0x0000000180A2FCD0-0x0000000180A2FEB0
	public static QRoutineMaster CreateMasterObject(string inName); // 0x0000000180A2FEB0-0x0000000180A2FF50
	public static void TrackAsset(UnityEngine.Object inAsset); // 0x0000000180A2FFA0-0x0000000180A30180
	public static bool TryMoveNextQRoutine(IEnumerator inIEnumerator, QRoutine inParentQRoutine); // 0x0000000180A30180-0x0000000180A30300
	private void Update(); // 0x0000000180A30300-0x0000000180A304F0
}

