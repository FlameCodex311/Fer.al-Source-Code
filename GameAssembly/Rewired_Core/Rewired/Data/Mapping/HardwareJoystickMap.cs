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
using Rewired.Interfaces;
using Rewired.Platforms;
using Rewired.Utils.Interfaces;
using UnityEngine;

// Image 51: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5871-7113

namespace Rewired.Data.Mapping
{
	[CustomClassObfuscation] // 0x0000000180207920-0x0000000180207950
	public sealed class HardwareJoystickMap : ScriptableObject, IHardwareControllerMap, IHardwareControllerMap_Internal // TypeDefIndex: 6217
	{
		// Fields
		[CustomObfuscation] // 0x00000001801D00E0-0x00000001801D0120
		[SerializeField] // 0x00000001801D00E0-0x00000001801D0120
		private string controllerName; // 0x18
		[CustomObfuscation] // 0x00000001801D00E0-0x00000001801D0120
		[SerializeField] // 0x00000001801D00E0-0x00000001801D0120
		private string editorControllerName; // 0x20
		[CustomObfuscation] // 0x00000001801D00E0-0x00000001801D0120
		[SerializeField] // 0x00000001801D00E0-0x00000001801D0120
		private string description; // 0x28
		[CustomObfuscation] // 0x00000001801D1070-0x00000001801D10B0
		[SerializeField] // 0x00000001801D1070-0x00000001801D10B0
		private string controllerGuid; // 0x30
		[CustomObfuscation] // 0x00000001801D00E0-0x00000001801D0120
		[SerializeField] // 0x00000001801D00E0-0x00000001801D0120
		private string[] templateGuids; // 0x38
		[CustomObfuscation] // 0x00000001801D00E0-0x00000001801D0120
		[SerializeField] // 0x00000001801D00E0-0x00000001801D0120
		private bool hideInLists; // 0x40
		[CustomObfuscation] // 0x00000001801D00E0-0x00000001801D0120
		[SerializeField] // 0x00000001801D00E0-0x00000001801D0120
		private JoystickType[] joystickTypes; // 0x48
		[CustomObfuscation] // 0x00000001801D00E0-0x00000001801D0120
		[SerializeField] // 0x00000001801D00E0-0x00000001801D0120
		private ControllerElementIdentifier[] elementIdentifiers; // 0x50
		[CustomObfuscation] // 0x00000001801D1070-0x00000001801D10B0
		[SerializeField] // 0x00000001801D1070-0x00000001801D10B0
		private CompoundElement[] compoundElements; // 0x58
		[CustomObfuscation] // 0x00000001801D1070-0x00000001801D10B0
		[SerializeField] // 0x00000001801D1070-0x00000001801D10B0
		private Platform_DirectInput directInput; // 0x60
		[CustomObfuscation] // 0x00000001801D00E0-0x00000001801D0120
		[SerializeField] // 0x00000001801D00E0-0x00000001801D0120
		private Platform_RawInput rawInput; // 0x68
		[CustomObfuscation] // 0x00000001801D1070-0x00000001801D10B0
		[SerializeField] // 0x00000001801D1070-0x00000001801D10B0
		private Platform_XInput xInput; // 0x70
		[CustomObfuscation] // 0x00000001801D00E0-0x00000001801D0120
		[SerializeField] // 0x00000001801D00E0-0x00000001801D0120
		private Platform_OSX osx; // 0x78
		[CustomObfuscation] // 0x00000001801D1070-0x00000001801D10B0
		[SerializeField] // 0x00000001801D1070-0x00000001801D10B0
		private Platform_Linux linux; // 0x80
		[CustomObfuscation] // 0x00000001801D1070-0x00000001801D10B0
		[SerializeField] // 0x00000001801D1070-0x00000001801D10B0
		private Platform_WindowsUWP windowsUWP; // 0x88
		[CustomObfuscation] // 0x00000001801D00E0-0x00000001801D0120
		[SerializeField] // 0x00000001801D00E0-0x00000001801D0120
		private Platform_Fallback fallback_Windows; // 0x90
		[CustomObfuscation] // 0x00000001801D00E0-0x00000001801D0120
		[SerializeField] // 0x00000001801D00E0-0x00000001801D0120
		private Platform_Fallback fallback_WindowsUWP; // 0x98
		[CustomObfuscation] // 0x00000001801D1070-0x00000001801D10B0
		[SerializeField] // 0x00000001801D1070-0x00000001801D10B0
		private Platform_Fallback fallback_OSX; // 0xA0
		[CustomObfuscation] // 0x00000001801D1070-0x00000001801D10B0
		[SerializeField] // 0x00000001801D1070-0x00000001801D10B0
		private Platform_Fallback fallback_Linux; // 0xA8
		[CustomObfuscation] // 0x00000001801D00E0-0x00000001801D0120
		[SerializeField] // 0x00000001801D00E0-0x00000001801D0120
		private Platform_Fallback fallback_Linux_PreConfigured; // 0xB0
		[CustomObfuscation] // 0x00000001801D1070-0x00000001801D10B0
		[SerializeField] // 0x00000001801D1070-0x00000001801D10B0
		private Platform_Fallback fallback_Android; // 0xB8
		[CustomObfuscation] // 0x00000001801D1070-0x00000001801D10B0
		[SerializeField] // 0x00000001801D1070-0x00000001801D10B0
		private Platform_Fallback fallback_iOS; // 0xC0
		[CustomObfuscation] // 0x00000001801D1070-0x00000001801D10B0
		[SerializeField] // 0x00000001801D1070-0x00000001801D10B0
		private Platform_Fallback fallback_Blackberry; // 0xC8
		[CustomObfuscation] // 0x00000001801D1070-0x00000001801D10B0
		[SerializeField] // 0x00000001801D1070-0x00000001801D10B0
		private Platform_Fallback fallback_WindowsPhone8; // 0xD0
		[CustomObfuscation] // 0x00000001801D1070-0x00000001801D10B0
		[SerializeField] // 0x00000001801D1070-0x00000001801D10B0
		private Platform_Fallback fallback_XBox360; // 0xD8
		[CustomObfuscation] // 0x00000001801D00E0-0x00000001801D0120
		[SerializeField] // 0x00000001801D00E0-0x00000001801D0120
		private Platform_Fallback fallback_XBoxOne; // 0xE0
		[CustomObfuscation] // 0x00000001801D00E0-0x00000001801D0120
		[SerializeField] // 0x00000001801D00E0-0x00000001801D0120
		private Platform_Fallback fallback_PS3; // 0xE8
		[CustomObfuscation] // 0x00000001801D1070-0x00000001801D10B0
		[SerializeField] // 0x00000001801D1070-0x00000001801D10B0
		private Platform_Fallback fallback_PS4; // 0xF0
		[CustomObfuscation] // 0x00000001801D1070-0x00000001801D10B0
		[SerializeField] // 0x00000001801D1070-0x00000001801D10B0
		private Platform_Fallback fallback_PSM; // 0xF8
		[CustomObfuscation] // 0x00000001801D1070-0x00000001801D10B0
		[SerializeField] // 0x00000001801D1070-0x00000001801D10B0
		private Platform_Fallback fallback_PSVita; // 0x100
		[CustomObfuscation] // 0x00000001801D00E0-0x00000001801D0120
		[SerializeField] // 0x00000001801D00E0-0x00000001801D0120
		private Platform_Fallback fallback_Wii; // 0x108
		[CustomObfuscation] // 0x00000001801D1070-0x00000001801D10B0
		[SerializeField] // 0x00000001801D1070-0x00000001801D10B0
		private Platform_Fallback fallback_WiiU; // 0x110
		[CustomObfuscation] // 0x00000001801D1070-0x00000001801D10B0
		[SerializeField] // 0x00000001801D1070-0x00000001801D10B0
		private Platform_Fallback fallback_AmazonFireTV; // 0x118
		[CustomObfuscation] // 0x00000001801D1070-0x00000001801D10B0
		[SerializeField] // 0x00000001801D1070-0x00000001801D10B0
		private Platform_Fallback fallback_RazerForgeTV; // 0x120
		[CustomObfuscation] // 0x00000001801D00E0-0x00000001801D0120
		[SerializeField] // 0x00000001801D00E0-0x00000001801D0120
		private Platform_WebGL webGL; // 0x128
		[CustomObfuscation] // 0x00000001801D1070-0x00000001801D10B0
		[SerializeField] // 0x00000001801D1070-0x00000001801D10B0
		private Platform_Ouya ouya; // 0x130
		[CustomObfuscation] // 0x00000001801D00E0-0x00000001801D0120
		[SerializeField] // 0x00000001801D00E0-0x00000001801D0120
		private Platform_XboxOne xboxOne; // 0x138
		[CustomObfuscation] // 0x00000001801D1070-0x00000001801D10B0
		[SerializeField] // 0x00000001801D1070-0x00000001801D10B0
		private Platform_PS4 ps4; // 0x140
		[CustomObfuscation] // 0x00000001801D1070-0x00000001801D10B0
		[SerializeField] // 0x00000001801D1070-0x00000001801D10B0
		private Platform_NintendoSwitch nintendoSwitch; // 0x148
		[CustomObfuscation] // 0x00000001801D00E0-0x00000001801D0120
		[SerializeField] // 0x00000001801D00E0-0x00000001801D0120
		private Platform_Stadia stadia; // 0x150
		[CustomObfuscation] // 0x00000001801D00E0-0x00000001801D0120
		[SerializeField] // 0x00000001801D00E0-0x00000001801D0120
		private Platform_InternalDriver internalDriver; // 0x158
		[CustomObfuscation] // 0x00000001801D00E0-0x00000001801D0120
		[SerializeField] // 0x00000001801D00E0-0x00000001801D0120
		private Platform_SDL2 sdl2_Linux; // 0x160
		[CustomObfuscation] // 0x00000001801D00E0-0x00000001801D0120
		[SerializeField] // 0x00000001801D00E0-0x00000001801D0120
		private Platform_SDL2 sdl2_Windows; // 0x168
		[CustomObfuscation] // 0x00000001801D1070-0x00000001801D10B0
		[SerializeField] // 0x00000001801D1070-0x00000001801D10B0
		private Platform_SDL2 sdl2_OSX; // 0x170
		[CustomObfuscation] // 0x00000001801D1070-0x00000001801D10B0
		[SerializeField] // 0x00000001801D1070-0x00000001801D10B0
		private int elementIdentifierIdCounter; // 0x178
	
		// Properties
		public string ControllerName { get; } // 0x0000000180372430-0x0000000180372440 
		public string EditorControllerName { get; } // 0x0000000180374AF0-0x0000000180374B00 
		public Guid Guid { get; } // 0x0000000180D8DEB0-0x0000000180D8DF30 
		public IEnumerable<Guid> TemplateGuids { get; } // 0x0000000180D8DFA0-0x0000000180D8E010 
		public IEnumerable<ControllerElementIdentifier> ElementIdentifiers { get; } // 0x0000000180D8DE40-0x0000000180D8DEB0 
		public int elementIdentifierCount { get; } // 0x0000000180D8E010-0x0000000180D8E020 
		public bool HideInLists { get; } // 0x0000000180455BA0-0x0000000180455BB0 
		internal IEnumerable<JoystickType> JoystickTypes { get; } // 0x0000000180D8DF30-0x0000000180D8DFA0 
		IEnumerable<IControllerElementIdentifierCommon_Internal> IHardwareControllerMap_Internal.ElementIdentifiers { get; } // 0x0000000180D8C310-0x0000000180D8C380 
	
		// Nested types
		[Serializable]
		[CustomClassObfuscation] // 0x0000000180207920-0x0000000180207950
		public abstract class Platform : IDeepCloneable // TypeDefIndex: 6218
		{
			// Fields
			public string description; // 0x10
	
