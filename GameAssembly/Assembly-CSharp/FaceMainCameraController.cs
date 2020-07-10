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

public class FaceMainCameraController // TypeDefIndex: 10088
{
	// Fields
	private static List<FaceMainCamera> _faceMainCameraList; // 0x00
	private static Coroutine _updateRoutine; // 0x08
	private static Camera _cachedCamera; // 0x10

	// Properties
	private static Camera cachedCamera { get; } // 0x000000018148F940-0x000000018148FA40 

	// Nested types
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <FaceCameraRoutine>d__7 : IEnumerator<object> // TypeDefIndex: 10089
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <FaceCameraRoutine>d__7(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x00000001814AA590-0x00000001814AA950
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x00000001814AA950-0x00000001814AA9A0
	}

	// Constructors
	public FaceMainCameraController(); // 0x000000018036B6C0-0x000000018036B6D0
	static FaceMainCameraController(); // 0x000000018148F8C0-0x000000018148F940

	// Methods
	public static void Add(FaceMainCamera inFaceMainCamera); // 0x000000018148F4A0-0x000000018148F680
	public static void Remove(FaceMainCamera inFaceMainCamera); // 0x000000018148F6D0-0x000000018148F8C0
	[IteratorStateMachine] // 0x0000000180146CA0-0x0000000180146CF0
	private static IEnumerator FaceCameraRoutine(); // 0x000000018148F680-0x000000018148F6D0
}

