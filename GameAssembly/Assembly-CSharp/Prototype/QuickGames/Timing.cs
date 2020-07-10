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
	public class Timing : QuickGamesBase // TypeDefIndex: 16254
	{
		// Fields
		public GameObject cursorPrefab; // 0xF0
		public GameObject targetPrefab; // 0xF8
		public float playAreaWidth; // 0x100
		public float playAreaHeight; // 0x104
		public float targetAreaWidth; // 0x108
		public float targetAreaHeight; // 0x10C
		public float cursorWidth; // 0x110
		public float cursorHeight; // 0x114
		public float cursorGap; // 0x118
		public int numCursors; // 0x11C
		public float cursorVelocity; // 0x120
		private List<GameObject> cursors; // 0x128
		private GameObject currentCursor; // 0x130
		private int ccIdx; // 0x138
	
		// Constructors
		public Timing(); // 0x00000001816018F0-0x0000000181601960
	
		// Methods
		public override void MStart(); // 0x00000001816016A0-0x0000000181601730
		private void Initialize(); // 0x0000000181601610-0x00000001816016A0
		public override void QuickGameUpdate(); // 0x0000000181601730-0x00000001816018F0
	}
}
