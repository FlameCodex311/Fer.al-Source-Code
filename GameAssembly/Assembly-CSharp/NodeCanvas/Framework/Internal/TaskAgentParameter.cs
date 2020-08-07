/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using ParadoxNotion.Serialization.FullSerializer;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace NodeCanvas.Framework.Internal
{
	[Serializable]
	[fsAutoInstance] // 0x00000001801CDF50-0x00000001801CDF70
	public sealed class TaskAgentParameter : BBParameter<UnityEngine.Object> // TypeDefIndex: 15782
	{
		// Fields
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private Type _type; // 0x50
	
		// Properties
		public override Type varType { get; } // 0x0000000180CCF320-0x0000000180CCF390 
		public new UnityEngine.Object value { get; set; } // 0x0000000180CCF230-0x0000000180CCF320 0x00000001803FEB60-0x00000001803FEB70
	
		// Constructors
		public TaskAgentParameter(); // 0x0000000180CCF1F0-0x0000000180CCF230
	
		// Methods
		public override object GetValueBoxed(); // 0x0000000180CCF0C0-0x0000000180CCF0D0
		public override void SetValueBoxed(object newValue); // 0x0000000180CCF170-0x0000000180CCF1F0
		public void SetType(Type newType); // 0x0000000180CCF0D0-0x0000000180CCF170
	}
}
