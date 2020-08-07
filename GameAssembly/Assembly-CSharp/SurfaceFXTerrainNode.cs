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

public class SurfaceFXTerrainNode : ManagedBehaviour // TypeDefIndex: 11934
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
	public SurfaceFXNodeState State { get; set; } // 0x00000001803F8270-0x00000001803F8280 0x0000000180CBC740-0x0000000180CBC750

	// Nested types
	public enum SurfaceFXNodeState // TypeDefIndex: 11935
	{
		Planted = 0,
		Lifted = 1
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <InstantiateFXBundle>d__1 : IEnumerator<object> // TypeDefIndex: 11936
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public string inBundleID; // 0x20
		public SurfaceFXTerrainNode <>4__this; // 0x28

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <InstantiateFXBundle>d__1(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x0000000180960D20-0x0000000180960FB0
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x0000000180960FB0-0x0000000180961000
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <UpdateRoutine>d__20 : IEnumerator<object> // TypeDefIndex: 11937
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public SurfaceFXTerrainNode <>4__this; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <UpdateRoutine>d__20(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x0000000180962520-0x0000000180962850
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x0000000180962850-0x00000001809628A0
	}

	// Constructors
	public SurfaceFXTerrainNode(); // 0x0000000180CBC6C0-0x0000000180CBC740

	// Methods
	[IteratorStateMachine] // 0x00000001801E9710-0x00000001801E9760
	private IEnumerator InstantiateFXBundle(string inBundleID); // 0x0000000180CBBE00-0x0000000180CBBE80
	private Color? GetColor(RaycastHit inHit); // 0x0000000180CBB400-0x0000000180CBB900
	private void RaycastCurrentGroundID(); // 0x0000000180CBBF60-0x0000000180CBC5D0
	private float[] GetTextureMix(Vector3 inWorldPos); // 0x0000000180CBBBE0-0x0000000180CBBE00
	private int GetMainTexture(Vector3 inWorldPos); // 0x0000000180CBB900-0x0000000180CBBBE0
	public override void MStart(); // 0x0000000180CBBE80-0x0000000180CBBF60
	[IteratorStateMachine] // 0x00000001801E9A50-0x00000001801E9AA0
	private IEnumerator UpdateRoutine(); // 0x0000000180CBC650-0x0000000180CBC6C0
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <InstantiateFXBundle>b__1_0(GameObject gObject); // 0x0000000180CBC5D0-0x0000000180CBC650
}

