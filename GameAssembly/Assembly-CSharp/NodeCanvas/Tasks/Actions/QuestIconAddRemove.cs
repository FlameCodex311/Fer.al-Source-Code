/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace NodeCanvas.Tasks.Actions
{
	[Category] // 0x000000018011F740-0x000000018011F7A0
	[Description] // 0x000000018011F740-0x000000018011F7A0
	public class QuestIconAddRemove : ActionTask // TypeDefIndex: 14428
	{
		// Fields
		public EIconActionType iconActionType; // 0x68
		[ShowIf] // 0x000000018011F8C0-0x000000018011F8F0
		public QuestIcon questIconPrefab; // 0x70
		[ShowIf] // 0x000000018011F8C0-0x000000018011F8F0
		public string imageDefId; // 0x78
	
		// Properties
		protected override string info { get; } // 0x0000000181559D30-0x0000000181559DE0 
	
		// Nested types
		public enum EIconActionType // TypeDefIndex: 14429
		{
			Attach = 0,
			Remove = 1
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c__DisplayClass6_0 // TypeDefIndex: 14430
		{
			// Fields
			public QuestIcon icon; // 0x10
	
			// Constructors
			public <>c__DisplayClass6_0(); // 0x000000018036B6C0-0x000000018036B6D0
	
			// Methods
			internal void <OnExecute>b__0(Sprite inSprite); // 0x00000001812685B0-0x00000001812685F0
		}
	
		// Constructors
		public QuestIconAddRemove(); // 0x0000000181559CF0-0x0000000181559D30
	
		// Methods
		protected override void OnExecute(); // 0x0000000181559910-0x0000000181559C00
		private void RemoveAllIcons(); // 0x0000000181559C00-0x0000000181559CF0
	}
}
