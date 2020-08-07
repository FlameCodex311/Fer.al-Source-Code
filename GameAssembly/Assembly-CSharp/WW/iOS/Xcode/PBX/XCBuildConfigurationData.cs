/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace WW.iOS.Xcode.PBX
{
	internal class XCBuildConfigurationData : PBXObjectData // TypeDefIndex: 16196
	{
		// Fields
		protected SortedDictionary<string, BuildConfigEntryData> entries; // 0x20
		public string baseConfigurationReference; // 0x28
	
		// Properties
		public string name { get; } // 0x00000001814D2040-0x00000001814D20A0 
	
		// Constructors
		public XCBuildConfigurationData(); // 0x00000001814D1F80-0x00000001814D2040
	
		// Methods
		private static string EscapeWithQuotesIfNeeded(string name, string value); // 0x00000001814D1300-0x00000001814D13D0
		public void SetProperty(string name, string value); // 0x00000001814D15A0-0x00000001814D1630
		public void AddProperty(string name, string value); // 0x00000001814D1090-0x00000001814D1160
		public void RemoveProperty(string name); // 0x00000001814D1520-0x00000001814D15A0
		public void RemovePropertyValue(string name, string value); // 0x00000001814D1470-0x00000001814D1520
		public void RemovePropertyValueList(string name, IEnumerable<string> valueList); // 0x00000001814D13D0-0x00000001814D1470
		public static XCBuildConfigurationData Create(string name); // 0x00000001814D1160-0x00000001814D1300
		public override void UpdateProps(); // 0x00000001814D1630-0x00000001814D1990
		public override void UpdateVars(); // 0x00000001814D1990-0x00000001814D1F80
	}
}
