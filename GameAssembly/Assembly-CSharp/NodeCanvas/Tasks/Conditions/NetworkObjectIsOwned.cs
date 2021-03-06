﻿/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace NodeCanvas.Tasks.Conditions
{
	[Category] // 0x00000001802446A0-0x0000000180244700
	[Description] // 0x00000001802446A0-0x0000000180244700
	public class NetworkObjectIsOwned : NetworkConditionTask<NetworkedObjectInfo> // TypeDefIndex: 15287
	{
		// Fields
		public EItemType itemType; // 0x68
	
		// Properties
		protected override string info { get; } // 0x0000000180801C50-0x0000000180801F30 
	
		// Nested types
		public enum EItemType // TypeDefIndex: 15288
		{
			Enigma = 1,
			SocialExpanseLockpick = 2,
			SocialExpanseChest = 3,
			Inspiration = 4
		}
	
		// Constructors
		public NetworkObjectIsOwned(); // 0x0000000180801C10-0x0000000180801C50
	}
}
