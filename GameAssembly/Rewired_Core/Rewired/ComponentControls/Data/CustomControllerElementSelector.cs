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

// Image 50: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5712-6954

namespace Rewired.ComponentControls.Data
{
	[Serializable]
	[CustomClassObfuscation] // 0x00000001800C10A0-0x00000001800C10D0
	public sealed class CustomControllerElementSelector // TypeDefIndex: 5808
	{
		// Fields
		[CustomObfuscation] // 0x0000000180145C70-0x0000000180145CD0
		[SerializeField] // 0x0000000180145C70-0x0000000180145CD0
		[Tooltip] // 0x0000000180145C70-0x0000000180145CD0
		private ElementType _elementType; // 0x10
		[CustomObfuscation] // 0x0000000180145F30-0x0000000180145F90
		[SerializeField] // 0x0000000180145F30-0x0000000180145F90
		[Tooltip] // 0x0000000180145F30-0x0000000180145F90
		private SelectorType _selectorType; // 0x14
		[CustomObfuscation] // 0x0000000180146280-0x00000001801462E0
		[SerializeField] // 0x0000000180146280-0x00000001801462E0
		[Tooltip] // 0x0000000180146280-0x00000001801462E0
		private string _elementName; // 0x18
		[CustomObfuscation] // 0x00000001801465C0-0x0000000180146640
		[FieldRange] // 0x00000001801465C0-0x0000000180146640
		[SerializeField] // 0x00000001801465C0-0x0000000180146640
		[Tooltip] // 0x00000001801465C0-0x0000000180146640
		private int _elementIndex; // 0x20
		[CustomObfuscation] // 0x0000000180146880-0x0000000180146900
		[FieldRange] // 0x0000000180146880-0x0000000180146900
		[SerializeField] // 0x0000000180146880-0x0000000180146900
		[Tooltip] // 0x0000000180146880-0x0000000180146900
		private int _elementId; // 0x24
		[HideInInspector] // 0x00000001800B36B0-0x00000001800B36C0
		private int IiqJkCxIiWfCtapWlzauQkrlOjpo; // 0x28
		[HideInInspector] // 0x00000001800B36B0-0x00000001800B36C0
		private int AmbMBiIfojcLTIXgvVqpPfJzIDqU; // 0x2C
	
		// Properties
		public ElementType elementType { get; set; } // 0x000000018036CFF0-0x000000018036D000 0x0000000181435C70-0x0000000181435C90
		public SelectorType selectorType { get; set; } // 0x0000000180372360-0x0000000180372370 0x0000000181435C90-0x0000000181435CD0
		public string elementName { get; set; } // 0x000000018038B150-0x000000018038B160 0x0000000181435C30-0x0000000181435C70
		public int elementIndex { get; set; } // 0x00000001803C2700-0x00000001803C2710 0x0000000181435BF0-0x0000000181435C30
		public int elementId { get; set; } // 0x00000001803C26F0-0x00000001803C2700 0x0000000181435BD0-0x0000000181435BF0
		public bool isAssigned { get; } // 0x0000000181435B30-0x0000000181435BD0 
	
		// Nested types
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		public enum ElementType // TypeDefIndex: 5809
		{
			Axis = 0,
			Button = 1
		}
	
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		public enum SelectorType // TypeDefIndex: 5810
		{
			Name = 0,
			Index = 1,
			Id = 2
		}
	
		// Constructors
		public CustomControllerElementSelector(); // 0x0000000181435B10-0x0000000181435B30
	
		// Methods
		public int GetElementIndex(CustomController customController); // 0x0000000181435450-0x00000001814359A0
		public string GetSelectorFormattedString(); // 0x00000001814359A0-0x0000000181435A60
		private IList<ControllerElementIdentifier> ZMiPycAGpOQhySHUZaTcPLozIgK(CustomController param_0000c6b8, ElementType param_0000c6b9); // 0x0000000181435A60-0x0000000181435B10
		public void ClearCache(); // 0x0000000181435440-0x0000000181435450
	}
}
