/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace NodeCanvas.Framework.Internal
{
	[Serializable]
	public class BBObjectParameter : BBParameter<object> // TypeDefIndex: 14658
	{
		// Fields
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private Type _type; // 0x48
	
		// Properties
		public override Type varType { get; } // 0x0000000180369C40-0x0000000180369C50 
	
		// Constructors
		public BBObjectParameter(); // 0x0000000181749580-0x0000000181749600
		public BBObjectParameter(Type t); // 0x0000000181749600-0x0000000181749660
	
		// Methods
		public void SetType(Type t); // 0x0000000181749460-0x0000000181749580
	}
}
