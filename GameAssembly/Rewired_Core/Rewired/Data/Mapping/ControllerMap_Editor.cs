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

// Image 51: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5871-7113

namespace Rewired.Data.Mapping
{
	[Serializable]
	public sealed class ControllerMap_Editor // TypeDefIndex: 6689
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
		public IEnumerable<ActionElementMap> ActionElementMaps { get; } // 0x0000000180D821F0-0x0000000180D82290 
		public Guid hardwareGuid { get; } // 0x0000000180D82290-0x0000000180D82310 
	
		// Nested types
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class jCCGBRpgNCbdzPSzcNgtyuwAcpl : IEnumerable<ActionElementMap>, IEnumerator<ActionElementMap> // TypeDefIndex: 6690
		{
			// Fields
			private ActionElementMap aSrFEaALHwhGTdXfCdeUqgbwaZGO; // 0x10
			private int eLrUhJFgzEZElCzdKvcrgOLXLvL; // 0x18
			private int RQaeFqcJnaOYpZSBxtfUkVOjfOo; // 0x1C
			public ControllerMap_Editor gKPmvKLRxdGbmXiMfUeDjGbezUo; // 0x20
			public int ZKnOmfdBGxPCzuiOaEmmaNwByyN; // 0x28
	
			// Properties
			ActionElementMap wREFtIYSMXfzFqOrbUZlcqTYuBI { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372440-0x0000000180372450 
			object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372440-0x0000000180372450 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public jCCGBRpgNCbdzPSzcNgtyuwAcpl(int <>1__state); // 0x00000001805EDEC0-0x00000001805EDF10
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			IEnumerator<ActionElementMap> IEnumerable<ActionElementMap>.GetEnumerator(); // 0x0000000180D90F80-0x0000000180D910C0
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			IEnumerator IEnumerable.GetEnumerator(); // 0x0000000180D90F80-0x0000000180D910C0
			private bool MoveNext(); // 0x0000000180D90DD0-0x0000000180D90F80
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000180D910C0-0x0000000180D91110
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		}
	
		// Constructors
		public ControllerMap_Editor(); // 0x0000000180D82190-0x0000000180D821F0
	
		// Methods
		public ControllerMap_Editor Clone(); // 0x0000000180D80100-0x0000000180D80310
		public ActionElementMap GetActionElementMap(int index); // 0x0000000180D81630-0x0000000180D816B0
		internal JoystickMap TNRoDaxnweWTmUCmpdXMNeyhAsE(Func<int, bool> param_0000dded, HardwareControllerMapIdentifier param_0000ddee, HardwareJoystickMap param_0000ddef, bool param_0000ddf0); // 0x0000000180D81810-0x0000000180D818D0
		internal KeyboardMap CObfGdbXviCUNBOxWfcmfKizwYH(Func<int, bool> param_0000ddf1); // 0x0000000180D80050-0x0000000180D80100
		internal MouseMap FDzGmdqWxkfkEbdcGRorwAkaokJ(Func<int, bool> param_0000ddf2); // 0x0000000180D80C80-0x0000000180D80D30
		internal CustomControllerMap pyoiHlRQNeNOPQeHDIZDlcktqVI(Func<int, bool> param_0000ddf3, CustomController_Editor param_0000ddf4); // 0x0000000180D82310-0x0000000180D823A0
		internal ControllerTemplateMap WVBGGcAShyAhuaoJOBlxFvkqAyeX(); // 0x0000000180D81EB0-0x0000000180D82190
		private void VjRfFCOOvZcaIkFFirwEbuTrteB(Func<int, bool> param_0000ddf5, ControllerMap param_0000ddf6, HardwareControllerMapIdentifier param_0000ddf7, HardwareJoystickMap param_0000ddf8, bool param_0000ddf9); // 0x0000000180D818D0-0x0000000180D81EB0
		private void GFqNidtcClgZNeDxxaISdzmTkQyY(Func<int, bool> param_0000ddfa, InputSource param_0000ddfb, CustomControllerMap param_0000ddfc, CustomController_Editor param_0000ddfd); // 0x0000000180D80D30-0x0000000180D81630
		public void CreateElementsFromHardwareMap(IHardwareControllerMap hardwareJoystickMap); // 0x0000000180D80310-0x0000000180D805F0
		public void CreateElementsFromHardwareMap(CustomController_Editor customController); // 0x0000000180D805F0-0x0000000180D80A60
		public void AddActionElementMap(); // 0x0000000180D7FFB0-0x0000000180D80050
		public void InsertActionElementMap(int index); // 0x0000000180D816B0-0x0000000180D817A0
		public void DeleteActionElementMap(int index); // 0x0000000180D80A60-0x0000000180D80B10
		public bool ReorderActionElementMap(int index, bool offsetDown, bool offsetNow); // 0x0000000180D817A0-0x0000000180D81810
		public void DuplicateActionElementMap(int index); // 0x0000000180D80B10-0x0000000180D80C80
		private ActionElementMap saoLdySNTnPBmokzuXxVdBgfdPe(); // 0x0000000180D823A0-0x0000000180D82400
	}
}
