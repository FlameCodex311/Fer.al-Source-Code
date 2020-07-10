/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Rewired.Interfaces;
using UnityEngine;

// Image 50: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5712-6954

namespace Rewired
{
	public sealed class Keyboard : ControllerWithMap // TypeDefIndex: 5927
	{
		// Fields
		private static Keyboard singleton; // 0x00
		private readonly IUnifiedKeyboardSource _source; // 0x100
		private ModifierKeyFlags currentModfierKeyFlags; // 0x108
		private ModifierKeyFlags currentModfierKeyFlagsDouble; // 0x10C
		private Func<KeyboardKeyCode, int> _getKeyIndexDelegate; // 0x110
		private readonly int[] keyCodeToKeyIndex; // 0x118
		private static KeyboardKeyCode[] __keyIndexToKeyboardKeyCode; // 0x08
		private readonly int maxKeyValue; // 0x120
		private static Guid s_deviceInstanceGuid; // 0x10
	
		// Properties
		private static KeyboardKeyCode[] keyIndexToKeyboardKeyCode { get; } // 0x0000000180630E00-0x0000000180630FD0 
		public override Guid deviceInstanceGuid { get; } // 0x0000000180630D10-0x0000000180630E00 
	
		// Nested types
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <PollForAllKeys>d__0 : IEnumerable<ControllerPollingInfo>, IEnumerator<ControllerPollingInfo> // TypeDefIndex: 5928
		{
			// Fields
			private ControllerPollingInfo <>2__current; // 0x10
			private int <>1__state; // 0x48
			private int <>l__initialThreadId; // 0x4C
			public Keyboard <>4__this; // 0x50
			public int <count>5__1; // 0x58
			public int <i>5__2; // 0x5C
			public KeyCode <keyCode>5__3; // 0x60
			public bool <value>5__4; // 0x64
	
			// Properties
			ControllerPollingInfo IEnumerator<Rewired.ControllerPollingInfo>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x0000000180460710-0x0000000180460740 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018063D890-0x000000018063D900 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <PollForAllKeys>d__0(int <>1__state); // 0x0000000180460800-0x0000000180460850
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			IEnumerator<ControllerPollingInfo> IEnumerable<ControllerPollingInfo>.GetEnumerator(); // 0x000000018063D730-0x000000018063D840
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			IEnumerator IEnumerable.GetEnumerator(); // 0x000000018063D730-0x000000018063D840
			private bool MoveNext(); // 0x000000018063D260-0x000000018063D730
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x000000018063D840-0x000000018063D890
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <PollForAllKeysDown>d__7 : IEnumerable<ControllerPollingInfo>, IEnumerator<ControllerPollingInfo> // TypeDefIndex: 5929
		{
			// Fields
			private ControllerPollingInfo <>2__current; // 0x10
			private int <>1__state; // 0x48
			private int <>l__initialThreadId; // 0x4C
			public Keyboard <>4__this; // 0x50
			public int <count>5__8; // 0x58
			public int <i>5__9; // 0x5C
			public KeyCode <keyCode>5__a; // 0x60
			public bool <value>5__b; // 0x64
	
			// Properties
			ControllerPollingInfo IEnumerator<Rewired.ControllerPollingInfo>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x0000000180460710-0x0000000180460740 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018063D1F0-0x000000018063D260 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <PollForAllKeysDown>d__7(int <>1__state); // 0x0000000180460800-0x0000000180460850
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			IEnumerator<ControllerPollingInfo> IEnumerable<ControllerPollingInfo>.GetEnumerator(); // 0x000000018063D0C0-0x000000018063D1A0
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			IEnumerator IEnumerable.GetEnumerator(); // 0x000000018063D0C0-0x000000018063D1A0
			private bool MoveNext(); // 0x000000018063CC30-0x000000018063D0C0
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x000000018063D1A0-0x000000018063D1F0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		}
	
		// Constructors
		internal Keyboard(string name, IUnifiedKeyboardSource source); // 0x0000000180630840-0x0000000180630BE0
		private Keyboard(int controllerId, InputSource inputSource, string name, string hardwareIdentifier, HardwareControllerMap_Game hardwareMap, int buttonCount, ControllerDataUpdater dataUpdater); // 0x0000000180630BE0-0x0000000180630D10
	
		// Methods
		public bool GetKey(KeyCode keyCode); // 0x000000018062DF50-0x000000018062E080
		public bool GetKeyDown(KeyCode keyCode); // 0x000000018062D700-0x000000018062D830
		public bool GetKeyUp(KeyCode keyCode); // 0x000000018062DDF0-0x000000018062DF50
		public bool GetKeyDoublePressHold(KeyCode keyCode, float speed); // 0x000000018062D530-0x000000018062D670
		public bool GetKeyDoublePressHold(KeyCode keyCode); // 0x000000018062D670-0x000000018062D700
		public bool GetKeyDoublePressDown(KeyCode keyCode, float speed); // 0x000000018062D3F0-0x000000018062D530
		public bool GetKeyDoublePressDown(KeyCode keyCode); // 0x000000018062D2B0-0x000000018062D3F0
		public bool GetKeyPrev(KeyCode keyCode); // 0x000000018062D990-0x000000018062DB00
		public float GetKeyTimePressed(KeyCode keyCode); // 0x000000018062DB90-0x000000018062DCC0
		public float GetKeyTimeUnpressed(KeyCode keyCode); // 0x000000018062DCC0-0x000000018062DDF0
		public bool GetModifierKey(ModifierKey key); // 0x000000018062EA30-0x000000018062EB80
		public bool GetModifierKeyDown(ModifierKey key); // 0x000000018062E330-0x000000018062E4C0
		public bool GetModifierKeyUp(ModifierKey key); // 0x000000018062E880-0x000000018062EA30
		public bool GetModifierKeyPrev(ModifierKey key); // 0x000000018062E4C0-0x000000018062E620
		public float GetModifierKeyTimePressed(ModifierKey key); // 0x000000018062E620-0x000000018062E750
		public float GetModifierKeyTimeUnpressed(ModifierKey key); // 0x000000018062E750-0x000000018062E880
		public KeyCode GetKeyCodeByButtonIndex(int buttonIndex); // 0x000000018062D0C0-0x000000018062D170
		public KeyCode GetKeyCodeById(int elementIdentifierId); // 0x000000018062D170-0x000000018062D2B0
		public int GetButtonIndexByKeyCode(KeyCode keyCode); // 0x000000018062C750-0x000000018062C860
		public ControllerElementIdentifier GetElementIdentifierByKeyCode(KeyCode keyCode); // 0x000000018062CE80-0x000000018062CFB0
		public ControllerPollingInfo PollForFirstKey(); // 0x000000018062F9C0-0x000000018062FDA0
		public IEnumerable<ControllerPollingInfo> PollForAllKeys(); // 0x000000018062F5E0-0x000000018062F660
		public IEnumerable<ControllerPollingInfo> PollForAllKeysDown(); // 0x000000018062F560-0x000000018062F5E0
		public ControllerPollingInfo PollForFirstKeyDown(); // 0x000000018062F6E0-0x000000018062F9C0
		public override ControllerPollingInfo PollForFirstButton(); // 0x000000018062F6A0-0x000000018062F6E0
		public override ControllerPollingInfo PollForFirstButtonDown(); // 0x000000018062F660-0x000000018062F6A0
		public override IEnumerable<ControllerPollingInfo> PollForAllButtons(); // 0x000000018062F5E0-0x000000018062F660
		public override IEnumerable<ControllerPollingInfo> PollForAllButtonsDown(); // 0x000000018062F560-0x000000018062F5E0
		public static bool IsModifierKey(KeyCode key); // 0x000000018062ED70-0x000000018062EDF0
		internal static bool IsModifierKey(KeyboardKeyCode key); // 0x000000018062EDF0-0x000000018062EE40
		public static ModifierKey KeyCodeToModifierKey(KeyCode key); // 0x000000018062EEC0-0x000000018062EF20
		public static ModifierKeyFlags KeyCodeToModifierKeyFlags(KeyCode key); // 0x000000018062EE40-0x000000018062EEC0
		public static bool ModifierKeyFlagsContain(ModifierKeyFlags flags, ModifierKey key); // 0x000000018062EF20-0x000000018062EFE0
		public static bool ModifierKeyFlagsContain(ModifierKeyFlags flags, KeyCode key); // 0x000000018062EFE0-0x000000018062F090
		public static ModifierKey ModifierKeyFlagsToModifierKey(ModifierKeyFlags flags); // 0x000000018062F150-0x000000018062F1C0
		public static KeyCode ModifierKeyFlagsToKeyCode(ModifierKeyFlags flags); // 0x000000018062F090-0x000000018062F150
		public static ModifierKeyFlags ModifierKeyToModifierKeyFlags(ModifierKey key); // 0x000000018062F520-0x000000018062F560
		public static string GetKeyName(KeyCode key); // 0x000000018062D830-0x000000018062D900
		public static string GetKeyName(KeyCode key, ModifierKeyFlags flags); // 0x000000018062D900-0x000000018062D990
		public static string ModifierKeyFlagsToString(ModifierKeyFlags flags, bool abbreviate); // 0x000000018062F1D0-0x000000018062F520
		public static string ModifierKeyFlagsToString(ModifierKeyFlags flags); // 0x000000018062F1C0-0x000000018062F1D0
		internal static KeyboardKeyCode KeyCodeToKeyboardKeyCode(KeyCode keyCode); // 0x00000001804259C0-0x0000000180425D40
		internal static KeyCode KeyboardKeyCodeToKeyCode(KeyboardKeyCode keyCode); // 0x00000001804259C0-0x0000000180425D40
		internal static ModifierKeyFlags ConvertModifierKeyFlagsSingleToDouble(ModifierKeyFlags flags); // 0x000000018062C370-0x000000018062C470
		internal static int GetDoubledModifierKeyCount(ModifierKeyFlags flags); // 0x000000018062CD60-0x000000018062CE80
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		internal static KeyboardKeyCode GetKeyboardKeyCodeByButtonIndex(int buttonIndex); // 0x000000018062E110-0x000000018062E330
		internal static int GetElementIdentifierIdByKeyCode(KeyboardKeyCode keyCode); // 0x000000018062CFB0-0x000000018062D0C0
		internal static void FixKeyboardAssignments(ref int elementIdentifierId, ref KeyCode keyCode); // 0x000000018062C470-0x000000018062C750
		internal override void UpdateData(UpdateLoopType updateLoop); // 0x00000001806307B0-0x0000000180630840
		internal void UpdateData_AndroidKeyboardDisabled(UpdateLoopType updateLoop); // 0x0000000180630440-0x00000001806307B0
		internal bool GetKey(KeyboardKeyCode keyCode); // 0x000000018062E080-0x000000018062E110
		internal bool GetKeyPrev(KeyboardKeyCode keyCode); // 0x000000018062DB00-0x000000018062DB90
		internal bool AllRequiredKeysPressed(KeyboardKeyCode keyCode, ModifierKeyFlags doubledFlags); // 0x000000018062BFE0-0x000000018062C240
		internal bool IsAnyComponentKeyActive(KeyboardKeyCode keyCode, ModifierKeyFlags doubledFlags); // 0x000000018062EB80-0x000000018062ED70
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		internal int GetButtonIndex(KeyboardKeyCode keyCode); // 0x000000018062C860-0x000000018062C8B0
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		internal override void BakeMap(ControllerMap controllerMap); // 0x000000018062C260-0x000000018062C350
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		internal override void BakeActionElementMap(ControllerMap controllerMap, ActionElementMap map); // 0x000000018062C240-0x000000018062C260
		internal override void Clear(); // 0x000000018062C350-0x000000018062C370
		private bool GetControlButtons(out Button leftButton, out Button rightButton, ModifierKey key); // 0x000000018062C8B0-0x000000018062CD60
		private void UpdateCurrentModifierKeyFlags(); // 0x000000018062FDA0-0x0000000180630440
	}
}
