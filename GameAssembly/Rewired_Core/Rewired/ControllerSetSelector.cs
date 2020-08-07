/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Rewired.Utils.Attributes;
using Rewired.Utils.Interfaces;
using Rewired.Utils.Libraries.TinyJson;
using UnityEngine;

// Image 51: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5871-7113

namespace Rewired
{
	[Serializable]
	[Preserve] // 0x00000001801CDAD0-0x00000001801CDAE0
	public sealed class ControllerSetSelector : ISerializationCallbackReceiver, IDeepCloneable // TypeDefIndex: 5894
	{
		// Fields
		[Serialize] // 0x00000001801CEF80-0x00000001801CEFD0
		[SerializeField] // 0x00000001801CEF80-0x00000001801CEFD0
		private Type _type; // 0x10
		[Serialize] // 0x00000001801CF1B0-0x00000001801CF1F0
		[SerializeField] // 0x00000001801CF1B0-0x00000001801CF1F0
		private ControllerType _controllerType; // 0x14
		[Serialize] // 0x00000001801CF350-0x00000001801CF3A0
		[SerializeField] // 0x00000001801CF350-0x00000001801CF3A0
		private string _guid; // 0x18
		[Serialize] // 0x00000001801CF6A0-0x00000001801CF6E0
		[SerializeField] // 0x00000001801CF6A0-0x00000001801CF6E0
		private string _hardwareIdentifier; // 0x20
		[Serialize] // 0x00000001801CF880-0x00000001801CF8C0
		[SerializeField] // 0x00000001801CF880-0x00000001801CF8C0
		private int _controllerId; // 0x28
		[NonSerialized]
		private Guid NvWLGZtyeEinjBuNjWkUeuGUEIe; // 0x2C
	
		// Properties
		internal bool hasControllerType { get; } // 0x00000001814A8C20-0x00000001814A8C30 
		public Type type { get; set; } // 0x0000000180387590-0x0000000180387930 0x00000001814A8E50-0x00000001814A8F10
		public ControllerType controllerType { get; set; } // 0x00000001803FD2F0-0x00000001803FD300 0x00000001803FD620-0x00000001803FD630
		public Guid hardwareTypeGuid { get; set; } // 0x00000001814A8B90-0x00000001814A8C20 0x00000001814A8DB0-0x00000001814A8E50
		public string hardwareIdentifier { get; set; } // 0x0000000180374AF0-0x0000000180374B00 0x00000001803F70C0-0x00000001803F70D0
		public Guid controllerTemplateTypeGuid { get; set; } // 0x00000001814A8A70-0x00000001814A8B00 0x00000001814A8C30-0x00000001814A8CF0
		public Guid deviceInstanceGuid { get; set; } // 0x00000001814A8B00-0x00000001814A8B90 0x00000001814A8CF0-0x00000001814A8DB0
		public int controllerId { get; set; } // 0x000000018043C680-0x000000018043C690 0x000000018041A3A0-0x000000018041A3B0
	
		// Nested types
		public enum Type // TypeDefIndex: 5895
		{
			All = 0,
			ControllerType = 1,
			HardwareType = 2,
			ControllerTemplateType = 3,
			PersistentControllerInstance = 4,
			SessionControllerInstance = 5
		}
	
		// Constructors
		internal ControllerSetSelector(Type type); // 0x00000001814A87F0-0x00000001814A8850
		public ControllerSetSelector(); // 0x00000001814A8900-0x00000001814A8940
		public ControllerSetSelector(ControllerSetSelector source); // 0x00000001814A8940-0x00000001814A8A70
		internal ControllerSetSelector(Type type, ControllerType controllerType, string guid, string hardwareIdentifier, int controllerId); // 0x00000001814A8850-0x00000001814A8900
	
		// Methods
		public bool Matches(Controller controller); // 0x00000001814A7520-0x00000001814A7780
		public override string ToString(); // 0x00000001814A85B0-0x00000001814A8780
		private void OzyaXpIvdqNRIklPPtVWlcUINUO(); // 0x00000001814A7780-0x00000001814A7800
		void ISerializationCallbackReceiver.OnAfterDeserialize(); // 0x00000001814A8780-0x00000001814A87F0
		void ISerializationCallbackReceiver.OnBeforeSerialize(); // 0x00000001803774A0-0x00000001803774B0
		object IDeepCloneable.DeepClone(); // 0x00000001814A7800-0x00000001814A7960
		public static ControllerSetSelector SelectAll(); // 0x00000001814A7960-0x00000001814A79E0
		public static ControllerSetSelector SelectControllerType(ControllerType controllerType); // 0x00000001814A7D70-0x00000001814A7DF0
		public static ControllerSetSelector SelectHardwareType(ControllerType controllerType, Guid hardwareTypeGuid, string hardwareIdentifier); // 0x00000001814A7DF0-0x00000001814A7F40
		public static ControllerSetSelector SelectHardwareType(Controller controller); // 0x00000001814A7F40-0x00000001814A8110
		public static ControllerSetSelector SelectControllerTemplateType(ControllerType controllerType, Guid controllerTemplateTypeGuid); // 0x00000001814A79E0-0x00000001814A7B30
		public static ControllerSetSelector SelectControllerTemplateType(IControllerTemplate controllerTemplate); // 0x00000001814A7B30-0x00000001814A7D70
		public static ControllerSetSelector SelectPersistentControllerInstance(ControllerType controllerType, Guid deviceInstanceGuid); // 0x00000001814A8110-0x00000001814A8260
		public static ControllerSetSelector SelectPersistentControllerInstance(Controller controller); // 0x00000001814A8260-0x00000001814A8410
		public static ControllerSetSelector SelectSessionControllerInstance(ControllerType controllerType, int controllerId); // 0x00000001814A8410-0x00000001814A84B0
		public static ControllerSetSelector SelectSessionControllerInstance(Controller controller); // 0x00000001814A84B0-0x00000001814A85B0
	}
}
