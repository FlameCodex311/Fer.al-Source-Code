/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace Prototype.QuickGames.CatchThrownItems
{
	public class CatchThrownItemsDragTarget : UnityEngine.MonoBehaviour // TypeDefIndex: 16308
	{
		// Fields
		public CircleCollider2D moverCollider; // 0x18
		public BoxCollider2D catcherCollider; // 0x20
		public TargetJoint2D moverTargetJoint; // 0x28
		public LayerMask dragLayers; // 0x30
		public bool drawDragLine; // 0x34
		public Color color; // 0x38
		public float maxY; // 0x48
		public float minY; // 0x4C
		public float maxX; // 0x50
		public Transform catchPoints; // 0x58
		internal List<Transform> allCatchPoints; // 0x60
		internal CatchThrownItems game; // 0x68
		internal RectTransform rectTrans; // 0x70
		private int _caughtPositionIndex; // 0x78
		private RectTransform _hudRect; // 0x80
		private Vector3 _mouseWorldPosition; // 0x88
		private bool _moverSelected; // 0x94
		private float _maxYworld; // 0x98
		private float _minYworld; // 0x9C
		private float _maxXworld; // 0xA0
		private float _minXworld; // 0xA4
	
		// Nested types
		[Serializable]
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c // TypeDefIndex: 16309
		{
			// Fields
			public static readonly <>c <>9; // 0x00
			public static Comparison<Transform> <>9__21_0; // 0x08
	
			// Constructors
			static <>c(); // 0x00000001813B0E90-0x00000001813B0EF0
			public <>c(); // 0x000000018036B6C0-0x000000018036B6D0
	
			// Methods
			internal int <Init>b__21_0(Transform a, Transform b); // 0x00000001813B0650-0x00000001813B06C0
		}
	
		// Constructors
		public CatchThrownItemsDragTarget(); // 0x0000000181399A90-0x0000000181399AE0
	
		// Methods
		internal void Init(); // 0x00000001813997B0-0x0000000181399A90
		internal void DragTargetUpdate(); // 0x00000001813991F0-0x0000000181399750
		internal int GetCaughtPosIndex(); // 0x0000000181399750-0x00000001813997B0
	}
}
