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

// Image 51: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5871-7113

namespace Rewired
{
	[Serializable]
	public sealed class ActionElementMap // TypeDefIndex: 6639
	{
		// Fields
		[CustomObfuscation] // 0x00000001801D00E0-0x00000001801D0120
		[SerializeField] // 0x00000001801D00E0-0x00000001801D0120
		internal int _actionCategoryId; // 0x10
		[CustomObfuscation] // 0x00000001801D1070-0x00000001801D10B0
		[SerializeField] // 0x00000001801D1070-0x00000001801D10B0
		internal int _actionId; // 0x14
		[CustomObfuscation] // 0x00000001801D1070-0x00000001801D10B0
		[SerializeField] // 0x00000001801D1070-0x00000001801D10B0
		internal ControllerElementType _elementType; // 0x18
		[CustomObfuscation] // 0x00000001801D00E0-0x00000001801D0120
		[SerializeField] // 0x00000001801D00E0-0x00000001801D0120
		internal int _elementIdentifierId; // 0x1C
		[CustomObfuscation] // 0x00000001801D00E0-0x00000001801D0120
		[SerializeField] // 0x00000001801D00E0-0x00000001801D0120
		internal AxisRange _axisRange; // 0x20
		[CustomObfuscation] // 0x00000001801D00E0-0x00000001801D0120
		[SerializeField] // 0x00000001801D00E0-0x00000001801D0120
		internal bool _invert; // 0x24
		[CustomObfuscation] // 0x00000001801D00E0-0x00000001801D0120
		[SerializeField] // 0x00000001801D00E0-0x00000001801D0120
		internal Pole _axisContribution; // 0x28
		[CustomObfuscation] // 0x00000001801D1070-0x00000001801D10B0
		[SerializeField] // 0x00000001801D1070-0x00000001801D10B0
		internal KeyboardKeyCode _keyboardKeyCode; // 0x2C
		[CustomObfuscation] // 0x00000001801D1070-0x00000001801D10B0
		[SerializeField] // 0x00000001801D1070-0x00000001801D10B0
		internal ModifierKey _modifierKey1; // 0x30
		[CustomObfuscation] // 0x00000001801D1070-0x00000001801D10B0
		[SerializeField] // 0x00000001801D1070-0x00000001801D10B0
		internal ModifierKey _modifierKey2; // 0x34
		[CustomObfuscation] // 0x00000001801D1070-0x00000001801D10B0
		[SerializeField] // 0x00000001801D1070-0x00000001801D10B0
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
		public int actionId { get; set; } // 0x00000001803FD2F0-0x00000001803FD300 0x0000000180908200-0x00000001809085D0
		public ControllerElementType elementType { get; internal set; } // 0x00000001803F46B0-0x00000001803F46C0 0x00000001803F46C0-0x00000001803F46D0
		public int elementIdentifierId { get; set; } // 0x00000001803FB770-0x00000001803FB780 0x0000000180908740-0x0000000180908970
		public AxisRange axisRange { get; set; } // 0x00000001803FB670-0x00000001803FB680 0x0000000180908640-0x0000000180908740
		public bool invert { get; set; } // 0x00000001804F2E90-0x00000001804F2EA0 0x00000001804F2EA0-0x00000001804F2EB0
		public Pole axisContribution { get; set; } // 0x000000018043C680-0x000000018043C690 0x00000001809085D0-0x0000000180908640
		public KeyboardKeyCode keyboardKeyCode { get; set; } // 0x000000018043C670-0x000000018043C680 0x0000000180908A70-0x0000000180908B60
		public ModifierKey modifierKey1 { get; set; } // 0x00000001804AA650-0x00000001804AA660 0x0000000180908B60-0x0000000180908C80
		public ModifierKey modifierKey2 { get; set; } // 0x00000001804EF8F0-0x00000001804EF900 0x0000000180908C80-0x0000000180908D70
		public ModifierKey modifierKey3 { get; set; } // 0x000000018057D1C0-0x000000018057D1D0 0x0000000180908D70-0x0000000180908E90
		public AxisType axisType { get; } // 0x0000000180907A90-0x0000000180907AB0 
		public ModifierKeyFlags modifierKeyFlags { get; } // 0x0000000180907B30-0x0000000180907B80 
		public KeyCode keyCode { get; set; } // 0x0000000180907B20-0x0000000180907B30 0x0000000180908970-0x0000000180908A70
		public bool hasModifiers { get; } // 0x0000000180907AB0-0x0000000180907AF0 
		public ControllerMap controllerMap { get; } // 0x00000001803C7290-0x00000001803C72A0 
		public bool enabled { get; set; } // 0x00000001803C9D60-0x00000001803C9D70 0x00000001803C9DD0-0x00000001803C9DE0
		public string elementIdentifierName { get; } // 0x0000000180378320-0x0000000180378330 
		public string actionDescriptiveName { get; } // 0x00000001803A1580-0x00000001803A1590 
		public int elementIndex { get; } // 0x00000001804ADA80-0x00000001804ADA90 
		public int id { get; } // 0x00000001804C5F20-0x00000001804C5F30 
		private bool isKeyboardMap { get; } // 0x0000000180907AF0-0x0000000180907B20 
		private static int nextUid { get; } // 0x0000000180907B80-0x0000000180907C60 
	
