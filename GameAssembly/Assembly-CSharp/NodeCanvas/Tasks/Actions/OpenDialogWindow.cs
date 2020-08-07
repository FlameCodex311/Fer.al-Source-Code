/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace NodeCanvas.Tasks.Actions
{
	[Category] // 0x00000001802870F0-0x0000000180287150
	[Description] // 0x00000001802870F0-0x0000000180287150
	public class OpenDialogWindow : ActionTask // TypeDefIndex: 15508
	{
		// Fields
		public EActorDisplayType actorDisplayType; // 0x68
		[ShowIf] // 0x00000001802873B0-0x00000001802873E0
		public BBParameter<string> npcLocalizedNameDefId; // 0x70
		[ShowIf] // 0x00000001802873B0-0x00000001802873E0
		public BBParameter<string> npcImageDefId; // 0x78
		[ShowIf] // 0x0000000180288930-0x0000000180288960
		public BBParameter<ActorNPCSpawner> actorNPCSpawner; // 0x80
		private string _localizedNameDefId; // 0x88
		private string _imageDefId; // 0x90
		private const string placholderImg = "178"; // Metadata: 0x007BB33D
		private const string thoughtLocID = "1326"; // Metadata: 0x007BB344
	
		// Properties
		protected override string info { get; } // 0x0000000180BBC3B0-0x0000000180BBC440 
	
		// Nested types
		public enum EActorDisplayType // TypeDefIndex: 15509
		{
			Custom = 0,
			Parent = 1,
			OtherActor = 2,
			Thought = 3
		}
	
		// Constructors
		public OpenDialogWindow(); // 0x0000000180BBC340-0x0000000180BBC3B0
	
		// Methods
		protected override void OnExecute(); // 0x0000000180BBBFC0-0x0000000180BBC240
		private void GetIDs(ActorNPCSpawner inSpawner); // 0x0000000180BBBE60-0x0000000180BBBFC0
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void <OnExecute>b__11_0(UI_Window_Dialog window); // 0x0000000180BBC240-0x0000000180BBC340
	}
}
