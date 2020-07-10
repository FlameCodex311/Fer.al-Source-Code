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
	[Category] // 0x0000000180110460-0x00000001801104C0
	[Description] // 0x0000000180110460-0x00000001801104C0
	public class Lobby_LC : ActionTask // TypeDefIndex: 14366
	{
		// Fields
		[RequiredField] // 0x00000001800B36B0-0x00000001800B36C0
		public LobbyManager.ELobbyType lobbyType; // 0x68
		[Tooltip] // 0x0000000180110AD0-0x0000000180110B00
		public string associatedDefId; // 0x70
	
		// Properties
		protected override string info { get; } // 0x000000018154E4B0-0x000000018154E4E0 
	
		// Constructors
		public Lobby_LC(); // 0x0000000180E87F80-0x0000000180E87F90
	
		// Methods
		protected override void OnExecute(); // 0x000000018154E410-0x000000018154E4B0
	}
}
