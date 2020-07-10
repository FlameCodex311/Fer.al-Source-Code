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

[Serializable]
public class VisibleCullingGroup : ManagedBehaviour // TypeDefIndex: 10656
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private VisibleDistanceType visibleDistanceType; // 0x50
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private bool useRaycast; // 0x54
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private bool onlyDisableRenderers; // 0x55
	[InspectorDisableOrHideByValue] // 0x0000000180164990-0x00000001801649E0
	[SerializeField] // 0x0000000180164990-0x00000001801649E0
	private float _customVisibleDistance; // 0x58
	private RaycastHit? _lastHit; // 0x5C
	private static RaycastHit[] _visibilityHitsNoAlloc; // 0x00
	private float _lastDistanceToCamera; // 0x8C

	// Properties
	private float VisibleDistance { get; } // 0x00000001811339A0-0x00000001811339E0 
	private bool IsCustomVisibleDistanceType { get; } // 0x0000000181133840-0x0000000181133850 
	private Ray VisibilityRay { get; } // 0x0000000181133850-0x00000001811339A0 
	private Vector3 CameraPosition { get; } // 0x00000001811335A0-0x0000000181133730 
	private static bool Preview { get; set; } // 0x00000001803C29F0-0x00000001803C2A00 0x00000001803581E0-0x00000001803581F0
	private float DistanceToCamera { get; } // 0x0000000181133730-0x0000000181133840 
	private bool Visible { get; set; } // 0x00000001811339E0-0x0000000181133C80 0x0000000181133C80-0x0000000181133F60

	// Nested types
	[Serializable]
	public enum VisibleDistanceType // TypeDefIndex: 10657
	{
		Far = 10,
		Close = 20,
		Custom = 30
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <VisibilityRoutine>d__18 : IEnumerator<object> // TypeDefIndex: 10658
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public VisibleCullingGroup <>4__this; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <VisibilityRoutine>d__18(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x000000018112C5F0-0x000000018112C6E0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x000000018112C6E0-0x000000018112C730
	}

	// Constructors
	public VisibleCullingGroup(); // 0x0000000181133530-0x00000001811335A0
	static VisibleCullingGroup(); // 0x00000001811334E0-0x0000000181133530

	// Methods
	public override void MStartAfterLocal(); // 0x0000000181132B40-0x0000000181132BC0
	private RaycastHit? RaycastToCamera(float inDistance); // 0x0000000181132F50-0x0000000181133340
	private bool TestAndSetVisibility(); // 0x0000000181133380-0x0000000181133480
	[IteratorStateMachine] // 0x0000000180164CD0-0x0000000180164D20
	private IEnumerator VisibilityRoutine(); // 0x0000000181133480-0x00000001811334E0
	private void SetVisible(bool inVisible); // 0x0000000181133340-0x0000000181133380
	private void OnDrawGizmos(); // 0x0000000181132BC0-0x0000000181132F50
}

