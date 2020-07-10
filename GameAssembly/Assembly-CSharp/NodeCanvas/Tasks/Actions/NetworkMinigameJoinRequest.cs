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
	[Category] // 0x0000000180119660-0x00000001801196C0
	[Description] // 0x0000000180119660-0x00000001801196C0
	public class NetworkMinigameJoinRequest : ActionTask // TypeDefIndex: 14390
	{
		// Fields
		public string levelDefId; // 0x68
		public bool skipPopUp; // 0x70
		public bool roomJoin; // 0x71
	
		// Properties
		protected override string info { get; } // 0x00000001815541E0-0x0000000181554230 
	
		// Constructors
		public NetworkMinigameJoinRequest(); // 0x0000000180E87F80-0x0000000180E87F90
	
		// Methods
		protected override void OnExecute(); // 0x00000001815540E0-0x00000001815541E0
	}
}
