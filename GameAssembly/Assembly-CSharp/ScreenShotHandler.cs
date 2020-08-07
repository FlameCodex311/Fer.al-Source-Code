/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.DeInspektor.Attributes;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class ScreenShotHandler : MonoBehaviour // TypeDefIndex: 11581
{
	// Fields
	private Texture2D _savedScreenShot; // 0x20
	private bool takeScreenShot; // 0x28
	private Vector2Int dimensions; // 0x2C
	private Action<Texture2D> _callback; // 0x38
	public Vector2Int debugDimensions; // 0x40

	// Nested types
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <DoScreenShotRoutine>d__6 : IEnumerator<object> // TypeDefIndex: 11582
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public ScreenShotHandler <>4__this; // 0x20
		private PostProcessLayer <ppLayer>5__2; // 0x28
		private bool <revertAA>5__3; // 0x30

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <DoScreenShotRoutine>d__6(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x00000001804006F0-0x0000000180400D70
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x0000000180400D70-0x0000000180401060
	}

	// Constructors
	public ScreenShotHandler(); // 0x00000001803743C0-0x00000001803743D0

	// Methods
	private void Awake(); // 0x00000001803FAA60-0x00000001803FAB00
	private void LateUpdate(); // 0x00000001803FAFF0-0x00000001803FB060
	[IteratorStateMachine] // 0x0000000180221290-0x00000001802212E0
	private IEnumerator DoScreenShotRoutine(); // 0x00000001803FABA0-0x00000001803FAC00
	private string GetScreenShotFolderName(); // 0x00000001803FAF60-0x00000001803FAFD0
	private string GetScreenShotFileName(); // 0x00000001803FAC00-0x00000001803FAF60
	private void HandleScreenCapture(); // 0x00000001803FAFD0-0x00000001803FAFF0
	private void ClearSavedScreenShot(); // 0x00000001803FAB00-0x00000001803FABA0
	public void TakeScreenShot(int width, int height, Action<Texture2D> inCallback = null); // 0x00000001803FB180-0x00000001803FB1F0
	public void SaveScreenShot(string inPath); // 0x00000001803FB060-0x00000001803FB180
	[DeMethodButton] // 0x0000000180221410-0x0000000180221470
	private void DebugTakeScreenShot_WithDimensions(); // 0x00000001803774A0-0x00000001803774B0
	[DeMethodButton] // 0x0000000180221800-0x0000000180221860
	private void DebugTakeScreenShot_FullScreen(); // 0x00000001803774A0-0x00000001803774B0
	[DeMethodButton] // 0x0000000180221AB0-0x0000000180221B10
	private void DebugSaveScreenShot(); // 0x00000001803774A0-0x00000001803774B0
	[DeMethodButton] // 0x0000000180221D50-0x0000000180221DB0
	private void ApplicationScreenShot(); // 0x00000001803FAA00-0x00000001803FAA60
}

