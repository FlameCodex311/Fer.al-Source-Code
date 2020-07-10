/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Rewired;
using Rewired.Interfaces;
using UnityEngine;

// Image 50: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5712-6954

namespace Rewired.Data
{
	[Serializable]
	[CustomClassObfuscation] // 0x00000001800C3C10-0x00000001800C3C60
	[CustomObfuscation] // 0x00000001800C3C10-0x00000001800C3C60
	internal sealed class ControllerTemplateElementIdentifier_Editor : ControllerTemplateElementIdentifier, IControllerTemplateElementIdentifier_Editor // TypeDefIndex: 6489
	{
		// Fields
		[CustomObfuscation] // 0x00000001800C3DD0-0x00000001800C3E10
		[SerializeField] // 0x00000001800C3DD0-0x00000001800C3E10
		private string _scriptingName; // 0x38
		[CustomObfuscation] // 0x00000001800C3DD0-0x00000001800C3E10
		[SerializeField] // 0x00000001800C3DD0-0x00000001800C3E10
		private string _alternateScriptingName; // 0x40
		[CustomObfuscation] // 0x00000001800C5270-0x00000001800C52B0
		[SerializeField] // 0x00000001800C5270-0x00000001800C52B0
		private bool _excludeFromExport; // 0x48
		[CustomObfuscation] // 0x00000001800C3DD0-0x00000001800C3E10
		[SerializeField] // 0x00000001800C3DD0-0x00000001800C3E10
		private bool _useEditorElementTypeOverride; // 0x49
		[CustomObfuscation] // 0x00000001800C3DD0-0x00000001800C3E10
		[SerializeField] // 0x00000001800C3DD0-0x00000001800C3E10
		private ControllerElementType _editorElementTypeOverride; // 0x4C
	
		// Properties
		internal string scriptingName { get; set; } // 0x0000000180369BB0-0x0000000180369BC0 0x00000001803A2820-0x00000001803A2830
		internal string alternateScriptingName { get; set; } // 0x0000000180369B30-0x0000000180369B40 0x00000001803A2810-0x00000001803A2820
		internal bool excludeFromExport { get; } // 0x00000001805E3A60-0x00000001805E3A70 
		internal override bool useEditorElementTypeOverride { get; } // 0x00000001805E3A70-0x00000001805E3A80 
		internal override ControllerElementType editorElementTypeOverride { get; } // 0x00000001804D0660-0x00000001804D0670 
		internal ControllerTemplateElementType effectiveElementType { get; } // 0x00000001805E3A40-0x00000001805E3A60 
		string IControllerTemplateElementIdentifier_Editor.scriptingName { get; } // 0x0000000180369BB0-0x0000000180369BC0 
		string IControllerTemplateElementIdentifier_Editor.alternateScriptingName { get; } // 0x0000000180369B30-0x0000000180369B40 
	
		// Constructors
		public ControllerTemplateElementIdentifier_Editor(); // 0x000000018037E800-0x000000018037E810
		public ControllerTemplateElementIdentifier_Editor(ControllerTemplateElementIdentifier_Editor source); // 0x00000001805E39E0-0x00000001805E3A40
		internal ControllerTemplateElementIdentifier_Editor(int id, string name, string positiveName, string negativeName, ControllerTemplateElementType elementType, string scriptingName, string alternateScriptingName, bool excludeFromExport, bool useEditorElementTypeOverride, ControllerElementType editorElementTypeOverride, bool isMappableOnPlatform); // 0x00000001805E3900-0x00000001805E3980
		internal ControllerTemplateElementIdentifier_Editor(ControllerTemplateElementIdentifier_Editor source, ControllerTemplateElementType changedElementType, bool isMappableOnPlatform); // 0x00000001805E3980-0x00000001805E39E0
	
		// Methods
		public override ControllerTemplateElementIdentifier Clone(); // 0x00000001805E3870-0x00000001805E3900
	}
}
