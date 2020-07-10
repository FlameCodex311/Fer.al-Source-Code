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

// Image 50: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5712-6954

namespace Rewired
{
	public class ControllerTemplateMap // TypeDefIndex: 5988
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
		public int id { get; } // 0x0000000180A8CAB0-0x0000000180A8CB50 
		public Guid templateTypeGuid { get; } // 0x0000000180A8CBF0-0x0000000180A8CCD0 
		public bool enabled { get; set; } // 0x0000000180A8CA10-0x0000000180A8CAB0 0x000000018044E330-0x000000018044E340
		public int categoryId { get; internal set; } // 0x0000000180A8C970-0x0000000180A8CA10 0x000000018036C630-0x000000018036C640
		public int layoutId { get; internal set; } // 0x0000000180A8CB50-0x0000000180A8CBF0 0x00000001804D0BC0-0x00000001804D0BD0
		public IList<ControllerTemplateActionElementMap> ElementMaps { get; } // 0x0000000180A8C8C0-0x0000000180A8C970 
	
		// Constructors
		internal ControllerTemplateMap(Guid templateTypeGuid); // 0x0000000180A8C7A0-0x0000000180A8C8C0
		internal ControllerTemplateMap(Guid templateTypeGuid, int categoryId, int layoutId, int sourceMapId); // 0x0000000180A8C750-0x0000000180A8C7A0
		static ControllerTemplateMap(); // 0x00000001803581E0-0x00000001803581F0
	
		// Methods
		public string ToXmlString(); // 0x0000000180A8C5C0-0x0000000180A8C750
		public string ToJsonString(); // 0x0000000180A8C430-0x0000000180A8C5C0
		public ControllerMap ToControllerMap(Controller controller); // 0x0000000180A8BB50-0x0000000180A8C430
		internal virtual void ExportDataToSerializedObject(SerializedObject serializedObject); // 0x0000000180A8A2F0-0x0000000180A8AC20
		internal virtual void Import(SerializedObject serializedObject); // 0x0000000180A8B6F0-0x0000000180A8BB50
		private void Clear(); // 0x0000000180A8A290-0x0000000180A8A2F0
		private SerializedObject Export(); // 0x0000000180A8AC20-0x0000000180A8ACD0
		internal void AddElementMap(ControllerTemplateActionElementMap elementMap); // 0x0000000180A8A200-0x0000000180A8A290
		internal static ControllerTemplateMap FromControllerMap(IControllerTemplate controllerTemplate, ControllerMap controllerMap); // 0x0000000180A8ACD0-0x0000000180A8B390
		public static ControllerTemplateMap FromXml(string xmlString); // 0x0000000180A8B5D0-0x0000000180A8B6F0
		public static ControllerTemplateMap FromJson(string jsonString); // 0x0000000180A8B390-0x0000000180A8B4D0
		private static ControllerTemplateMap FromSerializedData(SerializedObject serializedObject); // 0x0000000180A8B4D0-0x0000000180A8B5D0
	}
}
