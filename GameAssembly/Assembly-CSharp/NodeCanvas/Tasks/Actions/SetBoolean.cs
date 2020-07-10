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
	[Category] // 0x00000001800ED9E0-0x00000001800EDA40
	[Description] // 0x00000001800ED9E0-0x00000001800EDA40
	public class SetBoolean : ActionTask // TypeDefIndex: 14236
	{
		// Fields
		[BlackboardOnly] // 0x00000001800B4050-0x00000001800B4080
		[RequiredField] // 0x00000001800B4050-0x00000001800B4080
		public BBParameter<bool> boolVariable; // 0x68
		public BoolSetModes setTo; // 0x70
	
		// Properties
		protected override string info { get; } // 0x000000018125E5A0-0x000000018125E6C0 
	
		// Nested types
		public enum BoolSetModes // TypeDefIndex: 14237
		{
			False = 0,
			True = 1,
			Toggle = 2
		}
	
		// Constructors
		public SetBoolean(); // 0x0000000180E995D0-0x0000000180E995E0
	
		// Methods
		protected override void OnExecute(); // 0x000000018125E500-0x000000018125E5A0
	}
}
