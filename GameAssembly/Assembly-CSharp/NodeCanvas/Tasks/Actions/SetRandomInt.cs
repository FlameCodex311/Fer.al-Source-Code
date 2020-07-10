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
	[Category] // 0x00000001801290B0-0x0000000180129110
	[Description] // 0x00000001801290B0-0x0000000180129110
	public class SetRandomInt : ActionTask // TypeDefIndex: 14457
	{
		// Fields
		public BBParameter<int> min; // 0x68
		public BBParameter<int> max; // 0x70
		[BlackboardOnly] // 0x00000001800B36B0-0x00000001800B36C0
		public BBParameter<int> valueA; // 0x78
		private int _priorInt; // 0x80
	
		// Properties
		protected override string info { get; } // 0x0000000181262420-0x0000000181262710 
	
		// Constructors
		public SetRandomInt(); // 0x0000000181262400-0x0000000181262420
	
		// Methods
		private int RandomInt(); // 0x0000000181262350-0x0000000181262400
		protected override void OnExecute(); // 0x00000001812622E0-0x0000000181262350
	}
}