			// Properties
			internal abstract InputPlatform platform { get; }
			public abstract int assignedButtonCount { get; }
			public abstract int assignedAxisCount { get; }
			public virtual string controllerNameOverride { get; } // 0x000000018037DDC0-0x000000018037DDD0 
			internal abstract Elements_Base elements_base { get; }
			internal virtual bool isAllowed { get; } // 0x0000000180D8FFD0-0x0000000180D90060 
			internal abstract bool hasData { get; }
			internal abstract bool disabled { get; }
			internal abstract IList<Platform> variants_base { get; }
			internal IEnumerable<Platform> Variants { get; } // 0x0000000180D8FF40-0x0000000180D8FFB0 
			internal bool hasVariants { get; } // 0x0000000180D8FFB0-0x0000000180D8FFD0 
			[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
			internal int variantCount { get; } // 0x0000000180D906A0-0x0000000180D90720 
			internal bool selfOrVariantHasData { get; } // 0x0000000180D90060-0x0000000180D90280 
			internal bool selfOrVariantIsValid { get; } // 0x0000000180D90470-0x0000000180D906A0 
			internal bool selfOrVariantIsAllowed { get; } // 0x0000000180D90280-0x0000000180D90470 
	
			// Nested types
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private sealed class GZAfzUfNaNaapIKPbDvSSTwYWnvI : IEnumerable<Platform>, IEnumerator<Platform> // TypeDefIndex: 6219
			{
				// Fields
				private Platform aSrFEaALHwhGTdXfCdeUqgbwaZGO; // 0x10
				private int eLrUhJFgzEZElCzdKvcrgOLXLvL; // 0x18
				private int RQaeFqcJnaOYpZSBxtfUkVOjfOo; // 0x1C
				public Platform gKPmvKLRxdGbmXiMfUeDjGbezUo; // 0x20
				public IList<Platform> yrgCBjhrprJUpeKMDbrcgWtdHBKo; // 0x28
				public int ZCaKPgzFCrVnIscHoZYKRMOyQK; // 0x30
	
				// Properties
				Platform ZjgEXkGxBVzRLGmFzygWzMTuDVL { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372440-0x0000000180372450 
				object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372440-0x0000000180372450 
	
				// Constructors
				[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
				public GZAfzUfNaNaapIKPbDvSSTwYWnvI(int <>1__state); // 0x00000001805EDEC0-0x00000001805EDF10
	
				// Methods
				[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
				IEnumerator<Platform> System.Collections.Generic.IEnumerable<Rewired.Data.Mapping.HardwareJoystickMap.Platform>.GetEnumerator(); // 0x00000001818A8CA0-0x00000001818A8DC0
				[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
				IEnumerator IEnumerable.GetEnumerator(); // 0x00000001818A8CA0-0x00000001818A8DC0
				private bool MoveNext(); // 0x00000001818A8AF0-0x00000001818A8CA0
				[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
				void IEnumerator.Reset(); // 0x00000001818A8DC0-0x00000001818A8E10
				void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			}
	
			// Constructors
			protected Platform(); // 0x0000000180373240-0x0000000180373250
	
			// Methods
			internal abstract bool Matches(BridgedControllerHWInfo BridgedControllerHWInfo, bool strictMatch, out int variantIndex, out Platform platformMap);
			internal abstract string[] GetAxisNames(ControllerElementIdentifier[] identifiers);
			internal abstract string[] GetEffectiveButtonNames(ControllerElementIdentifier[] identifiers);
			internal abstract void GetGameElementIdentifierIdMappings(out int[] buttons, out int[] axes);
			internal abstract bool IsElementIdentifierMapped(int elementIdentifierId);
			internal Platform GetFirstValidPlatformMap(out int variantIndex); // 0x0000000180D8E400-0x0000000180D8E6B0
			internal int IndexOfElementIdentifier(ControllerElementIdentifier[] elementIdentifiers, int id); // 0x0000000180D8E790-0x0000000180D8E830
			internal abstract AxisCalibrationData[] GetAxisCalibrationData();
			internal abstract void GetAxisData(out AxisRange[] axisRanges, out HardwareAxisInfo[] axisInfos);
			internal abstract void GetButtonData(out HardwareButtonInfo[] buttonInfos);
			internal abstract ControllerElementType GetEffectiveElementIdentifierType(ControllerElementIdentifier elementIdentifier);
			internal abstract bool GetEffectiveAxisRange(ControllerElementIdentifier elementIdentifier, out AxisRange axisRange);
			internal Platform GetPlatformMap(int variantIndex); // 0x0000000180D8E6B0-0x0000000180D8E790
			internal HardwareJoystickMap_InputManager ToHardwareJoystickMap_InputManager(HardwareJoystickMap hardwareJoystickMap, InputSource inputSource, InputPlatform actualInputPlatform, int variantIndex); // 0x0000000180D8E830-0x0000000180D8FF40
			public abstract object DeepClone();
			internal abstract void CopyVars(Platform destination);
		}
	
		[Serializable]
		[CustomClassObfuscation] // 0x0000000180207920-0x0000000180207950
		public abstract class Elements_Base : IDeepCloneable // TypeDefIndex: 6220
		{
			// Properties
			public abstract int buttonCount { get; }
			public abstract int axisCount { get; }
	
			// Constructors
			protected Elements_Base(); // 0x0000000180373240-0x0000000180373250
	
			// Methods
			internal virtual void CopyVars(Elements_Base destination); // 0x00000001803774A0-0x00000001803774B0
			internal abstract ControllerElementType GetEffectiveElementIdentifierType(ControllerElementIdentifier elementIdentifier);
			internal abstract bool GetEffectiveAxisRange(ControllerElementIdentifier elementIdentifier, out AxisRange axisRange);
			public abstract object DeepClone();
		}
	
		[Serializable]
		[CustomClassObfuscation] // 0x0000000180207920-0x0000000180207950
		public abstract class MatchingCriteria_Base : IDeepCloneable // TypeDefIndex: 6221
		{
			// Fields
			public int axisCount; // 0x10
			public int buttonCount; // 0x14
			public bool disabled; // 0x18
			public string tag; // 0x20
	
			// Properties
			internal abstract bool hasData { get; }
			internal virtual bool isAllowed { get; } // 0x0000000180D8E3A0-0x0000000180D8E3B0 
			internal abstract int alternateElementCount { get; }
	
			// Nested types
			[Serializable]
			public class ElementCount_Base : IDeepCloneable // TypeDefIndex: 6222
			{
				// Fields
				public int axisCount; // 0x10
				public int buttonCount; // 0x14
	
				// Constructors
				public ElementCount_Base(); // 0x0000000180373240-0x0000000180373250
	
				// Methods
				public virtual object DeepClone(); // 0x0000000180D88470-0x0000000180D884E0
				internal virtual void CopyVars(ElementCount_Base param_0000cffa); // 0x0000000180D88430-0x0000000180D88470
				internal virtual bool Matches(BridgedControllerHWInfo param_0000cffb); // 0x0000000180D884E0-0x0000000180D88550
			}
	
			// Constructors
			protected MatchingCriteria_Base(); // 0x0000000180373240-0x0000000180373250
	
			// Methods
			internal virtual bool Matches(BridgedControllerHWInfo BridgedControllerHWInfo, bool strictMatch); // 0x0000000180D8E1D0-0x0000000180D8E280
			internal abstract ElementCount_Base GetAlternateElementCount(int index);
			internal virtual bool ElementCountsMatch(BridgedControllerHWInfo bridgedControllerHWInfo, out bool alternateMatched); // 0x0000000180D8E070-0x0000000180D8E1D0
			internal virtual void CopyVars(MatchingCriteria_Base destination); // 0x0000000180D8E020-0x0000000180D8E070
			internal static bool StringMatches(string searchIn, string searchFor, bool useRegex); // 0x0000000180D8E280-0x0000000180D8E3A0
			public abstract object DeepClone();
		}
	
		[Serializable]
		[CustomClassObfuscation] // 0x0000000180207920-0x0000000180207950
		public class CompoundElement : IDeepCloneable // TypeDefIndex: 6223
		{
			// Fields
			public CompoundControllerElementType type; // 0x10
			public int elementIdentifier; // 0x14
			public int[] componentElementIdentifiers; // 0x18
	
			// Properties
			public int elementCount { get; } // 0x00000001805EF540-0x00000001805EF550 
	
			// Constructors
			public CompoundElement(); // 0x0000000180D79160-0x0000000180D791D0
			public CompoundElement(CompoundElement original); // 0x0000000180D790F0-0x0000000180D79160
	
			// Methods
			public int GetComponentElementIdentifierId(int index); // 0x0000000180D78C90-0x0000000180D78CF0
			public virtual object DeepClone(); // 0x0000000180D78BF0-0x0000000180D78C90
			protected virtual void ImportVars(CompoundElement source); // 0x0000000180D78CF0-0x0000000180D78D60
			internal static void SortHatElementsClockwise(CompoundElement element); // 0x0000000180D78D60-0x0000000180D790F0
		}
	
		[Serializable]
		[CustomClassObfuscation] // 0x0000000180207920-0x0000000180207950
		public class VidPid // TypeDefIndex: 6224
		{
			// Fields
			public int vendorId; // 0x10
			public int productId; // 0x14
	
			// Constructors
			public VidPid(); // 0x0000000180373240-0x0000000180373250
		}
	
		[Serializable]
		[CustomClassObfuscation] // 0x0000000180207920-0x0000000180207950
		public class AxisCalibrationInfoEntry : IDeepCloneable // TypeDefIndex: 6225
		{
			// Fields
			[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
			internal AlternateAxisCalibrationType key; // 0x10
			[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
			internal AxisCalibrationInfo calibration; // 0x18
	
			// Constructors
			public AxisCalibrationInfoEntry(AxisCalibrationInfoEntry original); // 0x0000000180D77F60-0x0000000180D77FC0
	
			// Methods
			public virtual object DeepClone(); // 0x0000000180D779A0-0x0000000180D77A30
			protected virtual void ImportVars(AxisCalibrationInfoEntry source); // 0x0000000180D77A30-0x0000000180D77AB0
			public static Dictionary<int, AxisCalibrationInfo> ToDictionary(AxisCalibrationInfoEntry[] calibrations, bool deepClone); // 0x0000000180D77AB0-0x0000000180D77F60
		}
	
		[Serializable]
		[CustomClassObfuscation] // 0x0000000180207920-0x0000000180207950
		public abstract class Platform_RawOrDirectInput : Rewired.Data.Mapping.HardwareJoystickMap.Platform // TypeDefIndex: 6226
		{
			// Fields
			public MatchingCriteria matchingCriteria; // 0x18
	
			// Properties
			internal override bool hasData { get; } // 0x0000000181942370-0x0000000181942400 
			internal override bool disabled { get; } // 0x00000001805F64E0-0x00000001805F64F0 
			internal override bool isAllowed { get; } // 0x00000001805F6560-0x00000001805F65A0 
	
			// Nested types
			[Serializable]
			[CustomClassObfuscation] // 0x0000000180207920-0x0000000180207950
			public sealed class MatchingCriteria : MatchingCriteria_Base // TypeDefIndex: 6227
			{
				// Fields
				public int hatCount; // 0x28
				public ElementCount[] alternateElementCounts; // 0x30
				public bool productName_useRegex; // 0x38
				public string[] productName; // 0x40
				public string[] productGUID; // 0x48
				public int[] productId; // 0x50
				public DeviceType deviceType; // 0x58
	
				// Properties
				internal override bool hasData { get; } // 0x000000018193B490-0x000000018193B4C0 
				internal override bool isAllowed { get; } // 0x00000001805F43A0-0x00000001805F43C0 
				internal override int alternateElementCount { get; } // 0x00000001805F42F0-0x00000001805F4300 
	
				// Nested types
				[Serializable]
				public sealed class ElementCount : MatchingCriteria_Base.ElementCount_Base // TypeDefIndex: 6228
				{
					// Fields
					public int hatCount; // 0x18
	
					// Constructors
					public ElementCount(); // 0x00000001803F46D0-0x00000001803F46E0
	
					// Methods
					public override object DeepClone(); // 0x00000001819357B0-0x0000000181935840
					internal override void CopyVars(MatchingCriteria_Base.ElementCount_Base param_0000d00d); // 0x0000000181935740-0x00000001819357B0
					internal override bool Matches(BridgedControllerHWInfo param_0000d00e); // 0x00000001805EE280-0x00000001805EE2E0
				}
	
				// Constructors
				public MatchingCriteria(); // 0x00000001803F46D0-0x00000001803F46E0
	
				// Methods
				internal override bool Matches(BridgedControllerHWInfo bridgedControllerHWInfo, bool strictMatch); // 0x000000018193A830-0x000000018193AB30
				internal override ElementCount_Base GetAlternateElementCount(int index); // 0x00000001805F3C60-0x00000001805F3CA0
				internal override bool ElementCountsMatch(BridgedControllerHWInfo bridgedControllerHWInfo, out bool alternateMatched); // 0x0000000181939C60-0x0000000181939D00
				private bool ProductNameMatches(BridgedControllerHWInfo controller); // 0x000000018193B220-0x000000018193B2B0
				private bool ProductNameMatches(string name); // 0x000000018193B2B0-0x000000018193B490
				public override object DeepClone(); // 0x0000000181939B50-0x0000000181939BC0
				internal override void CopyVars(MatchingCriteria_Base destination); // 0x00000001819397C0-0x00000001819398B0
			}
	
			[Serializable]
			[CustomClassObfuscation] // 0x0000000180207920-0x0000000180207950
			public abstract class Elements_Platform_Base : Elements_Base // TypeDefIndex: 6229
			{
				// Properties
				internal abstract IEnumerable<Axis_Base> Axes { get; }
				internal abstract IEnumerable<Button_Base> Buttons { get; }
	
				// Constructors
				protected Elements_Platform_Base(); // 0x00000001803F46D0-0x00000001803F46E0
	
				// Methods
				internal abstract Axis_Base GetAxis(int axisIndex);
			}
	
			[Serializable]
			[CustomClassObfuscation] // 0x0000000180207920-0x0000000180207950
			public class CustomCalculationSourceData : IDeepCloneable // TypeDefIndex: 6230
			{
				// Fields
				public int sourceType; // 0x10
				public int sourceAxis; // 0x14
				public int sourceButton; // 0x18
				public int sourceOtherAxis; // 0x1C
				public AxisRange sourceAxisRange; // 0x20
				public float axisDeadZone; // 0x24
				public bool invert; // 0x28
				public AxisCalibrationType axisCalibrationType; // 0x2C
				public float axisZero; // 0x30
				public float axisMin; // 0x34
				public float axisMax; // 0x38
	
				// Constructors
				public CustomCalculationSourceData(); // 0x0000000180373240-0x0000000180373250
	
				// Methods
				public object DeepClone(); // 0x00000001819355C0-0x0000000181935660
			}
	
			[Serializable]
			[CustomClassObfuscation] // 0x0000000180207920-0x0000000180207950
			public abstract class Element : IDeepCloneable // TypeDefIndex: 6231
			{
				// Fields
				public CustomCalculation customCalculation; // 0x10
				public CustomCalculationSourceData[] customCalculationSourceData; // 0x18
	
				// Constructors
				protected Element(); // 0x0000000180373240-0x0000000180373250
	
				// Methods
				public abstract object DeepClone();
				protected void ImportVars(Element source); // 0x0000000181935920-0x0000000181935980
			}
	
			[Serializable]
			[CustomClassObfuscation] // 0x0000000180207920-0x0000000180207950
			public abstract class Button_Base : Element // TypeDefIndex: 6232
			{
				// Fields
				public int elementIdentifier; // 0x20
				public HardwareElementSourceTypeWithHat sourceType; // 0x24
				public int sourceButton; // 0x28
				public int sourceAxis; // 0x2C
				public Pole sourceAxisPole; // 0x30
				public float axisDeadZone; // 0x34
				public int sourceHat; // 0x38
				public HatType sourceHatType; // 0x3C
				public HatDirection sourceHatDirection; // 0x40
				public bool requireMultipleButtons; // 0x44
				public int[] requiredButtons; // 0x48
				public bool ignoreIfButtonsActive; // 0x50
				public int[] ignoreIfButtonsActiveButtons; // 0x58
				public HardwareButtonInfo buttonInfo; // 0x60
	
				// Constructors
				public Button_Base(); // 0x0000000181934D20-0x0000000181934D40
	
				// Methods
				protected void ImportVars(Button_Base source); // 0x0000000181934BE0-0x0000000181934D20
			}
	
			[Serializable]
			[CustomClassObfuscation] // 0x0000000180207920-0x0000000180207950
			public abstract class Axis_Base : Element // TypeDefIndex: 6233
			{
				// Fields
				public int elementIdentifier; // 0x20
				public HardwareElementSourceTypeWithHat sourceType; // 0x24
				public int sourceAxis; // 0x28
				public AxisRange sourceAxisRange; // 0x2C
				public bool invert; // 0x30
				public float axisDeadZone; // 0x34
				public bool calibrateAxis; // 0x38
				public float axisZero; // 0x3C
				public float axisMin; // 0x40
				public float axisMax; // 0x44
				public HardwareAxisInfo axisInfo; // 0x48
				public AxisCalibrationInfoEntry[] alternateCalibrations; // 0x50
				public int sourceButton; // 0x58
				public Pole buttonAxisContribution; // 0x5C
				public int sourceHat; // 0x60
				public AxisDirection sourceHatDirection; // 0x64
				public AxisRange sourceHatRange; // 0x68
	
				// Constructors
				public Axis_Base(); // 0x0000000181933C00-0x0000000181933C20
	
				// Methods
				protected void ImportVars(Axis_Base source); // 0x0000000181933A70-0x0000000181933C00
			}
	
			public enum DeviceType // TypeDefIndex: 6234
			{
				Any = 0,
				Device = 17,
				Mouse = 18,
				Keyboard = 19,
				Joystick = 20,
				Gamepad = 21,
				Driving = 22,
				Flight = 23,
				FirstPerson = 24,
				ControlDevice = 25,
				ScreenPointer = 26,
				Remote = 27,
				Supplemental = 28
			}
	
			// Constructors
			protected Platform_RawOrDirectInput(); // 0x00000001803F46D0-0x00000001803F46E0
	
			// Methods
			internal abstract IEnumerable<Axis_Base> IterateAxes();
			internal abstract IEnumerable<Button_Base> IterateButtons();
			internal override void CopyVars(Rewired.Data.Mapping.HardwareJoystickMap.Platform destination); // 0x0000000181942280-0x0000000181942370
		}
	
		[Serializable]
		[CustomClassObfuscation] // 0x0000000180207920-0x0000000180207950
		public class Platform_DirectInput_Base : Platform_RawOrDirectInput // TypeDefIndex: 6235
		{
			// Fields
			public Elements elements; // 0x20
	
			// Properties
			internal override InputPlatform platform { get; } // 0x000000018058C710-0x000000018058C720 
			internal Axis[] Axes_orig { get; } // 0x00000001805F6480-0x00000001805F6490 
			internal Button[] Buttons_orig { get; } // 0x00000001805F6490-0x00000001805F64A0 
			internal override IList<Rewired.Data.Mapping.HardwareJoystickMap.Platform> variants_base { get; } // 0x000000018037DDC0-0x000000018037DDD0 
			public override int assignedButtonCount { get; } // 0x00000001805F64C0-0x00000001805F64E0 
			public override int assignedAxisCount { get; } // 0x00000001805F64A0-0x00000001805F64C0 
			internal override Elements_Base elements_base { get; } // 0x0000000180374AF0-0x0000000180374B00 
	
			// Nested types
			[Serializable]
			[CustomClassObfuscation] // 0x0000000180207920-0x0000000180207950
			public sealed class Elements : Platform_RawOrDirectInput.Elements_Platform_Base // TypeDefIndex: 6236
			{
				// Fields
				public Axis[] axes; // 0x10
				public Button[] buttons; // 0x18
	
				// Properties
				public override int buttonCount { get; } // 0x00000001805EF540-0x00000001805EF550 
				public override int axisCount { get; } // 0x00000001805EF530-0x00000001805EF540 
				internal override IEnumerable<Platform_RawOrDirectInput.Axis_Base> Axes { get; } // 0x00000001818A85F0-0x00000001818A8670 
				internal override IEnumerable<Platform_RawOrDirectInput.Button_Base> Buttons { get; } // 0x00000001818A8770-0x00000001818A87F0 
	
				// Nested types
				[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
				private sealed class VFPeobtRAyqhQUBHMrCLvCKUfOd : IEnumerable<Platform_RawOrDirectInput.Axis_Base>, IEnumerator<Platform_RawOrDirectInput.Axis_Base> // TypeDefIndex: 6237
				{
					// Fields
					private Platform_RawOrDirectInput.Axis_Base aSrFEaALHwhGTdXfCdeUqgbwaZGO; // 0x10
					private int eLrUhJFgzEZElCzdKvcrgOLXLvL; // 0x18
					private int RQaeFqcJnaOYpZSBxtfUkVOjfOo; // 0x1C
					public Elements gKPmvKLRxdGbmXiMfUeDjGbezUo; // 0x20
					public int VKvkBbBTFhVmMOfYFCAQiouOITD; // 0x28
	
					// Properties
					Platform_RawOrDirectInput.Axis_Base nIKQstLqZCeOFdNDhBATHfuWIFQX { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372440-0x0000000180372450 
					object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372440-0x0000000180372450 
	
					// Constructors
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					public VFPeobtRAyqhQUBHMrCLvCKUfOd(int <>1__state); // 0x00000001805EDEC0-0x00000001805EDF10
	
					// Methods
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					IEnumerator<Platform_RawOrDirectInput.Axis_Base> System.Collections.Generic.IEnumerable<Rewired.Data.Mapping.HardwareJoystickMap.Platform_RawOrDirectInput.Axis_Base>.GetEnumerator(); // 0x00000001818B8890-0x00000001818B89E0
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					IEnumerator IEnumerable.GetEnumerator(); // 0x00000001818B8890-0x00000001818B89E0
					private bool MoveNext(); // 0x00000001818B8750-0x00000001818B8890
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					void IEnumerator.Reset(); // 0x00000001818B89E0-0x00000001818B8A30
					void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
				}
	
				[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
				private sealed class rQViXDgeNSgiBKrrBJjPNlNHqaJj : IEnumerable<Platform_RawOrDirectInput.Button_Base>, IEnumerator<Platform_RawOrDirectInput.Button_Base> // TypeDefIndex: 6238
				{
					// Fields
					private Platform_RawOrDirectInput.Button_Base aSrFEaALHwhGTdXfCdeUqgbwaZGO; // 0x10
					private int eLrUhJFgzEZElCzdKvcrgOLXLvL; // 0x18
					private int RQaeFqcJnaOYpZSBxtfUkVOjfOo; // 0x1C
					public Elements gKPmvKLRxdGbmXiMfUeDjGbezUo; // 0x20
					public int gOscWspLicRODXhGypyRngxBgnz; // 0x28
	
					// Properties
					Platform_RawOrDirectInput.Button_Base zZOeLQhakIZFsPvaKJkuaVXllVb { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372440-0x0000000180372450 
					object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372440-0x0000000180372450 
	
					// Constructors
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					public rQViXDgeNSgiBKrrBJjPNlNHqaJj(int <>1__state); // 0x00000001805EDEC0-0x00000001805EDF10
	
					// Methods
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					IEnumerator<Platform_RawOrDirectInput.Button_Base> System.Collections.Generic.IEnumerable<Rewired.Data.Mapping.HardwareJoystickMap.Platform_RawOrDirectInput.Button_Base>.GetEnumerator(); // 0x00000001818BA3C0-0x00000001818BA4C0
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					IEnumerator IEnumerable.GetEnumerator(); // 0x00000001818BA3C0-0x00000001818BA4C0
					private bool MoveNext(); // 0x00000001818BA2A0-0x00000001818BA3C0
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					void IEnumerator.Reset(); // 0x00000001818BA4C0-0x00000001818BA510
					void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
				}
	
				// Constructors
				public Elements(); // 0x00000001803FB1F0-0x00000001803FB200
	
				// Methods
				internal override Platform_RawOrDirectInput.Axis_Base GetAxis(int axisIndex); // 0x00000001818A6800-0x00000001818A6860
				internal override ControllerElementType GetEffectiveElementIdentifierType(ControllerElementIdentifier elementIdentifier); // 0x00000001818A7FB0-0x00000001818A8150
				internal override bool GetEffectiveAxisRange(ControllerElementIdentifier elementIdentifier, out AxisRange axisRange); // 0x00000001818A71B0-0x00000001818A74C0
				public override object DeepClone(); // 0x00000001818A6640-0x00000001818A66B0
				internal override void CopyVars(Elements_Base destination); // 0x00000001818A6380-0x00000001818A6410
			}
	
			[Serializable]
			[CustomClassObfuscation] // 0x0000000180207920-0x0000000180207950
			public sealed class Button : Platform_RawOrDirectInput.Button_Base // TypeDefIndex: 6239
			{
				// Constructors
				public Button(); // 0x00000001818A5160-0x00000001818A5170
	
				// Methods
				public override object DeepClone(); // 0x00000001818A4D80-0x00000001818A4DF0
				private void ImportVars(Button source); // 0x00000001818A4F40-0x00000001818A4F50
			}
	
			[Serializable]
			[CustomClassObfuscation] // 0x0000000180207920-0x0000000180207950
			public sealed class Axis : Platform_RawOrDirectInput.Axis_Base // TypeDefIndex: 6240
			{
				// Constructors
				public Axis(); // 0x00000001818A4610-0x00000001818A4620
	
				// Methods
				public override object DeepClone(); // 0x00000001818A40F0-0x00000001818A4160
				private void ImportVars(Axis source); // 0x00000001818A43B0-0x00000001818A43C0
			}
	
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private sealed class iuSqROEJUiINorGiLbNdWaSQilf : IEnumerable<Axis_Base>, IEnumerator<Axis_Base> // TypeDefIndex: 6241
			{
				// Fields
				private Platform_RawOrDirectInput.Axis_Base aSrFEaALHwhGTdXfCdeUqgbwaZGO; // 0x10
				private int eLrUhJFgzEZElCzdKvcrgOLXLvL; // 0x18
				private int RQaeFqcJnaOYpZSBxtfUkVOjfOo; // 0x1C
				public Platform_DirectInput_Base gKPmvKLRxdGbmXiMfUeDjGbezUo; // 0x20
				public int PDqsFqWbqPKqEzUyDCjDUidzESc; // 0x28
				public int csGJgKcxqlbMfoFsHtnxIxwbumC; // 0x2C
	
				// Properties
				Platform_RawOrDirectInput.Axis_Base nIKQstLqZCeOFdNDhBATHfuWIFQX { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372440-0x0000000180372450 
				object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372440-0x0000000180372450 
	
				// Constructors
				[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
				public iuSqROEJUiINorGiLbNdWaSQilf(int <>1__state); // 0x00000001818B9990-0x00000001818B9A00
	
				// Methods
				[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
				IEnumerator<Platform_RawOrDirectInput.Axis_Base> System.Collections.Generic.IEnumerable<Rewired.Data.Mapping.HardwareJoystickMap.Platform_RawOrDirectInput.Axis_Base>.GetEnumerator(); // 0x00000001818B9820-0x00000001818B9940
				[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
				IEnumerator IEnumerable.GetEnumerator(); // 0x00000001818B9820-0x00000001818B9940
				private bool MoveNext(); // 0x00000001818B9680-0x00000001818B9820
				[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
				void IEnumerator.Reset(); // 0x00000001818B9940-0x00000001818B9990
				void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			}
	
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private sealed class iuHqBVOUUoeiikFnGISYSUrdzJW : IEnumerable<Button_Base>, IEnumerator<Button_Base> // TypeDefIndex: 6242
			{
				// Fields
				private Platform_RawOrDirectInput.Button_Base aSrFEaALHwhGTdXfCdeUqgbwaZGO; // 0x10
				private int eLrUhJFgzEZElCzdKvcrgOLXLvL; // 0x18
				private int RQaeFqcJnaOYpZSBxtfUkVOjfOo; // 0x1C
				public Platform_DirectInput_Base gKPmvKLRxdGbmXiMfUeDjGbezUo; // 0x20
				public int AyMLzwfKbghsBcKYGuvxjNAmrlN; // 0x28
				public int QyDDfdpGWGcYplbmqgZMddBHnRm; // 0x2C
	
				// Properties
				Platform_RawOrDirectInput.Button_Base zZOeLQhakIZFsPvaKJkuaVXllVb { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372440-0x0000000180372450 
				object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372440-0x0000000180372450 
	
				// Constructors
				[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
				public iuHqBVOUUoeiikFnGISYSUrdzJW(int <>1__state); // 0x00000001805EDEC0-0x00000001805EDF10
	
				// Methods
				[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
				IEnumerator<Platform_RawOrDirectInput.Button_Base> System.Collections.Generic.IEnumerable<Rewired.Data.Mapping.HardwareJoystickMap.Platform_RawOrDirectInput.Button_Base>.GetEnumerator(); // 0x00000001818B9520-0x00000001818B9630
				[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
				IEnumerator IEnumerable.GetEnumerator(); // 0x00000001818B9520-0x00000001818B9630
				private bool MoveNext(); // 0x00000001818B9360-0x00000001818B9520
				[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
				void IEnumerator.Reset(); // 0x00000001818B9630-0x00000001818B9680
				void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			}
	
			// Constructors
			public Platform_DirectInput_Base(); // 0x00000001803FB1F0-0x00000001803FB200
	
			// Methods
			internal override bool Matches(BridgedControllerHWInfo BridgedControllerHWInfo, bool strictMatch, out int variantIndex, out Rewired.Data.Mapping.HardwareJoystickMap.Platform platformMap); // 0x00000001818AD190-0x00000001818AD220
			internal override string[] GetAxisNames(ControllerElementIdentifier[] identifiers); // 0x00000001818ABF90-0x00000001818AC270
			internal override string[] GetEffectiveButtonNames(ControllerElementIdentifier[] identifiers); // 0x00000001818AC450-0x00000001818AC730
			internal override bool IsElementIdentifierMapped(int elementIdentifierId); // 0x00000001818ACC70-0x00000001818AD060
			internal override void GetGameElementIdentifierIdMappings(out int[] buttons, out int[] axes); // 0x00000001818AC730-0x00000001818ACC70
			internal override AxisCalibrationData[] GetAxisCalibrationData(); // 0x00000001818AB4A0-0x00000001818ABAC0
			internal override void GetAxisData(out AxisRange[] axisRanges, out HardwareAxisInfo[] axisInfos); // 0x00000001818ABAC0-0x00000001818ABF90
			internal override void GetButtonData(out HardwareButtonInfo[] buttonInfos); // 0x00000001818AC270-0x00000001818AC450
			internal override ControllerElementType GetEffectiveElementIdentifierType(ControllerElementIdentifier elementIdentifier); // 0x00000001805F5B50-0x00000001805F5B70
			internal override bool GetEffectiveAxisRange(ControllerElementIdentifier elementIdentifier, out AxisRange axisRange); // 0x00000001805F5800-0x00000001805F5830
			internal override IEnumerable<Axis_Base> IterateAxes(); // 0x00000001818AD060-0x00000001818AD110
			internal override IEnumerable<Button_Base> IterateButtons(); // 0x00000001818AD110-0x00000001818AD190
			public override object DeepClone(); // 0x00000001818AB430-0x00000001818AB4A0
			internal override void CopyVars(Rewired.Data.Mapping.HardwareJoystickMap.Platform destination); // 0x00000001818AB340-0x00000001818AB430
		}
	
		[Serializable]
		[CustomClassObfuscation] // 0x0000000180207920-0x0000000180207950
		public sealed class Platform_DirectInput : Platform_DirectInput_Base // TypeDefIndex: 6243
		{
			// Fields
			public Platform_DirectInput_Base[] variants; // 0x28
	
			// Properties
			internal override IList<Rewired.Data.Mapping.HardwareJoystickMap.Platform> variants_base { get; } // 0x00000001803745B0-0x00000001803745C0 
	
			// Constructors
			public Platform_DirectInput(); // 0x00000001803FB1F0-0x00000001803FB200
	
			// Methods
			internal override bool Matches(BridgedControllerHWInfo BridgedControllerHWInfo, bool strictMatch, out int variantIndex, out Rewired.Data.Mapping.HardwareJoystickMap.Platform platformMap); // 0x00000001818AD430-0x00000001818AD610
			public override object DeepClone(); // 0x00000001818AD3C0-0x00000001818AD430
			internal override void CopyVars(Rewired.Data.Mapping.HardwareJoystickMap.Platform destination); // 0x00000001818AD220-0x00000001818AD3C0
		}
	
		[Serializable]
		[CustomClassObfuscation] // 0x0000000180207920-0x0000000180207950
		public class Platform_RawInput_Base : Platform_RawOrDirectInput // TypeDefIndex: 6244
		{
			// Fields
			public Elements elements; // 0x20
	
			// Properties
			internal override InputPlatform platform { get; } // 0x0000000180411150-0x0000000180411160 
			internal Axis[] Axes_orig { get; } // 0x00000001805F6480-0x00000001805F6490 
			internal Button[] Buttons_orig { get; } // 0x00000001805F6490-0x00000001805F64A0 
			internal override IList<Rewired.Data.Mapping.HardwareJoystickMap.Platform> variants_base { get; } // 0x000000018037DDC0-0x000000018037DDD0 
			public override int assignedButtonCount { get; } // 0x00000001805F64C0-0x00000001805F64E0 
			public override int assignedAxisCount { get; } // 0x00000001805F64A0-0x00000001805F64C0 
			internal override Elements_Base elements_base { get; } // 0x0000000180374AF0-0x0000000180374B00 
	
			// Nested types
			[Serializable]
			[CustomClassObfuscation] // 0x0000000180207920-0x0000000180207950
			public sealed class Elements : Platform_RawOrDirectInput.Elements_Platform_Base // TypeDefIndex: 6245
			{
				// Fields
				public Axis[] axes; // 0x10
				public Button[] buttons; // 0x18
	
				// Properties
				public override int buttonCount { get; } // 0x00000001805EF540-0x00000001805EF550 
				public override int axisCount { get; } // 0x00000001805EF530-0x00000001805EF540 
				internal override IEnumerable<Platform_RawOrDirectInput.Axis_Base> Axes { get; } // 0x0000000181937CE0-0x0000000181937D60 
				internal override IEnumerable<Platform_RawOrDirectInput.Button_Base> Buttons { get; } // 0x0000000181937DE0-0x0000000181937E80 
	
				// Nested types
				[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
				private sealed class iOZMHmzkLdeYvIRpMKglwSFXTrt : IEnumerable<Platform_RawOrDirectInput.Axis_Base>, IEnumerator<Platform_RawOrDirectInput.Axis_Base> // TypeDefIndex: 6246
				{
					// Fields
					private Platform_RawOrDirectInput.Axis_Base aSrFEaALHwhGTdXfCdeUqgbwaZGO; // 0x10
					private int eLrUhJFgzEZElCzdKvcrgOLXLvL; // 0x18
					private int RQaeFqcJnaOYpZSBxtfUkVOjfOo; // 0x1C
					public Elements gKPmvKLRxdGbmXiMfUeDjGbezUo; // 0x20
					public int MmyyNPUYdJpsCLKeobZeMLsbDxo; // 0x28
	
					// Properties
					Platform_RawOrDirectInput.Axis_Base nIKQstLqZCeOFdNDhBATHfuWIFQX { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372440-0x0000000180372450 
					object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372440-0x0000000180372450 
	
					// Constructors
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					public iOZMHmzkLdeYvIRpMKglwSFXTrt(int <>1__state); // 0x00000001805EDEC0-0x00000001805EDF10
	
					// Methods
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					IEnumerator<Platform_RawOrDirectInput.Axis_Base> System.Collections.Generic.IEnumerable<Rewired.Data.Mapping.HardwareJoystickMap.Platform_RawOrDirectInput.Axis_Base>.GetEnumerator(); // 0x000000018194A5D0-0x000000018194A6F0
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					IEnumerator IEnumerable.GetEnumerator(); // 0x000000018194A5D0-0x000000018194A6F0
					private bool MoveNext(); // 0x000000018194A480-0x000000018194A5D0
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					void IEnumerator.Reset(); // 0x000000018194A6F0-0x000000018194A740
					void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
				}
	
				[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
				private sealed class ncEmMQmZXTGhsprJENHTzLdLOHc : IEnumerable<Platform_RawOrDirectInput.Button_Base>, IEnumerator<Platform_RawOrDirectInput.Button_Base> // TypeDefIndex: 6247
				{
					// Fields
					private Platform_RawOrDirectInput.Button_Base aSrFEaALHwhGTdXfCdeUqgbwaZGO; // 0x10
					private int eLrUhJFgzEZElCzdKvcrgOLXLvL; // 0x18
					private int RQaeFqcJnaOYpZSBxtfUkVOjfOo; // 0x1C
					public Elements gKPmvKLRxdGbmXiMfUeDjGbezUo; // 0x20
					public int TSuxJyNcYLrUoHKyJOizjwmLoiL; // 0x28
	
					// Properties
					Platform_RawOrDirectInput.Button_Base zZOeLQhakIZFsPvaKJkuaVXllVb { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372440-0x0000000180372450 
					object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372440-0x0000000180372450 
	
					// Constructors
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					public ncEmMQmZXTGhsprJENHTzLdLOHc(int <>1__state); // 0x00000001805EDEC0-0x00000001805EDF10
	
					// Methods
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					IEnumerator<Platform_RawOrDirectInput.Button_Base> System.Collections.Generic.IEnumerable<Rewired.Data.Mapping.HardwareJoystickMap.Platform_RawOrDirectInput.Button_Base>.GetEnumerator(); // 0x000000018194ABB0-0x000000018194ACC0
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					IEnumerator IEnumerable.GetEnumerator(); // 0x000000018194ABB0-0x000000018194ACC0
					private bool MoveNext(); // 0x000000018194AA80-0x000000018194ABB0
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					void IEnumerator.Reset(); // 0x000000018194ACC0-0x000000018194AD10
					void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
				}
	
				// Constructors
				public Elements(); // 0x00000001803F46D0-0x00000001803F46E0
	
				// Methods
				internal override Platform_RawOrDirectInput.Axis_Base GetAxis(int axisIndex); // 0x0000000181936140-0x00000001819361A0
				internal override ControllerElementType GetEffectiveElementIdentifierType(ControllerElementIdentifier elementIdentifier); // 0x0000000181937590-0x0000000181937730
				internal override bool GetEffectiveAxisRange(ControllerElementIdentifier elementIdentifier, out AxisRange axisRange); // 0x00000001819361A0-0x00000001819364D0
				public override object DeepClone(); // 0x0000000181935DD0-0x0000000181935E40
				internal override void CopyVars(Elements_Base destination); // 0x0000000181935BF0-0x0000000181935C80
			}
	
			[Serializable]
			[CustomClassObfuscation] // 0x0000000180207920-0x0000000180207950
			public sealed class Button : Platform_RawOrDirectInput.Button_Base // TypeDefIndex: 6248
			{
				// Fields
				public int sourceOtherAxis; // 0x68
	
				// Constructors
				public Button(); // 0x0000000181934D20-0x0000000181934D40
	
				// Methods
				public override object DeepClone(); // 0x0000000181935070-0x0000000181935200
				private void ImportVars(Button source); // 0x0000000181935270-0x00000001819353C0
			}
	
			[Serializable]
			[CustomClassObfuscation] // 0x0000000180207920-0x0000000180207950
			public sealed class Axis : Platform_RawOrDirectInput.Axis_Base // TypeDefIndex: 6249
			{
				// Fields
				public int sourceOtherAxis; // 0x70
	
				// Constructors
				public Axis(); // 0x0000000181933C00-0x0000000181933C20
	
				// Methods
				public override object DeepClone(); // 0x0000000181933E10-0x0000000181933FE0
				private void ImportVars(Axis source); // 0x00000001819341A0-0x0000000181934340
			}
	
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private sealed class pjWYBcCdPvcIjgOkrBoCnwFNssX : IEnumerable<Axis_Base>, IEnumerator<Axis_Base> // TypeDefIndex: 6250
			{
				// Fields
				private Platform_RawOrDirectInput.Axis_Base aSrFEaALHwhGTdXfCdeUqgbwaZGO; // 0x10
				private int eLrUhJFgzEZElCzdKvcrgOLXLvL; // 0x18
				private int RQaeFqcJnaOYpZSBxtfUkVOjfOo; // 0x1C
				public Platform_RawInput_Base gKPmvKLRxdGbmXiMfUeDjGbezUo; // 0x20
				public int qCwetSCDbWTjKMGWQjVhebbIpqKV; // 0x28
				public int VZDlfBYfiaqORQQmkhlkPLaImkr; // 0x2C
	
				// Properties
				Platform_RawOrDirectInput.Axis_Base nIKQstLqZCeOFdNDhBATHfuWIFQX { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372440-0x0000000180372450 
				object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372440-0x0000000180372450 
	
				// Constructors
				[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
				public pjWYBcCdPvcIjgOkrBoCnwFNssX(int <>1__state); // 0x00000001805EDEC0-0x00000001805EDF10
	
				// Methods
				[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
				IEnumerator<Platform_RawOrDirectInput.Axis_Base> System.Collections.Generic.IEnumerable<Rewired.Data.Mapping.HardwareJoystickMap.Platform_RawOrDirectInput.Axis_Base>.GetEnumerator(); // 0x000000018194AEA0-0x000000018194AFC0
				[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
				IEnumerator IEnumerable.GetEnumerator(); // 0x000000018194AEA0-0x000000018194AFC0
				private bool MoveNext(); // 0x000000018194AD10-0x000000018194AEA0
				[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
				void IEnumerator.Reset(); // 0x000000018194AFC0-0x000000018194B010
				void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			}
	
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private sealed class eMQgimYfDNqVQgjKSKCqoGCpzmG : IEnumerable<Button_Base>, IEnumerator<Button_Base> // TypeDefIndex: 6251
			{
				// Fields
				private Platform_RawOrDirectInput.Button_Base aSrFEaALHwhGTdXfCdeUqgbwaZGO; // 0x10
				private int eLrUhJFgzEZElCzdKvcrgOLXLvL; // 0x18
				private int RQaeFqcJnaOYpZSBxtfUkVOjfOo; // 0x1C
				public Platform_RawInput_Base gKPmvKLRxdGbmXiMfUeDjGbezUo; // 0x20
				public int JXAxJSdeQOWBLJdenjcnltZjsYA; // 0x28
				public int VaYSydAOGtprQGObyqqjpusKBHA; // 0x2C
	
				// Properties
				Platform_RawOrDirectInput.Button_Base zZOeLQhakIZFsPvaKJkuaVXllVb { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372440-0x0000000180372450 
				object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372440-0x0000000180372450 
	
				// Constructors
				[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
				public eMQgimYfDNqVQgjKSKCqoGCpzmG(int <>1__state); // 0x00000001805EDEC0-0x00000001805EDF10
	
				// Methods
				[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
				IEnumerator<Platform_RawOrDirectInput.Button_Base> System.Collections.Generic.IEnumerable<Rewired.Data.Mapping.HardwareJoystickMap.Platform_RawOrDirectInput.Button_Base>.GetEnumerator(); // 0x000000018194A350-0x000000018194A430
				[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
				IEnumerator IEnumerable.GetEnumerator(); // 0x000000018194A350-0x000000018194A430
				private bool MoveNext(); // 0x000000018194A1B0-0x000000018194A350
				[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
				void IEnumerator.Reset(); // 0x000000018194A430-0x000000018194A480
				void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			}
	
			// Constructors
			public Platform_RawInput_Base(); // 0x00000001803F46D0-0x00000001803F46E0
	
			// Methods
			internal override bool Matches(BridgedControllerHWInfo BridgedControllerHWInfo, bool strictMatch, out int variantIndex, out Rewired.Data.Mapping.HardwareJoystickMap.Platform platformMap); // 0x00000001818B1590-0x00000001818B15F0
			internal override string[] GetAxisNames(ControllerElementIdentifier[] identifiers); // 0x0000000181940F00-0x0000000181941200
			internal override string[] GetEffectiveButtonNames(ControllerElementIdentifier[] identifiers); // 0x0000000181941400-0x00000001819416B0
			internal override bool IsElementIdentifierMapped(int elementIdentifierId); // 0x0000000181941B30-0x0000000181941EC0
			internal override void GetGameElementIdentifierIdMappings(out int[] buttons, out int[] axes); // 0x00000001819416B0-0x0000000181941B30
			internal override AxisCalibrationData[] GetAxisCalibrationData(); // 0x0000000181940330-0x00000001819409D0
			internal override void GetAxisData(out AxisRange[] axisRanges, out HardwareAxisInfo[] axisInfos); // 0x00000001819409D0-0x0000000181940F00
			internal override void GetButtonData(out HardwareButtonInfo[] buttonInfos); // 0x0000000181941200-0x0000000181941400
			internal override ControllerElementType GetEffectiveElementIdentifierType(ControllerElementIdentifier elementIdentifier); // 0x00000001805F5B50-0x00000001805F5B70
			internal override bool GetEffectiveAxisRange(ControllerElementIdentifier elementIdentifier, out AxisRange axisRange); // 0x00000001805F5800-0x00000001805F5830
			internal override IEnumerable<Axis_Base> IterateAxes(); // 0x0000000181941EC0-0x0000000181941F40
			internal override IEnumerable<Button_Base> IterateButtons(); // 0x0000000181941F40-0x0000000181941FC0
			public override object DeepClone(); // 0x00000001819402C0-0x0000000181940330
			internal override void CopyVars(Rewired.Data.Mapping.HardwareJoystickMap.Platform destination); // 0x00000001819400F0-0x00000001819402C0
		}
	
		[Serializable]
		[CustomClassObfuscation] // 0x0000000180207920-0x0000000180207950
		public sealed class Platform_RawInput : Platform_RawInput_Base // TypeDefIndex: 6252
		{
			// Fields
			public Platform_RawInput_Base[] variants; // 0x28
	
			// Properties
			internal override IList<Rewired.Data.Mapping.HardwareJoystickMap.Platform> variants_base { get; } // 0x00000001803745B0-0x00000001803745C0 
	
			// Constructors
			public Platform_RawInput(); // 0x00000001803F46D0-0x00000001803F46E0
	
			// Methods
			internal override bool Matches(BridgedControllerHWInfo BridgedControllerHWInfo, bool strictMatch, out int variantIndex, out Rewired.Data.Mapping.HardwareJoystickMap.Platform platformMap); // 0x00000001819420D0-0x0000000181942280
			public override object DeepClone(); // 0x0000000181942060-0x00000001819420D0
			internal override void CopyVars(Rewired.Data.Mapping.HardwareJoystickMap.Platform destination); // 0x0000000181941FC0-0x0000000181942060
		}
	
		[Serializable]
		[CustomClassObfuscation] // 0x0000000180207920-0x0000000180207950
		public class Platform_XInput_Base : Rewired.Data.Mapping.HardwareJoystickMap.Platform // TypeDefIndex: 6253
		{
			// Fields
			public MatchingCriteria matchingCriteria; // 0x18
			public Elements elements; // 0x20
	
			// Properties
			public override int assignedButtonCount { get; } // 0x00000001805F64C0-0x00000001805F64E0 
			public override int assignedAxisCount { get; } // 0x00000001805F64A0-0x00000001805F64C0 
			internal override InputPlatform platform { get; } // 0x000000018043E010-0x000000018043E020 
			internal Axis[] Axes_orig { get; } // 0x00000001805F6480-0x00000001805F6490 
			internal Button[] Buttons_orig { get; } // 0x00000001805F6490-0x00000001805F64A0 
			internal override bool hasData { get; } // 0x00000001805F8790-0x00000001805F8810 
			internal override bool disabled { get; } // 0x00000001805F64E0-0x00000001805F64F0 
			internal override bool isAllowed { get; } // 0x00000001805F6560-0x00000001805F65A0 
			internal override Elements_Base elements_base { get; } // 0x0000000180374AF0-0x0000000180374B00 
			internal override IList<Rewired.Data.Mapping.HardwareJoystickMap.Platform> variants_base { get; } // 0x000000018037DDC0-0x000000018037DDD0 
	
			// Nested types
			[Serializable]
			[CustomClassObfuscation] // 0x0000000180207920-0x0000000180207950
			public sealed class MatchingCriteria : MatchingCriteria_Base // TypeDefIndex: 6254
			{
				// Fields
				public XInputDeviceSubType[] subType; // 0x28
	
				// Properties
				internal override bool hasData { get; } // 0x00000001805F4330-0x00000001805F4360 
				internal override bool isAllowed { get; } // 0x00000001805F43A0-0x00000001805F43C0 
				internal override int alternateElementCount { get; } // 0x000000018037DDC0-0x000000018037DDD0 
	
				// Constructors
				public MatchingCriteria(); // 0x00000001803F46D0-0x00000001803F46E0
	
				// Methods
				internal override bool Matches(BridgedControllerHWInfo bridgedControllerHWInfo, bool strictMatch); // 0x00000001805F3E40-0x00000001805F3F90
				internal override ElementCount_Base GetAlternateElementCount(int index); // 0x000000018037DDC0-0x000000018037DDD0
				internal override bool ElementCountsMatch(BridgedControllerHWInfo bridgedControllerHWInfo, out bool alternateMatched); // 0x00000001805F3C50-0x00000001805F3C60
				public override object DeepClone(); // 0x00000001805F3B60-0x00000001805F3BD0
				internal override void CopyVars(MatchingCriteria_Base destination); // 0x00000001805F3880-0x00000001805F3940
			}
	
			[Serializable]
			[CustomClassObfuscation] // 0x0000000180207920-0x0000000180207950
			public sealed class Elements : Elements_Base // TypeDefIndex: 6255
			{
				// Fields
				public Axis[] axes; // 0x10
				public Button[] buttons; // 0x18
	
				// Properties
				public override int buttonCount { get; } // 0x00000001805EF540-0x00000001805EF550 
				public override int axisCount { get; } // 0x00000001805EF530-0x00000001805EF540 
	
				// Constructors
				public Elements(); // 0x00000001803F46D0-0x00000001803F46E0
	
				// Methods
				public override object DeepClone(); // 0x00000001805EE560-0x00000001805EE5D0
				internal override void CopyVars(Elements_Base destination); // 0x00000001805EE490-0x00000001805EE560
				internal override ControllerElementType GetEffectiveElementIdentifierType(ControllerElementIdentifier elementIdentifier); // 0x00000001805EF0F0-0x00000001805EF280
				internal override bool GetEffectiveAxisRange(ControllerElementIdentifier elementIdentifier, out AxisRange axisRange); // 0x00000001805EEA50-0x00000001805EECD0
			}
	
			[Serializable]
			[CustomClassObfuscation] // 0x0000000180207920-0x0000000180207950
			public abstract class Element : IDeepCloneable // TypeDefIndex: 6256
			{
				// Fields
				public int elementIdentifier; // 0x10
				public HardwareElementSourceType sourceType; // 0x14
				public XInputButton sourceButton; // 0x18
				public XInputAxis sourceAxis; // 0x1C
				public float axisDeadZone; // 0x20
	
				// Constructors
				protected Element(); // 0x0000000180373240-0x0000000180373250
	
				// Methods
				public abstract object DeepClone();
				internal virtual void CopyVars(Element destination); // 0x00000001805EE2E0-0x00000001805EE340
			}
	
			[Serializable]
			[CustomClassObfuscation] // 0x0000000180207920-0x0000000180207950
			public sealed class Button : Element // TypeDefIndex: 6257
			{
				// Fields
				public Pole sourceAxisPole; // 0x28
				public HardwareButtonInfo buttonInfo; // 0x30
	
				// Constructors
				public Button(); // 0x00000001805ED040-0x00000001805ED060
	
				// Methods
				public override object DeepClone(); // 0x00000001805ECD70-0x00000001805ECE00
				internal override void CopyVars(Element destination); // 0x00000001805ECBD0-0x00000001805ECD00
			}
	
			[Serializable]
			[CustomClassObfuscation] // 0x0000000180207920-0x0000000180207950
			public sealed class Axis : Element // TypeDefIndex: 6258
			{
				// Fields
				public bool invert; // 0x28
				public Pole buttonAxisContribution; // 0x2C
				public AxisRange sourceAxisRange; // 0x30
				public bool calibrateAxis; // 0x34
				public float axisZero; // 0x38
				public float axisMin; // 0x3C
				public float axisMax; // 0x40
				public AxisCalibrationInfoEntry[] alternateCalibrations; // 0x48
				public HardwareAxisInfo axisInfo; // 0x50
	
				// Constructors
				public Axis(); // 0x00000001805ECB60-0x00000001805ECB80
	
				// Methods
				public override object DeepClone(); // 0x00000001805EC8B0-0x00000001805EC920
				internal override void CopyVars(Element destination); // 0x00000001805EC630-0x00000001805EC7F0
			}
	
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private sealed class yNKATGcFUiFMIQCemcgUaIQGBPAh : IEnumerable<Axis>, IEnumerator<Axis> // TypeDefIndex: 6259
			{
				// Fields
				private Axis aSrFEaALHwhGTdXfCdeUqgbwaZGO; // 0x10
				private int eLrUhJFgzEZElCzdKvcrgOLXLvL; // 0x18
				private int RQaeFqcJnaOYpZSBxtfUkVOjfOo; // 0x1C
				public Platform_XInput_Base gKPmvKLRxdGbmXiMfUeDjGbezUo; // 0x20
				public int xfCMKYvfPoZlxORLRgmIUZiDCmJ; // 0x28
	
				// Properties
				Axis kkTYawmetfTkdSzxbKSqTSRqrcW { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372440-0x0000000180372450 
				object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372440-0x0000000180372450 
	
				// Constructors
				[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
				public yNKATGcFUiFMIQCemcgUaIQGBPAh(int <>1__state); // 0x00000001805EDEC0-0x00000001805EDF10
	
				// Methods
				[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
				IEnumerator<Axis> System.Collections.Generic.IEnumerable<Rewired.Data.Mapping.HardwareJoystickMap.Platform_XInput_Base.Axis>.GetEnumerator(); // 0x000000018061A800-0x000000018061A900
				[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
				IEnumerator IEnumerable.GetEnumerator(); // 0x000000018061A800-0x000000018061A900
				private bool MoveNext(); // 0x000000018061A660-0x000000018061A800
				[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
				void IEnumerator.Reset(); // 0x000000018061A900-0x000000018061A950
				void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			}
	
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private sealed class DLVcZRCpGlVpNWhDtAmyJiwSnYKN : IEnumerable<Button>, IEnumerator<Button> // TypeDefIndex: 6260
			{
				// Fields
				private Button aSrFEaALHwhGTdXfCdeUqgbwaZGO; // 0x10
				private int eLrUhJFgzEZElCzdKvcrgOLXLvL; // 0x18
				private int RQaeFqcJnaOYpZSBxtfUkVOjfOo; // 0x1C
				public Platform_XInput_Base gKPmvKLRxdGbmXiMfUeDjGbezUo; // 0x20
				public int MZVOuEoNiLJQnLowXRbjOgPjHWp; // 0x28
	
				// Properties
				Button DkuCOqCnVxdHwaaNicstqpjazoeK { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372440-0x0000000180372450 
				object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372440-0x0000000180372450 
	
				// Constructors
				[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
				public DLVcZRCpGlVpNWhDtAmyJiwSnYKN(int <>1__state); // 0x00000001805EDEC0-0x00000001805EDF10
	
				// Methods
				[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
				IEnumerator<Button> System.Collections.Generic.IEnumerable<Rewired.Data.Mapping.HardwareJoystickMap.Platform_XInput_Base.Button>.GetEnumerator(); // 0x00000001805EDD80-0x00000001805EDE70
				[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
				IEnumerator IEnumerable.GetEnumerator(); // 0x00000001805EDD80-0x00000001805EDE70
				private bool MoveNext(); // 0x00000001805EDBF0-0x00000001805EDD80
				[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
				void IEnumerator.Reset(); // 0x00000001805EDE70-0x00000001805EDEC0
				void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			}
	
			// Constructors
			public Platform_XInput_Base(); // 0x00000001803F46D0-0x00000001803F46E0
	
			// Methods
			internal override bool Matches(BridgedControllerHWInfo BridgedControllerHWInfo, bool strictMatch, out int variantIndex, out Rewired.Data.Mapping.HardwareJoystickMap.Platform platformMap); // 0x00000001805F86E0-0x00000001805F8790
			internal IEnumerable<Axis> IterateAxes(); // 0x00000001805F85E0-0x00000001805F8660
			internal IEnumerable<Button> IterateButtons(); // 0x00000001805F8660-0x00000001805F86E0
			internal override string[] GetAxisNames(ControllerElementIdentifier[] identifiers); // 0x00000001805F75F0-0x00000001805F7890
			internal override string[] GetEffectiveButtonNames(ControllerElementIdentifier[] identifiers); // 0x00000001805F7AB0-0x00000001805F7D60
			internal override bool IsElementIdentifierMapped(int elementIdentifierId); // 0x00000001805F8260-0x00000001805F85E0
			internal override void GetGameElementIdentifierIdMappings(out int[] buttons, out int[] axes); // 0x00000001805F7D60-0x00000001805F8260
			internal override AxisCalibrationData[] GetAxisCalibrationData(); // 0x00000001805F6B60-0x00000001805F7130
			internal override void GetAxisData(out AxisRange[] axisRanges, out HardwareAxisInfo[] axisInfos); // 0x00000001805F7130-0x00000001805F75F0
			internal override void GetButtonData(out HardwareButtonInfo[] buttonInfos); // 0x00000001805F7890-0x00000001805F7AB0
			internal override ControllerElementType GetEffectiveElementIdentifierType(ControllerElementIdentifier elementIdentifier); // 0x00000001805F5B50-0x00000001805F5B70
			internal override bool GetEffectiveAxisRange(ControllerElementIdentifier elementIdentifier, out AxisRange axisRange); // 0x00000001805F5800-0x00000001805F5830
			public override object DeepClone(); // 0x00000001805F6AF0-0x00000001805F6B60
			internal override void CopyVars(Rewired.Data.Mapping.HardwareJoystickMap.Platform destination); // 0x00000001805F69F0-0x00000001805F6AF0
		}
	
		[Serializable]
		[CustomClassObfuscation] // 0x0000000180207920-0x0000000180207950
		public sealed class Platform_XInput : Platform_XInput_Base // TypeDefIndex: 6261
		{
			// Fields
			public Platform_XInput_Base[] variants; // 0x28
	
			// Properties
			internal override IList<Rewired.Data.Mapping.HardwareJoystickMap.Platform> variants_base { get; } // 0x00000001803745B0-0x00000001803745C0 
	
			// Constructors
			public Platform_XInput(); // 0x00000001803F46D0-0x00000001803F46E0
	
			// Methods
			internal override bool Matches(BridgedControllerHWInfo BridgedControllerHWInfo, bool strictMatch, out int variantIndex, out Rewired.Data.Mapping.HardwareJoystickMap.Platform platformMap); // 0x00000001805F89F0-0x00000001805F8BF0
			public override object DeepClone(); // 0x00000001805F8980-0x00000001805F89F0
			internal override void CopyVars(Rewired.Data.Mapping.HardwareJoystickMap.Platform destination); // 0x00000001805F8810-0x00000001805F8980
		}
	
		[Serializable]
		[CustomClassObfuscation] // 0x0000000180207920-0x0000000180207950
		public class Platform_OSX_Base : Rewired.Data.Mapping.HardwareJoystickMap.Platform // TypeDefIndex: 6262
		{
			// Fields
			public MatchingCriteria matchingCriteria; // 0x18
			public Elements elements; // 0x20
	
			// Properties
			public override int assignedButtonCount { get; } // 0x00000001805F64C0-0x00000001805F64E0 
			public override int assignedAxisCount { get; } // 0x00000001805F64A0-0x00000001805F64C0 
			internal override InputPlatform platform { get; } // 0x000000018069B0C0-0x000000018069B0D0 
			internal Button[] Buttons_orig { get; } // 0x00000001805F6490-0x00000001805F64A0 
			internal Axis[] Axes_orig { get; } // 0x00000001805F6480-0x00000001805F6490 
			internal override bool hasData { get; } // 0x00000001805F64F0-0x00000001805F6560 
			internal override bool disabled { get; } // 0x00000001805F64E0-0x00000001805F64F0 
			internal override bool isAllowed { get; } // 0x00000001805F6560-0x00000001805F65A0 
			internal override Elements_Base elements_base { get; } // 0x0000000180374AF0-0x0000000180374B00 
			internal override IList<Rewired.Data.Mapping.HardwareJoystickMap.Platform> variants_base { get; } // 0x000000018037DDC0-0x000000018037DDD0 
	
			// Nested types
			[Serializable]
			[CustomClassObfuscation] // 0x0000000180207920-0x0000000180207950
			public sealed class MatchingCriteria : MatchingCriteria_Base // TypeDefIndex: 6263
			{
				// Fields
				public int hatCount; // 0x28
				public ElementCount[] alternateElementCounts; // 0x30
				public bool productName_useRegex; // 0x38
				public string[] productName; // 0x40
				public string[] manufacturer; // 0x48
				public int[] productId; // 0x50
				public int[] vendorId; // 0x58
	
				// Properties
				internal override bool hasData { get; } // 0x00000001818AB140-0x00000001818AB190 
				internal override bool isAllowed { get; } // 0x00000001805F43A0-0x00000001805F43C0 
				internal override int alternateElementCount { get; } // 0x00000001805F42F0-0x00000001805F4300 
	
				// Nested types
				[Serializable]
				public sealed class ElementCount : MatchingCriteria_Base.ElementCount_Base // TypeDefIndex: 6264
				{
					// Fields
					public int hatCount; // 0x18
	
					// Constructors
					public ElementCount(); // 0x00000001803F46D0-0x00000001803F46E0
	
					// Methods
					public override object DeepClone(); // 0x00000001819358B0-0x0000000181935920
					internal override void CopyVars(MatchingCriteria_Base.ElementCount_Base param_0000d08e); // 0x0000000181935660-0x00000001819356D0
					internal override bool Matches(BridgedControllerHWInfo param_0000d08f); // 0x00000001805EE280-0x00000001805EE2E0
				}
	
				// Constructors
				public MatchingCriteria(); // 0x00000001803F46D0-0x00000001803F46E0
	
				// Methods
				internal override bool Matches(BridgedControllerHWInfo bridgedControllerHWInfo, bool strictMatch); // 0x00000001818AA7C0-0x00000001818AAB00
				internal override ElementCount_Base GetAlternateElementCount(int index); // 0x00000001818A9E90-0x00000001818A9EF0
				internal override bool ElementCountsMatch(BridgedControllerHWInfo bridgedControllerHWInfo, out bool alternateMatched); // 0x00000001805F3BD0-0x00000001805F3C50
				private bool ProductNameMatches(string name); // 0x00000001818AAE60-0x00000001818AAFD0
				public override object DeepClone(); // 0x00000001818A9DA0-0x00000001818A9E10
				internal override void CopyVars(MatchingCriteria_Base destination); // 0x00000001818A98D0-0x00000001818A9A10
			}
	
			[Serializable]
			[CustomClassObfuscation] // 0x0000000180207920-0x0000000180207950
			public sealed class Elements : Elements_Base // TypeDefIndex: 6265
			{
				// Fields
				public Axis[] axes; // 0x10
				public Button[] buttons; // 0x18
	
				// Properties
				public override int buttonCount { get; } // 0x00000001805EF540-0x00000001805EF550 
				public override int axisCount { get; } // 0x00000001805EF530-0x00000001805EF540 
	
				// Nested types
				[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
				private sealed class kDbuzYEUdiCPSbTPZYFihOJXRhw : IEnumerable<Axis>, IEnumerator<Axis> // TypeDefIndex: 6266
				{
					// Fields
					private Axis aSrFEaALHwhGTdXfCdeUqgbwaZGO; // 0x10
					private int eLrUhJFgzEZElCzdKvcrgOLXLvL; // 0x18
					private int RQaeFqcJnaOYpZSBxtfUkVOjfOo; // 0x1C
					public Elements gKPmvKLRxdGbmXiMfUeDjGbezUo; // 0x20
					public Axis QOtFKkQrUwtUqtExfAGADDPHJjEi; // 0x28
					public Axis[] AimIAUzWJzqRTvvRSOziblXXlgI; // 0x30
					public int VAKyJWebqWYoNZcQIucCIKwQFyU; // 0x38
	
					// Properties
					Axis CfEkCNzpsTELahprwjkzGdvFgYQb { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372440-0x0000000180372450 
					object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372440-0x0000000180372450 
	
					// Constructors
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					public kDbuzYEUdiCPSbTPZYFihOJXRhw(int <>1__state); // 0x00000001805EDEC0-0x00000001805EDF10
	
					// Methods
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					IEnumerator<Axis> System.Collections.Generic.IEnumerable<Rewired.Data.Mapping.HardwareJoystickMap.Platform_OSX_Base.Axis>.GetEnumerator(); // 0x00000001818B9B80-0x00000001818B9C80
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					IEnumerator IEnumerable.GetEnumerator(); // 0x00000001818B9B80-0x00000001818B9C80
					private bool MoveNext(); // 0x00000001818B9A00-0x00000001818B9B80
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					void IEnumerator.Reset(); // 0x00000001818B9C80-0x00000001818B9CD0
					void IDisposable.Dispose(); // 0x00000001818B9070-0x00000001818B9090
					private void NbSadJNcFYcYqjFnHjxEdPkHvKqk(); // 0x00000001810467B0-0x00000001810467C0
				}
	
				[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
				private sealed class YuvaJpdWFSgCOICIJJGRUeMgqCWt : IEnumerable<Button>, IEnumerator<Button> // TypeDefIndex: 6267
				{
					// Fields
					private Button aSrFEaALHwhGTdXfCdeUqgbwaZGO; // 0x10
					private int eLrUhJFgzEZElCzdKvcrgOLXLvL; // 0x18
					private int RQaeFqcJnaOYpZSBxtfUkVOjfOo; // 0x1C
					public Elements gKPmvKLRxdGbmXiMfUeDjGbezUo; // 0x20
					public Button GpOFkhnPLrDpjtOBIuvAAnRIAmN; // 0x28
					public Button[] JAMgVrOdqZjCyRKutWYwxsNXFwE; // 0x30
					public int FvYAMRTUvsMUpgFZUmfjCbmhqlc; // 0x38
	
					// Properties
					Button gWqIzXkAxaffWVYBlScaueomugN { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372440-0x0000000180372450 
					object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372440-0x0000000180372450 
	
					// Constructors
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					public YuvaJpdWFSgCOICIJJGRUeMgqCWt(int <>1__state); // 0x00000001805EDEC0-0x00000001805EDF10
	
					// Methods
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					IEnumerator<Button> System.Collections.Generic.IEnumerable<Rewired.Data.Mapping.HardwareJoystickMap.Platform_OSX_Base.Button>.GetEnumerator(); // 0x00000001818B8F30-0x00000001818B9020
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					IEnumerator IEnumerable.GetEnumerator(); // 0x00000001818B8F30-0x00000001818B9020
					private bool MoveNext(); // 0x00000001818B8D40-0x00000001818B8F30
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					void IEnumerator.Reset(); // 0x00000001818B9020-0x00000001818B9070
					void IDisposable.Dispose(); // 0x00000001818B9070-0x00000001818B9090
					private void JwqjSHmXKMJEmMfHoasgibmAIyum(); // 0x00000001810467B0-0x00000001810467C0
				}
	
				// Constructors
				public Elements(); // 0x00000001803F46D0-0x00000001803F46E0
	
				// Methods
				public IEnumerable<Axis> IterateAxes(); // 0x00000001818A84D0-0x00000001818A8550
				public IEnumerable<Button> IterateButtons(); // 0x00000001818A8550-0x00000001818A85F0
				public override object DeepClone(); // 0x00000001818A6720-0x00000001818A6790
				internal override void CopyVars(Elements_Base destination); // 0x00000001818A6410-0x00000001818A64A0
				internal override ControllerElementType GetEffectiveElementIdentifierType(ControllerElementIdentifier elementIdentifier); // 0x00000001818A7C50-0x00000001818A7DF0
				internal override bool GetEffectiveAxisRange(ControllerElementIdentifier elementIdentifier, out AxisRange axisRange); // 0x00000001818A6E60-0x00000001818A71B0
			}
	
			[Serializable]
			[CustomClassObfuscation] // 0x0000000180207920-0x0000000180207950
			public abstract class Element : IDeepCloneable // TypeDefIndex: 6268
			{
				// Constructors
				protected Element(); // 0x0000000180373240-0x0000000180373250
	
				// Methods
				public abstract object DeepClone();
			}
	
			[Serializable]
			[CustomClassObfuscation] // 0x0000000180207920-0x0000000180207950
			public sealed class Button : Element // TypeDefIndex: 6269
			{
				// Fields
				public int elementIdentifier; // 0x10
				public HardwareElementSourceTypeWithHat sourceType; // 0x14
				public int sourceButton; // 0x18
				public int sourceStick; // 0x1C
				public OSXAxis sourceAxis; // 0x20
				public int sourceOtherAxis; // 0x24
				public Pole sourceAxisPole; // 0x28
				public float axisDeadZone; // 0x2C
				public int sourceHat; // 0x30
				public HatType sourceHatType; // 0x34
				public HatDirection sourceHatDirection; // 0x38
				public bool requireMultipleButtons; // 0x3C
				public int[] requiredButtons; // 0x40
				public bool ignoreIfButtonsActive; // 0x48
				public int[] ignoreIfButtonsActiveButtons; // 0x50
				public HardwareButtonInfo buttonInfo; // 0x58
	
				// Constructors
				public Button(); // 0x00000001805ED040-0x00000001805ED060
	
				// Methods
				public override object DeepClone(); // 0x00000001818A4BD0-0x00000001818A4D80
			}
	
			[Serializable]
			[CustomClassObfuscation] // 0x0000000180207920-0x0000000180207950
			public sealed class Axis : Element // TypeDefIndex: 6270
			{
				// Fields
				public int elementIdentifier; // 0x10
				public HardwareElementSourceTypeWithHat sourceType; // 0x14
				public int sourceStick; // 0x18
				public OSXAxis sourceAxis; // 0x1C
				public int sourceOtherAxis; // 0x20
				public AxisRange sourceAxisRange; // 0x24
				public bool invert; // 0x28
				public float axisDeadZone; // 0x2C
				public bool calibrateAxis; // 0x30
				public float axisZero; // 0x34
				public float axisMin; // 0x38
				public float axisMax; // 0x3C
				public AxisCalibrationInfoEntry[] alternateCalibrations; // 0x40
				public HardwareAxisInfo axisInfo; // 0x48
				public int sourceButton; // 0x50
				public Pole buttonAxisContribution; // 0x54
				public int sourceHat; // 0x58
				public AxisDirection sourceHatDirection; // 0x5C
				public AxisRange sourceHatRange; // 0x60
	
				// Constructors
				public Axis(); // 0x00000001818A45D0-0x00000001818A4610
	
				// Methods
				public override object DeepClone(); // 0x00000001818A41D0-0x00000001818A43B0
			}
	
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private sealed class yXuDCkhCyNabCiVDcabaQZoFldI : IEnumerable<Axis>, IEnumerator<Axis> // TypeDefIndex: 6271
			{
				// Fields
				private Axis aSrFEaALHwhGTdXfCdeUqgbwaZGO; // 0x10
				private int eLrUhJFgzEZElCzdKvcrgOLXLvL; // 0x18
				private int RQaeFqcJnaOYpZSBxtfUkVOjfOo; // 0x1C
				public Platform_OSX_Base gKPmvKLRxdGbmXiMfUeDjGbezUo; // 0x20
				public int UuBHjaWNzMERnxPaKiEarPHMoNP; // 0x28
	
				// Properties
				Axis CfEkCNzpsTELahprwjkzGdvFgYQb { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372440-0x0000000180372450 
				object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372440-0x0000000180372450 
	
				// Constructors
				[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
				public yXuDCkhCyNabCiVDcabaQZoFldI(int <>1__state); // 0x00000001805EDEC0-0x00000001805EDF10
	
				// Methods
				[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
				IEnumerator<Axis> System.Collections.Generic.IEnumerable<Rewired.Data.Mapping.HardwareJoystickMap.Platform_OSX_Base.Axis>.GetEnumerator(); // 0x000000018194B460-0x000000018194B550
				[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
				IEnumerator IEnumerable.GetEnumerator(); // 0x000000018194B460-0x000000018194B550
				private bool MoveNext(); // 0x000000018194B2C0-0x000000018194B460
				[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
				void IEnumerator.Reset(); // 0x000000018194B550-0x000000018194BC30
				void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			}
	
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private sealed class DCemplDjAOrRnMGrpnPUBhYToXq : IEnumerable<Button>, IEnumerator<Button> // TypeDefIndex: 6272
			{
				// Fields
				private Button aSrFEaALHwhGTdXfCdeUqgbwaZGO; // 0x10
				private int eLrUhJFgzEZElCzdKvcrgOLXLvL; // 0x18
				private int RQaeFqcJnaOYpZSBxtfUkVOjfOo; // 0x1C
				public Platform_OSX_Base gKPmvKLRxdGbmXiMfUeDjGbezUo; // 0x20
				public int kxwmRLvHnnFFMquAMAVEGqrKOkj; // 0x28
	
				// Properties
				Button gWqIzXkAxaffWVYBlScaueomugN { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372440-0x0000000180372450 
				object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372440-0x0000000180372450 
	
				// Constructors
				[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
				public DCemplDjAOrRnMGrpnPUBhYToXq(int <>1__state); // 0x00000001805EDEC0-0x00000001805EDF10
	
				// Methods
				[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
				IEnumerator<Button> System.Collections.Generic.IEnumerable<Rewired.Data.Mapping.HardwareJoystickMap.Platform_OSX_Base.Button>.GetEnumerator(); // 0x00000001818A5440-0x00000001818A5540
				[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
				IEnumerator IEnumerable.GetEnumerator(); // 0x00000001818A5440-0x00000001818A5540
				private bool MoveNext(); // 0x00000001818A52B0-0x00000001818A5440
				[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
				void IEnumerator.Reset(); // 0x00000001818A5540-0x00000001818A5590
				void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			}
	
			// Constructors
			public Platform_OSX_Base(); // 0x00000001803F46D0-0x00000001803F46E0
	
			// Methods
			internal override bool Matches(BridgedControllerHWInfo BridgedControllerHWInfo, bool strictMatch, out int variantIndex, out Rewired.Data.Mapping.HardwareJoystickMap.Platform platformMap); // 0x00000001818B8240-0x00000001818B82E0
			internal IEnumerable<Axis> IterateAxes(); // 0x00000001818B8150-0x00000001818B81C0
			internal IEnumerable<Button> IterateButtons(); // 0x00000001818B81C0-0x00000001818B8240
			internal override string[] GetAxisNames(ControllerElementIdentifier[] identifiers); // 0x00000001818B6EE0-0x00000001818B7410
			internal override string[] GetEffectiveButtonNames(ControllerElementIdentifier[] identifiers); // 0x00000001818B7630-0x00000001818B7910
			internal override bool IsElementIdentifierMapped(int elementIdentifierId); // 0x00000001818B7E50-0x00000001818B8150
			internal override void GetGameElementIdentifierIdMappings(out int[] buttons, out int[] axes); // 0x00000001818B7910-0x00000001818B7E50
			internal override AxisCalibrationData[] GetAxisCalibrationData(); // 0x00000001818B6410-0x00000001818B6A20
			internal override void GetAxisData(out AxisRange[] axisRanges, out HardwareAxisInfo[] axisInfos); // 0x00000001818B6A20-0x00000001818B6EE0
			internal override void GetButtonData(out HardwareButtonInfo[] buttonInfos); // 0x00000001818B7410-0x00000001818B7630
			internal override ControllerElementType GetEffectiveElementIdentifierType(ControllerElementIdentifier elementIdentifier); // 0x00000001805F5B50-0x00000001805F5B70
			internal override bool GetEffectiveAxisRange(ControllerElementIdentifier elementIdentifier, out AxisRange axisRange); // 0x00000001805F5800-0x00000001805F5830
			public override object DeepClone(); // 0x00000001818B63A0-0x00000001818B6410
			internal override void CopyVars(Rewired.Data.Mapping.HardwareJoystickMap.Platform destination); // 0x00000001818B62A0-0x00000001818B63A0
		}
	
		[Serializable]
		[CustomClassObfuscation] // 0x0000000180207920-0x0000000180207950
		public sealed class Platform_OSX : Platform_OSX_Base // TypeDefIndex: 6273
		{
			// Fields
			public Platform_OSX_Base[] variants; // 0x28
	
			// Properties
			internal override IList<Rewired.Data.Mapping.HardwareJoystickMap.Platform> variants_base { get; } // 0x00000001803745B0-0x00000001803745C0 
	
			// Constructors
			public Platform_OSX(); // 0x00000001803F46D0-0x00000001803F46E0
	
			// Methods
			internal override bool Matches(BridgedControllerHWInfo BridgedControllerHWInfo, bool strictMatch, out int variantIndex, out Rewired.Data.Mapping.HardwareJoystickMap.Platform platformMap); // 0x00000001818B8530-0x00000001818B8750
			public override object DeepClone(); // 0x00000001818B84C0-0x00000001818B8530
			internal override void CopyVars(Rewired.Data.Mapping.HardwareJoystickMap.Platform destination); // 0x00000001818B82E0-0x00000001818B84C0
		}
	
		[Serializable]
		[CustomClassObfuscation] // 0x0000000180207920-0x0000000180207950
		public class Platform_Linux_Base : Rewired.Data.Mapping.HardwareJoystickMap.Platform // TypeDefIndex: 6274
		{
			// Fields
			public MatchingCriteria matchingCriteria; // 0x18
			public Elements elements; // 0x20
	
			// Properties
			internal override InputPlatform platform { get; } // 0x0000000180CA1280-0x0000000180CA1290 
			internal override bool hasData { get; } // 0x00000001805F64F0-0x00000001805F6560 
			internal override bool disabled { get; } // 0x00000001805F64E0-0x00000001805F64F0 
			internal override bool isAllowed { get; } // 0x00000001805F6560-0x00000001805F65A0 
			internal Axis[] Axes_orig { get; } // 0x00000001805F6480-0x00000001805F6490 
			internal Button[] Buttons_orig { get; } // 0x00000001805F6490-0x00000001805F64A0 
			internal override IList<Rewired.Data.Mapping.HardwareJoystickMap.Platform> variants_base { get; } // 0x000000018037DDC0-0x000000018037DDD0 
			public override int assignedButtonCount { get; } // 0x00000001805F64C0-0x00000001805F64E0 
			public override int assignedAxisCount { get; } // 0x00000001805F64A0-0x00000001805F64C0 
			internal override Elements_Base elements_base { get; } // 0x0000000180374AF0-0x0000000180374B00 
	
			// Nested types
			[Serializable]
			[CustomClassObfuscation] // 0x0000000180207920-0x0000000180207950
			public sealed class MatchingCriteria : MatchingCriteria_Base // TypeDefIndex: 6275
			{
				// Fields
				public int hatCount; // 0x28
				public ElementCount[] alternateElementCounts; // 0x30
				public bool manufacturer_useRegex; // 0x38
				public bool productName_useRegex; // 0x39
				public bool systemName_useRegex; // 0x3A
				public string[] manufacturer; // 0x40
				public string[] productName; // 0x48
				public string[] systemName; // 0x50
				public string[] productGUID; // 0x58
	
				// Properties
				internal override bool hasData { get; } // 0x00000001818AB1E0-0x00000001818AB210 
				internal override bool isAllowed { get; } // 0x00000001805F43A0-0x00000001805F43C0 
				internal override int alternateElementCount { get; } // 0x00000001805F42F0-0x00000001805F4300 
	
				// Nested types
				[Serializable]
				public sealed class ElementCount : MatchingCriteria_Base.ElementCount_Base // TypeDefIndex: 6276
				{
					// Fields
					public int hatCount; // 0x18
	
					// Constructors
					public ElementCount(); // 0x00000001803F46D0-0x00000001803F46E0
	
					// Methods
					public override object DeepClone(); // 0x00000001818A5F80-0x00000001818A5FF0
					internal override void CopyVars(MatchingCriteria_Base.ElementCount_Base param_0000d0b7); // 0x00000001818A5EE0-0x00000001818A5F80
					internal override bool Matches(BridgedControllerHWInfo param_0000d0b8); // 0x00000001805EE280-0x00000001805EE2E0
				}
	
				// Constructors
				public MatchingCriteria(); // 0x00000001803F46D0-0x00000001803F46E0
	
				// Methods
				internal override bool Matches(BridgedControllerHWInfo bridgedControllerHWInfo, bool strictMatch); // 0x00000001818AA010-0x00000001818AA1B0
				internal override ElementCount_Base GetAlternateElementCount(int index); // 0x00000001818A9EF0-0x00000001818A9F70
				internal override bool ElementCountsMatch(BridgedControllerHWInfo bridgedControllerHWInfo, out bool alternateMatched); // 0x00000001805F3BD0-0x00000001805F3C50
				private bool AnyNameMatches(BridgedControllerHWInfo bridgedControllerHWInfo); // 0x00000001818A90E0-0x00000001818A93A0
				private bool NameMatches(string name, string[] names, bool useRegex); // 0x00000001818AAD20-0x00000001818AAE60
				public override object DeepClone(); // 0x00000001818A9BE0-0x00000001818A9C50
				internal override void CopyVars(MatchingCriteria_Base destination); // 0x00000001818A9490-0x00000001818A9600
			}
	
			[Serializable]
			[CustomClassObfuscation] // 0x0000000180207920-0x0000000180207950
			public sealed class Elements : Elements_Base // TypeDefIndex: 6277
			{
				// Fields
				public Axis[] axes; // 0x10
				public Button[] buttons; // 0x18
	
				// Properties
				public override int buttonCount { get; } // 0x00000001805EF540-0x00000001805EF550 
				public override int axisCount { get; } // 0x00000001805EF530-0x00000001805EF540 
				internal IEnumerable<Axis> Axes { get; } // 0x00000001818A8670-0x00000001818A86F0 
				internal IEnumerable<Button> Buttons { get; } // 0x00000001818A86F0-0x00000001818A8770 
	
				// Nested types
				[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
				private sealed class DIHrPacQyBgThcmQCQjVyqcxCENB : IEnumerable<Axis>, IEnumerator<Axis> // TypeDefIndex: 6278
				{
					// Fields
					private Axis aSrFEaALHwhGTdXfCdeUqgbwaZGO; // 0x10
					private int eLrUhJFgzEZElCzdKvcrgOLXLvL; // 0x18
					private int RQaeFqcJnaOYpZSBxtfUkVOjfOo; // 0x1C
					public Elements gKPmvKLRxdGbmXiMfUeDjGbezUo; // 0x20
					public int dlKRMznfHnrnlQhwLbzadzNerVV; // 0x28
	
					// Properties
					Axis IyWeLCDkxJwNmWNnkaEjzUfTboM { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372440-0x0000000180372450 
					object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372440-0x0000000180372450 
	
					// Constructors
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					public DIHrPacQyBgThcmQCQjVyqcxCENB(int <>1__state); // 0x00000001805EDEC0-0x00000001805EDF10
	
					// Methods
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					IEnumerator<Axis> System.Collections.Generic.IEnumerable<Rewired.Data.Mapping.HardwareJoystickMap.Platform_Linux_Base.Axis>.GetEnumerator(); // 0x00000001818A56E0-0x00000001818A57D0
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					IEnumerator IEnumerable.GetEnumerator(); // 0x00000001818A56E0-0x00000001818A57D0
					private bool MoveNext(); // 0x00000001818A5590-0x00000001818A56E0
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					void IEnumerator.Reset(); // 0x00000001818A57D0-0x00000001818A5820
					void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
				}
	
				[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
				private sealed class pDBLejlzqSJKuFhKdCHJMFCkWeC : IEnumerable<Button>, IEnumerator<Button> // TypeDefIndex: 6279
				{
					// Fields
					private Button aSrFEaALHwhGTdXfCdeUqgbwaZGO; // 0x10
					private int eLrUhJFgzEZElCzdKvcrgOLXLvL; // 0x18
					private int RQaeFqcJnaOYpZSBxtfUkVOjfOo; // 0x1C
					public Elements gKPmvKLRxdGbmXiMfUeDjGbezUo; // 0x20
					public int LROsuEcktDbMxHKcISgPlKzWdoWH; // 0x28
	
					// Properties
					Button AUongXdidwGNxOEzZZPzxKjkBG { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372440-0x0000000180372450 
					object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372440-0x0000000180372450 
	
					// Constructors
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					public pDBLejlzqSJKuFhKdCHJMFCkWeC(int <>1__state); // 0x00000001805EDEC0-0x00000001805EDF10
	
					// Methods
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					IEnumerator<Button> System.Collections.Generic.IEnumerable<Rewired.Data.Mapping.HardwareJoystickMap.Platform_Linux_Base.Button>.GetEnumerator(); // 0x00000001818BA100-0x00000001818BA250
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					IEnumerator IEnumerable.GetEnumerator(); // 0x00000001818BA100-0x00000001818BA250
					private bool MoveNext(); // 0x00000001818B9FB0-0x00000001818BA100
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					void IEnumerator.Reset(); // 0x00000001818BA250-0x00000001818BA2A0
					void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
				}
	
				// Constructors
				public Elements(); // 0x00000001803F46D0-0x00000001803F46E0
	
				// Methods
				internal Axis GetAxis(int axisIndex); // 0x00000001818A6860-0x00000001818A68A0
				internal override ControllerElementType GetEffectiveElementIdentifierType(ControllerElementIdentifier elementIdentifier); // 0x00000001818A7AB0-0x00000001818A7C50
				internal override bool GetEffectiveAxisRange(ControllerElementIdentifier elementIdentifier, out AxisRange axisRange); // 0x00000001818A7770-0x00000001818A7AB0
				public override object DeepClone(); // 0x00000001818A6560-0x00000001818A65D0
				internal override void CopyVars(Elements_Base destination); // 0x00000001818A62E0-0x00000001818A6380
			}
	
			[Serializable]
			[CustomClassObfuscation] // 0x0000000180207920-0x0000000180207950
			public abstract class Element : IDeepCloneable // TypeDefIndex: 6280
			{
				// Constructors
				protected Element(); // 0x0000000180373240-0x0000000180373250
	
				// Methods
				public abstract object DeepClone();
				protected virtual void ImportVars(Element source); // 0x00000001803774A0-0x00000001803774B0
			}
	
			[Serializable]
			[CustomClassObfuscation] // 0x0000000180207920-0x0000000180207950
			public class Button : Element // TypeDefIndex: 6281
			{
				// Fields
				public int elementIdentifier; // 0x10
				public HardwareElementSourceTypeWithHat sourceType; // 0x14
				public int sourceButton; // 0x18
				public int sourceAxis; // 0x1C
				public Pole sourceAxisPole; // 0x20
				public float axisDeadZone; // 0x24
				public int sourceHat; // 0x28
				public HatType sourceHatType; // 0x2C
				public HatDirection sourceHatDirection; // 0x30
				public bool requireMultipleButtons; // 0x34
				public int[] requiredButtons; // 0x38
				public bool ignoreIfButtonsActive; // 0x40
				public int[] ignoreIfButtonsActiveButtons; // 0x48
				public HardwareButtonInfo buttonInfo; // 0x50
	
				// Constructors
				public Button(); // 0x00000001805ED040-0x00000001805ED060
	
				// Methods
				public override object DeepClone(); // 0x00000001818A4E60-0x00000001818A4ED0
				protected override void ImportVars(Element source); // 0x00000001818A4F50-0x00000001818A5160
			}
	
			[Serializable]
			[CustomClassObfuscation] // 0x0000000180207920-0x0000000180207950
			public class Axis : Element // TypeDefIndex: 6282
			{
				// Fields
				public int elementIdentifier; // 0x10
				public HardwareElementSourceTypeWithHat sourceType; // 0x14
				public int sourceAxis; // 0x18
				public AxisRange sourceAxisRange; // 0x1C
				public bool invert; // 0x20
				public float axisDeadZone; // 0x24
				public bool calibrateAxis; // 0x28
				public float axisZero; // 0x2C
				public float axisMin; // 0x30
				public float axisMax; // 0x34
				public AxisCalibrationInfoEntry[] alternateCalibrations; // 0x38
				public HardwareAxisInfo axisInfo; // 0x40
				public int sourceButton; // 0x48
				public Pole buttonAxisContribution; // 0x4C
				public int sourceHat; // 0x50
				public AxisDirection sourceHatDirection; // 0x54
				public AxisRange sourceHatRange; // 0x58
	
				// Constructors
				public Axis(); // 0x00000001805ECB60-0x00000001805ECB80
	
				// Methods
				public override object DeepClone(); // 0x00000001818A4010-0x00000001818A4080
				protected override void ImportVars(Element source); // 0x00000001818A43C0-0x00000001818A45D0
			}
	
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private sealed class JVXtMysADmgBqblnlNmzoXWmalO : IEnumerable<Axis>, IEnumerator<Axis> // TypeDefIndex: 6283
			{
				// Fields
				private Axis aSrFEaALHwhGTdXfCdeUqgbwaZGO; // 0x10
				private int eLrUhJFgzEZElCzdKvcrgOLXLvL; // 0x18
				private int RQaeFqcJnaOYpZSBxtfUkVOjfOo; // 0x1C
				public Platform_Linux_Base gKPmvKLRxdGbmXiMfUeDjGbezUo; // 0x20
				public int DQgGjJPVnlmajRZeDWFlRjZvapb; // 0x28
				public int LsKMPEjXVYvqLhjsSaDRCRIiJDb; // 0x2C
	
				// Properties
				Axis IyWeLCDkxJwNmWNnkaEjzUfTboM { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372440-0x0000000180372450 
				object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372440-0x0000000180372450 
	
				// Constructors
				[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
				public JVXtMysADmgBqblnlNmzoXWmalO(int <>1__state); // 0x00000001805EDEC0-0x00000001805EDF10
	
				// Methods
				[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
				IEnumerator<Axis> System.Collections.Generic.IEnumerable<Rewired.Data.Mapping.HardwareJoystickMap.Platform_Linux_Base.Axis>.GetEnumerator(); // 0x00000001818A8FA0-0x00000001818A9090
				[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
				IEnumerator IEnumerable.GetEnumerator(); // 0x00000001818A8FA0-0x00000001818A9090
				private bool MoveNext(); // 0x00000001818A8E10-0x00000001818A8FA0
				[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
				void IEnumerator.Reset(); // 0x00000001818A9090-0x00000001818A90E0
				void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			}
	
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private sealed class mjzhtqKOdNSquXxFsFenMpwUARnd : IEnumerable<Button>, IEnumerator<Button> // TypeDefIndex: 6284
			{
				// Fields
				private Button aSrFEaALHwhGTdXfCdeUqgbwaZGO; // 0x10
				private int eLrUhJFgzEZElCzdKvcrgOLXLvL; // 0x18
				private int RQaeFqcJnaOYpZSBxtfUkVOjfOo; // 0x1C
				public Platform_Linux_Base gKPmvKLRxdGbmXiMfUeDjGbezUo; // 0x20
				public int iyuUZlobwtvyFhpacnGPFjIAtfk; // 0x28
				public int wXaidXRczYWwFUHadDdLikkBUPj; // 0x2C
	
				// Properties
				Button AUongXdidwGNxOEzZZPzxKjkBG { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372440-0x0000000180372450 
				object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372440-0x0000000180372450 
	
				// Constructors
				[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
				public mjzhtqKOdNSquXxFsFenMpwUARnd(int <>1__state); // 0x00000001805EDEC0-0x00000001805EDF10
	
				// Methods
				[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
				IEnumerator<Button> System.Collections.Generic.IEnumerable<Rewired.Data.Mapping.HardwareJoystickMap.Platform_Linux_Base.Button>.GetEnumerator(); // 0x00000001818B9E70-0x00000001818B9F60
				[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
				IEnumerator IEnumerable.GetEnumerator(); // 0x00000001818B9E70-0x00000001818B9F60
				private bool MoveNext(); // 0x00000001818B9CD0-0x00000001818B9E70
				[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
				void IEnumerator.Reset(); // 0x00000001818B9F60-0x00000001818B9FB0
				void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			}
	
			// Constructors
			public Platform_Linux_Base(); // 0x00000001803F46D0-0x00000001803F46E0
	
			// Methods
			internal override bool Matches(BridgedControllerHWInfo BridgedControllerHWInfo, bool strictMatch, out int variantIndex, out Rewired.Data.Mapping.HardwareJoystickMap.Platform platformMap); // 0x00000001818B1590-0x00000001818B15F0
			internal override string[] GetAxisNames(ControllerElementIdentifier[] identifiers); // 0x00000001818B2950-0x00000001818B2C30
			internal override string[] GetEffectiveButtonNames(ControllerElementIdentifier[] identifiers); // 0x00000001818B2E20-0x00000001818B30F0
			internal override bool IsElementIdentifierMapped(int elementIdentifierId); // 0x00000001818B3490-0x00000001818B3840
			internal override void GetGameElementIdentifierIdMappings(out int[] buttons, out int[] axes); // 0x00000001818B30F0-0x00000001818B3490
			internal override AxisCalibrationData[] GetAxisCalibrationData(); // 0x00000001818B1ED0-0x00000001818B24A0
			internal override void GetAxisData(out AxisRange[] axisRanges, out HardwareAxisInfo[] axisInfos); // 0x00000001818B24A0-0x00000001818B2950
			internal override void GetButtonData(out HardwareButtonInfo[] buttonInfos); // 0x00000001818B2C30-0x00000001818B2E20
			internal override ControllerElementType GetEffectiveElementIdentifierType(ControllerElementIdentifier elementIdentifier); // 0x00000001805F5B50-0x00000001805F5B70
			internal override bool GetEffectiveAxisRange(ControllerElementIdentifier elementIdentifier, out AxisRange axisRange); // 0x00000001805F5800-0x00000001805F5830
			internal IEnumerable<Axis> IterateAxes(); // 0x00000001818B3840-0x00000001818B38C0
			internal IEnumerable<Button> IterateButtons(); // 0x00000001818B38C0-0x00000001818B3940
			public override object DeepClone(); // 0x00000001818B1E60-0x00000001818B1ED0
			internal override void CopyVars(Rewired.Data.Mapping.HardwareJoystickMap.Platform destination); // 0x00000001818B1D70-0x00000001818B1E60
		}
	
		[Serializable]
		[CustomClassObfuscation] // 0x0000000180207920-0x0000000180207950
		public sealed class Platform_Linux : Platform_Linux_Base // TypeDefIndex: 6285
		{
			// Fields
			public Platform_Linux_Base[] variants; // 0x28
	
			// Properties
			internal override IList<Rewired.Data.Mapping.HardwareJoystickMap.Platform> variants_base { get; } // 0x00000001803745B0-0x00000001803745C0 
	
			// Constructors
			public Platform_Linux(); // 0x00000001803F46D0-0x00000001803F46E0
	
			// Methods
			internal override bool Matches(BridgedControllerHWInfo BridgedControllerHWInfo, bool strictMatch, out int variantIndex, out Rewired.Data.Mapping.HardwareJoystickMap.Platform platformMap); // 0x00000001818B3B50-0x00000001818B3D00
			public override object DeepClone(); // 0x00000001818B3AE0-0x00000001818B3B50
			internal override void CopyVars(Rewired.Data.Mapping.HardwareJoystickMap.Platform destination); // 0x00000001818B3940-0x00000001818B3AE0
		}
	
		[Serializable]
		[CustomClassObfuscation] // 0x0000000180207920-0x0000000180207950
		public class Platform_WindowsUWP_Base : Rewired.Data.Mapping.HardwareJoystickMap.Platform // TypeDefIndex: 6286
		{
			// Fields
			public MatchingCriteria matchingCriteria; // 0x18
			public Elements elements; // 0x20
	
			// Properties
			internal override InputPlatform platform { get; } // 0x000000018040D640-0x000000018040D650 
			internal override bool hasData { get; } // 0x00000001805F64F0-0x00000001805F6560 
			internal override bool disabled { get; } // 0x00000001805F64E0-0x00000001805F64F0 
			internal override bool isAllowed { get; } // 0x00000001805F6560-0x00000001805F65A0 
			internal Axis[] Axes_orig { get; } // 0x00000001805F6480-0x00000001805F6490 
			internal Button[] Buttons_orig { get; } // 0x00000001805F6490-0x00000001805F64A0 
			internal override IList<Rewired.Data.Mapping.HardwareJoystickMap.Platform> variants_base { get; } // 0x000000018037DDC0-0x000000018037DDD0 
			public override int assignedButtonCount { get; } // 0x00000001805F64C0-0x00000001805F64E0 
			public override int assignedAxisCount { get; } // 0x00000001805F64A0-0x00000001805F64C0 
			internal override Elements_Base elements_base { get; } // 0x0000000180374AF0-0x0000000180374B00 
	
			// Nested types
			[Serializable]
			[CustomClassObfuscation] // 0x0000000180207920-0x0000000180207950
			public sealed class MatchingCriteria : MatchingCriteria_Base // TypeDefIndex: 6287
			{
				// Fields
				public int hatCount; // 0x28
				public ElementCount[] alternateElementCounts; // 0x30
				public bool manufacturer_useRegex; // 0x38
				public bool productName_useRegex; // 0x39
				public string[] manufacturer; // 0x40
				public string[] productName; // 0x48
				public string[] productGUID; // 0x50
	
				// Properties
				internal override bool hasData { get; } // 0x00000001805F4300-0x00000001805F4330 
				internal override bool isAllowed { get; } // 0x00000001805F43A0-0x00000001805F43C0 
				internal override int alternateElementCount { get; } // 0x00000001805F42F0-0x00000001805F4300 
	
				// Nested types
				[Serializable]
				public sealed class ElementCount : MatchingCriteria_Base.ElementCount_Base // TypeDefIndex: 6288
				{
					// Fields
					public int hatCount; // 0x18
	
					// Constructors
					public ElementCount(); // 0x00000001803F46D0-0x00000001803F46E0
	
					// Methods
					public override object DeepClone(); // 0x00000001805EE210-0x00000001805EE280
					internal override void CopyVars(MatchingCriteria_Base.ElementCount_Base param_0000d0e4); // 0x00000001805EE1A0-0x00000001805EE210
					internal override bool Matches(BridgedControllerHWInfo param_0000d0e5); // 0x00000001805EE280-0x00000001805EE2E0
				}
	
				// Constructors
				public MatchingCriteria(); // 0x00000001803F46D0-0x00000001803F46E0
	
				// Methods
				internal override bool Matches(BridgedControllerHWInfo bridgedControllerHWInfo, bool strictMatch); // 0x00000001805F3CA0-0x00000001805F3E40
				internal override ElementCount_Base GetAlternateElementCount(int index); // 0x00000001805F3C60-0x00000001805F3CA0
				internal override bool ElementCountsMatch(BridgedControllerHWInfo bridgedControllerHWInfo, out bool alternateMatched); // 0x00000001805F3BD0-0x00000001805F3C50
				private bool AnyNameMatches(BridgedControllerHWInfo bridgedControllerHWInfo); // 0x00000001805F3690-0x00000001805F37F0
				private bool NameMatches(string name, string[] names, bool useRegex); // 0x00000001805F41A0-0x00000001805F42F0
				public override object DeepClone(); // 0x00000001805F3AF0-0x00000001805F3B60
				internal override void CopyVars(MatchingCriteria_Base destination); // 0x00000001805F3940-0x00000001805F3A80
			}
	
			[Serializable]
			[CustomClassObfuscation] // 0x0000000180207920-0x0000000180207950
			public sealed class Elements : Elements_Base // TypeDefIndex: 6289
			{
				// Fields
				public Axis[] axes; // 0x10
				public Button[] buttons; // 0x18
	
				// Properties
				public override int buttonCount { get; } // 0x00000001805EF540-0x00000001805EF550 
				public override int axisCount { get; } // 0x00000001805EF530-0x00000001805EF540 
				internal IEnumerable<Axis> Axes { get; } // 0x00000001805EF410-0x00000001805EF490 
				internal IEnumerable<Button> Buttons { get; } // 0x00000001805EF490-0x00000001805EF530 
	
				// Nested types
				[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
				private sealed class nwCHMmfvKrhzxNOWcqsRjSmtaxr : IEnumerable<Axis>, IEnumerator<Axis> // TypeDefIndex: 6290
				{
					// Fields
					private Axis aSrFEaALHwhGTdXfCdeUqgbwaZGO; // 0x10
					private int eLrUhJFgzEZElCzdKvcrgOLXLvL; // 0x18
					private int RQaeFqcJnaOYpZSBxtfUkVOjfOo; // 0x1C
					public Elements gKPmvKLRxdGbmXiMfUeDjGbezUo; // 0x20
					public int kSYldKdWyvCIIjgmCQtWwHDiLAK; // 0x28
	
					// Properties
					Axis tdtAarGoghHJrxNnwDAJGdxCCVez { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372440-0x0000000180372450 
					object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372440-0x0000000180372450 
	
					// Constructors
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					public nwCHMmfvKrhzxNOWcqsRjSmtaxr(int <>1__state); // 0x00000001805EDEC0-0x00000001805EDF10
	
					// Methods
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					IEnumerator<Axis> System.Collections.Generic.IEnumerable<Rewired.Data.Mapping.HardwareJoystickMap.Platform_WindowsUWP_Base.Axis>.GetEnumerator(); // 0x000000018061A230-0x000000018061A330
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					IEnumerator IEnumerable.GetEnumerator(); // 0x000000018061A230-0x000000018061A330
					private bool MoveNext(); // 0x000000018061A100-0x000000018061A230
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					void IEnumerator.Reset(); // 0x000000018061A330-0x000000018061A380
					void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
				}
	
				[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
				private sealed class DQfCIwhTbccVauJApPceFgLEHYh : IEnumerable<Button>, IEnumerator<Button> // TypeDefIndex: 6291
				{
					// Fields
					private Button aSrFEaALHwhGTdXfCdeUqgbwaZGO; // 0x10
					private int eLrUhJFgzEZElCzdKvcrgOLXLvL; // 0x18
					private int RQaeFqcJnaOYpZSBxtfUkVOjfOo; // 0x1C
					public Elements gKPmvKLRxdGbmXiMfUeDjGbezUo; // 0x20
					public int OBIFRTAPpnPisGnYmvUQtawYqEm; // 0x28
	
					// Properties
					Button SQRVqZvvmpfiJnzDZFNPdPPwYsV { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372440-0x0000000180372450 
					object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372440-0x0000000180372450 
	
					// Constructors
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					public DQfCIwhTbccVauJApPceFgLEHYh(int <>1__state); // 0x00000001805EDEC0-0x00000001805EDF10
	
					// Methods
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					IEnumerator<Button> System.Collections.Generic.IEnumerable<Rewired.Data.Mapping.HardwareJoystickMap.Platform_WindowsUWP_Base.Button>.GetEnumerator(); // 0x00000001805EE070-0x00000001805EE150
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					IEnumerator IEnumerable.GetEnumerator(); // 0x00000001805EE070-0x00000001805EE150
					private bool MoveNext(); // 0x00000001805EDF10-0x00000001805EE070
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					void IEnumerator.Reset(); // 0x00000001805EE150-0x00000001805EE1A0
					void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
				}
	
				// Constructors
				public Elements(); // 0x00000001803F46D0-0x00000001803F46E0
	
				// Methods
				internal Axis GetAxis(int axisIndex); // 0x00000001805EE6B0-0x00000001805EE720
				internal override ControllerElementType GetEffectiveElementIdentifierType(ControllerElementIdentifier elementIdentifier); // 0x00000001805EF280-0x00000001805EF410
				internal override bool GetEffectiveAxisRange(ControllerElementIdentifier elementIdentifier, out AxisRange axisRange); // 0x00000001805EE720-0x00000001805EEA50
				public override object DeepClone(); // 0x00000001805EE5D0-0x00000001805EE640
				internal override void CopyVars(Elements_Base destination); // 0x00000001805EE340-0x00000001805EE400
			}
	
			[Serializable]
			[CustomClassObfuscation] // 0x0000000180207920-0x0000000180207950
			public abstract class Element : IDeepCloneable // TypeDefIndex: 6292
			{
				// Constructors
				protected Element(); // 0x0000000180373240-0x0000000180373250
	
				// Methods
				public abstract object DeepClone();
				protected virtual void ImportVars(Element source); // 0x00000001803774A0-0x00000001803774B0
			}
	
			[Serializable]
			[CustomClassObfuscation] // 0x0000000180207920-0x0000000180207950
			public class Button : Element // TypeDefIndex: 6293
			{
				// Fields
				public int elementIdentifier; // 0x10
				public HardwareElementSourceTypeWithHat sourceType; // 0x14
				public int sourceButton; // 0x18
				public int sourceAxis; // 0x1C
				public Pole sourceAxisPole; // 0x20
				public float axisDeadZone; // 0x24
				public int sourceHat; // 0x28
				public HatType sourceHatType; // 0x2C
				public HatDirection sourceHatDirection; // 0x30
				public bool requireMultipleButtons; // 0x34
				public int[] requiredButtons; // 0x38
				public bool ignoreIfButtonsActive; // 0x40
				public int[] ignoreIfButtonsActiveButtons; // 0x48
				public HardwareButtonInfo buttonInfo; // 0x50
	
				// Constructors
				public Button(); // 0x00000001805ED040-0x00000001805ED060
	
				// Methods
				public override object DeepClone(); // 0x00000001805ECE00-0x00000001805ECE70
				protected override void ImportVars(Element source); // 0x00000001805ECE70-0x00000001805ED040
			}
	
			[Serializable]
			[CustomClassObfuscation] // 0x0000000180207920-0x0000000180207950
			public class Axis : Element // TypeDefIndex: 6294
			{
				// Fields
				public int elementIdentifier; // 0x10
				public HardwareElementSourceTypeWithHat sourceType; // 0x14
				public int sourceAxis; // 0x18
				public AxisRange sourceAxisRange; // 0x1C
				public bool invert; // 0x20
				public float axisDeadZone; // 0x24
				public bool calibrateAxis; // 0x28
				public float axisZero; // 0x2C
				public float axisMin; // 0x30
				public float axisMax; // 0x34
				public AxisCalibrationInfoEntry[] alternateCalibrations; // 0x38
				public HardwareAxisInfo axisInfo; // 0x40
				public int sourceButton; // 0x48
				public Pole buttonAxisContribution; // 0x4C
				public int sourceHat; // 0x50
				public AxisDirection sourceHatDirection; // 0x54
				public AxisRange sourceHatRange; // 0x58
	
				// Constructors
				public Axis(); // 0x00000001805ECB60-0x00000001805ECB80
	
				// Methods
				public override object DeepClone(); // 0x00000001805EC920-0x00000001805EC990
				protected override void ImportVars(Element source); // 0x00000001805EC990-0x00000001805ECB60
			}
	
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private sealed class nscRQtMBeThliEPyOEvRTjibBxg : IEnumerable<Axis>, IEnumerator<Axis> // TypeDefIndex: 6295
			{
				// Fields
				private Axis aSrFEaALHwhGTdXfCdeUqgbwaZGO; // 0x10
				private int eLrUhJFgzEZElCzdKvcrgOLXLvL; // 0x18
				private int RQaeFqcJnaOYpZSBxtfUkVOjfOo; // 0x1C
				public Platform_WindowsUWP_Base gKPmvKLRxdGbmXiMfUeDjGbezUo; // 0x20
				public int TQritcNoEDtsifJmeHQbGilvMSXw; // 0x28
				public int jOsEvROrKOHsSsVpiGSeVsByZKM; // 0x2C
	
				// Properties
				Axis tdtAarGoghHJrxNnwDAJGdxCCVez { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372440-0x0000000180372450 
				object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372440-0x0000000180372450 
	
				// Constructors
				[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
				public nscRQtMBeThliEPyOEvRTjibBxg(int <>1__state); // 0x00000001805EDEC0-0x00000001805EDF10
	
				// Methods
				[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
				IEnumerator<Axis> System.Collections.Generic.IEnumerable<Rewired.Data.Mapping.HardwareJoystickMap.Platform_WindowsUWP_Base.Axis>.GetEnumerator(); // 0x0000000180619FC0-0x000000018061A0B0
				[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
				IEnumerator IEnumerable.GetEnumerator(); // 0x0000000180619FC0-0x000000018061A0B0
				private bool MoveNext(); // 0x0000000180619E30-0x0000000180619FC0
				[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
				void IEnumerator.Reset(); // 0x000000018061A0B0-0x000000018061A100
				void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			}
	
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private sealed class lexDGCjoDqwlINLyXhjMbKhFcyJA : IEnumerable<Button>, IEnumerator<Button> // TypeDefIndex: 6296
			{
				// Fields
				private Button aSrFEaALHwhGTdXfCdeUqgbwaZGO; // 0x10
				private int eLrUhJFgzEZElCzdKvcrgOLXLvL; // 0x18
				private int RQaeFqcJnaOYpZSBxtfUkVOjfOo; // 0x1C
				public Platform_WindowsUWP_Base gKPmvKLRxdGbmXiMfUeDjGbezUo; // 0x20
				public int BhQEcLIRcwjnROFLXOtltjWAlSO; // 0x28
				public int NUBZJGqvKDcklmyLuibVVhGEAiNe; // 0x2C
	
				// Properties
				Button SQRVqZvvmpfiJnzDZFNPdPPwYsV { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372440-0x0000000180372450 
				object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372440-0x0000000180372450 
	
				// Constructors
				[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
				public lexDGCjoDqwlINLyXhjMbKhFcyJA(int <>1__state); // 0x00000001805EDEC0-0x00000001805EDF10
	
				// Methods
				[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
				IEnumerator<Button> System.Collections.Generic.IEnumerable<Rewired.Data.Mapping.HardwareJoystickMap.Platform_WindowsUWP_Base.Button>.GetEnumerator(); // 0x0000000180619D00-0x0000000180619DE0
				[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
				IEnumerator IEnumerable.GetEnumerator(); // 0x0000000180619D00-0x0000000180619DE0
				private bool MoveNext(); // 0x0000000180619B70-0x0000000180619D00
				[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
				void IEnumerator.Reset(); // 0x0000000180619DE0-0x0000000180619E30
				void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			}
	
			// Constructors
			public Platform_WindowsUWP_Base(); // 0x00000001803F46D0-0x00000001803F46E0
	
			// Methods
			internal override bool Matches(BridgedControllerHWInfo BridgedControllerHWInfo, bool strictMatch, out int variantIndex, out Rewired.Data.Mapping.HardwareJoystickMap.Platform platformMap); // 0x00000001805F63F0-0x00000001805F6480
			internal override string[] GetAxisNames(ControllerElementIdentifier[] identifiers); // 0x00000001805F5330-0x00000001805F5600
			internal override string[] GetEffectiveButtonNames(ControllerElementIdentifier[] identifiers); // 0x00000001805F5830-0x00000001805F5B50
			internal override bool IsElementIdentifierMapped(int elementIdentifierId); // 0x00000001805F5F30-0x00000001805F62F0
			internal override void GetGameElementIdentifierIdMappings(out int[] buttons, out int[] axes); // 0x00000001805F5B70-0x00000001805F5F30
			internal override AxisCalibrationData[] GetAxisCalibrationData(); // 0x00000001805F4830-0x00000001805F4E80
			internal override void GetAxisData(out AxisRange[] axisRanges, out HardwareAxisInfo[] axisInfos); // 0x00000001805F4E80-0x00000001805F5330
			internal override void GetButtonData(out HardwareButtonInfo[] buttonInfos); // 0x00000001805F5600-0x00000001805F5800
			internal override ControllerElementType GetEffectiveElementIdentifierType(ControllerElementIdentifier elementIdentifier); // 0x00000001805F5B50-0x00000001805F5B70
			internal override bool GetEffectiveAxisRange(ControllerElementIdentifier elementIdentifier, out AxisRange axisRange); // 0x00000001805F5800-0x00000001805F5830
			internal IEnumerable<Axis> IterateAxes(); // 0x00000001805F62F0-0x00000001805F6370
			internal IEnumerable<Button> IterateButtons(); // 0x00000001805F6370-0x00000001805F63F0
			public override object DeepClone(); // 0x00000001805F47C0-0x00000001805F4830
			internal override void CopyVars(Rewired.Data.Mapping.HardwareJoystickMap.Platform destination); // 0x00000001805F46D0-0x00000001805F47C0
		}
	
		[Serializable]
		[CustomClassObfuscation] // 0x0000000180207920-0x0000000180207950
		public sealed class Platform_WindowsUWP : Platform_WindowsUWP_Base // TypeDefIndex: 6297
		{
			// Fields
			public Platform_WindowsUWP_Base[] variants; // 0x28
	
			// Properties
			internal override IList<Rewired.Data.Mapping.HardwareJoystickMap.Platform> variants_base { get; } // 0x00000001803745B0-0x00000001803745C0 
	
			// Constructors
			public Platform_WindowsUWP(); // 0x00000001803F46D0-0x00000001803F46E0
	
			// Methods
			internal override bool Matches(BridgedControllerHWInfo BridgedControllerHWInfo, bool strictMatch, out int variantIndex, out Rewired.Data.Mapping.HardwareJoystickMap.Platform platformMap); // 0x00000001805F67C0-0x00000001805F69F0
			public override object DeepClone(); // 0x00000001805F6750-0x00000001805F67C0
			internal override void CopyVars(Rewired.Data.Mapping.HardwareJoystickMap.Platform destination); // 0x00000001805F65A0-0x00000001805F6750
		}
	
		[Serializable]
		[CustomClassObfuscation] // 0x0000000180207920-0x0000000180207950
		public class Platform_Fallback_Base : Rewired.Data.Mapping.HardwareJoystickMap.Platform // TypeDefIndex: 6298
		{
			// Fields
			public MatchingCriteria matchingCriteria; // 0x18
			public Elements elements; // 0x20
	
			// Properties
			public override int assignedButtonCount { get; } // 0x00000001805F64C0-0x00000001805F64E0 
			public override int assignedAxisCount { get; } // 0x00000001805F64A0-0x00000001805F64C0 
			internal override InputPlatform platform { get; } // 0x00000001814507D0-0x00000001814507E0 
			internal Axis[] Axes_orig { get; } // 0x00000001805F6480-0x00000001805F6490 
			internal Button[] Buttons_orig { get; } // 0x00000001805F6490-0x00000001805F64A0 
			internal override bool hasData { get; } // 0x00000001818AF370-0x00000001818AF3F0 
			internal override bool disabled { get; } // 0x00000001805F64E0-0x00000001805F64F0 
			internal override bool isAllowed { get; } // 0x00000001805F6560-0x00000001805F65A0 
			internal override Elements_Base elements_base { get; } // 0x0000000180374AF0-0x0000000180374B00 
			internal override IList<Rewired.Data.Mapping.HardwareJoystickMap.Platform> variants_base { get; } // 0x000000018037DDC0-0x000000018037DDD0 
	
			// Nested types
			[Serializable]
			[CustomClassObfuscation] // 0x0000000180207920-0x0000000180207950
			public sealed class MatchingCriteria : MatchingCriteria_Base // TypeDefIndex: 6299
			{
				// Fields
				public bool alwaysMatch; // 0x28
				public bool productName_useRegex; // 0x29
				public string[] productName; // 0x30
				public bool matchUnityVersion; // 0x38
				public string matchUnityVersion_min; // 0x40
				public string matchUnityVersion_max; // 0x48
				public bool matchSysVersion; // 0x50
				public string matchSysVersion_min; // 0x58
				public string matchSysVersion_max; // 0x60
	
				// Properties
				internal override bool hasData { get; } // 0x00000001818AB210-0x00000001818AB240 
				internal override bool isAllowed { get; } // 0x00000001818AB270-0x00000001818AB340 
				internal override int alternateElementCount { get; } // 0x000000018037DDC0-0x000000018037DDD0 
	
				// Constructors
				public MatchingCriteria(); // 0x00000001803F46D0-0x00000001803F46E0
	
				// Methods
				internal override bool Matches(BridgedControllerHWInfo bridgedControllerHWInfo, bool strictMatch); // 0x00000001818AAB00-0x00000001818AAD20
				internal override ElementCount_Base GetAlternateElementCount(int index); // 0x000000018037DDC0-0x000000018037DDD0
				internal override bool ElementCountsMatch(BridgedControllerHWInfo bridgedControllerHWInfo, out bool alternateMatched); // 0x00000001805F3C50-0x00000001805F3C60
				public override object DeepClone(); // 0x00000001818A9D30-0x00000001818A9DA0
				internal override void CopyVars(MatchingCriteria_Base destination); // 0x00000001818A93A0-0x00000001818A9490
			}
	
			[Serializable]
			[CustomClassObfuscation] // 0x0000000180207920-0x0000000180207950
			public sealed class Elements : Elements_Base // TypeDefIndex: 6300
			{
				// Fields
				public Axis[] axes; // 0x10
				public Button[] buttons; // 0x18
	
				// Properties
				public override int buttonCount { get; } // 0x00000001805EF540-0x00000001805EF550 
				public override int axisCount { get; } // 0x00000001805EF530-0x00000001805EF540 
	
				// Constructors
				public Elements(); // 0x00000001803F46D0-0x00000001803F46E0
	
				// Methods
				internal override ControllerElementType GetEffectiveElementIdentifierType(ControllerElementIdentifier elementIdentifier); // 0x00000001818A8310-0x00000001818A84D0
				internal override bool GetEffectiveAxisRange(ControllerElementIdentifier elementIdentifier, out AxisRange axisRange); // 0x00000001818A74C0-0x00000001818A7770
				public override object DeepClone(); // 0x00000001818A66B0-0x00000001818A6720
				internal override void CopyVars(Elements_Base destination); // 0x00000001818A64A0-0x00000001818A6560
			}
	
			[Serializable]
			[CustomClassObfuscation] // 0x0000000180207920-0x0000000180207950
			public class CustomCalculationSourceData : IDeepCloneable // TypeDefIndex: 6301
			{
				// Fields
				public int sourceType; // 0x10
				public int sourceElement; // 0x14
				public AxisRange sourceAxisRange; // 0x18
				public float deadzone; // 0x1C
				public bool invert; // 0x20
	
				// Constructors
				public CustomCalculationSourceData(); // 0x0000000180373240-0x0000000180373250
	
				// Methods
				public object DeepClone(); // 0x00000001818A5170-0x00000001818A5210
			}
	
			[Serializable]
			[CustomClassObfuscation] // 0x0000000180207920-0x0000000180207950
			public abstract class Element : IDeepCloneable // TypeDefIndex: 6302
			{
				// Fields
				public int elementIdentifier; // 0x10
				public HardwareElementSourceTypeWithHat sourceType; // 0x14
				public UnityAxis sourceAxis; // 0x18
				public float axisDeadZone; // 0x1C
				public UnityButton sourceButton; // 0x20
				public KeyCode sourceKeyCode; // 0x24
				public CustomCalculation customCalculation; // 0x28
				public CustomCalculationSourceData[] customCalculationSourceData; // 0x30
	
				// Constructors
				protected Element(); // 0x0000000180373240-0x0000000180373250
	
				// Methods
				public abstract object DeepClone();
				protected virtual void CopyVars(Element destination); // 0x00000001818A5FF0-0x00000001818A60A0
			}
	
			[Serializable]
			[CustomClassObfuscation] // 0x0000000180207920-0x0000000180207950
			public sealed class Button : Element // TypeDefIndex: 6303
			{
				// Fields
				public Pole sourceAxisPole; // 0x38
				public UnityAxis unityHat_sourceAxis1; // 0x3C
				public UnityAxis unityHat_sourceAxis2; // 0x40
				public Vector2 unityHat_isActiveAxisValues1; // 0x44
				public Vector2 unityHat_isActiveAxisValues2; // 0x4C
				public Vector2 unityHat_isActiveAxisValues3; // 0x54
				public Vector2 unityHat_zeroValues; // 0x5C
				public bool unityHat_checkNeverPressed; // 0x64
				public Vector2 unityHat_neverPressedZeroValues; // 0x68
				public bool requireMultipleButtons; // 0x70
				public UnityButton[] requiredButtons; // 0x78
				public bool ignoreIfButtonsActive; // 0x80
				public UnityButton[] ignoreIfButtonsActiveButtons; // 0x88
				public HardwareButtonInfo buttonInfo; // 0x90
	
				// Constructors
				public Button(); // 0x0000000180373240-0x0000000180373250
	
				// Methods
				public override object DeepClone(); // 0x00000001818A4ED0-0x00000001818A4F40
				protected override void CopyVars(Element destination); // 0x00000001818A4670-0x00000001818A48C0
			}
	
			[Serializable]
			[CustomClassObfuscation] // 0x0000000180207920-0x0000000180207950
			public sealed class Axis : Element // TypeDefIndex: 6304
			{
				// Fields
				public bool invert; // 0x38
				public AxisRange sourceAxisRange; // 0x3C
				public Pole buttonAxisContribution; // 0x40
				public bool calibrateAxis; // 0x44
				public float axisZero; // 0x48
				public float axisMin; // 0x4C
				public float axisMax; // 0x50
				public AxisCalibrationInfoEntry[] alternateCalibrations; // 0x58
				public HardwareAxisInfo axisInfo; // 0x60
	
				// Constructors
				public Axis(); // 0x0000000180373240-0x0000000180373250
	
				// Methods
				public override object DeepClone(); // 0x00000001818A4160-0x00000001818A41D0
				protected override void CopyVars(Element destination); // 0x00000001818A3A70-0x00000001818A3C00
			}
	
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private sealed class ErHZklvvrcCHrKkOykbKJBFdqgJ : IEnumerable<Axis>, IEnumerator<Axis> // TypeDefIndex: 6305
			{
				// Fields
				private Axis aSrFEaALHwhGTdXfCdeUqgbwaZGO; // 0x10
				private int eLrUhJFgzEZElCzdKvcrgOLXLvL; // 0x18
				private int RQaeFqcJnaOYpZSBxtfUkVOjfOo; // 0x1C
				public Platform_Fallback_Base gKPmvKLRxdGbmXiMfUeDjGbezUo; // 0x20
				public int vXugbulKaeMXKgsqpYRYwHmmuO; // 0x28
	
				// Properties
				Axis APBRTmRAFikEAWsXGWOvJhDfldZ { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372440-0x0000000180372450 
				object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372440-0x0000000180372450 
	
				// Constructors
				[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
				public ErHZklvvrcCHrKkOykbKJBFdqgJ(int <>1__state); // 0x00000001805EDEC0-0x00000001805EDF10
	
				// Methods
				[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
				IEnumerator<Axis> System.Collections.Generic.IEnumerable<Rewired.Data.Mapping.HardwareJoystickMap.Platform_Fallback_Base.Axis>.GetEnumerator(); // 0x00000001818A89B0-0x00000001818A8AA0
				[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
				IEnumerator IEnumerable.GetEnumerator(); // 0x00000001818A89B0-0x00000001818A8AA0
				private bool MoveNext(); // 0x00000001818A87F0-0x00000001818A89B0
				[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
				void IEnumerator.Reset(); // 0x00000001818A8AA0-0x00000001818A8AF0
				void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			}
	
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private sealed class DgJmiYTgHFMUhkOrrYCFGmsfYjm : IEnumerable<Button>, IEnumerator<Button> // TypeDefIndex: 6306
			{
				// Fields
				private Button aSrFEaALHwhGTdXfCdeUqgbwaZGO; // 0x10
				private int eLrUhJFgzEZElCzdKvcrgOLXLvL; // 0x18
				private int RQaeFqcJnaOYpZSBxtfUkVOjfOo; // 0x1C
				public Platform_Fallback_Base gKPmvKLRxdGbmXiMfUeDjGbezUo; // 0x20
				public int flfjUtxcbGKcbhEtrvOnFcBaRVP; // 0x28
	
				// Properties
				Button xGzhxiGbBgGgxbQucAjtFxJlfLEF { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372440-0x0000000180372450 
				object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372440-0x0000000180372450 
	
				// Constructors
				[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
				public DgJmiYTgHFMUhkOrrYCFGmsfYjm(int <>1__state); // 0x00000001805EDEC0-0x00000001805EDF10
	
				// Methods
				[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
				IEnumerator<Button> System.Collections.Generic.IEnumerable<Rewired.Data.Mapping.HardwareJoystickMap.Platform_Fallback_Base.Button>.GetEnumerator(); // 0x00000001818A5DA0-0x00000001818A5E90
				[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
				IEnumerator IEnumerable.GetEnumerator(); // 0x00000001818A5DA0-0x00000001818A5E90
				private bool MoveNext(); // 0x00000001818A5C00-0x00000001818A5DA0
				[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
				void IEnumerator.Reset(); // 0x00000001818A5E90-0x00000001818A5EE0
				void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			}
	
			// Constructors
			public Platform_Fallback_Base(); // 0x00000001803F46D0-0x00000001803F46E0
	
			// Methods
			internal override bool Matches(BridgedControllerHWInfo BridgedControllerHWInfo, bool strictMatch, out int variantIndex, out Rewired.Data.Mapping.HardwareJoystickMap.Platform platformMap); // 0x00000001818AF2F0-0x00000001818AF370
			internal IEnumerable<Axis> IterateAxes(); // 0x00000001818AF1F0-0x00000001818AF270
			internal IEnumerable<Button> IterateButtons(); // 0x00000001818AF270-0x00000001818AF2F0
			internal override string[] GetAxisNames(ControllerElementIdentifier[] identifiers); // 0x00000001818AE310-0x00000001818AE5D0
			internal override string[] GetEffectiveButtonNames(ControllerElementIdentifier[] identifiers); // 0x00000001818AE800-0x00000001818AEAC0
			internal override bool IsElementIdentifierMapped(int elementIdentifierId); // 0x00000001818AEE40-0x00000001818AF1F0
			internal override void GetGameElementIdentifierIdMappings(out int[] buttons, out int[] axes); // 0x00000001818AEAC0-0x00000001818AEE40
			internal override AxisCalibrationData[] GetAxisCalibrationData(); // 0x00000001818AD7D0-0x00000001818ADE30
			internal override void GetAxisData(out AxisRange[] axisRanges, out HardwareAxisInfo[] axisInfos); // 0x00000001818ADE30-0x00000001818AE310
			internal override void GetButtonData(out HardwareButtonInfo[] buttonInfos); // 0x00000001818AE5D0-0x00000001818AE800
			internal override ControllerElementType GetEffectiveElementIdentifierType(ControllerElementIdentifier elementIdentifier); // 0x00000001805F5B50-0x00000001805F5B70
			internal override bool GetEffectiveAxisRange(ControllerElementIdentifier elementIdentifier, out AxisRange axisRange); // 0x00000001805F5800-0x00000001805F5830
			public override object DeepClone(); // 0x00000001818AD760-0x00000001818AD7D0
			internal override void CopyVars(Rewired.Data.Mapping.HardwareJoystickMap.Platform destination); // 0x00000001818AD610-0x00000001818AD760
		}
	
		[Serializable]
		[CustomClassObfuscation] // 0x0000000180207920-0x0000000180207950
		public sealed class Platform_Fallback : Platform_Fallback_Base // TypeDefIndex: 6307
		{
			// Fields
			public Platform_Fallback_Base[] variants; // 0x28
	
			// Properties
			internal override IList<Rewired.Data.Mapping.HardwareJoystickMap.Platform> variants_base { get; } // 0x00000001803745B0-0x00000001803745C0 
	
			// Constructors
			public Platform_Fallback(); // 0x00000001803F46D0-0x00000001803F46E0
	
			// Methods
			internal override bool Matches(BridgedControllerHWInfo BridgedControllerHWInfo, bool strictMatch, out int variantIndex, out Rewired.Data.Mapping.HardwareJoystickMap.Platform platformMap); // 0x00000001818AF630-0x00000001818AF840
			public override object DeepClone(); // 0x00000001818AF5C0-0x00000001818AF630
			internal override void CopyVars(Rewired.Data.Mapping.HardwareJoystickMap.Platform destination); // 0x00000001818AF3F0-0x00000001818AF5C0
		}
	
		[Serializable]
		[CustomClassObfuscation] // 0x0000000180207920-0x0000000180207950
		public abstract class Platform_Custom : Rewired.Data.Mapping.HardwareJoystickMap.Platform // TypeDefIndex: 6308
		{
			// Properties
			internal abstract Axis[] Axes { get; }
			internal abstract Button[] Buttons { get; }
	
			// Nested types
			[Serializable]
			[CustomClassObfuscation] // 0x0000000180207920-0x0000000180207950
			public abstract class MatchingCriteria : MatchingCriteria_Base // TypeDefIndex: 6309
			{
				// Fields
				public bool alwaysMatch; // 0x28
	
				// Properties
				internal override bool hasData { get; } // 0x00000001818AB190-0x00000001818AB1B0 
				internal override bool isAllowed { get; } // 0x00000001805F43A0-0x00000001805F43C0 
				internal override int alternateElementCount { get; } // 0x000000018037DDC0-0x000000018037DDD0 
	
				// Constructors
				protected MatchingCriteria(); // 0x00000001803F46D0-0x00000001803F46E0
	
				// Methods
				internal override bool Matches(BridgedControllerHWInfo bridgedControllerHWInfo, bool strictMatch); // 0x00000001818A9F70-0x00000001818AA010
				internal override ElementCount_Base GetAlternateElementCount(int index); // 0x000000018037DDC0-0x000000018037DDD0
				internal override bool ElementCountsMatch(BridgedControllerHWInfo bridgedControllerHWInfo, out bool alternateMatched); // 0x00000001805F3C50-0x00000001805F3C60
				internal override void CopyVars(MatchingCriteria_Base destination); // 0x00000001818A9600-0x00000001818A9720
			}
	
			[Serializable]
			[CustomClassObfuscation] // 0x0000000180207920-0x0000000180207950
			public abstract class Elements : Elements_Base // TypeDefIndex: 6310
			{
				// Constructors
				protected Elements(); // 0x00000001803F46D0-0x00000001803F46E0
			}
	
			[Serializable]
			[CustomClassObfuscation] // 0x0000000180207920-0x0000000180207950
			public class CustomCalculationSourceData : IDeepCloneable // TypeDefIndex: 6311
			{
				// Fields
				public int sourceType; // 0x10
				public int sourceAxis; // 0x14
				public int sourceButton; // 0x18
				public int sourceOtherAxis; // 0x1C
				public AxisRange sourceAxisRange; // 0x20
				public float axisDeadZone; // 0x24
				public bool invert; // 0x28
				public AxisCalibrationType axisCalibrationType; // 0x2C
				public float axisZero; // 0x30
				public float axisMin; // 0x34
				public float axisMax; // 0x38
	
				// Constructors
				public CustomCalculationSourceData(); // 0x0000000180373240-0x0000000180373250
	
				// Methods
				public object DeepClone(); // 0x00000001818A5210-0x00000001818A52B0
			}
	
			[Serializable]
			[CustomClassObfuscation] // 0x0000000180207920-0x0000000180207950
			public abstract class Element : IDeepCloneable // TypeDefIndex: 6312
			{
				// Fields
				public int elementIdentifier; // 0x10
				public int sourceType; // 0x14
				public int sourceAxis; // 0x18
				public float axisDeadZone; // 0x1C
				public int sourceButton; // 0x20
				public CustomCalculation customCalculation; // 0x28
				public CustomCalculationSourceData[] customCalculationSourceData; // 0x30
	
				// Constructors
				protected Element(); // 0x0000000180373240-0x0000000180373250
	
				// Methods
				internal virtual void CopyVars(Element destination); // 0x00000001818A60A0-0x00000001818A6140
				public abstract object DeepClone();
			}
	
			[Serializable]
			[CustomClassObfuscation] // 0x0000000180207920-0x0000000180207950
			public abstract class Button : Element // TypeDefIndex: 6313
			{
				// Fields
				public Pole sourceAxisPole; // 0x38
				public bool requireMultipleButtons; // 0x3C
				public int[] requiredButtons; // 0x40
				public bool ignoreIfButtonsActive; // 0x48
				public int[] ignoreIfButtonsActiveButtons; // 0x50
				public HardwareButtonInfo buttonInfo; // 0x58
	
				// Constructors
				protected Button(); // 0x0000000180373240-0x0000000180373250
	
				// Methods
				internal override void CopyVars(Element destination); // 0x00000001818A48C0-0x00000001818A4AB0
			}
	
			[Serializable]
			[CustomClassObfuscation] // 0x0000000180207920-0x0000000180207950
			public abstract class Axis : Element // TypeDefIndex: 6314
			{
				// Fields
				public bool invert; // 0x38
				public AxisRange sourceAxisRange; // 0x3C
				public Pole buttonAxisContribution; // 0x40
				public bool calibrateAxis; // 0x44
				public float axisZero; // 0x48
				public float axisMin; // 0x4C
				public float axisMax; // 0x50
				public AxisCalibrationInfoEntry[] alternateCalibrations; // 0x58
				public HardwareAxisInfo axisInfo; // 0x60
	
				// Constructors
				protected Axis(); // 0x0000000180373240-0x0000000180373250
	
				// Methods
				internal override void CopyVars(Element destination); // 0x00000001818A3D30-0x00000001818A3FA0
			}
	
			// Constructors
			protected Platform_Custom(); // 0x00000001803F46D0-0x00000001803F46E0
	
			// Methods
			internal abstract IEnumerable<Axis> IterateAxes();
			internal abstract IEnumerable<Button> IterateButtons();
			internal override void CopyVars(Rewired.Data.Mapping.HardwareJoystickMap.Platform destination); // 0x00000001803774A0-0x00000001803774B0
		}
	
		[Serializable]
		[CustomClassObfuscation] // 0x0000000180207920-0x0000000180207950
		public class Platform_Ouya_Base : Platform_Custom // TypeDefIndex: 6315
		{
			// Fields
			public MatchingCriteria matchingCriteria; // 0x18
			public Elements elements; // 0x20
			private Axis[] _axesOrigGame; // 0x28
			private Button[] _buttonsOrigGame; // 0x30
	
			// Properties
			public override int assignedButtonCount { get; } // 0x00000001805F64C0-0x00000001805F64E0 
			public override int assignedAxisCount { get; } // 0x00000001805F64A0-0x00000001805F64C0 
			internal override InputPlatform platform { get; } // 0x000000018144D0B0-0x000000018144D0C0 
			internal override Axis[] Axes { get; } // 0x000000018193D520-0x000000018193D680 
			internal override Button[] Buttons { get; } // 0x000000018193D680-0x000000018193D7E0 
			internal Axis[] Axes_orig { get; } // 0x00000001805F6480-0x00000001805F6490 
			internal Button[] Buttons_orig { get; } // 0x00000001805F6490-0x00000001805F64A0 
			internal override bool hasData { get; } // 0x00000001818B1970-0x00000001818B19E0 
			internal override bool disabled { get; } // 0x00000001805F64E0-0x00000001805F64F0 
			internal override bool isAllowed { get; } // 0x00000001805F6560-0x00000001805F65A0 
			internal override Elements_Base elements_base { get; } // 0x0000000180374AF0-0x0000000180374B00 
			internal override IList<Rewired.Data.Mapping.HardwareJoystickMap.Platform> variants_base { get; } // 0x000000018037DDC0-0x000000018037DDD0 
	
			// Nested types
			[Serializable]
			[CustomClassObfuscation] // 0x0000000180207920-0x0000000180207950
			public sealed class MatchingCriteria : Platform_Custom.MatchingCriteria // TypeDefIndex: 6316
			{
				// Properties
				internal override bool hasData { get; } // 0x000000018193B5B0-0x000000018193B5D0 
				internal override bool isAllowed { get; } // 0x00000001805F43C0-0x00000001805F43F0 
	
				// Constructors
				public MatchingCriteria(); // 0x00000001803FB1F0-0x00000001803FB200
	
				// Methods
				internal override bool Matches(BridgedControllerHWInfo bridgedControllerHWInfo, bool strictMatch); // 0x000000018193A6D0-0x000000018193A780
				public override object DeepClone(); // 0x0000000181939AE0-0x0000000181939B50
				internal override void CopyVars(MatchingCriteria_Base destination); // 0x0000000181939610-0x0000000181939660
			}
	
			[Serializable]
			[CustomClassObfuscation] // 0x0000000180207920-0x0000000180207950
			public sealed class Elements : Platform_Custom.Elements // TypeDefIndex: 6317
			{
				// Fields
				public Axis[] axes; // 0x10
				public Button[] buttons; // 0x18
	
				// Properties
				public override int buttonCount { get; } // 0x00000001805EF540-0x00000001805EF550 
				public override int axisCount { get; } // 0x00000001805EF530-0x00000001805EF540 
	
				// Constructors
				public Elements(); // 0x00000001803FB1F0-0x00000001803FB200
	
				// Methods
				internal override ControllerElementType GetEffectiveElementIdentifierType(ControllerElementIdentifier elementIdentifier); // 0x0000000181937AB0-0x0000000181937C60
				internal override bool GetEffectiveAxisRange(ControllerElementIdentifier elementIdentifier, out AxisRange axisRange); // 0x0000000181936CA0-0x0000000181936F30
				public override object DeepClone(); // 0x0000000181935F90-0x0000000181936000
				internal override void CopyVars(Elements_Base destination); // 0x0000000181935A40-0x0000000181935B00
			}
	
			[Serializable]
			[CustomClassObfuscation] // 0x0000000180207920-0x0000000180207950
			public sealed class Button : Platform_Custom.Button // TypeDefIndex: 6318
			{
				// Constructors
				public Button(); // 0x00000001803F46D0-0x00000001803F46E0
	
				// Methods
				public override object DeepClone(); // 0x0000000181934F20-0x0000000181934F90
				internal override void CopyVars(Platform_Custom.Element destination); // 0x0000000181934D40-0x0000000181934DC0
			}
	
			[Serializable]
			[CustomClassObfuscation] // 0x0000000180207920-0x0000000180207950
			public sealed class Axis : Platform_Custom.Axis // TypeDefIndex: 6319
			{
				// Constructors
				public Axis(); // 0x00000001803F46D0-0x00000001803F46E0
	
				// Methods
				public override object DeepClone(); // 0x00000001819340C0-0x0000000181934130
				internal override void CopyVars(Platform_Custom.Element destination); // 0x0000000181933D30-0x0000000181933D80
			}
	
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private sealed class aRHzhkejxZtCIvbfKnQeaqQXbzf : IEnumerable<Axis>, IEnumerator<Axis> // TypeDefIndex: 6320
			{
				// Fields
				private Platform_Custom.Axis aSrFEaALHwhGTdXfCdeUqgbwaZGO; // 0x10
				private int eLrUhJFgzEZElCzdKvcrgOLXLvL; // 0x18
				private int RQaeFqcJnaOYpZSBxtfUkVOjfOo; // 0x1C
				public Platform_Ouya_Base gKPmvKLRxdGbmXiMfUeDjGbezUo; // 0x20
				public int PpDliwTKffJpGKoHEhgksSomaDH; // 0x28
	
				// Properties
				Platform_Custom.Axis lmiaTpCsaXfKxySEjXIZoypgnjMr { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372440-0x0000000180372450 
				object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372440-0x0000000180372450 
	
				// Constructors
				[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
				public aRHzhkejxZtCIvbfKnQeaqQXbzf(int <>1__state); // 0x00000001805EDEC0-0x00000001805EDF10
	
				// Methods
				[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
				IEnumerator<Platform_Custom.Axis> System.Collections.Generic.IEnumerable<Rewired.Data.Mapping.HardwareJoystickMap.Platform_Custom.Axis>.GetEnumerator(); // 0x000000018194A040-0x000000018194A160
				[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
				IEnumerator IEnumerable.GetEnumerator(); // 0x000000018194A040-0x000000018194A160
				private bool MoveNext(); // 0x0000000181949E90-0x000000018194A040
				[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
				void IEnumerator.Reset(); // 0x000000018194A160-0x000000018194A1B0
				void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			}
	
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private sealed class XtMZtzXwPdzvNhbKBQkMfxBUzFU : IEnumerable<Button>, IEnumerator<Button> // TypeDefIndex: 6321
			{
				// Fields
				private Platform_Custom.Button aSrFEaALHwhGTdXfCdeUqgbwaZGO; // 0x10
				private int eLrUhJFgzEZElCzdKvcrgOLXLvL; // 0x18
				private int RQaeFqcJnaOYpZSBxtfUkVOjfOo; // 0x1C
				public Platform_Ouya_Base gKPmvKLRxdGbmXiMfUeDjGbezUo; // 0x20
				public int iMkviWnQmExdFJquFuJojpIgZOm; // 0x28
	
				// Properties
				Platform_Custom.Button PlYXfEMpMbXcHXTJgpApbDPxYUh { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372440-0x0000000180372450 
				object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372440-0x0000000180372450 
	
				// Constructors
				[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
				public XtMZtzXwPdzvNhbKBQkMfxBUzFU(int <>1__state); // 0x0000000181949A80-0x0000000181949AF0
	
				// Methods
				[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
				IEnumerator<Platform_Custom.Button> System.Collections.Generic.IEnumerable<Rewired.Data.Mapping.HardwareJoystickMap.Platform_Custom.Button>.GetEnumerator(); // 0x0000000181949910-0x0000000181949A30
				[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
				IEnumerator IEnumerable.GetEnumerator(); // 0x0000000181949910-0x0000000181949A30
				private bool MoveNext(); // 0x00000001819497C0-0x0000000181949910
				[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
				void IEnumerator.Reset(); // 0x0000000181949A30-0x0000000181949A80
				void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			}
	
			// Constructors
			public Platform_Ouya_Base(); // 0x00000001803FB1F0-0x00000001803FB200
	
			// Methods
			internal override bool Matches(BridgedControllerHWInfo BridgedControllerHWInfo, bool strictMatch, out int variantIndex, out Rewired.Data.Mapping.HardwareJoystickMap.Platform platformMap); // 0x000000018193D4A0-0x000000018193D520
			internal override IEnumerable<Axis> IterateAxes(); // 0x000000018193D360-0x000000018193D400
			internal override IEnumerable<Button> IterateButtons(); // 0x000000018193D400-0x000000018193D4A0
			internal override string[] GetAxisNames(ControllerElementIdentifier[] identifiers); // 0x000000018193C480-0x000000018193C750
			internal override string[] GetEffectiveButtonNames(ControllerElementIdentifier[] identifiers); // 0x000000018193C930-0x000000018193CBE0
			internal override bool IsElementIdentifierMapped(int elementIdentifierId); // 0x000000018193CFD0-0x000000018193D360
			internal override void GetGameElementIdentifierIdMappings(out int[] buttons, out int[] axes); // 0x000000018193CBE0-0x000000018193CFD0
			internal override AxisCalibrationData[] GetAxisCalibrationData(); // 0x000000018193BA40-0x000000018193C020
			internal override void GetAxisData(out AxisRange[] axisRanges, out HardwareAxisInfo[] axisInfos); // 0x000000018193C020-0x000000018193C480
			internal override void GetButtonData(out HardwareButtonInfo[] buttonInfos); // 0x000000018193C750-0x000000018193C930
			internal override ControllerElementType GetEffectiveElementIdentifierType(ControllerElementIdentifier elementIdentifier); // 0x00000001805F5B50-0x00000001805F5B70
			internal override bool GetEffectiveAxisRange(ControllerElementIdentifier elementIdentifier, out AxisRange axisRange); // 0x00000001805F5800-0x00000001805F5830
			public override object DeepClone(); // 0x000000018193B9D0-0x000000018193BA40
			internal override void CopyVars(Rewired.Data.Mapping.HardwareJoystickMap.Platform destination); // 0x000000018193B8A0-0x000000018193B9D0
		}
	
		[Serializable]
		[CustomClassObfuscation] // 0x0000000180207920-0x0000000180207950
		public sealed class Platform_Ouya : Platform_Ouya_Base // TypeDefIndex: 6322
		{
			// Fields
			public Platform_Ouya_Base[] variants; // 0x38
	
			// Properties
			internal override IList<Rewired.Data.Mapping.HardwareJoystickMap.Platform> variants_base { get; } // 0x00000001803743D0-0x00000001803743E0 
	
			// Constructors
			public Platform_Ouya(); // 0x00000001803FB1F0-0x00000001803FB200
	
			// Methods
			internal override bool Matches(BridgedControllerHWInfo BridgedControllerHWInfo, bool strictMatch, out int variantIndex, out Rewired.Data.Mapping.HardwareJoystickMap.Platform platformMap); // 0x000000018193DA00-0x000000018193DBD0
			public override object DeepClone(); // 0x000000018193D990-0x000000018193DA00
			internal override void CopyVars(Rewired.Data.Mapping.HardwareJoystickMap.Platform destination); // 0x000000018193D7E0-0x000000018193D990
		}
	
		[Serializable]
		[CustomClassObfuscation] // 0x0000000180207920-0x0000000180207950
		public class Platform_XboxOne_Base : Platform_Custom // TypeDefIndex: 6323
		{
			// Fields
			public MatchingCriteria matchingCriteria; // 0x18
			public Elements elements; // 0x20
			private Axis[] _axesOrigGame; // 0x28
			private Button[] _buttonsOrigGame; // 0x30
	
			// Properties
			public override int assignedButtonCount { get; } // 0x00000001805F64C0-0x00000001805F64E0 
			public override int assignedAxisCount { get; } // 0x00000001805F64A0-0x00000001805F64C0 
			internal override InputPlatform platform { get; } // 0x00000001805FAF20-0x00000001805FAF30 
			internal override Axis[] Axes { get; } // 0x00000001805FAB20-0x00000001805FACF0 
			internal override Button[] Buttons { get; } // 0x00000001805FACF0-0x00000001805FAE90 
			internal Axis[] Axes_orig { get; } // 0x00000001805F6480-0x00000001805F6490 
			internal Button[] Buttons_orig { get; } // 0x00000001805F6490-0x00000001805F64A0 
			internal override bool hasData { get; } // 0x00000001805FAE90-0x00000001805FAF20 
			internal override bool disabled { get; } // 0x00000001805F64E0-0x00000001805F64F0 
			internal override bool isAllowed { get; } // 0x00000001805F6560-0x00000001805F65A0 
			internal override Elements_Base elements_base { get; } // 0x0000000180374AF0-0x0000000180374B00 
			internal override IList<Rewired.Data.Mapping.HardwareJoystickMap.Platform> variants_base { get; } // 0x000000018037DDC0-0x000000018037DDD0 
	
			// Nested types
			[Serializable]
			[CustomClassObfuscation] // 0x0000000180207920-0x0000000180207950
			public sealed class MatchingCriteria : Platform_Custom.MatchingCriteria // TypeDefIndex: 6324
			{
				// Fields
				public bool productName_useRegex; // 0x30
				public string[] productName; // 0x38
	
				// Properties
				internal override bool hasData { get; } // 0x00000001805F4360-0x00000001805F43A0 
				internal override bool isAllowed { get; } // 0x00000001805F43C0-0x00000001805F43F0 
	
				// Constructors
				public MatchingCriteria(); // 0x00000001803FB1F0-0x00000001803FB200
	
				// Methods
				internal override bool Matches(BridgedControllerHWInfo bridgedControllerHWInfo, bool strictMatch); // 0x00000001805F3F90-0x00000001805F41A0
				public override object DeepClone(); // 0x00000001805F3A80-0x00000001805F3AF0
				internal override void CopyVars(MatchingCriteria_Base destination); // 0x00000001805F37F0-0x00000001805F3880
			}
	
			[Serializable]
			[CustomClassObfuscation] // 0x0000000180207920-0x0000000180207950
			public sealed class Elements : Platform_Custom.Elements // TypeDefIndex: 6325
			{
				// Fields
				public Axis[] axes; // 0x10
				public Button[] buttons; // 0x18
	
				// Properties
				public override int buttonCount { get; } // 0x00000001805EF540-0x00000001805EF550 
				public override int axisCount { get; } // 0x00000001805EF530-0x00000001805EF540 
	
				// Constructors
				public Elements(); // 0x00000001803FB1F0-0x00000001803FB200
	
				// Methods
				internal override ControllerElementType GetEffectiveElementIdentifierType(ControllerElementIdentifier elementIdentifier); // 0x00000001805EEF90-0x00000001805EF0F0
				internal override bool GetEffectiveAxisRange(ControllerElementIdentifier elementIdentifier, out AxisRange axisRange); // 0x00000001805EECD0-0x00000001805EEF90
				public override object DeepClone(); // 0x00000001805EE640-0x00000001805EE6B0
				internal override void CopyVars(Elements_Base destination); // 0x00000001805EE400-0x00000001805EE490
			}
	
			[Serializable]
			[CustomClassObfuscation] // 0x0000000180207920-0x0000000180207950
			public sealed class Button : Platform_Custom.Button // TypeDefIndex: 6326
			{
				// Constructors
				public Button(); // 0x00000001803F46D0-0x00000001803F46E0
	
				// Methods
				public override object DeepClone(); // 0x00000001805ECD00-0x00000001805ECD70
				internal override void CopyVars(Platform_Custom.Element destination); // 0x00000001805ECB80-0x00000001805ECBD0
			}
	
			[Serializable]
			[CustomClassObfuscation] // 0x0000000180207920-0x0000000180207950
			public sealed class Axis : Platform_Custom.Axis // TypeDefIndex: 6327
			{
				// Constructors
				public Axis(); // 0x00000001803F46D0-0x00000001803F46E0
	
				// Methods
				public override object DeepClone(); // 0x00000001805EC840-0x00000001805EC8B0
				internal override void CopyVars(Platform_Custom.Element destination); // 0x00000001805EC7F0-0x00000001805EC840
			}
	
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private sealed class NebGQKirrNPGgkcrIancLxuvSo : IEnumerable<Axis>, IEnumerator<Axis> // TypeDefIndex: 6328
			{
				// Fields
				private Platform_Custom.Axis aSrFEaALHwhGTdXfCdeUqgbwaZGO; // 0x10
				private int eLrUhJFgzEZElCzdKvcrgOLXLvL; // 0x18
				private int RQaeFqcJnaOYpZSBxtfUkVOjfOo; // 0x1C
				public Platform_XboxOne_Base gKPmvKLRxdGbmXiMfUeDjGbezUo; // 0x20
				public int ZqUCxpYFlLPvBvVurELYuqFJjbN; // 0x28
	
				// Properties
				Platform_Custom.Axis lmiaTpCsaXfKxySEjXIZoypgnjMr { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372440-0x0000000180372450 
				object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372440-0x0000000180372450 
	
				// Constructors
				[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
				public NebGQKirrNPGgkcrIancLxuvSo(int <>1__state); // 0x00000001805EDEC0-0x00000001805EDF10
	
				// Methods
				[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
				IEnumerator<Platform_Custom.Axis> System.Collections.Generic.IEnumerable<Rewired.Data.Mapping.HardwareJoystickMap.Platform_Custom.Axis>.GetEnumerator(); // 0x00000001805F45A0-0x00000001805F4680
				[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
				IEnumerator IEnumerable.GetEnumerator(); // 0x00000001805F45A0-0x00000001805F4680
				private bool MoveNext(); // 0x00000001805F43F0-0x00000001805F45A0
				[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
				void IEnumerator.Reset(); // 0x00000001805F4680-0x00000001805F46D0
				void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			}
	
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private sealed class HybmreaYbjvEZmLHdFpKDIKPdWMC : IEnumerable<Button>, IEnumerator<Button> // TypeDefIndex: 6329
			{
				// Fields
				private Platform_Custom.Button aSrFEaALHwhGTdXfCdeUqgbwaZGO; // 0x10
				private int eLrUhJFgzEZElCzdKvcrgOLXLvL; // 0x18
				private int RQaeFqcJnaOYpZSBxtfUkVOjfOo; // 0x1C
				public Platform_XboxOne_Base gKPmvKLRxdGbmXiMfUeDjGbezUo; // 0x20
				public int aVGWoKnFCgGxTFeMMvcofNvZHCS; // 0x28
	
				// Properties
				Platform_Custom.Button PlYXfEMpMbXcHXTJgpApbDPxYUh { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372440-0x0000000180372450 
				object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372440-0x0000000180372450 
	
				// Constructors
				[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
				public HybmreaYbjvEZmLHdFpKDIKPdWMC(int <>1__state); // 0x00000001805EDEC0-0x00000001805EDF10
	
				// Methods
				[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
				IEnumerator<Platform_Custom.Button> System.Collections.Generic.IEnumerable<Rewired.Data.Mapping.HardwareJoystickMap.Platform_Custom.Button>.GetEnumerator(); // 0x00000001805F2EB0-0x00000001805F2F90
				[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
				IEnumerator IEnumerable.GetEnumerator(); // 0x00000001805F2EB0-0x00000001805F2F90
				private bool MoveNext(); // 0x00000001805F2D00-0x00000001805F2EB0
				[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
				void IEnumerator.Reset(); // 0x00000001805F2F90-0x00000001805F2FE0
				void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			}
	
			// Constructors
			public Platform_XboxOne_Base(); // 0x00000001803FB1F0-0x00000001803FB200
	
			// Methods
			internal override bool Matches(BridgedControllerHWInfo BridgedControllerHWInfo, bool strictMatch, out int variantIndex, out Rewired.Data.Mapping.HardwareJoystickMap.Platform platformMap); // 0x00000001805FAA90-0x00000001805FAB20
			internal override IEnumerable<Axis> IterateAxes(); // 0x00000001805FA990-0x00000001805FAA10
			internal override IEnumerable<Button> IterateButtons(); // 0x00000001805FAA10-0x00000001805FAA90
			internal override string[] GetAxisNames(ControllerElementIdentifier[] identifiers); // 0x00000001805F97C0-0x00000001805F9AA0
			internal override string[] GetEffectiveButtonNames(ControllerElementIdentifier[] identifiers); // 0x00000001805F9CE0-0x00000001805F9FA0
			internal override bool IsElementIdentifierMapped(int elementIdentifierId); // 0x00000001805FA570-0x00000001805FA990
			internal override void GetGameElementIdentifierIdMappings(out int[] buttons, out int[] axes); // 0x00000001805F9FA0-0x00000001805FA570
			internal override AxisCalibrationData[] GetAxisCalibrationData(); // 0x00000001805F8D40-0x00000001805F9320
			internal override void GetAxisData(out AxisRange[] axisRanges, out HardwareAxisInfo[] axisInfos); // 0x00000001805F9320-0x00000001805F97C0
			internal override void GetButtonData(out HardwareButtonInfo[] buttonInfos); // 0x00000001805F9AA0-0x00000001805F9CE0
			internal override ControllerElementType GetEffectiveElementIdentifierType(ControllerElementIdentifier elementIdentifier); // 0x00000001805F5B50-0x00000001805F5B70
			internal override bool GetEffectiveAxisRange(ControllerElementIdentifier elementIdentifier, out AxisRange axisRange); // 0x00000001805F5800-0x00000001805F5830
			public override object DeepClone(); // 0x00000001805F8CD0-0x00000001805F8D40
			internal override void CopyVars(Rewired.Data.Mapping.HardwareJoystickMap.Platform destination); // 0x00000001805F8BF0-0x00000001805F8CD0
		}
	
		[Serializable]
		[CustomClassObfuscation] // 0x0000000180207920-0x0000000180207950
		public sealed class Platform_XboxOne : Platform_XboxOne_Base // TypeDefIndex: 6330
		{
			// Fields
			public Platform_XboxOne_Base[] variants; // 0x38
	
			// Properties
			internal override IList<Rewired.Data.Mapping.HardwareJoystickMap.Platform> variants_base { get; } // 0x00000001803743D0-0x00000001803743E0 
	
			// Constructors
			public Platform_XboxOne(); // 0x00000001803FB1F0-0x00000001803FB200
	
			// Methods
			internal override bool Matches(BridgedControllerHWInfo BridgedControllerHWInfo, bool strictMatch, out int variantIndex, out Rewired.Data.Mapping.HardwareJoystickMap.Platform platformMap); // 0x00000001805FB140-0x00000001805FB360
			public override object DeepClone(); // 0x00000001805FB0D0-0x00000001805FB140
			internal override void CopyVars(Rewired.Data.Mapping.HardwareJoystickMap.Platform destination); // 0x00000001805FAF30-0x00000001805FB0D0
		}
	
		[Serializable]
		[CustomClassObfuscation] // 0x0000000180207920-0x0000000180207950
		public class Platform_PS4_Base : Platform_Custom // TypeDefIndex: 6331
		{
			// Fields
			public MatchingCriteria matchingCriteria; // 0x18
			public Elements elements; // 0x20
			private Axis[] _axesOrigGame; // 0x28
			private Button[] _buttonsOrigGame; // 0x30
	
			// Properties
			public override int assignedButtonCount { get; } // 0x00000001805F64C0-0x00000001805F64E0 
			public override int assignedAxisCount { get; } // 0x00000001805F64A0-0x00000001805F64C0 
			internal override InputPlatform platform { get; } // 0x000000018144C240-0x000000018144C250 
			internal override Axis[] Axes { get; } // 0x000000018193F850-0x000000018193FA20 
			internal override Button[] Buttons { get; } // 0x000000018193FA20-0x000000018193FC10 
			internal Axis[] Axes_orig { get; } // 0x00000001805F6480-0x00000001805F6490 
			internal Button[] Buttons_orig { get; } // 0x00000001805F6490-0x00000001805F64A0 
			internal override bool hasData { get; } // 0x000000018193FC10-0x000000018193FCB0 
			internal override bool disabled { get; } // 0x00000001805F64E0-0x00000001805F64F0 
			internal override bool isAllowed { get; } // 0x00000001805F6560-0x00000001805F65A0 
			internal override Elements_Base elements_base { get; } // 0x0000000180374AF0-0x0000000180374B00 
			internal override IList<Rewired.Data.Mapping.HardwareJoystickMap.Platform> variants_base { get; } // 0x000000018037DDC0-0x000000018037DDD0 
	
			// Nested types
			[Serializable]
			[CustomClassObfuscation] // 0x0000000180207920-0x0000000180207950
			public sealed class MatchingCriteria : Platform_Custom.MatchingCriteria // TypeDefIndex: 6332
			{
				// Fields
				public bool productName_useRegex; // 0x30
				public string[] productName; // 0x38
	
				// Properties
				internal override bool hasData { get; } // 0x00000001805F4360-0x00000001805F43A0 
				internal override bool isAllowed { get; } // 0x00000001805F43C0-0x00000001805F43F0 
	
				// Constructors
				public MatchingCriteria(); // 0x00000001803FB1F0-0x00000001803FB200
	
				// Methods
				internal override bool Matches(BridgedControllerHWInfo bridgedControllerHWInfo, bool strictMatch); // 0x000000018193AF00-0x000000018193B100
				public override object DeepClone(); // 0x00000001819398B0-0x0000000181939920
				internal override void CopyVars(MatchingCriteria_Base destination); // 0x0000000181939730-0x00000001819397C0
			}
	
			[Serializable]
			[CustomClassObfuscation] // 0x0000000180207920-0x0000000180207950
			public sealed class Elements : Platform_Custom.Elements // TypeDefIndex: 6333
			{
				// Fields
				public Axis[] axes; // 0x10
				public Button[] buttons; // 0x18
	
				// Properties
				public override int buttonCount { get; } // 0x00000001805EF540-0x00000001805EF550 
				public override int axisCount { get; } // 0x00000001805EF530-0x00000001805EF540 
	
				// Constructors
				public Elements(); // 0x00000001803FB1F0-0x00000001803FB200
	
				// Methods
				internal override ControllerElementType GetEffectiveElementIdentifierType(ControllerElementIdentifier elementIdentifier); // 0x00000001819373F0-0x0000000181937590
				internal override bool GetEffectiveAxisRange(ControllerElementIdentifier elementIdentifier, out AxisRange axisRange); // 0x0000000181936A00-0x0000000181936CA0
				public override object DeepClone(); // 0x0000000181935E40-0x0000000181935EB0
				internal override void CopyVars(Elements_Base destination); // 0x0000000181935D40-0x0000000181935DD0
			}
	
			[Serializable]
			[CustomClassObfuscation] // 0x0000000180207920-0x0000000180207950
			public sealed class Button : Platform_Custom.Button // TypeDefIndex: 6334
			{
				// Constructors
				public Button(); // 0x00000001803F46D0-0x00000001803F46E0
	
				// Methods
				public override object DeepClone(); // 0x0000000181935000-0x0000000181935070
				internal override void CopyVars(Platform_Custom.Element destination); // 0x0000000181934E10-0x0000000181934E60
			}
	
			[Serializable]
			[CustomClassObfuscation] // 0x0000000180207920-0x0000000180207950
			public sealed class Axis : Platform_Custom.Axis // TypeDefIndex: 6335
			{
				// Constructors
				public Axis(); // 0x00000001803F46D0-0x00000001803F46E0
	
				// Methods
				public override object DeepClone(); // 0x0000000181934050-0x00000001819340C0
				internal override void CopyVars(Platform_Custom.Element destination); // 0x0000000181933C70-0x0000000181933CC0
			}
	
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private sealed class BTBFoNEugzBOjcSnJHEQHIRhepA : IEnumerable<Axis>, IEnumerator<Axis> // TypeDefIndex: 6336
			{
				// Fields
				private Platform_Custom.Axis aSrFEaALHwhGTdXfCdeUqgbwaZGO; // 0x10
				private int eLrUhJFgzEZElCzdKvcrgOLXLvL; // 0x18
				private int RQaeFqcJnaOYpZSBxtfUkVOjfOo; // 0x1C
				public Platform_PS4_Base gKPmvKLRxdGbmXiMfUeDjGbezUo; // 0x20
				public int otBnEJmMttdoVeQbzgtbeSTKsqUM; // 0x28
	
				// Properties
				Platform_Custom.Axis lmiaTpCsaXfKxySEjXIZoypgnjMr { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372440-0x0000000180372450 
				object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372440-0x0000000180372450 
	
				// Constructors
				[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
				public BTBFoNEugzBOjcSnJHEQHIRhepA(int <>1__state); // 0x00000001805EDEC0-0x00000001805EDF10
	
				// Methods
				[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
				IEnumerator<Platform_Custom.Axis> System.Collections.Generic.IEnumerable<Rewired.Data.Mapping.HardwareJoystickMap.Platform_Custom.Axis>.GetEnumerator(); // 0x0000000181934790-0x00000001819348A0
				[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
				IEnumerator IEnumerable.GetEnumerator(); // 0x0000000181934790-0x00000001819348A0
				private bool MoveNext(); // 0x00000001819345C0-0x0000000181934790
				[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
				void IEnumerator.Reset(); // 0x00000001819348A0-0x00000001819348F0
				void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			}
	
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private sealed class NsBBdBPqHvvczEJFfDKrAzMbqsX : IEnumerable<Button>, IEnumerator<Button> // TypeDefIndex: 6337
			{
				// Fields
				private Platform_Custom.Button aSrFEaALHwhGTdXfCdeUqgbwaZGO; // 0x10
				private int eLrUhJFgzEZElCzdKvcrgOLXLvL; // 0x18
				private int RQaeFqcJnaOYpZSBxtfUkVOjfOo; // 0x1C
				public Platform_PS4_Base gKPmvKLRxdGbmXiMfUeDjGbezUo; // 0x20
				public int IOvbxPdWiUNWsRBXDOyerTZzBXtq; // 0x28
	
				// Properties
				Platform_Custom.Button PlYXfEMpMbXcHXTJgpApbDPxYUh { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372440-0x0000000180372450 
				object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372440-0x0000000180372450 
	
				// Constructors
				[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
				public NsBBdBPqHvvczEJFfDKrAzMbqsX(int <>1__state); // 0x00000001805EDEC0-0x00000001805EDF10
	
				// Methods
				[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
				IEnumerator<Platform_Custom.Button> System.Collections.Generic.IEnumerable<Rewired.Data.Mapping.HardwareJoystickMap.Platform_Custom.Button>.GetEnumerator(); // 0x000000018193B760-0x000000018193B850
				[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
				IEnumerator IEnumerable.GetEnumerator(); // 0x000000018193B760-0x000000018193B850
				private bool MoveNext(); // 0x000000018193B5D0-0x000000018193B760
				[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
				void IEnumerator.Reset(); // 0x000000018193B850-0x000000018193B8A0
				void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			}
	
			// Constructors
			public Platform_PS4_Base(); // 0x00000001803FB1F0-0x00000001803FB200
	
			// Methods
			internal override bool Matches(BridgedControllerHWInfo BridgedControllerHWInfo, bool strictMatch, out int variantIndex, out Rewired.Data.Mapping.HardwareJoystickMap.Platform platformMap); // 0x000000018193F7A0-0x000000018193F850
			internal override IEnumerable<Axis> IterateAxes(); // 0x000000018193F6A0-0x000000018193F720
			internal override IEnumerable<Button> IterateButtons(); // 0x000000018193F720-0x000000018193F7A0
			internal override string[] GetAxisNames(ControllerElementIdentifier[] identifiers); // 0x000000018193E780-0x000000018193EA60
			internal override string[] GetEffectiveButtonNames(ControllerElementIdentifier[] identifiers); // 0x000000018193EC50-0x000000018193EF00
			internal override bool IsElementIdentifierMapped(int elementIdentifierId); // 0x000000018193F380-0x000000018193F6A0
			internal override void GetGameElementIdentifierIdMappings(out int[] buttons, out int[] axes); // 0x000000018193EF00-0x000000018193F380
			internal override AxisCalibrationData[] GetAxisCalibrationData(); // 0x000000018193DD20-0x000000018193E2D0
			internal override void GetAxisData(out AxisRange[] axisRanges, out HardwareAxisInfo[] axisInfos); // 0x000000018193E2D0-0x000000018193E780
			internal override void GetButtonData(out HardwareButtonInfo[] buttonInfos); // 0x000000018193EA60-0x000000018193EC50
			internal override ControllerElementType GetEffectiveElementIdentifierType(ControllerElementIdentifier elementIdentifier); // 0x00000001805F5B50-0x00000001805F5B70
			internal override bool GetEffectiveAxisRange(ControllerElementIdentifier elementIdentifier, out AxisRange axisRange); // 0x00000001805F5800-0x00000001805F5830
			public override object DeepClone(); // 0x000000018193DCB0-0x000000018193DD20
			internal override void CopyVars(Rewired.Data.Mapping.HardwareJoystickMap.Platform destination); // 0x000000018193DBD0-0x000000018193DCB0
		}
	
		[Serializable]
		[CustomClassObfuscation] // 0x0000000180207920-0x0000000180207950
		public sealed class Platform_PS4 : Platform_PS4_Base // TypeDefIndex: 6338
		{
			// Fields
			public Platform_PS4_Base[] variants; // 0x38
	
			// Properties
			internal override IList<Rewired.Data.Mapping.HardwareJoystickMap.Platform> variants_base { get; } // 0x00000001803743D0-0x00000001803743E0 
	
			// Constructors
			public Platform_PS4(); // 0x00000001803FB1F0-0x00000001803FB200
	
			// Methods
			internal override bool Matches(BridgedControllerHWInfo BridgedControllerHWInfo, bool strictMatch, out int variantIndex, out Rewired.Data.Mapping.HardwareJoystickMap.Platform platformMap); // 0x000000018193FED0-0x00000001819400F0
			public override object DeepClone(); // 0x000000018193FE60-0x000000018193FED0
			internal override void CopyVars(Rewired.Data.Mapping.HardwareJoystickMap.Platform destination); // 0x000000018193FCB0-0x000000018193FE60
		}
	
		[Serializable]
		[CustomClassObfuscation] // 0x0000000180207920-0x0000000180207950
		public class Platform_NintendoSwitch_Base : Platform_Custom // TypeDefIndex: 6339
		{
			// Fields
			public MatchingCriteria matchingCriteria; // 0x18
			public Elements elements; // 0x20
			private Axis[] _axesOrigGame; // 0x28
			private Button[] _buttonsOrigGame; // 0x30
	
			// Properties
			public override int assignedButtonCount { get; } // 0x00000001805F64C0-0x00000001805F64E0 
			public override int assignedAxisCount { get; } // 0x00000001805F64A0-0x00000001805F64C0 
			internal override InputPlatform platform { get; } // 0x000000018144BA60-0x000000018144BA70 
			internal override Axis[] Axes { get; } // 0x00000001818B5A40-0x00000001818B5BF0 
			internal override Button[] Buttons { get; } // 0x00000001818B5BF0-0x00000001818B5DC0 
			internal Axis[] Axes_orig { get; } // 0x00000001805F6480-0x00000001805F6490 
			internal Button[] Buttons_orig { get; } // 0x00000001805F6490-0x00000001805F64A0 
			internal override bool hasData { get; } // 0x00000001818B5DC0-0x00000001818B5E40 
			internal override bool disabled { get; } // 0x00000001805F64E0-0x00000001805F64F0 
			internal override bool isAllowed { get; } // 0x00000001805F6560-0x00000001805F65A0 
			internal override Elements_Base elements_base { get; } // 0x0000000180374AF0-0x0000000180374B00 
			internal override IList<Rewired.Data.Mapping.HardwareJoystickMap.Platform> variants_base { get; } // 0x000000018037DDC0-0x000000018037DDD0 
	
			// Nested types
			[Serializable]
			[CustomClassObfuscation] // 0x0000000180207920-0x0000000180207950
			public sealed class MatchingCriteria : Platform_Custom.MatchingCriteria // TypeDefIndex: 6340
			{
				// Fields
				public bool productName_useRegex; // 0x30
				public string[] productName; // 0x38
	
				// Properties
				internal override bool hasData { get; } // 0x00000001818AB1B0-0x00000001818AB1E0 
				internal override bool isAllowed { get; } // 0x00000001818AB240-0x00000001818AB270 
	
				// Constructors
				public MatchingCriteria(); // 0x00000001803F46D0-0x00000001803F46E0
	
				// Methods
				internal override bool Matches(BridgedControllerHWInfo bridgedControllerHWInfo, bool strictMatch); // 0x00000001818AA550-0x00000001818AA7C0
				public override object DeepClone(); // 0x00000001818A9CC0-0x00000001818A9D30
				internal override void CopyVars(MatchingCriteria_Base destination); // 0x00000001818A9A10-0x00000001818A9BE0
			}
	
			[Serializable]
			[CustomClassObfuscation] // 0x0000000180207920-0x0000000180207950
			public sealed class Elements : Platform_Custom.Elements // TypeDefIndex: 6341
			{
				// Fields
				public Axis[] axes; // 0x10
				public Button[] buttons; // 0x18
	
				// Properties
				public override int buttonCount { get; } // 0x00000001805EF540-0x00000001805EF550 
				public override int axisCount { get; } // 0x00000001805EF530-0x00000001805EF540 
	
				// Constructors
				public Elements(); // 0x00000001803F46D0-0x00000001803F46E0
	
				// Methods
				internal override ControllerElementType GetEffectiveElementIdentifierType(ControllerElementIdentifier elementIdentifier); // 0x00000001818A7DF0-0x00000001818A7FB0
				internal override bool GetEffectiveAxisRange(ControllerElementIdentifier elementIdentifier, out AxisRange axisRange); // 0x00000001818A68A0-0x00000001818A6B10
				public override object DeepClone(); // 0x00000001818A6790-0x00000001818A6800
				internal override void CopyVars(Elements_Base destination); // 0x00000001818A6140-0x00000001818A6210
			}
	
			[Serializable]
			[CustomClassObfuscation] // 0x0000000180207920-0x0000000180207950
			public sealed class Button : Platform_Custom.Button // TypeDefIndex: 6342
			{
				// Constructors
				public Button(); // 0x0000000180373240-0x0000000180373250
	
				// Methods
				public override object DeepClone(); // 0x00000001818A4B60-0x00000001818A4BD0
				internal override void CopyVars(Platform_Custom.Element destination); // 0x00000001818A4620-0x00000001818A4670
			}
	
			[Serializable]
			[CustomClassObfuscation] // 0x0000000180207920-0x0000000180207950
			public sealed class Axis : Platform_Custom.Axis // TypeDefIndex: 6343
			{
				// Constructors
				public Axis(); // 0x0000000180373240-0x0000000180373250
	
				// Methods
				public override object DeepClone(); // 0x00000001818A4080-0x00000001818A40F0
				internal override void CopyVars(Platform_Custom.Element destination); // 0x00000001818A3C00-0x00000001818A3C50
			}
	
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private sealed class XQrDbhCDAQZmLKoJQgSwuqMacwH : IEnumerable<Axis>, IEnumerator<Axis> // TypeDefIndex: 6344
			{
				// Fields
				private Platform_Custom.Axis aSrFEaALHwhGTdXfCdeUqgbwaZGO; // 0x10
				private int eLrUhJFgzEZElCzdKvcrgOLXLvL; // 0x18
				private int RQaeFqcJnaOYpZSBxtfUkVOjfOo; // 0x1C
				public Platform_NintendoSwitch_Base gKPmvKLRxdGbmXiMfUeDjGbezUo; // 0x20
				public int ERsJdabRVBlvmexWFudQlEOEgzz; // 0x28
	
				// Properties
				Platform_Custom.Axis lmiaTpCsaXfKxySEjXIZoypgnjMr { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372440-0x0000000180372450 
				object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372440-0x0000000180372450 
	
				// Constructors
				[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
				public XQrDbhCDAQZmLKoJQgSwuqMacwH(int <>1__state); // 0x00000001805EDEC0-0x00000001805EDF10
	
				// Methods
				[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
				IEnumerator<Platform_Custom.Axis> System.Collections.Generic.IEnumerable<Rewired.Data.Mapping.HardwareJoystickMap.Platform_Custom.Axis>.GetEnumerator(); // 0x00000001818B8BE0-0x00000001818B8CF0
				[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
				IEnumerator IEnumerable.GetEnumerator(); // 0x00000001818B8BE0-0x00000001818B8CF0
				private bool MoveNext(); // 0x00000001818B8A30-0x00000001818B8BE0
				[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
				void IEnumerator.Reset(); // 0x00000001818B8CF0-0x00000001818B8D40
				void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			}
	
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private sealed class xGHaRdeVItRBPtXXBzsXuKZcVCH : IEnumerable<Button>, IEnumerator<Button> // TypeDefIndex: 6345
			{
				// Fields
				private Platform_Custom.Button aSrFEaALHwhGTdXfCdeUqgbwaZGO; // 0x10
				private int eLrUhJFgzEZElCzdKvcrgOLXLvL; // 0x18
				private int RQaeFqcJnaOYpZSBxtfUkVOjfOo; // 0x1C
				public Platform_NintendoSwitch_Base gKPmvKLRxdGbmXiMfUeDjGbezUo; // 0x20
				public int umyEYedVOzahltUTGwzXdPVXGQEt; // 0x28
	
				// Properties
				Platform_Custom.Button PlYXfEMpMbXcHXTJgpApbDPxYUh { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372440-0x0000000180372450 
				object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372440-0x0000000180372450 
	
				// Constructors
				[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
				public xGHaRdeVItRBPtXXBzsXuKZcVCH(int <>1__state); // 0x00000001805EDEC0-0x00000001805EDF10
	
				// Methods
				[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
				IEnumerator<Platform_Custom.Button> System.Collections.Generic.IEnumerable<Rewired.Data.Mapping.HardwareJoystickMap.Platform_Custom.Button>.GetEnumerator(); // 0x00000001818BA6B0-0x00000001818BA7F0
				[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
				IEnumerator IEnumerable.GetEnumerator(); // 0x00000001818BA6B0-0x00000001818BA7F0
				private bool MoveNext(); // 0x00000001818BA510-0x00000001818BA6B0
				[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
				void IEnumerator.Reset(); // 0x00000001818BA7F0-0x00000001818BA840
				void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			}
	
			// Constructors
			public Platform_NintendoSwitch_Base(); // 0x00000001803F46D0-0x00000001803F46E0
	
			// Methods
			internal override bool Matches(BridgedControllerHWInfo BridgedControllerHWInfo, bool strictMatch, out int variantIndex, out Rewired.Data.Mapping.HardwareJoystickMap.Platform platformMap); // 0x00000001818B1590-0x00000001818B15F0
			internal override IEnumerable<Axis> IterateAxes(); // 0x00000001818B5940-0x00000001818B59C0
			internal override IEnumerable<Button> IterateButtons(); // 0x00000001818B59C0-0x00000001818B5A40
			internal override string[] GetAxisNames(ControllerElementIdentifier[] identifiers); // 0x00000001818B49C0-0x00000001818B4C80
			internal override string[] GetEffectiveButtonNames(ControllerElementIdentifier[] identifiers); // 0x00000001818B4E70-0x00000001818B5160
			internal override bool IsElementIdentifierMapped(int elementIdentifierId); // 0x00000001818B55F0-0x00000001818B5940
			internal override void GetGameElementIdentifierIdMappings(out int[] buttons, out int[] axes); // 0x00000001818B5160-0x00000001818B55F0
			internal override AxisCalibrationData[] GetAxisCalibrationData(); // 0x00000001818B3EE0-0x00000001818B4500
			internal override void GetAxisData(out AxisRange[] axisRanges, out HardwareAxisInfo[] axisInfos); // 0x00000001818B4500-0x00000001818B49C0
			internal override void GetButtonData(out HardwareButtonInfo[] buttonInfos); // 0x00000001818B4C80-0x00000001818B4E70
			internal override ControllerElementType GetEffectiveElementIdentifierType(ControllerElementIdentifier elementIdentifier); // 0x00000001805F5B50-0x00000001805F5B70
			internal override bool GetEffectiveAxisRange(ControllerElementIdentifier elementIdentifier, out AxisRange axisRange); // 0x00000001805F5800-0x00000001805F5830
			public override object DeepClone(); // 0x00000001818B3E70-0x00000001818B3EE0
			internal override void CopyVars(Rewired.Data.Mapping.HardwareJoystickMap.Platform destination); // 0x00000001818B3D00-0x00000001818B3E70
		}
	
		[Serializable]
		[CustomClassObfuscation] // 0x0000000180207920-0x0000000180207950
		public sealed class Platform_NintendoSwitch : Platform_NintendoSwitch_Base // TypeDefIndex: 6346
		{
			// Fields
			public Platform_NintendoSwitch_Base[] variants; // 0x38
	
			// Properties
			internal override IList<Rewired.Data.Mapping.HardwareJoystickMap.Platform> variants_base { get; } // 0x00000001803743D0-0x00000001803743E0 
	
			// Constructors
			public Platform_NintendoSwitch(); // 0x00000001803F46D0-0x00000001803F46E0
	
			// Methods
			internal override bool Matches(BridgedControllerHWInfo BridgedControllerHWInfo, bool strictMatch, out int variantIndex, out Rewired.Data.Mapping.HardwareJoystickMap.Platform platformMap); // 0x00000001818B60B0-0x00000001818B62A0
			public override object DeepClone(); // 0x00000001818B6040-0x00000001818B60B0
			internal override void CopyVars(Rewired.Data.Mapping.HardwareJoystickMap.Platform destination); // 0x00000001818B5E40-0x00000001818B6040
		}
	
		[Serializable]
		[CustomClassObfuscation] // 0x0000000180207920-0x0000000180207950
		public class Platform_Stadia_Base : Platform_Custom // TypeDefIndex: 6347
		{
			// Fields
			public MatchingCriteria matchingCriteria; // 0x18
			public Elements elements; // 0x20
			public string controllerName; // 0x28
			private Axis[] _axesOrigGame; // 0x30
			private Button[] _buttonsOrigGame; // 0x38
	
			// Properties
			public override int assignedButtonCount { get; } // 0x00000001805F64C0-0x00000001805F64E0 
			public override int assignedAxisCount { get; } // 0x00000001805F64A0-0x00000001805F64C0 
			public override string controllerNameOverride { get; } // 0x00000001803745B0-0x00000001803745C0 
			internal override InputPlatform platform { get; } // 0x0000000181452210-0x0000000181452220 
			internal override Axis[] Axes { get; } // 0x0000000181946050-0x0000000181946240 
			internal override Button[] Buttons { get; } // 0x0000000181946240-0x00000001819463B0 
			internal Axis[] Axes_orig { get; } // 0x00000001805F6480-0x00000001805F6490 
			internal Button[] Buttons_orig { get; } // 0x00000001805F6490-0x00000001805F64A0 
			internal override bool hasData { get; } // 0x00000001818B1970-0x00000001818B19E0 
			internal override bool disabled { get; } // 0x00000001805F64E0-0x00000001805F64F0 
			internal override bool isAllowed { get; } // 0x00000001805F6560-0x00000001805F65A0 
			internal override Elements_Base elements_base { get; } // 0x0000000180374AF0-0x0000000180374B00 
			internal override IList<Rewired.Data.Mapping.HardwareJoystickMap.Platform> variants_base { get; } // 0x000000018037DDC0-0x000000018037DDD0 
	
			// Nested types
			[Serializable]
			[CustomClassObfuscation] // 0x0000000180207920-0x0000000180207950
			public sealed class MatchingCriteria : Platform_Custom.MatchingCriteria // TypeDefIndex: 6348
			{
				// Fields
				public bool productName_useRegex; // 0x30
				public string[] productName; // 0x38
	
				// Properties
				internal override bool hasData { get; } // 0x00000001805F4360-0x00000001805F43A0 
				internal override bool isAllowed { get; } // 0x00000001805F43C0-0x00000001805F43F0 
	
				// Constructors
				public MatchingCriteria(); // 0x00000001803FB1F0-0x00000001803FB200
	
				// Methods
				internal override bool Matches(BridgedControllerHWInfo bridgedControllerHWInfo, bool strictMatch); // 0x000000018193AB30-0x000000018193AD50
				public override object DeepClone(); // 0x0000000181939990-0x0000000181939A00
				internal override void CopyVars(MatchingCriteria_Base destination); // 0x0000000181939660-0x0000000181939730
			}
	
			[Serializable]
			[CustomClassObfuscation] // 0x0000000180207920-0x0000000180207950
			public sealed class Elements : Platform_Custom.Elements // TypeDefIndex: 6349
			{
				// Fields
				public Axis[] axes; // 0x10
				public Button[] buttons; // 0x18
	
				// Properties
				public override int buttonCount { get; } // 0x00000001805EF540-0x00000001805EF550 
				public override int axisCount { get; } // 0x00000001805EF530-0x00000001805EF540 
	
				// Constructors
				public Elements(); // 0x00000001803FB1F0-0x00000001803FB200
	
				// Methods
				internal override ControllerElementType GetEffectiveElementIdentifierType(ControllerElementIdentifier elementIdentifier); // 0x0000000181937250-0x00000001819373F0
				internal override bool GetEffectiveAxisRange(ControllerElementIdentifier elementIdentifier, out AxisRange axisRange); // 0x00000001819364E0-0x0000000181936780
				public override object DeepClone(); // 0x0000000181936000-0x0000000181936070
				internal override void CopyVars(Elements_Base destination); // 0x0000000181935980-0x0000000181935A40
			}
	
			[Serializable]
			[CustomClassObfuscation] // 0x0000000180207920-0x0000000180207950
			public sealed class Button : Platform_Custom.Button // TypeDefIndex: 6350
			{
				// Constructors
				public Button(); // 0x00000001803F46D0-0x00000001803F46E0
	
				// Methods
				public override object DeepClone(); // 0x0000000181934EB0-0x0000000181934F20
				internal override void CopyVars(Platform_Custom.Element destination); // 0x0000000181934E60-0x0000000181934EB0
			}
	
			[Serializable]
			[CustomClassObfuscation] // 0x0000000180207920-0x0000000180207950
			public sealed class Axis : Platform_Custom.Axis // TypeDefIndex: 6351
			{
				// Constructors
				public Axis(); // 0x00000001803F46D0-0x00000001803F46E0
	
				// Methods
				public override object DeepClone(); // 0x0000000181934130-0x00000001819341A0
				internal override void CopyVars(Platform_Custom.Element destination); // 0x0000000181933CC0-0x0000000181933D30
			}
	
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private sealed class jNxenzbJKPLtWtqjNnMSWuGkiLk : IEnumerable<Axis>, IEnumerator<Axis> // TypeDefIndex: 6352
			{
				// Fields
				private Platform_Custom.Axis aSrFEaALHwhGTdXfCdeUqgbwaZGO; // 0x10
				private int eLrUhJFgzEZElCzdKvcrgOLXLvL; // 0x18
				private int RQaeFqcJnaOYpZSBxtfUkVOjfOo; // 0x1C
				public Platform_Stadia_Base gKPmvKLRxdGbmXiMfUeDjGbezUo; // 0x20
				public int pEBadAbjxbeiHDRavKlzalcAuMEM; // 0x28
	
				// Properties
				Platform_Custom.Axis lmiaTpCsaXfKxySEjXIZoypgnjMr { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372440-0x0000000180372450 
				object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372440-0x0000000180372450 
	
				// Constructors
				[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
				public jNxenzbJKPLtWtqjNnMSWuGkiLk(int <>1__state); // 0x00000001805EDEC0-0x00000001805EDF10
	
				// Methods
				[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
				IEnumerator<Platform_Custom.Axis> System.Collections.Generic.IEnumerable<Rewired.Data.Mapping.HardwareJoystickMap.Platform_Custom.Axis>.GetEnumerator(); // 0x000000018194A910-0x000000018194AA30
				[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
				IEnumerator IEnumerable.GetEnumerator(); // 0x000000018194A910-0x000000018194AA30
				private bool MoveNext(); // 0x000000018194A740-0x000000018194A910
				[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
				void IEnumerator.Reset(); // 0x000000018194AA30-0x000000018194AA80
				void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			}
	
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private sealed class BgrPHNLVoZIUwsPbcorknaQsvlY : IEnumerable<Button>, IEnumerator<Button> // TypeDefIndex: 6353
			{
				// Fields
				private Platform_Custom.Button aSrFEaALHwhGTdXfCdeUqgbwaZGO; // 0x10
				private int eLrUhJFgzEZElCzdKvcrgOLXLvL; // 0x18
				private int RQaeFqcJnaOYpZSBxtfUkVOjfOo; // 0x1C
				public Platform_Stadia_Base gKPmvKLRxdGbmXiMfUeDjGbezUo; // 0x20
				public int GNuiCdEaABybrZvwSBusMLNxLzw; // 0x28
	
				// Properties
				Platform_Custom.Button PlYXfEMpMbXcHXTJgpApbDPxYUh { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372440-0x0000000180372450 
				object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372440-0x0000000180372450 
	
				// Constructors
				[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
				public BgrPHNLVoZIUwsPbcorknaQsvlY(int <>1__state); // 0x00000001805EDEC0-0x00000001805EDF10
	
				// Methods
				[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
				IEnumerator<Platform_Custom.Button> System.Collections.Generic.IEnumerable<Rewired.Data.Mapping.HardwareJoystickMap.Platform_Custom.Button>.GetEnumerator(); // 0x0000000181934AB0-0x0000000181934B90
				[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
				IEnumerator IEnumerable.GetEnumerator(); // 0x0000000181934AB0-0x0000000181934B90
				private bool MoveNext(); // 0x00000001819348F0-0x0000000181934AB0
				[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
				void IEnumerator.Reset(); // 0x0000000181934B90-0x0000000181934BE0
				void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			}
	
			// Constructors
			public Platform_Stadia_Base(); // 0x00000001803FB1F0-0x00000001803FB200
	
			// Methods
			internal override bool Matches(BridgedControllerHWInfo BridgedControllerHWInfo, bool strictMatch, out int variantIndex, out Rewired.Data.Mapping.HardwareJoystickMap.Platform platformMap); // 0x00000001818B1590-0x00000001818B15F0
			internal override IEnumerable<Axis> IterateAxes(); // 0x0000000181945F50-0x0000000181945FD0
			internal override IEnumerable<Button> IterateButtons(); // 0x0000000181945FD0-0x0000000181946050
			internal override string[] GetAxisNames(ControllerElementIdentifier[] identifiers); // 0x0000000181944FE0-0x00000001819452A0
			internal override string[] GetEffectiveButtonNames(ControllerElementIdentifier[] identifiers); // 0x00000001819454C0-0x0000000181945760
			internal override bool IsElementIdentifierMapped(int elementIdentifierId); // 0x0000000181945B50-0x0000000181945F50
			internal override void GetGameElementIdentifierIdMappings(out int[] buttons, out int[] axes); // 0x0000000181945760-0x0000000181945B50
			internal override AxisCalibrationData[] GetAxisCalibrationData(); // 0x0000000181944590-0x0000000181944B50
			internal override void GetAxisData(out AxisRange[] axisRanges, out HardwareAxisInfo[] axisInfos); // 0x0000000181944B50-0x0000000181944FE0
			internal override void GetButtonData(out HardwareButtonInfo[] buttonInfos); // 0x00000001819452A0-0x00000001819454C0
			internal override ControllerElementType GetEffectiveElementIdentifierType(ControllerElementIdentifier elementIdentifier); // 0x00000001805F5B50-0x00000001805F5B70
			internal override bool GetEffectiveAxisRange(ControllerElementIdentifier elementIdentifier, out AxisRange axisRange); // 0x00000001805F5800-0x00000001805F5830
			public override object DeepClone(); // 0x0000000181944520-0x0000000181944590
			internal override void CopyVars(Rewired.Data.Mapping.HardwareJoystickMap.Platform destination); // 0x00000001819443E0-0x0000000181944520
		}
	
		[Serializable]
		[CustomClassObfuscation] // 0x0000000180207920-0x0000000180207950
		public sealed class Platform_Stadia : Platform_Stadia_Base // TypeDefIndex: 6354
		{
			// Fields
			public Platform_Stadia_Base[] variants; // 0x40
	
			// Properties
			internal override IList<Rewired.Data.Mapping.HardwareJoystickMap.Platform> variants_base { get; } // 0x00000001803C7290-0x00000001803C72A0 
	
			// Constructors
			public Platform_Stadia(); // 0x00000001803FB1F0-0x00000001803FB200
	
			// Methods
			internal override bool Matches(BridgedControllerHWInfo BridgedControllerHWInfo, bool strictMatch, out int variantIndex, out Rewired.Data.Mapping.HardwareJoystickMap.Platform platformMap); // 0x0000000181946610-0x00000001819467E0
			public override object DeepClone(); // 0x00000001819465A0-0x0000000181946610
			internal override void CopyVars(Rewired.Data.Mapping.HardwareJoystickMap.Platform destination); // 0x00000001819463B0-0x00000001819465A0
		}
	
		[Serializable]
		[CustomClassObfuscation] // 0x0000000180207920-0x0000000180207950
		public class Platform_InternalDriver_Base : Platform_Custom // TypeDefIndex: 6355
		{
			// Fields
			public MatchingCriteria matchingCriteria; // 0x18
			public Elements elements; // 0x20
			private Axis[] _axesOrigGame; // 0x28
			private Button[] _buttonsOrigGame; // 0x30
	
			// Properties
			public override int assignedButtonCount { get; } // 0x00000001805F64C0-0x00000001805F64E0 
			public override int assignedAxisCount { get; } // 0x00000001805F64A0-0x00000001805F64C0 
			internal override InputPlatform platform { get; } // 0x000000018144B470-0x000000018144B480 
			internal override Axis[] Axes { get; } // 0x00000001818B15F0-0x00000001818B17C0 
			internal override Button[] Buttons { get; } // 0x00000001818B17C0-0x00000001818B1970 
			internal Axis[] Axes_orig { get; } // 0x00000001805F6480-0x00000001805F6490 
			internal Button[] Buttons_orig { get; } // 0x00000001805F6490-0x00000001805F64A0 
			internal override bool hasData { get; } // 0x00000001818B1970-0x00000001818B19E0 
			internal override bool disabled { get; } // 0x00000001805F64E0-0x00000001805F64F0 
			internal override bool isAllowed { get; } // 0x00000001805F6560-0x00000001805F65A0 
			internal override Elements_Base elements_base { get; } // 0x0000000180374AF0-0x0000000180374B00 
			internal override IList<Rewired.Data.Mapping.HardwareJoystickMap.Platform> variants_base { get; } // 0x000000018037DDC0-0x000000018037DDD0 
	
			// Nested types
			[Serializable]
			[CustomClassObfuscation] // 0x0000000180207920-0x0000000180207950
			public sealed class MatchingCriteria : Platform_Custom.MatchingCriteria // TypeDefIndex: 6356
			{
				// Fields
				public bool productName_useRegex; // 0x30
				public string[] productName; // 0x38
				public VidPid[] vidPid; // 0x40
				public int hatCount; // 0x48
	
				// Properties
				internal override bool hasData { get; } // 0x00000001818AB0C0-0x00000001818AB140 
				internal override bool isAllowed { get; } // 0x00000001818AB240-0x00000001818AB270 
	
				// Constructors
				public MatchingCriteria(); // 0x00000001803F46D0-0x00000001803F46E0
	
				// Methods
				internal override bool Matches(BridgedControllerHWInfo bridgedControllerHWInfo, bool strictMatch); // 0x00000001818AA1B0-0x00000001818AA550
				internal override bool ElementCountsMatch(BridgedControllerHWInfo bridgedControllerHWInfo, out bool alternateMatched); // 0x00000001818A9E10-0x00000001818A9E90
				public override object DeepClone(); // 0x00000001818A9C50-0x00000001818A9CC0
				internal override void CopyVars(MatchingCriteria_Base destination); // 0x00000001818A9720-0x00000001818A98D0
				private bool ProductNameMatches(string name); // 0x00000001818AAFD0-0x00000001818AB0C0
			}
	
			[Serializable]
			[CustomClassObfuscation] // 0x0000000180207920-0x0000000180207950
			public sealed class Elements : Platform_Custom.Elements // TypeDefIndex: 6357
			{
				// Fields
				public Axis[] axes; // 0x10
				public Button[] buttons; // 0x18
	
				// Properties
				public override int buttonCount { get; } // 0x00000001805EF540-0x00000001805EF550 
				public override int axisCount { get; } // 0x00000001805EF530-0x00000001805EF540 
	
				// Constructors
				public Elements(); // 0x00000001803F46D0-0x00000001803F46E0
	
				// Methods
				internal override ControllerElementType GetEffectiveElementIdentifierType(ControllerElementIdentifier elementIdentifier); // 0x00000001818A8150-0x00000001818A8310
				internal override bool GetEffectiveAxisRange(ControllerElementIdentifier elementIdentifier, out AxisRange axisRange); // 0x00000001818A6B10-0x00000001818A6E60
				public override object DeepClone(); // 0x00000001818A65D0-0x00000001818A6640
				internal override void CopyVars(Elements_Base destination); // 0x00000001818A6210-0x00000001818A62E0
			}
	
			[Serializable]
			[CustomClassObfuscation] // 0x0000000180207920-0x0000000180207950
			public sealed class Button : Platform_Custom.Button // TypeDefIndex: 6358
			{
				// Fields
				public int sourceHat; // 0x60
				public HatDirection sourceHatDirection; // 0x64
				public HatType sourceHatType; // 0x68
	
				// Constructors
				public Button(); // 0x0000000180373240-0x0000000180373250
	
				// Methods
				public override object DeepClone(); // 0x00000001818A4DF0-0x00000001818A4E60
				internal override void CopyVars(Platform_Custom.Element destination); // 0x00000001818A4AB0-0x00000001818A4B60
			}
	
			[Serializable]
			[CustomClassObfuscation] // 0x0000000180207920-0x0000000180207950
			public sealed class Axis : Platform_Custom.Axis // TypeDefIndex: 6359
			{
				// Fields
				public int sourceHat; // 0x68
				public AxisDirection sourceHatDirection; // 0x6C
				public HatType sourceHatType; // 0x70
				public AxisRange sourceHatRange; // 0x74
	
				// Constructors
				public Axis(); // 0x0000000180373240-0x0000000180373250
	
				// Methods
				public override object DeepClone(); // 0x00000001818A3FA0-0x00000001818A4010
				internal override void CopyVars(Platform_Custom.Element destination); // 0x00000001818A3C50-0x00000001818A3D30
			}
	
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private sealed class DTwGUWcdtZLoYGgkpfHjNkVhJXaY : IEnumerable<Axis>, IEnumerator<Axis> // TypeDefIndex: 6360
			{
				// Fields
				private Platform_Custom.Axis aSrFEaALHwhGTdXfCdeUqgbwaZGO; // 0x10
				private int eLrUhJFgzEZElCzdKvcrgOLXLvL; // 0x18
				private int RQaeFqcJnaOYpZSBxtfUkVOjfOo; // 0x1C
				public Platform_InternalDriver_Base gKPmvKLRxdGbmXiMfUeDjGbezUo; // 0x20
				public int OKqDOIeGjuUmWPnbtTNDBwaJFkg; // 0x28
	
				// Properties
				Platform_Custom.Axis lmiaTpCsaXfKxySEjXIZoypgnjMr { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372440-0x0000000180372450 
				object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372440-0x0000000180372450 
	
				// Constructors
				[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
				public DTwGUWcdtZLoYGgkpfHjNkVhJXaY(int <>1__state); // 0x00000001818A5B90-0x00000001818A5C00
	
				// Methods
				[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
				IEnumerator<Platform_Custom.Axis> System.Collections.Generic.IEnumerable<Rewired.Data.Mapping.HardwareJoystickMap.Platform_Custom.Axis>.GetEnumerator(); // 0x00000001818A59D0-0x00000001818A5B40
				[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
				IEnumerator IEnumerable.GetEnumerator(); // 0x00000001818A59D0-0x00000001818A5B40
				private bool MoveNext(); // 0x00000001818A5820-0x00000001818A59D0
				[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
				void IEnumerator.Reset(); // 0x00000001818A5B40-0x00000001818A5B90
				void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			}
	
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private sealed class cEdIVWppmhuWZkBRUomjDjDWdHX : IEnumerable<Button>, IEnumerator<Button> // TypeDefIndex: 6361
			{
				// Fields
				private Platform_Custom.Button aSrFEaALHwhGTdXfCdeUqgbwaZGO; // 0x10
				private int eLrUhJFgzEZElCzdKvcrgOLXLvL; // 0x18
				private int RQaeFqcJnaOYpZSBxtfUkVOjfOo; // 0x1C
				public Platform_InternalDriver_Base gKPmvKLRxdGbmXiMfUeDjGbezUo; // 0x20
				public int MfWCXKDbkSvVWDfejeNcfleegxhD; // 0x28
	
				// Properties
				Platform_Custom.Button PlYXfEMpMbXcHXTJgpApbDPxYUh { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372440-0x0000000180372450 
				object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372440-0x0000000180372450 
	
				// Constructors
				[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
				public cEdIVWppmhuWZkBRUomjDjDWdHX(int <>1__state); // 0x00000001805EDEC0-0x00000001805EDF10
	
				// Methods
				[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
				IEnumerator<Platform_Custom.Button> System.Collections.Generic.IEnumerable<Rewired.Data.Mapping.HardwareJoystickMap.Platform_Custom.Button>.GetEnumerator(); // 0x00000001818B9230-0x00000001818B9310
				[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
				IEnumerator IEnumerable.GetEnumerator(); // 0x00000001818B9230-0x00000001818B9310
				private bool MoveNext(); // 0x00000001818B9090-0x00000001818B9230
				[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
				void IEnumerator.Reset(); // 0x00000001818B9310-0x00000001818B9360
				void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			}
	
			// Constructors
			public Platform_InternalDriver_Base(); // 0x00000001803F46D0-0x00000001803F46E0
	
			// Methods
			internal override bool Matches(BridgedControllerHWInfo BridgedControllerHWInfo, bool strictMatch, out int variantIndex, out Rewired.Data.Mapping.HardwareJoystickMap.Platform platformMap); // 0x00000001818B1590-0x00000001818B15F0
			internal override IEnumerable<Axis> IterateAxes(); // 0x00000001818B1460-0x00000001818B1510
			internal override IEnumerable<Button> IterateButtons(); // 0x00000001818B1510-0x00000001818B1590
			internal override string[] GetAxisNames(ControllerElementIdentifier[] identifiers); // 0x00000001818B0450-0x00000001818B0740
			internal override string[] GetEffectiveButtonNames(ControllerElementIdentifier[] identifiers); // 0x00000001818B0950-0x00000001818B0C00
			internal override bool IsElementIdentifierMapped(int elementIdentifierId); // 0x00000001818B1050-0x00000001818B1460
			internal override void GetGameElementIdentifierIdMappings(out int[] buttons, out int[] axes); // 0x00000001818B0C00-0x00000001818B1050
			internal override AxisCalibrationData[] GetAxisCalibrationData(); // 0x00000001818AF980-0x00000001818AFF80
			internal override void GetAxisData(out AxisRange[] axisRanges, out HardwareAxisInfo[] axisInfos); // 0x00000001818AFF80-0x00000001818B0450
			internal override void GetButtonData(out HardwareButtonInfo[] buttonInfos); // 0x00000001818B0740-0x00000001818B0950
			internal override ControllerElementType GetEffectiveElementIdentifierType(ControllerElementIdentifier elementIdentifier); // 0x00000001805F5B50-0x00000001805F5B70
			internal override bool GetEffectiveAxisRange(ControllerElementIdentifier elementIdentifier, out AxisRange axisRange); // 0x00000001805F5800-0x00000001805F5830
			public override object DeepClone(); // 0x00000001818AF910-0x00000001818AF980
			internal override void CopyVars(Rewired.Data.Mapping.HardwareJoystickMap.Platform destination); // 0x00000001818AF840-0x00000001818AF910
		}
	
		[Serializable]
		[CustomClassObfuscation] // 0x0000000180207920-0x0000000180207950
		public sealed class Platform_InternalDriver : Platform_InternalDriver_Base // TypeDefIndex: 6362
		{
			// Fields
			public Platform_InternalDriver_Base[] variants; // 0x38
	
			// Properties
			internal override IList<Rewired.Data.Mapping.HardwareJoystickMap.Platform> variants_base { get; } // 0x00000001803743D0-0x00000001803743E0 
	
			// Constructors
			public Platform_InternalDriver(); // 0x00000001803F46D0-0x00000001803F46E0
	
			// Methods
			internal override bool Matches(BridgedControllerHWInfo BridgedControllerHWInfo, bool strictMatch, out int variantIndex, out Rewired.Data.Mapping.HardwareJoystickMap.Platform platformMap); // 0x00000001818B1BA0-0x00000001818B1D70
			public override object DeepClone(); // 0x00000001818B1B30-0x00000001818B1BA0
			internal override void CopyVars(Rewired.Data.Mapping.HardwareJoystickMap.Platform destination); // 0x00000001818B19E0-0x00000001818B1B30
		}
	
		[Serializable]
		[CustomClassObfuscation] // 0x0000000180207920-0x0000000180207950
		public class Platform_SDL2_Base : Rewired.Data.Mapping.HardwareJoystickMap.Platform // TypeDefIndex: 6363
		{
			// Fields
			public MatchingCriteria matchingCriteria; // 0x18
			public Elements elements; // 0x20
	
			// Properties
			internal override InputPlatform platform { get; } // 0x000000018144BAD0-0x000000018144BAE0 
			internal override bool hasData { get; } // 0x00000001805F64F0-0x00000001805F6560 
			internal override bool disabled { get; } // 0x00000001805F64E0-0x00000001805F64F0 
			internal override bool isAllowed { get; } // 0x00000001805F6560-0x00000001805F65A0 
			internal Axis[] Axes_orig { get; } // 0x00000001805F6480-0x00000001805F6490 
			internal Button[] Buttons_orig { get; } // 0x00000001805F6490-0x00000001805F64A0 
			internal override IList<Rewired.Data.Mapping.HardwareJoystickMap.Platform> variants_base { get; } // 0x000000018037DDC0-0x000000018037DDD0 
			public override int assignedButtonCount { get; } // 0x00000001805F64C0-0x00000001805F64E0 
			public override int assignedAxisCount { get; } // 0x00000001805F64A0-0x00000001805F64C0 
			internal override Elements_Base elements_base { get; } // 0x0000000180374AF0-0x0000000180374B00 
	
			// Nested types
			[Serializable]
			[CustomClassObfuscation] // 0x0000000180207920-0x0000000180207950
			public sealed class MatchingCriteria : MatchingCriteria_Base // TypeDefIndex: 6364
			{
				// Fields
				public int hatCount; // 0x28
				public bool manufacturer_useRegex; // 0x2C
				public bool productName_useRegex; // 0x2D
				public bool systemName_useRegex; // 0x2E
				public string[] manufacturer; // 0x30
				public string[] productName; // 0x38
				public string[] systemName; // 0x40
				public string[] productGUID; // 0x48
	
				// Properties
				internal override bool hasData { get; } // 0x000000018193B580-0x000000018193B5B0 
				internal override bool isAllowed { get; } // 0x00000001805F43A0-0x00000001805F43C0 
				internal override int alternateElementCount { get; } // 0x000000018037DDC0-0x000000018037DDD0 
	
				// Nested types
				[Serializable]
				public sealed class ElementCount : MatchingCriteria_Base.ElementCount_Base // TypeDefIndex: 6365
				{
					// Fields
					public int hatCount; // 0x18
	
					// Constructors
					public ElementCount(); // 0x00000001803F46D0-0x00000001803F46E0
	
					// Methods
					public override object DeepClone(); // 0x0000000181935840-0x00000001819358B0
					internal override void CopyVars(MatchingCriteria_Base.ElementCount_Base param_0000d202); // 0x00000001819356D0-0x0000000181935740
					internal override bool Matches(BridgedControllerHWInfo param_0000d203); // 0x00000001805EE280-0x00000001805EE2E0
				}
	
				// Constructors
				public MatchingCriteria(); // 0x00000001803F46D0-0x00000001803F46E0
	
				// Methods
				internal override bool Matches(BridgedControllerHWInfo bridgedControllerHWInfo, bool strictMatch); // 0x000000018193AD50-0x000000018193AF00
				internal override ElementCount_Base GetAlternateElementCount(int index); // 0x000000018037DDC0-0x000000018037DDD0
				internal override bool ElementCountsMatch(BridgedControllerHWInfo bridgedControllerHWInfo, out bool alternateMatched); // 0x0000000181939BC0-0x0000000181939C60
				private bool AnyNameMatches(BridgedControllerHWInfo bridgedControllerHWInfo); // 0x0000000181938550-0x00000001819387C0
				private bool NameMatches(string name, string[] names, bool useRegex); // 0x000000018193B100-0x000000018193B220
				public override object DeepClone(); // 0x0000000181939920-0x0000000181939990
				internal override void CopyVars(MatchingCriteria_Base destination); // 0x0000000181939480-0x0000000181939610
			}
	
			[Serializable]
			[CustomClassObfuscation] // 0x0000000180207920-0x0000000180207950
			public sealed class Elements : Elements_Base // TypeDefIndex: 6366
			{
				// Fields
				public Axis[] axes; // 0x10
				public Button[] buttons; // 0x18
	
				// Properties
				public override int buttonCount { get; } // 0x00000001805EF540-0x00000001805EF550 
				public override int axisCount { get; } // 0x00000001805EF530-0x00000001805EF540 
				internal IEnumerable<Axis> Axes { get; } // 0x0000000181937C60-0x0000000181937CE0 
				internal IEnumerable<Button> Buttons { get; } // 0x0000000181937D60-0x0000000181937DE0 
	
				// Nested types
				[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
				private sealed class VnyIlJGNxbzdhVKGDNSaJmvmjDt : IEnumerable<Axis>, IEnumerator<Axis> // TypeDefIndex: 6367
				{
					// Fields
					private Axis aSrFEaALHwhGTdXfCdeUqgbwaZGO; // 0x10
					private int eLrUhJFgzEZElCzdKvcrgOLXLvL; // 0x18
					private int RQaeFqcJnaOYpZSBxtfUkVOjfOo; // 0x1C
					public Elements gKPmvKLRxdGbmXiMfUeDjGbezUo; // 0x20
					public int RDIGNTEYsGGGcPnUoJaYatxMQIGu; // 0x28
	
					// Properties
					Axis dYrcdAbGekmCeefejhcyEnMgOPn { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372440-0x0000000180372450 
					object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372440-0x0000000180372450 
	
					// Constructors
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					public VnyIlJGNxbzdhVKGDNSaJmvmjDt(int <>1__state); // 0x00000001805EDEC0-0x00000001805EDF10
	
					// Methods
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					IEnumerator<Axis> System.Collections.Generic.IEnumerable<Rewired.Data.Mapping.HardwareJoystickMap.Platform_SDL2_Base.Axis>.GetEnumerator(); // 0x0000000181949680-0x0000000181949770
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					IEnumerator IEnumerable.GetEnumerator(); // 0x0000000181949680-0x0000000181949770
					private bool MoveNext(); // 0x0000000181949550-0x0000000181949680
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					void IEnumerator.Reset(); // 0x0000000181949770-0x00000001819497C0
					void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
				}
	
				[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
				private sealed class rWVWNdyfOBDyrMOIZPcHEEFfvlI : IEnumerable<Button>, IEnumerator<Button> // TypeDefIndex: 6368
				{
					// Fields
					private Button aSrFEaALHwhGTdXfCdeUqgbwaZGO; // 0x10
					private int eLrUhJFgzEZElCzdKvcrgOLXLvL; // 0x18
					private int RQaeFqcJnaOYpZSBxtfUkVOjfOo; // 0x1C
					public Elements gKPmvKLRxdGbmXiMfUeDjGbezUo; // 0x20
					public int qhFhsQmEjLIJaKwmGYvMIDsdOYE; // 0x28
	
					// Properties
					Button aaCYadWUVvfTeqVLjUBuiXYVHCh { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372440-0x0000000180372450 
					object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372440-0x0000000180372450 
	
					// Constructors
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					public rWVWNdyfOBDyrMOIZPcHEEFfvlI(int <>1__state); // 0x00000001805EDEC0-0x00000001805EDF10
	
					// Methods
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					IEnumerator<Button> System.Collections.Generic.IEnumerable<Rewired.Data.Mapping.HardwareJoystickMap.Platform_SDL2_Base.Button>.GetEnumerator(); // 0x000000018194B180-0x000000018194B270
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					IEnumerator IEnumerable.GetEnumerator(); // 0x000000018194B180-0x000000018194B270
					private bool MoveNext(); // 0x000000018194B010-0x000000018194B180
					[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
					void IEnumerator.Reset(); // 0x000000018194B270-0x000000018194B2C0
					void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
				}
	
				// Constructors
				public Elements(); // 0x00000001803F46D0-0x00000001803F46E0
	
				// Methods
				internal Axis GetAxis(int axisIndex); // 0x00000001819360E0-0x0000000181936140
				internal override ControllerElementType GetEffectiveElementIdentifierType(ControllerElementIdentifier elementIdentifier); // 0x00000001819378E0-0x0000000181937A90
				internal override bool GetEffectiveAxisRange(ControllerElementIdentifier elementIdentifier, out AxisRange axisRange); // 0x0000000181936F30-0x0000000181937250
				public override object DeepClone(); // 0x0000000181936070-0x00000001819360E0
				internal override void CopyVars(Elements_Base destination); // 0x0000000181935B50-0x0000000181935BF0
			}
	
			[Serializable]
			[CustomClassObfuscation] // 0x0000000180207920-0x0000000180207950
			public abstract class Element : IDeepCloneable // TypeDefIndex: 6369
			{
				// Constructors
				protected Element(); // 0x0000000180373240-0x0000000180373250
	
				// Methods
				public abstract object DeepClone();
				protected virtual void ImportVars(Element source); // 0x00000001803774A0-0x00000001803774B0
			}
	
			[Serializable]
			[CustomClassObfuscation] // 0x0000000180207920-0x0000000180207950
			public class Button : Element // TypeDefIndex: 6370
			{
				// Fields
				public int elementIdentifier; // 0x10
				public HardwareElementSourceTypeWithHat sourceType; // 0x14
				public int sourceButton; // 0x18
				public int sourceAxis; // 0x1C
				public Pole sourceAxisPole; // 0x20
				public float axisDeadZone; // 0x24
				public int sourceHat; // 0x28
				public HatType sourceHatType; // 0x2C
				public HatDirection sourceHatDirection; // 0x30
				public bool requireMultipleButtons; // 0x34
				public int[] requiredButtons; // 0x38
				public bool ignoreIfButtonsActive; // 0x40
				public int[] ignoreIfButtonsActiveButtons; // 0x48
				public HardwareButtonInfo buttonInfo; // 0x50
	
				// Constructors
				public Button(); // 0x00000001805ED040-0x00000001805ED060
	
				// Methods
				public override object DeepClone(); // 0x0000000181935200-0x0000000181935270
				protected override void ImportVars(Element source); // 0x00000001819353C0-0x00000001819355C0
			}
	
			[Serializable]
			[CustomClassObfuscation] // 0x0000000180207920-0x0000000180207950
			public class Axis : Element // TypeDefIndex: 6371
			{
				// Fields
				public int elementIdentifier; // 0x10
				public HardwareElementSourceTypeWithHat sourceType; // 0x14
				public int sourceAxis; // 0x18
				public AxisRange sourceAxisRange; // 0x1C
				public bool invert; // 0x20
				public float axisDeadZone; // 0x24
				public bool calibrateAxis; // 0x28
				public float axisZero; // 0x2C
				public float axisMin; // 0x30
				public float axisMax; // 0x34
				public AxisCalibrationInfoEntry[] alternateCalibrations; // 0x38
				public HardwareAxisInfo axisInfo; // 0x40
				public int sourceButton; // 0x48
				public Pole buttonAxisContribution; // 0x4C
				public int sourceHat; // 0x50
				public AxisDirection sourceHatDirection; // 0x54
				public AxisRange sourceHatRange; // 0x58
	
				// Constructors
				public Axis(); // 0x00000001805ECB60-0x00000001805ECB80
	
				// Methods
				public override object DeepClone(); // 0x0000000181933D80-0x0000000181933E10
				protected override void ImportVars(Element source); // 0x0000000181934340-0x00000001819345C0
			}
	
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private sealed class GEZFpgkKgRxPvcRLmPGEHqGGNIyc : IEnumerable<Axis>, IEnumerator<Axis> // TypeDefIndex: 6372
			{
				// Fields
				private Axis aSrFEaALHwhGTdXfCdeUqgbwaZGO; // 0x10
				private int eLrUhJFgzEZElCzdKvcrgOLXLvL; // 0x18
				private int RQaeFqcJnaOYpZSBxtfUkVOjfOo; // 0x1C
				public Platform_SDL2_Base gKPmvKLRxdGbmXiMfUeDjGbezUo; // 0x20
				public int MkYcyrMpguQVynujwUqgSecgjnS; // 0x28
				public int kUZavVxuoFGTXaGHdihJOfOTqSsz; // 0x2C
	
				// Properties
				Axis dYrcdAbGekmCeefejhcyEnMgOPn { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372440-0x0000000180372450 
				object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372440-0x0000000180372450 
	
				// Constructors
				[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
				public GEZFpgkKgRxPvcRLmPGEHqGGNIyc(int <>1__state); // 0x0000000181938170-0x00000001819381E0
	
				// Methods
				[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
				IEnumerator<Axis> System.Collections.Generic.IEnumerable<Rewired.Data.Mapping.HardwareJoystickMap.Platform_SDL2_Base.Axis>.GetEnumerator(); // 0x0000000181938020-0x0000000181938120
				[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
				IEnumerator IEnumerable.GetEnumerator(); // 0x0000000181938020-0x0000000181938120
				private bool MoveNext(); // 0x0000000181937E80-0x0000000181938020
				[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
				void IEnumerator.Reset(); // 0x0000000181938120-0x0000000181938170
				void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			}
	
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private sealed class ZHCkLrFdlfcmUCXrRbhCljEycoGg : IEnumerable<Button>, IEnumerator<Button> // TypeDefIndex: 6373
			{
				// Fields
				private Button aSrFEaALHwhGTdXfCdeUqgbwaZGO; // 0x10
				private int eLrUhJFgzEZElCzdKvcrgOLXLvL; // 0x18
				private int RQaeFqcJnaOYpZSBxtfUkVOjfOo; // 0x1C
				public Platform_SDL2_Base gKPmvKLRxdGbmXiMfUeDjGbezUo; // 0x20
				public int zCKwvnmhCVYBIHPFuFdarPHRZRk; // 0x28
				public int FBMUfvOhXnFxnWWJOEscwbYbcwl; // 0x2C
	
				// Properties
				Button aaCYadWUVvfTeqVLjUBuiXYVHCh { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372440-0x0000000180372450 
				object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372440-0x0000000180372450 
	
				// Constructors
				[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
				public ZHCkLrFdlfcmUCXrRbhCljEycoGg(int <>1__state); // 0x0000000181949E10-0x0000000181949E90
	
				// Methods
				[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
				IEnumerator<Button> System.Collections.Generic.IEnumerable<Rewired.Data.Mapping.HardwareJoystickMap.Platform_SDL2_Base.Button>.GetEnumerator(); // 0x0000000181949CA0-0x0000000181949DC0
				[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
				IEnumerator IEnumerable.GetEnumerator(); // 0x0000000181949CA0-0x0000000181949DC0
				private bool MoveNext(); // 0x0000000181949AF0-0x0000000181949CA0
				[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
				void IEnumerator.Reset(); // 0x0000000181949DC0-0x0000000181949E10
				void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			}
	
			// Constructors
			public Platform_SDL2_Base(); // 0x00000001803F46D0-0x00000001803F46E0
	
			// Methods
			internal override bool Matches(BridgedControllerHWInfo BridgedControllerHWInfo, bool strictMatch, out int variantIndex, out Rewired.Data.Mapping.HardwareJoystickMap.Platform platformMap); // 0x00000001818B1590-0x00000001818B15F0
			internal override string[] GetAxisNames(ControllerElementIdentifier[] identifiers); // 0x0000000181942FF0-0x00000001819432E0
			internal override string[] GetEffectiveButtonNames(ControllerElementIdentifier[] identifiers); // 0x0000000181943540-0x0000000181943800
			internal override bool IsElementIdentifierMapped(int elementIdentifierId); // 0x0000000181943BE0-0x0000000181943F30
			internal override void GetGameElementIdentifierIdMappings(out int[] buttons, out int[] axes); // 0x0000000181943800-0x0000000181943BE0
			internal override AxisCalibrationData[] GetAxisCalibrationData(); // 0x0000000181942530-0x0000000181942AF0
			internal override void GetAxisData(out AxisRange[] axisRanges, out HardwareAxisInfo[] axisInfos); // 0x0000000181942AF0-0x0000000181942FF0
			internal override void GetButtonData(out HardwareButtonInfo[] buttonInfos); // 0x00000001819432E0-0x00000001819434F0
			internal override ControllerElementType GetEffectiveElementIdentifierType(ControllerElementIdentifier elementIdentifier); // 0x00000001805F5B50-0x00000001805F5B70
			internal override bool GetEffectiveAxisRange(ControllerElementIdentifier elementIdentifier, out AxisRange axisRange); // 0x00000001819434F0-0x0000000181943540
			internal IEnumerable<Axis> IterateAxes(); // 0x0000000181943F30-0x0000000181943FD0
			internal IEnumerable<Button> IterateButtons(); // 0x0000000181943FD0-0x0000000181944040
			public override object DeepClone(); // 0x00000001819424C0-0x0000000181942530
			internal override void CopyVars(Rewired.Data.Mapping.HardwareJoystickMap.Platform destination); // 0x0000000181942400-0x00000001819424C0
		}
	
		[Serializable]
		[CustomClassObfuscation] // 0x0000000180207920-0x0000000180207950
		public sealed class Platform_SDL2 : Platform_SDL2_Base // TypeDefIndex: 6374
		{
			// Fields
			public Platform_SDL2_Base[] variants; // 0x28
	
			// Properties
			internal override IList<Rewired.Data.Mapping.HardwareJoystickMap.Platform> variants_base { get; } // 0x00000001803745B0-0x00000001803745C0 
	
			// Constructors
			public Platform_SDL2(); // 0x00000001803F46D0-0x00000001803F46E0
	
			// Methods
			internal override bool Matches(BridgedControllerHWInfo BridgedControllerHWInfo, bool strictMatch, out int variantIndex, out Rewired.Data.Mapping.HardwareJoystickMap.Platform platformMap); // 0x00000001819441F0-0x00000001819443E0
			public override object DeepClone(); // 0x0000000181944180-0x00000001819441F0
			internal override void CopyVars(Rewired.Data.Mapping.HardwareJoystickMap.Platform destination); // 0x0000000181944040-0x0000000181944180
		}
	
		[Serializable]
		[CustomClassObfuscation] // 0x0000000180207920-0x0000000180207950
		public class Platform_Steam_Base : Rewired.Data.Mapping.HardwareJoystickMap.Platform // TypeDefIndex: 6375
		{
			// Fields
			public MatchingCriteria matchingCriteria; // 0x18
			public Elements elements; // 0x20
	
			// Properties
			public override int assignedButtonCount { get; } // 0x00000001805F64C0-0x00000001805F64E0 
			public override int assignedAxisCount { get; } // 0x00000001805F64A0-0x00000001805F64C0 
			internal override InputPlatform platform { get; } // 0x000000018144A020-0x000000018144A030 
			internal override bool hasData { get; } // 0x00000001805F64F0-0x00000001805F6560 
			internal override bool disabled { get; } // 0x00000001805F64E0-0x00000001805F64F0 
			internal override bool isAllowed { get; } // 0x00000001805F6560-0x00000001805F65A0 
			internal override Elements_Base elements_base { get; } // 0x0000000180374AF0-0x0000000180374B00 
			internal override IList<Rewired.Data.Mapping.HardwareJoystickMap.Platform> variants_base { get; } // 0x000000018037DDC0-0x000000018037DDD0 
	
			// Nested types
			[Serializable]
			[CustomClassObfuscation] // 0x0000000180207920-0x0000000180207950
			public sealed class MatchingCriteria : MatchingCriteria_Base // TypeDefIndex: 6376
			{
				// Properties
				internal override bool hasData { get; } // 0x0000000180380B60-0x0000000180380B70 
				internal override bool isAllowed { get; } // 0x00000001805F43A0-0x00000001805F43C0 
				internal override int alternateElementCount { get; } // 0x000000018037DDC0-0x000000018037DDD0 
	
				// Constructors
				public MatchingCriteria(); // 0x00000001803F46D0-0x00000001803F46E0
	
				// Methods
				internal override bool Matches(BridgedControllerHWInfo bridgedControllerHWInfo, bool strictMatch); // 0x000000018193A780-0x000000018193A830
				internal override ElementCount_Base GetAlternateElementCount(int index); // 0x000000018037DDC0-0x000000018037DDD0
				internal override bool ElementCountsMatch(BridgedControllerHWInfo bridgedControllerHWInfo, out bool alternateMatched); // 0x00000001805F3C50-0x00000001805F3C60
				public override object DeepClone(); // 0x0000000181939A70-0x0000000181939AE0
				internal override void CopyVars(MatchingCriteria_Base destination); // 0x00000001819392B0-0x0000000181939300
			}
	
			[Serializable]
			[CustomClassObfuscation] // 0x0000000180207920-0x0000000180207950
			public sealed class Elements : Elements_Base // TypeDefIndex: 6377
			{
				// Properties
				public override int buttonCount { get; } // 0x000000018037DDC0-0x000000018037DDD0 
				public override int axisCount { get; } // 0x000000018037DDC0-0x000000018037DDD0 
	
				// Constructors
				public Elements(); // 0x00000001803F46D0-0x00000001803F46E0
	
				// Methods
				public override object DeepClone(); // 0x0000000181935EB0-0x0000000181935F20
				internal override void CopyVars(Elements_Base destination); // 0x0000000181935B00-0x0000000181935B50
				internal override ControllerElementType GetEffectiveElementIdentifierType(ControllerElementIdentifier elementIdentifier); // 0x0000000181937A90-0x0000000181937AB0
				internal override bool GetEffectiveAxisRange(ControllerElementIdentifier elementIdentifier, out AxisRange axisRange); // 0x00000001819364D0-0x00000001819364E0
			}
	
			// Constructors
			public Platform_Steam_Base(); // 0x00000001803F46D0-0x00000001803F46E0
	
			// Methods
			internal override bool Matches(BridgedControllerHWInfo BridgedControllerHWInfo, bool strictMatch, out int variantIndex, out Rewired.Data.Mapping.HardwareJoystickMap.Platform platformMap); // 0x0000000181946B30-0x0000000181946BB0
			internal override string[] GetAxisNames(ControllerElementIdentifier[] identifiers); // 0x0000000181946A10-0x0000000181946A50
			internal override string[] GetEffectiveButtonNames(ControllerElementIdentifier[] identifiers); // 0x0000000181946A90-0x0000000181946AD0
			internal override bool IsElementIdentifierMapped(int elementIdentifierId); // 0x0000000180380950-0x0000000180380960
			internal override void GetGameElementIdentifierIdMappings(out int[] buttons, out int[] axes); // 0x0000000181946AD0-0x0000000181946B30
			internal override AxisCalibrationData[] GetAxisCalibrationData(); // 0x0000000181946970-0x00000001819469B0
			internal override void GetAxisData(out AxisRange[] axisRanges, out HardwareAxisInfo[] axisInfos); // 0x00000001819469B0-0x0000000181946A10
			internal override void GetButtonData(out HardwareButtonInfo[] buttonInfos); // 0x0000000181946A50-0x0000000181946A90
			internal override ControllerElementType GetEffectiveElementIdentifierType(ControllerElementIdentifier elementIdentifier); // 0x00000001805F5B50-0x00000001805F5B70
			internal override bool GetEffectiveAxisRange(ControllerElementIdentifier elementIdentifier, out AxisRange axisRange); // 0x00000001805F5800-0x00000001805F5830
			public override object DeepClone(); // 0x0000000181946900-0x0000000181946970
			internal override void CopyVars(Rewired.Data.Mapping.HardwareJoystickMap.Platform destination); // 0x00000001819467E0-0x0000000181946900
		}
	
		[Serializable]
		[CustomClassObfuscation] // 0x0000000180207920-0x0000000180207950
		public sealed class Platform_Steam : Platform_Steam_Base // TypeDefIndex: 6378
		{
			// Fields
			public Platform_Steam_Base[] variants; // 0x28
	
			// Properties
			internal override IList<Rewired.Data.Mapping.HardwareJoystickMap.Platform> variants_base { get; } // 0x00000001803745B0-0x00000001803745C0 
	
			// Constructors
			public Platform_Steam(); // 0x00000001803F46D0-0x00000001803F46E0
	
			// Methods
			internal override bool Matches(BridgedControllerHWInfo BridgedControllerHWInfo, bool strictMatch, out int variantIndex, out Rewired.Data.Mapping.HardwareJoystickMap.Platform platformMap); // 0x0000000181946DD0-0x0000000181946F80
			public override object DeepClone(); // 0x0000000181946D50-0x0000000181946DD0
			internal override void CopyVars(Rewired.Data.Mapping.HardwareJoystickMap.Platform destination); // 0x0000000181946BB0-0x0000000181946D50
		}
	
		[Serializable]
		[CustomClassObfuscation] // 0x0000000180207920-0x0000000180207950
		public class Platform_WebGL_Base : Platform_Custom // TypeDefIndex: 6379
		{
			// Fields
			public MatchingCriteria matchingCriteria; // 0x18
			public Elements elements; // 0x20
			private Axis[] _axesOrigGame; // 0x28
			private Button[] _buttonsOrigGame; // 0x30
	
			// Properties
			public override int assignedButtonCount { get; } // 0x00000001805F64C0-0x00000001805F64E0 
			public override int assignedAxisCount { get; } // 0x00000001805F64A0-0x00000001805F64C0 
			internal override InputPlatform platform { get; } // 0x000000018144D490-0x000000018144D4A0 
			internal override Axis[] Axes { get; } // 0x0000000181948D40-0x0000000181948F30 
			internal override Button[] Buttons { get; } // 0x0000000181948F30-0x0000000181949120 
			internal Axis[] Axes_orig { get; } // 0x00000001805F6480-0x00000001805F6490 
			internal Button[] Buttons_orig { get; } // 0x00000001805F6490-0x00000001805F64A0 
			internal override bool hasData { get; } // 0x00000001818B1970-0x00000001818B19E0 
			internal override bool disabled { get; } // 0x00000001805F64E0-0x00000001805F64F0 
			internal override bool isAllowed { get; } // 0x0000000181949120-0x0000000181949170 
			internal override Elements_Base elements_base { get; } // 0x0000000180374AF0-0x0000000180374B00 
			internal override IList<Rewired.Data.Mapping.HardwareJoystickMap.Platform> variants_base { get; } // 0x000000018037DDC0-0x000000018037DDD0 
	
			// Nested types
			[Serializable]
			[CustomClassObfuscation] // 0x0000000180207920-0x0000000180207950
			public sealed class MatchingCriteria : Platform_Custom.MatchingCriteria // TypeDefIndex: 6380
			{
				// Fields
				public bool productName_useRegex; // 0x30
				public string[] productName; // 0x38
				public string[] productGUID; // 0x40
				public int[] mapping; // 0x48
				public ElementCount_Base[] elementCount; // 0x50
				public ClientInfo[] clientInfo; // 0x58
	
				// Properties
				internal override bool hasData { get; } // 0x000000018193B4C0-0x000000018193B580 
				internal override bool isAllowed { get; } // 0x00000001805F43C0-0x00000001805F43F0 
	
				// Nested types
				[Serializable]
				public sealed class ClientInfo : IDeepCloneable // TypeDefIndex: 6381
				{
					// Fields
					public int browser; // 0x10
					public string browserVersionMin; // 0x18
					public string browserVersionMax; // 0x20
					public int os; // 0x28
					public string osVersionMin; // 0x30
					public string osVersionMax; // 0x38
	
					// Constructors
					public ClientInfo(); // 0x0000000180373240-0x0000000180373250
	
					// Methods
					public object DeepClone(); // 0x00000001805ED060-0x00000001805ED120
				}
	
				// Constructors
				public MatchingCriteria(); // 0x00000001803FB1F0-0x00000001803FB200
	
				// Methods
				internal override bool Matches(BridgedControllerHWInfo bridgedControllerHWInfo, bool strictMatch); // 0x0000000181939D00-0x000000018193A6D0
				private static bool CheckBrowserVersion(int browser, string versionMin, string versionMax, string[] currentVersion); // 0x00000001819387C0-0x0000000181938D40
				private static bool CheckOSVersion(string versionMin, string versionMax, string[] currentVersion); // 0x0000000181938D40-0x00000001819392B0
				public override object DeepClone(); // 0x0000000181939A00-0x0000000181939A70
				internal override void CopyVars(MatchingCriteria_Base destination); // 0x0000000181939300-0x0000000181939480
			}
	
			[Serializable]
			[CustomClassObfuscation] // 0x0000000180207920-0x0000000180207950
			public sealed class Elements : Platform_Custom.Elements // TypeDefIndex: 6382
			{
				// Fields
				public Axis[] axes; // 0x10
				public Button[] buttons; // 0x18
	
				// Properties
				public override int buttonCount { get; } // 0x00000001805EF540-0x00000001805EF550 
				public override int axisCount { get; } // 0x00000001805EF530-0x00000001805EF540 
	
				// Constructors
				public Elements(); // 0x00000001803FB1F0-0x00000001803FB200
	
				// Methods
				internal override ControllerElementType GetEffectiveElementIdentifierType(ControllerElementIdentifier elementIdentifier); // 0x0000000181937730-0x00000001819378E0
				internal override bool GetEffectiveAxisRange(ControllerElementIdentifier elementIdentifier, out AxisRange axisRange); // 0x0000000181936780-0x0000000181936A00
				public override object DeepClone(); // 0x0000000181935F20-0x0000000181935F90
				internal override void CopyVars(Elements_Base destination); // 0x0000000181935C80-0x0000000181935D40
			}
	
			[Serializable]
			[CustomClassObfuscation] // 0x0000000180207920-0x0000000180207950
			public sealed class Button : Platform_Custom.Button // TypeDefIndex: 6383
			{
				// Constructors
				public Button(); // 0x00000001803F46D0-0x00000001803F46E0
	
				// Methods
				public override object DeepClone(); // 0x0000000181934F90-0x0000000181935000
				internal override void CopyVars(Platform_Custom.Element destination); // 0x0000000181934DC0-0x0000000181934E10
			}
	
			[Serializable]
			[CustomClassObfuscation] // 0x0000000180207920-0x0000000180207950
			public sealed class Axis : Platform_Custom.Axis // TypeDefIndex: 6384
			{
				// Constructors
				public Axis(); // 0x00000001803F46D0-0x00000001803F46E0
	
				// Methods
				public override object DeepClone(); // 0x0000000181933FE0-0x0000000181934050
				internal override void CopyVars(Platform_Custom.Element destination); // 0x0000000181933C20-0x0000000181933C70
			}
	
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private sealed class tmBcGMhQxnjkGDfnIBFgECdDEcTp : IEnumerable<Axis>, IEnumerator<Axis> // TypeDefIndex: 6385
			{
				// Fields
				private Platform_Custom.Axis aSrFEaALHwhGTdXfCdeUqgbwaZGO; // 0x10
				private int eLrUhJFgzEZElCzdKvcrgOLXLvL; // 0x18
				private int RQaeFqcJnaOYpZSBxtfUkVOjfOo; // 0x1C
				public Platform_WebGL_Base gKPmvKLRxdGbmXiMfUeDjGbezUo; // 0x20
				public int RouWpZWgcGMaNYbSoGLLgSFGnac; // 0x28
	
				// Properties
				Platform_Custom.Axis lmiaTpCsaXfKxySEjXIZoypgnjMr { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372440-0x0000000180372450 
				object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372440-0x0000000180372450 
	
				// Constructors
				[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
				public tmBcGMhQxnjkGDfnIBFgECdDEcTp(int <>1__state); // 0x00000001805EDEC0-0x00000001805EDF10
	
				// Methods
				[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
				IEnumerator<Platform_Custom.Axis> System.Collections.Generic.IEnumerable<Rewired.Data.Mapping.HardwareJoystickMap.Platform_Custom.Axis>.GetEnumerator(); // 0x000000018061A510-0x000000018061A610
				[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
				IEnumerator IEnumerable.GetEnumerator(); // 0x000000018061A510-0x000000018061A610
				private bool MoveNext(); // 0x000000018061A380-0x000000018061A510
				[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
				void IEnumerator.Reset(); // 0x000000018061A610-0x000000018061A660
				void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			}
	
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private sealed class IwhbaTGEaCEzBRlaCpARhqtjKmQC : IEnumerable<Button>, IEnumerator<Button> // TypeDefIndex: 6386
			{
				// Fields
				private Platform_Custom.Button aSrFEaALHwhGTdXfCdeUqgbwaZGO; // 0x10
				private int eLrUhJFgzEZElCzdKvcrgOLXLvL; // 0x18
				private int RQaeFqcJnaOYpZSBxtfUkVOjfOo; // 0x1C
				public Platform_WebGL_Base gKPmvKLRxdGbmXiMfUeDjGbezUo; // 0x20
				public int hdYsEDGHUoTnnwMkZZXRWpgIwxb; // 0x28
	
				// Properties
				Platform_Custom.Button PlYXfEMpMbXcHXTJgpApbDPxYUh { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372440-0x0000000180372450 
				object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372440-0x0000000180372450 
	
				// Constructors
				[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
				public IwhbaTGEaCEzBRlaCpARhqtjKmQC(int <>1__state); // 0x00000001819384E0-0x0000000181938550
	
				// Methods
				[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
				IEnumerator<Platform_Custom.Button> System.Collections.Generic.IEnumerable<Rewired.Data.Mapping.HardwareJoystickMap.Platform_Custom.Button>.GetEnumerator(); // 0x0000000181938360-0x0000000181938490
				[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
				IEnumerator IEnumerable.GetEnumerator(); // 0x0000000181938360-0x0000000181938490
				private bool MoveNext(); // 0x00000001819381E0-0x0000000181938360
				[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
				void IEnumerator.Reset(); // 0x0000000181938490-0x00000001819384E0
				void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			}
	
			// Constructors
			public Platform_WebGL_Base(); // 0x00000001803FB1F0-0x00000001803FB200
	
			// Methods
			internal override bool Matches(BridgedControllerHWInfo BridgedControllerHWInfo, bool strictMatch, out int variantIndex, out Rewired.Data.Mapping.HardwareJoystickMap.Platform platformMap); // 0x0000000181948C80-0x0000000181948D40
			internal override IEnumerable<Axis> IterateAxes(); // 0x0000000181948B50-0x0000000181948BE0
			internal override IEnumerable<Button> IterateButtons(); // 0x0000000181948BE0-0x0000000181948C80
			internal override string[] GetAxisNames(ControllerElementIdentifier[] identifiers); // 0x0000000181947B90-0x0000000181947E50
			internal override string[] GetEffectiveButtonNames(ControllerElementIdentifier[] identifiers); // 0x0000000181948080-0x0000000181948360
			internal override bool IsElementIdentifierMapped(int elementIdentifierId); // 0x0000000181948820-0x0000000181948B50
			internal override void GetGameElementIdentifierIdMappings(out int[] buttons, out int[] axes); // 0x0000000181948360-0x0000000181948820
			internal override AxisCalibrationData[] GetAxisCalibrationData(); // 0x00000001819470F0-0x00000001819476F0
			internal override void GetAxisData(out AxisRange[] axisRanges, out HardwareAxisInfo[] axisInfos); // 0x00000001819476F0-0x0000000181947B90
			internal override void GetButtonData(out HardwareButtonInfo[] buttonInfos); // 0x0000000181947E50-0x0000000181948080
			internal override ControllerElementType GetEffectiveElementIdentifierType(ControllerElementIdentifier elementIdentifier); // 0x00000001805F5B50-0x00000001805F5B70
			internal override bool GetEffectiveAxisRange(ControllerElementIdentifier elementIdentifier, out AxisRange axisRange); // 0x00000001805F5800-0x00000001805F5830
			public override object DeepClone(); // 0x0000000181947060-0x00000001819470F0
			internal override void CopyVars(Rewired.Data.Mapping.HardwareJoystickMap.Platform destination); // 0x0000000181946F80-0x0000000181947060
		}
	
		[Serializable]
		[CustomClassObfuscation] // 0x0000000180207920-0x0000000180207950
		public sealed class Platform_WebGL : Platform_WebGL_Base // TypeDefIndex: 6387
		{
			// Fields
			public Platform_WebGL_Base[] variants; // 0x38
	
			// Properties
			internal override IList<Rewired.Data.Mapping.HardwareJoystickMap.Platform> variants_base { get; } // 0x00000001803743D0-0x00000001803743E0 
	
			// Constructors
			public Platform_WebGL(); // 0x00000001803FB1F0-0x00000001803FB200
	
			// Methods
			internal override bool Matches(BridgedControllerHWInfo BridgedControllerHWInfo, bool strictMatch, out int variantIndex, out Rewired.Data.Mapping.HardwareJoystickMap.Platform platformMap); // 0x0000000181949340-0x0000000181949550
			public override object DeepClone(); // 0x00000001819492D0-0x0000000181949340
			internal override void CopyVars(Rewired.Data.Mapping.HardwareJoystickMap.Platform destination); // 0x0000000181949170-0x00000001819492D0
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class dGRMznpLGnCWObVzUPXeWKFSyQb : IEnumerable<Guid>, IEnumerator<Guid> // TypeDefIndex: 6388
		{
			// Fields
			private Guid aSrFEaALHwhGTdXfCdeUqgbwaZGO; // 0x10
			private int eLrUhJFgzEZElCzdKvcrgOLXLvL; // 0x20
			private int RQaeFqcJnaOYpZSBxtfUkVOjfOo; // 0x24
			public HardwareJoystickMap gKPmvKLRxdGbmXiMfUeDjGbezUo; // 0x28
			public int ZKnOmfdBGxPCzuiOaEmmaNwByyN; // 0x30
	
			// Properties
			Guid wPhFNVGruwsEitgnJFTcdPyIZsIV { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180619460-0x0000000180619470 
			object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x00000001806194C0-0x0000000180619510 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public dGRMznpLGnCWObVzUPXeWKFSyQb(int <>1__state); // 0x0000000180619510-0x0000000180619560
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			IEnumerator<Guid> IEnumerable<Guid>.GetEnumerator(); // 0x0000000180619360-0x0000000180619460
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			IEnumerator IEnumerable.GetEnumerator(); // 0x0000000180619360-0x0000000180619460
			private bool MoveNext(); // 0x0000000180619190-0x0000000180619360
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000180619470-0x00000001806194C0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class ySbjvvDALvBUwVngEYkutLawAYM : IEnumerable<ControllerElementIdentifier>, IEnumerator<ControllerElementIdentifier> // TypeDefIndex: 6389
		{
			// Fields
			private ControllerElementIdentifier aSrFEaALHwhGTdXfCdeUqgbwaZGO; // 0x10
			private int eLrUhJFgzEZElCzdKvcrgOLXLvL; // 0x18
			private int RQaeFqcJnaOYpZSBxtfUkVOjfOo; // 0x1C
			public HardwareJoystickMap gKPmvKLRxdGbmXiMfUeDjGbezUo; // 0x20
			public int PjYtuicjXGalARRYfcvVGxZVBdI; // 0x28
	
			// Properties
			ControllerElementIdentifier QmgYVYcGXUPSkQvXLtYdUlBXEfB { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372440-0x0000000180372450 
			object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372440-0x0000000180372450 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public ySbjvvDALvBUwVngEYkutLawAYM(int <>1__state); // 0x00000001805EDEC0-0x00000001805EDF10
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			IEnumerator<ControllerElementIdentifier> IEnumerable<ControllerElementIdentifier>.GetEnumerator(); // 0x000000018061AA90-0x000000018061ABA0
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			IEnumerator IEnumerable.GetEnumerator(); // 0x000000018061AA90-0x000000018061ABA0
			private bool MoveNext(); // 0x000000018061A950-0x000000018061AA90
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x000000018061ABA0-0x000000018061ABF0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class eFSWDCwnTJdZvbPDKOvWTjjZkVJd : IEnumerable<JoystickType>, IEnumerator<JoystickType> // TypeDefIndex: 6390
		{
			// Fields
			private JoystickType aSrFEaALHwhGTdXfCdeUqgbwaZGO; // 0x10
			private int eLrUhJFgzEZElCzdKvcrgOLXLvL; // 0x14
			private int RQaeFqcJnaOYpZSBxtfUkVOjfOo; // 0x18
			public HardwareJoystickMap gKPmvKLRxdGbmXiMfUeDjGbezUo; // 0x20
			public int IiqAOvtVNlCuKCmYJrKqAvSPedRP; // 0x28
	
			// Properties
			JoystickType hlflTucGxtvsPFCUNWteonLmNrf { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180387590-0x0000000180387930 
			object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180619820-0x0000000180619870 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public eFSWDCwnTJdZvbPDKOvWTjjZkVJd(int <>1__state); // 0x0000000180619870-0x00000001806198C0
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			IEnumerator<JoystickType> IEnumerable<JoystickType>.GetEnumerator(); // 0x00000001806196A0-0x00000001806197D0
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			IEnumerator IEnumerable.GetEnumerator(); // 0x00000001806196A0-0x00000001806197D0
			private bool MoveNext(); // 0x0000000180619560-0x00000001806196A0
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x00000001806197D0-0x0000000180619820
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class iWxdQKamXdhylHenKJlqqUxaoEG : IEnumerable<IControllerElementIdentifierCommon_Internal>, IEnumerator<IControllerElementIdentifierCommon_Internal> // TypeDefIndex: 6391
		{
			// Fields
			private IControllerElementIdentifierCommon_Internal aSrFEaALHwhGTdXfCdeUqgbwaZGO; // 0x10
			private int eLrUhJFgzEZElCzdKvcrgOLXLvL; // 0x18
			private int RQaeFqcJnaOYpZSBxtfUkVOjfOo; // 0x1C
			public HardwareJoystickMap gKPmvKLRxdGbmXiMfUeDjGbezUo; // 0x20
			public int CVuVYRUyKDQHENvKvQkTKDOtumC; // 0x28
	
			// Properties
			IControllerElementIdentifierCommon_Internal kPWOkKKCGAiizbmYmSqjRLfSZWGa { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372440-0x0000000180372450 
			object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372440-0x0000000180372450 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public iWxdQKamXdhylHenKJlqqUxaoEG(int <>1__state); // 0x00000001805EDEC0-0x00000001805EDF10
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			IEnumerator<IControllerElementIdentifierCommon_Internal> IEnumerable<IControllerElementIdentifierCommon_Internal>.GetEnumerator(); // 0x0000000180619A10-0x0000000180619B20
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			IEnumerator IEnumerable.GetEnumerator(); // 0x0000000180619A10-0x0000000180619B20
			private bool MoveNext(); // 0x00000001806198C0-0x0000000180619A10
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000180619B20-0x0000000180619B70
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		}
	
		// Constructors
		public HardwareJoystickMap(); // 0x0000000180D8C380-0x0000000180D8C990
		public HardwareJoystickMap(HardwareJoystickMap source); // 0x0000000180D8C990-0x0000000180D8DE40
	
		// Methods
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		public string[] GetElementIdentifierNames(); // 0x0000000180D8AEE0-0x0000000180D8B050
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		public int[] GetElementIdentifierIds(); // 0x0000000180D8A920-0x0000000180D8AAB0
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		public ControllerElementIdentifier GetElementIdentifier(int id); // 0x0000000180D8B050-0x0000000180D8B0D0
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		public bool ContainsElementIdentifier(int id); // 0x0000000180D88FB0-0x0000000180D88FD0
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		public int GetElementIdentifierInfo(ControllerElementType type, out string[] names, out int[] ids); // 0x0000000180D8AAB0-0x0000000180D8AEE0
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		public int GetMappableElementIdentifierInfo(out string[] names, out int[] ids); // 0x0000000180D8B170-0x0000000180D8B590
		internal HardwareJoystickMap Clone(); // 0x0000000180D88F50-0x0000000180D88FB0
		internal int IndexOfElementIdentifier(int id); // 0x0000000180D8BAB0-0x0000000180D8BB30
		internal ControllerElementType GetEffectiveElementIdentifierType(HardwareControllerMapIdentifier hardwareMapIdentifier, int elementIdentifierId, bool isDefaultMap); // 0x0000000180D8A880-0x0000000180D8A920
		internal bool GetEffectiveAxisRange(HardwareControllerMapIdentifier hardwareMapIdentifier, int elementIdentifierId, bool isDefaultMap, out AxisRange axisRange); // 0x0000000180D8A7E0-0x0000000180D8A880
		internal void GetElementIdentifiersForControllerElements(HardwareControllerMapIdentifier hardwareMapIdentifier, bool isDefaultMap, out int[] buttons, out int[] axes); // 0x0000000180D8B0D0-0x0000000180D8B170
		internal static bool Matches(Platform platform, BridgedControllerHWInfo bridgedControllerHWInfo, bool strictMatch, out int variantIndex, out Platform platformMap); // 0x0000000180D8C2B0-0x0000000180D8C300
		internal bool Matches(BridgedControllerHWInfo bridgedControllerHWInfo, bool strictMatch, bool isDefaultMap, out InputPlatform actualInputPlatform, out int variantIndex, out Platform platformMap); // 0x0000000180D8BB30-0x0000000180D8C2B0
		internal HardwareJoystickMap_InputManager GetDefaultHardwareJoystickMap_InputManager(InputSource inputSource); // 0x0000000180D8A2B0-0x0000000180D8A7E0
		internal string[] GetTemplateGuidsOrig(); // 0x00000001803743D0-0x00000001803743E0
		IControllerElementIdentifierCommon_Internal IHardwareControllerMap_Internal.GetElementIdentifier(int id); // 0x0000000180D8C300-0x0000000180D8C310
		private Platform_Fallback_Base FindFallbackMatch(BridgedControllerHWInfo bridgedControllerHWInfo, bool strictMatch, bool isDefaultMap, out InputPlatform actualInputPlatform, out int variantIndex); // 0x0000000180D89820-0x0000000180D89E90
		private Platform_Fallback_Base FindFallbackMap(InputSource inputSource, bool isDefaultMap, out InputPlatform actualInputPlatform, out int variantIndex); // 0x0000000180D88FD0-0x0000000180D89820
		private Platform_SDL2_Base FindSDL2Match(BridgedControllerHWInfo bridgedControllerHWInfo, bool strictMatch, bool isDefaultMap, out InputPlatform actualInputPlatform, out int variantIndex); // 0x0000000180D8A0B0-0x0000000180D8A2B0
		private Platform_SDL2_Base FindSDL2Map(InputSource inputSource, bool isDefaultMap, out InputPlatform actualInputPlatform, out int variantIndex); // 0x0000000180D89E90-0x0000000180D8A0B0
		private T TryGetFirstValidMap<T>(T mainMap, bool isDefaultMap, ref InputPlatform actualInputPlatform, out int variantIndex)
			where T : Platform;
		private T TryGetFirstMatchingMap<T>(T mainMap, BridgedControllerHWInfo bridgedControllerHWInfo, bool strictMatch, bool isDefaultMap, ref InputPlatform actualInputPlatform, out int variantIndex)
			where T : Platform;
		private T GetUniversalDefaultMap<T>(out InputPlatform actualInputPlatform, out int variantIndex)
			where T : Platform;
		private T GetUniversalDefaultMapRoot<T>(Type type, out InputPlatform actualInputPlatform)
			where T : Platform;
		private Platform GetSpecificPlatformMap(HardwareControllerMapIdentifier hardwareMapIdentifier); // 0x0000000180D8B590-0x0000000180D8B680
		private Platform GetSpecificPlatformRoot(InputPlatform exactInputPlatform); // 0x0000000180D8B680-0x0000000180D8BAB0
	}
}
