/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace WW.Debug
{
	public class DebugCommandPanel : DebugPanel // TypeDefIndex: 16253
	{
		// Fields
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private bool clearCommandAfterExecution; // 0x50
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private DebugCommandOutput _output; // 0x58
		private CommandHistorySerialized _commandHistory; // 0x60
		private int _historyIndex; // 0x68
		private bool _moveCaretToEnd; // 0x6C
		private const string COMMAND_HISTORY_KEY = "Debug_CommandHistory"; // Metadata: 0x007BBA2D
	
		// Nested types
		[Serializable]
		private class CommandHistorySerialized // TypeDefIndex: 16254
		{
			// Fields
			public List<string> commandList; // 0x10
	
			// Constructors
			public CommandHistorySerialized(); // 0x000000018065F8D0-0x000000018065F930
		}
	
		// Constructors
		public DebugCommandPanel(); // 0x0000000180665750-0x0000000180665770
	
		// Methods
		protected override void OnEnable(); // 0x0000000180665100-0x00000001806651D0
		public void OnOpen(); // 0x00000001806651D0-0x0000000180665310
		public void OnClose(); // 0x0000000180665010-0x0000000180665030
		protected override void OnDisable(); // 0x0000000180665030-0x0000000180665100
		protected override void LateUpdate(); // 0x0000000180664FD0-0x0000000180665010
		private void Update(); // 0x0000000180665480-0x0000000180665750
		private void GetPreviousCommand(); // 0x0000000180664EC0-0x0000000180664FD0
		private void GetNextCommand(); // 0x0000000180664DE0-0x0000000180664EC0
		public override void BtnClicked_Clear(); // 0x0000000180664D40-0x0000000180664DE0
		public char OnValidateCommand(string text, int charIndex, char addedChar); // 0x0000000180665310-0x0000000180665480
	}
}
