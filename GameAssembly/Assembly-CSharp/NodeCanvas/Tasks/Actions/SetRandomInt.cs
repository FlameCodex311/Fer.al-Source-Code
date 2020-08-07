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
	[Category] // 0x0000000180294B50-0x0000000180294BB0
	[Description] // 0x0000000180294B50-0x0000000180294BB0
	public class SetRandomInt : ActionTask // TypeDefIndex: 15563
	{
		// Fields
		public BBParameter<int> min; // 0x68
		public BBParameter<int> max; // 0x70
		[BlackboardOnly] // 0x00000001801CDAD0-0x00000001801CDAE0
		public BBParameter<int> valueA; // 0x78
		private int _priorInt; // 0x80
	
		// Properties
		protected override string info { get; } // 0x00000001807A7160-0x00000001807A7420 
	
		// Constructors
		public SetRandomInt(); // 0x00000001807A7140-0x00000001807A7160
	
		// Methods
		private int RandomInt(); // 0x00000001807A7090-0x00000001807A7140
		protected override void OnExecute(); // 0x00000001807A7020-0x00000001807A7090
	}
}
