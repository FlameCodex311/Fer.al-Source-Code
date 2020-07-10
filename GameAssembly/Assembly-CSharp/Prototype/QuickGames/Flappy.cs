/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace Prototype.QuickGames
{
	public class Flappy : QuickGamesBase // TypeDefIndex: 16115
	{
		// Fields
		public GameObject playerPrefab; // 0xF0
		public GameObject obstaclePrefab; // 0xF8
		public float movementSpeed; // 0x100
		public float obstacleGap; // 0x104
		public float flapForce; // 0x108
		private GameObject player; // 0x110
		private Rigidbody2D playerRB; // 0x118
		private GameObject board; // 0x120
		private GameObject obstacleHolder; // 0x128
		private RectTransform obstacleHolderRectTransform; // 0x130
		private GameObject pipeHolder; // 0x138
		private List<GameObject> obstacles; // 0x140
		private Vector2 groundMovement; // 0x148
	
		// Constructors
		public Flappy(); // 0x00000001813E8860-0x00000001813E8890
	
		// Methods
		public override void MStart(); // 0x00000001813E8530-0x00000001813E86E0
		private void Initialize(); // 0x00000001813E8240-0x00000001813E8530
		public override void QuickGameUpdate(); // 0x00000001813E86F0-0x00000001813E8860
		public void PlayerCollision(); // 0x00000001813E86E0-0x00000001813E86F0
	}
}
