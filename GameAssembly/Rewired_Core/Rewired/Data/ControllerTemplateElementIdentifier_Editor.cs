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

// Image 51: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5871-7113

namespace Rewired.Data
{
	[Serializable]
	[CustomClassObfuscation] // 0x00000001801CDED0-0x00000001801CDF20
	[CustomObfuscation] // 0x00000001801CDED0-0x00000001801CDF20
	internal sealed class ControllerTemplateElementIdentifier_Editor : ControllerTemplateElementIdentifier, IControllerTemplateElementIdentifier_Editor // TypeDefIndex: 6648
	{
		// Fields
		[CustomObfuscation] // 0x00000001801D00E0-0x00000001801D0120
		[SerializeField] // 0x00000001801D00E0-0x00000001801D0120
		private string _scriptingName; // 0x38
		[CustomObfuscation] // 0x00000001801D00E0-0x00000001801D0120
		[SerializeField] // 0x00000001801D00E0-0x00000001801D0120
		private string _alternateScriptingName; // 0x40
		[CustomObfuscation] // 0x00000001801D1070-0x00000001801D10B0
		[SerializeField] // 0x00000001801D1070-0x00000001801D10B0
		private bool _excludeFromExport; // 0x48
		[CustomObfuscation] // 0x00000001801D00E0-0x00000001801D0120
		[SerializeField] // 0x00000001801D00E0-0x00000001801D0120
		private bool _useEditorElementTypeOverride; // 0x49
		[CustomObfuscation] // 0x00000001801D00E0-0x00000001801D0120
		[SerializeField] // 0x00000001801D00E0-0x00000001801D0120
		private ControllerElementType _editorElementTypeOverride; // 0x4C
	
		// Properties
		internal string scriptingName { get; set; } // 0x00000001803743D0-0x00000001803743E0 0x00000001803FEB60-0x00000001803FEB70
		internal string alternateScriptingName { get; set; } // 0x00000001803C7290-0x00000001803C72A0 0x00000001804CD6C0-0x00000001804CD6D0
		internal bool excludeFromExport { get; } // 0x00000001803C9D60-0x00000001803C9D70 
		internal override bool useEditorElementTypeOverride { get; } // 0x00000001803C9D80-0x00000001803C9D90 
		internal override ControllerElementType editorElementTypeOverride { get; } // 0x000000018078C430-0x000000018078C440 
		internal ControllerTemplateElementType effectiveElementType { get; } // 0x0000000180D82CE0-0x0000000180D82D00 
		string IControllerTemplateElementIdentifier_Editor.scriptingName { get; } // 0x00000001803743D0-0x00000001803743E0 
		string IControllerTemplateElementIdentifier_Editor.alternateScriptingName { get; } // 0x00000001803C7290-0x00000001803C72A0 
	
		// Constructors
		public ControllerTemplateElementIdentifier_Editor(); // 0x00000001803F46D0-0x00000001803F46E0
		public ControllerTemplateElementIdentifier_Editor(ControllerTemplateElementIdentifier_Editor source); // 0x0000000180D82C80-0x0000000180D82CE0
		internal ControllerTemplateElementIdentifier_Editor(int id, string name, string positiveName, string negativeName, ControllerTemplateElementType elementType, string scriptingName, string alternateScriptingName, bool excludeFromExport, bool useEditorElementTypeOverride, ControllerElementType editorElementTypeOverride, bool isMappableOnPlatform); // 0x0000000180D82BA0-0x0000000180D82C20
		internal ControllerTemplateElementIdentifier_Editor(ControllerTemplateElementIdentifier_Editor source, ControllerTemplateElementType changedElementType, bool isMappableOnPlatform); // 0x0000000180D82C20-0x0000000180D82C80
	
		// Methods
		public override ControllerTemplateElementIdentifier Clone(); // 0x0000000180D82B10-0x0000000180D82BA0
	}
}
