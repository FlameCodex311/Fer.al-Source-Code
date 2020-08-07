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

namespace NodeCanvas.BehaviourTrees
{
	[Category] // 0x0000000180221710-0x0000000180221800
	[Color] // 0x0000000180221710-0x0000000180221800
	[Description] // 0x0000000180221710-0x0000000180221800
	[Icon] // 0x0000000180221710-0x0000000180221800
	[Name] // 0x0000000180221710-0x0000000180221800
	public class OnRoomJoin : BTComposite // TypeDefIndex: 15192
	{
		// Fields
		private Status _status; // 0x88
		private bool _initialized; // 0x8C
	
		// Constructors
		public OnRoomJoin(); // 0x00000001808B1FE0-0x00000001808B2000
	
		// Methods
		private void AddListeners(); // 0x00000001808B2000-0x00000001808B20D0
		private void RemoveListeners(); // 0x00000001808B21D0-0x00000001808B22A0
		protected override Status OnExecute(Component agent, IBlackboard blackboard); // 0x00000001808B20D0-0x00000001808B21D0
		private void Server_OnRoomJoinSuccess(RoomJoinSuccessMessage inMessage); // 0x00000001808B22C0-0x00000001808B22E0
		private void Server_OnRoomJoinFailed(RoomJoinFailedMessage inMessage); // 0x00000001808B22A0-0x00000001808B22C0
	}
}
