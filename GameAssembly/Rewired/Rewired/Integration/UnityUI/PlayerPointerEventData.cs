/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Rewired.UI;
using UnityEngine.EventSystems;

// Image 79: Rewired.dll - Assembly: Rewired, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9355-9437

namespace Rewired.Integration.UnityUI
{
	public class PlayerPointerEventData : PointerEventData // TypeDefIndex: 9428
	{
		// Fields
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private int <playerId>k__BackingField; // 0x130
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private int <inputSourceIndex>k__BackingField; // 0x134
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private IMouseInputSource <mouseSource>k__BackingField; // 0x138
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private ITouchInputSource <touchSource>k__BackingField; // 0x140
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private PointerEventType <sourceType>k__BackingField; // 0x148
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private int <buttonIndex>k__BackingField; // 0x14C
	
		// Properties
		public int playerId { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x000000018091EDF0-0x000000018091EE00 0x0000000181060110-0x0000000181060120
		public int inputSourceIndex { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x000000018058C4E0-0x000000018058C4F0 0x0000000181060100-0x0000000181060110
		public IMouseInputSource mouseSource { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x00000001803EF230-0x00000001803EF240 0x0000000180617A90-0x0000000180617AA0
		public ITouchInputSource touchSource { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x00000001803EF170-0x00000001803EF180 0x0000000180617AA0-0x0000000180617AB0
		public PointerEventType sourceType { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x00000001810600E0-0x00000001810600F0 0x0000000181060120-0x0000000181060130
		public int buttonIndex { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x000000018044F710-0x000000018044F720 0x00000001810600F0-0x0000000181060100
	
		// Constructors
		public PlayerPointerEventData(EventSystem eventSystem); // 0x00000001810600B0-0x00000001810600E0
	
		// Methods
		public override string ToString(); // 0x000000018105FEF0-0x00000001810600B0
	}
}
