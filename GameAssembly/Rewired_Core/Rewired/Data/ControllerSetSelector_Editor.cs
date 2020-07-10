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

// Image 50: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5712-6954

namespace Rewired.Data
{
	[Serializable]
	[Preserve] // 0x00000001800B36B0-0x00000001800B36C0
	public sealed class ControllerSetSelector_Editor : IDeepCloneable // TypeDefIndex: 6502
	{
		// Fields
		[Serialize] // 0x00000001800B4050-0x00000001800B4080
		[SerializeField] // 0x00000001800B4050-0x00000001800B4080
		private ControllerSetSelector.Type _type; // 0x10
		[Serialize] // 0x00000001800B4050-0x00000001800B4080
		[SerializeField] // 0x00000001800B4050-0x00000001800B4080
		private ControllerType _controllerType; // 0x14
		[Serialize] // 0x00000001800B4050-0x00000001800B4080
		[SerializeField] // 0x00000001800B4050-0x00000001800B4080
		private string _hardwareTypeGuidString; // 0x18
		[Serialize] // 0x00000001800B4050-0x00000001800B4080
		[SerializeField] // 0x00000001800B4050-0x00000001800B4080
		private string _hardwareIdentifier; // 0x20
		[Serialize] // 0x00000001800B4050-0x00000001800B4080
		[SerializeField] // 0x00000001800B4050-0x00000001800B4080
		private string _controllerTemplateTypeGuidString; // 0x28
		[Serialize] // 0x00000001800B4050-0x00000001800B4080
		[SerializeField] // 0x00000001800B4050-0x00000001800B4080
		private string _deviceInstanceGuidString; // 0x30
		[Serialize] // 0x00000001800B4050-0x00000001800B4080
		[SerializeField] // 0x00000001800B4050-0x00000001800B4080
		private int _customControllerSourceId; // 0x38
		[Serialize] // 0x00000001800B4050-0x00000001800B4080
		[SerializeField] // 0x00000001800B4050-0x00000001800B4080
		private int _controllerId; // 0x3C
	
		// Properties
		public ControllerSetSelector.Type type { get; set; } // 0x000000018036CFF0-0x000000018036D000 0x000000018037AA40-0x000000018037AA50
		public ControllerType controllerType { get; set; } // 0x0000000180372360-0x0000000180372370 0x000000018036C6F0-0x000000018036C700
		public Guid hardwareTypeGuid { get; set; } // 0x00000001805E3770-0x00000001805E37F0 0x00000001805E3830-0x00000001805E3850
		public string hardwareTypeGuidString { get; set; } // 0x000000018038B150-0x000000018038B160 0x000000018038B160-0x000000018038B170
		public string hardwareIdentifier { get; set; } // 0x000000018036AC70-0x000000018036AC80 0x000000018036AC90-0x000000018036ACA0
		public Guid controllerTemplateTypeGuid { get; set; } // 0x00000001805E3670-0x00000001805E36F0 0x00000001805E37F0-0x00000001805E3810
		public string controllerTemplateTypeGuidString { get; set; } // 0x0000000180369B60-0x0000000180369B70 0x0000000180422D30-0x0000000180422D40
		public Guid deviceInstanceGuid { get; set; } // 0x00000001805E36F0-0x00000001805E3770 0x00000001805E3810-0x00000001805E3830
		public string deviceInstanceGuidString { get; set; } // 0x0000000180397720-0x0000000180397730 0x00000001803A2800-0x00000001803A2810
		public int controllerId { get; set; } // 0x0000000180487DC0-0x0000000180487DD0 0x000000018036C630-0x000000018036C640
		public int customControllerSourceId { get; set; } // 0x00000001804999D0-0x00000001804999E0 0x000000018036C620-0x000000018036C630
	
		// Constructors
		internal ControllerSetSelector_Editor(ControllerSetSelector.Type type); // 0x00000001805E32F0-0x00000001805E3390
		public ControllerSetSelector_Editor(); // 0x00000001805E3390-0x00000001805E3420
		public ControllerSetSelector_Editor(ControllerSetSelector_Editor source); // 0x00000001805E3240-0x00000001805E32F0
	
		// Methods
		internal ControllerSetSelector dNByhzaKGVAtFdCyWsrRhAiGeiO(); // 0x00000001805E3420-0x00000001805E3670
		object IDeepCloneable.DeepClone(); // 0x00000001805E3160-0x00000001805E3240
	}
}
