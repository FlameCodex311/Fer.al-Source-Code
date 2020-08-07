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

public class FaceMainCameraController // TypeDefIndex: 11578
{
	// Fields
	private static List<FaceMainCamera> _faceMainCameraList; // 0x00
	private static Coroutine _updateRoutine; // 0x08
	private static Camera _cachedCamera; // 0x10

	// Properties
	private static Camera cachedCamera { get; } // 0x00000001808672F0-0x00000001808673F0 

	// Nested types
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <FaceCameraRoutine>d__7 : IEnumerator<object> // TypeDefIndex: 11579
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <FaceCameraRoutine>d__7(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x000000018086A4F0-0x000000018086A8A0
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x000000018086A8A0-0x000000018086AD70
	}

	// Constructors
	public FaceMainCameraController(); // 0x0000000180373240-0x0000000180373250
	static FaceMainCameraController(); // 0x0000000180867270-0x00000001808672F0

	// Methods
	public static void Add(FaceMainCamera inFaceMainCamera); // 0x0000000180866E50-0x0000000180867030
	public static void Remove(FaceMainCamera inFaceMainCamera); // 0x0000000180867080-0x0000000180867270
	[IteratorStateMachine] // 0x00000001802205A0-0x00000001802205F0
	private static IEnumerator FaceCameraRoutine(); // 0x0000000180867030-0x0000000180867080
}

