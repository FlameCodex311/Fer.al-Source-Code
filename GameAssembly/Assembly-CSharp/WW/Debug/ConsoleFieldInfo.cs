/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace WW.Debug
{
	public class ConsoleFieldInfo // TypeDefIndex: 15704
	{
		// Fields
		private FieldInfo _field; // 0x10
		private PropertyInfo _property; // 0x18
		private string _name; // 0x20
		private string _group; // 0x28
		private object _instance; // 0x30
		private bool _readonly; // 0x38
	
		// Properties
		public string Name { get; } // 0x000000018036AC70-0x000000018036AC80 
		public string Group { get; } // 0x0000000180369B60-0x0000000180369B70 
		public object Instance { get; } // 0x0000000180397720-0x0000000180397730 
		public bool Readonly { get; } // 0x00000001804AEAD0-0x00000001804AEAE0 
		public Type Type { get; } // 0x0000000181119E60-0x0000000181119ED0 
	
		// Constructors
		public ConsoleFieldInfo(FieldInfo inField, object inInstance, string inName, string inGroup, bool inReadonly); // 0x0000000181119D70-0x0000000181119DD0
		public ConsoleFieldInfo(PropertyInfo inProperty, object inInstance, string inName, string inGroup, bool inReadonly); // 0x0000000181119DD0-0x0000000181119E60
	
		// Methods
		public object GetValue(); // 0x0000000181119C70-0x0000000181119CE0
		public void SetValue(object inValue); // 0x0000000181119CE0-0x0000000181119D70
	}
}
