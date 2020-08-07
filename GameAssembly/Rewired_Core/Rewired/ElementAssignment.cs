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
	public struct ElementAssignment // TypeDefIndex: 5889
	{
		// Fields
		public ElementAssignmentType type; // 0x00
		public int elementMapId; // 0x04
		public int elementIdentifierId; // 0x08
		public AxisRange axisRange; // 0x0C
		public KeyCode keyboardKey; // 0x10
		public ModifierKeyFlags modifierKeyFlags; // 0x14
		public int actionId; // 0x18
		public Pole axisContribution; // 0x1C
		public bool invert; // 0x20
	
		// Constructors
		public ElementAssignment(ElementAssignmentType elementAssignmentType, int elementIdentifierId, AxisRange axisRange, KeyCode keyboardKey, ModifierKeyFlags modifierKeyFlags, int actionId, Pole axisContribution, bool invert, int elementMapId); // 0x00000001800A3180-0x00000001800A31C0
		public ElementAssignment(ControllerType controllerType, ControllerElementType elementType, int elementIdentifierId, AxisRange axisRange, KeyCode keyboardKey, ModifierKeyFlags modifierKeyFlags, int actionId, Pole axisContribution, bool invert, int elementMapId); // 0x00000001800A2FE0-0x00000001800A3060
		public ElementAssignment(ElementAssignmentType elementAssignmentType, int elementIdentifierId, AxisRange axisRange, KeyCode keyboardKey, ModifierKeyFlags modifierKeyFlags, int actionId, Pole axisContribution, bool invert); // 0x00000001800A3110-0x00000001800A3150
		public ElementAssignment(ControllerType controllerType, ControllerElementType elementType, int elementIdentifierId, AxisRange axisRange, KeyCode keyboardKey, ModifierKeyFlags modifierKeyFlags, int actionId, Pole axisContribution, bool invert); // 0x00000001800A3060-0x00000001800A30E0
		public ElementAssignment(int elementIdentifierId, int actionId, bool invert); // 0x00000001800A3150-0x00000001800A3180
		public ElementAssignment(int elementIdentifierId, int actionId, bool invert, int elementMapId); // 0x00000001800A3280-0x00000001800A32B0
		public ElementAssignment(int elementIdentifierId, AxisRange axisRange, int actionId, Pole axisContribution); // 0x00000001800A2FB0-0x00000001800A2FE0
		public ElementAssignment(int elementIdentifierId, AxisRange axisRange, int actionId, Pole axisContribution, int elementMapId); // 0x00000001800A3250-0x00000001800A3280
		public ElementAssignment(int elementIdentifierId, int actionId, Pole axisContribution); // 0x00000001800A32B0-0x00000001800A3360
		public ElementAssignment(int elementIdentifierId, int actionId, Pole axisContribution, int elementMapId); // 0x00000001800A30E0-0x00000001800A3110
		public ElementAssignment(KeyCode keyboardKey, ModifierKeyFlags modifierKeyFlags, int actionId, Pole axisContribution); // 0x00000001800A31C0-0x00000001800A31D0
		public ElementAssignment(KeyCode keyboardKey, ModifierKeyFlags modifierKeyFlags, int actionId, Pole axisContribution, int elementMapId); // 0x00000001800A31D0-0x00000001800A3250
	
		// Methods
		public static ElementAssignment CompleteAssignment(ElementAssignmentType elementAssignmentType, int elementIdentifierId, AxisRange axisRange, KeyCode keyboardKey, ModifierKeyFlags modifierKeyFlags, int actionId, Pole axisContribution, bool invert, int elementMapId); // 0x0000000180E5C470-0x0000000180E5C4C0
		public static ElementAssignment CompleteAssignment(ControllerType controllerType, ControllerElementType elementType, int elementIdentifierId, AxisRange axisRange, KeyCode keyboardKey, ModifierKeyFlags modifierKeyFlags, int actionId, Pole axisContribution, bool invert, int elementMapId); // 0x0000000180E5C300-0x0000000180E5C390
		public static ElementAssignment CompleteAssignment(ElementAssignmentType elementAssignmentType, int elementIdentifierId, AxisRange axisRange, KeyCode keyboardKey, ModifierKeyFlags modifierKeyFlags, int actionId, Pole axisContribution, bool invert); // 0x0000000180E5C390-0x0000000180E5C3E0
		public static ElementAssignment CompleteAssignment(ControllerType controllerType, ControllerElementType elementType, int elementIdentifierId, AxisRange axisRange, KeyCode keyboardKey, ModifierKeyFlags modifierKeyFlags, int actionId, Pole axisContribution, bool invert); // 0x0000000180E5C3E0-0x0000000180E5C470
		public static ElementAssignment FullAxisAssignment(int elementIdentifierId, int actionId, bool invert); // 0x0000000180E5C4C0-0x0000000180E5C4F0
		public static ElementAssignment FullAxisAssignment(int elementIdentifierId, int actionId, bool invert, int elementMapId); // 0x0000000180E5C4F0-0x0000000180E5C520
		public static ElementAssignment SplitAxisAssignment(int elementIdentifierId, AxisRange axisRange, int actionId, Pole axisContribution); // 0x0000000180E5C680-0x0000000180E5C930
		public static ElementAssignment SplitAxisAssignment(int elementIdentifierId, AxisRange axisRange, int actionId, Pole axisContribution, int elementMapId); // 0x0000000180E5C640-0x0000000180E5C680
		public static ElementAssignment ButtonAssignment(int elementIdentifierId, int actionId, Pole axisContribution); // 0x0000000180E5C280-0x0000000180E5C2C0
		public static ElementAssignment ButtonAssignment(int elementIdentifierId, int actionId, Pole axisContribution, int elementMapId); // 0x0000000180E5C2C0-0x0000000180E5C300
		public static ElementAssignment KeyboardKeyAssignment(KeyCode keyboardKey, ModifierKeyFlags modifierKeyFlags, int actionId, Pole axisContribution); // 0x0000000180E5C5B0-0x0000000180E5C640
		public static ElementAssignment KeyboardKeyAssignment(KeyCode keyboardKey, ModifierKeyFlags modifierKeyFlags, int actionId, Pole axisContribution, int elementMapId); // 0x0000000180E5C520-0x0000000180E5C5B0
		public ElementAssignmentConflictCheck ToElementAssignmentConflictCheck(); // 0x00000001800A2EC0-0x00000001800A2FB0
	}
}
