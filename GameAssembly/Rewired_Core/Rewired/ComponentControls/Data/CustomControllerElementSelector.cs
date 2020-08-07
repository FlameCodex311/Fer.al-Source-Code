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
using UnityEngine;

// Image 51: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5871-7113

namespace Rewired.ComponentControls.Data
{
	[Serializable]
	[CustomClassObfuscation] // 0x00000001801DDE50-0x00000001801DDE80
	public sealed class CustomControllerElementSelector // TypeDefIndex: 5967
	{
		// Fields
		[CustomObfuscation] // 0x00000001801E0A20-0x00000001801E0A80
		[SerializeField] // 0x00000001801E0A20-0x00000001801E0A80
		[Tooltip] // 0x00000001801E0A20-0x00000001801E0A80
		private ElementType _elementType; // 0x10
		[CustomObfuscation] // 0x00000001801E0F10-0x00000001801E0F70
		[SerializeField] // 0x00000001801E0F10-0x00000001801E0F70
		[Tooltip] // 0x00000001801E0F10-0x00000001801E0F70
		private SelectorType _selectorType; // 0x14
		[CustomObfuscation] // 0x00000001801E1250-0x00000001801E12B0
		[SerializeField] // 0x00000001801E1250-0x00000001801E12B0
		[Tooltip] // 0x00000001801E1250-0x00000001801E12B0
		private string _elementName; // 0x18
		[CustomObfuscation] // 0x00000001801E2820-0x00000001801E28A0
		[FieldRange] // 0x00000001801E2820-0x00000001801E28A0
		[SerializeField] // 0x00000001801E2820-0x00000001801E28A0
		[Tooltip] // 0x00000001801E2820-0x00000001801E28A0
		private int _elementIndex; // 0x20
		[CustomObfuscation] // 0x00000001801E2B90-0x00000001801E2C10
		[FieldRange] // 0x00000001801E2B90-0x00000001801E2C10
		[SerializeField] // 0x00000001801E2B90-0x00000001801E2C10
		[Tooltip] // 0x00000001801E2B90-0x00000001801E2C10
		private int _elementId; // 0x24
		[HideInInspector] // 0x00000001801CDAD0-0x00000001801CDAE0
		private int IiqJkCxIiWfCtapWlzauQkrlOjpo; // 0x28
		[HideInInspector] // 0x00000001801CDAD0-0x00000001801CDAE0
		private int AmbMBiIfojcLTIXgvVqpPfJzIDqU; // 0x2C
	
		// Properties
		public ElementType elementType { get; set; } // 0x0000000180387590-0x0000000180387930 0x0000000180913650-0x0000000180913670
		public SelectorType selectorType { get; set; } // 0x00000001803FD2F0-0x00000001803FD300 0x0000000180913670-0x00000001809136B0
		public string elementName { get; set; } // 0x0000000180372430-0x0000000180372440 0x0000000180913610-0x0000000180913650
		public int elementIndex { get; set; } // 0x00000001803FB670-0x00000001803FB680 0x00000001809135D0-0x0000000180913610
		public int elementId { get; set; } // 0x0000000180491DB0-0x0000000180491DC0 0x00000001809135B0-0x00000001809135D0
		public bool isAssigned { get; } // 0x0000000180913510-0x00000001809135B0 
	
		// Nested types
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		public enum ElementType // TypeDefIndex: 5968
		{
			Axis = 0,
			Button = 1
		}
	
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		public enum SelectorType // TypeDefIndex: 5969
		{
			Name = 0,
			Index = 1,
			Id = 2
		}
	
		// Constructors
		public CustomControllerElementSelector(); // 0x00000001809134F0-0x0000000180913510
	
		// Methods
		public int GetElementIndex(CustomController customController); // 0x0000000180912E50-0x0000000180913390
		public string GetSelectorFormattedString(); // 0x0000000180913390-0x0000000180913450
		private IList<ControllerElementIdentifier> ZMiPycAGpOQhySHUZaTcPLozIgK(CustomController param_0000c928, ElementType param_0000c929); // 0x0000000180913450-0x00000001809134F0
		public void ClearCache(); // 0x0000000180912E40-0x0000000180912E50
	}
}
