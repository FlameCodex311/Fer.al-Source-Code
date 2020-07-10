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

public class SurfaceFXTerrainNode : ManagedBehaviour // TypeDefIndex: 10457
{
	// Fields
	private SurfaceFXNodeState _state; // 0x50
	private string _currentGroundID; // 0x58
	private Dictionary<string, float> _currentGroundMix; // 0x60
	private Vector3 _lastRaycastPosition; // 0x68
	private Transform _lastRaycastTransform; // 0x78
	private string _lastRaycastTransformName; // 0x80
	private Color? _color; // 0x88
	private Vector3 _lastPosition; // 0x9C
	private float _lastLiftedY; // 0xA8
	private float _lastPlantedY; // 0xAC

	// Properties
	public SurfaceFXNodeState State { get; set; } // 0x0000000180369BA0-0x0000000180369BB0 0x0000000181206F20-0x0000000181206F30

	// Nested types
	public enum SurfaceFXNodeState // TypeDefIndex: 10458
	{
		Planted = 0,
		Lifted = 1
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <InstantiateFXBundle>d__1 : IEnumerator<object> // TypeDefIndex: 10459
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public string inBundleID; // 0x20
		public SurfaceFXTerrainNode <>4__this; // 0x28

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <InstantiateFXBundle>d__1(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x0000000181211A90-0x0000000181211D30
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x0000000181211D30-0x0000000181211D80
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <UpdateRoutine>d__20 : IEnumerator<object> // TypeDefIndex: 10460
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public SurfaceFXTerrainNode <>4__this; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <UpdateRoutine>d__20(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x0000000181213520-0x0000000181213860
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x0000000181213860-0x00000001812138B0
	}

	// Constructors
	public SurfaceFXTerrainNode(); // 0x0000000181206EA0-0x0000000181206F20

	// Methods
	[IteratorStateMachine] // 0x000000018011D9D0-0x000000018011DA20
	private IEnumerator InstantiateFXBundle(string inBundleID); // 0x00000001812065F0-0x0000000181206660
	private Color? GetColor(RaycastHit inHit); // 0x0000000181205B90-0x00000001812060B0
	private void RaycastCurrentGroundID(); // 0x0000000181206730-0x0000000181206DC0
	private float[] GetTextureMix(Vector3 inWorldPos); // 0x00000001812063B0-0x00000001812065F0
	private int GetMainTexture(Vector3 inWorldPos); // 0x00000001812060B0-0x00000001812063B0
	public override void MStart(); // 0x0000000181206660-0x0000000181206730
	[IteratorStateMachine] // 0x000000018011DBB0-0x000000018011DC00
	private IEnumerator UpdateRoutine(); // 0x0000000181206E40-0x0000000181206EA0
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <InstantiateFXBundle>b__1_0(GameObject gObject); // 0x0000000181206DC0-0x0000000181206E40
}

