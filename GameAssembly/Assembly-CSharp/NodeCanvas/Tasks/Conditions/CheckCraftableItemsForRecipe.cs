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
	[Category] // 0x0000000180241DF0-0x0000000180241E50
	[Description] // 0x0000000180241DF0-0x0000000180241E50
	public class CheckCraftableItemsForRecipe : ConditionTask // TypeDefIndex: 15279
	{
		// Fields
		public BBParameter<string> recipeDefId; // 0x68
		private bool _initialized; // 0x70
		private int _craftableItemCount; // 0x74
		private int[] _requiredCounts; // 0x78
		private string[] _defIds; // 0x80
	
		// Properties
		protected override string info { get; } // 0x0000000180798B90-0x0000000180798BE0 
	
		// Constructors
		public CheckCraftableItemsForRecipe(); // 0x0000000180798B30-0x0000000180798B90
	
		// Methods
		protected override bool OnCheck(); // 0x0000000180798810-0x0000000180798B30
	}
}
