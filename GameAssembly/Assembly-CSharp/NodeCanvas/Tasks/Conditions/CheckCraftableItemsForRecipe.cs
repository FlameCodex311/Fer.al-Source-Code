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
	[Category] // 0x00000001800DE2A0-0x00000001800DE300
	[Description] // 0x00000001800DE2A0-0x00000001800DE300
	public class CheckCraftableItemsForRecipe : ConditionTask // TypeDefIndex: 14176
	{
		// Fields
		public BBParameter<string> recipeDefId; // 0x68
		private bool _initialized; // 0x70
		private int _craftableItemCount; // 0x74
		private int[] _requiredCounts; // 0x78
		private string[] _defIds; // 0x80
	
		// Properties
		protected override string info { get; } // 0x000000018124FC20-0x000000018124FC70 
	
		// Constructors
		public CheckCraftableItemsForRecipe(); // 0x000000018124FBC0-0x000000018124FC20
	
		// Methods
		protected override bool OnCheck(); // 0x000000018124F880-0x000000018124FBC0
	}
}
