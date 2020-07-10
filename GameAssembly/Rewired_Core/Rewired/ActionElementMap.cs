/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using Rewired.Utils.Classes.Data;
using UnityEngine;

// Image 50: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5712-6954

namespace Rewired
{
	[Serializable]
	public sealed class ActionElementMap // TypeDefIndex: 6480
	{
		// Fields
		[CustomObfuscation] // 0x00000001800C3DD0-0x00000001800C3E10
		[SerializeField] // 0x00000001800C3DD0-0x00000001800C3E10
		internal int _actionCategoryId; // 0x10
		[CustomObfuscation] // 0x00000001800C5270-0x00000001800C52B0
		[SerializeField] // 0x00000001800C5270-0x00000001800C52B0
		internal int _actionId; // 0x14
		[CustomObfuscation] // 0x00000001800C5270-0x00000001800C52B0
		[SerializeField] // 0x00000001800C5270-0x00000001800C52B0
		internal ControllerElementType _elementType; // 0x18
		[CustomObfuscation] // 0x00000001800C3DD0-0x00000001800C3E10
		[SerializeField] // 0x00000001800C3DD0-0x00000001800C3E10
		internal int _elementIdentifierId; // 0x1C
		[CustomObfuscation] // 0x00000001800C3DD0-0x00000001800C3E10
		[SerializeField] // 0x00000001800C3DD0-0x00000001800C3E10
		internal AxisRange _axisRange; // 0x20
		[CustomObfuscation] // 0x00000001800C3DD0-0x00000001800C3E10
		[SerializeField] // 0x00000001800C3DD0-0x00000001800C3E10
		internal bool _invert; // 0x24
		[CustomObfuscation] // 0x00000001800C3DD0-0x00000001800C3E10
		[SerializeField] // 0x00000001800C3DD0-0x00000001800C3E10
		internal Pole _axisContribution; // 0x28
		[CustomObfuscation] // 0x00000001800C5270-0x00000001800C52B0
		[SerializeField] // 0x00000001800C5270-0x00000001800C52B0
		internal KeyboardKeyCode _keyboardKeyCode; // 0x2C
		[CustomObfuscation] // 0x00000001800C5270-0x00000001800C52B0
		[SerializeField] // 0x00000001800C5270-0x00000001800C52B0
		internal ModifierKey _modifierKey1; // 0x30
		[CustomObfuscation] // 0x00000001800C5270-0x00000001800C52B0
		[SerializeField] // 0x00000001800C5270-0x00000001800C52B0
		internal ModifierKey _modifierKey2; // 0x34
		[CustomObfuscation] // 0x00000001800C5270-0x00000001800C52B0
		[SerializeField] // 0x00000001800C5270-0x00000001800C52B0
		internal ModifierKey _modifierKey3; // 0x38
		[NonSerialized]
		internal ControllerMap RNrniZeIkGmMkeqZsCLNgsdrTfDu; // 0x40
		[NonSerialized]
		internal bool RYgMGyqWnNNUOzFUBDIFjvchsBxb; // 0x48
		[NonSerialized]
		internal string oOMORlOrxgmdGBHNEgbnhrIAoCGC; // 0x50
		[NonSerialized]
		internal string vzzdNsgcHfbLIdBbrldYLZwQPWL; // 0x58
		[NonSerialized]
		internal int cIpzjPbNKhTxYBMDvNEwhaGcpst; // 0x60
		[NonSerialized]
		internal readonly int jotfbgeLQZTIFstijorJbghJlvHQ; // 0x64
		private static int uidCounter; // 0x00
		private static StringBuilder s_toStringSB; // 0x08
	
		// Properties
		public int actionId { get; set; } // 0x0000000180372360-0x0000000180372370 0x000000018142A570-0x000000018142A960
		public ControllerElementType elementType { get; internal set; } // 0x0000000180367710-0x0000000180367720 0x000000018036B1F0-0x000000018036B200
		public int elementIdentifierId { get; set; } // 0x000000018037E420-0x000000018037E430 0x000000018142AAD0-0x000000018142AD10
		public AxisRange axisRange { get; set; } // 0x00000001803C2700-0x00000001803C2710 0x000000018142A9D0-0x000000018142AAD0
		public bool invert { get; set; } // 0x0000000180487D80-0x0000000180487D90 0x00000001804884F0-0x0000000180488500
		public Pole axisContribution { get; set; } // 0x000000018038E0E0-0x000000018038E0F0 0x000000018142A960-0x000000018142A9D0
		public KeyboardKeyCode keyboardKeyCode { get; set; } // 0x000000018038E0D0-0x000000018038E0E0 0x000000018142AE10-0x000000018142AF00
		public ModifierKey modifierKey1 { get; set; } // 0x000000018043DDC0-0x000000018043DDD0 0x000000018142AF00-0x000000018142B020
		public ModifierKey modifierKey2 { get; set; } // 0x000000018043E170-0x000000018043E180 0x000000018142B020-0x000000018142B110
		public ModifierKey modifierKey3 { get; set; } // 0x00000001804999D0-0x00000001804999E0 0x000000018142B110-0x000000018142B230
		public AxisType axisType { get; } // 0x0000000181429DE0-0x0000000181429E00 
		public ModifierKeyFlags modifierKeyFlags { get; } // 0x0000000181429E80-0x0000000181429ED0 
		public KeyCode keyCode { get; set; } // 0x0000000181429E70-0x0000000181429E80 0x000000018142AD10-0x000000018142AE10
		public bool hasModifiers { get; } // 0x0000000181429E00-0x0000000181429E40 
		public ControllerMap controllerMap { get; } // 0x0000000180369B30-0x0000000180369B40 
		public bool enabled { get; set; } // 0x00000001805E3A60-0x00000001805E3A70 0x000000018082AC70-0x000000018082AC80
		public string elementIdentifierName { get; } // 0x00000001803A27A0-0x00000001803A27B0 
		public string actionDescriptiveName { get; } // 0x0000000180357120-0x0000000180357130 
		public int elementIndex { get; } // 0x00000001804A3730-0x00000001804A3740 
		public int id { get; } // 0x00000001804D0650-0x00000001804D0660 
		private bool isKeyboardMap { get; } // 0x0000000181429E40-0x0000000181429E70 
		private static int nextUid { get; } // 0x0000000181429ED0-0x0000000181429FB0 
	
