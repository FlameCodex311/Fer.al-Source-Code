/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Rewired.Interfaces;
using UnityEngine;

// Image 51: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5871-7113

namespace Rewired
{
	[Serializable]
	[CustomClassObfuscation] // 0x00000001801DDE50-0x00000001801DDE80
	public class ControllerTemplateElementIdentifier : IControllerTemplateElementIdentifier // TypeDefIndex: 6647
	{
		// Fields
		[CustomObfuscation] // 0x00000001801D1070-0x00000001801D10B0
		[SerializeField] // 0x00000001801D1070-0x00000001801D10B0
		private int _id; // 0x10
		[CustomObfuscation] // 0x00000001801D00E0-0x00000001801D0120
		[SerializeField] // 0x00000001801D00E0-0x00000001801D0120
		private string _name; // 0x18
		[CustomObfuscation] // 0x00000001801D1070-0x00000001801D10B0
		[SerializeField] // 0x00000001801D1070-0x00000001801D10B0
		private string _positiveName; // 0x20
		[CustomObfuscation] // 0x00000001801D00E0-0x00000001801D0120
		[SerializeField] // 0x00000001801D00E0-0x00000001801D0120
		private string _negativeName; // 0x28
		[CustomObfuscation] // 0x00000001801D1070-0x00000001801D10B0
		[SerializeField] // 0x00000001801D1070-0x00000001801D10B0
		private ControllerTemplateElementType _elementType; // 0x30
		internal readonly bool isMappableOnPlatform; // 0x34
	
		// Properties
		public int id { get; } // 0x0000000180387590-0x0000000180387930 
		public string name { get; internal set; } // 0x0000000180372430-0x0000000180372440 0x0000000180379F30-0x0000000180379F40
		public string positiveName { get; internal set; } // 0x0000000180374AF0-0x0000000180374B00 0x00000001803F70C0-0x00000001803F70D0
		public string negativeName { get; internal set; } // 0x00000001803745B0-0x00000001803745C0 0x00000001803FA0C0-0x00000001803FA0D0
		public ControllerTemplateElementType elementType { get; } // 0x00000001804AA650-0x00000001804AA660 
		internal virtual bool useEditorElementTypeOverride { get; } // 0x0000000180380950-0x0000000180380960 
		internal virtual ControllerElementType editorElementTypeOverride { get; } // 0x000000018153F360-0x000000018153F5F0 
		object IControllerElementIdentifierCommon_Internal.elementType { get; } // 0x000000018153F090-0x000000018153F0E0 
		bool IControllerElementIdentifierCommon_Internal.useEditorElementTypeOverride { get; } // 0x00000001813228B0-0x00000001813228D0 
		ControllerElementType IControllerElementIdentifierCommon_Internal.editorElementTypeOverride { get; } // 0x00000001813BF570-0x00000001813BF590 
	
		// Constructors
		public ControllerTemplateElementIdentifier(); // 0x0000000180373240-0x0000000180373250
		public ControllerTemplateElementIdentifier(ControllerTemplateElementIdentifier source); // 0x000000018153F1A0-0x000000018153F240
		internal ControllerTemplateElementIdentifier(int id, string name, string positiveName, string negativeName, ControllerTemplateElementType elementType, bool isMappableOnPlatform); // 0x000000018153F240-0x000000018153F2A0
		internal ControllerTemplateElementIdentifier(ControllerTemplateElementIdentifier source, ControllerTemplateElementType changedElementType, bool isMappableOnPlatform); // 0x000000018153F2A0-0x000000018153F360
	
		// Methods
		public virtual ControllerTemplateElementIdentifier Clone(); // 0x000000018153EE60-0x000000018153EF30
		public string GetDisplayName(AxisRange axisRange); // 0x000000018153EF30-0x000000018153F090
		internal ControllerElementIdentifier ToControllerElementIdentifier(); // 0x000000018153F0E0-0x000000018153F1A0
	}
}
