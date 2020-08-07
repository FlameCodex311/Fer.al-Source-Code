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

// Image 51: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5871-7113

namespace Rewired.Data.Mapping
{
	public sealed class HardwareJoystickTemplateMap : HardwareControllerTemplateMap, IHardwareControllerMap, IHardwareControllerMap_Internal, IHardwareControllerTemplateMap, IHardwareControllerTemplateMap_Internal // TypeDefIndex: 6395
	{
		// Fields
		[CustomObfuscation] // 0x00000001801D00E0-0x00000001801D0120
		[SerializeField] // 0x00000001801D00E0-0x00000001801D0120
		private string controllerName; // 0x18
		[CustomObfuscation] // 0x00000001801D1070-0x00000001801D10B0
		[SerializeField] // 0x00000001801D1070-0x00000001801D10B0
		private string description; // 0x20
		[CustomObfuscation] // 0x00000001801D00E0-0x00000001801D0120
		[SerializeField] // 0x00000001801D00E0-0x00000001801D0120
		private string templateGuid; // 0x28
		[CustomObfuscation] // 0x00000001801D1070-0x00000001801D10B0
		[SerializeField] // 0x00000001801D1070-0x00000001801D10B0
		private string className; // 0x30
		[CustomObfuscation] // 0x00000001801D1070-0x00000001801D10B0
		[SerializeField] // 0x00000001801D1070-0x00000001801D10B0
		private ControllerTemplateElementIdentifier_Editor[] elementIdentifiers; // 0x38
		[CustomObfuscation] // 0x00000001801D1070-0x00000001801D10B0
		[SerializeField] // 0x00000001801D1070-0x00000001801D10B0
		private List<Entry> joysticks; // 0x40
		[CustomObfuscation] // 0x00000001801D1070-0x00000001801D10B0
		[SerializeField] // 0x00000001801D1070-0x00000001801D10B0
		private SpecialElementEntry[] specialElements; // 0x48
		[CustomObfuscation] // 0x00000001801D00E0-0x00000001801D0120
		[SerializeField] // 0x00000001801D00E0-0x00000001801D0120
		private int elementIdentifierIdCounter; // 0x50
		[CustomObfuscation] // 0x00000001801D1070-0x00000001801D10B0
		[SerializeField] // 0x00000001801D1070-0x00000001801D10B0
		private int joystickIdCounter; // 0x54
	
		// Properties
		public override Guid Guid { get; } // 0x00000001805F1A60-0x00000001805F1AE0 
		public string ControllerName { get; } // 0x0000000180372430-0x0000000180372440 
		public string ClassName { get; } // 0x00000001803745C0-0x00000001803745D0 
		public IEnumerable<ControllerTemplateElementIdentifier> ElementIdentifiers { get; } // 0x00000001805F19E0-0x00000001805F1A60 
		IEnumerable<IControllerElementIdentifierCommon_Internal> IHardwareControllerMap_Internal.ElementIdentifiers { get; } // 0x00000001805F1170-0x00000001805F11F0 
		string IHardwareControllerTemplateMap_Internal.name { get; } // 0x0000000180372430-0x0000000180372440 
		Guid IHardwareControllerTemplateMap_Internal.typeGuid { get; } // 0x00000001805F1960-0x00000001805F1990 
	
		// Nested types
		[Serializable]
		public sealed class Entry // TypeDefIndex: 6396
		{
			// Fields
			public int id; // 0x10
			public string name; // 0x18
			public string joystickGuid; // 0x20
			public string fileGuid; // 0x28
			public List<ElementIdentifierMap> elementIdentifierMappings; // 0x30
	
			// Properties
			public Guid JoystickGuid { get; } // 0x00000001805EFAC0-0x00000001805EFBC0 
	
			// Constructors
			public Entry(); // 0x0000000180373240-0x0000000180373250
	
			// Methods
			public int GetJoystickElementId(int templateElementId); // 0x00000001805EF800-0x00000001805EF960
			public int GetTemplateElementId(int joystickElementId); // 0x00000001805EF960-0x00000001805EFAC0
			public ElementIdentifierMap GetElementIdentifierMap(int templateId); // 0x00000001805EF550-0x00000001805EF690
			public void GetElementIdentifierMaps(int templateId, List<ElementIdentifierMap> results); // 0x00000001805EF690-0x00000001805EF800
		}
	
