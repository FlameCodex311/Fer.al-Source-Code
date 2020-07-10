/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Rewired.Utils.Classes.Data;

// Image 50: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5712-6954

namespace Rewired
{
	public sealed class ControllerTemplateActionAxisMap : ControllerTemplateActionElementMap // TypeDefIndex: 5967
	{
		// Fields
		private AxisRange ExRGMQhhcszaUDJSZXmAQgaCQwR; // 0x28
		private Pole VzTdNXQLdMKvOCewKuOOTAJpYPj; // 0x2C
		private bool xiGVcbeDngTNOAGsRyRJuOyHGQY; // 0x30
	
		// Properties
		public AxisRange axisRange { get; } // 0x000000018038E0E0-0x000000018038E0F0 
		public Pole axisContribution { get; } // 0x000000018038E0D0-0x000000018038E0E0 
		public bool invert { get; } // 0x000000018048B840-0x000000018048B850 
	
		// Constructors
		internal ControllerTemplateActionAxisMap(SerializedObject serializedObject); // 0x0000000180A87C50-0x0000000180A87D10
		internal ControllerTemplateActionAxisMap(int templateElementIdentifierId, AxisRange axisRange, ActionElementMap actionElementMap); // 0x0000000180A87D10-0x0000000180A87DF0
		internal ControllerTemplateActionAxisMap(int elementIdentifierId, int actionId, AxisRange axisRange, Pole axisContribution, bool invert, bool enabled); // 0x0000000180A87DF0-0x0000000180A87E90
	
		// Methods
		internal override void Export(SerializedObject param_0000cbba); // 0x0000000180A87A80-0x0000000180A87B40
		internal override void Import(SerializedObject param_0000cbbb); // 0x0000000180A87B40-0x0000000180A87C50
		internal override void Clear(); // 0x0000000180A87310-0x0000000180A87320
		internal override int CreateAEMsFromSource(IControllerTemplateElementSource param_0000cbbc, List<ActionElementMap> param_0000cbbd, bool param_0000cbbe); // 0x0000000180A87320-0x0000000180A87880
		private ActionElementMap waObOGILnxLHUQNmxEavMzNaVosg(IControllerElementTarget param_0000cbbf, AxisRange param_0000cbc0); // 0x0000000180A87E90-0x0000000180A88210
		private ActionElementMap DLeWjLbhpciRFqAbNSLWiihFBMz(IControllerElementTarget param_0000cbc1, Pole param_0000cbc2, Pole param_0000cbc3); // 0x0000000180A87880-0x0000000180A87A80
	}
}
