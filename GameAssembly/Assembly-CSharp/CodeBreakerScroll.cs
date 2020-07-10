/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class CodeBreakerScroll : MonoBehaviour // TypeDefIndex: 12906
{
	// Fields
	public Collider scrollCollider; // 0x20
	public Camera raycastCamera; // 0x28
	public float scrollScale; // 0x30
	public float scrollKnobScale; // 0x34
	public GameObject notesContainer; // 0x38
	public List<GameObject> scrollKnobs; // 0x40
	private Vector3 lastPos; // 0x48
	private float _minScrollY; // 0x54
	private float _maxScrollY; // 0x58
	private float _scrollY; // 0x5C
	private bool _dragging; // 0x60
	private int _pausedCount; // 0x64
	private float _playScrollSfxTimer; // 0x68

	// Properties
	private bool Paused { get; } // 0x00000001812751C0-0x00000001812751D0 

	// Nested types
	[Serializable]
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c // TypeDefIndex: 12907
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static TweenCallback <>9__20_1; // 0x08
		public static TweenCallback <>9__25_1; // 0x10

		// Constructors
		static <>c(); // 0x00000001812820D0-0x0000000181282130
		public <>c(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <OnMouseUp>b__20_1(); // 0x0000000181281810-0x0000000181281820
		internal void <SetMaxScrollPosition>b__25_1(); // 0x0000000181281810-0x0000000181281820
	}

	// Constructors
	public CodeBreakerScroll(); // 0x00000001812751A0-0x00000001812751C0

	// Methods
	private void Start(); // 0x0000000181274DE0-0x0000000181274EC0
	private void Update(); // 0x0000000181275150-0x00000001812751A0
	private void OnDestroy(); // 0x0000000181274260-0x00000001812742F0
	private void OnGamePaused(CodeBreakerGamePausedMessage inMessage); // 0x00000001812742F0-0x0000000181274380
	private void OnMouseDown(); // 0x0000000181274380-0x00000001812745C0
	private void OnMouseUp(); // 0x00000001812748A0-0x0000000181274AD0
	private void OnMouseDrag(); // 0x00000001812745C0-0x0000000181274810
	private void OnMouseOver(); // 0x0000000181274810-0x00000001812748A0
	private void UpdateKnobRotation(); // 0x0000000181274F20-0x0000000181275150
	private void OnScrollMoved(float amount); // 0x0000000181274AD0-0x0000000181274C00
	public void SetMaxScrollPosition(float inMaxScroll, bool autoScrollToMax = false /* Metadata: 0x00783304 */); // 0x0000000181274C00-0x0000000181274DE0
	public void Clear(); // 0x00000001812741A0-0x0000000181274260
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <OnMouseUp>b__20_0(); // 0x0000000181274EC0-0x0000000181274F20
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <SetMaxScrollPosition>b__25_0(); // 0x0000000181274EC0-0x0000000181274F20
}