		[Serializable]
		public sealed class ElementIdentifierMap // TypeDefIndex: 6397
		{
			// Fields
			public int templateId; // 0x10
			public int joystickId; // 0x14
			public int joystickId2; // 0x18
			public bool splitAxis; // 0x1C
	
			// Constructors
			public ElementIdentifierMap(); // 0x0000000180373240-0x0000000180373250
		}
	
		[Serializable]
		public sealed class SpecialElementEntry : IControllerTemplateMapSpecialElement_Internal // TypeDefIndex: 6398
		{
			// Fields
			public int elementIdentifierId; // 0x10
			public string data; // 0x18
	
			// Constructors
			public SpecialElementEntry(); // 0x00000001805FC900-0x00000001805FC910
	
			// Methods
			T IControllerTemplateMapSpecialElement_Internal.GetMapping<T>()
				where T : ControllerTemplateSpecialElementMapping;
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class LjFBAxwllMBIqiXFgJiToWWhvuv : IEnumerable<ControllerTemplateElementIdentifier>, IEnumerator<ControllerTemplateElementIdentifier> // TypeDefIndex: 6399
		{
			// Fields
			private ControllerTemplateElementIdentifier aSrFEaALHwhGTdXfCdeUqgbwaZGO; // 0x10
			private int eLrUhJFgzEZElCzdKvcrgOLXLvL; // 0x18
			private int RQaeFqcJnaOYpZSBxtfUkVOjfOo; // 0x1C
			public HardwareJoystickTemplateMap gKPmvKLRxdGbmXiMfUeDjGbezUo; // 0x20
			public int ZKnOmfdBGxPCzuiOaEmmaNwByyN; // 0x28
	
			// Properties
			ControllerTemplateElementIdentifier KDUzpCWTxikDogxmOXkIdwAfNqc { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372440-0x0000000180372450 
			object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372440-0x0000000180372450 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public LjFBAxwllMBIqiXFgJiToWWhvuv(int <>1__state); // 0x00000001805EDEC0-0x00000001805EDF10
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			IEnumerator<ControllerTemplateElementIdentifier> IEnumerable<ControllerTemplateElementIdentifier>.GetEnumerator(); // 0x00000001805F33B0-0x00000001805F34C0
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			IEnumerator IEnumerable.GetEnumerator(); // 0x00000001805F33B0-0x00000001805F34C0
			private bool MoveNext(); // 0x00000001805F3270-0x00000001805F33B0
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x00000001805F34C0-0x00000001805F3510
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class LYLnTiTZDJSGXrXMuoKmGbRamm : IEnumerable<IControllerElementIdentifierCommon_Internal>, IEnumerator<IControllerElementIdentifierCommon_Internal> // TypeDefIndex: 6400
		{
			// Fields
			private IControllerElementIdentifierCommon_Internal aSrFEaALHwhGTdXfCdeUqgbwaZGO; // 0x10
			private int eLrUhJFgzEZElCzdKvcrgOLXLvL; // 0x18
			private int RQaeFqcJnaOYpZSBxtfUkVOjfOo; // 0x1C
			public HardwareJoystickTemplateMap gKPmvKLRxdGbmXiMfUeDjGbezUo; // 0x20
			public int PjYtuicjXGalARRYfcvVGxZVBdI; // 0x28
	
			// Properties
			IControllerElementIdentifierCommon_Internal kPWOkKKCGAiizbmYmSqjRLfSZWGa { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372440-0x0000000180372450 
			object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372440-0x0000000180372450 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public LYLnTiTZDJSGXrXMuoKmGbRamm(int <>1__state); // 0x00000001805EDEC0-0x00000001805EDF10
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			IEnumerator<IControllerElementIdentifierCommon_Internal> IEnumerable<IControllerElementIdentifierCommon_Internal>.GetEnumerator(); // 0x00000001805F3130-0x00000001805F3220
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			IEnumerator IEnumerable.GetEnumerator(); // 0x00000001805F3130-0x00000001805F3220
			private bool MoveNext(); // 0x00000001805F2FE0-0x00000001805F3130
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x00000001805F3220-0x00000001805F3270
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		}
	
		// Constructors
		public HardwareJoystickTemplateMap(); // 0x00000001805F1990-0x00000001805F19E0
	
		// Methods
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		public ControllerTemplateElementIdentifier GetElementIdentifier(int id); // 0x00000001805F00B0-0x00000001805F0110
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		public bool ContainsElementIdentifier(int id); // 0x00000001805EFC70-0x00000001805EFC90
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		public string[] GetElementIdentifierNames(); // 0x00000001805EFD80-0x00000001805EFEF0
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		public int[] GetElementIdentifierIds(); // 0x00000001805EFC90-0x00000001805EFD80
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		internal string[] GetElementIdentifierScriptingNames(bool useAlternate); // 0x00000001805EFEF0-0x00000001805F00B0
		public int GetMappableElementIdentifierInfo(out string[] names, out int[] ids); // 0x00000001805F08D0-0x00000001805F0CF0
		public int GetNonMappableElementIdentifierInfo(out string[] names, out int[] ids); // 0x00000001805F0CF0-0x00000001805F1110
		public string[] GetJoystickNames(); // 0x00000001805F0740-0x00000001805F08D0
		public int[] GetJoystickIds(); // 0x00000001805F0610-0x00000001805F0740
		public Guid GetJoystickGuid(int joystickId); // 0x00000001805F0270-0x00000001805F0450
		public int GetJoystickId(Guid guid); // 0x00000001805F0450-0x00000001805F0610
		public string GetJoystickFileGuidString(int joystickId); // 0x00000001805F0110-0x00000001805F0270
		internal bool iXNzOHrDumSJyUklTiUZNlpYydh(ControllerMap_Editor param_0000d270, HardwareJoystickMap param_0000d271, Guid param_0000d272, out string param_0000d273); // 0x00000001805F1AE0-0x00000001805F26E0
		internal ControllerTemplateElementIdentifier mNzVFAiBNOihmCachBdGDRiTVUg(Guid param_0000d274, int param_0000d275); // 0x00000001805F26E0-0x00000001805F2B60
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		internal SpecialElementEntry[] GetSpecialElementsOrig(); // 0x00000001803743E0-0x00000001803743F0
		private Entry uDGNCWGQfmuhvDHBSxGtBouWbNb(Guid param_0000d276); // 0x00000001805F2B60-0x00000001805F2D00
		private int BjoajNIhtXiBdWdIfIGbFKqwmvy(int param_0000d277); // 0x00000001805EFBC0-0x00000001805EFC70
		IControllerElementIdentifierCommon_Internal IHardwareControllerMap_Internal.GetElementIdentifier(int param_0000d278); // 0x00000001805F1110-0x00000001805F1170
		int IHardwareControllerTemplateMap_Internal.GetElementIdentifierCount(); // 0x00000001805F1850-0x00000001805F1860
		IControllerTemplateElementIdentifier IHardwareControllerTemplateMap_Internal.GetTemplateElementIdentifier(int param_0000d279); // 0x00000001805F1920-0x00000001805F1960
		IControllerTemplateElementIdentifier IHardwareControllerTemplateMap_Internal.GetTemplateElementIdentifierById(int param_0000d27a); // 0x00000001805F1110-0x00000001805F1170
		IControllerTemplateMapSpecialElement_Internal IHardwareControllerTemplateMap_Internal.GetSpecialTemplateElementByElementIdentifierId(int param_0000d27b); // 0x00000001805F1860-0x00000001805F1920
		oDhSVhqolYnpfNXmoDZvnEklacS IHardwareControllerTemplateMap_Internal.GetAxisTarget(Controller param_0000d27c, int param_0000d27d); // 0x00000001805F11F0-0x00000001805F1570
		oDhSVhqolYnpfNXmoDZvnEklacS IHardwareControllerTemplateMap_Internal.GetButtonTarget(Controller param_0000d27e, int param_0000d27f); // 0x00000001805F1570-0x00000001805F1850
	}
}
