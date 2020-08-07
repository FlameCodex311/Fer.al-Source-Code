/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace NodeCanvas.Framework.Internal
{
	[Serializable]
	public class BBObjectParameter : BBParameter<object>, ISerializationCallbackReceiver // TypeDefIndex: 15784
	{
		// Fields
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private string _type; // 0x50
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private Type <type>k__BackingField; // 0x58
	
		// Properties
		private Type type { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x00000001803A1580-0x00000001803A1590 0x00000001803A1740-0x00000001803A1750
		public override Type varType { get; } // 0x0000000180CBF2C0-0x0000000180CBF370 
	
		// Constructors
		public BBObjectParameter(); // 0x0000000180CBF1E0-0x0000000180CBF260
		public BBObjectParameter(Type t); // 0x0000000180CBF260-0x0000000180CBF2C0
		public BBObjectParameter(BBParameter source); // 0x0000000180CBF150-0x0000000180CBF1E0
	
		// Methods
		new void ISerializationCallbackReceiver.OnBeforeSerialize(); // 0x0000000180CBF0C0-0x0000000180CBF150
		new void ISerializationCallbackReceiver.OnAfterDeserialize(); // 0x0000000180CBF050-0x0000000180CBF0C0
		public void SetType(Type t); // 0x0000000180CBEF00-0x0000000180CBF050
	}
}