		// Constructors
		public ActionElementMap(); // 0x00000001814298C0-0x0000000181429A10
		public ActionElementMap(ActionElementMap map); // 0x0000000181429A10-0x0000000181429BE0
		public ActionElementMap(int actionId, ControllerElementType elementType, int elementIdentifierId); // 0x0000000181429BE0-0x0000000181429C30
		public ActionElementMap(int actionId, ControllerElementType elementType, int elementIdentifierId, Pole axisContribution, AxisRange axisRange); // 0x00000001814297D0-0x0000000181429860
		public ActionElementMap(int actionId, ControllerElementType elementType, int elementIdentifierId, Pole axisContribution, AxisRange axisRange, bool invert); // 0x0000000181429860-0x00000001814298C0
		public ActionElementMap(int actionId, ControllerElementType elementType, Pole axisContribution, KeyboardKeyCode keyboardKeyCode, ModifierKey modifierKey1, ModifierKey modifierKey2, ModifierKey modifierKey3); // 0x0000000181429C30-0x0000000181429CA0
		static ActionElementMap(); // 0x0000000181429790-0x00000001814297D0
	
		// Methods
		internal static bool dIylxglaohlpiULnXEveptnMtjP(ActionElementMap param_0000d766); // 0x0000000181429CA0-0x0000000181429D30
		internal static void iWlerSFfasVeRFAYFQtrYHXwKkra(ActionElementMap param_0000d767, ActionElementMap param_0000d768); // 0x0000000181429FB0-0x000000018142A140
		public bool CheckForAssignmentConflict(ElementAssignment elementAssignment); // 0x0000000181428710-0x00000001814288E0
		public bool CheckForAssignmentConflict(ActionElementMap elementMap); // 0x0000000181428600-0x0000000181428710
		public bool ShowInField(AxisRange fieldActionRange); // 0x0000000181428C30-0x0000000181428E30
		public bool IsTarget(ControllerElementTarget elementTarget); // 0x0000000181428BE0-0x0000000181428C30
		public bool IsTarget(IControllerElementTarget elementTarget); // 0x00000001814289F0-0x0000000181428BE0
		internal void AanbyFPIGYaXTAFkKafEiGtuHuY(ControllerMap param_0000d790); // 0x00000001814281B0-0x00000001814282A0
		internal void elzVAiQyWkzuCtGheqcKGERyJJZ(ControllerMap param_0000d791, HardwareControllerMap_Game param_0000d792); // 0x0000000181429D30-0x0000000181429DE0
		private void AanbyFPIGYaXTAFkKafEiGtuHuY(bool param_0000d793); // 0x00000001814282A0-0x0000000181428380
		private void AanbyFPIGYaXTAFkKafEiGtuHuY(ControllerType param_0000d794, HardwareControllerMap_Game param_0000d795, bool param_0000d796); // 0x0000000181427C40-0x00000001814281B0
		private void rHmegILsxjODifpRAbGWlRanCcv(); // 0x000000018142A220-0x000000018142A570
		internal void vMfAexzdpfzhXKkyGdAHmJVnQEr(); // 0x000000018142B580-0x000000018142B640
		private bool UphtGWDUkoGvmsHdAlawJPgoxoo(KeyboardKeyCode param_0000d797, ModifierKeyFlags param_0000d798); // 0x00000001814296D0-0x0000000181429790
		private bool ytINqBOGeYmPBMCXpvVsQMIGfsb(int param_0000d799, AxisRange param_0000d79a); // 0x000000018142B640-0x000000018142B730
		private bool qkdMUWVbdqgUrHevksmWKyDtmum(ElementAssignmentType param_0000d79b); // 0x000000018142A160-0x000000018142A220
		private void jbjvQNVJEVXuZkNSBpQEpvieKDj(); // 0x000000018142A140-0x000000018142A160
		private void GGaCJWAfENtANvBAQKAkFmIfEuq(); // 0x00000001814288E0-0x00000001814289F0
		private void twqwlDxSSSSAFvKnCKBfIDjRHdT(); // 0x000000018142B230-0x000000018142B330
		internal SerializedObject uJZpqEBLkJUYeZxXRkMWiNxeekH(); // 0x000000018142B330-0x000000018142B580
		internal void BxoFMvWmvalDyQMZPpCVmdbosOa(SerializedObject param_0000d79c); // 0x0000000181428380-0x0000000181428600
		public override string ToString(); // 0x0000000181428E30-0x00000001814296D0
	}
}
