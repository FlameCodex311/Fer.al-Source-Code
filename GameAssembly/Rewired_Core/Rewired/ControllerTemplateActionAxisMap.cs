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

// Image 51: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5871-7113

namespace Rewired
{
	public sealed class ControllerTemplateActionAxisMap : ControllerTemplateActionElementMap // TypeDefIndex: 6126
	{
		// Fields
		private AxisRange ExRGMQhhcszaUDJSZXmAQgaCQwR; // 0x28
		private Pole VzTdNXQLdMKvOCewKuOOTAJpYPj; // 0x2C
		private bool xiGVcbeDngTNOAGsRyRJuOyHGQY; // 0x30
	
		// Properties
		public AxisRange axisRange { get; } // 0x000000018043C680-0x000000018043C690 
		public Pole axisContribution { get; } // 0x000000018043C670-0x000000018043C680 
		public bool invert { get; } // 0x0000000180455B90-0x0000000180455BA0 
	
		// Constructors
		internal ControllerTemplateActionAxisMap(SerializedObject serializedObject); // 0x000000018153D090-0x000000018153D150
		internal ControllerTemplateActionAxisMap(int templateElementIdentifierId, AxisRange axisRange, ActionElementMap actionElementMap); // 0x000000018153D150-0x000000018153D230
		internal ControllerTemplateActionAxisMap(int elementIdentifierId, int actionId, AxisRange axisRange, Pole axisContribution, bool invert, bool enabled); // 0x000000018153D230-0x000000018153D2D0
	
		// Methods
		internal override void Export(SerializedObject param_0000ce2a); // 0x000000018153CEC0-0x000000018153CF80
		internal override void Import(SerializedObject param_0000ce2b); // 0x000000018153CF80-0x000000018153D090
		internal override void Clear(); // 0x000000018153C780-0x000000018153C790
		internal override int CreateAEMsFromSource(IControllerTemplateElementSource param_0000ce2c, List<ActionElementMap> param_0000ce2d, bool param_0000ce2e); // 0x000000018153C790-0x000000018153CCD0
		private ActionElementMap waObOGILnxLHUQNmxEavMzNaVosg(IControllerElementTarget param_0000ce2f, AxisRange param_0000ce30); // 0x000000018153D2D0-0x000000018153D650
		private ActionElementMap DLeWjLbhpciRFqAbNSLWiihFBMz(IControllerElementTarget param_0000ce31, Pole param_0000ce32, Pole param_0000ce33); // 0x000000018153CCD0-0x000000018153CEC0
	}
}
