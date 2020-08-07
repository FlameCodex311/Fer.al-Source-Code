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

public class SurfaceFXWaterNode : ManagedBehaviour // TypeDefIndex: 11938
{
	// Fields
	private ActorBase _parentActorBase; // 0x50
	private FXState _fxState; // 0x58
	private WorldSurfaceDefComponent _currentBuiltFXSurfaceDef; // 0x60
	private SurfaceFXPrefab _currentBuiltFXBundle; // 0x68
	private float _currentBuiltFXSurfaceOffset; // 0x70
	private string _currentGroundID; // 0x78
	private Dictionary<string, float> _currentGroundMix; // 0x80
	private Vector3 _lastRaycastPosition; // 0x88
	private Transform _lastRaycastTransform; // 0x98
	private string _lastRaycastTransformName; // 0xA0
	private Vector3 _lastHitPosition; // 0xA8
	private Color? _color; // 0xB4

	// Properties
	private ActorBase ParentActorBase { get; } // 0x0000000180958900-0x0000000180958980 

	// Nested types
	private enum FXState // TypeDefIndex: 11939
	{
		Unbuilt = 0,
		Building = 1,
		Built = 2
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass10_0 // TypeDefIndex: 11940
	{
		// Fields
		public WorldSurfaceDefComponent inSurfaceDefComponent; // 0x10
		public SurfaceFXWaterNode <>4__this; // 0x18

		// Constructors
		public <>c__DisplayClass10_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <BuildFXRoutine>b__0(GameObject inLoadedAsset); // 0x0000000180962260-0x0000000180962490
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <BuildFXRoutine>d__10 : IEnumerator<object> // TypeDefIndex: 11941
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public WorldSurfaceDefComponent inSurfaceDefComponent; // 0x20
		public SurfaceFXWaterNode <>4__this; // 0x28

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <BuildFXRoutine>d__10(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x0000000180960B30-0x0000000180960CD0
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x0000000180960CD0-0x0000000180960D20
	}

	// Constructors
	public SurfaceFXWaterNode(); // 0x00000001809588A0-0x0000000180958900

	// Methods
	public override void MUpdate(); // 0x0000000180957D30-0x0000000180958140
	private void DestroyBuiltFX(); // 0x0000000180957290-0x0000000180957330
	[IteratorStateMachine] // 0x00000001801EB370-0x00000001801EB3C0
	private IEnumerator BuildFXRoutine(WorldSurfaceDefComponent inSurfaceDefComponent); // 0x0000000180957220-0x0000000180957290
	private void UpdateFXPosition(); // 0x0000000180958710-0x00000001809588A0
	private Color? GetColor(RaycastHit inHit); // 0x0000000180957330-0x0000000180957830
	private void RaycastCurrentGroundID(); // 0x0000000180958140-0x0000000180958710
	private float[] GetTextureMix(Vector3 inWorldPos); // 0x0000000180957B10-0x0000000180957D30
	private int GetMainTexture(Vector3 inWorldPos); // 0x0000000180957830-0x0000000180957B10
}

