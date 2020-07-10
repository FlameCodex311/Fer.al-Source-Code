/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace NodeCanvas.Tasks.Actions
{
	[Category] // 0x000000018011AF20-0x000000018011AF80
	[Description] // 0x000000018011AF20-0x000000018011AF80
	public class OpenDialogWindow : ActionTask // TypeDefIndex: 14403
	{
		// Fields
		public EActorDisplayType actorDisplayType; // 0x68
		[ShowIf] // 0x000000018011B130-0x000000018011B160
		public BBParameter<string> npcLocalizedNameDefId; // 0x70
		[ShowIf] // 0x000000018011B130-0x000000018011B160
		public BBParameter<string> npcImageDefId; // 0x78
		[ShowIf] // 0x000000018011B320-0x000000018011B350
		public BBParameter<ActorNPCSpawner> actorNPCSpawner; // 0x80
		private string _localizedNameDefId; // 0x88
		private string _imageDefId; // 0x90
		private const string placholderImg = "178"; // Metadata: 0x0078455B
		private const string thoughtLocID = "1326"; // Metadata: 0x00784562
	
		// Properties
		protected override string info { get; } // 0x0000000181555EF0-0x0000000181555F90 
	
		// Nested types
		public enum EActorDisplayType // TypeDefIndex: 14404
		{
			Custom = 0,
			Parent = 1,
			OtherActor = 2,
			Thought = 3
		}
	
		// Constructors
		public OpenDialogWindow(); // 0x0000000181555E80-0x0000000181555EF0
	
		// Methods
		protected override void OnExecute(); // 0x0000000181555AF0-0x0000000181555D80
		private void GetIDs(ActorNPCSpawner inSpawner); // 0x0000000181555990-0x0000000181555AF0
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private void <OnExecute>b__11_0(UI_Window_Dialog window); // 0x0000000181555D80-0x0000000181555E80
	}
}
