/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace NodeCanvas.Tasks.Actions
{
	[Category] // 0x000000018028CF70-0x000000018028CFD0
	[Description] // 0x000000018028CF70-0x000000018028CFD0
	public class QuestIconAddRemove : ActionTask // TypeDefIndex: 15533
	{
		// Fields
		public EIconActionType iconActionType; // 0x68
		[ShowIf] // 0x000000018028D2B0-0x000000018028D2E0
		public QuestIcon questIconPrefab; // 0x70
		[ShowIf] // 0x000000018028D2B0-0x000000018028D2E0
		public string imageDefId; // 0x78
	
		// Properties
		protected override string info { get; } // 0x000000018079EFB0-0x000000018079F060 
	
		// Nested types
		public enum EIconActionType // TypeDefIndex: 15534
		{
			Attach = 0,
			Remove = 1
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c__DisplayClass6_0 // TypeDefIndex: 15535
		{
			// Fields
			public QuestIcon icon; // 0x10
	
			// Constructors
			public <>c__DisplayClass6_0(); // 0x0000000180373240-0x0000000180373250
	
			// Methods
			internal void <OnExecute>b__0(Sprite inSprite); // 0x00000001807AC950-0x00000001807AC990
		}
	
		// Constructors
		public QuestIconAddRemove(); // 0x000000018079EF70-0x000000018079EFB0
	
		// Methods
		protected override void OnExecute(); // 0x000000018079EBA0-0x000000018079EE80
		private void RemoveAllIcons(); // 0x000000018079EE80-0x000000018079EF70
	}
}
