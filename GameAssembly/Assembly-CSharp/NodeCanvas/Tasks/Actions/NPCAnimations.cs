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
	[Category] // 0x0000000180284230-0x0000000180284290
	[Description] // 0x0000000180284230-0x0000000180284290
	public class NPCAnimations : ActionTask<ActorNPCSpawner> // TypeDefIndex: 15490
	{
		// Fields
		public EAnimationControlType animationControlType; // 0x68
		[ShowIf] // 0x0000000180284400-0x0000000180284430
		public AnimatorSetter.EActions actionId; // 0x6C
		public BBParameter<bool> disableFaceLocalPlayer; // 0x70
	
		// Properties
		protected override string info { get; } // 0x0000000180BBA140-0x0000000180BBA4B0 
	
		// Nested types
		public enum EAnimationControlType // TypeDefIndex: 15491
		{
			play = 0,
			stop = 1
		}
	
		// Constructors
		public NPCAnimations(); // 0x0000000180BBA100-0x0000000180BBA140
	
		// Methods
		protected override void OnExecute(); // 0x0000000180BB9F90-0x0000000180BBA100
	}
}
