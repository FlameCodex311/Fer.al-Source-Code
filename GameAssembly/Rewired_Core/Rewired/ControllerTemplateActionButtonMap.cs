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
	public sealed class ControllerTemplateActionButtonMap : ControllerTemplateActionElementMap // TypeDefIndex: 6125
	{
		// Fields
		private Pole VzTdNXQLdMKvOCewKuOOTAJpYPj; // 0x28
	
		// Properties
		public Pole axisContribution { get; } // 0x000000018043C680-0x000000018043C690 
	
		// Constructors
		internal ControllerTemplateActionButtonMap(SerializedObject serializedObject); // 0x000000018153DDA0-0x000000018153DE40
		internal ControllerTemplateActionButtonMap(int templateElementIdentifierId, ActionElementMap actionElementMap); // 0x000000018153DC70-0x000000018153DD30
		internal ControllerTemplateActionButtonMap(int elementIdentifierId, int actionId, Pole axisContribution, bool enabled); // 0x000000018153DD30-0x000000018153DDA0
	
		// Methods
		internal override void Export(SerializedObject param_0000ce19); // 0x000000018153D7C0-0x000000018153D840
		internal override void Import(SerializedObject param_0000ce1a); // 0x000000018153D840-0x000000018153D920
		internal override void Clear(); // 0x000000018153D650-0x000000018153D660
		internal override int CreateAEMsFromSource(IControllerTemplateElementSource param_0000ce1b, List<ActionElementMap> param_0000ce1c, bool param_0000ce1d); // 0x000000018153D660-0x000000018153D7C0
		private ActionElementMap WckSODxzLlXZtllqeRMXDaEvJHf(IControllerElementTarget param_0000ce1e, Pole param_0000ce1f); // 0x000000018153D920-0x000000018153DC70
	}
}
