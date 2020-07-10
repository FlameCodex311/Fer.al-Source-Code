/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Rewired;
using Rewired.Data;
using Rewired.Interfaces;
using UnityEngine;

// Image 50: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5712-6954

namespace Rewired.Data.Mapping
{
	public sealed class HardwareJoystickTemplateMap : HardwareControllerTemplateMap, IHardwareControllerMap, IHardwareControllerMap_Internal, IHardwareControllerTemplateMap, IHardwareControllerTemplateMap_Internal // TypeDefIndex: 6236
	{
		// Fields
		[CustomObfuscation] // 0x00000001800C3DD0-0x00000001800C3E10
		[SerializeField] // 0x00000001800C3DD0-0x00000001800C3E10
		private string controllerName; // 0x18
		[CustomObfuscation] // 0x00000001800C5270-0x00000001800C52B0
		[SerializeField] // 0x00000001800C5270-0x00000001800C52B0
		private string description; // 0x20
		[CustomObfuscation] // 0x00000001800C3DD0-0x00000001800C3E10
		[SerializeField] // 0x00000001800C3DD0-0x00000001800C3E10
		private string templateGuid; // 0x28
		[CustomObfuscation] // 0x00000001800C5270-0x00000001800C52B0
		[SerializeField] // 0x00000001800C5270-0x00000001800C52B0
		private string className; // 0x30
		[CustomObfuscation] // 0x00000001800C5270-0x00000001800C52B0
		[SerializeField] // 0x00000001800C5270-0x00000001800C52B0
		private ControllerTemplateElementIdentifier_Editor[] elementIdentifiers; // 0x38
		[CustomObfuscation] // 0x00000001800C5270-0x00000001800C52B0
		[SerializeField] // 0x00000001800C5270-0x00000001800C52B0
		private List<Entry> joysticks; // 0x40
		[CustomObfuscation] // 0x00000001800C5270-0x00000001800C52B0
		[SerializeField] // 0x00000001800C5270-0x00000001800C52B0
		private SpecialElementEntry[] specialElements; // 0x48
		[CustomObfuscation] // 0x00000001800C3DD0-0x00000001800C3E10
		[SerializeField] // 0x00000001800C3DD0-0x00000001800C3E10
		private int elementIdentifierIdCounter; // 0x50
		[CustomObfuscation] // 0x00000001800C5270-0x00000001800C52B0
		[SerializeField] // 0x00000001800C5270-0x00000001800C52B0
		private int joystickIdCounter; // 0x54
	
		// Properties
		public override Guid Guid { get; } // 0x00000001803977B0-0x0000000180397830 
		public string ControllerName { get; } // 0x000000018038B150-0x000000018038B160 
		public string ClassName { get; } // 0x0000000180397720-0x0000000180397730 
		public IEnumerable<ControllerTemplateElementIdentifier> ElementIdentifiers { get; } // 0x0000000180397730-0x00000001803977B0 
		IEnumerable<IControllerElementIdentifierCommon_Internal> IHardwareControllerMap_Internal.ElementIdentifiers { get; } // 0x0000000180396E90-0x0000000180396F10 
		string IHardwareControllerTemplateMap_Internal.name { get; } // 0x000000018038B150-0x000000018038B160 
		Guid IHardwareControllerTemplateMap_Internal.typeGuid { get; } // 0x00000001803976A0-0x00000001803976D0 
	
		// Nested types
		[Serializable]
		public sealed class Entry // TypeDefIndex: 6237
		{
			// Fields
			public int id; // 0x10
			public string name; // 0x18
			public string joystickGuid; // 0x20
			public string fileGuid; // 0x28
			public List<ElementIdentifierMap> elementIdentifierMappings; // 0x30
	
			// Properties
			public Guid JoystickGuid { get; } // 0x0000000180395720-0x0000000180395820 
	
			// Constructors
			public Entry(); // 0x000000018036B6C0-0x000000018036B6D0
	
