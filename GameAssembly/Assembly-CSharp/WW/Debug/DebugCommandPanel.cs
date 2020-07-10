/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace WW.Debug
{
	public class DebugCommandPanel : DebugPanel // TypeDefIndex: 15702
	{
		// Fields
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private bool clearCommandAfterExecution; // 0x50
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private DebugCommandOutput _output; // 0x58
		private List<string> _commandHistory; // 0x60
		private int _historyIndex; // 0x68
		private bool _moveCaretToEnd; // 0x6C
	
		// Constructors
		public DebugCommandPanel(); // 0x000000018111F990-0x000000018111FA00
	
		// Methods
		protected override void OnEnable(); // 0x000000018111F5C0-0x000000018111F690
		protected override void OnDisable(); // 0x000000018111F4F0-0x000000018111F5C0
		protected override void LateUpdate(); // 0x000000018111F4B0-0x000000018111F4F0
		private void Update(); // 0x000000018111F7D0-0x000000018111F990
		private void GetPreviousCommand(); // 0x000000018111F3E0-0x000000018111F4B0
		private void GetNextCommand(); // 0x000000018111F320-0x000000018111F3E0
		public override void BtnClicked_Clear(); // 0x000000018111F280-0x000000018111F320
		public char OnValidateCommand(string text, int charIndex, char addedChar); // 0x000000018111F690-0x000000018111F7D0
	}
}
