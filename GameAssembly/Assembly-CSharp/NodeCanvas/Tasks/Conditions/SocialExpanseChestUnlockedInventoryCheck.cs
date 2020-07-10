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
	[Category] // 0x00000001800E04F0-0x00000001800E0550
	[Description] // 0x00000001800E04F0-0x00000001800E0550
	public class SocialExpanseChestUnlockedInventoryCheck : ConditionTask // TypeDefIndex: 14191
	{
		// Fields
		public string socialExpanseID; // 0x68
		public string chestUUID; // 0x70
	
		// Properties
		protected override string info { get; } // 0x00000001812635C0-0x0000000181263610 
	
		// Constructors
		public SocialExpanseChestUnlockedInventoryCheck(); // 0x000000018124D940-0x000000018124D950
	
		// Methods
		protected override bool OnCheck(); // 0x0000000181263520-0x00000001812635C0
	}
}
