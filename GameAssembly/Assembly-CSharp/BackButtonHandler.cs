/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class BackButtonHandler : MonoBehaviour // TypeDefIndex: 13584
{
	// Fields
	private static BackButtonHandler _instance; // 0x00
	private const float BackButtonMinimumTime = 0.25f; // Metadata: 0x00783E88
	private List<Action> _stack; // 0x20
	private float _lastBackButtonTime; // 0x28

	// Properties
	public static BackButtonHandler instance { get; } // 0x00000001810405A0-0x0000000181040790 

	// Constructors
	public BackButtonHandler(); // 0x0000000181040530-0x00000001810405A0
	static BackButtonHandler(); // 0x00000001803581E0-0x00000001803581F0

	// Methods
	public static void Push(Action onBackButton); // 0x0000000181040350-0x0000000181040400
	public static void Pop(Action onBackButton); // 0x00000001810402D0-0x0000000181040350
	private void Update(); // 0x0000000181040400-0x0000000181040530
}

