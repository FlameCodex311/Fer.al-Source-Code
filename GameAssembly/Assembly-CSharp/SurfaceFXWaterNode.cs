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

public class SurfaceFXWaterNode : ManagedBehaviour // TypeDefIndex: 10461
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
	private ActorBase ParentActorBase { get; } // 0x0000000181208680-0x0000000181208700 

	// Nested types
	private enum FXState // TypeDefIndex: 10462
	{
		Unbuilt = 0,
		Building = 1,
		Built = 2
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass10_0 // TypeDefIndex: 10463
	{
		// Fields
		public WorldSurfaceDefComponent inSurfaceDefComponent; // 0x10
		public SurfaceFXWaterNode <>4__this; // 0x18

		// Constructors
		public <>c__DisplayClass10_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <BuildFXRoutine>b__0(GameObject inLoadedAsset); // 0x00000001812130B0-0x0000000181213300
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <BuildFXRoutine>d__10 : IEnumerator<object> // TypeDefIndex: 10464
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public WorldSurfaceDefComponent inSurfaceDefComponent; // 0x20
		public SurfaceFXWaterNode <>4__this; // 0x28

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <BuildFXRoutine>d__10(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x00000001812118A0-0x0000000181211A40
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x0000000181211A40-0x0000000181211A90
	}

	// Constructors
	public SurfaceFXWaterNode(); // 0x0000000181208620-0x0000000181208680

	// Methods
	public override void MUpdate(); // 0x0000000181207AA0-0x0000000181207EB0
	private void DestroyBuiltFX(); // 0x0000000181206FA0-0x0000000181207040
	[IteratorStateMachine] // 0x000000018011F2B0-0x000000018011F300
	private IEnumerator BuildFXRoutine(WorldSurfaceDefComponent inSurfaceDefComponent); // 0x0000000181206F30-0x0000000181206FA0
	private void UpdateFXPosition(); // 0x0000000181208490-0x0000000181208620
	private Color? GetColor(RaycastHit inHit); // 0x0000000181207040-0x0000000181207560
	private void RaycastCurrentGroundID(); // 0x0000000181207EB0-0x0000000181208490
	private float[] GetTextureMix(Vector3 inWorldPos); // 0x0000000181207860-0x0000000181207AA0
	private int GetMainTexture(Vector3 inWorldPos); // 0x0000000181207560-0x0000000181207860
}

