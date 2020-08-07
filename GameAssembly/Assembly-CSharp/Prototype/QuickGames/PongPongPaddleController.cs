/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace Prototype.QuickGames
{
	public class PongPongPaddleController : MonoBehaviour, IPointerDownHandler, IPointerUpHandler // TypeDefIndex: 14950
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
		public PongPongPaddleController(); // 0x0000000180A52430-0x0000000180A52450
	
		// Methods
		public void SetUp(Vector2 startPos, float speed, bool isEnemy, PongPongController parentController, PongPongBallController ballController); // 0x0000000180A52350-0x0000000180A52430
		public void OnPointerDown(PointerEventData pointerEventData); // 0x0000000180A522B0-0x0000000180A522C0
		public void OnPointerUp(PointerEventData pointerEventData); // 0x0000000180A522C0-0x0000000180A522D0
		public void QuickGameUpdate(); // 0x0000000180A522D0-0x0000000180A522E0
		private void FixedUpdate(); // 0x0000000180A51CC0-0x0000000180A51E30
		private void HandleMovement(); // 0x0000000180A51F90-0x0000000180A522B0
		public Vector2 GetStrikeForce(); // 0x0000000180A51E30-0x0000000180A51F90
		public void Reset(); // 0x0000000180A522E0-0x0000000180A52350
	}
}
