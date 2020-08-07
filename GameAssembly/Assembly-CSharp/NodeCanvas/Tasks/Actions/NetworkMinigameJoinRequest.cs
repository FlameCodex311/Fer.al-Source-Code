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
	[Category] // 0x0000000180284760-0x00000001802847C0
	[Description] // 0x0000000180284760-0x00000001802847C0
	public class NetworkMinigameJoinRequest : ActionTask // TypeDefIndex: 15495
	{
		// Fields
		public string levelDefId; // 0x68
		public bool skipPopUp; // 0x70
		public bool roomJoin; // 0x71
	
		// Properties
		protected override string info { get; } // 0x0000000180BBA750-0x0000000180BBA7A0 
	
		// Constructors
		public NetworkMinigameJoinRequest(); // 0x000000018079E240-0x000000018079E250
	
		// Methods
		protected override void OnExecute(); // 0x0000000180BBA650-0x0000000180BBA750
	}
}
