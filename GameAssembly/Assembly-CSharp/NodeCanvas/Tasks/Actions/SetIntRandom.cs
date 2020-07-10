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
	[Category] // 0x00000001800EF050-0x00000001800EF0D0
	[Description] // 0x00000001800EF050-0x00000001800EF0D0
	[Name] // 0x00000001800EF050-0x00000001800EF0D0
	public class SetIntRandom : ActionTask // TypeDefIndex: 14243
	{
		// Fields
		public BBParameter<int> minValue; // 0x68
		public BBParameter<int> maxValue; // 0x70
		[BlackboardOnly] // 0x00000001800B36B0-0x00000001800B36C0
		public BBParameter<int> intVariable; // 0x78
	
		// Properties
		protected override string info { get; } // 0x0000000181260F40-0x0000000181261230 
	
		// Constructors
		public SetIntRandom(); // 0x0000000180E87F80-0x0000000180E87F90
	
		// Methods
		protected override void OnExecute(); // 0x0000000181260E90-0x0000000181260F40
	}
}
