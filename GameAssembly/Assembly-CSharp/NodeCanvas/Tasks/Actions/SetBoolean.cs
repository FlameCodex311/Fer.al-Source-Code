/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace NodeCanvas.Tasks.Actions
{
	[Category] // 0x00000001802514E0-0x0000000180251540
	[Description] // 0x00000001802514E0-0x0000000180251540
	public class SetBoolean : ActionTask // TypeDefIndex: 15336
	{
		// Fields
		[BlackboardOnly] // 0x00000001801CDDD0-0x00000001801CDE00
		[RequiredField] // 0x00000001801CDDD0-0x00000001801CDE00
		public BBParameter<bool> boolVariable; // 0x68
		public BoolSetModes setTo; // 0x70
	
		// Properties
		protected override string info { get; } // 0x00000001807A30D0-0x00000001807A31F0 
	
		// Nested types
		public enum BoolSetModes // TypeDefIndex: 15337
		{
			False = 0,
			True = 1,
			Toggle = 2
		}
	
		// Constructors
		public SetBoolean(); // 0x00000001807A30C0-0x00000001807A30D0
	
		// Methods
		protected override void OnExecute(); // 0x00000001807A3020-0x00000001807A30C0
	}
}
