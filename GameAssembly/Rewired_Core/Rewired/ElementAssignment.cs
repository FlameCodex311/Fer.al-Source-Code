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
	public struct ElementAssignment // TypeDefIndex: 5730
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
		public ElementAssignment(ElementAssignmentType elementAssignmentType, int elementIdentifierId, AxisRange axisRange, KeyCode keyboardKey, ModifierKeyFlags modifierKeyFlags, int actionId, Pole axisContribution, bool invert, int elementMapId); // 0x000000018000AA10-0x000000018000AA50
		public ElementAssignment(ControllerType controllerType, ControllerElementType elementType, int elementIdentifierId, AxisRange axisRange, KeyCode keyboardKey, ModifierKeyFlags modifierKeyFlags, int actionId, Pole axisContribution, bool invert, int elementMapId); // 0x000000018000A870-0x000000018000A8F0
		public ElementAssignment(ElementAssignmentType elementAssignmentType, int elementIdentifierId, AxisRange axisRange, KeyCode keyboardKey, ModifierKeyFlags modifierKeyFlags, int actionId, Pole axisContribution, bool invert); // 0x000000018000A9A0-0x000000018000A9E0
		public ElementAssignment(ControllerType controllerType, ControllerElementType elementType, int elementIdentifierId, AxisRange axisRange, KeyCode keyboardKey, ModifierKeyFlags modifierKeyFlags, int actionId, Pole axisContribution, bool invert); // 0x000000018000A8F0-0x000000018000A970
		public ElementAssignment(int elementIdentifierId, int actionId, bool invert); // 0x000000018000A9E0-0x000000018000AA10
		public ElementAssignment(int elementIdentifierId, int actionId, bool invert, int elementMapId); // 0x000000018000AB10-0x000000018000AB40
		public ElementAssignment(int elementIdentifierId, AxisRange axisRange, int actionId, Pole axisContribution); // 0x000000018000A840-0x000000018000A870
		public ElementAssignment(int elementIdentifierId, AxisRange axisRange, int actionId, Pole axisContribution, int elementMapId); // 0x000000018000AAE0-0x000000018000AB10
		public ElementAssignment(int elementIdentifierId, int actionId, Pole axisContribution); // 0x000000018000AB40-0x000000018000ABF0
		public ElementAssignment(int elementIdentifierId, int actionId, Pole axisContribution, int elementMapId); // 0x000000018000A970-0x000000018000A9A0
		public ElementAssignment(KeyCode keyboardKey, ModifierKeyFlags modifierKeyFlags, int actionId, Pole axisContribution); // 0x000000018000AA50-0x000000018000AA60
		public ElementAssignment(KeyCode keyboardKey, ModifierKeyFlags modifierKeyFlags, int actionId, Pole axisContribution, int elementMapId); // 0x000000018000AA60-0x000000018000AAE0
	
		// Methods
		public static ElementAssignment CompleteAssignment(ElementAssignmentType elementAssignmentType, int elementIdentifierId, AxisRange axisRange, KeyCode keyboardKey, ModifierKeyFlags modifierKeyFlags, int actionId, Pole axisContribution, bool invert, int elementMapId); // 0x0000000180618540-0x0000000180618590
		public static ElementAssignment CompleteAssignment(ControllerType controllerType, ControllerElementType elementType, int elementIdentifierId, AxisRange axisRange, KeyCode keyboardKey, ModifierKeyFlags modifierKeyFlags, int actionId, Pole axisContribution, bool invert, int elementMapId); // 0x00000001806183D0-0x0000000180618460
		public static ElementAssignment CompleteAssignment(ElementAssignmentType elementAssignmentType, int elementIdentifierId, AxisRange axisRange, KeyCode keyboardKey, ModifierKeyFlags modifierKeyFlags, int actionId, Pole axisContribution, bool invert); // 0x0000000180618460-0x00000001806184B0
		public static ElementAssignment CompleteAssignment(ControllerType controllerType, ControllerElementType elementType, int elementIdentifierId, AxisRange axisRange, KeyCode keyboardKey, ModifierKeyFlags modifierKeyFlags, int actionId, Pole axisContribution, bool invert); // 0x00000001806184B0-0x0000000180618540
		public static ElementAssignment FullAxisAssignment(int elementIdentifierId, int actionId, bool invert); // 0x0000000180618590-0x00000001806185C0
		public static ElementAssignment FullAxisAssignment(int elementIdentifierId, int actionId, bool invert, int elementMapId); // 0x00000001806185C0-0x00000001806185F0
		public static ElementAssignment SplitAxisAssignment(int elementIdentifierId, AxisRange axisRange, int actionId, Pole axisContribution); // 0x0000000180618750-0x0000000180618A00
		public static ElementAssignment SplitAxisAssignment(int elementIdentifierId, AxisRange axisRange, int actionId, Pole axisContribution, int elementMapId); // 0x0000000180618710-0x0000000180618750
		public static ElementAssignment ButtonAssignment(int elementIdentifierId, int actionId, Pole axisContribution); // 0x0000000180618350-0x0000000180618390
		public static ElementAssignment ButtonAssignment(int elementIdentifierId, int actionId, Pole axisContribution, int elementMapId); // 0x0000000180618390-0x00000001806183D0
		public static ElementAssignment KeyboardKeyAssignment(KeyCode keyboardKey, ModifierKeyFlags modifierKeyFlags, int actionId, Pole axisContribution); // 0x0000000180618680-0x0000000180618710
		public static ElementAssignment KeyboardKeyAssignment(KeyCode keyboardKey, ModifierKeyFlags modifierKeyFlags, int actionId, Pole axisContribution, int elementMapId); // 0x00000001806185F0-0x0000000180618680
		public ElementAssignmentConflictCheck ToElementAssignmentConflictCheck(); // 0x000000018000A750-0x000000018000A840
	}
}
