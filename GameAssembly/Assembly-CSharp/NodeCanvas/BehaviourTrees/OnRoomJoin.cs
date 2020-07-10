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

namespace NodeCanvas.BehaviourTrees
{
	[Category] // 0x0000000180173E90-0x0000000180173F80
	[Color] // 0x0000000180173E90-0x0000000180173F80
	[Description] // 0x0000000180173E90-0x0000000180173F80
	[Icon] // 0x0000000180173E90-0x0000000180173F80
	[Name] // 0x0000000180173E90-0x0000000180173F80
	public class OnRoomJoin : BTComposite // TypeDefIndex: 14072
	{
		// Fields
		private Status _status; // 0x78
		private bool _initialized; // 0x7C
	
		// Constructors
		public OnRoomJoin(); // 0x0000000181570000-0x0000000181570010
	
		// Methods
		private void AddListeners(); // 0x0000000181570010-0x00000001815700E0
		private void RemoveListeners(); // 0x00000001815701D0-0x00000001815702A0
		protected override Status OnExecute(Component agent, IBlackboard blackboard); // 0x00000001815700E0-0x00000001815701D0
		private void Server_OnRoomJoinSuccess(RoomJoinSuccessMessage inMessage); // 0x00000001815702C0-0x00000001815702E0
		private void Server_OnRoomJoinFailed(RoomJoinFailedMessage inMessage); // 0x00000001815702A0-0x00000001815702C0
	}
}
