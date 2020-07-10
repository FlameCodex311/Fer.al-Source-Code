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

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class ScreenShotHandler : MonoBehaviour // TypeDefIndex: 10090
{
	// Fields
	private Texture2D _savedScreenShot; // 0x20
	private bool takeScreenShot; // 0x28
	private Vector2Int dimensions; // 0x2C
	private Action<Texture2D> _callback; // 0x38
	public Vector2Int debugDimensions; // 0x40

	// Nested types
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <DoScreenShotRoutine>d__6 : IEnumerator<object> // TypeDefIndex: 10091
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public ScreenShotHandler <>4__this; // 0x20
		private PostProcessLayer <ppLayer>5__2; // 0x28
		private bool <revertAA>5__3; // 0x30

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <DoScreenShotRoutine>d__6(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x0000000180EC4870-0x0000000180EC4F20
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x0000000180EC4F20-0x0000000180EC54B0
	}

	// Constructors
	public ScreenShotHandler(); // 0x0000000180E095D0-0x0000000180E095E0

	// Methods
	private void Awake(); // 0x0000000180EBC2C0-0x0000000180EBC360
	private void LateUpdate(); // 0x0000000180EBC870-0x0000000180EBC8E0
	[IteratorStateMachine] // 0x0000000180147950-0x00000001801479A0
	private IEnumerator DoScreenShotRoutine(); // 0x0000000180EBC400-0x0000000180EBC460
	private string GetScreenShotFolderName(); // 0x0000000180EBC7E0-0x0000000180EBC850
	private string GetScreenShotFileName(); // 0x0000000180EBC460-0x0000000180EBC7E0
	private void HandleScreenCapture(); // 0x0000000180EBC850-0x0000000180EBC870
	private void ClearSavedScreenShot(); // 0x0000000180EBC360-0x0000000180EBC400
	public void TakeScreenShot(int width, int height, Action<Texture2D> inCallback = null); // 0x0000000180EBCA00-0x0000000180EBCA70
	public void SaveScreenShot(string inPath); // 0x0000000180EBC8E0-0x0000000180EBCA00
	[DeMethodButton] // 0x0000000180147C80-0x0000000180147CE0
	private void DebugTakeScreenShot_WithDimensions(); // 0x00000001803581E0-0x00000001803581F0
	[DeMethodButton] // 0x0000000180147FD0-0x0000000180148030
	private void DebugTakeScreenShot_FullScreen(); // 0x00000001803581E0-0x00000001803581F0
	[DeMethodButton] // 0x0000000180148510-0x0000000180148570
	private void DebugSaveScreenShot(); // 0x00000001803581E0-0x00000001803581F0
	[DeMethodButton] // 0x00000001801489B0-0x0000000180148A10
	private void ApplicationScreenShot(); // 0x0000000180EBC260-0x0000000180EBC2C0
}

