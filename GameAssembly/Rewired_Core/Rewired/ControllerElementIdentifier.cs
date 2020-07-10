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

// Image 50: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5712-6954

namespace Rewired
{
	[Serializable]
	[CustomClassObfuscation] // 0x00000001800C10A0-0x00000001800C10D0
	public sealed class ControllerElementIdentifier : IControllerElementIdentifierCommon_Internal // TypeDefIndex: 6487
	{
		// Fields
		[CustomObfuscation] // 0x00000001800C5270-0x00000001800C52B0
		[SerializeField] // 0x00000001800C5270-0x00000001800C52B0
		private int _id; // 0x10
		[CustomObfuscation] // 0x00000001800C3DD0-0x00000001800C3E10
		[SerializeField] // 0x00000001800C3DD0-0x00000001800C3E10
		private string _name; // 0x18
		[CustomObfuscation] // 0x00000001800C5270-0x00000001800C52B0
		[SerializeField] // 0x00000001800C5270-0x00000001800C52B0
		private string _positiveName; // 0x20
		[CustomObfuscation] // 0x00000001800C5270-0x00000001800C52B0
		[SerializeField] // 0x00000001800C5270-0x00000001800C52B0
		private string _negativeName; // 0x28
		[CustomObfuscation] // 0x00000001800C5270-0x00000001800C52B0
		[SerializeField] // 0x00000001800C5270-0x00000001800C52B0
		private ControllerElementType _elementType; // 0x30
		[CustomObfuscation] // 0x00000001800C3DD0-0x00000001800C3E10
		[SerializeField] // 0x00000001800C3DD0-0x00000001800C3E10
		private CompoundControllerElementType _compoundElementType; // 0x34
		internal readonly bool isMappableOnPlatform; // 0x38
		private bool wKnBnddjnLGpvWTmfpNbnnIJgPbb; // 0x39
		private static ControllerElementIdentifier mBDxCiUDRMjvJkDBGqxtRRiEPdx; // 0x00
	
		// Properties
		public int id { get; } // 0x000000018036CFF0-0x000000018036D000 
		public string name { get; internal set; } // 0x000000018038B150-0x000000018038B160 0x000000018043E190-0x000000018043E210
		public string positiveName { get; internal set; } // 0x000000018036AC70-0x000000018036AC80 0x000000018043E2A0-0x000000018043E6E0
		public string negativeName { get; internal set; } // 0x0000000180369B60-0x0000000180369B70 0x000000018043E210-0x000000018043E2A0
		public ControllerElementType elementType { get; } // 0x000000018043DDC0-0x000000018043DDD0 
		public CompoundControllerElementType compoundElementType { get; } // 0x000000018043E170-0x000000018043E180 
		internal bool isCompoundElement { get; } // 0x000000018043E180-0x000000018043E190 
		object IControllerElementIdentifierCommon_Internal.elementType { get; } // 0x000000018043DDD0-0x000000018043DE20 
		bool IControllerElementIdentifierCommon_Internal.useEditorElementTypeOverride { get; } // 0x00000001803C28F0-0x00000001803C2900 
		ControllerElementType IControllerElementIdentifierCommon_Internal.editorElementTypeOverride { get; } // 0x000000018043DDC0-0x000000018043DDD0 
		internal static ControllerElementIdentifier BlankReadOnly { get; } // 0x000000018043E0C0-0x000000018043E170 
	
		// Constructors
		public ControllerElementIdentifier(); // 0x000000018036B6C0-0x000000018036B6D0
		public ControllerElementIdentifier(ControllerElementIdentifier source); // 0x000000018043E060-0x000000018043E0C0
		internal ControllerElementIdentifier(int id, string name, string positiveName, string negativeName, ControllerElementType elementType, CompoundControllerElementType compoundElementType, bool isMappableOnPlatform); // 0x000000018043DFB0-0x000000018043E060
		internal ControllerElementIdentifier(int id, string name, string positiveName, string negativeName, ControllerElementType elementType, bool isMappableOnPlatform); // 0x000000018043DE90-0x000000018043DF00
		internal ControllerElementIdentifier(ControllerElementIdentifier source, bool isMappableOnPlatform, ControllerElementType changedElementType); // 0x000000018043DF00-0x000000018043DFB0
	
		// Methods
		public ControllerElementIdentifier Clone(); // 0x000000018043DBA0-0x000000018043DC30
		public string GetDisplayName(ControllerElementType actualElementType, AxisRange axisRange); // 0x000000018043DC40-0x000000018043DDC0
		public string GetDisplayName(AxisRange axisRange); // 0x000000018043DC30-0x000000018043DC40
		private void YZoTVTEKTyqqaeRvObnTHvRkCGZx(); // 0x000000018043DE20-0x000000018043DE90
	}
}
