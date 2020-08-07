/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace WW.Debug
{
	public class ConsoleFieldInfo // TypeDefIndex: 16256
	{
		// Fields
		private FieldInfo _field; // 0x10
		private PropertyInfo _property; // 0x18
		private string _name; // 0x20
		private string _group; // 0x28
		private object _instance; // 0x30
		private bool _readonly; // 0x38
	
		// Properties
		public string Name { get; } // 0x0000000180374AF0-0x0000000180374B00 
		public string Group { get; } // 0x00000001803745B0-0x00000001803745C0 
		public object Instance { get; } // 0x00000001803745C0-0x00000001803745D0 
		public bool Readonly { get; } // 0x0000000180379B20-0x0000000180379B30 
		public Type Type { get; } // 0x000000018065FB60-0x000000018065FBD0 
	
		// Constructors
		public ConsoleFieldInfo(FieldInfo inField, object inInstance, string inName, string inGroup, bool inReadonly); // 0x000000018065FA70-0x000000018065FAD0
		public ConsoleFieldInfo(PropertyInfo inProperty, object inInstance, string inName, string inGroup, bool inReadonly); // 0x000000018065FAD0-0x000000018065FB60
	
		// Methods
		public object GetValue(); // 0x000000018065F970-0x000000018065F9E0
		public void SetValue(object inValue); // 0x000000018065F9E0-0x000000018065FA70
	}
}
