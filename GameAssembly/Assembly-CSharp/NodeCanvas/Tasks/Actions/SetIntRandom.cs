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
	[Category] // 0x0000000180253530-0x00000001802535B0
	[Description] // 0x0000000180253530-0x00000001802535B0
	[Name] // 0x0000000180253530-0x00000001802535B0
	public class SetIntRandom : ActionTask // TypeDefIndex: 15343
	{
		// Fields
		public BBParameter<int> minValue; // 0x68
		public BBParameter<int> maxValue; // 0x70
		[BlackboardOnly] // 0x00000001801CDAD0-0x00000001801CDAE0
		public BBParameter<int> intVariable; // 0x78
	
		// Properties
		protected override string info { get; } // 0x00000001807A5CB0-0x00000001807A5F70 
	
		// Constructors
		public SetIntRandom(); // 0x000000018079E240-0x000000018079E250
	
		// Methods
		protected override void OnExecute(); // 0x00000001807A5C00-0x00000001807A5CB0
	}
}
