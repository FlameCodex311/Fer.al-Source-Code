/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Rewired.UI;
using UnityEngine.EventSystems;

// Image 78: Rewired.dll - Assembly: Rewired, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9189-9271

namespace Rewired.Integration.UnityUI
{
	public class PlayerPointerEventData : PointerEventData // TypeDefIndex: 9262
	{
		// Fields
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private int <playerId>k__BackingField; // 0x130
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private int <inputSourceIndex>k__BackingField; // 0x134
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private IMouseInputSource <mouseSource>k__BackingField; // 0x138
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private ITouchInputSource <touchSource>k__BackingField; // 0x140
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private PointerEventType <sourceType>k__BackingField; // 0x148
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private int <buttonIndex>k__BackingField; // 0x14C
	
		// Properties
		public int playerId { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x00000001810E21D0-0x00000001810E21E0 0x0000000181BC0AF0-0x0000000181BC0B00
		public int inputSourceIndex { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x0000000181BC0AD0-0x0000000181BC0AE0 0x0000000181BC0AE0-0x0000000181BC0AF0
		public IMouseInputSource mouseSource { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x00000001803BD3B0-0x00000001803BD3C0 0x00000001803BE5D0-0x00000001803BE5E0
		public ITouchInputSource touchSource { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x00000001803BD3E0-0x00000001803BD3F0 0x00000001803BE600-0x00000001803BE610
		public PointerEventType sourceType { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x0000000180A98E90-0x0000000180A98EA0 0x0000000181BC0B00-0x0000000181BC0B10
		public int buttonIndex { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x0000000180F83870-0x0000000180F83880 0x000000018123FBD0-0x000000018123FBE0
	
		// Constructors
		public PlayerPointerEventData(EventSystem eventSystem); // 0x0000000181BC0AA0-0x0000000181BC0AD0
	
		// Methods
		public override string ToString(); // 0x0000000181BC08E0-0x0000000181BC0AA0
	}
}
