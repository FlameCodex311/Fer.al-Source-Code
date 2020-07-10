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
	public struct ElementAssignmentConflictCheck // TypeDefIndex: 5729
	{
		// Fields
		private ElementAssignmentType wUZAlwHmfBMMidpogxYMDufUkFRG; // 0x00
		private int qInCCRhldamcdoUHmMSlSCAIgFUz; // 0x04
		private ControllerType jVRvmdSGLvngKifezJIAQbIZrmi; // 0x08
		private int tiHDqwuWnAypLNJNoTzBctdWRZt; // 0x0C
		private int FagvWnfdvpjghSTDXAJvpmbJDre; // 0x10
		private int AnXSVmQmALeFvDLtjtDRSylVzKF; // 0x14
		private int eyxCNSJYYsWxlnYVbMTJpmQClnM; // 0x18
		private int ilJvqPoikRsmduZhwvvUegWxsnI; // 0x1C
		private AxisRange ExRGMQhhcszaUDJSZXmAQgaCQwR; // 0x20
		private KeyCode thHapmgLdrcZZoySVPpCrGMvXDJL; // 0x24
		private ModifierKeyFlags WyYzmoHdRbnuKAzTWBtVuJIIols; // 0x28
		private int cjzdzLwOcjfmOCBkTzQRGkafOqG; // 0x2C
		private Pole VzTdNXQLdMKvOCewKuOOTAJpYPj; // 0x30
		private bool xiGVcbeDngTNOAGsRyRJuOyHGQY; // 0x34
	
		// Properties
		public ElementAssignmentType elementAssignmentType { get; set; } // 0x0000000180004180-0x0000000180004190 0x0000000180004650-0x0000000180004660
		public int playerId { get; set; } // 0x0000000180002FD0-0x0000000180003310 0x0000000180004CC0-0x0000000180004CD0
		public ControllerType controllerType { get; set; } // 0x0000000180004AB0-0x0000000180004AC0 0x0000000180004C50-0x0000000180004C60
		public int controllerId { get; set; } // 0x00000001800060E0-0x00000001800060F0 0x000000018000A1D0-0x000000018000A1E0
		public int controllerMapId { get; set; } // 0x0000000180002700-0x0000000180002710 0x000000018000A1F0-0x000000018000A200
		public int controllerMapCategoryId { get; set; } // 0x000000018000A120-0x000000018000A130 0x000000018000A1E0-0x000000018000A1F0
		public int elementMapId { get; set; } // 0x000000018000A140-0x000000018000A150 0x000000018000A210-0x000000018000A220
		public int elementIdentifierId { get; set; } // 0x000000018000A130-0x000000018000A140 0x000000018000A200-0x000000018000A210
		public AxisRange axisRange { get; set; } // 0x00000001800064C0-0x00000001800064D0 0x000000018000A1C0-0x000000018000A1D0
		public KeyCode keyboardKey { get; set; } // 0x000000018000A160-0x000000018000A170 0x000000018000A230-0x000000018000A240
		public ModifierKeyFlags modifierKeyFlags { get; set; } // 0x000000018000A170-0x000000018000A180 0x000000018000A240-0x000000018000A310
		public int actionId { get; set; } // 0x000000018000A100-0x000000018000A110 0x000000018000A1A0-0x000000018000A1B0
		public Pole axisContribution { get; set; } // 0x000000018000A110-0x000000018000A120 0x000000018000A1B0-0x000000018000A1C0
		public bool invert { get; set; } // 0x000000018000A150-0x000000018000A160 0x000000018000A220-0x000000018000A230
	
		// Constructors
		public ElementAssignmentConflictCheck(int playerId, ControllerType controllerType, int controllerId, int controllerMapId, ElementAssignmentType elementAssignmentType, int elementIdentifierId, AxisRange axisRange, KeyCode keyboardKey, ModifierKeyFlags modifierKeyFlags, int actionId, Pole axisContribution, bool invert); // 0x0000000180009B80-0x0000000180009BF0
		public ElementAssignmentConflictCheck(int playerId, ControllerType controllerType, int controllerId, int controllerMapId, ElementAssignmentType elementAssignmentType, int elementIdentifierId, AxisRange axisRange, KeyCode keyboardKey, ModifierKeyFlags modifierKeyFlags, int actionId, Pole axisContribution, bool invert, int elementMapId); // 0x0000000180009CD0-0x0000000180009D40
		public ElementAssignmentConflictCheck(int playerId, ControllerType controllerType, int controllerId, int controllerMapId, ControllerElementType elementType, int elementIdentifierId, AxisRange axisRange, KeyCode keyboardKey, ModifierKeyFlags modifierKeyFlags, int actionId, Pole axisContribution, bool invert); // 0x0000000180009FA0-0x000000018000A040
		public ElementAssignmentConflictCheck(int playerId, ControllerType controllerType, int controllerId, int controllerMapId, ControllerElementType elementType, int elementIdentifierId, AxisRange axisRange, KeyCode keyboardKey, ModifierKeyFlags modifierKeyFlags, int actionId, Pole axisContribution, bool invert, int elementMapId); // 0x0000000180009E60-0x0000000180009F30
		public ElementAssignmentConflictCheck(int playerId, ControllerType controllerType, int controllerId, int controllerMapId, int elementIdentifierId, int actionId, bool invert); // 0x0000000180009DA0-0x0000000180009E00
		public ElementAssignmentConflictCheck(int playerId, ControllerType controllerType, int controllerId, int controllerMapId, int elementIdentifierId, int actionId, bool invert, int elementMapId); // 0x0000000180009B10-0x0000000180009B80
		public ElementAssignmentConflictCheck(int playerId, ControllerType controllerType, int controllerId, int controllerMapId, int elementIdentifierId, AxisRange axisRange, int actionId, Pole axisContribution); // 0x0000000180009D40-0x0000000180009DA0
		public ElementAssignmentConflictCheck(int playerId, ControllerType controllerType, int controllerId, int controllerMapId, int elementIdentifierId, AxisRange axisRange, int actionId, Pole axisContribution, int elementMapId); // 0x0000000180009BF0-0x0000000180009C60
		public ElementAssignmentConflictCheck(int playerId, ControllerType controllerType, int controllerId, int controllerMapId, int elementIdentifierId, int actionId, Pole axisContribution); // 0x0000000180009E00-0x0000000180009E60
		public ElementAssignmentConflictCheck(int playerId, ControllerType controllerType, int controllerId, int controllerMapId, int elementIdentifierId, int actionId, Pole axisContribution, int elementMapId); // 0x0000000180009F30-0x0000000180009FA0
		public ElementAssignmentConflictCheck(int playerId, ControllerType controllerType, int controllerId, int controllerMapId, KeyCode keyboardKey, ModifierKeyFlags modifierKeyFlags, int actionId, Pole axisContribution); // 0x0000000180009AA0-0x0000000180009B10
		public ElementAssignmentConflictCheck(int playerId, ControllerType controllerType, int controllerId, int controllerMapId, KeyCode keyboardKey, ModifierKeyFlags modifierKeyFlags, int actionId, Pole axisContribution, int elementMapId); // 0x0000000180009C60-0x0000000180009CD0
		public ElementAssignmentConflictCheck(ElementAssignmentConflictCheck source); // 0x000000018000A040-0x000000018000A100
	
		// Methods
		public ElementAssignment ToElementAssignment(); // 0x0000000180009920-0x00000001800099A0
		public ElementAssignment ToFullAxisAssignment(); // 0x00000001800099A0-0x00000001800099E0
		public ElementAssignment ToSplitAxisAssignment(); // 0x0000000180009A60-0x0000000180009AA0
		public ElementAssignment ToButtonAssignment(); // 0x00000001800098A0-0x0000000180009920
		public ElementAssignment ToKeyboardKeyAssignment(); // 0x00000001800099E0-0x0000000180009A60
		private void ptBmvOgwPBCXNFMLWtmXrhiaBAgj(); // 0x000000018000A180-0x000000018000A1A0
	}
}
