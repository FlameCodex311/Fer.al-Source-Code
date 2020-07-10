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

// Image 50: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5712-6954

namespace Rewired.Data
{
	public sealed class ControllerDataFiles : ScriptableObject // TypeDefIndex: 6034
	{
		// Fields
		[CustomObfuscation] // 0x00000001800C3DD0-0x00000001800C3E10
		[SerializeField] // 0x00000001800C3DD0-0x00000001800C3E10
		private HardwareJoystickMap defaultHardwareJoystickMap; // 0x18
		[CustomObfuscation] // 0x00000001800C5270-0x00000001800C52B0
		[SerializeField] // 0x00000001800C5270-0x00000001800C52B0
		private HardwareJoystickMap[] hardwareJoystickMaps; // 0x20
		[CustomObfuscation] // 0x00000001800C5270-0x00000001800C52B0
		[SerializeField] // 0x00000001800C5270-0x00000001800C52B0
		private HardwareJoystickTemplateMap[] joystickTemplates; // 0x28
		[NonSerialized]
		private bool RAnXmqwPYIEvGeEQzFJwtWAdQWx; // 0x30
	
		// Properties
		public Guid defaultHardwareJoystickMapGuid { get; } // 0x00000001805DF4C0-0x00000001805DF5D0 
		public HardwareJoystickTemplateMap[] JoystickTemplates { get; set; } // 0x0000000180369B60-0x0000000180369B70 0x0000000180422D30-0x0000000180422D40
		public HardwareJoystickMap[] HardwareJoystickMaps { get; set; } // 0x000000018036AC70-0x000000018036AC80 0x000000018036AC90-0x000000018036ACA0
		public HardwareJoystickMap DefaultHardwareJoystickMap { get; set; } // 0x000000018038B150-0x000000018038B160 0x000000018038B160-0x000000018038B170
	
		// Constructors
		public ControllerDataFiles(); // 0x00000001803A2BB0-0x00000001803A2BC0
	
		// Methods
		public string[] GetJoystickNames(); // 0x00000001805DE3C0-0x00000001805DE660
		public string[] GetEditorJoystickNames(); // 0x00000001805DD8F0-0x00000001805DDC70
		public Guid[] GetJoystickGuids(); // 0x00000001805DE060-0x00000001805DE3C0
		public string[] GetJoystickTemplateNames(); // 0x00000001805DE870-0x00000001805DEA90
		public Guid[] GetJoystickTemplateGuids(); // 0x00000001805DE660-0x00000001805DE870
		public HardwareJoystickMap GetHardwareJoystickMap(Guid guid); // 0x00000001805DDC70-0x00000001805DDF80
		public HardwareJoystickTemplateMap GetJoystickTemplate(Guid guid); // 0x00000001805DEA90-0x00000001805DECC0
		public IHardwareControllerTemplateMap GetControllerTemplate(Guid guid); // 0x00000001805DD8D0-0x00000001805DD8F0
		public IHardwareControllerMap GetHardwareJoystickOrTemplateMap(Guid guid); // 0x00000001805DDF80-0x00000001805DE060
		internal ControllerTemplateElementIdentifier vjwEhCZEZHlszoNSLRdwLzibmvc(Guid param_0000cc9f, int param_0000cca0); // 0x00000001805DF5D0-0x00000001805DF950
		internal HardwareJoystickMap_InputManager ZDDUghlFvyxMHPqJsmkLZHIQwXp(Guid param_0000cca1, InputSource param_0000cca2); // 0x00000001805DEFC0-0x00000001805DF240
		internal HardwareJoystickMap_InputManager zJKHVYcTIijTbjHMuBBGFkuSuCSr(BridgedControllerHWInfo param_0000cca3); // 0x00000001805DF950-0x00000001805DFF40
		private HardwareJoystickMap_InputManager LYKEZddnzpHZKZUhGgOWwmPkjMdm(HardwareJoystickMap param_0000cca4, BridgedControllerHWInfo param_0000cca5, bool param_0000cca6, out InputPlatform param_0000cca7, out int param_0000cca8, out HardwareJoystickMap.Platform param_0000cca9); // 0x00000001805DECC0-0x00000001805DEE20
		private HardwareJoystickMap_InputManager cqqFETOenjjInbvmhAspzwkfQYK(BridgedControllerHWInfo param_0000ccaa, string param_0000ccab); // 0x00000001805DF240-0x00000001805DF4C0
		private HardwareJoystickMap_InputManager MPLEyvBuouUwpvhGqNdNjgPnsAj(BridgedControllerHWInfo param_0000ccac); // 0x00000001805DEE20-0x00000001805DEEA0
		private void SavSGuJhrEsBDJpWxRYntYQMIIw(); // 0x00000001805DEEA0-0x00000001805DEFC0
	}
}
