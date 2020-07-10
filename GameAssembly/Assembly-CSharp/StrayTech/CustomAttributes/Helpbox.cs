/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using StrayTech;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace StrayTech.CustomAttributes
{
	public class Helpbox : PropertyAttribute, IValidates // TypeDefIndex: 13929
	{
		// Fields
		public readonly Type MessageType; // 0x18
		public readonly string Message; // 0x20
	
		// Nested types
		public enum Type // TypeDefIndex: 13930
		{
			Info = 0,
			Warning = 1,
			Error = 2
		}
	
		// Constructors
		public Helpbox(string message, Type displayType = Type.Info /* Metadata: 0x00784258 */); // 0x0000000181354B30-0x0000000181354B70
	
		// Methods
		public bool IsValid(); // 0x0000000181354B10-0x0000000181354B30
	}
}
