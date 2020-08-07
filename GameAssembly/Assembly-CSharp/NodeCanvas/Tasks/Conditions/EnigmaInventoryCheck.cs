/*
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
	[Category] // 0x0000000180244880-0x00000001802448E0
	[Description] // 0x0000000180244880-0x00000001802448E0
	public class EnigmaInventoryCheck : ConditionTask // TypeDefIndex: 15289
	{
		// Fields
		public EEnigmaStatus enigmaStatus; // 0x68
		public string enigmaName; // 0x70
		public string enigmaID; // 0x78
	
		// Properties
		protected override string info { get; } // 0x00000001807FDAB0-0x00000001807FDB60 
	
		// Nested types
		public enum EEnigmaStatus // TypeDefIndex: 15290
		{
			Owned = 0,
			Active = 1,
			Complete = 2
		}
	
		// Constructors
		public EnigmaInventoryCheck(); // 0x0000000180792480-0x0000000180792490
	
		// Methods
		protected override bool OnCheck(); // 0x00000001807FDA10-0x00000001807FDAB0
	}
}
