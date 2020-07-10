/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace WW.iOS.Xcode.PBX
{
	internal class XCBuildConfigurationData : PBXObjectData // TypeDefIndex: 15816
	{
		// Fields
		protected SortedDictionary<string, BuildConfigEntryData> entries; // 0x20
		public string baseConfigurationReference; // 0x28
	
		// Properties
		public string name { get; } // 0x000000018169E690-0x000000018169E6F0 
	
		// Constructors
		public XCBuildConfigurationData(); // 0x000000018169E610-0x000000018169E690
	
		// Methods
		private static string EscapeWithQuotesIfNeeded(string name, string value); // 0x000000018169D6A0-0x000000018169D780
		public void SetProperty(string name, string value); // 0x000000018169DB10-0x000000018169DBA0
		public void AddProperty(string name, string value); // 0x000000018169D370-0x000000018169D440
		public void RemoveProperty(string name); // 0x000000018169DA90-0x000000018169DB10
		public void RemovePropertyValue(string name, string value); // 0x000000018169D940-0x000000018169DA90
		public void RemovePropertyValueList(string name, IEnumerable<string> valueList); // 0x000000018169D780-0x000000018169D940
		public static XCBuildConfigurationData Create(string name); // 0x000000018169D440-0x000000018169D6A0
		public override void UpdateProps(); // 0x000000018169DBA0-0x000000018169DF60
		public override void UpdateVars(); // 0x000000018169DF60-0x000000018169E610
	}
}
