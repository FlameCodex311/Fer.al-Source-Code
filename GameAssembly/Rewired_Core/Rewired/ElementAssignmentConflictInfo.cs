/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;

// Image 50: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5712-6954

namespace Rewired
{
	public struct ElementAssignmentConflictInfo // TypeDefIndex: 5728
	{
		// Fields
		private bool YOfzDsDNrcKWmqXnhPcgbZslJOm; // 0x00
		private bool DuHdTsMDkHfWeffDFciMHnBUilxv; // 0x01
		private int qInCCRhldamcdoUHmMSlSCAIgFUz; // 0x04
		private ControllerType jVRvmdSGLvngKifezJIAQbIZrmi; // 0x08
		private int tiHDqwuWnAypLNJNoTzBctdWRZt; // 0x0C
		private int FagvWnfdvpjghSTDXAJvpmbJDre; // 0x10
		private int eyxCNSJYYsWxlnYVbMTJpmQClnM; // 0x14
		private ControllerElementType qpRMJmJvNOAvIcQCpUijnRuXokN; // 0x18
		private int ilJvqPoikRsmduZhwvvUegWxsnI; // 0x1C
		private KeyCode jNUmuZdwlfalSdaytJiHlizbECwi; // 0x20
		private ModifierKeyFlags WyYzmoHdRbnuKAzTWBtVuJIIols; // 0x24
		private int cjzdzLwOcjfmOCBkTzQRGkafOqG; // 0x28
	
		// Properties
		public bool isConflict { get; internal set; } // 0x000000018000A660-0x000000018000A670 0x000000018000A690-0x000000018000A6A0
		public bool isUserAssignable { get; internal set; } // 0x000000018000A670-0x000000018000A680 0x000000018000A6A0-0x000000018000A750
		public int playerId { get; internal set; } // 0x0000000180002FD0-0x0000000180003310 0x0000000180004CC0-0x0000000180004CD0
		public ControllerType controllerType { get; internal set; } // 0x0000000180004AB0-0x0000000180004AC0 0x0000000180004C50-0x0000000180004C60
		public int controllerId { get; internal set; } // 0x00000001800060E0-0x00000001800060F0 0x000000018000A1D0-0x000000018000A1E0
		public int controllerMapId { get; internal set; } // 0x0000000180002700-0x0000000180002710 0x000000018000A1F0-0x000000018000A200
		public int elementMapId { get; internal set; } // 0x000000018000A120-0x000000018000A130 0x000000018000A1E0-0x000000018000A1F0
		public ControllerElementType elementType { get; internal set; } // 0x000000018000A140-0x000000018000A150 0x000000018000A210-0x000000018000A220
		public int elementIdentifierId { get; internal set; } // 0x000000018000A130-0x000000018000A140 0x000000018000A200-0x000000018000A210
		public KeyCode keyCode { get; internal set; } // 0x00000001800064C0-0x00000001800064D0 0x000000018000A1C0-0x000000018000A1D0
		public ModifierKeyFlags modifierKeyFlags { get; internal set; } // 0x000000018000A160-0x000000018000A170 0x000000018000A230-0x000000018000A240
		public int actionId { get; internal set; } // 0x000000018000A170-0x000000018000A180 0x000000018000A240-0x000000018000A310
		public Player player { get; } // 0x000000018000A680-0x000000018000A690 
		public InputAction action { get; } // 0x000000018000A410-0x000000018000A4F0 
		public Controller controller { get; } // 0x000000018000A500-0x000000018000A510 
		public ControllerMap controllerMap { get; } // 0x000000018000A4F0-0x000000018000A500 
		public ControllerElementIdentifier elementIdentifier { get; } // 0x000000018000A5B0-0x000000018000A600 
		public ActionElementMap elementMap { get; } // 0x000000018000A600-0x000000018000A660 
		public string elementDisplayName { get; } // 0x000000018000A510-0x000000018000A5B0 
	
		// Constructors
		public ElementAssignmentConflictInfo(bool isConflict, bool isUserAssignable, int playerId, ControllerType controllerType, int controllerId, int controllerMapId, int elementMapId, int actionId, ControllerElementType elementType, int elementIdentifierId, KeyCode keyCode, ModifierKeyFlags modifierKeyFlags); // 0x000000018000A310-0x000000018000A360
		public ElementAssignmentConflictInfo(ElementAssignmentConflictInfo source); // 0x000000018000A360-0x000000018000A410
	}
}
