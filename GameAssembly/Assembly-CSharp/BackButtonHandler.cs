/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class BackButtonHandler : MonoBehaviour // TypeDefIndex: 11251
{
	// Fields
	private static BackButtonHandler _instance; // 0x00
	private const float BackButtonMinimumTime = 0.25f; // Metadata: 0x0077C947
	private List<Action> _stack; // 0x20
	private float _lastBackButtonTime; // 0x28

	// Properties
	public static BackButtonHandler instance { get; } // 0x000000018215A270-0x000000018215A450 

	// Constructors
	public BackButtonHandler(); // 0x000000018215A200-0x000000018215A270
	static BackButtonHandler(); // 0x00000001803774A0-0x00000001803774B0

	// Methods
	public static void Push(Action onBackButton); // 0x000000018215A020-0x000000018215A0D0
	public static void Pop(Action onBackButton); // 0x0000000182159FA0-0x000000018215A020
	private void Update(); // 0x000000018215A0D0-0x000000018215A200
}

