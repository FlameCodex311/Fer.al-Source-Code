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
	public class EggProtector : QuickGamesBase // TypeDefIndex: 16112
	{
		// Fields
		public GameObject playerPrefab; // 0xF0
		public GameObject eggPrefab; // 0xF8
		public GameObject enemyPrefab; // 0x100
		private GameObject player; // 0x108
		private Rigidbody2D playerBody; // 0x110
		private List<GameObject> eggs; // 0x118
		private List<GameObject> enemies; // 0x120
		private GameObject board; // 0x128
		private Rect boardRect; // 0x130
		private Rect eggRect; // 0x140
		private Rect playerRect; // 0x150
		private Rect enemyRect; // 0x160
		private int numEggs; // 0x170
		private float enemySpawnWait; // 0x174
		private float spawnWait; // 0x178
	
		// Constructors
		public EggProtector(); // 0x00000001813A2220-0x00000001813A2240
	
		// Methods
		public override void MStart(); // 0x00000001813A1CE0-0x00000001813A1EB0
		public override void QuickGameUpdate(); // 0x00000001813A1EB0-0x00000001813A2010
		private void Initialize(); // 0x00000001813A1890-0x00000001813A1CE0
		private void SpawnEnemy(); // 0x00000001813A2010-0x00000001813A2220
		private void HandleInput(); // 0x00000001813A1770-0x00000001813A1890
	}
}
