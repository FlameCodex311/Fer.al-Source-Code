/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using ParadoxNotion;
using ParadoxNotion.Design;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace NodeCanvas.Tasks.Actions
{
	[Category] // 0x00000001800EEC20-0x00000001800EECA0
	[Description] // 0x00000001800EEC20-0x00000001800EECA0
	[Name] // 0x00000001800EEC20-0x00000001800EECA0
	public class SetInt : ActionTask // TypeDefIndex: 14242
	{
		// Fields
		[BlackboardOnly] // 0x00000001800B36B0-0x00000001800B36C0
		public BBParameter<int> valueA; // 0x68
		public OperationMethod Operation; // 0x70
		public BBParameter<int> valueB; // 0x78
	
		// Properties
		protected override string info { get; } // 0x00000001812612F0-0x0000000181261330 
	
		// Constructors
		public SetInt(); // 0x0000000180E87F80-0x0000000180E87F90
	
		// Methods
		protected override void OnExecute(); // 0x0000000181261230-0x00000001812612F0
	}
}
