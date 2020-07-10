/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace Prototype.QuickGames.FindTheTreasure
{
	public class FindTheTreasure_dragTarget : UnityEngine.MonoBehaviour // TypeDefIndex: 16296
	{
		// Fields
		public Transform spotLight; // 0x18
		public CircleCollider2D moverCollider; // 0x20
		public Rigidbody2D moverRigidBody; // 0x28
		public TargetJoint2D moverTargetJoint; // 0x30
		public RawImage rawImage; // 0x38
		public Canvas canvas; // 0x40
		public LayerMask dragLayers; // 0x48
		public bool drawDragLine; // 0x4C
		public Color color; // 0x50
		public float spotlightSmooth; // 0x60
		public float maxSpotliteRotate; // 0x64
		public float maxSpotlightSpeed; // 0x68
		public float maxY; // 0x6C
		public float minY; // 0x70
		public float maxXmin; // 0x74
		public float maxXmax; // 0x78
		public float UImaxX; // 0x7C
		public bool tiltSpotLight; // 0x80
		public RectTransform BG_back; // 0x88
		public RectTransform BG_mid; // 0x90
		public RectTransform BG_fore; // 0x98
		public float BGspeed_back; // 0xA0
		public float BGspeed_mid; // 0xA4
		public float BGspeed_fore; // 0xA8
		internal FindTheTreasure Game; // 0xB0
		internal RectTransform rectTrans; // 0xB8
		private RectTransform _hudRect; // 0xC0
		private Vector2 _mouseLocalPosition; // 0xC8
		private Quaternion _spotlightRotate; // 0xD0
		private TargetJoint2D _targetJoint; // 0xE0
		private Vector3 _mouseWorldPosition; // 0xE8
		private Camera _cam; // 0xF8
		private Rect _facingRect; // 0x100
		private bool _moverSelected; // 0x110
		private Vector2 _moveDir; // 0x114
		private float _maxXrange; // 0x11C
		private float _maxYworld; // 0x120
		private float _minYworld; // 0x124
		private float _maxXworld; // 0x128
		private float _minXworld; // 0x12C
	
		// Constructors
		public FindTheTreasure_dragTarget(); // 0x00000001813E8180-0x00000001813E8210
	
		// Methods
		internal void Init(); // 0x00000001813E7F50-0x00000001813E8180
		internal void DragTargetUpdate(); // 0x00000001813E71A0-0x00000001813E7F50
	}
}
