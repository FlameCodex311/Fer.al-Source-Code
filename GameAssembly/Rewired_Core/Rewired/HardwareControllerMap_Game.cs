/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Rewired.Data.Mapping;
using Rewired.Utils.Classes.Data;

// Image 50: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5712-6954

namespace Rewired
{
	[CustomClassObfuscation] // 0x00000001800C3A30-0x00000001800C3A80
	[CustomObfuscation] // 0x00000001800C3A30-0x00000001800C3A80
	internal class HardwareControllerMap_Game // TypeDefIndex: 6532
	{
		// Fields
		public readonly string controllerName; // 0x10
		public readonly HardwareControllerMapIdentifier hardwareMapIdentifier; // 0x18
		public readonly int customControllerSourceId; // 0x34
		public readonly ADictionary<int, ControllerElementIdentifier> elementIdentifiers; // 0x38
		public readonly ControllerElementIdentifier[] elementIdentifiers_cache; // 0x40
		public readonly ControllerElementIdentifier[] buttonElementIdentifiers_cache; // 0x48
		public readonly ControllerElementIdentifier[] axisElementIdentifiers_cache; // 0x50
		public readonly ControllerElementIdentifier[] axis2DElementIdentifiers_cache; // 0x58
		public readonly ControllerElementIdentifier[] hatElementIdentifiers_cache; // 0x60
		public readonly IList<ControllerElementIdentifier> elementIdentifiers_readOnly; // 0x68
		public readonly IList<ControllerElementIdentifier> buttonElementIdentifiers_readOnly; // 0x70
		public readonly IList<ControllerElementIdentifier> axisElementIdentifiers_readOnly; // 0x78
		public readonly IList<ControllerElementIdentifier> axis2DElementIdentifiers_readOnly; // 0x80
		public readonly IList<ControllerElementIdentifier> hatElementIdentifiers_readOnly; // 0x88
		public readonly int[] buttonElementIdentifierIds; // 0x90
		public readonly int[] axisElementIdentifierIds; // 0x98
		public readonly int[] axis2DElementIdentifierIds; // 0xA0
		public readonly int[] hatElementIdentifierIds; // 0xA8
		public readonly int elementIdentifierCount; // 0xB0
		public readonly int axisCount; // 0xB4
		public readonly int buttonCount; // 0xB8
		public readonly int compoundElementCount; // 0xBC
		public readonly int axis2DCount; // 0xC0
		public readonly int hatCount; // 0xC4
		public readonly JoystickType[] joystickTypes; // 0xC8
		public readonly AxisCalibrationData[] hwAxisCalibrationData; // 0xD0
		public readonly AxisRange[] hwAxisRanges; // 0xD8
		public readonly HardwareAxisInfo[] hwAxisInfo; // 0xE0
		public readonly HardwareButtonInfo[] hwButtonInfo; // 0xE8
		public readonly HardwareJoystickMap.CompoundElement[] compoundElements; // 0xF0
	
		// Constructors
		private HardwareControllerMap_Game(string controllerName); // 0x000000018037D3F0-0x000000018037D420
		public HardwareControllerMap_Game(string controllerName, int customControllerSourceId, ControllerElementIdentifier[] hardwareElementIdentifiers, int[] buttonElementIdentifierIds, int[] axisElementIdentifierIds, AxisCalibrationData[] hwAxisCalibrationData, AxisRange[] hwAxisRanges, HardwareAxisInfo[] hwAxisInfo, HardwareButtonInfo[] hwButtonInfo, HardwareJoystickMap.CompoundElement[] compoundElements); // 0x000000018061CFF0-0x000000018061D080
		public HardwareControllerMap_Game(string controllerName, HardwareControllerMapIdentifier hardwareMapIdentifier, JoystickType[] joystickTypes, ControllerElementIdentifier[] hardwareElementIdentifiers, int[] buttonElementIdentifierIds, int[] axisElementIdentifierIds, AxisCalibrationData[] hwAxisCalibrationData, AxisRange[] hwAxisRanges, HardwareAxisInfo[] hwAxisInfo, HardwareButtonInfo[] hwButtonInfo, HardwareJoystickMap.CompoundElement[] compoundElements); // 0x000000018061D170-0x000000018061D280
		public HardwareControllerMap_Game(string controllerName, HardwareControllerMapIdentifier hardwareMapIdentifier, ControllerElementIdentifier[] hardwareElementIdentifiers, int[] buttonElementIdentifierIds, int[] axisElementIdentifierIds, AxisCalibrationData[] hwAxisCalibrationData, AxisRange[] hwAxisRanges, HardwareAxisInfo[] hwAxisInfo, HardwareButtonInfo[] hwButtonInfo, HardwareJoystickMap.CompoundElement[] compoundElements); // 0x000000018061D080-0x000000018061D170
		private HardwareControllerMap_Game(string controllerName, ControllerElementIdentifier[] hardwareElementIdentifiers, int[] buttonElementIdentifierIds, int[] axisElementIdentifierIds, AxisCalibrationData[] hwAxisCalibrationData, AxisRange[] hwAxisRanges, HardwareAxisInfo[] hwAxisInfo, HardwareButtonInfo[] hwButtonInfo, HardwareJoystickMap.CompoundElement[] compoundElements); // 0x000000018061C500-0x000000018061CFF0
	
		// Methods
		public string GetElementIdentifierName(int elementIdentifierId); // 0x000000018061C000-0x000000018061C0A0
		public string GetElementIdentifierPositiveName(int elementIdentifierId); // 0x000000018061C140-0x000000018061C1E0
		public string GetElementIdentifierNegativeName(int elementIdentifierId); // 0x000000018061C0A0-0x000000018061C140
		public int GetAxisIndex(int elementIdentifierId); // 0x000000018061BA80-0x000000018061BB20
		public int GetAxisIndex(string elementIdentifierName); // 0x000000018061B850-0x000000018061BA80
		public int GetButtonIndex(int elementIdentifierId); // 0x000000018061BE50-0x000000018061BEF0
		public int GetButtonIndex(string elementIdentifierName); // 0x000000018061BBD0-0x000000018061BE50
		public ControllerElementIdentifier GetElementIdentifierById(int id); // 0x000000018061BEF0-0x000000018061C000
		public ControllerElementIdentifier GetButtonElementIdentifierById(int id); // 0x000000018061BB20-0x000000018061BBD0
		public ControllerElementIdentifier GetAxisElementIdentifierById(int id); // 0x000000018061B780-0x000000018061B850
		public HardwareJoystickMap.CompoundElement GetAxis2DData(int index); // 0x000000018061B670-0x000000018061B780
		public HardwareJoystickMap.CompoundElement GetHatData(int index); // 0x000000018061C280-0x000000018061C400
		public ControllerElementType GetElementType(int elementIdentifierId); // 0x000000018061C1E0-0x000000018061C280
		private int XNvqQQRPwtAdAujfKdpKKpZrLPja(ControllerElementIdentifier[] param_0000dbcd, int param_0000dbce); // 0x000000018061C400-0x000000018061C500
	}
}
