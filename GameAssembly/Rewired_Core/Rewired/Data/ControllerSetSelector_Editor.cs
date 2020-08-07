/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Rewired;
using Rewired.Utils.Attributes;
using Rewired.Utils.Interfaces;
using Rewired.Utils.Libraries.TinyJson;
using UnityEngine;

// Image 51: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5871-7113

namespace Rewired.Data
{
	[Serializable]
	[Preserve] // 0x00000001801CDAD0-0x00000001801CDAE0
	public sealed class ControllerSetSelector_Editor : IDeepCloneable // TypeDefIndex: 6661
	{
		// Fields
		[Serialize] // 0x00000001801CDDD0-0x00000001801CDE00
		[SerializeField] // 0x00000001801CDDD0-0x00000001801CDE00
		private ControllerSetSelector.Type _type; // 0x10
		[Serialize] // 0x00000001801CDDD0-0x00000001801CDE00
		[SerializeField] // 0x00000001801CDDD0-0x00000001801CDE00
		private ControllerType _controllerType; // 0x14
		[Serialize] // 0x00000001801CDDD0-0x00000001801CDE00
		[SerializeField] // 0x00000001801CDDD0-0x00000001801CDE00
		private string _hardwareTypeGuidString; // 0x18
		[Serialize] // 0x00000001801CDDD0-0x00000001801CDE00
		[SerializeField] // 0x00000001801CDDD0-0x00000001801CDE00
		private string _hardwareIdentifier; // 0x20
		[Serialize] // 0x00000001801CDDD0-0x00000001801CDE00
		[SerializeField] // 0x00000001801CDDD0-0x00000001801CDE00
		private string _controllerTemplateTypeGuidString; // 0x28
		[Serialize] // 0x00000001801CDDD0-0x00000001801CDE00
		[SerializeField] // 0x00000001801CDDD0-0x00000001801CDE00
		private string _deviceInstanceGuidString; // 0x30
		[Serialize] // 0x00000001801CDDD0-0x00000001801CDE00
		[SerializeField] // 0x00000001801CDDD0-0x00000001801CDE00
		private int _customControllerSourceId; // 0x38
		[Serialize] // 0x00000001801CDDD0-0x00000001801CDE00
		[SerializeField] // 0x00000001801CDDD0-0x00000001801CDE00
		private int _controllerId; // 0x3C
	
		// Properties
		public ControllerSetSelector.Type type { get; set; } // 0x0000000180387590-0x0000000180387930 0x00000001803FEB70-0x00000001803FEB80
		public ControllerType controllerType { get; set; } // 0x00000001803FD2F0-0x00000001803FD300 0x00000001803FD620-0x00000001803FD630
		public Guid hardwareTypeGuid { get; set; } // 0x0000000180D82A10-0x0000000180D82A90 0x0000000180D82AD0-0x0000000180D82AF0
		public string hardwareTypeGuidString { get; set; } // 0x0000000180372430-0x0000000180372440 0x0000000180379F30-0x0000000180379F40
		public string hardwareIdentifier { get; set; } // 0x0000000180374AF0-0x0000000180374B00 0x00000001803F70C0-0x00000001803F70D0
		public Guid controllerTemplateTypeGuid { get; set; } // 0x0000000180D82910-0x0000000180D82990 0x0000000180D82A90-0x0000000180D82AB0
		public string controllerTemplateTypeGuidString { get; set; } // 0x00000001803745B0-0x00000001803745C0 0x00000001803FA0C0-0x00000001803FA0D0
		public Guid deviceInstanceGuid { get; set; } // 0x0000000180D82990-0x0000000180D82A10 0x0000000180D82AB0-0x0000000180D82AD0
		public string deviceInstanceGuidString { get; set; } // 0x00000001803745C0-0x00000001803745D0 0x00000001803FA0A0-0x00000001803FA0B0
		public int controllerId { get; set; } // 0x000000018099EBE0-0x000000018099EBF0 0x000000018041B1A0-0x000000018041B1B0
		public int customControllerSourceId { get; set; } // 0x000000018057D1C0-0x000000018057D1D0 0x000000018041B190-0x000000018041B1A0
	
		// Constructors
		internal ControllerSetSelector_Editor(ControllerSetSelector.Type type); // 0x0000000180D82590-0x0000000180D82630
		public ControllerSetSelector_Editor(); // 0x0000000180D82630-0x0000000180D826C0
		public ControllerSetSelector_Editor(ControllerSetSelector_Editor source); // 0x0000000180D824E0-0x0000000180D82590
	
		// Methods
		internal ControllerSetSelector dNByhzaKGVAtFdCyWsrRhAiGeiO(); // 0x0000000180D826C0-0x0000000180D82910
		object IDeepCloneable.DeepClone(); // 0x0000000180D82400-0x0000000180D824E0
	}
}
