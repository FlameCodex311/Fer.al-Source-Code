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

[Serializable]
public class VisibleCullingGroup : ManagedBehaviour // TypeDefIndex: 12159
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private VisibleDistanceType visibleDistanceType; // 0x50
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private bool useRaycast; // 0x54
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private bool onlyDisableRenderers; // 0x55
	[InspectorDisableOrHideByValue] // 0x0000000180244A80-0x0000000180244AD0
	[SerializeField] // 0x0000000180244A80-0x0000000180244AD0
	private float _customVisibleDistance; // 0x58
	private RaycastHit? _lastHit; // 0x5C
	private static RaycastHit[] _visibilityHitsNoAlloc; // 0x00
	private float _lastDistanceToCamera; // 0x8C

	// Properties
	private float VisibleDistance { get; } // 0x00000001806778E0-0x0000000180677920 
	private bool IsCustomVisibleDistanceType { get; } // 0x0000000180677780-0x0000000180677790 
	private Ray VisibilityRay { get; } // 0x0000000180677790-0x00000001806778E0 
	private Vector3 CameraPosition { get; } // 0x0000000180677500-0x0000000180677680 
	private static bool Preview { get; set; } // 0x0000000180380B60-0x0000000180380B70 0x00000001803774A0-0x00000001803774B0
	private float DistanceToCamera { get; } // 0x0000000180677680-0x0000000180677780 
	private bool Visible { get; set; } // 0x0000000180677920-0x0000000180677BC0 0x0000000180677BC0-0x0000000180677E90

	// Nested types
	[Serializable]
	public enum VisibleDistanceType // TypeDefIndex: 12160
	{
		Far = 10,
		Close = 20,
		Custom = 30
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <VisibilityRoutine>d__18 : IEnumerator<object> // TypeDefIndex: 12161
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public VisibleCullingGroup <>4__this; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <VisibilityRoutine>d__18(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x000000018066A720-0x000000018066A810
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x000000018066A810-0x000000018066A860
	}

	// Constructors
	public VisibleCullingGroup(); // 0x0000000180677490-0x0000000180677500
	static VisibleCullingGroup(); // 0x0000000180677440-0x0000000180677490

	// Methods
	public override void MStartAfterLocal(); // 0x0000000180676AB0-0x0000000180676B30
	private RaycastHit? RaycastToCamera(float inDistance); // 0x0000000180676EC0-0x00000001806772A0
	private bool TestAndSetVisibility(); // 0x00000001806772E0-0x00000001806773E0
	[IteratorStateMachine] // 0x0000000180244C60-0x0000000180244CB0
	private IEnumerator VisibilityRoutine(); // 0x00000001806773E0-0x0000000180677440
	private void SetVisible(bool inVisible); // 0x00000001806772A0-0x00000001806772E0
	private void OnDrawGizmos(); // 0x0000000180676B30-0x0000000180676EC0
}

