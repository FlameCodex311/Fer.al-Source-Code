/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace Prototype.QuickGames
{
	public class QuickGamesMoveCursor : ManagedBehaviour // TypeDefIndex: 16229
	{
		// Fields
		[Tooltip] // 0x0000000180140C80-0x0000000180140CB0
		public Transform cursorObject; // 0x50
		[Tooltip] // 0x000000018010DF10-0x000000018010DF40
		public float cursorMoveDistnceMaxX; // 0x58
		[Tooltip] // 0x000000018010DF10-0x000000018010DF40
		public float cursorMoveDistnceMaxY; // 0x5C
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private Vector2 <CursorPosition>k__BackingField; // 0x60
		private QuickGamesBase _game; // 0x68
		private Vector2 _lastMousePosition; // 0x70
		private Vector2 _currentMousePosition; // 0x78
		private Vector2 _originaCursorPosition; // 0x80
		private float _playAreaBorderMaxX; // 0x88
		private float _playAreaBorderMaxY; // 0x8C
		private float _playAreaBorderMinX; // 0x90
		private float _playAreaBorderMinY; // 0x94
		private Vector3 _localZreset; // 0x98
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private Vector2 <moveDir>k__BackingField; // 0xA4
	
		// Properties
		public Vector2 CursorPosition { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x0000000181535010-0x0000000181535030 0x00000001803A27E0-0x00000001803A27F0
		public Vector2 moveDir { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x0000000181535030-0x0000000181535050 0x0000000181535050-0x0000000181535060
	
		// Constructors
		public QuickGamesMoveCursor(); // 0x0000000181534FB0-0x0000000181535010
	
		// Methods
		public override void MStart(); // 0x0000000181534A30-0x0000000181534BF0
		public void ShowCursor(bool inShow); // 0x0000000181534F70-0x0000000181534FB0
		public void MoveCursor(); // 0x0000000181534BF0-0x0000000181534F70
	}
}
