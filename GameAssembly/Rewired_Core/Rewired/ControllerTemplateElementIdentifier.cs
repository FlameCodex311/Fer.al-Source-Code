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
	public class ControllerTemplateElementIdentifier : IControllerTemplateElementIdentifier // TypeDefIndex: 6488
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
		[CustomObfuscation] // 0x00000001800C3DD0-0x00000001800C3E10
		[SerializeField] // 0x00000001800C3DD0-0x00000001800C3E10
		private string _negativeName; // 0x28
		[CustomObfuscation] // 0x00000001800C5270-0x00000001800C52B0
		[SerializeField] // 0x00000001800C5270-0x00000001800C52B0
		private ControllerTemplateElementType _elementType; // 0x30
		internal readonly bool isMappableOnPlatform; // 0x34
	
		// Properties
		public int id { get; } // 0x000000018036CFF0-0x000000018036D000 
		public string name { get; internal set; } // 0x000000018038B150-0x000000018038B160 0x000000018038B160-0x000000018038B170
		public string positiveName { get; internal set; } // 0x000000018036AC70-0x000000018036AC80 0x000000018036AC90-0x000000018036ACA0
		public string negativeName { get; internal set; } // 0x0000000180369B60-0x0000000180369B70 0x0000000180422D30-0x0000000180422D40
		public ControllerTemplateElementType elementType { get; } // 0x000000018043DDC0-0x000000018043DDD0 
		internal virtual bool useEditorElementTypeOverride { get; } // 0x00000001803C28F0-0x00000001803C2900 
		internal virtual ControllerElementType editorElementTypeOverride { get; } // 0x0000000180A89F70-0x0000000180A8A200 
		object IControllerElementIdentifierCommon_Internal.elementType { get; } // 0x0000000180A89C80-0x0000000180A89CD0 
		bool IControllerElementIdentifierCommon_Internal.useEditorElementTypeOverride { get; } // 0x00000001806A4D60-0x00000001806A4D80 
		ControllerElementType IControllerElementIdentifierCommon_Internal.editorElementTypeOverride { get; } // 0x00000001806A4DF0-0x00000001806A4E10 
	
		// Constructors
		public ControllerTemplateElementIdentifier(); // 0x000000018036B6C0-0x000000018036B6D0
		public ControllerTemplateElementIdentifier(ControllerTemplateElementIdentifier source); // 0x0000000180A89D90-0x0000000180A89E40
		internal ControllerTemplateElementIdentifier(int id, string name, string positiveName, string negativeName, ControllerTemplateElementType elementType, bool isMappableOnPlatform); // 0x0000000180A89E40-0x0000000180A89EA0
		internal ControllerTemplateElementIdentifier(ControllerTemplateElementIdentifier source, ControllerTemplateElementType changedElementType, bool isMappableOnPlatform); // 0x0000000180A89EA0-0x0000000180A89F70
	
		// Methods
		public virtual ControllerTemplateElementIdentifier Clone(); // 0x0000000180A89A50-0x0000000180A89B20
		public string GetDisplayName(AxisRange axisRange); // 0x0000000180A89B20-0x0000000180A89C80
		internal ControllerElementIdentifier ToControllerElementIdentifier(); // 0x0000000180A89CD0-0x0000000180A89D90
	}
}
