/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace Prototype.QuickGames
{
	public class PongPongPaddleController : MonoBehaviour, IPointerDownHandler, IPointerUpHandler // TypeDefIndex: 16208
	{
		// Fields
		private PongPongController parentController; // 0x20
		private PongPongBallController ballController; // 0x28
		private RectTransform rectTransform; // 0x30
		private Rigidbody2D body; // 0x38
		private float speed; // 0x40
		private bool isEnemy; // 0x44
		private Vector2 startPos; // 0x48
		private Vector2 targetPos; // 0x50
		private Vector2 prevPos; // 0x58
		private bool isMoving; // 0x60
		private Vector2 velocity; // 0x64
		private int mcu; // 0x6C
		private int mc; // 0x70
		private bool enemyOnRight; // 0x74
		private bool pointerDown; // 0x75
	
		// Constructors
		public PongPongPaddleController(); // 0x000000018152FF30-0x000000018152FF50
	
		// Methods
		public void SetUp(Vector2 startPos, float speed, bool isEnemy, PongPongController parentController, PongPongBallController ballController); // 0x000000018152FE50-0x000000018152FF30
		public void OnPointerDown(PointerEventData pointerEventData); // 0x000000018152FDB0-0x000000018152FDC0
		public void OnPointerUp(PointerEventData pointerEventData); // 0x000000018152FDC0-0x000000018152FDD0
		public void QuickGameUpdate(); // 0x000000018152FDD0-0x000000018152FDE0
		private void FixedUpdate(); // 0x000000018152F7B0-0x000000018152F920
		private void HandleMovement(); // 0x000000018152FA80-0x000000018152FDB0
		public Vector2 GetStrikeForce(); // 0x000000018152F920-0x000000018152FA80
		public void Reset(); // 0x000000018152FDE0-0x000000018152FE50
	}
}
