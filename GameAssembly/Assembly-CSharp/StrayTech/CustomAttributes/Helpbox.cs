/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using StrayTech;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace StrayTech.CustomAttributes
{
	public class Helpbox : PropertyAttribute, IValidates // TypeDefIndex: 14597
	{
		// Fields
		public readonly Type MessageType; // 0x18
		public readonly string Message; // 0x20
	
		// Nested types
		public enum Type // TypeDefIndex: 14598
		{
			Info = 0,
			Warning = 1,
			Error = 2
		}
	
		// Constructors
		public Helpbox(string message, Type displayType = Type.Info /* Metadata: 0x007BAD1B */); // 0x0000000180CB5500-0x0000000180CB5540
	
		// Methods
		public bool IsValid(); // 0x0000000180A73A40-0x0000000180A73A60
	}
}
