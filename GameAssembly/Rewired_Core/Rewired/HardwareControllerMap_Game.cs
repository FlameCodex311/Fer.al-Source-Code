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

// Image 51: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5871-7113

namespace Rewired
{
	[CustomClassObfuscation] // 0x00000001801CDC90-0x00000001801CDCE0
	[CustomObfuscation] // 0x00000001801CDC90-0x00000001801CDCE0
	internal class HardwareControllerMap_Game // TypeDefIndex: 6691
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
		private HardwareControllerMap_Game(string controllerName); // 0x0000000180400150-0x0000000180400180
		public HardwareControllerMap_Game(string controllerName, int customControllerSourceId, ControllerElementIdentifier[] hardwareElementIdentifiers, int[] buttonElementIdentifierIds, int[] axisElementIdentifierIds, AxisCalibrationData[] hwAxisCalibrationData, AxisRange[] hwAxisRanges, HardwareAxisInfo[] hwAxisInfo, HardwareButtonInfo[] hwButtonInfo, HardwareJoystickMap.CompoundElement[] compoundElements); // 0x0000000180E60D80-0x0000000180E60E10
		public HardwareControllerMap_Game(string controllerName, HardwareControllerMapIdentifier hardwareMapIdentifier, JoystickType[] joystickTypes, ControllerElementIdentifier[] hardwareElementIdentifiers, int[] buttonElementIdentifierIds, int[] axisElementIdentifierIds, AxisCalibrationData[] hwAxisCalibrationData, AxisRange[] hwAxisRanges, HardwareAxisInfo[] hwAxisInfo, HardwareButtonInfo[] hwButtonInfo, HardwareJoystickMap.CompoundElement[] compoundElements); // 0x0000000180E60F00-0x0000000180E61010
		public HardwareControllerMap_Game(string controllerName, HardwareControllerMapIdentifier hardwareMapIdentifier, ControllerElementIdentifier[] hardwareElementIdentifiers, int[] buttonElementIdentifierIds, int[] axisElementIdentifierIds, AxisCalibrationData[] hwAxisCalibrationData, AxisRange[] hwAxisRanges, HardwareAxisInfo[] hwAxisInfo, HardwareButtonInfo[] hwButtonInfo, HardwareJoystickMap.CompoundElement[] compoundElements); // 0x0000000180E60E10-0x0000000180E60F00
		private HardwareControllerMap_Game(string controllerName, ControllerElementIdentifier[] hardwareElementIdentifiers, int[] buttonElementIdentifierIds, int[] axisElementIdentifierIds, AxisCalibrationData[] hwAxisCalibrationData, AxisRange[] hwAxisRanges, HardwareAxisInfo[] hwAxisInfo, HardwareButtonInfo[] hwButtonInfo, HardwareJoystickMap.CompoundElement[] compoundElements); // 0x0000000180E60310-0x0000000180E60D80
	
		// Methods
		public string GetElementIdentifierName(int elementIdentifierId); // 0x0000000180E5FE40-0x0000000180E5FEE0
		public string GetElementIdentifierPositiveName(int elementIdentifierId); // 0x0000000180E5FF80-0x0000000180E60020
		public string GetElementIdentifierNegativeName(int elementIdentifierId); // 0x0000000180E5FEE0-0x0000000180E5FF80
		public int GetAxisIndex(int elementIdentifierId); // 0x0000000180E5F8F0-0x0000000180E5F990
		public int GetAxisIndex(string elementIdentifierName); // 0x0000000180E5F6D0-0x0000000180E5F8F0
		public int GetButtonIndex(int elementIdentifierId); // 0x0000000180E5FCB0-0x0000000180E5FD40
		public int GetButtonIndex(string elementIdentifierName); // 0x0000000180E5FA40-0x0000000180E5FCB0
		public ControllerElementIdentifier GetElementIdentifierById(int id); // 0x0000000180E5FD40-0x0000000180E5FE40
		public ControllerElementIdentifier GetButtonElementIdentifierById(int id); // 0x0000000180E5F990-0x0000000180E5FA40
		public ControllerElementIdentifier GetAxisElementIdentifierById(int id); // 0x0000000180E5F600-0x0000000180E5F6D0
		public HardwareJoystickMap.CompoundElement GetAxis2DData(int index); // 0x0000000180E5F4F0-0x0000000180E5F600
		public HardwareJoystickMap.CompoundElement GetHatData(int index); // 0x0000000180E600C0-0x0000000180E60220
		public ControllerElementType GetElementType(int elementIdentifierId); // 0x0000000180E60020-0x0000000180E600C0
		private int XNvqQQRPwtAdAujfKdpKKpZrLPja(ControllerElementIdentifier[] param_0000de3d, int param_0000de3e); // 0x0000000180E60220-0x0000000180E60310
	}
}
