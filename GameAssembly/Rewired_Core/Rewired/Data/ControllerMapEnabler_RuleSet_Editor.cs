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

// Image 51: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5871-7113

namespace Rewired.Data
{
	[Serializable]
	[CustomClassObfuscation] // 0x00000001802111C0-0x0000000180211200
	[Preserve] // 0x00000001802111C0-0x0000000180211200
	public sealed class ControllerMapEnabler_RuleSet_Editor // TypeDefIndex: 6653
	{
		// Fields
		[Serialize] // 0x00000001801CDDD0-0x00000001801CDE00
		[SerializeField] // 0x00000001801CDDD0-0x00000001801CDE00
		private int _id; // 0x10
		[Serialize] // 0x00000001801CDDD0-0x00000001801CDE00
		[SerializeField] // 0x00000001801CDDD0-0x00000001801CDE00
		private string _name; // 0x18
		[Serialize] // 0x00000001801CDDD0-0x00000001801CDE00
		[SerializeField] // 0x00000001801CDDD0-0x00000001801CDE00
		private string _tag; // 0x20
		[Serialize] // 0x00000001801CDDD0-0x00000001801CDE00
		[SerializeField] // 0x00000001801CDDD0-0x00000001801CDE00
		private List<ControllerMapEnabler_Rule_Editor> _rules; // 0x28
	
		// Properties
		public int id { get; set; } // 0x0000000180387590-0x0000000180387930 0x00000001803FEB70-0x00000001803FEB80
		public string name { get; set; } // 0x0000000180372430-0x0000000180372440 0x0000000180379F30-0x0000000180379F40
		public string tag { get; set; } // 0x0000000180374AF0-0x0000000180374B00 0x00000001803F70C0-0x00000001803F70D0
		public List<ControllerMapEnabler_Rule_Editor> rules { get; set; } // 0x00000001803745B0-0x00000001803745C0 0x00000001803FA0C0-0x00000001803FA0D0
	
		// Constructors
		public ControllerMapEnabler_RuleSet_Editor(); // 0x0000000180D7F2A0-0x0000000180D7F300
		public ControllerMapEnabler_RuleSet_Editor(ControllerMapEnabler_RuleSet_Editor source); // 0x0000000180D7F300-0x0000000180D7F410
	
		// Methods
		internal ControllerMapEnabler_RuleSet_Editor Clone(); // 0x0000000180D7EFA0-0x0000000180D7F0D0
		internal ControllerMapEnabler.RuleSet ToRuntime(); // 0x0000000180D7F0D0-0x0000000180D7F2A0
	}
}
