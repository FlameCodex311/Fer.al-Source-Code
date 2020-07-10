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
using Rewired.Utils.Interfaces;
using Rewired.Utils.Libraries.TinyJson;
using UnityEngine;

// Image 50: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5712-6954

namespace Rewired.Data
{
	[Serializable]
	[CustomClassObfuscation] // 0x00000001800B3E80-0x00000001800B3EC0
	[Preserve] // 0x00000001800B3E80-0x00000001800B3EC0
	public sealed class ControllerMapLayoutManager_Rule_Editor : IDeepCloneable // TypeDefIndex: 6501
	{
		// Fields
		[Serialize] // 0x00000001800B4050-0x00000001800B4080
		[SerializeField] // 0x00000001800B4050-0x00000001800B4080
		private string _tag; // 0x10
		[Serialize] // 0x00000001800B4050-0x00000001800B4080
		[SerializeField] // 0x00000001800B4050-0x00000001800B4080
		private List<int> _categoryIds; // 0x18
		[Serialize] // 0x00000001800B4050-0x00000001800B4080
		[SerializeField] // 0x00000001800B4050-0x00000001800B4080
		private int _layoutId; // 0x20
		[Serialize] // 0x00000001800B4050-0x00000001800B4080
		[SerializeField] // 0x00000001800B4050-0x00000001800B4080
		private ControllerSetSelector_Editor _controllerSetSelector; // 0x28
	
		// Properties
		public string tag { get; set; } // 0x000000018036AC80-0x000000018036AC90 0x000000018036B1E0-0x000000018036B1F0
		public List<int> categoryIds { get; set; } // 0x000000018038B150-0x000000018038B160 0x000000018038B160-0x000000018038B170
		public int layoutId { get; set; } // 0x00000001803C2700-0x00000001803C2710 0x00000001804886F0-0x0000000180488700
		public ControllerSetSelector_Editor controllerSetSelector { get; set; } // 0x0000000180369B60-0x0000000180369B70 0x0000000180422D30-0x0000000180422D40
	
		// Constructors
		public ControllerMapLayoutManager_Rule_Editor(); // 0x00000001805E0EC0-0x00000001805E0F50
		public ControllerMapLayoutManager_Rule_Editor(ControllerMapLayoutManager_Rule_Editor source); // 0x00000001805E0DF0-0x00000001805E0EC0
	
		// Methods
		internal ControllerMapLayoutManager.Rule ToRuntime(); // 0x00000001805E0D20-0x00000001805E0DF0
		object IDeepCloneable.DeepClone(); // 0x00000001805E0C20-0x00000001805E0D20
	}
}
