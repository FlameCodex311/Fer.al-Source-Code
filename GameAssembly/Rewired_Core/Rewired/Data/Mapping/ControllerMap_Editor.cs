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
using Rewired;
using Rewired.Data;

// Image 50: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5712-6954

namespace Rewired.Data.Mapping
{
	[Serializable]
	public sealed class ControllerMap_Editor // TypeDefIndex: 6530
	{
		// Fields
		public int id; // 0x10
		public int categoryId; // 0x14
		public int layoutId; // 0x18
		public string name; // 0x20
		public string hardwareGuidString; // 0x28
		public int customControllerUid; // 0x30
		public List<ActionElementMap> actionElementMaps; // 0x38
	
		// Properties
		public IEnumerable<ActionElementMap> ActionElementMaps { get; } // 0x00000001805E2F50-0x00000001805E2FF0 
		public Guid hardwareGuid { get; } // 0x00000001805E2FF0-0x00000001805E3070 
	
		// Nested types
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class jCCGBRpgNCbdzPSzcNgtyuwAcpl : IEnumerable<ActionElementMap>, IEnumerator<ActionElementMap> // TypeDefIndex: 6531
		{
			// Fields
			private ActionElementMap aSrFEaALHwhGTdXfCdeUqgbwaZGO; // 0x10
			private int eLrUhJFgzEZElCzdKvcrgOLXLvL; // 0x18
			private int RQaeFqcJnaOYpZSBxtfUkVOjfOo; // 0x1C
			public ControllerMap_Editor gKPmvKLRxdGbmXiMfUeDjGbezUo; // 0x20
			public int ZKnOmfdBGxPCzuiOaEmmaNwByyN; // 0x28
	
			// Properties
			ActionElementMap wREFtIYSMXfzFqOrbUZlcqTYuBI { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018036AC80-0x000000018036AC90 
			object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018036AC80-0x000000018036AC90 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public jCCGBRpgNCbdzPSzcNgtyuwAcpl(int <>1__state); // 0x0000000180393A20-0x0000000180393A70
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			IEnumerator<ActionElementMap> IEnumerable<ActionElementMap>.GetEnumerator(); // 0x00000001805F2130-0x00000001805F2270
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			IEnumerator IEnumerable.GetEnumerator(); // 0x00000001805F2130-0x00000001805F2270
			private bool MoveNext(); // 0x00000001805F1F70-0x00000001805F2130
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x00000001805F2270-0x00000001805F22C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		}
	
		// Constructors
		public ControllerMap_Editor(); // 0x00000001805E2EF0-0x00000001805E2F50
	
		// Methods
		public ControllerMap_Editor Clone(); // 0x00000001805E10A0-0x00000001805E12B0
		public ActionElementMap GetActionElementMap(int index); // 0x00000001805E2350-0x00000001805E23D0
		internal JoystickMap TNRoDaxnweWTmUCmpdXMNeyhAsE(Func<int, bool> param_0000db7d, HardwareControllerMapIdentifier param_0000db7e, HardwareJoystickMap param_0000db7f, bool param_0000db80); // 0x00000001805E2540-0x00000001805E2600
		internal KeyboardMap CObfGdbXviCUNBOxWfcmfKizwYH(Func<int, bool> param_0000db81); // 0x00000001805E0FF0-0x00000001805E10A0
		internal MouseMap FDzGmdqWxkfkEbdcGRorwAkaokJ(Func<int, bool> param_0000db82); // 0x00000001805E1C50-0x00000001805E1D00
		internal CustomControllerMap pyoiHlRQNeNOPQeHDIZDlcktqVI(Func<int, bool> param_0000db83, CustomController_Editor param_0000db84); // 0x00000001805E3070-0x00000001805E3100
		internal ControllerTemplateMap WVBGGcAShyAhuaoJOBlxFvkqAyeX(); // 0x00000001805E2C00-0x00000001805E2EF0
		private void VjRfFCOOvZcaIkFFirwEbuTrteB(Func<int, bool> param_0000db85, ControllerMap param_0000db86, HardwareControllerMapIdentifier param_0000db87, HardwareJoystickMap param_0000db88, bool param_0000db89); // 0x00000001805E2600-0x00000001805E2C00
		private void GFqNidtcClgZNeDxxaISdzmTkQyY(Func<int, bool> param_0000db8a, InputSource param_0000db8b, CustomControllerMap param_0000db8c, CustomController_Editor param_0000db8d); // 0x00000001805E1D00-0x00000001805E2350
		public void CreateElementsFromHardwareMap(IHardwareControllerMap hardwareJoystickMap); // 0x00000001805E12B0-0x00000001805E15A0
		public void CreateElementsFromHardwareMap(CustomController_Editor customController); // 0x00000001805E15A0-0x00000001805E1A30
		public void AddActionElementMap(); // 0x00000001805E0F50-0x00000001805E0FF0
		public void InsertActionElementMap(int index); // 0x00000001805E23D0-0x00000001805E24D0
		public void DeleteActionElementMap(int index); // 0x00000001805E1A30-0x00000001805E1AE0
		public bool ReorderActionElementMap(int index, bool offsetDown, bool offsetNow); // 0x00000001805E24D0-0x00000001805E2540
		public void DuplicateActionElementMap(int index); // 0x00000001805E1AE0-0x00000001805E1C50
		private ActionElementMap saoLdySNTnPBmokzuXxVdBgfdPe(); // 0x00000001805E3100-0x00000001805E3160
	}
}
