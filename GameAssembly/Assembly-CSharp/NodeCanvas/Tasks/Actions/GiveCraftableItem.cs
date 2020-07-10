/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace NodeCanvas.Tasks.Actions
{
	[Category] // 0x000000018010EF20-0x000000018010EF80
	[Description] // 0x000000018010EF20-0x000000018010EF80
	public class GiveCraftableItem : ActionTask // TypeDefIndex: 14362
	{
		// Fields
		public BBParameter<string> craftableItemDefId; // 0x68
		public BBParameter<int> amount; // 0x70
	
		// Properties
		protected override string info { get; } // 0x000000018154B110-0x000000018154B340 
	
		// Constructors
		public GiveCraftableItem(); // 0x0000000180E87F80-0x0000000180E87F90
	
		// Methods
		protected override void OnExecute(); // 0x000000018154B080-0x000000018154B110
	}
}
