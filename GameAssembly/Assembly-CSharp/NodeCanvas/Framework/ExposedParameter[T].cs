/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace NodeCanvas.Framework
{
	public sealed class ExposedParameter<T> : ExposedParameter // TypeDefIndex: 15673
	{
		// Fields
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private string _targetVariableID;
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private T _value;
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private Variable<T> <varRef>k__BackingField;
	
		// Properties
		public Variable<T> varRef { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; }
		public override string targetVariableID { get; }
		public override Type type { get; }
		public override object valueBoxed { get; set; }
		public override Variable varRefBoxed { get; }
		public T value { get; set; }
	
		// Constructors
		public ExposedParameter();
		public ExposedParameter(Variable target);
	
		// Methods
		public override void Bind(IBlackboard blackboard);
		public override void UnBind(IBlackboard blackboard);
		private T GetRawValue();
		private void SetRawValue(T value);
	}
}
