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
	public class Timing : QuickGamesBase // TypeDefIndex: 14996
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
		public Timing(); // 0x0000000180A3E570-0x0000000180A3E5E0
	
		// Methods
		public override void MStart(); // 0x0000000180A3E330-0x0000000180A3E3C0
		private void Initialize(); // 0x0000000180A3E2A0-0x0000000180A3E330
		public override void QuickGameUpdate(); // 0x0000000180A3E3C0-0x0000000180A3E570
	}
}
