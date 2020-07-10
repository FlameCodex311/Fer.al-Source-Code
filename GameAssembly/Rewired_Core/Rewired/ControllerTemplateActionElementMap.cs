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
	public abstract class ControllerTemplateActionElementMap // TypeDefIndex: 5965
	{
		// Fields
		private readonly int jotfbgeLQZTIFstijorJbghJlvHQ; // 0x10
		private readonly ControllerTemplateElementType qpRMJmJvNOAvIcQCpUijnRuXokN; // 0x14
		private bool RYgMGyqWnNNUOzFUBDIFjvchsBxb; // 0x18
		private int cjzdzLwOcjfmOCBkTzQRGkafOqG; // 0x1C
		private int ilJvqPoikRsmduZhwvvUegWxsnI; // 0x20
		private static int CWAmZHoCdeGiAYLhklKyhSqRYVl; // 0x00
	
		// Properties
		public int id { get; } // 0x000000018036CFF0-0x000000018036D000 
		public ControllerTemplateElementType elementType { get; } // 0x0000000180372360-0x0000000180372370 
		public bool enabled { get; set; } // 0x000000018041BAC0-0x000000018041BAD0 0x000000018048F590-0x000000018048F5A0
		public int actionId { get; set; } // 0x000000018037E420-0x000000018037E430 0x000000018037E600-0x000000018037E610
		public int elementIdentifierId { get; set; } // 0x00000001803C2700-0x00000001803C2710 0x00000001804886F0-0x0000000180488700
	
		// Constructors
		internal ControllerTemplateActionElementMap(ControllerTemplateElementType elementType); // 0x0000000180A89220-0x0000000180A892E0
		internal ControllerTemplateActionElementMap(ControllerTemplateElementType elementType, int elementIdentifierId, ActionElementMap actionElementMap); // 0x0000000180A89350-0x0000000180A89400
		internal ControllerTemplateActionElementMap(ControllerTemplateElementType elementType, int elementIdentifierId, int actionId, bool enabled); // 0x0000000180A892E0-0x0000000180A89350
		protected ControllerTemplateActionElementMap(ActionElementMap actionElementMap); // 0x000000018036B6C0-0x000000018036B6D0
	
		// Methods
		internal int idgThgOVoKvCqHYTymByBqPwgdbj(IControllerTemplate param_0000cb93, List<ActionElementMap> param_0000cb94, bool param_0000cb95); // 0x0000000180A89400-0x0000000180A89860
		internal SerializedObject uJZpqEBLkJUYeZxXRkMWiNxeekH(); // 0x0000000180A89860-0x0000000180A898F0
		internal virtual void Export(SerializedObject param_0000cb96); // 0x0000000180A890A0-0x0000000180A89170
		internal virtual void Import(SerializedObject param_0000cb97); // 0x0000000180A89170-0x0000000180A89220
		internal virtual void Clear(); // 0x0000000180A89090-0x0000000180A890A0
		internal abstract int CreateAEMsFromSource(IControllerTemplateElementSource param_0000cb98, List<ActionElementMap> param_0000cb99, bool param_0000cb9a);
		private int vSxfwNmghzSwJEyATQdzvGPOHjQ(IControllerTemplate param_0000cb9b, List<ActionElementMap> param_0000cb9c, bool param_0000cb9d); // 0x0000000180A898F0-0x0000000180A89A50
		internal static ControllerTemplateActionElementMap AQMpZVIIXTyemnHtIDPtxhINdLN(SerializedObject param_0000cb9e); // 0x0000000180A88F10-0x0000000180A89090
		internal static ControllerTemplateActionElementMap AQMpZVIIXTyemnHtIDPtxhINdLN(ControllerTemplateElementTarget param_0000cb9f, ActionElementMap param_0000cba0); // 0x0000000180A88A10-0x0000000180A88D30
		internal static ControllerTemplateActionElementMap AQMpZVIIXTyemnHtIDPtxhINdLN(ActionElementMap param_0000cba1); // 0x0000000180A88D30-0x0000000180A88F10
	}
}
