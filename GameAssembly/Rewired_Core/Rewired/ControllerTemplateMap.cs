/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Rewired.Utils.Classes.Data;

// Image 51: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5871-7113

namespace Rewired
{
	public class ControllerTemplateMap // TypeDefIndex: 6147
	{
		// Fields
		private readonly int _reInputId; // 0x10
		private readonly int _id; // 0x14
		private readonly Guid _templateTypeGuid; // 0x18
		private readonly List<ControllerTemplateActionElementMap> _elementMaps; // 0x28
		private readonly ReadOnlyCollection<ControllerTemplateActionElementMap> _elementMaps_readOnly; // 0x30
		private bool _enabled; // 0x38
		private int _categoryId; // 0x3C
		private int _layoutId; // 0x40
		private int _sourceMapId; // 0x44
		private static int __idCounter; // 0x00
	
		// Properties
		public int id { get; } // 0x0000000181541DD0-0x0000000181541E70 
		public Guid templateTypeGuid { get; } // 0x0000000181541F10-0x0000000181541FF0 
		public bool enabled { get; set; } // 0x0000000181541D30-0x0000000181541DD0 0x00000001804F1690-0x00000001804F16A0
		public int categoryId { get; internal set; } // 0x0000000181541C90-0x0000000181541D30 0x000000018041B1A0-0x000000018041B1B0
		public int layoutId { get; internal set; } // 0x0000000181541E70-0x0000000181541F10 0x00000001804ADAD0-0x00000001804ADAE0
		public IList<ControllerTemplateActionElementMap> ElementMaps { get; } // 0x0000000181541BE0-0x0000000181541C90 
	
		// Constructors
		internal ControllerTemplateMap(Guid templateTypeGuid); // 0x0000000181541AC0-0x0000000181541BE0
		internal ControllerTemplateMap(Guid templateTypeGuid, int categoryId, int layoutId, int sourceMapId); // 0x0000000181541A70-0x0000000181541AC0
		static ControllerTemplateMap(); // 0x00000001803774A0-0x00000001803774B0
	
		// Methods
		public string ToXmlString(); // 0x00000001815418E0-0x0000000181541A70
		public string ToJsonString(); // 0x0000000181541750-0x00000001815418E0
		public ControllerMap ToControllerMap(Controller controller); // 0x0000000181540EA0-0x0000000181541750
		internal virtual void ExportDataToSerializedObject(SerializedObject serializedObject); // 0x000000018153F6E0-0x000000018153FFB0
		internal virtual void Import(SerializedObject serializedObject); // 0x0000000181540A50-0x0000000181540EA0
		private void Clear(); // 0x000000018153F680-0x000000018153F6E0
		private SerializedObject Export(); // 0x000000018153FFB0-0x0000000181540060
		internal void AddElementMap(ControllerTemplateActionElementMap elementMap); // 0x000000018153F5F0-0x000000018153F680
		internal static ControllerTemplateMap FromControllerMap(IControllerTemplate controllerTemplate, ControllerMap controllerMap); // 0x0000000181540060-0x0000000181540700
		public static ControllerTemplateMap FromXml(string xmlString); // 0x0000000181540930-0x0000000181540A50
		public static ControllerTemplateMap FromJson(string jsonString); // 0x0000000181540700-0x0000000181540840
		private static ControllerTemplateMap FromSerializedData(SerializedObject serializedObject); // 0x0000000181540840-0x0000000181540930
	}
}
