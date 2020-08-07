/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class CodeBreakerScroll : MonoBehaviour // TypeDefIndex: 10571
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
	private bool Paused { get; } // 0x000000018052D940-0x000000018052D950 

	// Nested types
	[Serializable]
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c // TypeDefIndex: 10572
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static TweenCallback <>9__20_1; // 0x08
		public static TweenCallback <>9__25_1; // 0x10

		// Constructors
		static <>c(); // 0x0000000180538B40-0x0000000180538BA0
		public <>c(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <OnMouseUp>b__20_1(); // 0x00000001805382A0-0x00000001805382B0
		internal void <SetMaxScrollPosition>b__25_1(); // 0x00000001805382A0-0x00000001805382B0
	}

	// Constructors
	public CodeBreakerScroll(); // 0x000000018052D920-0x000000018052D940

	// Methods
	private void Start(); // 0x000000018052D570-0x000000018052D650
	private void Update(); // 0x000000018052D8D0-0x000000018052D920
	private void OnDestroy(); // 0x000000018052C9F0-0x000000018052CA80
	private void OnGamePaused(CodeBreakerGamePausedMessage inMessage); // 0x000000018052CA80-0x000000018052CB10
	private void OnMouseDown(); // 0x000000018052CB10-0x000000018052CD50
	private void OnMouseUp(); // 0x000000018052D030-0x000000018052D260
	private void OnMouseDrag(); // 0x000000018052CD50-0x000000018052CFA0
	private void OnMouseOver(); // 0x000000018052CFA0-0x000000018052D030
	private void UpdateKnobRotation(); // 0x000000018052D6B0-0x000000018052D8D0
	private void OnScrollMoved(float amount); // 0x000000018052D260-0x000000018052D390
	public void SetMaxScrollPosition(float inMaxScroll, bool autoScrollToMax = false /* Metadata: 0x0077BDAF */); // 0x000000018052D390-0x000000018052D570
	public void Clear(); // 0x000000018052C940-0x000000018052C9F0
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <OnMouseUp>b__20_0(); // 0x000000018052D650-0x000000018052D6B0
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <SetMaxScrollPosition>b__25_0(); // 0x000000018052D650-0x000000018052D6B0
}

