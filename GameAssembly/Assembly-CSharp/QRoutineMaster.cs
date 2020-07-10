/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class QRoutineMaster : MonoBehaviour // TypeDefIndex: 13558
{
	// Fields
	private static QRoutineMaster _instance; // 0x00
	private static QRoutineGroup _masterGroup; // 0x08
	private static QRoutineGroup _standardGroup; // 0x10
	private static QRoutine _currentActiveQRoutine; // 0x18
	private List<QRoutineGroup> _tempSubGroups; // 0x20

	// Properties
	private static QRoutineMaster Instance { get; } // 0x00000001815F2B10-0x00000001815F2C90 
	public static QRoutineGroup MasterGroup { get; } // 0x00000001815F2C90-0x00000001815F2DB0 
	public static QRoutineGroup StandardGroup { get; } // 0x00000001815F2DB0-0x00000001815F2FC0 
	public static QRoutine CurrentActiveQRoutine { get; set; } // 0x00000001815F2A50-0x00000001815F2B10 0x00000001815F2FC0-0x00000001815F3020

	// Constructors
	public QRoutineMaster(); // 0x00000001815F29F0-0x00000001815F2A50
	static QRoutineMaster(); // 0x00000001803581E0-0x00000001803581F0

	// Methods
	[RuntimeInitializeOnLoadMethod] // 0x00000001800C1340-0x00000001800C1350
	private static void Init(); // 0x00000001815F2440-0x00000001815F2490
	public static void CoreReset(); // 0x00000001815F21C0-0x00000001815F23A0
	public static QRoutineMaster CreateMasterObject(string inName); // 0x00000001815F23A0-0x00000001815F2440
	public static void TrackAsset(UnityEngine.Object inAsset); // 0x00000001815F2490-0x00000001815F2670
	public static bool TryMoveNextQRoutine(IEnumerator inIEnumerator, QRoutine inParentQRoutine); // 0x00000001815F2670-0x00000001815F27F0
	private void Update(); // 0x00000001815F27F0-0x00000001815F29F0
}

