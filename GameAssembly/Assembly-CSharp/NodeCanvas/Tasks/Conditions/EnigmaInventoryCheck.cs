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
	[Category] // 0x00000001800DFF00-0x00000001800DFF60
	[Description] // 0x00000001800DFF00-0x00000001800DFF60
	public class EnigmaInventoryCheck : ConditionTask // TypeDefIndex: 14186
	{
		// Fields
		public EEnigmaStatus enigmaStatus; // 0x68
		public string enigmaName; // 0x70
		public string enigmaID; // 0x78
	
		// Properties
		protected override string info { get; } // 0x0000000181256B50-0x0000000181256C00 
	
		// Nested types
		public enum EEnigmaStatus // TypeDefIndex: 14187
		{
			Owned = 0,
			Active = 1,
			Complete = 2
		}
	
		// Constructors
		public EnigmaInventoryCheck(); // 0x000000018124D940-0x000000018124D950
	
		// Methods
		protected override bool OnCheck(); // 0x0000000181256AB0-0x0000000181256B50
	}
}
