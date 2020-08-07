/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace Prototype.QuickGames
{
	public class Flappy : QuickGamesBase // TypeDefIndex: 14857
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
		public Flappy(); // 0x000000018097FED0-0x000000018097FF00
	
		// Methods
		public override void MStart(); // 0x000000018097FBB0-0x000000018097FD50
		private void Initialize(); // 0x000000018097F8D0-0x000000018097FBB0
		public override void QuickGameUpdate(); // 0x000000018097FD60-0x000000018097FED0
		public void PlayerCollision(); // 0x000000018097FD50-0x000000018097FD60
	}
}