			// Methods
			public int GetJoystickElementId(int templateElementId); // 0x0000000180395460-0x00000001803955C0
			public int GetTemplateElementId(int joystickElementId); // 0x00000001803955C0-0x0000000180395720
			public ElementIdentifierMap GetElementIdentifierMap(int templateId); // 0x00000001803951B0-0x00000001803952F0
			public void GetElementIdentifierMaps(int templateId, List<ElementIdentifierMap> results); // 0x00000001803952F0-0x0000000180395460
		}
	
		[Serializable]
		public sealed class ElementIdentifierMap // TypeDefIndex: 6238
		{
			// Fields
			public int templateId; // 0x10
			public int joystickId; // 0x14
			public int joystickId2; // 0x18
			public bool splitAxis; // 0x1C
	
			// Constructors
			public ElementIdentifierMap(); // 0x000000018036B6C0-0x000000018036B6D0
		}
	
		[Serializable]
		public sealed class SpecialElementEntry : IControllerTemplateMapSpecialElement_Internal // TypeDefIndex: 6239
		{
			// Fields
			public int elementIdentifierId; // 0x10
			public string data; // 0x18
	
			// Constructors
			public SpecialElementEntry(); // 0x00000001803A2BC0-0x00000001803A2BD0
	
			// Methods
			T IControllerTemplateMapSpecialElement_Internal.GetMapping<T>()
				where T : ControllerTemplateSpecialElementMapping;
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class LjFBAxwllMBIqiXFgJiToWWhvuv : IEnumerable<ControllerTemplateElementIdentifier>, IEnumerator<ControllerTemplateElementIdentifier> // TypeDefIndex: 6240
		{
			// Fields
			private ControllerTemplateElementIdentifier aSrFEaALHwhGTdXfCdeUqgbwaZGO; // 0x10
			private int eLrUhJFgzEZElCzdKvcrgOLXLvL; // 0x18
			private int RQaeFqcJnaOYpZSBxtfUkVOjfOo; // 0x1C
			public HardwareJoystickTemplateMap gKPmvKLRxdGbmXiMfUeDjGbezUo; // 0x20
			public int ZKnOmfdBGxPCzuiOaEmmaNwByyN; // 0x28
	
			// Properties
			ControllerTemplateElementIdentifier KDUzpCWTxikDogxmOXkIdwAfNqc { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018036AC80-0x000000018036AC90 
			object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018036AC80-0x000000018036AC90 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public LjFBAxwllMBIqiXFgJiToWWhvuv(int <>1__state); // 0x0000000180393A20-0x0000000180393A70
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			IEnumerator<ControllerTemplateElementIdentifier> IEnumerable<ControllerTemplateElementIdentifier>.GetEnumerator(); // 0x00000001803991A0-0x00000001803992C0
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			IEnumerator IEnumerable.GetEnumerator(); // 0x00000001803991A0-0x00000001803992C0
			private bool MoveNext(); // 0x0000000180399050-0x00000001803991A0
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x00000001803992C0-0x0000000180399310
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class LYLnTiTZDJSGXrXMuoKmGbRamm : IEnumerable<IControllerElementIdentifierCommon_Internal>, IEnumerator<IControllerElementIdentifierCommon_Internal> // TypeDefIndex: 6241
		{
			// Fields
			private IControllerElementIdentifierCommon_Internal aSrFEaALHwhGTdXfCdeUqgbwaZGO; // 0x10
			private int eLrUhJFgzEZElCzdKvcrgOLXLvL; // 0x18
			private int RQaeFqcJnaOYpZSBxtfUkVOjfOo; // 0x1C
			public HardwareJoystickTemplateMap gKPmvKLRxdGbmXiMfUeDjGbezUo; // 0x20
			public int PjYtuicjXGalARRYfcvVGxZVBdI; // 0x28
	
			// Properties
			IControllerElementIdentifierCommon_Internal kPWOkKKCGAiizbmYmSqjRLfSZWGa { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018036AC80-0x000000018036AC90 
			object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018036AC80-0x000000018036AC90 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public LYLnTiTZDJSGXrXMuoKmGbRamm(int <>1__state); // 0x0000000180393A20-0x0000000180393A70
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			IEnumerator<IControllerElementIdentifierCommon_Internal> IEnumerable<IControllerElementIdentifierCommon_Internal>.GetEnumerator(); // 0x0000000180398F00-0x0000000180399000
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			IEnumerator IEnumerable.GetEnumerator(); // 0x0000000180398F00-0x0000000180399000
			private bool MoveNext(); // 0x0000000180398DA0-0x0000000180398F00
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x0000000180399000-0x0000000180399050
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		}
	
		// Constructors
		public HardwareJoystickTemplateMap(); // 0x00000001803976D0-0x0000000180397720
	
		// Methods
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		public ControllerTemplateElementIdentifier GetElementIdentifier(int id); // 0x0000000180395D50-0x0000000180395DC0
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		public bool ContainsElementIdentifier(int id); // 0x00000001803958D0-0x00000001803958F0
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		public string[] GetElementIdentifierNames(); // 0x00000001803959F0-0x0000000180395B70
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		public int[] GetElementIdentifierIds(); // 0x00000001803958F0-0x00000001803959F0
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		internal string[] GetElementIdentifierScriptingNames(bool useAlternate); // 0x0000000180395B70-0x0000000180395D50
		public int GetMappableElementIdentifierInfo(out string[] names, out int[] ids); // 0x00000001803965A0-0x00000001803969E0
		public int GetNonMappableElementIdentifierInfo(out string[] names, out int[] ids); // 0x00000001803969E0-0x0000000180396E20
		public string[] GetJoystickNames(); // 0x0000000180396400-0x00000001803965A0
		public int[] GetJoystickIds(); // 0x00000001803962D0-0x0000000180396400
		public Guid GetJoystickGuid(int joystickId); // 0x0000000180395F20-0x0000000180396100
		public int GetJoystickId(Guid guid); // 0x0000000180396100-0x00000001803962D0
		public string GetJoystickFileGuidString(int joystickId); // 0x0000000180395DC0-0x0000000180395F20
		internal bool iXNzOHrDumSJyUklTiUZNlpYydh(ControllerMap_Editor param_0000d000, HardwareJoystickMap param_0000d001, Guid param_0000d002, out string param_0000d003); // 0x0000000180397830-0x0000000180398480
		internal ControllerTemplateElementIdentifier mNzVFAiBNOihmCachBdGDRiTVUg(Guid param_0000d004, int param_0000d005); // 0x0000000180398480-0x0000000180398910
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		internal SpecialElementEntry[] GetSpecialElementsOrig(); // 0x0000000180369C40-0x0000000180369C50
		private Entry uDGNCWGQfmuhvDHBSxGtBouWbNb(Guid param_0000d006); // 0x0000000180398910-0x0000000180398AB0
		private int BjoajNIhtXiBdWdIfIGbFKqwmvy(int param_0000d007); // 0x0000000180395820-0x00000001803958D0
		IControllerElementIdentifierCommon_Internal IHardwareControllerMap_Internal.GetElementIdentifier(int param_0000d008); // 0x0000000180396E20-0x0000000180396E90
		int IHardwareControllerTemplateMap_Internal.GetElementIdentifierCount(); // 0x0000000180397580-0x0000000180397590
		IControllerTemplateElementIdentifier IHardwareControllerTemplateMap_Internal.GetTemplateElementIdentifier(int param_0000d009); // 0x0000000180397660-0x00000001803976A0
		IControllerTemplateElementIdentifier IHardwareControllerTemplateMap_Internal.GetTemplateElementIdentifierById(int param_0000d00a); // 0x0000000180396E20-0x0000000180396E90
		IControllerTemplateMapSpecialElement_Internal IHardwareControllerTemplateMap_Internal.GetSpecialTemplateElementByElementIdentifierId(int param_0000d00b); // 0x0000000180397590-0x0000000180397660
		oDhSVhqolYnpfNXmoDZvnEklacS IHardwareControllerTemplateMap_Internal.GetAxisTarget(Controller param_0000d00c, int param_0000d00d); // 0x0000000180396F10-0x00000001803972A0
		oDhSVhqolYnpfNXmoDZvnEklacS IHardwareControllerTemplateMap_Internal.GetButtonTarget(Controller param_0000d00e, int param_0000d00f); // 0x00000001803972A0-0x0000000180397580
	}
}