		// Constructors
		public ActionElementMap(); // 0x0000000180907570-0x00000001809076C0
		public ActionElementMap(ActionElementMap map); // 0x00000001809076C0-0x0000000180907890
		public ActionElementMap(int actionId, ControllerElementType elementType, int elementIdentifierId); // 0x0000000180907890-0x00000001809078E0
		public ActionElementMap(int actionId, ControllerElementType elementType, int elementIdentifierId, Pole axisContribution, AxisRange axisRange); // 0x0000000180907480-0x0000000180907510
		public ActionElementMap(int actionId, ControllerElementType elementType, int elementIdentifierId, Pole axisContribution, AxisRange axisRange, bool invert); // 0x0000000180907510-0x0000000180907570
		public ActionElementMap(int actionId, ControllerElementType elementType, Pole axisContribution, KeyboardKeyCode keyboardKeyCode, ModifierKey modifierKey1, ModifierKey modifierKey2, ModifierKey modifierKey3); // 0x00000001809078E0-0x0000000180907950
		static ActionElementMap(); // 0x0000000180907440-0x0000000180907480
	
		// Methods
		internal static bool dIylxglaohlpiULnXEveptnMtjP(ActionElementMap param_0000d9d6); // 0x0000000180907950-0x00000001809079E0
		internal static void iWlerSFfasVeRFAYFQtrYHXwKkra(ActionElementMap param_0000d9d7, ActionElementMap param_0000d9d8); // 0x0000000180907C60-0x0000000180907DF0
		public bool CheckForAssignmentConflict(ElementAssignment elementAssignment); // 0x0000000180906380-0x0000000180906540
		public bool CheckForAssignmentConflict(ActionElementMap elementMap); // 0x0000000180906280-0x0000000180906380
		public bool ShowInField(AxisRange fieldActionRange); // 0x0000000180906890-0x0000000180906AE0
		public bool IsTarget(ControllerElementTarget elementTarget); // 0x0000000180906840-0x0000000180906890
		public bool IsTarget(IControllerElementTarget elementTarget); // 0x0000000180906650-0x0000000180906840
		internal void AanbyFPIGYaXTAFkKafEiGtuHuY(ControllerMap param_0000da00); // 0x0000000180905E30-0x0000000180905F20
		internal void elzVAiQyWkzuCtGheqcKGERyJJZ(ControllerMap param_0000da01, HardwareControllerMap_Game param_0000da02); // 0x00000001809079E0-0x0000000180907A90
		private void AanbyFPIGYaXTAFkKafEiGtuHuY(bool param_0000da03); // 0x0000000180905F20-0x0000000180906000
		private void AanbyFPIGYaXTAFkKafEiGtuHuY(ControllerType param_0000da04, HardwareControllerMap_Game param_0000da05, bool param_0000da06); // 0x00000001809058D0-0x0000000180905E30
		private void rHmegILsxjODifpRAbGWlRanCcv(); // 0x0000000180907ED0-0x0000000180908200
		internal void vMfAexzdpfzhXKkyGdAHmJVnQEr(); // 0x00000001809091E0-0x00000001809092A0
		private bool UphtGWDUkoGvmsHdAlawJPgoxoo(KeyboardKeyCode param_0000da07, ModifierKeyFlags param_0000da08); // 0x0000000180907380-0x0000000180907440
		private bool ytINqBOGeYmPBMCXpvVsQMIGfsb(int param_0000da09, AxisRange param_0000da0a); // 0x00000001809092A0-0x0000000180909390
		private bool qkdMUWVbdqgUrHevksmWKyDtmum(ElementAssignmentType param_0000da0b); // 0x0000000180907E10-0x0000000180907ED0
		private void jbjvQNVJEVXuZkNSBpQEpvieKDj(); // 0x0000000180907DF0-0x0000000180907E10
		private void GGaCJWAfENtANvBAQKAkFmIfEuq(); // 0x0000000180906540-0x0000000180906650
		private void twqwlDxSSSSAFvKnCKBfIDjRHdT(); // 0x0000000180908E90-0x0000000180908F90
		internal SerializedObject uJZpqEBLkJUYeZxXRkMWiNxeekH(); // 0x0000000180908F90-0x00000001809091E0
		internal void BxoFMvWmvalDyQMZPpCVmdbosOa(SerializedObject param_0000da0c); // 0x0000000180906000-0x0000000180906280
		public override string ToString(); // 0x0000000180906AE0-0x0000000180907380
	}
}
