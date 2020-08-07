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
	public sealed class ControllerElementIdentifier : IControllerElementIdentifierCommon_Internal // TypeDefIndex: 6646
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
		[CustomObfuscation] // 0x00000001801D1070-0x00000001801D10B0
		[SerializeField] // 0x00000001801D1070-0x00000001801D10B0
		private string _negativeName; // 0x28
		[CustomObfuscation] // 0x00000001801D1070-0x00000001801D10B0
		[SerializeField] // 0x00000001801D1070-0x00000001801D10B0
		private ControllerElementType _elementType; // 0x30
		[CustomObfuscation] // 0x00000001801D00E0-0x00000001801D0120
		[SerializeField] // 0x00000001801D00E0-0x00000001801D0120
		private CompoundControllerElementType _compoundElementType; // 0x34
		internal readonly bool isMappableOnPlatform; // 0x38
		private bool wKnBnddjnLGpvWTmfpNbnnIJgPbb; // 0x39
		private static ControllerElementIdentifier mBDxCiUDRMjvJkDBGqxtRRiEPdx; // 0x00
	
		// Properties
		public int id { get; } // 0x0000000180387590-0x0000000180387930 
		public string name { get; internal set; } // 0x0000000180372430-0x0000000180372440 0x00000001808C4E60-0x00000001808C4EE0
		public string positiveName { get; internal set; } // 0x0000000180374AF0-0x0000000180374B00 0x00000001808C4F70-0x00000001808C53B0
		public string negativeName { get; internal set; } // 0x00000001803745B0-0x00000001803745C0 0x00000001808C4EE0-0x00000001808C4F70
		public ControllerElementType elementType { get; } // 0x00000001804AA650-0x00000001804AA660 
		public CompoundControllerElementType compoundElementType { get; } // 0x00000001804EF8F0-0x00000001804EF900 
		internal bool isCompoundElement { get; } // 0x00000001808C4E50-0x00000001808C4E60 
		object IControllerElementIdentifierCommon_Internal.elementType { get; } // 0x00000001808C4AC0-0x00000001808C4B10 
		bool IControllerElementIdentifierCommon_Internal.useEditorElementTypeOverride { get; } // 0x0000000180380950-0x0000000180380960 
		ControllerElementType IControllerElementIdentifierCommon_Internal.editorElementTypeOverride { get; } // 0x00000001804AA650-0x00000001804AA660 
		internal static ControllerElementIdentifier BlankReadOnly { get; } // 0x00000001808C4DA0-0x00000001808C4E50 
	
		// Constructors
		public ControllerElementIdentifier(); // 0x0000000180373240-0x0000000180373250
		public ControllerElementIdentifier(ControllerElementIdentifier source); // 0x00000001808C4D40-0x00000001808C4DA0
		internal ControllerElementIdentifier(int id, string name, string positiveName, string negativeName, ControllerElementType elementType, CompoundControllerElementType compoundElementType, bool isMappableOnPlatform); // 0x00000001808C4C90-0x00000001808C4D40
		internal ControllerElementIdentifier(int id, string name, string positiveName, string negativeName, ControllerElementType elementType, bool isMappableOnPlatform); // 0x00000001808C4B80-0x00000001808C4BF0
		internal ControllerElementIdentifier(ControllerElementIdentifier source, bool isMappableOnPlatform, ControllerElementType changedElementType); // 0x00000001808C4BF0-0x00000001808C4C90
	
		// Methods
		public ControllerElementIdentifier Clone(); // 0x00000001808C48B0-0x00000001808C4940
		public string GetDisplayName(ControllerElementType actualElementType, AxisRange axisRange); // 0x00000001808C4950-0x00000001808C4AC0
		public string GetDisplayName(AxisRange axisRange); // 0x00000001808C4940-0x00000001808C4950
		private void YZoTVTEKTyqqaeRvObnTHvRkCGZx(); // 0x00000001808C4B10-0x00000001808C4B80
	}
}
