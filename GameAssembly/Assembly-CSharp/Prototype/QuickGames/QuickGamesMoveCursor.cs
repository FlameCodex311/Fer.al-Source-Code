/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace Prototype.QuickGames
{
	public class QuickGamesMoveCursor : ManagedBehaviour // TypeDefIndex: 14971
	{
		// Fields
		[Tooltip] // 0x000000018025FC10-0x000000018025FC40
		public Transform cursorObject; // 0x50
		[Tooltip] // 0x0000000180230E50-0x0000000180230E80
		public float cursorMoveDistnceMaxX; // 0x58
		[Tooltip] // 0x0000000180230E50-0x0000000180230E80
		public float cursorMoveDistnceMaxY; // 0x5C
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
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
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private Vector2 <moveDir>k__BackingField; // 0xA4
	
		// Properties
		public Vector2 CursorPosition { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x0000000180A573B0-0x0000000180A573D0 0x00000001804AF510-0x00000001804AF520
		public Vector2 moveDir { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x0000000180A573D0-0x0000000180A573F0 0x0000000180A573F0-0x0000000180A57400
	
		// Constructors
		public QuickGamesMoveCursor(); // 0x0000000180A57350-0x0000000180A573B0
	
		// Methods
		public override void MStart(); // 0x0000000180A56DD0-0x0000000180A56F90
		public void ShowCursor(bool inShow); // 0x0000000180A57310-0x0000000180A57350
		public void MoveCursor(); // 0x0000000180A56F90-0x0000000180A57310
	}
}
