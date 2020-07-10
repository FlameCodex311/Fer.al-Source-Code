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

// Image 50: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5712-6954

namespace Rewired
{
	[Serializable]
	[Preserve] // 0x00000001800B36B0-0x00000001800B36C0
	public sealed class ControllerSetSelector : ISerializationCallbackReceiver, IDeepCloneable // TypeDefIndex: 5735
	{
		// Fields
		[Serialize] // 0x0000000180132870-0x00000001801328C0
		[SerializeField] // 0x0000000180132870-0x00000001801328C0
		private Type _type; // 0x10
		[Serialize] // 0x0000000180132B20-0x0000000180132B60
		[SerializeField] // 0x0000000180132B20-0x0000000180132B60
		private ControllerType _controllerType; // 0x14
		[Serialize] // 0x0000000180132E80-0x0000000180132ED0
		[SerializeField] // 0x0000000180132E80-0x0000000180132ED0
		private string _guid; // 0x18
		[Serialize] // 0x0000000180133140-0x0000000180133180
		[SerializeField] // 0x0000000180133140-0x0000000180133180
		private string _hardwareIdentifier; // 0x20
		[Serialize] // 0x00000001801334B0-0x00000001801334F0
		[SerializeField] // 0x00000001801334B0-0x00000001801334F0
		private int _controllerId; // 0x28
		[NonSerialized]
		private Guid NvWLGZtyeEinjBuNjWkUeuGUEIe; // 0x2C
	
		// Properties
		internal bool hasControllerType { get; } // 0x0000000180A096A0-0x0000000180A096B0 
		public Type type { get; set; } // 0x000000018036CFF0-0x000000018036D000 0x0000000180A098D0-0x0000000180A09990
		public ControllerType controllerType { get; set; } // 0x0000000180372360-0x0000000180372370 0x000000018036C6F0-0x000000018036C700
		public Guid hardwareTypeGuid { get; set; } // 0x0000000180A09610-0x0000000180A096A0 0x0000000180A09830-0x0000000180A098D0
		public string hardwareIdentifier { get; set; } // 0x000000018036AC70-0x000000018036AC80 0x000000018036AC90-0x000000018036ACA0
		public Guid controllerTemplateTypeGuid { get; set; } // 0x0000000180A094F0-0x0000000180A09580 0x0000000180A096B0-0x0000000180A09770
		public Guid deviceInstanceGuid { get; set; } // 0x0000000180A09580-0x0000000180A09610 0x0000000180A09770-0x0000000180A09830
		public int controllerId { get; set; } // 0x000000018038E0E0-0x000000018038E0F0 0x000000018036B790-0x000000018036B7A0
	
		// Nested types
		public enum Type // TypeDefIndex: 5736
		{
			All = 0,
			ControllerType = 1,
			HardwareType = 2,
			ControllerTemplateType = 3,
			PersistentControllerInstance = 4,
			SessionControllerInstance = 5
		}
	
		// Constructors
		internal ControllerSetSelector(Type type); // 0x0000000180A09260-0x0000000180A092C0
		public ControllerSetSelector(); // 0x0000000180A09370-0x0000000180A093B0
		public ControllerSetSelector(ControllerSetSelector source); // 0x0000000180A093B0-0x0000000180A094F0
		internal ControllerSetSelector(Type type, ControllerType controllerType, string guid, string hardwareIdentifier, int controllerId); // 0x0000000180A092C0-0x0000000180A09370
	
		// Methods
		public bool Matches(Controller controller); // 0x0000000180A07F80-0x0000000180A081E0
		public override string ToString(); // 0x0000000180A09020-0x0000000180A091F0
		private void OzyaXpIvdqNRIklPPtVWlcUINUO(); // 0x0000000180A081E0-0x0000000180A08260
		void ISerializationCallbackReceiver.OnAfterDeserialize(); // 0x0000000180A091F0-0x0000000180A09260
		void ISerializationCallbackReceiver.OnBeforeSerialize(); // 0x00000001803581E0-0x00000001803581F0
		object IDeepCloneable.DeepClone(); // 0x0000000180A08260-0x0000000180A083D0
		public static ControllerSetSelector SelectAll(); // 0x0000000180A083D0-0x0000000180A08450
		public static ControllerSetSelector SelectControllerType(ControllerType controllerType); // 0x0000000180A087E0-0x0000000180A08860
		public static ControllerSetSelector SelectHardwareType(ControllerType controllerType, Guid hardwareTypeGuid, string hardwareIdentifier); // 0x0000000180A08860-0x0000000180A089B0
		public static ControllerSetSelector SelectHardwareType(Controller controller); // 0x0000000180A089B0-0x0000000180A08B80
		public static ControllerSetSelector SelectControllerTemplateType(ControllerType controllerType, Guid controllerTemplateTypeGuid); // 0x0000000180A08450-0x0000000180A085A0
		public static ControllerSetSelector SelectControllerTemplateType(IControllerTemplate controllerTemplate); // 0x0000000180A085A0-0x0000000180A087E0
		public static ControllerSetSelector SelectPersistentControllerInstance(ControllerType controllerType, Guid deviceInstanceGuid); // 0x0000000180A08B80-0x0000000180A08CD0
		public static ControllerSetSelector SelectPersistentControllerInstance(Controller controller); // 0x0000000180A08CD0-0x0000000180A08E80
		public static ControllerSetSelector SelectSessionControllerInstance(ControllerType controllerType, int controllerId); // 0x0000000180A08E80-0x0000000180A08F20
		public static ControllerSetSelector SelectSessionControllerInstance(Controller controller); // 0x0000000180A08F20-0x0000000180A09020
	}
}
