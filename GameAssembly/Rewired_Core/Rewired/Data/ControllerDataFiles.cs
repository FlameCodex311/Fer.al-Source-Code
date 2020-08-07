/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Rewired;
using Rewired.Data.Mapping;
using UnityEngine;

// Image 51: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5871-7113

namespace Rewired.Data
{
	public sealed class ControllerDataFiles : ScriptableObject // TypeDefIndex: 6193
	{
		// Fields
		[CustomObfuscation] // 0x00000001801D00E0-0x00000001801D0120
		[SerializeField] // 0x00000001801D00E0-0x00000001801D0120
		private HardwareJoystickMap defaultHardwareJoystickMap; // 0x18
		[CustomObfuscation] // 0x00000001801D1070-0x00000001801D10B0
		[SerializeField] // 0x00000001801D1070-0x00000001801D10B0
		private HardwareJoystickMap[] hardwareJoystickMaps; // 0x20
		[CustomObfuscation] // 0x00000001801D1070-0x00000001801D10B0
		[SerializeField] // 0x00000001801D1070-0x00000001801D10B0
		private HardwareJoystickTemplateMap[] joystickTemplates; // 0x28
		[NonSerialized]
		private bool RAnXmqwPYIEvGeEQzFJwtWAdQWx; // 0x30
	
		// Properties
		public Guid defaultHardwareJoystickMapGuid { get; } // 0x0000000180D7E540-0x0000000180D7E650 
		public HardwareJoystickTemplateMap[] JoystickTemplates { get; set; } // 0x00000001803745B0-0x00000001803745C0 0x00000001803FA0C0-0x00000001803FA0D0
		public HardwareJoystickMap[] HardwareJoystickMaps { get; set; } // 0x0000000180374AF0-0x0000000180374B00 0x00000001803F70C0-0x00000001803F70D0
		public HardwareJoystickMap DefaultHardwareJoystickMap { get; set; } // 0x0000000180372430-0x0000000180372440 0x0000000180379F30-0x0000000180379F40
	
		// Constructors
		public ControllerDataFiles(); // 0x00000001803FEC00-0x00000001803FEC10
	
		// Methods
		public string[] GetJoystickNames(); // 0x0000000180D7D4B0-0x0000000180D7D730
		public string[] GetEditorJoystickNames(); // 0x0000000180D7CA30-0x0000000180D7CD90
		public Guid[] GetJoystickGuids(); // 0x0000000180D7D170-0x0000000180D7D4B0
		public string[] GetJoystickTemplateNames(); // 0x0000000180D7D930-0x0000000180D7DB40
		public Guid[] GetJoystickTemplateGuids(); // 0x0000000180D7D730-0x0000000180D7D930
		public HardwareJoystickMap GetHardwareJoystickMap(Guid guid); // 0x0000000180D7CD90-0x0000000180D7D090
		public HardwareJoystickTemplateMap GetJoystickTemplate(Guid guid); // 0x0000000180D7DB40-0x0000000180D7DD60
		public IHardwareControllerTemplateMap GetControllerTemplate(Guid guid); // 0x0000000180D7CA10-0x0000000180D7CA30
		public IHardwareControllerMap GetHardwareJoystickOrTemplateMap(Guid guid); // 0x0000000180D7D090-0x0000000180D7D170
		internal ControllerTemplateElementIdentifier vjwEhCZEZHlszoNSLRdwLzibmvc(Guid param_0000cf0f, int param_0000cf10); // 0x0000000180D7E650-0x0000000180D7E9D0
		internal HardwareJoystickMap_InputManager ZDDUghlFvyxMHPqJsmkLZHIQwXp(Guid param_0000cf11, InputSource param_0000cf12); // 0x0000000180D7E060-0x0000000180D7E2E0
		internal HardwareJoystickMap_InputManager zJKHVYcTIijTbjHMuBBGFkuSuCSr(BridgedControllerHWInfo param_0000cf13); // 0x0000000180D7E9D0-0x0000000180D7EFA0
		private HardwareJoystickMap_InputManager LYKEZddnzpHZKZUhGgOWwmPkjMdm(HardwareJoystickMap param_0000cf14, BridgedControllerHWInfo param_0000cf15, bool param_0000cf16, out InputPlatform param_0000cf17, out int param_0000cf18, out HardwareJoystickMap.Platform param_0000cf19); // 0x0000000180D7DD60-0x0000000180D7DEC0
		private HardwareJoystickMap_InputManager cqqFETOenjjInbvmhAspzwkfQYK(BridgedControllerHWInfo param_0000cf1a, string param_0000cf1b); // 0x0000000180D7E2E0-0x0000000180D7E540
		private HardwareJoystickMap_InputManager MPLEyvBuouUwpvhGqNdNjgPnsAj(BridgedControllerHWInfo param_0000cf1c); // 0x0000000180D7DEC0-0x0000000180D7DF40
		private void SavSGuJhrEsBDJpWxRYntYQMIIw(); // 0x0000000180D7DF40-0x0000000180D7E060
	}
}
