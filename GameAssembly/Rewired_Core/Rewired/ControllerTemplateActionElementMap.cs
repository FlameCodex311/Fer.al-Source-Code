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
	public abstract class ControllerTemplateActionElementMap // TypeDefIndex: 6124
	{
		// Fields
		private readonly int jotfbgeLQZTIFstijorJbghJlvHQ; // 0x10
		private readonly ControllerTemplateElementType qpRMJmJvNOAvIcQCpUijnRuXokN; // 0x14
		private bool RYgMGyqWnNNUOzFUBDIFjvchsBxb; // 0x18
		private int cjzdzLwOcjfmOCBkTzQRGkafOqG; // 0x1C
		private int ilJvqPoikRsmduZhwvvUegWxsnI; // 0x20
		private static int CWAmZHoCdeGiAYLhklKyhSqRYVl; // 0x00
	
		// Properties
		public int id { get; } // 0x0000000180387590-0x0000000180387930 
		public ControllerTemplateElementType elementType { get; } // 0x00000001803FD2F0-0x00000001803FD300 
		public bool enabled { get; set; } // 0x00000001803F6D30-0x00000001803F6D40 0x00000001803F6D40-0x00000001803F6D50
		public int actionId { get; set; } // 0x00000001803FB770-0x00000001803FB780 0x000000018042D0F0-0x000000018042D100
		public int elementIdentifierId { get; set; } // 0x00000001803FB670-0x00000001803FB680 0x00000001804556D0-0x00000001804556E0
	
		// Constructors
		internal ControllerTemplateActionElementMap(ControllerTemplateElementType elementType); // 0x000000018153E640-0x000000018153E700
		internal ControllerTemplateActionElementMap(ControllerTemplateElementType elementType, int elementIdentifierId, ActionElementMap actionElementMap); // 0x000000018153E770-0x000000018153E820
		internal ControllerTemplateActionElementMap(ControllerTemplateElementType elementType, int elementIdentifierId, int actionId, bool enabled); // 0x000000018153E700-0x000000018153E770
		protected ControllerTemplateActionElementMap(ActionElementMap actionElementMap); // 0x0000000180373240-0x0000000180373250
	
		// Methods
		internal int idgThgOVoKvCqHYTymByBqPwgdbj(IControllerTemplate param_0000ce03, List<ActionElementMap> param_0000ce04, bool param_0000ce05); // 0x000000018153E820-0x000000018153EC70
		internal SerializedObject uJZpqEBLkJUYeZxXRkMWiNxeekH(); // 0x000000018153EC70-0x000000018153ED00
		internal virtual void Export(SerializedObject param_0000ce06); // 0x000000018153E4C0-0x000000018153E590
		internal virtual void Import(SerializedObject param_0000ce07); // 0x000000018153E590-0x000000018153E640
		internal virtual void Clear(); // 0x000000018153E4B0-0x000000018153E4C0
		internal abstract int CreateAEMsFromSource(IControllerTemplateElementSource param_0000ce08, List<ActionElementMap> param_0000ce09, bool param_0000ce0a);
		private int vSxfwNmghzSwJEyATQdzvGPOHjQ(IControllerTemplate param_0000ce0b, List<ActionElementMap> param_0000ce0c, bool param_0000ce0d); // 0x000000018153ED00-0x000000018153EE60
		internal static ControllerTemplateActionElementMap AQMpZVIIXTyemnHtIDPtxhINdLN(SerializedObject param_0000ce0e); // 0x000000018153E330-0x000000018153E4B0
		internal static ControllerTemplateActionElementMap AQMpZVIIXTyemnHtIDPtxhINdLN(ControllerTemplateElementTarget param_0000ce0f, ActionElementMap param_0000ce10); // 0x000000018153DE40-0x000000018153E160
		internal static ControllerTemplateActionElementMap AQMpZVIIXTyemnHtIDPtxhINdLN(ActionElementMap param_0000ce11); // 0x000000018153E160-0x000000018153E330
	}
}
