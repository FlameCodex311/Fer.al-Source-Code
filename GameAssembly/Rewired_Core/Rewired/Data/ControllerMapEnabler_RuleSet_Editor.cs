/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Rewired;
using Rewired.Utils.Attributes;
using Rewired.Utils.Libraries.TinyJson;
using UnityEngine;

// Image 50: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5712-6954

namespace Rewired.Data
{
	[Serializable]
	[CustomClassObfuscation] // 0x00000001800B3E80-0x00000001800B3EC0
	[Preserve] // 0x00000001800B3E80-0x00000001800B3EC0
	public sealed class ControllerMapEnabler_RuleSet_Editor // TypeDefIndex: 6494
	{
		// Fields
		[Serialize] // 0x00000001800B4050-0x00000001800B4080
		[SerializeField] // 0x00000001800B4050-0x00000001800B4080
		private int _id; // 0x10
		[Serialize] // 0x00000001800B4050-0x00000001800B4080
		[SerializeField] // 0x00000001800B4050-0x00000001800B4080
		private string _name; // 0x18
		[Serialize] // 0x00000001800B4050-0x00000001800B4080
		[SerializeField] // 0x00000001800B4050-0x00000001800B4080
		private string _tag; // 0x20
		[Serialize] // 0x00000001800B4050-0x00000001800B4080
		[SerializeField] // 0x00000001800B4050-0x00000001800B4080
		private List<ControllerMapEnabler_Rule_Editor> _rules; // 0x28
	
		// Properties
		public int id { get; set; } // 0x000000018036CFF0-0x000000018036D000 0x000000018037AA40-0x000000018037AA50
		public string name { get; set; } // 0x000000018038B150-0x000000018038B160 0x000000018038B160-0x000000018038B170
		public string tag { get; set; } // 0x000000018036AC70-0x000000018036AC80 0x000000018036AC90-0x000000018036ACA0
		public List<ControllerMapEnabler_Rule_Editor> rules { get; set; } // 0x0000000180369B60-0x0000000180369B70 0x0000000180422D30-0x0000000180422D40
	
		// Constructors
		public ControllerMapEnabler_RuleSet_Editor(); // 0x00000001805E0240-0x00000001805E02A0
		public ControllerMapEnabler_RuleSet_Editor(ControllerMapEnabler_RuleSet_Editor source); // 0x00000001805E02A0-0x00000001805E03B0
	
		// Methods
		internal ControllerMapEnabler_RuleSet_Editor Clone(); // 0x00000001805DFF40-0x00000001805E0070
		internal ControllerMapEnabler.RuleSet ToRuntime(); // 0x00000001805E0070-0x00000001805E0240
	}
}
