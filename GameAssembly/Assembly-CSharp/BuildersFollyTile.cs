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

public class BuildersFollyTile : MonoBehaviour // TypeDefIndex: 10488
{
	// Fields
	[RootSelector] // 0x00000001802007E0-0x0000000180200840
	public string StationName; // 0x20
	public BuildersFollyData.ETileTypes tileType; // 0x28
	public BuildersFollyData.ETileGridPlacement tileGridPlacement; // 0x2C
	public BuildersFollyGridSpot[] gridSpots; // 0x30
	public Path[] paths; // 0x38
	public GameObject invalidIndicator; // 0x40
	public Sprite stationImage; // 0x48
	public GameObject selectedIndicator; // 0x50
	public GameObject flip; // 0x58
	public GameObject rotate; // 0x60
	public Transform fxAttachPoint; // 0x68
	public bool useHeightForMoveIndicator; // 0x70
	public float moveIndicatorHeight; // 0x74
	public bool useColorChangeForMoveIndication; // 0x78
	public Color moveIndicatorColor; // 0x7C
	public bool useJiggleForMovementIndicator; // 0x8C
	public Transform jiggleTransform; // 0x90
	public Vector3 jiggleMaxRotation; // 0x98
	public float jiggleRotationSpeed; // 0xA4
	private Quaternion _initialRotation; // 0xA8
	internal bool trappedTwiggle; // 0xB8
	internal bool flipped; // 0xB9
	internal bool inMoveMode; // 0xBA
	internal int tileRotation; // 0xBC
	internal int gridXspot; // 0xC0
	internal int gridZspot; // 0xC4
	internal bool _isValid; // 0xC8
	internal Animator animator; // 0xD0
	internal BuildersFollyGridSpot closestGridSpot; // 0xD8
	internal BuildersFollyTile previousTile; // 0xE0
	internal BuildersFollyTile nextTile; // 0xE8
	private bool wasValid; // 0xF0

	// Properties
	internal bool isValid { get; set; } // 0x0000000180AB93C0-0x0000000180AB93D0 0x0000000180AB93D0-0x0000000180AB93E0

	// Nested types
	[Serializable]
	public struct Path // TypeDefIndex: 10489
	{
		// Fields
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		public Transform[] pathPoints; // 0x00
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <PulseIndicator>d__40 : IEnumerator<object> // TypeDefIndex: 10490
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public BuildersFollyTile <>4__this; // 0x20
		private Material <mat>5__2; // 0x28
		private Color <oldColor>5__3; // 0x30
		private float <fTimer>5__4; // 0x40
		private Quaternion <qToRotation>5__5; // 0x44

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <PulseIndicator>d__40(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x0000000180ACAB80-0x0000000180ACB1E0
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x0000000180ACB1E0-0x0000000180ACB230
	}

	// Constructors
	public BuildersFollyTile(); // 0x0000000180AB9320-0x0000000180AB93C0

	// Methods
	private void Start(); // 0x0000000180AB91D0-0x0000000180AB9280
	internal void UpdateValid(); // 0x0000000180AB9280-0x0000000180AB9320
	internal void AnimationDelivered(); // 0x0000000180AB8F60-0x0000000180AB8FF0
	internal void AnimationTrigger(bool inPlay); // 0x0000000180AB8FF0-0x0000000180AB9170
	[IteratorStateMachine] // 0x0000000180200910-0x0000000180200960
	internal IEnumerator PulseIndicator(); // 0x0000000180AB9170-0x0000000180AB91D0
}

