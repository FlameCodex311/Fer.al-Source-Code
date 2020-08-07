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
	[Category] // 0x00000001802424B0-0x0000000180242510
	[Description] // 0x00000001802424B0-0x0000000180242510
	public class CheckOwnedRecipe : ConditionTask // TypeDefIndex: 15281
	{
		// Fields
		public BBParameter<string> recipeDefId; // 0x68
	
		// Properties
		protected override string info { get; } // 0x00000001807F46E0-0x00000001807F4730 
	
		// Constructors
		public CheckOwnedRecipe(); // 0x0000000180792480-0x0000000180792490
	
		// Methods
		protected override bool OnCheck(); // 0x00000001807F4670-0x00000001807F46E0
	}
}
