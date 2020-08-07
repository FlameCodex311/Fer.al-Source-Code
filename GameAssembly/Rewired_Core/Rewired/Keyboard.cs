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

// Image 51: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5871-7113

namespace Rewired
{
	public sealed class Keyboard : ControllerWithMap // TypeDefIndex: 6086
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
		private static KeyboardKeyCode[] keyIndexToKeyboardKeyCode { get; } // 0x0000000180EA8810-0x0000000180EA89D0 
		public override Guid deviceInstanceGuid { get; } // 0x0000000180EA8720-0x0000000180EA8810 
	
		// Nested types
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <PollForAllKeys>d__0 : IEnumerable<ControllerPollingInfo>, IEnumerator<ControllerPollingInfo> // TypeDefIndex: 6087
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
			ControllerPollingInfo IEnumerator<Rewired.ControllerPollingInfo>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x00000001808E6F10-0x00000001808E6F40 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180EB4FC0-0x0000000180EB5030 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <PollForAllKeys>d__0(int <>1__state); // 0x00000001808E7000-0x00000001808E7050
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			IEnumerator<ControllerPollingInfo> IEnumerable<ControllerPollingInfo>.GetEnumerator(); // 0x0000000180EB4E60-0x0000000180EB4F70
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			IEnumerator IEnumerable.GetEnumerator(); // 0x0000000180EB4E60-0x0000000180EB4F70
			private bool MoveNext(); // 0x0000000180EB49A0-0x0000000180EB4E60
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000180EB4F70-0x0000000180EB4FC0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <PollForAllKeysDown>d__7 : IEnumerable<ControllerPollingInfo>, IEnumerator<ControllerPollingInfo> // TypeDefIndex: 6088
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
			ControllerPollingInfo IEnumerator<Rewired.ControllerPollingInfo>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x00000001808E6F10-0x00000001808E6F40 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180EB4930-0x0000000180EB49A0 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <PollForAllKeysDown>d__7(int <>1__state); // 0x00000001808E7000-0x00000001808E7050
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			IEnumerator<ControllerPollingInfo> IEnumerable<ControllerPollingInfo>.GetEnumerator(); // 0x0000000180EB4800-0x0000000180EB48E0
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			IEnumerator IEnumerable.GetEnumerator(); // 0x0000000180EB4800-0x0000000180EB48E0
			private bool MoveNext(); // 0x0000000180EB4380-0x0000000180EB4800
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000180EB48E0-0x0000000180EB4930
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		}
	
		// Constructors
		internal Keyboard(string name, IUnifiedKeyboardSource source); // 0x0000000180EA8260-0x0000000180EA85F0
		private Keyboard(int controllerId, InputSource inputSource, string name, string hardwareIdentifier, HardwareControllerMap_Game hardwareMap, int buttonCount, ControllerDataUpdater dataUpdater); // 0x0000000180EA85F0-0x0000000180EA8720
	
		// Methods
		public bool GetKey(KeyCode keyCode); // 0x0000000180EA5A40-0x0000000180EA5B70
		public bool GetKeyDown(KeyCode keyCode); // 0x0000000180EA5210-0x0000000180EA5340
		public bool GetKeyUp(KeyCode keyCode); // 0x0000000180EA58F0-0x0000000180EA5A40
		public bool GetKeyDoublePressHold(KeyCode keyCode, float speed); // 0x0000000180EA5050-0x0000000180EA5180
		public bool GetKeyDoublePressHold(KeyCode keyCode); // 0x0000000180EA5180-0x0000000180EA5210
		public bool GetKeyDoublePressDown(KeyCode keyCode, float speed); // 0x0000000180EA4F20-0x0000000180EA5050
		public bool GetKeyDoublePressDown(KeyCode keyCode); // 0x0000000180EA4DF0-0x0000000180EA4F20
		public bool GetKeyPrev(KeyCode keyCode); // 0x0000000180EA54A0-0x0000000180EA5600
		public float GetKeyTimePressed(KeyCode keyCode); // 0x0000000180EA5690-0x0000000180EA57C0
		public float GetKeyTimeUnpressed(KeyCode keyCode); // 0x0000000180EA57C0-0x0000000180EA58F0
		public bool GetModifierKey(ModifierKey key); // 0x0000000180EA64F0-0x0000000180EA6640
		public bool GetModifierKeyDown(ModifierKey key); // 0x0000000180EA5E00-0x0000000180EA5F90
		public bool GetModifierKeyUp(ModifierKey key); // 0x0000000180EA6350-0x0000000180EA64F0
		public bool GetModifierKeyPrev(ModifierKey key); // 0x0000000180EA5F90-0x0000000180EA60F0
		public float GetModifierKeyTimePressed(ModifierKey key); // 0x0000000180EA60F0-0x0000000180EA6220
		public float GetModifierKeyTimeUnpressed(ModifierKey key); // 0x0000000180EA6220-0x0000000180EA6350
		public KeyCode GetKeyCodeByButtonIndex(int buttonIndex); // 0x0000000180EA4A80-0x0000000180EA4D20
		public KeyCode GetKeyCodeById(int elementIdentifierId); // 0x0000000180EA4D20-0x0000000180EA4DF0
		public int GetButtonIndexByKeyCode(KeyCode keyCode); // 0x0000000180EA4170-0x0000000180EA4270
		public ControllerElementIdentifier GetElementIdentifierByKeyCode(KeyCode keyCode); // 0x0000000180EA4850-0x0000000180EA4980
		public ControllerPollingInfo PollForFirstKey(); // 0x0000000180EA7460-0x0000000180EA7830
		public IEnumerable<ControllerPollingInfo> PollForAllKeys(); // 0x0000000180EA7090-0x0000000180EA7110
		public IEnumerable<ControllerPollingInfo> PollForAllKeysDown(); // 0x0000000180EA7010-0x0000000180EA7090
		public ControllerPollingInfo PollForFirstKeyDown(); // 0x0000000180EA7190-0x0000000180EA7460
		public override ControllerPollingInfo PollForFirstButton(); // 0x0000000180EA7150-0x0000000180EA7190
		public override ControllerPollingInfo PollForFirstButtonDown(); // 0x0000000180EA7110-0x0000000180EA7150
		public override IEnumerable<ControllerPollingInfo> PollForAllButtons(); // 0x0000000180EA7090-0x0000000180EA7110
		public override IEnumerable<ControllerPollingInfo> PollForAllButtonsDown(); // 0x0000000180EA7010-0x0000000180EA7090
		public static bool IsModifierKey(KeyCode key); // 0x0000000180EA6820-0x0000000180EA68A0
		internal static bool IsModifierKey(KeyboardKeyCode key); // 0x0000000180EA68A0-0x0000000180EA68F0
		public static ModifierKey KeyCodeToModifierKey(KeyCode key); // 0x0000000180EA6970-0x0000000180EA69D0
		public static ModifierKeyFlags KeyCodeToModifierKeyFlags(KeyCode key); // 0x0000000180EA68F0-0x0000000180EA6970
		public static bool ModifierKeyFlagsContain(ModifierKeyFlags flags, ModifierKey key); // 0x0000000180EA69D0-0x0000000180EA6A90
		public static bool ModifierKeyFlagsContain(ModifierKeyFlags flags, KeyCode key); // 0x0000000180EA6A90-0x0000000180EA6B40
		public static ModifierKey ModifierKeyFlagsToModifierKey(ModifierKeyFlags flags); // 0x0000000180EA6C00-0x0000000180EA6C70
		public static KeyCode ModifierKeyFlagsToKeyCode(ModifierKeyFlags flags); // 0x0000000180EA6B40-0x0000000180EA6C00
		public static ModifierKeyFlags ModifierKeyToModifierKeyFlags(ModifierKey key); // 0x0000000180EA6FD0-0x0000000180EA7010
		public static string GetKeyName(KeyCode key); // 0x0000000180EA5340-0x0000000180EA5410
		public static string GetKeyName(KeyCode key, ModifierKeyFlags flags); // 0x0000000180EA5410-0x0000000180EA54A0
		public static string ModifierKeyFlagsToString(ModifierKeyFlags flags, bool abbreviate); // 0x0000000180EA6C80-0x0000000180EA6FD0
		public static string ModifierKeyFlagsToString(ModifierKeyFlags flags); // 0x0000000180EA6C70-0x0000000180EA6C80
		internal static KeyboardKeyCode KeyCodeToKeyboardKeyCode(KeyCode keyCode); // 0x0000000180831220-0x0000000180831570
		internal static KeyCode KeyboardKeyCodeToKeyCode(KeyboardKeyCode keyCode); // 0x0000000180831220-0x0000000180831570
		internal static ModifierKeyFlags ConvertModifierKeyFlagsSingleToDouble(ModifierKeyFlags flags); // 0x0000000180EA3E10-0x0000000180EA3F10
		internal static int GetDoubledModifierKeyCount(ModifierKeyFlags flags); // 0x0000000180EA4730-0x0000000180EA4850
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		internal static KeyboardKeyCode GetKeyboardKeyCodeByButtonIndex(int buttonIndex); // 0x0000000180EA5C00-0x0000000180EA5E00
		internal static int GetElementIdentifierIdByKeyCode(KeyboardKeyCode keyCode); // 0x0000000180EA4980-0x0000000180EA4A80
		internal static void FixKeyboardAssignments(ref int elementIdentifierId, ref KeyCode keyCode); // 0x0000000180EA3F10-0x0000000180EA4170
		internal override void UpdateData(UpdateLoopType updateLoop); // 0x0000000180EA81D0-0x0000000180EA8260
		internal void UpdateData_AndroidKeyboardDisabled(UpdateLoopType updateLoop); // 0x0000000180EA7E90-0x0000000180EA81D0
		internal bool GetKey(KeyboardKeyCode keyCode); // 0x0000000180EA5B70-0x0000000180EA5C00
		internal bool GetKeyPrev(KeyboardKeyCode keyCode); // 0x0000000180EA5600-0x0000000180EA5690
		internal bool AllRequiredKeysPressed(KeyboardKeyCode keyCode, ModifierKeyFlags doubledFlags); // 0x0000000180EA3A80-0x0000000180EA3CE0
		internal bool IsAnyComponentKeyActive(KeyboardKeyCode keyCode, ModifierKeyFlags doubledFlags); // 0x0000000180EA6640-0x0000000180EA6820
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		internal int GetButtonIndex(KeyboardKeyCode keyCode); // 0x0000000180EA4270-0x0000000180EA42C0
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		internal override void BakeMap(ControllerMap controllerMap); // 0x0000000180EA3D00-0x0000000180EA3DF0
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		internal override void BakeActionElementMap(ControllerMap controllerMap, ActionElementMap map); // 0x0000000180EA3CE0-0x0000000180EA3D00
		internal override void Clear(); // 0x0000000180EA3DF0-0x0000000180EA3E10
		private bool GetControlButtons(out Button leftButton, out Button rightButton, ModifierKey key); // 0x0000000180EA42C0-0x0000000180EA4730
		private void UpdateCurrentModifierKeyFlags(); // 0x0000000180EA7830-0x0000000180EA7E90
	}
}
