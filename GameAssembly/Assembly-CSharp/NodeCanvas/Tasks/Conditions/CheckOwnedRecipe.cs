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
	[Category] // 0x00000001800DEA00-0x00000001800DEA60
	[Description] // 0x00000001800DEA00-0x00000001800DEA60
	public class CheckOwnedRecipe : ConditionTask // TypeDefIndex: 14178
	{
		// Fields
		public BBParameter<string> recipeDefId; // 0x68
	
		// Properties
		protected override string info { get; } // 0x0000000181254080-0x00000001812540D0 
	
		// Constructors
		public CheckOwnedRecipe(); // 0x000000018124D940-0x000000018124D950
	
		// Methods
		protected override bool OnCheck(); // 0x0000000181254000-0x0000000181254080
	}
}
