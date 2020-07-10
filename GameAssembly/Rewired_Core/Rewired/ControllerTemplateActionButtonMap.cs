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
	public sealed class ControllerTemplateActionButtonMap : ControllerTemplateActionElementMap // TypeDefIndex: 5966
	{
		// Fields
		private Pole VzTdNXQLdMKvOCewKuOOTAJpYPj; // 0x28
	
		// Properties
		public Pole axisContribution { get; } // 0x000000018038E0E0-0x000000018038E0F0 
	
		// Constructors
		internal ControllerTemplateActionButtonMap(SerializedObject serializedObject); // 0x0000000180A88970-0x0000000180A88A10
		internal ControllerTemplateActionButtonMap(int templateElementIdentifierId, ActionElementMap actionElementMap); // 0x0000000180A88830-0x0000000180A88900
		internal ControllerTemplateActionButtonMap(int elementIdentifierId, int actionId, Pole axisContribution, bool enabled); // 0x0000000180A88900-0x0000000180A88970
	
		// Methods
		internal override void Export(SerializedObject param_0000cba9); // 0x0000000180A88380-0x0000000180A88400
		internal override void Import(SerializedObject param_0000cbaa); // 0x0000000180A88400-0x0000000180A884E0
		internal override void Clear(); // 0x0000000180A88210-0x0000000180A88220
		internal override int CreateAEMsFromSource(IControllerTemplateElementSource param_0000cbab, List<ActionElementMap> param_0000cbac, bool param_0000cbad); // 0x0000000180A88220-0x0000000180A88380
		private ActionElementMap WckSODxzLlXZtllqeRMXDaEvJHf(IControllerElementTarget param_0000cbae, Pole param_0000cbaf); // 0x0000000180A884E0-0x0000000180A88830
	}
}
