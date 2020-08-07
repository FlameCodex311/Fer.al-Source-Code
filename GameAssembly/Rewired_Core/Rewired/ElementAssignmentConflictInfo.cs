/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;

// Image 51: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5871-7113

namespace Rewired
{
	public struct ElementAssignmentConflictInfo // TypeDefIndex: 5887
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
		public bool isConflict { get; internal set; } // 0x00000001800A1FA0-0x00000001800A2000 0x00000001800A2E00-0x00000001800A2E10
		public bool isUserAssignable { get; internal set; } // 0x00000001800A2DE0-0x00000001800A2DF0 0x00000001800A2E10-0x00000001800A2EC0
		public int playerId { get; internal set; } // 0x0000000180003CA0-0x0000000180003FD0 0x00000001800215B0-0x00000001800215C0
		public ControllerType controllerType { get; internal set; } // 0x00000001800213D0-0x00000001800213E0 0x0000000180021560-0x0000000180021590
		public int controllerId { get; internal set; } // 0x0000000180030DA0-0x0000000180030DB0 0x00000001800A2910-0x00000001800A2920
		public int controllerMapId { get; internal set; } // 0x00000001800034D0-0x00000001800034E0 0x00000001800A2930-0x00000001800A2940
		public int elementMapId { get; internal set; } // 0x0000000180064030-0x0000000180064040 0x00000001800A2920-0x00000001800A2930
		public ControllerElementType elementType { get; internal set; } // 0x0000000180091C10-0x0000000180091C20 0x00000001800A2950-0x00000001800A2960
		public int elementIdentifierId { get; internal set; } // 0x00000001800A2890-0x00000001800A28A0 0x00000001800A2940-0x00000001800A2950
		public KeyCode keyCode { get; internal set; } // 0x00000001800A2880-0x00000001800A2890 0x00000001800A2900-0x00000001800A2910
		public ModifierKeyFlags modifierKeyFlags { get; internal set; } // 0x00000001800A28B0-0x00000001800A28C0 0x00000001800A2970-0x00000001800A2A40
		public int actionId { get; internal set; } // 0x0000000180006C60-0x0000000180006C70 0x0000000180006CB0-0x0000000180006CE0
		public Player player { get; } // 0x00000001800A2DF0-0x00000001800A2E00 
		public InputAction action { get; } // 0x00000001800A2B40-0x00000001800A2C20 
		public Controller controller { get; } // 0x00000001800A2C30-0x00000001800A2C40 
		public ControllerMap controllerMap { get; } // 0x00000001800A2C20-0x00000001800A2C30 
		public ControllerElementIdentifier elementIdentifier { get; } // 0x00000001800A2CE0-0x00000001800A2D30 
		public ActionElementMap elementMap { get; } // 0x00000001800A2D30-0x00000001800A2DE0 
		public string elementDisplayName { get; } // 0x00000001800A2C40-0x00000001800A2CE0 
	
		// Constructors
		public ElementAssignmentConflictInfo(bool isConflict, bool isUserAssignable, int playerId, ControllerType controllerType, int controllerId, int controllerMapId, int elementMapId, int actionId, ControllerElementType elementType, int elementIdentifierId, KeyCode keyCode, ModifierKeyFlags modifierKeyFlags); // 0x00000001800A2A40-0x00000001800A2A90
		public ElementAssignmentConflictInfo(ElementAssignmentConflictInfo source); // 0x00000001800A2A90-0x00000001800A2B40
	}
}
