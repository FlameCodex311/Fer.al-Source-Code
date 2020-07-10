/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace NodeCanvas.Tasks.Conditions
{
	[Category] // 0x00000001800DFD00-0x00000001800DFD60
	[Description] // 0x00000001800DFD00-0x00000001800DFD60
	public class NetworkObjectIsOwned : NetworkConditionTask<NetworkedObjectInfo> // TypeDefIndex: 14184
	{
		// Fields
		public EItemType itemType; // 0x68
	
		// Properties
		protected override string info { get; } // 0x0000000181259670-0x0000000181259970 
	
		// Nested types
		public enum EItemType // TypeDefIndex: 14185
		{
			Enigma = 1,
			SocialExpanseLockpick = 2,
			SocialExpanseChest = 3,
			Inspiration = 4
		}
	
		// Constructors
		public NetworkObjectIsOwned(); // 0x0000000181259630-0x0000000181259670
	}
}
