/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using ParadoxNotion.Design;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace NodeCanvas.Framework
{
	[SpoofAOT] // 0x00000001801CDAD0-0x00000001801CDAE0
	public abstract class ExposedParameter // TypeDefIndex: 15672
	{
		// Properties
		public abstract string targetVariableID { get; }
		public abstract Type type { get; }
		public abstract object valueBoxed { get; set; }
		public abstract Variable varRefBoxed { get; }
	
		// Constructors
		protected ExposedParameter(); // 0x0000000180373240-0x0000000180373250
	
		// Methods
		public abstract void Bind(IBlackboard blackboard);
		public abstract void UnBind(IBlackboard blackboard);
		public static ExposedParameter CreateInstance(Variable target); // 0x00000001808A7990-0x00000001808A7B60
	}
}
