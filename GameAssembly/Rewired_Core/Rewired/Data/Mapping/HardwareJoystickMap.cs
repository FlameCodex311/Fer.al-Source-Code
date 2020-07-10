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

// Image 50: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5712-6954

namespace Rewired.Data.Mapping
{
	[CustomClassObfuscation] // 0x00000001800D0530-0x00000001800D0560
	public sealed class HardwareJoystickMap : ScriptableObject, IHardwareControllerMap, IHardwareControllerMap_Internal // TypeDefIndex: 6058
	{
		// Fields
		[CustomObfuscation] // 0x00000001800C3DD0-0x00000001800C3E10
		[SerializeField] // 0x00000001800C3DD0-0x00000001800C3E10
		private string controllerName; // 0x18
		[CustomObfuscation] // 0x00000001800C3DD0-0x00000001800C3E10
		[SerializeField] // 0x00000001800C3DD0-0x00000001800C3E10
		private string editorControllerName; // 0x20
		[CustomObfuscation] // 0x00000001800C3DD0-0x00000001800C3E10
		[SerializeField] // 0x00000001800C3DD0-0x00000001800C3E10
		private string description; // 0x28
		[CustomObfuscation] // 0x00000001800C5270-0x00000001800C52B0
		[SerializeField] // 0x00000001800C5270-0x00000001800C52B0
		private string controllerGuid; // 0x30
		[CustomObfuscation] // 0x00000001800C3DD0-0x00000001800C3E10
		[SerializeField] // 0x00000001800C3DD0-0x00000001800C3E10
		private string[] templateGuids; // 0x38
		[CustomObfuscation] // 0x00000001800C3DD0-0x00000001800C3E10
		[SerializeField] // 0x00000001800C3DD0-0x00000001800C3E10
		private bool hideInLists; // 0x40
		[CustomObfuscation] // 0x00000001800C3DD0-0x00000001800C3E10
		[SerializeField] // 0x00000001800C3DD0-0x00000001800C3E10
		private JoystickType[] joystickTypes; // 0x48
		[CustomObfuscation] // 0x00000001800C3DD0-0x00000001800C3E10
		[SerializeField] // 0x00000001800C3DD0-0x00000001800C3E10
		private ControllerElementIdentifier[] elementIdentifiers; // 0x50
		[CustomObfuscation] // 0x00000001800C5270-0x00000001800C52B0
		[SerializeField] // 0x00000001800C5270-0x00000001800C52B0
		private CompoundElement[] compoundElements; // 0x58
		[CustomObfuscation] // 0x00000001800C5270-0x00000001800C52B0
		[SerializeField] // 0x00000001800C5270-0x00000001800C52B0
		private Platform_DirectInput directInput; // 0x60
		[CustomObfuscation] // 0x00000001800C3DD0-0x00000001800C3E10
		[SerializeField] // 0x00000001800C3DD0-0x00000001800C3E10
		private Platform_RawInput rawInput; // 0x68
		[CustomObfuscation] // 0x00000001800C5270-0x00000001800C52B0
		[SerializeField] // 0x00000001800C5270-0x00000001800C52B0
		private Platform_XInput xInput; // 0x70
		[CustomObfuscation] // 0x00000001800C3DD0-0x00000001800C3E10
		[SerializeField] // 0x00000001800C3DD0-0x00000001800C3E10
		private Platform_OSX osx; // 0x78
		[CustomObfuscation] // 0x00000001800C5270-0x00000001800C52B0
		[SerializeField] // 0x00000001800C5270-0x00000001800C52B0
		private Platform_Linux linux; // 0x80
		[CustomObfuscation] // 0x00000001800C5270-0x00000001800C52B0
		[SerializeField] // 0x00000001800C5270-0x00000001800C52B0
		private Platform_WindowsUWP windowsUWP; // 0x88
		[CustomObfuscation] // 0x00000001800C3DD0-0x00000001800C3E10
		[SerializeField] // 0x00000001800C3DD0-0x00000001800C3E10
		private Platform_Fallback fallback_Windows; // 0x90
		[CustomObfuscation] // 0x00000001800C3DD0-0x00000001800C3E10
		[SerializeField] // 0x00000001800C3DD0-0x00000001800C3E10
		private Platform_Fallback fallback_WindowsUWP; // 0x98
		[CustomObfuscation] // 0x00000001800C5270-0x00000001800C52B0
		[SerializeField] // 0x00000001800C5270-0x00000001800C52B0
		private Platform_Fallback fallback_OSX; // 0xA0
		[CustomObfuscation] // 0x00000001800C5270-0x00000001800C52B0
		[SerializeField] // 0x00000001800C5270-0x00000001800C52B0
		private Platform_Fallback fallback_Linux; // 0xA8
		[CustomObfuscation] // 0x00000001800C3DD0-0x00000001800C3E10
		[SerializeField] // 0x00000001800C3DD0-0x00000001800C3E10
		private Platform_Fallback fallback_Linux_PreConfigured; // 0xB0
		[CustomObfuscation] // 0x00000001800C5270-0x00000001800C52B0
		[SerializeField] // 0x00000001800C5270-0x00000001800C52B0
		private Platform_Fallback fallback_Android; // 0xB8
		[CustomObfuscation] // 0x00000001800C5270-0x00000001800C52B0
		[SerializeField] // 0x00000001800C5270-0x00000001800C52B0
		private Platform_Fallback fallback_iOS; // 0xC0
		[CustomObfuscation] // 0x00000001800C5270-0x00000001800C52B0
		[SerializeField] // 0x00000001800C5270-0x00000001800C52B0
		private Platform_Fallback fallback_Blackberry; // 0xC8
		[CustomObfuscation] // 0x00000001800C5270-0x00000001800C52B0
		[SerializeField] // 0x00000001800C5270-0x00000001800C52B0
		private Platform_Fallback fallback_WindowsPhone8; // 0xD0
		[CustomObfuscation] // 0x00000001800C5270-0x00000001800C52B0
		[SerializeField] // 0x00000001800C5270-0x00000001800C52B0
		private Platform_Fallback fallback_XBox360; // 0xD8
		[CustomObfuscation] // 0x00000001800C3DD0-0x00000001800C3E10
		[SerializeField] // 0x00000001800C3DD0-0x00000001800C3E10
		private Platform_Fallback fallback_XBoxOne; // 0xE0
		[CustomObfuscation] // 0x00000001800C3DD0-0x00000001800C3E10
		[SerializeField] // 0x00000001800C3DD0-0x00000001800C3E10
		private Platform_Fallback fallback_PS3; // 0xE8
		[CustomObfuscation] // 0x00000001800C5270-0x00000001800C52B0
		[SerializeField] // 0x00000001800C5270-0x00000001800C52B0
		private Platform_Fallback fallback_PS4; // 0xF0
		[CustomObfuscation] // 0x00000001800C5270-0x00000001800C52B0
		[SerializeField] // 0x00000001800C5270-0x00000001800C52B0
		private Platform_Fallback fallback_PSM; // 0xF8
		[CustomObfuscation] // 0x00000001800C5270-0x00000001800C52B0
		[SerializeField] // 0x00000001800C5270-0x00000001800C52B0
		private Platform_Fallback fallback_PSVita; // 0x100
		[CustomObfuscation] // 0x00000001800C3DD0-0x00000001800C3E10
		[SerializeField] // 0x00000001800C3DD0-0x00000001800C3E10
		private Platform_Fallback fallback_Wii; // 0x108
		[CustomObfuscation] // 0x00000001800C5270-0x00000001800C52B0
		[SerializeField] // 0x00000001800C5270-0x00000001800C52B0
		private Platform_Fallback fallback_WiiU; // 0x110
		[CustomObfuscation] // 0x00000001800C5270-0x00000001800C52B0
		[SerializeField] // 0x00000001800C5270-0x00000001800C52B0
		private Platform_Fallback fallback_AmazonFireTV; // 0x118
		[CustomObfuscation] // 0x00000001800C5270-0x00000001800C52B0
		[SerializeField] // 0x00000001800C5270-0x00000001800C52B0
		private Platform_Fallback fallback_RazerForgeTV; // 0x120
		[CustomObfuscation] // 0x00000001800C3DD0-0x00000001800C3E10
		[SerializeField] // 0x00000001800C3DD0-0x00000001800C3E10
		private Platform_WebGL webGL; // 0x128
		[CustomObfuscation] // 0x00000001800C5270-0x00000001800C52B0
		[SerializeField] // 0x00000001800C5270-0x00000001800C52B0
		private Platform_Ouya ouya; // 0x130
		[CustomObfuscation] // 0x00000001800C3DD0-0x00000001800C3E10
		[SerializeField] // 0x00000001800C3DD0-0x00000001800C3E10
		private Platform_XboxOne xboxOne; // 0x138
		[CustomObfuscation] // 0x00000001800C5270-0x00000001800C52B0
		[SerializeField] // 0x00000001800C5270-0x00000001800C52B0
		private Platform_PS4 ps4; // 0x140
		[CustomObfuscation] // 0x00000001800C5270-0x00000001800C52B0
		[SerializeField] // 0x00000001800C5270-0x00000001800C52B0
		private Platform_NintendoSwitch nintendoSwitch; // 0x148
		[CustomObfuscation] // 0x00000001800C3DD0-0x00000001800C3E10
		[SerializeField] // 0x00000001800C3DD0-0x00000001800C3E10
		private Platform_Stadia stadia; // 0x150
		[CustomObfuscation] // 0x00000001800C3DD0-0x00000001800C3E10
		[SerializeField] // 0x00000001800C3DD0-0x00000001800C3E10
		private Platform_InternalDriver internalDriver; // 0x158
		[CustomObfuscation] // 0x00000001800C3DD0-0x00000001800C3E10
		[SerializeField] // 0x00000001800C3DD0-0x00000001800C3E10
		private Platform_SDL2 sdl2_Linux; // 0x160
		[CustomObfuscation] // 0x00000001800C3DD0-0x00000001800C3E10
		[SerializeField] // 0x00000001800C3DD0-0x00000001800C3E10
		private Platform_SDL2 sdl2_Windows; // 0x168
		[CustomObfuscation] // 0x00000001800C5270-0x00000001800C52B0
		[SerializeField] // 0x00000001800C5270-0x00000001800C52B0
		private Platform_SDL2 sdl2_OSX; // 0x170
		[CustomObfuscation] // 0x00000001800C5270-0x00000001800C52B0
		[SerializeField] // 0x00000001800C5270-0x00000001800C52B0
		private int elementIdentifierIdCounter; // 0x178
	
		// Properties
		public string ControllerName { get; } // 0x000000018038B150-0x000000018038B160 
		public string EditorControllerName { get; } // 0x000000018036AC70-0x000000018036AC80 
		public Guid Guid { get; } // 0x00000001805EEF00-0x00000001805EEF80 
		public IEnumerable<Guid> TemplateGuids { get; } // 0x00000001805EEFF0-0x00000001805EF060 
		public IEnumerable<ControllerElementIdentifier> ElementIdentifiers { get; } // 0x00000001805EEE90-0x00000001805EEF00 
		public int elementIdentifierCount { get; } // 0x00000001805EF060-0x00000001805EF070 
		public bool HideInLists { get; } // 0x0000000180478660-0x0000000180478670 
		internal IEnumerable<JoystickType> JoystickTypes { get; } // 0x00000001805EEF80-0x00000001805EEFF0 
		IEnumerable<IControllerElementIdentifierCommon_Internal> IHardwareControllerMap_Internal.ElementIdentifiers { get; } // 0x00000001805ED2E0-0x00000001805ED350 
	
		// Nested types
		[Serializable]
		[CustomClassObfuscation] // 0x00000001800D0530-0x00000001800D0560
		public abstract class Platform : IDeepCloneable // TypeDefIndex: 6059
		{
			// Fields
			public string description; // 0x10
	
			// Properties
			internal abstract InputPlatform platform { get; }
			public abstract int assignedButtonCount { get; }
			public abstract int assignedAxisCount { get; }
			public virtual string controllerNameOverride { get; } // 0x000000018035FCC0-0x000000018035FCD0 
			internal abstract Elements_Base elements_base { get; }
			internal virtual bool isAllowed { get; } // 0x00000001805F1160-0x00000001805F11F0 
			internal abstract bool hasData { get; }
			internal abstract bool disabled { get; }
			internal abstract IList<Platform> variants_base { get; }
			internal IEnumerable<Platform> Variants { get; } // 0x00000001805F10D0-0x00000001805F1140 
			internal bool hasVariants { get; } // 0x00000001805F1140-0x00000001805F1160 
			[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
			internal int variantCount { get; } // 0x00000001805F1830-0x00000001805F18B0 
			internal bool selfOrVariantHasData { get; } // 0x00000001805F11F0-0x00000001805F1410 
			internal bool selfOrVariantIsValid { get; } // 0x00000001805F1600-0x00000001805F1830 
			internal bool selfOrVariantIsAllowed { get; } // 0x00000001805F1410-0x00000001805F1600 
	
			// Nested types
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private sealed class GZAfzUfNaNaapIKPbDvSSTwYWnvI : IEnumerable<Platform>, IEnumerator<Platform> // TypeDefIndex: 6060
			{
				// Fields
				private Platform aSrFEaALHwhGTdXfCdeUqgbwaZGO; // 0x10
				private int eLrUhJFgzEZElCzdKvcrgOLXLvL; // 0x18
				private int RQaeFqcJnaOYpZSBxtfUkVOjfOo; // 0x1C
				public Platform gKPmvKLRxdGbmXiMfUeDjGbezUo; // 0x20
				public IList<Platform> yrgCBjhrprJUpeKMDbrcgWtdHBKo; // 0x28
				public int ZCaKPgzFCrVnIscHoZYKRMOyQK; // 0x30
	
				// Properties
				Platform ZjgEXkGxBVzRLGmFzygWzMTuDVL { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018036AC80-0x000000018036AC90 
				object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018036AC80-0x000000018036AC90 
	
				// Constructors
				[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
				public GZAfzUfNaNaapIKPbDvSSTwYWnvI(int <>1__state); // 0x0000000180393A20-0x0000000180393A70
	
				// Methods
				[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
				IEnumerator<Platform> System.Collections.Generic.IEnumerable<Rewired.Data.Mapping.HardwareJoystickMap.Platform>.GetEnumerator(); // 0x0000000180C25E60-0x0000000180C25F80
				[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
				IEnumerator IEnumerable.GetEnumerator(); // 0x0000000180C25E60-0x0000000180C25F80
				private bool MoveNext(); // 0x0000000180C25CB0-0x0000000180C25E60
				[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
				void IEnumerator.Reset(); // 0x0000000180C25F80-0x0000000180C25FD0
				void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			}
	
			// Constructors
			protected Platform(); // 0x000000018036B6C0-0x000000018036B6D0
	
			// Methods
			internal abstract bool Matches(BridgedControllerHWInfo BridgedControllerHWInfo, bool strictMatch, out int variantIndex, out Platform platformMap);
			internal abstract string[] GetAxisNames(ControllerElementIdentifier[] identifiers);
			internal abstract string[] GetEffectiveButtonNames(ControllerElementIdentifier[] identifiers);
			internal abstract void GetGameElementIdentifierIdMappings(out int[] buttons, out int[] axes);
			internal abstract bool IsElementIdentifierMapped(int elementIdentifierId);
			internal Platform GetFirstValidPlatformMap(out int variantIndex); // 0x00000001805EF460-0x00000001805EF710
			internal int IndexOfElementIdentifier(ControllerElementIdentifier[] elementIdentifiers, int id); // 0x00000001805EF7F0-0x00000001805EF890
			internal abstract AxisCalibrationData[] GetAxisCalibrationData();
			internal abstract void GetAxisData(out AxisRange[] axisRanges, out HardwareAxisInfo[] axisInfos);
			internal abstract void GetButtonData(out HardwareButtonInfo[] buttonInfos);
			internal abstract ControllerElementType GetEffectiveElementIdentifierType(ControllerElementIdentifier elementIdentifier);
			internal abstract bool GetEffectiveAxisRange(ControllerElementIdentifier elementIdentifier, out AxisRange axisRange);
			internal Platform GetPlatformMap(int variantIndex); // 0x00000001805EF710-0x00000001805EF7F0
			internal HardwareJoystickMap_InputManager ToHardwareJoystickMap_InputManager(HardwareJoystickMap hardwareJoystickMap, InputSource inputSource, InputPlatform actualInputPlatform, int variantIndex); // 0x00000001805EF890-0x00000001805F10D0
			public abstract object DeepClone();
			internal abstract void CopyVars(Platform destination);
		}
	
		[Serializable]
		[CustomClassObfuscation] // 0x00000001800D0530-0x00000001800D0560
		public abstract class Elements_Base : IDeepCloneable // TypeDefIndex: 6061
		{
			// Properties
			public abstract int buttonCount { get; }
			public abstract int axisCount { get; }
	
			// Constructors
			protected Elements_Base(); // 0x000000018036B6C0-0x000000018036B6D0
	
			// Methods
			internal virtual void CopyVars(Elements_Base destination); // 0x00000001803581E0-0x00000001803581F0
			internal abstract ControllerElementType GetEffectiveElementIdentifierType(ControllerElementIdentifier elementIdentifier);
			internal abstract bool GetEffectiveAxisRange(ControllerElementIdentifier elementIdentifier, out AxisRange axisRange);
			public abstract object DeepClone();
		}
	
		[Serializable]
		[CustomClassObfuscation] // 0x00000001800D0530-0x00000001800D0560
		public abstract class MatchingCriteria_Base : IDeepCloneable // TypeDefIndex: 6062
		{
			// Fields
			public int axisCount; // 0x10
			public int buttonCount; // 0x14
			public bool disabled; // 0x18
			public string tag; // 0x20
	
			// Properties
			internal abstract bool hasData { get; }
			internal virtual bool isAllowed { get; } // 0x00000001805EF400-0x00000001805EF410 
			internal abstract int alternateElementCount { get; }
	
			// Nested types
			[Serializable]
			public class ElementCount_Base : IDeepCloneable // TypeDefIndex: 6063
			{
				// Fields
				public int axisCount; // 0x10
				public int buttonCount; // 0x14
	
				// Constructors
				public ElementCount_Base(); // 0x000000018036B6C0-0x000000018036B6D0
	
				// Methods
				public virtual object DeepClone(); // 0x00000001805E9390-0x00000001805E9400
				internal virtual void CopyVars(ElementCount_Base param_0000cd8a); // 0x00000001805E9350-0x00000001805E9390
				internal virtual bool Matches(BridgedControllerHWInfo param_0000cd8b); // 0x00000001805E9400-0x00000001805E9470
			}
	
			// Constructors
			protected MatchingCriteria_Base(); // 0x000000018036B6C0-0x000000018036B6D0
	
			// Methods
			internal virtual bool Matches(BridgedControllerHWInfo BridgedControllerHWInfo, bool strictMatch); // 0x00000001805EF220-0x00000001805EF2D0
			internal abstract ElementCount_Base GetAlternateElementCount(int index);
			internal virtual bool ElementCountsMatch(BridgedControllerHWInfo bridgedControllerHWInfo, out bool alternateMatched); // 0x00000001805EF0C0-0x00000001805EF220
			internal virtual void CopyVars(MatchingCriteria_Base destination); // 0x00000001805EF070-0x00000001805EF0C0
			internal static bool StringMatches(string searchIn, string searchFor, bool useRegex); // 0x00000001805EF2D0-0x00000001805EF400
			public abstract object DeepClone();
		}
	
		[Serializable]
		[CustomClassObfuscation] // 0x00000001800D0530-0x00000001800D0560
		public class CompoundElement : IDeepCloneable // TypeDefIndex: 6064
		{
			// Fields
			public CompoundControllerElementType type; // 0x10
			public int elementIdentifier; // 0x14
			public int[] componentElementIdentifiers; // 0x18
	
			// Properties
			public int elementCount { get; } // 0x00000001803951A0-0x00000001803951B0 
	
			// Constructors
			public CompoundElement(); // 0x00000001805D9EA0-0x00000001805D9F10
			public CompoundElement(CompoundElement original); // 0x00000001805D9E30-0x00000001805D9EA0
	
			// Methods
			public int GetComponentElementIdentifierId(int index); // 0x00000001805D9990-0x00000001805D99F0
			public virtual object DeepClone(); // 0x00000001805D98F0-0x00000001805D9990
			protected virtual void ImportVars(CompoundElement source); // 0x00000001805D99F0-0x00000001805D9A60
			internal static void SortHatElementsClockwise(CompoundElement element); // 0x00000001805D9A60-0x00000001805D9E30
		}
	
		[Serializable]
		[CustomClassObfuscation] // 0x00000001800D0530-0x00000001800D0560
		public class VidPid // TypeDefIndex: 6065
		{
			// Fields
			public int vendorId; // 0x10
			public int productId; // 0x14
	
			// Constructors
			public VidPid(); // 0x000000018036B6C0-0x000000018036B6D0
		}
	
		[Serializable]
		[CustomClassObfuscation] // 0x00000001800D0530-0x00000001800D0560
		public class AxisCalibrationInfoEntry : IDeepCloneable // TypeDefIndex: 6066
		{
			// Fields
			[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
			internal AlternateAxisCalibrationType key; // 0x10
			[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
			internal AxisCalibrationInfo calibration; // 0x18
	
			// Constructors
			public AxisCalibrationInfoEntry(AxisCalibrationInfoEntry original); // 0x00000001805D8BF0-0x00000001805D8C50
	
			// Methods
			public virtual object DeepClone(); // 0x00000001805D8620-0x00000001805D86B0
			protected virtual void ImportVars(AxisCalibrationInfoEntry source); // 0x00000001805D86B0-0x00000001805D8730
			public static Dictionary<int, AxisCalibrationInfo> ToDictionary(AxisCalibrationInfoEntry[] calibrations, bool deepClone); // 0x00000001805D8730-0x00000001805D8BF0
		}
	
		[Serializable]
		[CustomClassObfuscation] // 0x00000001800D0530-0x00000001800D0560
		public abstract class Platform_RawOrDirectInput : Rewired.Data.Mapping.HardwareJoystickMap.Platform // TypeDefIndex: 6067
		{
			// Fields
			public MatchingCriteria matchingCriteria; // 0x18
	
			// Properties
			internal override bool hasData { get; } // 0x0000000180C79940-0x0000000180C799D0 
			internal override bool disabled { get; } // 0x000000018039C440-0x000000018039C450 
			internal override bool isAllowed { get; } // 0x000000018039C4C0-0x000000018039C500 
	
			// Nested types
			[Serializable]
			[CustomClassObfuscation] // 0x00000001800D0530-0x00000001800D0560
			public sealed class MatchingCriteria : MatchingCriteria_Base // TypeDefIndex: 6068
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
				internal override bool hasData { get; } // 0x0000000180C726E0-0x0000000180C72710 
				internal override bool isAllowed { get; } // 0x000000018039A1E0-0x000000018039A200 
				internal override int alternateElementCount { get; } // 0x000000018039A130-0x000000018039A140 
	
				// Nested types
				[Serializable]
				public sealed class ElementCount : MatchingCriteria_Base.ElementCount_Base // TypeDefIndex: 6069
				{
					// Fields
					public int hatCount; // 0x18
	
					// Constructors
					public ElementCount(); // 0x000000018037E800-0x000000018037E810
	
					// Methods
					public override object DeepClone(); // 0x0000000180C6C710-0x0000000180C6C7A0
					internal override void CopyVars(MatchingCriteria_Base.ElementCount_Base param_0000cd9d); // 0x0000000180C6C6A0-0x0000000180C6C710
					internal override bool Matches(BridgedControllerHWInfo param_0000cd9e); // 0x0000000180393E00-0x0000000180393E60
				}
	
				// Constructors
				public MatchingCriteria(); // 0x000000018037E800-0x000000018037E810
	
				// Methods
				internal override bool Matches(BridgedControllerHWInfo bridgedControllerHWInfo, bool strictMatch); // 0x0000000180C71A20-0x0000000180C71D30
				internal override ElementCount_Base GetAlternateElementCount(int index); // 0x0000000180399A80-0x0000000180399AD0
				internal override bool ElementCountsMatch(BridgedControllerHWInfo bridgedControllerHWInfo, out bool alternateMatched); // 0x0000000180C70E10-0x0000000180C70EB0
				private bool ProductNameMatches(BridgedControllerHWInfo controller); // 0x0000000180C72450-0x0000000180C724E0
				private bool ProductNameMatches(string name); // 0x0000000180C724E0-0x0000000180C726E0
				public override object DeepClone(); // 0x0000000180C70D00-0x0000000180C70D70
				internal override void CopyVars(MatchingCriteria_Base destination); // 0x0000000180C70970-0x0000000180C70A60
			}
	
			[Serializable]
			[CustomClassObfuscation] // 0x00000001800D0530-0x00000001800D0560
			public abstract class Elements_Platform_Base : Elements_Base // TypeDefIndex: 6070
			{
				// Properties
				internal abstract IEnumerable<Axis_Base> Axes { get; }
				internal abstract IEnumerable<Button_Base> Buttons { get; }
	
				// Constructors
				protected Elements_Platform_Base(); // 0x000000018037E800-0x000000018037E810
	
				// Methods
				internal abstract Axis_Base GetAxis(int axisIndex);
			}
	
			[Serializable]
			[CustomClassObfuscation] // 0x00000001800D0530-0x00000001800D0560
			public class CustomCalculationSourceData : IDeepCloneable // TypeDefIndex: 6071
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
				public CustomCalculationSourceData(); // 0x000000018036B6C0-0x000000018036B6D0
	
				// Methods
				public object DeepClone(); // 0x0000000180C6C520-0x0000000180C6C5C0
			}
	
			[Serializable]
			[CustomClassObfuscation] // 0x00000001800D0530-0x00000001800D0560
			public abstract class Element : IDeepCloneable // TypeDefIndex: 6072
			{
				// Fields
				public CustomCalculation customCalculation; // 0x10
				public CustomCalculationSourceData[] customCalculationSourceData; // 0x18
	
				// Constructors
				protected Element(); // 0x000000018036B6C0-0x000000018036B6D0
	
				// Methods
				public abstract object DeepClone();
				protected void ImportVars(Element source); // 0x0000000180C6C880-0x0000000180C6C8E0
			}
	
			[Serializable]
			[CustomClassObfuscation] // 0x00000001800D0530-0x00000001800D0560
			public abstract class Button_Base : Element // TypeDefIndex: 6073
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
				public Button_Base(); // 0x0000000180C6BC60-0x0000000180C6BC80
	
				// Methods
				protected void ImportVars(Button_Base source); // 0x0000000180C6BB20-0x0000000180C6BC60
			}
	
			[Serializable]
			[CustomClassObfuscation] // 0x00000001800D0530-0x00000001800D0560
			public abstract class Axis_Base : Element // TypeDefIndex: 6074
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
				public Axis_Base(); // 0x0000000180C6AAF0-0x0000000180C6AB10
	
				// Methods
				protected void ImportVars(Axis_Base source); // 0x0000000180C6A950-0x0000000180C6AAF0
			}
	
			public enum DeviceType // TypeDefIndex: 6075
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
			protected Platform_RawOrDirectInput(); // 0x000000018037E800-0x000000018037E810
	
			// Methods
			internal abstract IEnumerable<Axis_Base> IterateAxes();
			internal abstract IEnumerable<Button_Base> IterateButtons();
			internal override void CopyVars(Rewired.Data.Mapping.HardwareJoystickMap.Platform destination); // 0x0000000180C79850-0x0000000180C79940
		}
	
		[Serializable]
		[CustomClassObfuscation] // 0x00000001800D0530-0x00000001800D0560
		public class Platform_DirectInput_Base : Platform_RawOrDirectInput // TypeDefIndex: 6076
		{
			// Fields
			public Elements elements; // 0x20
	
			// Properties
			internal override InputPlatform platform { get; } // 0x000000018042E670-0x000000018042E680 
			internal Axis[] Axes_orig { get; } // 0x000000018039C3E0-0x000000018039C3F0 
			internal Button[] Buttons_orig { get; } // 0x000000018039C3F0-0x000000018039C400 
			internal override IList<Rewired.Data.Mapping.HardwareJoystickMap.Platform> variants_base { get; } // 0x000000018035FCC0-0x000000018035FCD0 
			public override int assignedButtonCount { get; } // 0x000000018039C420-0x000000018039C440 
			public override int assignedAxisCount { get; } // 0x000000018039C400-0x000000018039C420 
			internal override Elements_Base elements_base { get; } // 0x000000018036AC70-0x000000018036AC80 
	
			// Nested types
			[Serializable]
			[CustomClassObfuscation] // 0x00000001800D0530-0x00000001800D0560
			public sealed class Elements : Platform_RawOrDirectInput.Elements_Platform_Base // TypeDefIndex: 6077
			{
				// Fields
				public Axis[] axes; // 0x10
				public Button[] buttons; // 0x18
	
				// Properties
				public override int buttonCount { get; } // 0x00000001803951A0-0x00000001803951B0 
				public override int axisCount { get; } // 0x0000000180395190-0x00000001803951A0 
				internal override IEnumerable<Platform_RawOrDirectInput.Axis_Base> Axes { get; } // 0x0000000180C257A0-0x0000000180C25820 
				internal override IEnumerable<Platform_RawOrDirectInput.Button_Base> Buttons { get; } // 0x0000000180C25920-0x0000000180C259A0 
	
				// Nested types
				[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
				private sealed class VFPeobtRAyqhQUBHMrCLvCKUfOd : IEnumerable<Platform_RawOrDirectInput.Axis_Base>, IEnumerator<Platform_RawOrDirectInput.Axis_Base> // TypeDefIndex: 6078
				{
					// Fields
					private Platform_RawOrDirectInput.Axis_Base aSrFEaALHwhGTdXfCdeUqgbwaZGO; // 0x10
					private int eLrUhJFgzEZElCzdKvcrgOLXLvL; // 0x18
					private int RQaeFqcJnaOYpZSBxtfUkVOjfOo; // 0x1C
					public Elements gKPmvKLRxdGbmXiMfUeDjGbezUo; // 0x20
					public int VKvkBbBTFhVmMOfYFCAQiouOITD; // 0x28
	
					// Properties
					Platform_RawOrDirectInput.Axis_Base nIKQstLqZCeOFdNDhBATHfuWIFQX { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018036AC80-0x000000018036AC90 
					object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018036AC80-0x000000018036AC90 
	
					// Constructors
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					public VFPeobtRAyqhQUBHMrCLvCKUfOd(int <>1__state); // 0x0000000180393A20-0x0000000180393A70
	
					// Methods
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					IEnumerator<Platform_RawOrDirectInput.Axis_Base> System.Collections.Generic.IEnumerable<Rewired.Data.Mapping.HardwareJoystickMap.Platform_RawOrDirectInput.Axis_Base>.GetEnumerator(); // 0x0000000180C362D0-0x0000000180C36420
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					IEnumerator IEnumerable.GetEnumerator(); // 0x0000000180C362D0-0x0000000180C36420
					private bool MoveNext(); // 0x0000000180C36180-0x0000000180C362D0
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					void IEnumerator.Reset(); // 0x0000000180C36420-0x0000000180C36470
					void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
				}
	
				[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
				private sealed class rQViXDgeNSgiBKrrBJjPNlNHqaJj : IEnumerable<Platform_RawOrDirectInput.Button_Base>, IEnumerator<Platform_RawOrDirectInput.Button_Base> // TypeDefIndex: 6079
				{
					// Fields
					private Platform_RawOrDirectInput.Button_Base aSrFEaALHwhGTdXfCdeUqgbwaZGO; // 0x10
					private int eLrUhJFgzEZElCzdKvcrgOLXLvL; // 0x18
					private int RQaeFqcJnaOYpZSBxtfUkVOjfOo; // 0x1C
					public Elements gKPmvKLRxdGbmXiMfUeDjGbezUo; // 0x20
					public int gOscWspLicRODXhGypyRngxBgnz; // 0x28
	
					// Properties
					Platform_RawOrDirectInput.Button_Base zZOeLQhakIZFsPvaKJkuaVXllVb { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018036AC80-0x000000018036AC90 
					object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018036AC80-0x000000018036AC90 
	
					// Constructors
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					public rQViXDgeNSgiBKrrBJjPNlNHqaJj(int <>1__state); // 0x0000000180393A20-0x0000000180393A70
	
					// Methods
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					IEnumerator<Platform_RawOrDirectInput.Button_Base> System.Collections.Generic.IEnumerable<Rewired.Data.Mapping.HardwareJoystickMap.Platform_RawOrDirectInput.Button_Base>.GetEnumerator(); // 0x0000000180C37EB0-0x0000000180C37FB0
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					IEnumerator IEnumerable.GetEnumerator(); // 0x0000000180C37EB0-0x0000000180C37FB0
					private bool MoveNext(); // 0x0000000180C37D80-0x0000000180C37EB0
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					void IEnumerator.Reset(); // 0x0000000180C37FB0-0x0000000180C38000
					void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
				}
	
				// Constructors
				public Elements(); // 0x0000000180363710-0x0000000180363720
	
				// Methods
				internal override Platform_RawOrDirectInput.Axis_Base GetAxis(int axisIndex); // 0x0000000180C23830-0x0000000180C23890
				internal override ControllerElementType GetEffectiveElementIdentifierType(ControllerElementIdentifier elementIdentifier); // 0x0000000180C25120-0x0000000180C252D0
				internal override bool GetEffectiveAxisRange(ControllerElementIdentifier elementIdentifier, out AxisRange axisRange); // 0x0000000180C24260-0x0000000180C24590
				public override object DeepClone(); // 0x0000000180C23670-0x0000000180C236E0
				internal override void CopyVars(Elements_Base destination); // 0x0000000180C233B0-0x0000000180C23440
			}
	
			[Serializable]
			[CustomClassObfuscation] // 0x00000001800D0530-0x00000001800D0560
			public sealed class Button : Platform_RawOrDirectInput.Button_Base // TypeDefIndex: 6080
			{
				// Constructors
				public Button(); // 0x0000000180C22140-0x0000000180C22150
	
				// Methods
				public override object DeepClone(); // 0x0000000180C21D50-0x0000000180C21DC0
				private void ImportVars(Button source); // 0x0000000180C21F10-0x0000000180C21F20
			}
	
			[Serializable]
			[CustomClassObfuscation] // 0x00000001800D0530-0x00000001800D0560
			public sealed class Axis : Platform_RawOrDirectInput.Axis_Base // TypeDefIndex: 6081
			{
				// Constructors
				public Axis(); // 0x0000000180C215C0-0x0000000180C215D0
	
				// Methods
				public override object DeepClone(); // 0x0000000180C210A0-0x0000000180C21110
				private void ImportVars(Axis source); // 0x0000000180C21360-0x0000000180C21370
			}
	
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private sealed class iuSqROEJUiINorGiLbNdWaSQilf : IEnumerable<Axis_Base>, IEnumerator<Axis_Base> // TypeDefIndex: 6082
			{
				// Fields
				private Platform_RawOrDirectInput.Axis_Base aSrFEaALHwhGTdXfCdeUqgbwaZGO; // 0x10
				private int eLrUhJFgzEZElCzdKvcrgOLXLvL; // 0x18
				private int RQaeFqcJnaOYpZSBxtfUkVOjfOo; // 0x1C
				public Platform_DirectInput_Base gKPmvKLRxdGbmXiMfUeDjGbezUo; // 0x20
				public int PDqsFqWbqPKqEzUyDCjDUidzESc; // 0x28
				public int csGJgKcxqlbMfoFsHtnxIxwbumC; // 0x2C
	
				// Properties
				Platform_RawOrDirectInput.Axis_Base nIKQstLqZCeOFdNDhBATHfuWIFQX { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018036AC80-0x000000018036AC90 
				object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018036AC80-0x000000018036AC90 
	
				// Constructors
				[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
				public iuSqROEJUiINorGiLbNdWaSQilf(int <>1__state); // 0x0000000180C37440-0x0000000180C374B0
	
				// Methods
				[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
				IEnumerator<Platform_RawOrDirectInput.Axis_Base> System.Collections.Generic.IEnumerable<Rewired.Data.Mapping.HardwareJoystickMap.Platform_RawOrDirectInput.Axis_Base>.GetEnumerator(); // 0x0000000180C372D0-0x0000000180C373F0
				[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
				IEnumerator IEnumerable.GetEnumerator(); // 0x0000000180C372D0-0x0000000180C373F0
				private bool MoveNext(); // 0x0000000180C37110-0x0000000180C372D0
				[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
				void IEnumerator.Reset(); // 0x0000000180C373F0-0x0000000180C37440
				void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			}
	
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private sealed class iuHqBVOUUoeiikFnGISYSUrdzJW : IEnumerable<Button_Base>, IEnumerator<Button_Base> // TypeDefIndex: 6083
			{
				// Fields
				private Platform_RawOrDirectInput.Button_Base aSrFEaALHwhGTdXfCdeUqgbwaZGO; // 0x10
				private int eLrUhJFgzEZElCzdKvcrgOLXLvL; // 0x18
				private int RQaeFqcJnaOYpZSBxtfUkVOjfOo; // 0x1C
				public Platform_DirectInput_Base gKPmvKLRxdGbmXiMfUeDjGbezUo; // 0x20
				public int AyMLzwfKbghsBcKYGuvxjNAmrlN; // 0x28
				public int QyDDfdpGWGcYplbmqgZMddBHnRm; // 0x2C
	
				// Properties
				Platform_RawOrDirectInput.Button_Base zZOeLQhakIZFsPvaKJkuaVXllVb { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018036AC80-0x000000018036AC90 
				object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018036AC80-0x000000018036AC90 
	
				// Constructors
				[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
				public iuHqBVOUUoeiikFnGISYSUrdzJW(int <>1__state); // 0x0000000180393A20-0x0000000180393A70
	
				// Methods
				[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
				IEnumerator<Platform_RawOrDirectInput.Button_Base> System.Collections.Generic.IEnumerable<Rewired.Data.Mapping.HardwareJoystickMap.Platform_RawOrDirectInput.Button_Base>.GetEnumerator(); // 0x0000000180C36FB0-0x0000000180C370C0
				[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
				IEnumerator IEnumerable.GetEnumerator(); // 0x0000000180C36FB0-0x0000000180C370C0
				private bool MoveNext(); // 0x0000000180C36DE0-0x0000000180C36FB0
				[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
				void IEnumerator.Reset(); // 0x0000000180C370C0-0x0000000180C37110
				void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			}
	
			// Constructors
			public Platform_DirectInput_Base(); // 0x0000000180363710-0x0000000180363720
	
			// Methods
			internal override bool Matches(BridgedControllerHWInfo BridgedControllerHWInfo, bool strictMatch, out int variantIndex, out Rewired.Data.Mapping.HardwareJoystickMap.Platform platformMap); // 0x0000000180C2A550-0x0000000180C2A5E0
			internal override string[] GetAxisNames(ControllerElementIdentifier[] identifiers); // 0x0000000180C292D0-0x0000000180C295D0
			internal override string[] GetEffectiveButtonNames(ControllerElementIdentifier[] identifiers); // 0x0000000180C297C0-0x0000000180C29AC0
			internal override bool IsElementIdentifierMapped(int elementIdentifierId); // 0x0000000180C2A020-0x0000000180C2A420
			internal override void GetGameElementIdentifierIdMappings(out int[] buttons, out int[] axes); // 0x0000000180C29AC0-0x0000000180C2A020
			internal override AxisCalibrationData[] GetAxisCalibrationData(); // 0x0000000180C28740-0x0000000180C28DC0
			internal override void GetAxisData(out AxisRange[] axisRanges, out HardwareAxisInfo[] axisInfos); // 0x0000000180C28DC0-0x0000000180C292D0
			internal override void GetButtonData(out HardwareButtonInfo[] buttonInfos); // 0x0000000180C295D0-0x0000000180C297C0
			internal override ControllerElementType GetEffectiveElementIdentifierType(ControllerElementIdentifier elementIdentifier); // 0x000000018039BA80-0x000000018039BAA0
			internal override bool GetEffectiveAxisRange(ControllerElementIdentifier elementIdentifier, out AxisRange axisRange); // 0x000000018039B710-0x000000018039B740
			internal override IEnumerable<Axis_Base> IterateAxes(); // 0x0000000180C2A420-0x0000000180C2A4D0
			internal override IEnumerable<Button_Base> IterateButtons(); // 0x0000000180C2A4D0-0x0000000180C2A550
			public override object DeepClone(); // 0x0000000180C286D0-0x0000000180C28740
			internal override void CopyVars(Rewired.Data.Mapping.HardwareJoystickMap.Platform destination); // 0x0000000180C285E0-0x0000000180C286D0
		}
	
		[Serializable]
		[CustomClassObfuscation] // 0x00000001800D0530-0x00000001800D0560
		public sealed class Platform_DirectInput : Platform_DirectInput_Base // TypeDefIndex: 6084
		{
			// Fields
			public Platform_DirectInput_Base[] variants; // 0x28
	
			// Properties
			internal override IList<Rewired.Data.Mapping.HardwareJoystickMap.Platform> variants_base { get; } // 0x0000000180369B60-0x0000000180369B70 
	
			// Constructors
			public Platform_DirectInput(); // 0x0000000180363710-0x0000000180363720
	
			// Methods
			internal override bool Matches(BridgedControllerHWInfo BridgedControllerHWInfo, bool strictMatch, out int variantIndex, out Rewired.Data.Mapping.HardwareJoystickMap.Platform platformMap); // 0x0000000180C2A7F0-0x0000000180C2A9E0
			public override object DeepClone(); // 0x0000000180C2A780-0x0000000180C2A7F0
			internal override void CopyVars(Rewired.Data.Mapping.HardwareJoystickMap.Platform destination); // 0x0000000180C2A5E0-0x0000000180C2A780
		}
	
		[Serializable]
		[CustomClassObfuscation] // 0x00000001800D0530-0x00000001800D0560
		public class Platform_RawInput_Base : Platform_RawOrDirectInput // TypeDefIndex: 6085
		{
			// Fields
			public Elements elements; // 0x20
	
			// Properties
			internal override InputPlatform platform { get; } // 0x0000000180362180-0x0000000180362190 
			internal Axis[] Axes_orig { get; } // 0x000000018039C3E0-0x000000018039C3F0 
			internal Button[] Buttons_orig { get; } // 0x000000018039C3F0-0x000000018039C400 
			internal override IList<Rewired.Data.Mapping.HardwareJoystickMap.Platform> variants_base { get; } // 0x000000018035FCC0-0x000000018035FCD0 
			public override int assignedButtonCount { get; } // 0x000000018039C420-0x000000018039C440 
			public override int assignedAxisCount { get; } // 0x000000018039C400-0x000000018039C420 
			internal override Elements_Base elements_base { get; } // 0x000000018036AC70-0x000000018036AC80 
	
			// Nested types
			[Serializable]
			[CustomClassObfuscation] // 0x00000001800D0530-0x00000001800D0560
			public sealed class Elements : Platform_RawOrDirectInput.Elements_Platform_Base // TypeDefIndex: 6086
			{
				// Fields
				public Axis[] axes; // 0x10
				public Button[] buttons; // 0x18
	
				// Properties
				public override int buttonCount { get; } // 0x00000001803951A0-0x00000001803951B0 
				public override int axisCount { get; } // 0x0000000180395190-0x00000001803951A0 
				internal override IEnumerable<Platform_RawOrDirectInput.Axis_Base> Axes { get; } // 0x0000000180C6EDD0-0x0000000180C6EE50 
				internal override IEnumerable<Platform_RawOrDirectInput.Button_Base> Buttons { get; } // 0x0000000180C6EED0-0x0000000180C6EF70 
	
				// Nested types
				[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
				private sealed class iOZMHmzkLdeYvIRpMKglwSFXTrt : IEnumerable<Platform_RawOrDirectInput.Axis_Base>, IEnumerator<Platform_RawOrDirectInput.Axis_Base> // TypeDefIndex: 6087
				{
					// Fields
					private Platform_RawOrDirectInput.Axis_Base aSrFEaALHwhGTdXfCdeUqgbwaZGO; // 0x10
					private int eLrUhJFgzEZElCzdKvcrgOLXLvL; // 0x18
					private int RQaeFqcJnaOYpZSBxtfUkVOjfOo; // 0x1C
					public Elements gKPmvKLRxdGbmXiMfUeDjGbezUo; // 0x20
					public int MmyyNPUYdJpsCLKeobZeMLsbDxo; // 0x28
	
					// Properties
					Platform_RawOrDirectInput.Axis_Base nIKQstLqZCeOFdNDhBATHfuWIFQX { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018036AC80-0x000000018036AC90 
					object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018036AC80-0x000000018036AC90 
	
					// Constructors
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					public iOZMHmzkLdeYvIRpMKglwSFXTrt(int <>1__state); // 0x0000000180393A20-0x0000000180393A70
	
					// Methods
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					IEnumerator<Platform_RawOrDirectInput.Axis_Base> System.Collections.Generic.IEnumerable<Rewired.Data.Mapping.HardwareJoystickMap.Platform_RawOrDirectInput.Axis_Base>.GetEnumerator(); // 0x0000000180C81FB0-0x0000000180C820D0
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					IEnumerator IEnumerable.GetEnumerator(); // 0x0000000180C81FB0-0x0000000180C820D0
					private bool MoveNext(); // 0x0000000180C81E50-0x0000000180C81FB0
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					void IEnumerator.Reset(); // 0x0000000180C820D0-0x0000000180C82120
					void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
				}
	
				[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
				private sealed class ncEmMQmZXTGhsprJENHTzLdLOHc : IEnumerable<Platform_RawOrDirectInput.Button_Base>, IEnumerator<Platform_RawOrDirectInput.Button_Base> // TypeDefIndex: 6088
				{
					// Fields
					private Platform_RawOrDirectInput.Button_Base aSrFEaALHwhGTdXfCdeUqgbwaZGO; // 0x10
					private int eLrUhJFgzEZElCzdKvcrgOLXLvL; // 0x18
					private int RQaeFqcJnaOYpZSBxtfUkVOjfOo; // 0x1C
					public Elements gKPmvKLRxdGbmXiMfUeDjGbezUo; // 0x20
					public int TSuxJyNcYLrUoHKyJOizjwmLoiL; // 0x28
	
					// Properties
					Platform_RawOrDirectInput.Button_Base zZOeLQhakIZFsPvaKJkuaVXllVb { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018036AC80-0x000000018036AC90 
					object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018036AC80-0x000000018036AC90 
	
					// Constructors
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					public ncEmMQmZXTGhsprJENHTzLdLOHc(int <>1__state); // 0x0000000180393A20-0x0000000180393A70
	
					// Methods
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					IEnumerator<Platform_RawOrDirectInput.Button_Base> System.Collections.Generic.IEnumerable<Rewired.Data.Mapping.HardwareJoystickMap.Platform_RawOrDirectInput.Button_Base>.GetEnumerator(); // 0x0000000180C825B0-0x0000000180C826C0
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					IEnumerator IEnumerable.GetEnumerator(); // 0x0000000180C825B0-0x0000000180C826C0
					private bool MoveNext(); // 0x0000000180C82470-0x0000000180C825B0
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					void IEnumerator.Reset(); // 0x0000000180C826C0-0x0000000180C82710
					void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
				}
	
				// Constructors
				public Elements(); // 0x000000018037E800-0x000000018037E810
	
				// Methods
				internal override Platform_RawOrDirectInput.Axis_Base GetAxis(int axisIndex); // 0x0000000180C6D0B0-0x0000000180C6D120
				internal override ControllerElementType GetEffectiveElementIdentifierType(ControllerElementIdentifier elementIdentifier); // 0x0000000180C6E620-0x0000000180C6E7D0
				internal override bool GetEffectiveAxisRange(ControllerElementIdentifier elementIdentifier, out AxisRange axisRange); // 0x0000000180C6D120-0x0000000180C6D470
				public override object DeepClone(); // 0x0000000180C6CD30-0x0000000180C6CDA0
				internal override void CopyVars(Elements_Base destination); // 0x0000000180C6CB50-0x0000000180C6CBE0
			}
	
			[Serializable]
			[CustomClassObfuscation] // 0x00000001800D0530-0x00000001800D0560
			public sealed class Button : Platform_RawOrDirectInput.Button_Base // TypeDefIndex: 6089
			{
				// Fields
				public int sourceOtherAxis; // 0x68
	
				// Constructors
				public Button(); // 0x0000000180C6BC60-0x0000000180C6BC80
	
				// Methods
				public override object DeepClone(); // 0x0000000180C6BFB0-0x0000000180C6C140
				private void ImportVars(Button source); // 0x0000000180C6C1B0-0x0000000180C6C310
			}
	
			[Serializable]
			[CustomClassObfuscation] // 0x00000001800D0530-0x00000001800D0560
			public sealed class Axis : Platform_RawOrDirectInput.Axis_Base // TypeDefIndex: 6090
			{
				// Fields
				public int sourceOtherAxis; // 0x70
	
				// Constructors
				public Axis(); // 0x0000000180C6AAF0-0x0000000180C6AB10
	
				// Methods
				public override object DeepClone(); // 0x0000000180C6AD00-0x0000000180C6AED0
				private void ImportVars(Axis source); // 0x0000000180C6B090-0x0000000180C6B230
			}
	
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private sealed class pjWYBcCdPvcIjgOkrBoCnwFNssX : IEnumerable<Axis_Base>, IEnumerator<Axis_Base> // TypeDefIndex: 6091
			{
				// Fields
				private Platform_RawOrDirectInput.Axis_Base aSrFEaALHwhGTdXfCdeUqgbwaZGO; // 0x10
				private int eLrUhJFgzEZElCzdKvcrgOLXLvL; // 0x18
				private int RQaeFqcJnaOYpZSBxtfUkVOjfOo; // 0x1C
				public Platform_RawInput_Base gKPmvKLRxdGbmXiMfUeDjGbezUo; // 0x20
				public int qCwetSCDbWTjKMGWQjVhebbIpqKV; // 0x28
				public int VZDlfBYfiaqORQQmkhlkPLaImkr; // 0x2C
	
				// Properties
				Platform_RawOrDirectInput.Axis_Base nIKQstLqZCeOFdNDhBATHfuWIFQX { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018036AC80-0x000000018036AC90 
				object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018036AC80-0x000000018036AC90 
	
				// Constructors
				[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
				public pjWYBcCdPvcIjgOkrBoCnwFNssX(int <>1__state); // 0x0000000180393A20-0x0000000180393A70
	
				// Methods
				[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
				IEnumerator<Platform_RawOrDirectInput.Axis_Base> System.Collections.Generic.IEnumerable<Rewired.Data.Mapping.HardwareJoystickMap.Platform_RawOrDirectInput.Axis_Base>.GetEnumerator(); // 0x0000000180C828B0-0x0000000180C829D0
				[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
				IEnumerator IEnumerable.GetEnumerator(); // 0x0000000180C828B0-0x0000000180C829D0
				private bool MoveNext(); // 0x0000000180C82710-0x0000000180C828B0
				[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
				void IEnumerator.Reset(); // 0x0000000180C829D0-0x0000000180C82A20
				void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			}
	
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private sealed class eMQgimYfDNqVQgjKSKCqoGCpzmG : IEnumerable<Button_Base>, IEnumerator<Button_Base> // TypeDefIndex: 6092
			{
				// Fields
				private Platform_RawOrDirectInput.Button_Base aSrFEaALHwhGTdXfCdeUqgbwaZGO; // 0x10
				private int eLrUhJFgzEZElCzdKvcrgOLXLvL; // 0x18
				private int RQaeFqcJnaOYpZSBxtfUkVOjfOo; // 0x1C
				public Platform_RawInput_Base gKPmvKLRxdGbmXiMfUeDjGbezUo; // 0x20
				public int JXAxJSdeQOWBLJdenjcnltZjsYA; // 0x28
				public int VaYSydAOGtprQGObyqqjpusKBHA; // 0x2C
	
				// Properties
				Platform_RawOrDirectInput.Button_Base zZOeLQhakIZFsPvaKJkuaVXllVb { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018036AC80-0x000000018036AC90 
				object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018036AC80-0x000000018036AC90 
	
				// Constructors
				[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
				public eMQgimYfDNqVQgjKSKCqoGCpzmG(int <>1__state); // 0x0000000180393A20-0x0000000180393A70
	
				// Methods
				[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
				IEnumerator<Platform_RawOrDirectInput.Button_Base> System.Collections.Generic.IEnumerable<Rewired.Data.Mapping.HardwareJoystickMap.Platform_RawOrDirectInput.Button_Base>.GetEnumerator(); // 0x0000000180C81D10-0x0000000180C81E00
				[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
				IEnumerator IEnumerable.GetEnumerator(); // 0x0000000180C81D10-0x0000000180C81E00
				private bool MoveNext(); // 0x0000000180C81B60-0x0000000180C81D10
				[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
				void IEnumerator.Reset(); // 0x0000000180C81E00-0x0000000180C81E50
				void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			}
	
			// Constructors
			public Platform_RawInput_Base(); // 0x000000018037E800-0x000000018037E810
	
			// Methods
			internal override bool Matches(BridgedControllerHWInfo BridgedControllerHWInfo, bool strictMatch, out int variantIndex, out Rewired.Data.Mapping.HardwareJoystickMap.Platform platformMap); // 0x0000000180C2EC00-0x0000000180C2EC60
			internal override string[] GetAxisNames(ControllerElementIdentifier[] identifiers); // 0x0000000180C78460-0x0000000180C78780
			internal override string[] GetEffectiveButtonNames(ControllerElementIdentifier[] identifiers); // 0x0000000180C78990-0x0000000180C78C50
			internal override bool IsElementIdentifierMapped(int elementIdentifierId); // 0x0000000180C790F0-0x0000000180C79480
			internal override void GetGameElementIdentifierIdMappings(out int[] buttons, out int[] axes); // 0x0000000180C78C50-0x0000000180C790F0
			internal override AxisCalibrationData[] GetAxisCalibrationData(); // 0x0000000180C777F0-0x0000000180C77EF0
			internal override void GetAxisData(out AxisRange[] axisRanges, out HardwareAxisInfo[] axisInfos); // 0x0000000180C77EF0-0x0000000180C78460
			internal override void GetButtonData(out HardwareButtonInfo[] buttonInfos); // 0x0000000180C78780-0x0000000180C78990
			internal override ControllerElementType GetEffectiveElementIdentifierType(ControllerElementIdentifier elementIdentifier); // 0x000000018039BA80-0x000000018039BAA0
			internal override bool GetEffectiveAxisRange(ControllerElementIdentifier elementIdentifier, out AxisRange axisRange); // 0x000000018039B710-0x000000018039B740
			internal override IEnumerable<Axis_Base> IterateAxes(); // 0x0000000180C79480-0x0000000180C79500
			internal override IEnumerable<Button_Base> IterateButtons(); // 0x0000000180C79500-0x0000000180C79580
			public override object DeepClone(); // 0x0000000180C77780-0x0000000180C777F0
			internal override void CopyVars(Rewired.Data.Mapping.HardwareJoystickMap.Platform destination); // 0x0000000180C775B0-0x0000000180C77780
		}
	
		[Serializable]
		[CustomClassObfuscation] // 0x00000001800D0530-0x00000001800D0560
		public sealed class Platform_RawInput : Platform_RawInput_Base // TypeDefIndex: 6093
		{
			// Fields
			public Platform_RawInput_Base[] variants; // 0x28
	
			// Properties
			internal override IList<Rewired.Data.Mapping.HardwareJoystickMap.Platform> variants_base { get; } // 0x0000000180369B60-0x0000000180369B70 
	
			// Constructors
			public Platform_RawInput(); // 0x000000018037E800-0x000000018037E810
	
			// Methods
			internal override bool Matches(BridgedControllerHWInfo BridgedControllerHWInfo, bool strictMatch, out int variantIndex, out Rewired.Data.Mapping.HardwareJoystickMap.Platform platformMap); // 0x0000000180C79690-0x0000000180C79850
			public override object DeepClone(); // 0x0000000180C79620-0x0000000180C79690
			internal override void CopyVars(Rewired.Data.Mapping.HardwareJoystickMap.Platform destination); // 0x0000000180C79580-0x0000000180C79620
		}
	
		[Serializable]
		[CustomClassObfuscation] // 0x00000001800D0530-0x00000001800D0560
		public class Platform_XInput_Base : Rewired.Data.Mapping.HardwareJoystickMap.Platform // TypeDefIndex: 6094
		{
			// Fields
			public MatchingCriteria matchingCriteria; // 0x18
			public Elements elements; // 0x20
	
			// Properties
			public override int assignedButtonCount { get; } // 0x000000018039C420-0x000000018039C440 
			public override int assignedAxisCount { get; } // 0x000000018039C400-0x000000018039C420 
			internal override InputPlatform platform { get; } // 0x000000018038FAD0-0x000000018038FAE0 
			internal Axis[] Axes_orig { get; } // 0x000000018039C3E0-0x000000018039C3F0 
			internal Button[] Buttons_orig { get; } // 0x000000018039C3F0-0x000000018039C400 
			internal override bool hasData { get; } // 0x000000018039E7F0-0x000000018039E870 
			internal override bool disabled { get; } // 0x000000018039C440-0x000000018039C450 
			internal override bool isAllowed { get; } // 0x000000018039C4C0-0x000000018039C500 
			internal override Elements_Base elements_base { get; } // 0x000000018036AC70-0x000000018036AC80 
			internal override IList<Rewired.Data.Mapping.HardwareJoystickMap.Platform> variants_base { get; } // 0x000000018035FCC0-0x000000018035FCD0 
	
			// Nested types
			[Serializable]
			[CustomClassObfuscation] // 0x00000001800D0530-0x00000001800D0560
			public sealed class MatchingCriteria : MatchingCriteria_Base // TypeDefIndex: 6095
			{
				// Fields
				public XInputDeviceSubType[] subType; // 0x28
	
				// Properties
				internal override bool hasData { get; } // 0x000000018039A170-0x000000018039A1A0 
				internal override bool isAllowed { get; } // 0x000000018039A1E0-0x000000018039A200 
				internal override int alternateElementCount { get; } // 0x000000018035FCC0-0x000000018035FCD0 
	
				// Constructors
				public MatchingCriteria(); // 0x000000018037E800-0x000000018037E810
	
				// Methods
				internal override bool Matches(BridgedControllerHWInfo bridgedControllerHWInfo, bool strictMatch); // 0x0000000180399C70-0x0000000180399DC0
				internal override ElementCount_Base GetAlternateElementCount(int index); // 0x000000018035FCC0-0x000000018035FCD0
				internal override bool ElementCountsMatch(BridgedControllerHWInfo bridgedControllerHWInfo, out bool alternateMatched); // 0x0000000180399A70-0x0000000180399A80
				public override object DeepClone(); // 0x0000000180399980-0x00000001803999F0
				internal override void CopyVars(MatchingCriteria_Base destination); // 0x00000001803996A0-0x0000000180399760
			}
	
			[Serializable]
			[CustomClassObfuscation] // 0x00000001800D0530-0x00000001800D0560
			public sealed class Elements : Elements_Base // TypeDefIndex: 6096
			{
				// Fields
				public Axis[] axes; // 0x10
				public Button[] buttons; // 0x18
	
				// Properties
				public override int buttonCount { get; } // 0x00000001803951A0-0x00000001803951B0 
				public override int axisCount { get; } // 0x0000000180395190-0x00000001803951A0 
	
				// Constructors
				public Elements(); // 0x000000018037E800-0x000000018037E810
	
				// Methods
				public override object DeepClone(); // 0x00000001803940F0-0x0000000180394160
				internal override void CopyVars(Elements_Base destination); // 0x0000000180394020-0x00000001803940F0
				internal override ControllerElementType GetEffectiveElementIdentifierType(ControllerElementIdentifier elementIdentifier); // 0x0000000180394D10-0x0000000180394EC0
				internal override bool GetEffectiveAxisRange(ControllerElementIdentifier elementIdentifier, out AxisRange axisRange); // 0x0000000180394610-0x00000001803948B0
			}
	
			[Serializable]
			[CustomClassObfuscation] // 0x00000001800D0530-0x00000001800D0560
			public abstract class Element : IDeepCloneable // TypeDefIndex: 6097
			{
				// Fields
				public int elementIdentifier; // 0x10
				public HardwareElementSourceType sourceType; // 0x14
				public XInputButton sourceButton; // 0x18
				public XInputAxis sourceAxis; // 0x1C
				public float axisDeadZone; // 0x20
	
				// Constructors
				protected Element(); // 0x000000018036B6C0-0x000000018036B6D0
	
				// Methods
				public abstract object DeepClone();
				internal virtual void CopyVars(Element destination); // 0x0000000180393E60-0x0000000180393ED0
			}
	
			[Serializable]
			[CustomClassObfuscation] // 0x00000001800D0530-0x00000001800D0560
			public sealed class Button : Element // TypeDefIndex: 6098
			{
				// Fields
				public Pole sourceAxisPole; // 0x28
				public HardwareButtonInfo buttonInfo; // 0x30
	
				// Constructors
				public Button(); // 0x0000000180392B20-0x0000000180392B40
	
				// Methods
				public override object DeepClone(); // 0x0000000180392850-0x00000001803928E0
				internal override void CopyVars(Element destination); // 0x00000001803926A0-0x00000001803927E0
			}
	
			[Serializable]
			[CustomClassObfuscation] // 0x00000001800D0530-0x00000001800D0560
			public sealed class Axis : Element // TypeDefIndex: 6099
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
				public Axis(); // 0x0000000180392630-0x0000000180392650
	
				// Methods
				public override object DeepClone(); // 0x0000000180392380-0x00000001803923F0
				internal override void CopyVars(Element destination); // 0x0000000180392100-0x00000001803922C0
			}
	
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private sealed class yNKATGcFUiFMIQCemcgUaIQGBPAh : IEnumerable<Axis>, IEnumerator<Axis> // TypeDefIndex: 6100
			{
				// Fields
				private Axis aSrFEaALHwhGTdXfCdeUqgbwaZGO; // 0x10
				private int eLrUhJFgzEZElCzdKvcrgOLXLvL; // 0x18
				private int RQaeFqcJnaOYpZSBxtfUkVOjfOo; // 0x1C
				public Platform_XInput_Base gKPmvKLRxdGbmXiMfUeDjGbezUo; // 0x20
				public int xfCMKYvfPoZlxORLRgmIUZiDCmJ; // 0x28
	
				// Properties
				Axis kkTYawmetfTkdSzxbKSqTSRqrcW { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018036AC80-0x000000018036AC90 
				object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018036AC80-0x000000018036AC90 
	
				// Constructors
				[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
				public yNKATGcFUiFMIQCemcgUaIQGBPAh(int <>1__state); // 0x0000000180393A20-0x0000000180393A70
	
				// Methods
				[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
				IEnumerator<Axis> System.Collections.Generic.IEnumerable<Rewired.Data.Mapping.HardwareJoystickMap.Platform_XInput_Base.Axis>.GetEnumerator(); // 0x00000001803C1460-0x00000001803C1560
				[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
				IEnumerator IEnumerable.GetEnumerator(); // 0x00000001803C1460-0x00000001803C1560
				private bool MoveNext(); // 0x00000001803C12B0-0x00000001803C1460
				[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
				void IEnumerator.Reset(); // 0x00000001803C1560-0x00000001803C15B0
				void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			}
	
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private sealed class DLVcZRCpGlVpNWhDtAmyJiwSnYKN : IEnumerable<Button>, IEnumerator<Button> // TypeDefIndex: 6101
			{
				// Fields
				private Button aSrFEaALHwhGTdXfCdeUqgbwaZGO; // 0x10
				private int eLrUhJFgzEZElCzdKvcrgOLXLvL; // 0x18
				private int RQaeFqcJnaOYpZSBxtfUkVOjfOo; // 0x1C
				public Platform_XInput_Base gKPmvKLRxdGbmXiMfUeDjGbezUo; // 0x20
				public int MZVOuEoNiLJQnLowXRbjOgPjHWp; // 0x28
	
				// Properties
				Button DkuCOqCnVxdHwaaNicstqpjazoeK { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018036AC80-0x000000018036AC90 
				object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018036AC80-0x000000018036AC90 
	
				// Constructors
				[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
				public DLVcZRCpGlVpNWhDtAmyJiwSnYKN(int <>1__state); // 0x0000000180393A20-0x0000000180393A70
	
				// Methods
				[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
				IEnumerator<Button> System.Collections.Generic.IEnumerable<Rewired.Data.Mapping.HardwareJoystickMap.Platform_XInput_Base.Button>.GetEnumerator(); // 0x00000001803938E0-0x00000001803939D0
				[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
				IEnumerator IEnumerable.GetEnumerator(); // 0x00000001803938E0-0x00000001803939D0
				private bool MoveNext(); // 0x0000000180393740-0x00000001803938E0
				[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
				void IEnumerator.Reset(); // 0x00000001803939D0-0x0000000180393A20
				void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			}
	
			// Constructors
			public Platform_XInput_Base(); // 0x000000018037E800-0x000000018037E810
	
			// Methods
			internal override bool Matches(BridgedControllerHWInfo BridgedControllerHWInfo, bool strictMatch, out int variantIndex, out Rewired.Data.Mapping.HardwareJoystickMap.Platform platformMap); // 0x000000018039E740-0x000000018039E7F0
			internal IEnumerable<Axis> IterateAxes(); // 0x000000018039E640-0x000000018039E6C0
			internal IEnumerable<Button> IterateButtons(); // 0x000000018039E6C0-0x000000018039E740
			internal override string[] GetAxisNames(ControllerElementIdentifier[] identifiers); // 0x000000018039D5E0-0x000000018039D8A0
			internal override string[] GetEffectiveButtonNames(ControllerElementIdentifier[] identifiers); // 0x000000018039DAD0-0x000000018039DD90
			internal override bool IsElementIdentifierMapped(int elementIdentifierId); // 0x000000018039E2B0-0x000000018039E640
			internal override void GetGameElementIdentifierIdMappings(out int[] buttons, out int[] axes); // 0x000000018039DD90-0x000000018039E2B0
			internal override AxisCalibrationData[] GetAxisCalibrationData(); // 0x000000018039CAC0-0x000000018039D0F0
			internal override void GetAxisData(out AxisRange[] axisRanges, out HardwareAxisInfo[] axisInfos); // 0x000000018039D0F0-0x000000018039D5E0
			internal override void GetButtonData(out HardwareButtonInfo[] buttonInfos); // 0x000000018039D8A0-0x000000018039DAD0
			internal override ControllerElementType GetEffectiveElementIdentifierType(ControllerElementIdentifier elementIdentifier); // 0x000000018039BA80-0x000000018039BAA0
			internal override bool GetEffectiveAxisRange(ControllerElementIdentifier elementIdentifier, out AxisRange axisRange); // 0x000000018039B710-0x000000018039B740
			public override object DeepClone(); // 0x000000018039CA50-0x000000018039CAC0
			internal override void CopyVars(Rewired.Data.Mapping.HardwareJoystickMap.Platform destination); // 0x000000018039C950-0x000000018039CA50
		}
	
		[Serializable]
		[CustomClassObfuscation] // 0x00000001800D0530-0x00000001800D0560
		public sealed class Platform_XInput : Platform_XInput_Base // TypeDefIndex: 6102
		{
			// Fields
			public Platform_XInput_Base[] variants; // 0x28
	
			// Properties
			internal override IList<Rewired.Data.Mapping.HardwareJoystickMap.Platform> variants_base { get; } // 0x0000000180369B60-0x0000000180369B70 
	
			// Constructors
			public Platform_XInput(); // 0x000000018037E800-0x000000018037E810
	
			// Methods
			internal override bool Matches(BridgedControllerHWInfo BridgedControllerHWInfo, bool strictMatch, out int variantIndex, out Rewired.Data.Mapping.HardwareJoystickMap.Platform platformMap); // 0x000000018039EA50-0x000000018039EC60
			public override object DeepClone(); // 0x000000018039E9E0-0x000000018039EA50
			internal override void CopyVars(Rewired.Data.Mapping.HardwareJoystickMap.Platform destination); // 0x000000018039E870-0x000000018039E9E0
		}
	
		[Serializable]
		[CustomClassObfuscation] // 0x00000001800D0530-0x00000001800D0560
		public class Platform_OSX_Base : Rewired.Data.Mapping.HardwareJoystickMap.Platform // TypeDefIndex: 6103
		{
			// Fields
			public MatchingCriteria matchingCriteria; // 0x18
			public Elements elements; // 0x20
	
			// Properties
			public override int assignedButtonCount { get; } // 0x000000018039C420-0x000000018039C440 
			public override int assignedAxisCount { get; } // 0x000000018039C400-0x000000018039C420 
			internal override InputPlatform platform { get; } // 0x00000001806A5520-0x00000001806A5530 
			internal Button[] Buttons_orig { get; } // 0x000000018039C3F0-0x000000018039C400 
			internal Axis[] Axes_orig { get; } // 0x000000018039C3E0-0x000000018039C3F0 
			internal override bool hasData { get; } // 0x000000018039C450-0x000000018039C4C0 
			internal override bool disabled { get; } // 0x000000018039C440-0x000000018039C450 
			internal override bool isAllowed { get; } // 0x000000018039C4C0-0x000000018039C500 
			internal override Elements_Base elements_base { get; } // 0x000000018036AC70-0x000000018036AC80 
			internal override IList<Rewired.Data.Mapping.HardwareJoystickMap.Platform> variants_base { get; } // 0x000000018035FCC0-0x000000018035FCD0 
	
			// Nested types
			[Serializable]
			[CustomClassObfuscation] // 0x00000001800D0530-0x00000001800D0560
			public sealed class MatchingCriteria : MatchingCriteria_Base // TypeDefIndex: 6104
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
				internal override bool hasData { get; } // 0x0000000180C283E0-0x0000000180C28430 
				internal override bool isAllowed { get; } // 0x000000018039A1E0-0x000000018039A200 
				internal override int alternateElementCount { get; } // 0x000000018039A130-0x000000018039A140 
	
				// Nested types
				[Serializable]
				public sealed class ElementCount : MatchingCriteria_Base.ElementCount_Base // TypeDefIndex: 6105
				{
					// Fields
					public int hatCount; // 0x18
	
					// Constructors
					public ElementCount(); // 0x000000018037E800-0x000000018037E810
	
					// Methods
					public override object DeepClone(); // 0x0000000180C6C810-0x0000000180C6C880
					internal override void CopyVars(MatchingCriteria_Base.ElementCount_Base param_0000ce1e); // 0x0000000180C6C5C0-0x0000000180C6C630
					internal override bool Matches(BridgedControllerHWInfo param_0000ce1f); // 0x0000000180393E00-0x0000000180393E60
				}
	
				// Constructors
				public MatchingCriteria(); // 0x000000018037E800-0x000000018037E810
	
				// Methods
				internal override bool Matches(BridgedControllerHWInfo bridgedControllerHWInfo, bool strictMatch); // 0x0000000180C27A00-0x0000000180C27D60
				internal override ElementCount_Base GetAlternateElementCount(int index); // 0x0000000180C27090-0x0000000180C27100
				internal override bool ElementCountsMatch(BridgedControllerHWInfo bridgedControllerHWInfo, out bool alternateMatched); // 0x00000001803999F0-0x0000000180399A70
				private bool ProductNameMatches(string name); // 0x0000000180C280E0-0x0000000180C28260
				public override object DeepClone(); // 0x0000000180C26FA0-0x0000000180C27010
				internal override void CopyVars(MatchingCriteria_Base destination); // 0x0000000180C26AD0-0x0000000180C26C10
			}
	
			[Serializable]
			[CustomClassObfuscation] // 0x00000001800D0530-0x00000001800D0560
			public sealed class Elements : Elements_Base // TypeDefIndex: 6106
			{
				// Fields
				public Axis[] axes; // 0x10
				public Button[] buttons; // 0x18
	
				// Properties
				public override int buttonCount { get; } // 0x00000001803951A0-0x00000001803951B0 
				public override int axisCount { get; } // 0x0000000180395190-0x00000001803951A0 
	
				// Nested types
				[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
				private sealed class kDbuzYEUdiCPSbTPZYFihOJXRhw : IEnumerable<Axis>, IEnumerator<Axis> // TypeDefIndex: 6107
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
					Axis CfEkCNzpsTELahprwjkzGdvFgYQb { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018036AC80-0x000000018036AC90 
					object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018036AC80-0x000000018036AC90 
	
					// Constructors
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					public kDbuzYEUdiCPSbTPZYFihOJXRhw(int <>1__state); // 0x0000000180393A20-0x0000000180393A70
	
					// Methods
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					IEnumerator<Axis> System.Collections.Generic.IEnumerable<Rewired.Data.Mapping.HardwareJoystickMap.Platform_OSX_Base.Axis>.GetEnumerator(); // 0x0000000180C37640-0x0000000180C37740
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					IEnumerator IEnumerable.GetEnumerator(); // 0x0000000180C37640-0x0000000180C37740
					private bool MoveNext(); // 0x0000000180C374B0-0x0000000180C37640
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					void IEnumerator.Reset(); // 0x0000000180C37740-0x0000000180C37790
					void IDisposable.Dispose(); // 0x0000000180C36AE0-0x0000000180C36B00
					private void NbSadJNcFYcYqjFnHjxEdPkHvKqk(); // 0x00000001807813B0-0x00000001807813C0
				}
	
				[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
				private sealed class YuvaJpdWFSgCOICIJJGRUeMgqCWt : IEnumerable<Button>, IEnumerator<Button> // TypeDefIndex: 6108
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
					Button gWqIzXkAxaffWVYBlScaueomugN { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018036AC80-0x000000018036AC90 
					object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018036AC80-0x000000018036AC90 
	
					// Constructors
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					public YuvaJpdWFSgCOICIJJGRUeMgqCWt(int <>1__state); // 0x0000000180393A20-0x0000000180393A70
	
					// Methods
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					IEnumerator<Button> System.Collections.Generic.IEnumerable<Rewired.Data.Mapping.HardwareJoystickMap.Platform_OSX_Base.Button>.GetEnumerator(); // 0x0000000180C36990-0x0000000180C36A90
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					IEnumerator IEnumerable.GetEnumerator(); // 0x0000000180C36990-0x0000000180C36A90
					private bool MoveNext(); // 0x0000000180C36790-0x0000000180C36990
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					void IEnumerator.Reset(); // 0x0000000180C36A90-0x0000000180C36AE0
					void IDisposable.Dispose(); // 0x0000000180C36AE0-0x0000000180C36B00
					private void JwqjSHmXKMJEmMfHoasgibmAIyum(); // 0x00000001807813B0-0x00000001807813C0
				}
	
				// Constructors
				public Elements(); // 0x000000018037E800-0x000000018037E810
	
				// Methods
				public IEnumerable<Axis> IterateAxes(); // 0x0000000180C25680-0x0000000180C25700
				public IEnumerable<Button> IterateButtons(); // 0x0000000180C25700-0x0000000180C257A0
				public override object DeepClone(); // 0x0000000180C23750-0x0000000180C237C0
				internal override void CopyVars(Elements_Base destination); // 0x0000000180C23440-0x0000000180C234D0
				internal override ControllerElementType GetEffectiveElementIdentifierType(ControllerElementIdentifier elementIdentifier); // 0x0000000180C24D90-0x0000000180C24F40
				internal override bool GetEffectiveAxisRange(ControllerElementIdentifier elementIdentifier, out AxisRange axisRange); // 0x0000000180C23EE0-0x0000000180C24260
			}
	
			[Serializable]
			[CustomClassObfuscation] // 0x00000001800D0530-0x00000001800D0560
			public abstract class Element : IDeepCloneable // TypeDefIndex: 6109
			{
				// Constructors
				protected Element(); // 0x000000018036B6C0-0x000000018036B6D0
	
				// Methods
				public abstract object DeepClone();
			}
	
			[Serializable]
			[CustomClassObfuscation] // 0x00000001800D0530-0x00000001800D0560
			public sealed class Button : Element // TypeDefIndex: 6110
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
				public Button(); // 0x0000000180392B20-0x0000000180392B40
	
				// Methods
				public override object DeepClone(); // 0x0000000180C21BA0-0x0000000180C21D50
			}
	
			[Serializable]
			[CustomClassObfuscation] // 0x00000001800D0530-0x00000001800D0560
			public sealed class Axis : Element // TypeDefIndex: 6111
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
				public Axis(); // 0x0000000180C21580-0x0000000180C215C0
	
				// Methods
				public override object DeepClone(); // 0x0000000180C21180-0x0000000180C21360
			}
	
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private sealed class yXuDCkhCyNabCiVDcabaQZoFldI : IEnumerable<Axis>, IEnumerator<Axis> // TypeDefIndex: 6112
			{
				// Fields
				private Axis aSrFEaALHwhGTdXfCdeUqgbwaZGO; // 0x10
				private int eLrUhJFgzEZElCzdKvcrgOLXLvL; // 0x18
				private int RQaeFqcJnaOYpZSBxtfUkVOjfOo; // 0x1C
				public Platform_OSX_Base gKPmvKLRxdGbmXiMfUeDjGbezUo; // 0x20
				public int UuBHjaWNzMERnxPaKiEarPHMoNP; // 0x28
	
				// Properties
				Axis CfEkCNzpsTELahprwjkzGdvFgYQb { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018036AC80-0x000000018036AC90 
				object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018036AC80-0x000000018036AC90 
	
				// Constructors
				[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
				public yXuDCkhCyNabCiVDcabaQZoFldI(int <>1__state); // 0x0000000180393A20-0x0000000180393A70
	
				// Methods
				[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
				IEnumerator<Axis> System.Collections.Generic.IEnumerable<Rewired.Data.Mapping.HardwareJoystickMap.Platform_OSX_Base.Axis>.GetEnumerator(); // 0x0000000180C82E90-0x0000000180C82F90
				[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
				IEnumerator IEnumerable.GetEnumerator(); // 0x0000000180C82E90-0x0000000180C82F90
				private bool MoveNext(); // 0x0000000180C82CE0-0x0000000180C82E90
				[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
				void IEnumerator.Reset(); // 0x0000000180C82F90-0x0000000180C82FE0
				void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			}
	
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private sealed class DCemplDjAOrRnMGrpnPUBhYToXq : IEnumerable<Button>, IEnumerator<Button> // TypeDefIndex: 6113
			{
				// Fields
				private Button aSrFEaALHwhGTdXfCdeUqgbwaZGO; // 0x10
				private int eLrUhJFgzEZElCzdKvcrgOLXLvL; // 0x18
				private int RQaeFqcJnaOYpZSBxtfUkVOjfOo; // 0x1C
				public Platform_OSX_Base gKPmvKLRxdGbmXiMfUeDjGbezUo; // 0x20
				public int kxwmRLvHnnFFMquAMAVEGqrKOkj; // 0x28
	
				// Properties
				Button gWqIzXkAxaffWVYBlScaueomugN { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018036AC80-0x000000018036AC90 
				object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018036AC80-0x000000018036AC90 
	
				// Constructors
				[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
				public DCemplDjAOrRnMGrpnPUBhYToXq(int <>1__state); // 0x0000000180393A20-0x0000000180393A70
	
				// Methods
				[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
				IEnumerator<Button> System.Collections.Generic.IEnumerable<Rewired.Data.Mapping.HardwareJoystickMap.Platform_OSX_Base.Button>.GetEnumerator(); // 0x0000000180C22440-0x0000000180C22540
				[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
				IEnumerator IEnumerable.GetEnumerator(); // 0x0000000180C22440-0x0000000180C22540
				private bool MoveNext(); // 0x0000000180C22290-0x0000000180C22440
				[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
				void IEnumerator.Reset(); // 0x0000000180C22540-0x0000000180C22590
				void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			}
	
			// Constructors
			public Platform_OSX_Base(); // 0x000000018037E800-0x000000018037E810
	
			// Methods
			internal override bool Matches(BridgedControllerHWInfo BridgedControllerHWInfo, bool strictMatch, out int variantIndex, out Rewired.Data.Mapping.HardwareJoystickMap.Platform platformMap); // 0x0000000180C35C60-0x0000000180C35D00
			internal IEnumerable<Axis> IterateAxes(); // 0x0000000180C35B70-0x0000000180C35BE0
			internal IEnumerable<Button> IterateButtons(); // 0x0000000180C35BE0-0x0000000180C35C60
			internal override string[] GetAxisNames(ControllerElementIdentifier[] identifiers); // 0x0000000180C34870-0x0000000180C34DD0
			internal override string[] GetEffectiveButtonNames(ControllerElementIdentifier[] identifiers); // 0x0000000180C35000-0x0000000180C352F0
			internal override bool IsElementIdentifierMapped(int elementIdentifierId); // 0x0000000180C35860-0x0000000180C35B70
			internal override void GetGameElementIdentifierIdMappings(out int[] buttons, out int[] axes); // 0x0000000180C352F0-0x0000000180C35860
			internal override AxisCalibrationData[] GetAxisCalibrationData(); // 0x0000000180C33D00-0x0000000180C34370
			internal override void GetAxisData(out AxisRange[] axisRanges, out HardwareAxisInfo[] axisInfos); // 0x0000000180C34370-0x0000000180C34870
			internal override void GetButtonData(out HardwareButtonInfo[] buttonInfos); // 0x0000000180C34DD0-0x0000000180C35000
			internal override ControllerElementType GetEffectiveElementIdentifierType(ControllerElementIdentifier elementIdentifier); // 0x000000018039BA80-0x000000018039BAA0
			internal override bool GetEffectiveAxisRange(ControllerElementIdentifier elementIdentifier, out AxisRange axisRange); // 0x000000018039B710-0x000000018039B740
			public override object DeepClone(); // 0x0000000180C33C90-0x0000000180C33D00
			internal override void CopyVars(Rewired.Data.Mapping.HardwareJoystickMap.Platform destination); // 0x0000000180C33B90-0x0000000180C33C90
		}
	
		[Serializable]
		[CustomClassObfuscation] // 0x00000001800D0530-0x00000001800D0560
		public sealed class Platform_OSX : Platform_OSX_Base // TypeDefIndex: 6114
		{
			// Fields
			public Platform_OSX_Base[] variants; // 0x28
	
			// Properties
			internal override IList<Rewired.Data.Mapping.HardwareJoystickMap.Platform> variants_base { get; } // 0x0000000180369B60-0x0000000180369B70 
	
			// Constructors
			public Platform_OSX(); // 0x000000018037E800-0x000000018037E810
	
			// Methods
			internal override bool Matches(BridgedControllerHWInfo BridgedControllerHWInfo, bool strictMatch, out int variantIndex, out Rewired.Data.Mapping.HardwareJoystickMap.Platform platformMap); // 0x0000000180C35F50-0x0000000180C36180
			public override object DeepClone(); // 0x0000000180C35EE0-0x0000000180C35F50
			internal override void CopyVars(Rewired.Data.Mapping.HardwareJoystickMap.Platform destination); // 0x0000000180C35D00-0x0000000180C35EE0
		}
	
		[Serializable]
		[CustomClassObfuscation] // 0x00000001800D0530-0x00000001800D0560
		public class Platform_Linux_Base : Rewired.Data.Mapping.HardwareJoystickMap.Platform // TypeDefIndex: 6115
		{
			// Fields
			public MatchingCriteria matchingCriteria; // 0x18
			public Elements elements; // 0x20
	
			// Properties
			internal override InputPlatform platform { get; } // 0x00000001805B70B0-0x00000001805B70C0 
			internal override bool hasData { get; } // 0x000000018039C450-0x000000018039C4C0 
			internal override bool disabled { get; } // 0x000000018039C440-0x000000018039C450 
			internal override bool isAllowed { get; } // 0x000000018039C4C0-0x000000018039C500 
			internal Axis[] Axes_orig { get; } // 0x000000018039C3E0-0x000000018039C3F0 
			internal Button[] Buttons_orig { get; } // 0x000000018039C3F0-0x000000018039C400 
			internal override IList<Rewired.Data.Mapping.HardwareJoystickMap.Platform> variants_base { get; } // 0x000000018035FCC0-0x000000018035FCD0 
			public override int assignedButtonCount { get; } // 0x000000018039C420-0x000000018039C440 
			public override int assignedAxisCount { get; } // 0x000000018039C400-0x000000018039C420 
			internal override Elements_Base elements_base { get; } // 0x000000018036AC70-0x000000018036AC80 
	
			// Nested types
			[Serializable]
			[CustomClassObfuscation] // 0x00000001800D0530-0x00000001800D0560
			public sealed class MatchingCriteria : MatchingCriteria_Base // TypeDefIndex: 6116
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
				internal override bool hasData { get; } // 0x0000000180C28480-0x0000000180C284B0 
				internal override bool isAllowed { get; } // 0x000000018039A1E0-0x000000018039A200 
				internal override int alternateElementCount { get; } // 0x000000018039A130-0x000000018039A140 
	
				// Nested types
				[Serializable]
				public sealed class ElementCount : MatchingCriteria_Base.ElementCount_Base // TypeDefIndex: 6117
				{
					// Fields
					public int hatCount; // 0x18
	
					// Constructors
					public ElementCount(); // 0x000000018037E800-0x000000018037E810
	
					// Methods
					public override object DeepClone(); // 0x0000000180C22FB0-0x0000000180C23020
					internal override void CopyVars(MatchingCriteria_Base.ElementCount_Base param_0000ce47); // 0x0000000180C22F10-0x0000000180C22FB0
					internal override bool Matches(BridgedControllerHWInfo param_0000ce48); // 0x0000000180393E00-0x0000000180393E60
				}
	
				// Constructors
				public MatchingCriteria(); // 0x000000018037E800-0x000000018037E810
	
				// Methods
				internal override bool Matches(BridgedControllerHWInfo bridgedControllerHWInfo, bool strictMatch); // 0x0000000180C27220-0x0000000180C273D0
				internal override ElementCount_Base GetAlternateElementCount(int index); // 0x0000000180C27100-0x0000000180C27180
				internal override bool ElementCountsMatch(BridgedControllerHWInfo bridgedControllerHWInfo, out bool alternateMatched); // 0x00000001803999F0-0x0000000180399A70
				private bool AnyNameMatches(BridgedControllerHWInfo bridgedControllerHWInfo); // 0x0000000180C262B0-0x0000000180C26590
				private bool NameMatches(string name, string[] names, bool useRegex); // 0x0000000180C27F90-0x0000000180C280E0
				public override object DeepClone(); // 0x0000000180C26DE0-0x0000000180C26E50
				internal override void CopyVars(MatchingCriteria_Base destination); // 0x0000000180C26680-0x0000000180C26800
			}
	
			[Serializable]
			[CustomClassObfuscation] // 0x00000001800D0530-0x00000001800D0560
			public sealed class Elements : Elements_Base // TypeDefIndex: 6118
			{
				// Fields
				public Axis[] axes; // 0x10
				public Button[] buttons; // 0x18
	
				// Properties
				public override int buttonCount { get; } // 0x00000001803951A0-0x00000001803951B0 
				public override int axisCount { get; } // 0x0000000180395190-0x00000001803951A0 
				internal IEnumerable<Axis> Axes { get; } // 0x0000000180C25820-0x0000000180C258A0 
				internal IEnumerable<Button> Buttons { get; } // 0x0000000180C258A0-0x0000000180C25920 
	
				// Nested types
				[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
				private sealed class DIHrPacQyBgThcmQCQjVyqcxCENB : IEnumerable<Axis>, IEnumerator<Axis> // TypeDefIndex: 6119
				{
					// Fields
					private Axis aSrFEaALHwhGTdXfCdeUqgbwaZGO; // 0x10
					private int eLrUhJFgzEZElCzdKvcrgOLXLvL; // 0x18
					private int RQaeFqcJnaOYpZSBxtfUkVOjfOo; // 0x1C
					public Elements gKPmvKLRxdGbmXiMfUeDjGbezUo; // 0x20
					public int dlKRMznfHnrnlQhwLbzadzNerVV; // 0x28
	
					// Properties
					Axis IyWeLCDkxJwNmWNnkaEjzUfTboM { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018036AC80-0x000000018036AC90 
					object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018036AC80-0x000000018036AC90 
	
					// Constructors
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					public DIHrPacQyBgThcmQCQjVyqcxCENB(int <>1__state); // 0x0000000180393A20-0x0000000180393A70
	
					// Methods
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					IEnumerator<Axis> System.Collections.Generic.IEnumerable<Rewired.Data.Mapping.HardwareJoystickMap.Platform_Linux_Base.Axis>.GetEnumerator(); // 0x0000000180C226E0-0x0000000180C227D0
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					IEnumerator IEnumerable.GetEnumerator(); // 0x0000000180C226E0-0x0000000180C227D0
					private bool MoveNext(); // 0x0000000180C22590-0x0000000180C226E0
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					void IEnumerator.Reset(); // 0x0000000180C227D0-0x0000000180C22820
					void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
				}
	
				[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
				private sealed class pDBLejlzqSJKuFhKdCHJMFCkWeC : IEnumerable<Button>, IEnumerator<Button> // TypeDefIndex: 6120
				{
					// Fields
					private Button aSrFEaALHwhGTdXfCdeUqgbwaZGO; // 0x10
					private int eLrUhJFgzEZElCzdKvcrgOLXLvL; // 0x18
					private int RQaeFqcJnaOYpZSBxtfUkVOjfOo; // 0x1C
					public Elements gKPmvKLRxdGbmXiMfUeDjGbezUo; // 0x20
					public int LROsuEcktDbMxHKcISgPlKzWdoWH; // 0x28
	
					// Properties
					Button AUongXdidwGNxOEzZZPzxKjkBG { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018036AC80-0x000000018036AC90 
					object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018036AC80-0x000000018036AC90 
	
					// Constructors
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					public pDBLejlzqSJKuFhKdCHJMFCkWeC(int <>1__state); // 0x0000000180393A20-0x0000000180393A70
	
					// Methods
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					IEnumerator<Button> System.Collections.Generic.IEnumerable<Rewired.Data.Mapping.HardwareJoystickMap.Platform_Linux_Base.Button>.GetEnumerator(); // 0x0000000180C37BE0-0x0000000180C37D30
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					IEnumerator IEnumerable.GetEnumerator(); // 0x0000000180C37BE0-0x0000000180C37D30
					private bool MoveNext(); // 0x0000000180C37A90-0x0000000180C37BE0
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					void IEnumerator.Reset(); // 0x0000000180C37D30-0x0000000180C37D80
					void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
				}
	
				// Constructors
				public Elements(); // 0x000000018037E800-0x000000018037E810
	
				// Methods
				internal Axis GetAxis(int axisIndex); // 0x0000000180C23890-0x0000000180C238E0
				internal override ControllerElementType GetEffectiveElementIdentifierType(ControllerElementIdentifier elementIdentifier); // 0x0000000180C24BD0-0x0000000180C24D90
				internal override bool GetEffectiveAxisRange(ControllerElementIdentifier elementIdentifier, out AxisRange axisRange); // 0x0000000180C24860-0x0000000180C24BD0
				public override object DeepClone(); // 0x0000000180C23590-0x0000000180C23600
				internal override void CopyVars(Elements_Base destination); // 0x0000000180C23310-0x0000000180C233B0
			}
	
			[Serializable]
			[CustomClassObfuscation] // 0x00000001800D0530-0x00000001800D0560
			public abstract class Element : IDeepCloneable // TypeDefIndex: 6121
			{
				// Constructors
				protected Element(); // 0x000000018036B6C0-0x000000018036B6D0
	
				// Methods
				public abstract object DeepClone();
				protected virtual void ImportVars(Element source); // 0x00000001803581E0-0x00000001803581F0
			}
	
			[Serializable]
			[CustomClassObfuscation] // 0x00000001800D0530-0x00000001800D0560
			public class Button : Element // TypeDefIndex: 6122
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
				public Button(); // 0x0000000180392B20-0x0000000180392B40
	
				// Methods
				public override object DeepClone(); // 0x0000000180C21E30-0x0000000180C21EA0
				protected override void ImportVars(Element source); // 0x0000000180C21F20-0x0000000180C22140
			}
	
			[Serializable]
			[CustomClassObfuscation] // 0x00000001800D0530-0x00000001800D0560
			public class Axis : Element // TypeDefIndex: 6123
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
				public Axis(); // 0x0000000180392630-0x0000000180392650
	
				// Methods
				public override object DeepClone(); // 0x0000000180C20FC0-0x0000000180C21030
				protected override void ImportVars(Element source); // 0x0000000180C21370-0x0000000180C21580
			}
	
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private sealed class JVXtMysADmgBqblnlNmzoXWmalO : IEnumerable<Axis>, IEnumerator<Axis> // TypeDefIndex: 6124
			{
				// Fields
				private Axis aSrFEaALHwhGTdXfCdeUqgbwaZGO; // 0x10
				private int eLrUhJFgzEZElCzdKvcrgOLXLvL; // 0x18
				private int RQaeFqcJnaOYpZSBxtfUkVOjfOo; // 0x1C
				public Platform_Linux_Base gKPmvKLRxdGbmXiMfUeDjGbezUo; // 0x20
				public int DQgGjJPVnlmajRZeDWFlRjZvapb; // 0x28
				public int LsKMPEjXVYvqLhjsSaDRCRIiJDb; // 0x2C
	
				// Properties
				Axis IyWeLCDkxJwNmWNnkaEjzUfTboM { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018036AC80-0x000000018036AC90 
				object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018036AC80-0x000000018036AC90 
	
				// Constructors
				[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
				public JVXtMysADmgBqblnlNmzoXWmalO(int <>1__state); // 0x0000000180393A20-0x0000000180393A70
	
				// Methods
				[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
				IEnumerator<Axis> System.Collections.Generic.IEnumerable<Rewired.Data.Mapping.HardwareJoystickMap.Platform_Linux_Base.Axis>.GetEnumerator(); // 0x0000000180C26170-0x0000000180C26260
				[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
				IEnumerator IEnumerable.GetEnumerator(); // 0x0000000180C26170-0x0000000180C26260
				private bool MoveNext(); // 0x0000000180C25FD0-0x0000000180C26170
				[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
				void IEnumerator.Reset(); // 0x0000000180C26260-0x0000000180C262B0
				void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			}
	
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private sealed class mjzhtqKOdNSquXxFsFenMpwUARnd : IEnumerable<Button>, IEnumerator<Button> // TypeDefIndex: 6125
			{
				// Fields
				private Button aSrFEaALHwhGTdXfCdeUqgbwaZGO; // 0x10
				private int eLrUhJFgzEZElCzdKvcrgOLXLvL; // 0x18
				private int RQaeFqcJnaOYpZSBxtfUkVOjfOo; // 0x1C
				public Platform_Linux_Base gKPmvKLRxdGbmXiMfUeDjGbezUo; // 0x20
				public int iyuUZlobwtvyFhpacnGPFjIAtfk; // 0x28
				public int wXaidXRczYWwFUHadDdLikkBUPj; // 0x2C
	
				// Properties
				Button AUongXdidwGNxOEzZZPzxKjkBG { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018036AC80-0x000000018036AC90 
				object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018036AC80-0x000000018036AC90 
	
				// Constructors
				[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
				public mjzhtqKOdNSquXxFsFenMpwUARnd(int <>1__state); // 0x0000000180393A20-0x0000000180393A70
	
				// Methods
				[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
				IEnumerator<Button> System.Collections.Generic.IEnumerable<Rewired.Data.Mapping.HardwareJoystickMap.Platform_Linux_Base.Button>.GetEnumerator(); // 0x0000000180C37950-0x0000000180C37A40
				[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
				IEnumerator IEnumerable.GetEnumerator(); // 0x0000000180C37950-0x0000000180C37A40
				private bool MoveNext(); // 0x0000000180C37790-0x0000000180C37950
				[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
				void IEnumerator.Reset(); // 0x0000000180C37A40-0x0000000180C37A90
				void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			}
	
			// Constructors
			public Platform_Linux_Base(); // 0x000000018037E800-0x000000018037E810
	
			// Methods
			internal override bool Matches(BridgedControllerHWInfo BridgedControllerHWInfo, bool strictMatch, out int variantIndex, out Rewired.Data.Mapping.HardwareJoystickMap.Platform platformMap); // 0x0000000180C2EC00-0x0000000180C2EC60
			internal override string[] GetAxisNames(ControllerElementIdentifier[] identifiers); // 0x0000000180C30080-0x0000000180C30370
			internal override string[] GetEffectiveButtonNames(ControllerElementIdentifier[] identifiers); // 0x0000000180C30570-0x0000000180C30850
			internal override bool IsElementIdentifierMapped(int elementIdentifierId); // 0x0000000180C30C20-0x0000000180C30FE0
			internal override void GetGameElementIdentifierIdMappings(out int[] buttons, out int[] axes); // 0x0000000180C30850-0x0000000180C30C20
			internal override AxisCalibrationData[] GetAxisCalibrationData(); // 0x0000000180C2F570-0x0000000180C2FB90
			internal override void GetAxisData(out AxisRange[] axisRanges, out HardwareAxisInfo[] axisInfos); // 0x0000000180C2FB90-0x0000000180C30080
			internal override void GetButtonData(out HardwareButtonInfo[] buttonInfos); // 0x0000000180C30370-0x0000000180C30570
			internal override ControllerElementType GetEffectiveElementIdentifierType(ControllerElementIdentifier elementIdentifier); // 0x000000018039BA80-0x000000018039BAA0
			internal override bool GetEffectiveAxisRange(ControllerElementIdentifier elementIdentifier, out AxisRange axisRange); // 0x000000018039B710-0x000000018039B740
			internal IEnumerable<Axis> IterateAxes(); // 0x0000000180C30FE0-0x0000000180C31060
			internal IEnumerable<Button> IterateButtons(); // 0x0000000180C31060-0x0000000180C310E0
			public override object DeepClone(); // 0x0000000180C2F500-0x0000000180C2F570
			internal override void CopyVars(Rewired.Data.Mapping.HardwareJoystickMap.Platform destination); // 0x0000000180C2F410-0x0000000180C2F500
		}
	
		[Serializable]
		[CustomClassObfuscation] // 0x00000001800D0530-0x00000001800D0560
		public sealed class Platform_Linux : Platform_Linux_Base // TypeDefIndex: 6126
		{
			// Fields
			public Platform_Linux_Base[] variants; // 0x28
	
			// Properties
			internal override IList<Rewired.Data.Mapping.HardwareJoystickMap.Platform> variants_base { get; } // 0x0000000180369B60-0x0000000180369B70 
	
			// Constructors
			public Platform_Linux(); // 0x000000018037E800-0x000000018037E810
	
			// Methods
			internal override bool Matches(BridgedControllerHWInfo BridgedControllerHWInfo, bool strictMatch, out int variantIndex, out Rewired.Data.Mapping.HardwareJoystickMap.Platform platformMap); // 0x0000000180C312F0-0x0000000180C314A0
			public override object DeepClone(); // 0x0000000180C31280-0x0000000180C312F0
			internal override void CopyVars(Rewired.Data.Mapping.HardwareJoystickMap.Platform destination); // 0x0000000180C310E0-0x0000000180C31280
		}
	
		[Serializable]
		[CustomClassObfuscation] // 0x00000001800D0530-0x00000001800D0560
		public class Platform_WindowsUWP_Base : Rewired.Data.Mapping.HardwareJoystickMap.Platform // TypeDefIndex: 6127
		{
			// Fields
			public MatchingCriteria matchingCriteria; // 0x18
			public Elements elements; // 0x20
	
			// Properties
			internal override InputPlatform platform { get; } // 0x000000018035E180-0x000000018035E190 
			internal override bool hasData { get; } // 0x000000018039C450-0x000000018039C4C0 
			internal override bool disabled { get; } // 0x000000018039C440-0x000000018039C450 
			internal override bool isAllowed { get; } // 0x000000018039C4C0-0x000000018039C500 
			internal Axis[] Axes_orig { get; } // 0x000000018039C3E0-0x000000018039C3F0 
			internal Button[] Buttons_orig { get; } // 0x000000018039C3F0-0x000000018039C400 
			internal override IList<Rewired.Data.Mapping.HardwareJoystickMap.Platform> variants_base { get; } // 0x000000018035FCC0-0x000000018035FCD0 
			public override int assignedButtonCount { get; } // 0x000000018039C420-0x000000018039C440 
			public override int assignedAxisCount { get; } // 0x000000018039C400-0x000000018039C420 
			internal override Elements_Base elements_base { get; } // 0x000000018036AC70-0x000000018036AC80 
	
			// Nested types
			[Serializable]
			[CustomClassObfuscation] // 0x00000001800D0530-0x00000001800D0560
			public sealed class MatchingCriteria : MatchingCriteria_Base // TypeDefIndex: 6128
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
				internal override bool hasData { get; } // 0x000000018039A140-0x000000018039A170 
				internal override bool isAllowed { get; } // 0x000000018039A1E0-0x000000018039A200 
				internal override int alternateElementCount { get; } // 0x000000018039A130-0x000000018039A140 
	
				// Nested types
				[Serializable]
				public sealed class ElementCount : MatchingCriteria_Base.ElementCount_Base // TypeDefIndex: 6129
				{
					// Fields
					public int hatCount; // 0x18
	
					// Constructors
					public ElementCount(); // 0x000000018037E800-0x000000018037E810
	
					// Methods
					public override object DeepClone(); // 0x0000000180393D90-0x0000000180393E00
					internal override void CopyVars(MatchingCriteria_Base.ElementCount_Base param_0000ce74); // 0x0000000180393D20-0x0000000180393D90
					internal override bool Matches(BridgedControllerHWInfo param_0000ce75); // 0x0000000180393E00-0x0000000180393E60
				}
	
				// Constructors
				public MatchingCriteria(); // 0x000000018037E800-0x000000018037E810
	
				// Methods
				internal override bool Matches(BridgedControllerHWInfo bridgedControllerHWInfo, bool strictMatch); // 0x0000000180399AD0-0x0000000180399C70
				internal override ElementCount_Base GetAlternateElementCount(int index); // 0x0000000180399A80-0x0000000180399AD0
				internal override bool ElementCountsMatch(BridgedControllerHWInfo bridgedControllerHWInfo, out bool alternateMatched); // 0x00000001803999F0-0x0000000180399A70
				private bool AnyNameMatches(BridgedControllerHWInfo bridgedControllerHWInfo); // 0x0000000180399490-0x0000000180399610
				private bool NameMatches(string name, string[] names, bool useRegex); // 0x0000000180399FE0-0x000000018039A130
				public override object DeepClone(); // 0x0000000180399910-0x0000000180399980
				internal override void CopyVars(MatchingCriteria_Base destination); // 0x0000000180399760-0x00000001803998A0
			}
	
			[Serializable]
			[CustomClassObfuscation] // 0x00000001800D0530-0x00000001800D0560
			public sealed class Elements : Elements_Base // TypeDefIndex: 6130
			{
				// Fields
				public Axis[] axes; // 0x10
				public Button[] buttons; // 0x18
	
				// Properties
				public override int buttonCount { get; } // 0x00000001803951A0-0x00000001803951B0 
				public override int axisCount { get; } // 0x0000000180395190-0x00000001803951A0 
				internal IEnumerable<Axis> Axes { get; } // 0x0000000180395070-0x00000001803950F0 
				internal IEnumerable<Button> Buttons { get; } // 0x00000001803950F0-0x0000000180395190 
	
				// Nested types
				[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
				private sealed class nwCHMmfvKrhzxNOWcqsRjSmtaxr : IEnumerable<Axis>, IEnumerator<Axis> // TypeDefIndex: 6131
				{
					// Fields
					private Axis aSrFEaALHwhGTdXfCdeUqgbwaZGO; // 0x10
					private int eLrUhJFgzEZElCzdKvcrgOLXLvL; // 0x18
					private int RQaeFqcJnaOYpZSBxtfUkVOjfOo; // 0x1C
					public Elements gKPmvKLRxdGbmXiMfUeDjGbezUo; // 0x20
					public int kSYldKdWyvCIIjgmCQtWwHDiLAK; // 0x28
	
					// Properties
					Axis tdtAarGoghHJrxNnwDAJGdxCCVez { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018036AC80-0x000000018036AC90 
					object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018036AC80-0x000000018036AC90 
	
					// Constructors
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					public nwCHMmfvKrhzxNOWcqsRjSmtaxr(int <>1__state); // 0x0000000180393A20-0x0000000180393A70
	
					// Methods
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					IEnumerator<Axis> System.Collections.Generic.IEnumerable<Rewired.Data.Mapping.HardwareJoystickMap.Platform_WindowsUWP_Base.Axis>.GetEnumerator(); // 0x00000001803C0E70-0x00000001803C0F70
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					IEnumerator IEnumerable.GetEnumerator(); // 0x00000001803C0E70-0x00000001803C0F70
					private bool MoveNext(); // 0x00000001803C0D20-0x00000001803C0E70
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					void IEnumerator.Reset(); // 0x00000001803C0F70-0x00000001803C0FC0
					void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
				}
	
				[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
				private sealed class DQfCIwhTbccVauJApPceFgLEHYh : IEnumerable<Button>, IEnumerator<Button> // TypeDefIndex: 6132
				{
					// Fields
					private Button aSrFEaALHwhGTdXfCdeUqgbwaZGO; // 0x10
					private int eLrUhJFgzEZElCzdKvcrgOLXLvL; // 0x18
					private int RQaeFqcJnaOYpZSBxtfUkVOjfOo; // 0x1C
					public Elements gKPmvKLRxdGbmXiMfUeDjGbezUo; // 0x20
					public int OBIFRTAPpnPisGnYmvUQtawYqEm; // 0x28
	
					// Properties
					Button SQRVqZvvmpfiJnzDZFNPdPPwYsV { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018036AC80-0x000000018036AC90 
					object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018036AC80-0x000000018036AC90 
	
					// Constructors
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					public DQfCIwhTbccVauJApPceFgLEHYh(int <>1__state); // 0x0000000180393A20-0x0000000180393A70
	
					// Methods
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					IEnumerator<Button> System.Collections.Generic.IEnumerable<Rewired.Data.Mapping.HardwareJoystickMap.Platform_WindowsUWP_Base.Button>.GetEnumerator(); // 0x0000000180393BE0-0x0000000180393CD0
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					IEnumerator IEnumerable.GetEnumerator(); // 0x0000000180393BE0-0x0000000180393CD0
					private bool MoveNext(); // 0x0000000180393A70-0x0000000180393BE0
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					void IEnumerator.Reset(); // 0x0000000180393CD0-0x0000000180393D20
					void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
				}
	
				// Constructors
				public Elements(); // 0x000000018037E800-0x000000018037E810
	
				// Methods
				internal Axis GetAxis(int axisIndex); // 0x0000000180394240-0x00000001803942C0
				internal override ControllerElementType GetEffectiveElementIdentifierType(ControllerElementIdentifier elementIdentifier); // 0x0000000180394EC0-0x0000000180395070
				internal override bool GetEffectiveAxisRange(ControllerElementIdentifier elementIdentifier, out AxisRange axisRange); // 0x00000001803942C0-0x0000000180394610
				public override object DeepClone(); // 0x0000000180394160-0x00000001803941D0
				internal override void CopyVars(Elements_Base destination); // 0x0000000180393ED0-0x0000000180393F90
			}
	
			[Serializable]
			[CustomClassObfuscation] // 0x00000001800D0530-0x00000001800D0560
			public abstract class Element : IDeepCloneable // TypeDefIndex: 6133
			{
				// Constructors
				protected Element(); // 0x000000018036B6C0-0x000000018036B6D0
	
				// Methods
				public abstract object DeepClone();
				protected virtual void ImportVars(Element source); // 0x00000001803581E0-0x00000001803581F0
			}
	
			[Serializable]
			[CustomClassObfuscation] // 0x00000001800D0530-0x00000001800D0560
			public class Button : Element // TypeDefIndex: 6134
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
				public Button(); // 0x0000000180392B20-0x0000000180392B40
	
				// Methods
				public override object DeepClone(); // 0x00000001803928E0-0x0000000180392950
				protected override void ImportVars(Element source); // 0x0000000180392950-0x0000000180392B20
			}
	
			[Serializable]
			[CustomClassObfuscation] // 0x00000001800D0530-0x00000001800D0560
			public class Axis : Element // TypeDefIndex: 6135
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
				public Axis(); // 0x0000000180392630-0x0000000180392650
	
				// Methods
				public override object DeepClone(); // 0x00000001803923F0-0x0000000180392460
				protected override void ImportVars(Element source); // 0x0000000180392460-0x0000000180392630
			}
	
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private sealed class nscRQtMBeThliEPyOEvRTjibBxg : IEnumerable<Axis>, IEnumerator<Axis> // TypeDefIndex: 6136
			{
				// Fields
				private Axis aSrFEaALHwhGTdXfCdeUqgbwaZGO; // 0x10
				private int eLrUhJFgzEZElCzdKvcrgOLXLvL; // 0x18
				private int RQaeFqcJnaOYpZSBxtfUkVOjfOo; // 0x1C
				public Platform_WindowsUWP_Base gKPmvKLRxdGbmXiMfUeDjGbezUo; // 0x20
				public int TQritcNoEDtsifJmeHQbGilvMSXw; // 0x28
				public int jOsEvROrKOHsSsVpiGSeVsByZKM; // 0x2C
	
				// Properties
				Axis tdtAarGoghHJrxNnwDAJGdxCCVez { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018036AC80-0x000000018036AC90 
				object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018036AC80-0x000000018036AC90 
	
				// Constructors
				[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
				public nscRQtMBeThliEPyOEvRTjibBxg(int <>1__state); // 0x0000000180393A20-0x0000000180393A70
	
				// Methods
				[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
				IEnumerator<Axis> System.Collections.Generic.IEnumerable<Rewired.Data.Mapping.HardwareJoystickMap.Platform_WindowsUWP_Base.Axis>.GetEnumerator(); // 0x00000001803C0BE0-0x00000001803C0CD0
				[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
				IEnumerator IEnumerable.GetEnumerator(); // 0x00000001803C0BE0-0x00000001803C0CD0
				private bool MoveNext(); // 0x00000001803C0A40-0x00000001803C0BE0
				[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
				void IEnumerator.Reset(); // 0x00000001803C0CD0-0x00000001803C0D20
				void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			}
	
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private sealed class lexDGCjoDqwlINLyXhjMbKhFcyJA : IEnumerable<Button>, IEnumerator<Button> // TypeDefIndex: 6137
			{
				// Fields
				private Button aSrFEaALHwhGTdXfCdeUqgbwaZGO; // 0x10
				private int eLrUhJFgzEZElCzdKvcrgOLXLvL; // 0x18
				private int RQaeFqcJnaOYpZSBxtfUkVOjfOo; // 0x1C
				public Platform_WindowsUWP_Base gKPmvKLRxdGbmXiMfUeDjGbezUo; // 0x20
				public int BhQEcLIRcwjnROFLXOtltjWAlSO; // 0x28
				public int NUBZJGqvKDcklmyLuibVVhGEAiNe; // 0x2C
	
				// Properties
				Button SQRVqZvvmpfiJnzDZFNPdPPwYsV { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018036AC80-0x000000018036AC90 
				object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018036AC80-0x000000018036AC90 
	
				// Constructors
				[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
				public lexDGCjoDqwlINLyXhjMbKhFcyJA(int <>1__state); // 0x0000000180393A20-0x0000000180393A70
	
				// Methods
				[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
				IEnumerator<Button> System.Collections.Generic.IEnumerable<Rewired.Data.Mapping.HardwareJoystickMap.Platform_WindowsUWP_Base.Button>.GetEnumerator(); // 0x00000001803C0910-0x00000001803C09F0
				[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
				IEnumerator IEnumerable.GetEnumerator(); // 0x00000001803C0910-0x00000001803C09F0
				private bool MoveNext(); // 0x00000001803C0770-0x00000001803C0910
				[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
				void IEnumerator.Reset(); // 0x00000001803C09F0-0x00000001803C0A40
				void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			}
	
			// Constructors
			public Platform_WindowsUWP_Base(); // 0x000000018037E800-0x000000018037E810
	
			// Methods
			internal override bool Matches(BridgedControllerHWInfo BridgedControllerHWInfo, bool strictMatch, out int variantIndex, out Rewired.Data.Mapping.HardwareJoystickMap.Platform platformMap); // 0x000000018039C350-0x000000018039C3E0
			internal override string[] GetAxisNames(ControllerElementIdentifier[] identifiers); // 0x000000018039B220-0x000000018039B500
			internal override string[] GetEffectiveButtonNames(ControllerElementIdentifier[] identifiers); // 0x000000018039B740-0x000000018039BA80
			internal override bool IsElementIdentifierMapped(int elementIdentifierId); // 0x000000018039BE70-0x000000018039C250
			internal override void GetGameElementIdentifierIdMappings(out int[] buttons, out int[] axes); // 0x000000018039BAA0-0x000000018039BE70
			internal override AxisCalibrationData[] GetAxisCalibrationData(); // 0x000000018039A680-0x000000018039AD30
			internal override void GetAxisData(out AxisRange[] axisRanges, out HardwareAxisInfo[] axisInfos); // 0x000000018039AD30-0x000000018039B220
			internal override void GetButtonData(out HardwareButtonInfo[] buttonInfos); // 0x000000018039B500-0x000000018039B710
			internal override ControllerElementType GetEffectiveElementIdentifierType(ControllerElementIdentifier elementIdentifier); // 0x000000018039BA80-0x000000018039BAA0
			internal override bool GetEffectiveAxisRange(ControllerElementIdentifier elementIdentifier, out AxisRange axisRange); // 0x000000018039B710-0x000000018039B740
			internal IEnumerable<Axis> IterateAxes(); // 0x000000018039C250-0x000000018039C2D0
			internal IEnumerable<Button> IterateButtons(); // 0x000000018039C2D0-0x000000018039C350
			public override object DeepClone(); // 0x000000018039A610-0x000000018039A680
			internal override void CopyVars(Rewired.Data.Mapping.HardwareJoystickMap.Platform destination); // 0x000000018039A520-0x000000018039A610
		}
	
		[Serializable]
		[CustomClassObfuscation] // 0x00000001800D0530-0x00000001800D0560
		public sealed class Platform_WindowsUWP : Platform_WindowsUWP_Base // TypeDefIndex: 6138
		{
			// Fields
			public Platform_WindowsUWP_Base[] variants; // 0x28
	
			// Properties
			internal override IList<Rewired.Data.Mapping.HardwareJoystickMap.Platform> variants_base { get; } // 0x0000000180369B60-0x0000000180369B70 
	
			// Constructors
			public Platform_WindowsUWP(); // 0x000000018037E800-0x000000018037E810
	
			// Methods
			internal override bool Matches(BridgedControllerHWInfo BridgedControllerHWInfo, bool strictMatch, out int variantIndex, out Rewired.Data.Mapping.HardwareJoystickMap.Platform platformMap); // 0x000000018039C720-0x000000018039C950
			public override object DeepClone(); // 0x000000018039C6B0-0x000000018039C720
			internal override void CopyVars(Rewired.Data.Mapping.HardwareJoystickMap.Platform destination); // 0x000000018039C500-0x000000018039C6B0
		}
	
		[Serializable]
		[CustomClassObfuscation] // 0x00000001800D0530-0x00000001800D0560
		public class Platform_Fallback_Base : Rewired.Data.Mapping.HardwareJoystickMap.Platform // TypeDefIndex: 6139
		{
			// Fields
			public MatchingCriteria matchingCriteria; // 0x18
			public Elements elements; // 0x20
	
			// Properties
			public override int assignedButtonCount { get; } // 0x000000018039C420-0x000000018039C440 
			public override int assignedAxisCount { get; } // 0x000000018039C400-0x000000018039C420 
			internal override InputPlatform platform { get; } // 0x00000001809ED5C0-0x00000001809ED5D0 
			internal Axis[] Axes_orig { get; } // 0x000000018039C3E0-0x000000018039C3F0 
			internal Button[] Buttons_orig { get; } // 0x000000018039C3F0-0x000000018039C400 
			internal override bool hasData { get; } // 0x0000000180C2C880-0x0000000180C2C900 
			internal override bool disabled { get; } // 0x000000018039C440-0x000000018039C450 
			internal override bool isAllowed { get; } // 0x000000018039C4C0-0x000000018039C500 
			internal override Elements_Base elements_base { get; } // 0x000000018036AC70-0x000000018036AC80 
			internal override IList<Rewired.Data.Mapping.HardwareJoystickMap.Platform> variants_base { get; } // 0x000000018035FCC0-0x000000018035FCD0 
	
			// Nested types
			[Serializable]
			[CustomClassObfuscation] // 0x00000001800D0530-0x00000001800D0560
			public sealed class MatchingCriteria : MatchingCriteria_Base // TypeDefIndex: 6140
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
				internal override bool hasData { get; } // 0x0000000180C284B0-0x0000000180C284E0 
				internal override bool isAllowed { get; } // 0x0000000180C28510-0x0000000180C285E0 
				internal override int alternateElementCount { get; } // 0x000000018035FCC0-0x000000018035FCD0 
	
				// Constructors
				public MatchingCriteria(); // 0x000000018037E800-0x000000018037E810
	
				// Methods
				internal override bool Matches(BridgedControllerHWInfo bridgedControllerHWInfo, bool strictMatch); // 0x0000000180C27D60-0x0000000180C27F90
				internal override ElementCount_Base GetAlternateElementCount(int index); // 0x000000018035FCC0-0x000000018035FCD0
				internal override bool ElementCountsMatch(BridgedControllerHWInfo bridgedControllerHWInfo, out bool alternateMatched); // 0x0000000180399A70-0x0000000180399A80
				public override object DeepClone(); // 0x0000000180C26F30-0x0000000180C26FA0
				internal override void CopyVars(MatchingCriteria_Base destination); // 0x0000000180C26590-0x0000000180C26680
			}
	
			[Serializable]
			[CustomClassObfuscation] // 0x00000001800D0530-0x00000001800D0560
			public sealed class Elements : Elements_Base // TypeDefIndex: 6141
			{
				// Fields
				public Axis[] axes; // 0x10
				public Button[] buttons; // 0x18
	
				// Properties
				public override int buttonCount { get; } // 0x00000001803951A0-0x00000001803951B0 
				public override int axisCount { get; } // 0x0000000180395190-0x00000001803951A0 
	
				// Constructors
				public Elements(); // 0x000000018037E800-0x000000018037E810
	
				// Methods
				internal override ControllerElementType GetEffectiveElementIdentifierType(ControllerElementIdentifier elementIdentifier); // 0x0000000180C254B0-0x0000000180C25680
				internal override bool GetEffectiveAxisRange(ControllerElementIdentifier elementIdentifier, out AxisRange axisRange); // 0x0000000180C24590-0x0000000180C24860
				public override object DeepClone(); // 0x0000000180C236E0-0x0000000180C23750
				internal override void CopyVars(Elements_Base destination); // 0x0000000180C234D0-0x0000000180C23590
			}
	
			[Serializable]
			[CustomClassObfuscation] // 0x00000001800D0530-0x00000001800D0560
			public class CustomCalculationSourceData : IDeepCloneable // TypeDefIndex: 6142
			{
				// Fields
				public int sourceType; // 0x10
				public int sourceElement; // 0x14
				public AxisRange sourceAxisRange; // 0x18
				public float deadzone; // 0x1C
				public bool invert; // 0x20
	
				// Constructors
				public CustomCalculationSourceData(); // 0x000000018036B6C0-0x000000018036B6D0
	
				// Methods
				public object DeepClone(); // 0x0000000180C22150-0x0000000180C221F0
			}
	
			[Serializable]
			[CustomClassObfuscation] // 0x00000001800D0530-0x00000001800D0560
			public abstract class Element : IDeepCloneable // TypeDefIndex: 6143
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
				protected Element(); // 0x000000018036B6C0-0x000000018036B6D0
	
				// Methods
				public abstract object DeepClone();
				protected virtual void CopyVars(Element destination); // 0x0000000180C23020-0x0000000180C230D0
			}
	
			[Serializable]
			[CustomClassObfuscation] // 0x00000001800D0530-0x00000001800D0560
			public sealed class Button : Element // TypeDefIndex: 6144
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
				public Button(); // 0x000000018036B6C0-0x000000018036B6D0
	
				// Methods
				public override object DeepClone(); // 0x0000000180C21EA0-0x0000000180C21F10
				protected override void CopyVars(Element destination); // 0x0000000180C21620-0x0000000180C21880
			}
	
			[Serializable]
			[CustomClassObfuscation] // 0x00000001800D0530-0x00000001800D0560
			public sealed class Axis : Element // TypeDefIndex: 6145
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
				public Axis(); // 0x000000018036B6C0-0x000000018036B6D0
	
				// Methods
				public override object DeepClone(); // 0x0000000180C21110-0x0000000180C21180
				protected override void CopyVars(Element destination); // 0x0000000180C20A00-0x0000000180C20B90
			}
	
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private sealed class ErHZklvvrcCHrKkOykbKJBFdqgJ : IEnumerable<Axis>, IEnumerator<Axis> // TypeDefIndex: 6146
			{
				// Fields
				private Axis aSrFEaALHwhGTdXfCdeUqgbwaZGO; // 0x10
				private int eLrUhJFgzEZElCzdKvcrgOLXLvL; // 0x18
				private int RQaeFqcJnaOYpZSBxtfUkVOjfOo; // 0x1C
				public Platform_Fallback_Base gKPmvKLRxdGbmXiMfUeDjGbezUo; // 0x20
				public int vXugbulKaeMXKgsqpYRYwHmmuO; // 0x28
	
				// Properties
				Axis APBRTmRAFikEAWsXGWOvJhDfldZ { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018036AC80-0x000000018036AC90 
				object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018036AC80-0x000000018036AC90 
	
				// Constructors
				[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
				public ErHZklvvrcCHrKkOykbKJBFdqgJ(int <>1__state); // 0x0000000180393A20-0x0000000180393A70
	
				// Methods
				[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
				IEnumerator<Axis> System.Collections.Generic.IEnumerable<Rewired.Data.Mapping.HardwareJoystickMap.Platform_Fallback_Base.Axis>.GetEnumerator(); // 0x0000000180C25B70-0x0000000180C25C60
				[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
				IEnumerator IEnumerable.GetEnumerator(); // 0x0000000180C25B70-0x0000000180C25C60
				private bool MoveNext(); // 0x0000000180C259A0-0x0000000180C25B70
				[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
				void IEnumerator.Reset(); // 0x0000000180C25C60-0x0000000180C25CB0
				void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			}
	
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private sealed class DgJmiYTgHFMUhkOrrYCFGmsfYjm : IEnumerable<Button>, IEnumerator<Button> // TypeDefIndex: 6147
			{
				// Fields
				private Button aSrFEaALHwhGTdXfCdeUqgbwaZGO; // 0x10
				private int eLrUhJFgzEZElCzdKvcrgOLXLvL; // 0x18
				private int RQaeFqcJnaOYpZSBxtfUkVOjfOo; // 0x1C
				public Platform_Fallback_Base gKPmvKLRxdGbmXiMfUeDjGbezUo; // 0x20
				public int flfjUtxcbGKcbhEtrvOnFcBaRVP; // 0x28
	
				// Properties
				Button xGzhxiGbBgGgxbQucAjtFxJlfLEF { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018036AC80-0x000000018036AC90 
				object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018036AC80-0x000000018036AC90 
	
				// Constructors
				[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
				public DgJmiYTgHFMUhkOrrYCFGmsfYjm(int <>1__state); // 0x0000000180393A20-0x0000000180393A70
	
				// Methods
				[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
				IEnumerator<Button> System.Collections.Generic.IEnumerable<Rewired.Data.Mapping.HardwareJoystickMap.Platform_Fallback_Base.Button>.GetEnumerator(); // 0x0000000180C22DD0-0x0000000180C22EC0
				[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
				IEnumerator IEnumerable.GetEnumerator(); // 0x0000000180C22DD0-0x0000000180C22EC0
				private bool MoveNext(); // 0x0000000180C22C10-0x0000000180C22DD0
				[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
				void IEnumerator.Reset(); // 0x0000000180C22EC0-0x0000000180C22F10
				void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			}
	
			// Constructors
			public Platform_Fallback_Base(); // 0x000000018037E800-0x000000018037E810
	
			// Methods
			internal override bool Matches(BridgedControllerHWInfo BridgedControllerHWInfo, bool strictMatch, out int variantIndex, out Rewired.Data.Mapping.HardwareJoystickMap.Platform platformMap); // 0x0000000180C2C800-0x0000000180C2C880
			internal IEnumerable<Axis> IterateAxes(); // 0x0000000180C2C700-0x0000000180C2C780
			internal IEnumerable<Button> IterateButtons(); // 0x0000000180C2C780-0x0000000180C2C800
			internal override string[] GetAxisNames(ControllerElementIdentifier[] identifiers); // 0x0000000180C2B7A0-0x0000000180C2BA80
			internal override string[] GetEffectiveButtonNames(ControllerElementIdentifier[] identifiers); // 0x0000000180C2BCD0-0x0000000180C2BFB0
			internal override bool IsElementIdentifierMapped(int elementIdentifierId); // 0x0000000180C2C340-0x0000000180C2C700
			internal override void GetGameElementIdentifierIdMappings(out int[] buttons, out int[] axes); // 0x0000000180C2BFB0-0x0000000180C2C340
			internal override AxisCalibrationData[] GetAxisCalibrationData(); // 0x0000000180C2ABB0-0x0000000180C2B280
			internal override void GetAxisData(out AxisRange[] axisRanges, out HardwareAxisInfo[] axisInfos); // 0x0000000180C2B280-0x0000000180C2B7A0
			internal override void GetButtonData(out HardwareButtonInfo[] buttonInfos); // 0x0000000180C2BA80-0x0000000180C2BCD0
			internal override ControllerElementType GetEffectiveElementIdentifierType(ControllerElementIdentifier elementIdentifier); // 0x000000018039BA80-0x000000018039BAA0
			internal override bool GetEffectiveAxisRange(ControllerElementIdentifier elementIdentifier, out AxisRange axisRange); // 0x000000018039B710-0x000000018039B740
			public override object DeepClone(); // 0x0000000180C2AB40-0x0000000180C2ABB0
			internal override void CopyVars(Rewired.Data.Mapping.HardwareJoystickMap.Platform destination); // 0x0000000180C2A9E0-0x0000000180C2AB40
		}
	
		[Serializable]
		[CustomClassObfuscation] // 0x00000001800D0530-0x00000001800D0560
		public sealed class Platform_Fallback : Platform_Fallback_Base // TypeDefIndex: 6148
		{
			// Fields
			public Platform_Fallback_Base[] variants; // 0x28
	
			// Properties
			internal override IList<Rewired.Data.Mapping.HardwareJoystickMap.Platform> variants_base { get; } // 0x0000000180369B60-0x0000000180369B70 
	
			// Constructors
			public Platform_Fallback(); // 0x000000018037E800-0x000000018037E810
	
			// Methods
			internal override bool Matches(BridgedControllerHWInfo BridgedControllerHWInfo, bool strictMatch, out int variantIndex, out Rewired.Data.Mapping.HardwareJoystickMap.Platform platformMap); // 0x0000000180C2CB40-0x0000000180C2CD60
			public override object DeepClone(); // 0x0000000180C2CAD0-0x0000000180C2CB40
			internal override void CopyVars(Rewired.Data.Mapping.HardwareJoystickMap.Platform destination); // 0x0000000180C2C900-0x0000000180C2CAD0
		}
	
		[Serializable]
		[CustomClassObfuscation] // 0x00000001800D0530-0x00000001800D0560
		public abstract class Platform_Custom : Rewired.Data.Mapping.HardwareJoystickMap.Platform // TypeDefIndex: 6149
		{
			// Properties
			internal abstract Axis[] Axes { get; }
			internal abstract Button[] Buttons { get; }
	
			// Nested types
			[Serializable]
			[CustomClassObfuscation] // 0x00000001800D0530-0x00000001800D0560
			public abstract class MatchingCriteria : MatchingCriteria_Base // TypeDefIndex: 6150
			{
				// Fields
				public bool alwaysMatch; // 0x28
	
				// Properties
				internal override bool hasData { get; } // 0x0000000180C28430-0x0000000180C28450 
				internal override bool isAllowed { get; } // 0x000000018039A1E0-0x000000018039A200 
				internal override int alternateElementCount { get; } // 0x000000018035FCC0-0x000000018035FCD0 
	
				// Constructors
				protected MatchingCriteria(); // 0x000000018037E800-0x000000018037E810
	
				// Methods
				internal override bool Matches(BridgedControllerHWInfo bridgedControllerHWInfo, bool strictMatch); // 0x0000000180C27180-0x0000000180C27220
				internal override ElementCount_Base GetAlternateElementCount(int index); // 0x000000018035FCC0-0x000000018035FCD0
				internal override bool ElementCountsMatch(BridgedControllerHWInfo bridgedControllerHWInfo, out bool alternateMatched); // 0x0000000180399A70-0x0000000180399A80
				internal override void CopyVars(MatchingCriteria_Base destination); // 0x0000000180C26800-0x0000000180C26920
			}
	
			[Serializable]
			[CustomClassObfuscation] // 0x00000001800D0530-0x00000001800D0560
			public abstract class Elements : Elements_Base // TypeDefIndex: 6151
			{
				// Constructors
				protected Elements(); // 0x000000018037E800-0x000000018037E810
			}
	
			[Serializable]
			[CustomClassObfuscation] // 0x00000001800D0530-0x00000001800D0560
			public class CustomCalculationSourceData : IDeepCloneable // TypeDefIndex: 6152
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
				public CustomCalculationSourceData(); // 0x000000018036B6C0-0x000000018036B6D0
	
				// Methods
				public object DeepClone(); // 0x0000000180C221F0-0x0000000180C22290
			}
	
			[Serializable]
			[CustomClassObfuscation] // 0x00000001800D0530-0x00000001800D0560
			public abstract class Element : IDeepCloneable // TypeDefIndex: 6153
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
				protected Element(); // 0x000000018036B6C0-0x000000018036B6D0
	
				// Methods
				internal virtual void CopyVars(Element destination); // 0x0000000180C230D0-0x0000000180C23170
				public abstract object DeepClone();
			}
	
			[Serializable]
			[CustomClassObfuscation] // 0x00000001800D0530-0x00000001800D0560
			public abstract class Button : Element // TypeDefIndex: 6154
			{
				// Fields
				public Pole sourceAxisPole; // 0x38
				public bool requireMultipleButtons; // 0x3C
				public int[] requiredButtons; // 0x40
				public bool ignoreIfButtonsActive; // 0x48
				public int[] ignoreIfButtonsActiveButtons; // 0x50
				public HardwareButtonInfo buttonInfo; // 0x58
	
				// Constructors
				protected Button(); // 0x000000018036B6C0-0x000000018036B6D0
	
				// Methods
				internal override void CopyVars(Element destination); // 0x0000000180C21880-0x0000000180C21A80
			}
	
			[Serializable]
			[CustomClassObfuscation] // 0x00000001800D0530-0x00000001800D0560
			public abstract class Axis : Element // TypeDefIndex: 6155
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
				protected Axis(); // 0x000000018036B6C0-0x000000018036B6D0
	
				// Methods
				internal override void CopyVars(Element destination); // 0x0000000180C20CD0-0x0000000180C20F50
			}
	
			// Constructors
			protected Platform_Custom(); // 0x000000018037E800-0x000000018037E810
	
			// Methods
			internal abstract IEnumerable<Axis> IterateAxes();
			internal abstract IEnumerable<Button> IterateButtons();
			internal override void CopyVars(Rewired.Data.Mapping.HardwareJoystickMap.Platform destination); // 0x00000001803581E0-0x00000001803581F0
		}
	
		[Serializable]
		[CustomClassObfuscation] // 0x00000001800D0530-0x00000001800D0560
		public class Platform_Ouya_Base : Platform_Custom // TypeDefIndex: 6156
		{
			// Fields
			public MatchingCriteria matchingCriteria; // 0x18
			public Elements elements; // 0x20
			private Axis[] _axesOrigGame; // 0x28
			private Button[] _buttonsOrigGame; // 0x30
	
			// Properties
			public override int assignedButtonCount { get; } // 0x000000018039C420-0x000000018039C440 
			public override int assignedAxisCount { get; } // 0x000000018039C400-0x000000018039C420 
			internal override InputPlatform platform { get; } // 0x00000001809E9E40-0x00000001809E9E50 
			internal override Axis[] Axes { get; } // 0x0000000180C74890-0x0000000180C74A00 
			internal override Button[] Buttons { get; } // 0x0000000180C74A00-0x0000000180C74B70 
			internal Axis[] Axes_orig { get; } // 0x000000018039C3E0-0x000000018039C3F0 
			internal Button[] Buttons_orig { get; } // 0x000000018039C3F0-0x000000018039C400 
			internal override bool hasData { get; } // 0x0000000180C2F000-0x0000000180C2F070 
			internal override bool disabled { get; } // 0x000000018039C440-0x000000018039C450 
			internal override bool isAllowed { get; } // 0x000000018039C4C0-0x000000018039C500 
			internal override Elements_Base elements_base { get; } // 0x000000018036AC70-0x000000018036AC80 
			internal override IList<Rewired.Data.Mapping.HardwareJoystickMap.Platform> variants_base { get; } // 0x000000018035FCC0-0x000000018035FCD0 
	
			// Nested types
			[Serializable]
			[CustomClassObfuscation] // 0x00000001800D0530-0x00000001800D0560
			public sealed class MatchingCriteria : Platform_Custom.MatchingCriteria // TypeDefIndex: 6157
			{
				// Properties
				internal override bool hasData { get; } // 0x0000000180C72800-0x0000000180C72820 
				internal override bool isAllowed { get; } // 0x000000018039A200-0x000000018039A230 
	
				// Constructors
				public MatchingCriteria(); // 0x0000000180363710-0x0000000180363720
	
				// Methods
				internal override bool Matches(BridgedControllerHWInfo bridgedControllerHWInfo, bool strictMatch); // 0x0000000180C718C0-0x0000000180C71970
				public override object DeepClone(); // 0x0000000180C70C90-0x0000000180C70D00
				internal override void CopyVars(MatchingCriteria_Base destination); // 0x0000000180C707C0-0x0000000180C70810
			}
	
			[Serializable]
			[CustomClassObfuscation] // 0x00000001800D0530-0x00000001800D0560
			public sealed class Elements : Platform_Custom.Elements // TypeDefIndex: 6158
			{
				// Fields
				public Axis[] axes; // 0x10
				public Button[] buttons; // 0x18
	
				// Properties
				public override int buttonCount { get; } // 0x00000001803951A0-0x00000001803951B0 
				public override int axisCount { get; } // 0x0000000180395190-0x00000001803951A0 
	
				// Constructors
				public Elements(); // 0x0000000180363710-0x0000000180363720
	
				// Methods
				internal override ControllerElementType GetEffectiveElementIdentifierType(ControllerElementIdentifier elementIdentifier); // 0x0000000180C6EB80-0x0000000180C6ED50
				internal override bool GetEffectiveAxisRange(ControllerElementIdentifier elementIdentifier, out AxisRange axisRange); // 0x0000000180C6DCA0-0x0000000180C6DF50
				public override object DeepClone(); // 0x0000000180C6CEF0-0x0000000180C6CF60
				internal override void CopyVars(Elements_Base destination); // 0x0000000180C6C9A0-0x0000000180C6CA60
			}
	
			[Serializable]
			[CustomClassObfuscation] // 0x00000001800D0530-0x00000001800D0560
			public sealed class Button : Platform_Custom.Button // TypeDefIndex: 6159
			{
				// Constructors
				public Button(); // 0x000000018037E800-0x000000018037E810
	
				// Methods
				public override object DeepClone(); // 0x0000000180C6BE60-0x0000000180C6BED0
				internal override void CopyVars(Platform_Custom.Element destination); // 0x0000000180C6BC80-0x0000000180C6BD00
			}
	
			[Serializable]
			[CustomClassObfuscation] // 0x00000001800D0530-0x00000001800D0560
			public sealed class Axis : Platform_Custom.Axis // TypeDefIndex: 6160
			{
				// Constructors
				public Axis(); // 0x000000018037E800-0x000000018037E810
	
				// Methods
				public override object DeepClone(); // 0x0000000180C6AFB0-0x0000000180C6B020
				internal override void CopyVars(Platform_Custom.Element destination); // 0x0000000180C6AC20-0x0000000180C6AC70
			}
	
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private sealed class aRHzhkejxZtCIvbfKnQeaqQXbzf : IEnumerable<Axis>, IEnumerator<Axis> // TypeDefIndex: 6161
			{
				// Fields
				private Platform_Custom.Axis aSrFEaALHwhGTdXfCdeUqgbwaZGO; // 0x10
				private int eLrUhJFgzEZElCzdKvcrgOLXLvL; // 0x18
				private int RQaeFqcJnaOYpZSBxtfUkVOjfOo; // 0x1C
				public Platform_Ouya_Base gKPmvKLRxdGbmXiMfUeDjGbezUo; // 0x20
				public int PpDliwTKffJpGKoHEhgksSomaDH; // 0x28
	
				// Properties
				Platform_Custom.Axis lmiaTpCsaXfKxySEjXIZoypgnjMr { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018036AC80-0x000000018036AC90 
				object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018036AC80-0x000000018036AC90 
	
				// Constructors
				[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
				public aRHzhkejxZtCIvbfKnQeaqQXbzf(int <>1__state); // 0x0000000180393A20-0x0000000180393A70
	
				// Methods
				[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
				IEnumerator<Platform_Custom.Axis> System.Collections.Generic.IEnumerable<Rewired.Data.Mapping.HardwareJoystickMap.Platform_Custom.Axis>.GetEnumerator(); // 0x0000000180C819F0-0x0000000180C81B10
				[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
				IEnumerator IEnumerable.GetEnumerator(); // 0x0000000180C819F0-0x0000000180C81B10
				private bool MoveNext(); // 0x0000000180C81820-0x0000000180C819F0
				[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
				void IEnumerator.Reset(); // 0x0000000180C81B10-0x0000000180C81B60
				void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			}
	
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private sealed class XtMZtzXwPdzvNhbKBQkMfxBUzFU : IEnumerable<Button>, IEnumerator<Button> // TypeDefIndex: 6162
			{
				// Fields
				private Platform_Custom.Button aSrFEaALHwhGTdXfCdeUqgbwaZGO; // 0x10
				private int eLrUhJFgzEZElCzdKvcrgOLXLvL; // 0x18
				private int RQaeFqcJnaOYpZSBxtfUkVOjfOo; // 0x1C
				public Platform_Ouya_Base gKPmvKLRxdGbmXiMfUeDjGbezUo; // 0x20
				public int iMkviWnQmExdFJquFuJojpIgZOm; // 0x28
	
				// Properties
				Platform_Custom.Button PlYXfEMpMbXcHXTJgpApbDPxYUh { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018036AC80-0x000000018036AC90 
				object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018036AC80-0x000000018036AC90 
	
				// Constructors
				[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
				public XtMZtzXwPdzvNhbKBQkMfxBUzFU(int <>1__state); // 0x0000000180C813F0-0x0000000180C81460
	
				// Methods
				[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
				IEnumerator<Platform_Custom.Button> System.Collections.Generic.IEnumerable<Rewired.Data.Mapping.HardwareJoystickMap.Platform_Custom.Button>.GetEnumerator(); // 0x0000000180C81280-0x0000000180C813A0
				[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
				IEnumerator IEnumerable.GetEnumerator(); // 0x0000000180C81280-0x0000000180C813A0
				private bool MoveNext(); // 0x0000000180C81120-0x0000000180C81280
				[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
				void IEnumerator.Reset(); // 0x0000000180C813A0-0x0000000180C813F0
				void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			}
	
			// Constructors
			public Platform_Ouya_Base(); // 0x0000000180363710-0x0000000180363720
	
			// Methods
			internal override bool Matches(BridgedControllerHWInfo BridgedControllerHWInfo, bool strictMatch, out int variantIndex, out Rewired.Data.Mapping.HardwareJoystickMap.Platform platformMap); // 0x0000000180C74810-0x0000000180C74890
			internal override IEnumerable<Axis> IterateAxes(); // 0x0000000180C746D0-0x0000000180C74770
			internal override IEnumerable<Button> IterateButtons(); // 0x0000000180C74770-0x0000000180C74810
			internal override string[] GetAxisNames(ControllerElementIdentifier[] identifiers); // 0x0000000180C73780-0x0000000180C73A70
			internal override string[] GetEffectiveButtonNames(ControllerElementIdentifier[] identifiers); // 0x0000000180C73C60-0x0000000180C73F30
			internal override bool IsElementIdentifierMapped(int elementIdentifierId); // 0x0000000180C74330-0x0000000180C746D0
			internal override void GetGameElementIdentifierIdMappings(out int[] buttons, out int[] axes); // 0x0000000180C73F30-0x0000000180C74330
			internal override AxisCalibrationData[] GetAxisCalibrationData(); // 0x0000000180C72CB0-0x0000000180C732F0
			internal override void GetAxisData(out AxisRange[] axisRanges, out HardwareAxisInfo[] axisInfos); // 0x0000000180C732F0-0x0000000180C73780
			internal override void GetButtonData(out HardwareButtonInfo[] buttonInfos); // 0x0000000180C73A70-0x0000000180C73C60
			internal override ControllerElementType GetEffectiveElementIdentifierType(ControllerElementIdentifier elementIdentifier); // 0x000000018039BA80-0x000000018039BAA0
			internal override bool GetEffectiveAxisRange(ControllerElementIdentifier elementIdentifier, out AxisRange axisRange); // 0x000000018039B710-0x000000018039B740
			public override object DeepClone(); // 0x0000000180C72C40-0x0000000180C72CB0
			internal override void CopyVars(Rewired.Data.Mapping.HardwareJoystickMap.Platform destination); // 0x0000000180C72B10-0x0000000180C72C40
		}
	
		[Serializable]
		[CustomClassObfuscation] // 0x00000001800D0530-0x00000001800D0560
		public sealed class Platform_Ouya : Platform_Ouya_Base // TypeDefIndex: 6163
		{
			// Fields
			public Platform_Ouya_Base[] variants; // 0x38
	
			// Properties
			internal override IList<Rewired.Data.Mapping.HardwareJoystickMap.Platform> variants_base { get; } // 0x0000000180369BB0-0x0000000180369BC0 
	
			// Constructors
			public Platform_Ouya(); // 0x0000000180363710-0x0000000180363720
	
			// Methods
			internal override bool Matches(BridgedControllerHWInfo BridgedControllerHWInfo, bool strictMatch, out int variantIndex, out Rewired.Data.Mapping.HardwareJoystickMap.Platform platformMap); // 0x0000000180C74D90-0x0000000180C74F70
			public override object DeepClone(); // 0x0000000180C74D20-0x0000000180C74D90
			internal override void CopyVars(Rewired.Data.Mapping.HardwareJoystickMap.Platform destination); // 0x0000000180C74B70-0x0000000180C74D20
		}
	
		[Serializable]
		[CustomClassObfuscation] // 0x00000001800D0530-0x00000001800D0560
		public class Platform_XboxOne_Base : Platform_Custom // TypeDefIndex: 6164
		{
			// Fields
			public MatchingCriteria matchingCriteria; // 0x18
			public Elements elements; // 0x20
			private Axis[] _axesOrigGame; // 0x28
			private Button[] _buttonsOrigGame; // 0x30
	
			// Properties
			public override int assignedButtonCount { get; } // 0x000000018039C420-0x000000018039C440 
			public override int assignedAxisCount { get; } // 0x000000018039C400-0x000000018039C420 
			internal override InputPlatform platform { get; } // 0x00000001803A10C0-0x00000001803A10D0 
			internal override Axis[] Axes { get; } // 0x00000001803A0C90-0x00000001803A0E70 
			internal override Button[] Buttons { get; } // 0x00000001803A0E70-0x00000001803A1030 
			internal Axis[] Axes_orig { get; } // 0x000000018039C3E0-0x000000018039C3F0 
			internal Button[] Buttons_orig { get; } // 0x000000018039C3F0-0x000000018039C400 
			internal override bool hasData { get; } // 0x00000001803A1030-0x00000001803A10C0 
			internal override bool disabled { get; } // 0x000000018039C440-0x000000018039C450 
			internal override bool isAllowed { get; } // 0x000000018039C4C0-0x000000018039C500 
			internal override Elements_Base elements_base { get; } // 0x000000018036AC70-0x000000018036AC80 
			internal override IList<Rewired.Data.Mapping.HardwareJoystickMap.Platform> variants_base { get; } // 0x000000018035FCC0-0x000000018035FCD0 
	
			// Nested types
			[Serializable]
			[CustomClassObfuscation] // 0x00000001800D0530-0x00000001800D0560
			public sealed class MatchingCriteria : Platform_Custom.MatchingCriteria // TypeDefIndex: 6165
			{
				// Fields
				public bool productName_useRegex; // 0x30
				public string[] productName; // 0x38
	
				// Properties
				internal override bool hasData { get; } // 0x000000018039A1A0-0x000000018039A1E0 
				internal override bool isAllowed { get; } // 0x000000018039A200-0x000000018039A230 
	
				// Constructors
				public MatchingCriteria(); // 0x0000000180363710-0x0000000180363720
	
				// Methods
				internal override bool Matches(BridgedControllerHWInfo bridgedControllerHWInfo, bool strictMatch); // 0x0000000180399DC0-0x0000000180399FE0
				public override object DeepClone(); // 0x00000001803998A0-0x0000000180399910
				internal override void CopyVars(MatchingCriteria_Base destination); // 0x0000000180399610-0x00000001803996A0
			}
	
			[Serializable]
			[CustomClassObfuscation] // 0x00000001800D0530-0x00000001800D0560
			public sealed class Elements : Platform_Custom.Elements // TypeDefIndex: 6166
			{
				// Fields
				public Axis[] axes; // 0x10
				public Button[] buttons; // 0x18
	
				// Properties
				public override int buttonCount { get; } // 0x00000001803951A0-0x00000001803951B0 
				public override int axisCount { get; } // 0x0000000180395190-0x00000001803951A0 
	
				// Constructors
				public Elements(); // 0x0000000180363710-0x0000000180363720
	
				// Methods
				internal override ControllerElementType GetEffectiveElementIdentifierType(ControllerElementIdentifier elementIdentifier); // 0x0000000180394B90-0x0000000180394D10
				internal override bool GetEffectiveAxisRange(ControllerElementIdentifier elementIdentifier, out AxisRange axisRange); // 0x00000001803948B0-0x0000000180394B90
				public override object DeepClone(); // 0x00000001803941D0-0x0000000180394240
				internal override void CopyVars(Elements_Base destination); // 0x0000000180393F90-0x0000000180394020
			}
	
			[Serializable]
			[CustomClassObfuscation] // 0x00000001800D0530-0x00000001800D0560
			public sealed class Button : Platform_Custom.Button // TypeDefIndex: 6167
			{
				// Constructors
				public Button(); // 0x000000018037E800-0x000000018037E810
	
				// Methods
				public override object DeepClone(); // 0x00000001803927E0-0x0000000180392850
				internal override void CopyVars(Platform_Custom.Element destination); // 0x0000000180392650-0x00000001803926A0
			}
	
			[Serializable]
			[CustomClassObfuscation] // 0x00000001800D0530-0x00000001800D0560
			public sealed class Axis : Platform_Custom.Axis // TypeDefIndex: 6168
			{
				// Constructors
				public Axis(); // 0x000000018037E800-0x000000018037E810
	
				// Methods
				public override object DeepClone(); // 0x0000000180392310-0x0000000180392380
				internal override void CopyVars(Platform_Custom.Element destination); // 0x00000001803922C0-0x0000000180392310
			}
	
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private sealed class NebGQKirrNPGgkcrIancLxuvSo : IEnumerable<Axis>, IEnumerator<Axis> // TypeDefIndex: 6169
			{
				// Fields
				private Platform_Custom.Axis aSrFEaALHwhGTdXfCdeUqgbwaZGO; // 0x10
				private int eLrUhJFgzEZElCzdKvcrgOLXLvL; // 0x18
				private int RQaeFqcJnaOYpZSBxtfUkVOjfOo; // 0x1C
				public Platform_XboxOne_Base gKPmvKLRxdGbmXiMfUeDjGbezUo; // 0x20
				public int ZqUCxpYFlLPvBvVurELYuqFJjbN; // 0x28
	
				// Properties
				Platform_Custom.Axis lmiaTpCsaXfKxySEjXIZoypgnjMr { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018036AC80-0x000000018036AC90 
				object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018036AC80-0x000000018036AC90 
	
				// Constructors
				[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
				public NebGQKirrNPGgkcrIancLxuvSo(int <>1__state); // 0x0000000180393A20-0x0000000180393A70
	
				// Methods
				[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
				IEnumerator<Platform_Custom.Axis> System.Collections.Generic.IEnumerable<Rewired.Data.Mapping.HardwareJoystickMap.Platform_Custom.Axis>.GetEnumerator(); // 0x000000018039A3F0-0x000000018039A4D0
				[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
				IEnumerator IEnumerable.GetEnumerator(); // 0x000000018039A3F0-0x000000018039A4D0
				private bool MoveNext(); // 0x000000018039A230-0x000000018039A3F0
				[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
				void IEnumerator.Reset(); // 0x000000018039A4D0-0x000000018039A520
				void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			}
	
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private sealed class HybmreaYbjvEZmLHdFpKDIKPdWMC : IEnumerable<Button>, IEnumerator<Button> // TypeDefIndex: 6170
			{
				// Fields
				private Platform_Custom.Button aSrFEaALHwhGTdXfCdeUqgbwaZGO; // 0x10
				private int eLrUhJFgzEZElCzdKvcrgOLXLvL; // 0x18
				private int RQaeFqcJnaOYpZSBxtfUkVOjfOo; // 0x1C
				public Platform_XboxOne_Base gKPmvKLRxdGbmXiMfUeDjGbezUo; // 0x20
				public int aVGWoKnFCgGxTFeMMvcofNvZHCS; // 0x28
	
				// Properties
				Platform_Custom.Button PlYXfEMpMbXcHXTJgpApbDPxYUh { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018036AC80-0x000000018036AC90 
				object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018036AC80-0x000000018036AC90 
	
				// Constructors
				[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
				public HybmreaYbjvEZmLHdFpKDIKPdWMC(int <>1__state); // 0x0000000180393A20-0x0000000180393A70
	
				// Methods
				[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
				IEnumerator<Platform_Custom.Button> System.Collections.Generic.IEnumerable<Rewired.Data.Mapping.HardwareJoystickMap.Platform_Custom.Button>.GetEnumerator(); // 0x0000000180398C70-0x0000000180398D50
				[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
				IEnumerator IEnumerable.GetEnumerator(); // 0x0000000180398C70-0x0000000180398D50
				private bool MoveNext(); // 0x0000000180398AB0-0x0000000180398C70
				[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
				void IEnumerator.Reset(); // 0x0000000180398D50-0x0000000180398DA0
				void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			}
	
			// Constructors
			public Platform_XboxOne_Base(); // 0x0000000180363710-0x0000000180363720
	
			// Methods
			internal override bool Matches(BridgedControllerHWInfo BridgedControllerHWInfo, bool strictMatch, out int variantIndex, out Rewired.Data.Mapping.HardwareJoystickMap.Platform platformMap); // 0x00000001803A0C00-0x00000001803A0C90
			internal override IEnumerable<Axis> IterateAxes(); // 0x00000001803A0B00-0x00000001803A0B80
			internal override IEnumerable<Button> IterateButtons(); // 0x00000001803A0B80-0x00000001803A0C00
			internal override string[] GetAxisNames(ControllerElementIdentifier[] identifiers); // 0x000000018039F8C0-0x000000018039FBC0
			internal override string[] GetEffectiveButtonNames(ControllerElementIdentifier[] identifiers); // 0x000000018039FE10-0x00000001803A00E0
			internal override bool IsElementIdentifierMapped(int elementIdentifierId); // 0x00000001803A06D0-0x00000001803A0B00
			internal override void GetGameElementIdentifierIdMappings(out int[] buttons, out int[] axes); // 0x00000001803A00E0-0x00000001803A06D0
			internal override AxisCalibrationData[] GetAxisCalibrationData(); // 0x000000018039EDB0-0x000000018039F3F0
			internal override void GetAxisData(out AxisRange[] axisRanges, out HardwareAxisInfo[] axisInfos); // 0x000000018039F3F0-0x000000018039F8C0
			internal override void GetButtonData(out HardwareButtonInfo[] buttonInfos); // 0x000000018039FBC0-0x000000018039FE10
			internal override ControllerElementType GetEffectiveElementIdentifierType(ControllerElementIdentifier elementIdentifier); // 0x000000018039BA80-0x000000018039BAA0
			internal override bool GetEffectiveAxisRange(ControllerElementIdentifier elementIdentifier, out AxisRange axisRange); // 0x000000018039B710-0x000000018039B740
			public override object DeepClone(); // 0x000000018039ED40-0x000000018039EDB0
			internal override void CopyVars(Rewired.Data.Mapping.HardwareJoystickMap.Platform destination); // 0x000000018039EC60-0x000000018039ED40
		}
	
		[Serializable]
		[CustomClassObfuscation] // 0x00000001800D0530-0x00000001800D0560
		public sealed class Platform_XboxOne : Platform_XboxOne_Base // TypeDefIndex: 6171
		{
			// Fields
			public Platform_XboxOne_Base[] variants; // 0x38
	
			// Properties
			internal override IList<Rewired.Data.Mapping.HardwareJoystickMap.Platform> variants_base { get; } // 0x0000000180369BB0-0x0000000180369BC0 
	
			// Constructors
			public Platform_XboxOne(); // 0x0000000180363710-0x0000000180363720
	
			// Methods
			internal override bool Matches(BridgedControllerHWInfo BridgedControllerHWInfo, bool strictMatch, out int variantIndex, out Rewired.Data.Mapping.HardwareJoystickMap.Platform platformMap); // 0x00000001803A12E0-0x00000001803A1500
			public override object DeepClone(); // 0x00000001803A1270-0x00000001803A12E0
			internal override void CopyVars(Rewired.Data.Mapping.HardwareJoystickMap.Platform destination); // 0x00000001803A10D0-0x00000001803A1270
		}
	
		[Serializable]
		[CustomClassObfuscation] // 0x00000001800D0530-0x00000001800D0560
		public class Platform_PS4_Base : Platform_Custom // TypeDefIndex: 6172
		{
			// Fields
			public MatchingCriteria matchingCriteria; // 0x18
			public Elements elements; // 0x20
			private Axis[] _axesOrigGame; // 0x28
			private Button[] _buttonsOrigGame; // 0x30
	
			// Properties
			public override int assignedButtonCount { get; } // 0x000000018039C420-0x000000018039C440 
			public override int assignedAxisCount { get; } // 0x000000018039C400-0x000000018039C420 
			internal override InputPlatform platform { get; } // 0x00000001809E8FB0-0x00000001809E8FC0 
			internal override Axis[] Axes { get; } // 0x0000000180C76CE0-0x0000000180C76EC0 
			internal override Button[] Buttons { get; } // 0x0000000180C76EC0-0x0000000180C770C0 
			internal Axis[] Axes_orig { get; } // 0x000000018039C3E0-0x000000018039C3F0 
			internal Button[] Buttons_orig { get; } // 0x000000018039C3F0-0x000000018039C400 
			internal override bool hasData { get; } // 0x0000000180C770C0-0x0000000180C77160 
			internal override bool disabled { get; } // 0x000000018039C440-0x000000018039C450 
			internal override bool isAllowed { get; } // 0x000000018039C4C0-0x000000018039C500 
			internal override Elements_Base elements_base { get; } // 0x000000018036AC70-0x000000018036AC80 
			internal override IList<Rewired.Data.Mapping.HardwareJoystickMap.Platform> variants_base { get; } // 0x000000018035FCC0-0x000000018035FCD0 
	
			// Nested types
			[Serializable]
			[CustomClassObfuscation] // 0x00000001800D0530-0x00000001800D0560
			public sealed class MatchingCriteria : Platform_Custom.MatchingCriteria // TypeDefIndex: 6173
			{
				// Fields
				public bool productName_useRegex; // 0x30
				public string[] productName; // 0x38
	
				// Properties
				internal override bool hasData { get; } // 0x000000018039A1A0-0x000000018039A1E0 
				internal override bool isAllowed { get; } // 0x000000018039A200-0x000000018039A230 
	
				// Constructors
				public MatchingCriteria(); // 0x0000000180363710-0x0000000180363720
	
				// Methods
				internal override bool Matches(BridgedControllerHWInfo bridgedControllerHWInfo, bool strictMatch); // 0x0000000180C72110-0x0000000180C72320
				public override object DeepClone(); // 0x0000000180C70A60-0x0000000180C70AD0
				internal override void CopyVars(MatchingCriteria_Base destination); // 0x0000000180C708E0-0x0000000180C70970
			}
	
			[Serializable]
			[CustomClassObfuscation] // 0x00000001800D0530-0x00000001800D0560
			public sealed class Elements : Platform_Custom.Elements // TypeDefIndex: 6174
			{
				// Fields
				public Axis[] axes; // 0x10
				public Button[] buttons; // 0x18
	
				// Properties
				public override int buttonCount { get; } // 0x00000001803951A0-0x00000001803951B0 
				public override int axisCount { get; } // 0x0000000180395190-0x00000001803951A0 
	
				// Constructors
				public Elements(); // 0x0000000180363710-0x0000000180363720
	
				// Methods
				internal override ControllerElementType GetEffectiveElementIdentifierType(ControllerElementIdentifier elementIdentifier); // 0x0000000180C6E460-0x0000000180C6E620
				internal override bool GetEffectiveAxisRange(ControllerElementIdentifier elementIdentifier, out AxisRange axisRange); // 0x0000000180C6D9E0-0x0000000180C6DCA0
				public override object DeepClone(); // 0x0000000180C6CDA0-0x0000000180C6CE10
				internal override void CopyVars(Elements_Base destination); // 0x0000000180C6CCA0-0x0000000180C6CD30
			}
	
			[Serializable]
			[CustomClassObfuscation] // 0x00000001800D0530-0x00000001800D0560
			public sealed class Button : Platform_Custom.Button // TypeDefIndex: 6175
			{
				// Constructors
				public Button(); // 0x000000018037E800-0x000000018037E810
	
				// Methods
				public override object DeepClone(); // 0x0000000180C6BF40-0x0000000180C6BFB0
				internal override void CopyVars(Platform_Custom.Element destination); // 0x0000000180C6BD50-0x0000000180C6BDA0
			}
	
			[Serializable]
			[CustomClassObfuscation] // 0x00000001800D0530-0x00000001800D0560
			public sealed class Axis : Platform_Custom.Axis // TypeDefIndex: 6176
			{
				// Constructors
				public Axis(); // 0x000000018037E800-0x000000018037E810
	
				// Methods
				public override object DeepClone(); // 0x0000000180C6AF40-0x0000000180C6AFB0
				internal override void CopyVars(Platform_Custom.Element destination); // 0x0000000180C6AB60-0x0000000180C6ABB0
			}
	
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private sealed class BTBFoNEugzBOjcSnJHEQHIRhepA : IEnumerable<Axis>, IEnumerator<Axis> // TypeDefIndex: 6177
			{
				// Fields
				private Platform_Custom.Axis aSrFEaALHwhGTdXfCdeUqgbwaZGO; // 0x10
				private int eLrUhJFgzEZElCzdKvcrgOLXLvL; // 0x18
				private int RQaeFqcJnaOYpZSBxtfUkVOjfOo; // 0x1C
				public Platform_PS4_Base gKPmvKLRxdGbmXiMfUeDjGbezUo; // 0x20
				public int otBnEJmMttdoVeQbzgtbeSTKsqUM; // 0x28
	
				// Properties
				Platform_Custom.Axis lmiaTpCsaXfKxySEjXIZoypgnjMr { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018036AC80-0x000000018036AC90 
				object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018036AC80-0x000000018036AC90 
	
				// Constructors
				[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
				public BTBFoNEugzBOjcSnJHEQHIRhepA(int <>1__state); // 0x0000000180393A20-0x0000000180393A70
	
				// Methods
				[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
				IEnumerator<Platform_Custom.Axis> System.Collections.Generic.IEnumerable<Rewired.Data.Mapping.HardwareJoystickMap.Platform_Custom.Axis>.GetEnumerator(); // 0x0000000180C6B6B0-0x0000000180C6B7C0
				[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
				IEnumerator IEnumerable.GetEnumerator(); // 0x0000000180C6B6B0-0x0000000180C6B7C0
				private bool MoveNext(); // 0x0000000180C6B4C0-0x0000000180C6B6B0
				[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
				void IEnumerator.Reset(); // 0x0000000180C6B7C0-0x0000000180C6B810
				void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			}
	
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private sealed class NsBBdBPqHvvczEJFfDKrAzMbqsX : IEnumerable<Button>, IEnumerator<Button> // TypeDefIndex: 6178
			{
				// Fields
				private Platform_Custom.Button aSrFEaALHwhGTdXfCdeUqgbwaZGO; // 0x10
				private int eLrUhJFgzEZElCzdKvcrgOLXLvL; // 0x18
				private int RQaeFqcJnaOYpZSBxtfUkVOjfOo; // 0x1C
				public Platform_PS4_Base gKPmvKLRxdGbmXiMfUeDjGbezUo; // 0x20
				public int IOvbxPdWiUNWsRBXDOyerTZzBXtq; // 0x28
	
				// Properties
				Platform_Custom.Button PlYXfEMpMbXcHXTJgpApbDPxYUh { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018036AC80-0x000000018036AC90 
				object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018036AC80-0x000000018036AC90 
	
				// Constructors
				[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
				public NsBBdBPqHvvczEJFfDKrAzMbqsX(int <>1__state); // 0x0000000180393A20-0x0000000180393A70
	
				// Methods
				[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
				IEnumerator<Platform_Custom.Button> System.Collections.Generic.IEnumerable<Rewired.Data.Mapping.HardwareJoystickMap.Platform_Custom.Button>.GetEnumerator(); // 0x0000000180C729C0-0x0000000180C72AC0
				[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
				IEnumerator IEnumerable.GetEnumerator(); // 0x0000000180C729C0-0x0000000180C72AC0
				private bool MoveNext(); // 0x0000000180C72820-0x0000000180C729C0
				[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
				void IEnumerator.Reset(); // 0x0000000180C72AC0-0x0000000180C72B10
				void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			}
	
			// Constructors
			public Platform_PS4_Base(); // 0x0000000180363710-0x0000000180363720
	
			// Methods
			internal override bool Matches(BridgedControllerHWInfo BridgedControllerHWInfo, bool strictMatch, out int variantIndex, out Rewired.Data.Mapping.HardwareJoystickMap.Platform platformMap); // 0x0000000180C76C30-0x0000000180C76CE0
			internal override IEnumerable<Axis> IterateAxes(); // 0x0000000180C76B30-0x0000000180C76BB0
			internal override IEnumerable<Button> IterateButtons(); // 0x0000000180C76BB0-0x0000000180C76C30
			internal override string[] GetAxisNames(ControllerElementIdentifier[] identifiers); // 0x0000000180C75BA0-0x0000000180C75EA0
			internal override string[] GetEffectiveButtonNames(ControllerElementIdentifier[] identifiers); // 0x0000000180C760A0-0x0000000180C76360
			internal override bool IsElementIdentifierMapped(int elementIdentifierId); // 0x0000000180C76800-0x0000000180C76B30
			internal override void GetGameElementIdentifierIdMappings(out int[] buttons, out int[] axes); // 0x0000000180C76360-0x0000000180C76800
			internal override AxisCalibrationData[] GetAxisCalibrationData(); // 0x0000000180C750C0-0x0000000180C756C0
			internal override void GetAxisData(out AxisRange[] axisRanges, out HardwareAxisInfo[] axisInfos); // 0x0000000180C756C0-0x0000000180C75BA0
			internal override void GetButtonData(out HardwareButtonInfo[] buttonInfos); // 0x0000000180C75EA0-0x0000000180C760A0
			internal override ControllerElementType GetEffectiveElementIdentifierType(ControllerElementIdentifier elementIdentifier); // 0x000000018039BA80-0x000000018039BAA0
			internal override bool GetEffectiveAxisRange(ControllerElementIdentifier elementIdentifier, out AxisRange axisRange); // 0x000000018039B710-0x000000018039B740
			public override object DeepClone(); // 0x0000000180C75050-0x0000000180C750C0
			internal override void CopyVars(Rewired.Data.Mapping.HardwareJoystickMap.Platform destination); // 0x0000000180C74F70-0x0000000180C75050
		}
	
		[Serializable]
		[CustomClassObfuscation] // 0x00000001800D0530-0x00000001800D0560
		public sealed class Platform_PS4 : Platform_PS4_Base // TypeDefIndex: 6179
		{
			// Fields
			public Platform_PS4_Base[] variants; // 0x38
	
			// Properties
			internal override IList<Rewired.Data.Mapping.HardwareJoystickMap.Platform> variants_base { get; } // 0x0000000180369BB0-0x0000000180369BC0 
	
			// Constructors
			public Platform_PS4(); // 0x0000000180363710-0x0000000180363720
	
			// Methods
			internal override bool Matches(BridgedControllerHWInfo BridgedControllerHWInfo, bool strictMatch, out int variantIndex, out Rewired.Data.Mapping.HardwareJoystickMap.Platform platformMap); // 0x0000000180C77380-0x0000000180C775B0
			public override object DeepClone(); // 0x0000000180C77310-0x0000000180C77380
			internal override void CopyVars(Rewired.Data.Mapping.HardwareJoystickMap.Platform destination); // 0x0000000180C77160-0x0000000180C77310
		}
	
		[Serializable]
		[CustomClassObfuscation] // 0x00000001800D0530-0x00000001800D0560
		public class Platform_NintendoSwitch_Base : Platform_Custom // TypeDefIndex: 6180
		{
			// Fields
			public MatchingCriteria matchingCriteria; // 0x18
			public Elements elements; // 0x20
			private Axis[] _axesOrigGame; // 0x28
			private Button[] _buttonsOrigGame; // 0x30
	
			// Properties
			public override int assignedButtonCount { get; } // 0x000000018039C420-0x000000018039C440 
			public override int assignedAxisCount { get; } // 0x000000018039C400-0x000000018039C420 
			internal override InputPlatform platform { get; } // 0x00000001809E87D0-0x00000001809E87E0 
			internal override Axis[] Axes { get; } // 0x0000000180C332F0-0x0000000180C334C0 
			internal override Button[] Buttons { get; } // 0x0000000180C334C0-0x0000000180C336A0 
			internal Axis[] Axes_orig { get; } // 0x000000018039C3E0-0x000000018039C3F0 
			internal Button[] Buttons_orig { get; } // 0x000000018039C3F0-0x000000018039C400 
			internal override bool hasData { get; } // 0x0000000180C336A0-0x0000000180C33720 
			internal override bool disabled { get; } // 0x000000018039C440-0x000000018039C450 
			internal override bool isAllowed { get; } // 0x000000018039C4C0-0x000000018039C500 
			internal override Elements_Base elements_base { get; } // 0x000000018036AC70-0x000000018036AC80 
			internal override IList<Rewired.Data.Mapping.HardwareJoystickMap.Platform> variants_base { get; } // 0x000000018035FCC0-0x000000018035FCD0 
	
			// Nested types
			[Serializable]
			[CustomClassObfuscation] // 0x00000001800D0530-0x00000001800D0560
			public sealed class MatchingCriteria : Platform_Custom.MatchingCriteria // TypeDefIndex: 6181
			{
				// Fields
				public bool productName_useRegex; // 0x30
				public string[] productName; // 0x38
	
				// Properties
				internal override bool hasData { get; } // 0x0000000180C28450-0x0000000180C28480 
				internal override bool isAllowed { get; } // 0x0000000180C284E0-0x0000000180C28510 
	
				// Constructors
				public MatchingCriteria(); // 0x000000018037E800-0x000000018037E810
	
				// Methods
				internal override bool Matches(BridgedControllerHWInfo bridgedControllerHWInfo, bool strictMatch); // 0x0000000180C27780-0x0000000180C27A00
				public override object DeepClone(); // 0x0000000180C26EC0-0x0000000180C26F30
				internal override void CopyVars(MatchingCriteria_Base destination); // 0x0000000180C26C10-0x0000000180C26DE0
			}
	
			[Serializable]
			[CustomClassObfuscation] // 0x00000001800D0530-0x00000001800D0560
			public sealed class Elements : Platform_Custom.Elements // TypeDefIndex: 6182
			{
				// Fields
				public Axis[] axes; // 0x10
				public Button[] buttons; // 0x18
	
				// Properties
				public override int buttonCount { get; } // 0x00000001803951A0-0x00000001803951B0 
				public override int axisCount { get; } // 0x0000000180395190-0x00000001803951A0 
	
				// Constructors
				public Elements(); // 0x000000018037E800-0x000000018037E810
	
				// Methods
				internal override ControllerElementType GetEffectiveElementIdentifierType(ControllerElementIdentifier elementIdentifier); // 0x0000000180C24F40-0x0000000180C25120
				internal override bool GetEffectiveAxisRange(ControllerElementIdentifier elementIdentifier, out AxisRange axisRange); // 0x0000000180C238E0-0x0000000180C23B70
				public override object DeepClone(); // 0x0000000180C237C0-0x0000000180C23830
				internal override void CopyVars(Elements_Base destination); // 0x0000000180C23170-0x0000000180C23240
			}
	
			[Serializable]
			[CustomClassObfuscation] // 0x00000001800D0530-0x00000001800D0560
			public sealed class Button : Platform_Custom.Button // TypeDefIndex: 6183
			{
				// Constructors
				public Button(); // 0x000000018036B6C0-0x000000018036B6D0
	
				// Methods
				public override object DeepClone(); // 0x0000000180C21B30-0x0000000180C21BA0
				internal override void CopyVars(Platform_Custom.Element destination); // 0x0000000180C215D0-0x0000000180C21620
			}
	
			[Serializable]
			[CustomClassObfuscation] // 0x00000001800D0530-0x00000001800D0560
			public sealed class Axis : Platform_Custom.Axis // TypeDefIndex: 6184
			{
				// Constructors
				public Axis(); // 0x000000018036B6C0-0x000000018036B6D0
	
				// Methods
				public override object DeepClone(); // 0x0000000180C21030-0x0000000180C210A0
				internal override void CopyVars(Platform_Custom.Element destination); // 0x0000000180C20B90-0x0000000180C20BE0
			}
	
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private sealed class XQrDbhCDAQZmLKoJQgSwuqMacwH : IEnumerable<Axis>, IEnumerator<Axis> // TypeDefIndex: 6185
			{
				// Fields
				private Platform_Custom.Axis aSrFEaALHwhGTdXfCdeUqgbwaZGO; // 0x10
				private int eLrUhJFgzEZElCzdKvcrgOLXLvL; // 0x18
				private int RQaeFqcJnaOYpZSBxtfUkVOjfOo; // 0x1C
				public Platform_NintendoSwitch_Base gKPmvKLRxdGbmXiMfUeDjGbezUo; // 0x20
				public int ERsJdabRVBlvmexWFudQlEOEgzz; // 0x28
	
				// Properties
				Platform_Custom.Axis lmiaTpCsaXfKxySEjXIZoypgnjMr { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018036AC80-0x000000018036AC90 
				object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018036AC80-0x000000018036AC90 
	
				// Constructors
				[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
				public XQrDbhCDAQZmLKoJQgSwuqMacwH(int <>1__state); // 0x0000000180393A20-0x0000000180393A70
	
				// Methods
				[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
				IEnumerator<Platform_Custom.Axis> System.Collections.Generic.IEnumerable<Rewired.Data.Mapping.HardwareJoystickMap.Platform_Custom.Axis>.GetEnumerator(); // 0x0000000180C36630-0x0000000180C36740
				[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
				IEnumerator IEnumerable.GetEnumerator(); // 0x0000000180C36630-0x0000000180C36740
				private bool MoveNext(); // 0x0000000180C36470-0x0000000180C36630
				[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
				void IEnumerator.Reset(); // 0x0000000180C36740-0x0000000180C36790
				void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			}
	
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private sealed class xGHaRdeVItRBPtXXBzsXuKZcVCH : IEnumerable<Button>, IEnumerator<Button> // TypeDefIndex: 6186
			{
				// Fields
				private Platform_Custom.Button aSrFEaALHwhGTdXfCdeUqgbwaZGO; // 0x10
				private int eLrUhJFgzEZElCzdKvcrgOLXLvL; // 0x18
				private int RQaeFqcJnaOYpZSBxtfUkVOjfOo; // 0x1C
				public Platform_NintendoSwitch_Base gKPmvKLRxdGbmXiMfUeDjGbezUo; // 0x20
				public int umyEYedVOzahltUTGwzXdPVXGQEt; // 0x28
	
				// Properties
				Platform_Custom.Button PlYXfEMpMbXcHXTJgpApbDPxYUh { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018036AC80-0x000000018036AC90 
				object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018036AC80-0x000000018036AC90 
	
				// Constructors
				[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
				public xGHaRdeVItRBPtXXBzsXuKZcVCH(int <>1__state); // 0x0000000180393A20-0x0000000180393A70
	
				// Methods
				[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
				IEnumerator<Platform_Custom.Button> System.Collections.Generic.IEnumerable<Rewired.Data.Mapping.HardwareJoystickMap.Platform_Custom.Button>.GetEnumerator(); // 0x0000000180C381B0-0x0000000180C382F0
				[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
				IEnumerator IEnumerable.GetEnumerator(); // 0x0000000180C381B0-0x0000000180C382F0
				private bool MoveNext(); // 0x0000000180C38000-0x0000000180C381B0
				[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
				void IEnumerator.Reset(); // 0x0000000180C382F0-0x0000000180C38340
				void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			}
	
			// Constructors
			public Platform_NintendoSwitch_Base(); // 0x000000018037E800-0x000000018037E810
	
			// Methods
			internal override bool Matches(BridgedControllerHWInfo BridgedControllerHWInfo, bool strictMatch, out int variantIndex, out Rewired.Data.Mapping.HardwareJoystickMap.Platform platformMap); // 0x0000000180C2EC00-0x0000000180C2EC60
			internal override IEnumerable<Axis> IterateAxes(); // 0x0000000180C331F0-0x0000000180C33270
			internal override IEnumerable<Button> IterateButtons(); // 0x0000000180C33270-0x0000000180C332F0
			internal override string[] GetAxisNames(ControllerElementIdentifier[] identifiers); // 0x0000000180C32200-0x0000000180C324E0
			internal override string[] GetEffectiveButtonNames(ControllerElementIdentifier[] identifiers); // 0x0000000180C326E0-0x0000000180C329E0
			internal override bool IsElementIdentifierMapped(int elementIdentifierId); // 0x0000000180C32E90-0x0000000180C331F0
			internal override void GetGameElementIdentifierIdMappings(out int[] buttons, out int[] axes); // 0x0000000180C329E0-0x0000000180C32E90
			internal override AxisCalibrationData[] GetAxisCalibrationData(); // 0x0000000180C31690-0x0000000180C31D10
			internal override void GetAxisData(out AxisRange[] axisRanges, out HardwareAxisInfo[] axisInfos); // 0x0000000180C31D10-0x0000000180C32200
			internal override void GetButtonData(out HardwareButtonInfo[] buttonInfos); // 0x0000000180C324E0-0x0000000180C326E0
			internal override ControllerElementType GetEffectiveElementIdentifierType(ControllerElementIdentifier elementIdentifier); // 0x000000018039BA80-0x000000018039BAA0
			internal override bool GetEffectiveAxisRange(ControllerElementIdentifier elementIdentifier, out AxisRange axisRange); // 0x000000018039B710-0x000000018039B740
			public override object DeepClone(); // 0x0000000180C31620-0x0000000180C31690
			internal override void CopyVars(Rewired.Data.Mapping.HardwareJoystickMap.Platform destination); // 0x0000000180C314A0-0x0000000180C31620
		}
	
		[Serializable]
		[CustomClassObfuscation] // 0x00000001800D0530-0x00000001800D0560
		public sealed class Platform_NintendoSwitch : Platform_NintendoSwitch_Base // TypeDefIndex: 6187
		{
			// Fields
			public Platform_NintendoSwitch_Base[] variants; // 0x38
	
			// Properties
			internal override IList<Rewired.Data.Mapping.HardwareJoystickMap.Platform> variants_base { get; } // 0x0000000180369BB0-0x0000000180369BC0 
	
			// Constructors
			public Platform_NintendoSwitch(); // 0x000000018037E800-0x000000018037E810
	
			// Methods
			internal override bool Matches(BridgedControllerHWInfo BridgedControllerHWInfo, bool strictMatch, out int variantIndex, out Rewired.Data.Mapping.HardwareJoystickMap.Platform platformMap); // 0x0000000180C33990-0x0000000180C33B90
			public override object DeepClone(); // 0x0000000180C33920-0x0000000180C33990
			internal override void CopyVars(Rewired.Data.Mapping.HardwareJoystickMap.Platform destination); // 0x0000000180C33720-0x0000000180C33920
		}
	
		[Serializable]
		[CustomClassObfuscation] // 0x00000001800D0530-0x00000001800D0560
		public class Platform_Stadia_Base : Platform_Custom // TypeDefIndex: 6188
		{
			// Fields
			public MatchingCriteria matchingCriteria; // 0x18
			public Elements elements; // 0x20
			public string controllerName; // 0x28
			private Axis[] _axesOrigGame; // 0x30
			private Button[] _buttonsOrigGame; // 0x38
	
			// Properties
			public override int assignedButtonCount { get; } // 0x000000018039C420-0x000000018039C440 
			public override int assignedAxisCount { get; } // 0x000000018039C400-0x000000018039C420 
			public override string controllerNameOverride { get; } // 0x0000000180369B60-0x0000000180369B70 
			internal override InputPlatform platform { get; } // 0x00000001809EF010-0x00000001809EF020 
			internal override Axis[] Axes { get; } // 0x0000000180C7D830-0x0000000180C7DA30 
			internal override Button[] Buttons { get; } // 0x0000000180C7DA30-0x0000000180C7DBB0 
			internal Axis[] Axes_orig { get; } // 0x000000018039C3E0-0x000000018039C3F0 
			internal Button[] Buttons_orig { get; } // 0x000000018039C3F0-0x000000018039C400 
			internal override bool hasData { get; } // 0x0000000180C2F000-0x0000000180C2F070 
			internal override bool disabled { get; } // 0x000000018039C440-0x000000018039C450 
			internal override bool isAllowed { get; } // 0x000000018039C4C0-0x000000018039C500 
			internal override Elements_Base elements_base { get; } // 0x000000018036AC70-0x000000018036AC80 
			internal override IList<Rewired.Data.Mapping.HardwareJoystickMap.Platform> variants_base { get; } // 0x000000018035FCC0-0x000000018035FCD0 
	
			// Nested types
			[Serializable]
			[CustomClassObfuscation] // 0x00000001800D0530-0x00000001800D0560
			public sealed class MatchingCriteria : Platform_Custom.MatchingCriteria // TypeDefIndex: 6189
			{
				// Fields
				public bool productName_useRegex; // 0x30
				public string[] productName; // 0x38
	
				// Properties
				internal override bool hasData { get; } // 0x000000018039A1A0-0x000000018039A1E0 
				internal override bool isAllowed { get; } // 0x000000018039A200-0x000000018039A230 
	
				// Constructors
				public MatchingCriteria(); // 0x0000000180363710-0x0000000180363720
	
				// Methods
				internal override bool Matches(BridgedControllerHWInfo bridgedControllerHWInfo, bool strictMatch); // 0x0000000180C71D30-0x0000000180C71F60
				public override object DeepClone(); // 0x0000000180C70B40-0x0000000180C70BB0
				internal override void CopyVars(MatchingCriteria_Base destination); // 0x0000000180C70810-0x0000000180C708E0
			}
	
			[Serializable]
			[CustomClassObfuscation] // 0x00000001800D0530-0x00000001800D0560
			public sealed class Elements : Platform_Custom.Elements // TypeDefIndex: 6190
			{
				// Fields
				public Axis[] axes; // 0x10
				public Button[] buttons; // 0x18
	
				// Properties
				public override int buttonCount { get; } // 0x00000001803951A0-0x00000001803951B0 
				public override int axisCount { get; } // 0x0000000180395190-0x00000001803951A0 
	
				// Constructors
				public Elements(); // 0x0000000180363710-0x0000000180363720
	
				// Methods
				internal override ControllerElementType GetEffectiveElementIdentifierType(ControllerElementIdentifier elementIdentifier); // 0x0000000180C6E2A0-0x0000000180C6E460
				internal override bool GetEffectiveAxisRange(ControllerElementIdentifier elementIdentifier, out AxisRange axisRange); // 0x0000000180C6D480-0x0000000180C6D740
				public override object DeepClone(); // 0x0000000180C6CF60-0x0000000180C6CFD0
				internal override void CopyVars(Elements_Base destination); // 0x0000000180C6C8E0-0x0000000180C6C9A0
			}
	
			[Serializable]
			[CustomClassObfuscation] // 0x00000001800D0530-0x00000001800D0560
			public sealed class Button : Platform_Custom.Button // TypeDefIndex: 6191
			{
				// Constructors
				public Button(); // 0x000000018037E800-0x000000018037E810
	
				// Methods
				public override object DeepClone(); // 0x0000000180C6BDF0-0x0000000180C6BE60
				internal override void CopyVars(Platform_Custom.Element destination); // 0x0000000180C6BDA0-0x0000000180C6BDF0
			}
	
			[Serializable]
			[CustomClassObfuscation] // 0x00000001800D0530-0x00000001800D0560
			public sealed class Axis : Platform_Custom.Axis // TypeDefIndex: 6192
			{
				// Constructors
				public Axis(); // 0x000000018037E800-0x000000018037E810
	
				// Methods
				public override object DeepClone(); // 0x0000000180C6B020-0x0000000180C6B090
				internal override void CopyVars(Platform_Custom.Element destination); // 0x0000000180C6ABB0-0x0000000180C6AC20
			}
	
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private sealed class jNxenzbJKPLtWtqjNnMSWuGkiLk : IEnumerable<Axis>, IEnumerator<Axis> // TypeDefIndex: 6193
			{
				// Fields
				private Platform_Custom.Axis aSrFEaALHwhGTdXfCdeUqgbwaZGO; // 0x10
				private int eLrUhJFgzEZElCzdKvcrgOLXLvL; // 0x18
				private int RQaeFqcJnaOYpZSBxtfUkVOjfOo; // 0x1C
				public Platform_Stadia_Base gKPmvKLRxdGbmXiMfUeDjGbezUo; // 0x20
				public int pEBadAbjxbeiHDRavKlzalcAuMEM; // 0x28
	
				// Properties
				Platform_Custom.Axis lmiaTpCsaXfKxySEjXIZoypgnjMr { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018036AC80-0x000000018036AC90 
				object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018036AC80-0x000000018036AC90 
	
				// Constructors
				[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
				public jNxenzbJKPLtWtqjNnMSWuGkiLk(int <>1__state); // 0x0000000180393A20-0x0000000180393A70
	
				// Methods
				[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
				IEnumerator<Platform_Custom.Axis> System.Collections.Generic.IEnumerable<Rewired.Data.Mapping.HardwareJoystickMap.Platform_Custom.Axis>.GetEnumerator(); // 0x0000000180C82300-0x0000000180C82420
				[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
				IEnumerator IEnumerable.GetEnumerator(); // 0x0000000180C82300-0x0000000180C82420
				private bool MoveNext(); // 0x0000000180C82120-0x0000000180C82300
				[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
				void IEnumerator.Reset(); // 0x0000000180C82420-0x0000000180C82470
				void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			}
	
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private sealed class BgrPHNLVoZIUwsPbcorknaQsvlY : IEnumerable<Button>, IEnumerator<Button> // TypeDefIndex: 6194
			{
				// Fields
				private Platform_Custom.Button aSrFEaALHwhGTdXfCdeUqgbwaZGO; // 0x10
				private int eLrUhJFgzEZElCzdKvcrgOLXLvL; // 0x18
				private int RQaeFqcJnaOYpZSBxtfUkVOjfOo; // 0x1C
				public Platform_Stadia_Base gKPmvKLRxdGbmXiMfUeDjGbezUo; // 0x20
				public int GNuiCdEaABybrZvwSBusMLNxLzw; // 0x28
	
				// Properties
				Platform_Custom.Button PlYXfEMpMbXcHXTJgpApbDPxYUh { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018036AC80-0x000000018036AC90 
				object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018036AC80-0x000000018036AC90 
	
				// Constructors
				[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
				public BgrPHNLVoZIUwsPbcorknaQsvlY(int <>1__state); // 0x0000000180393A20-0x0000000180393A70
	
				// Methods
				[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
				IEnumerator<Platform_Custom.Button> System.Collections.Generic.IEnumerable<Rewired.Data.Mapping.HardwareJoystickMap.Platform_Custom.Button>.GetEnumerator(); // 0x0000000180C6B9F0-0x0000000180C6BAD0
				[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
				IEnumerator IEnumerable.GetEnumerator(); // 0x0000000180C6B9F0-0x0000000180C6BAD0
				private bool MoveNext(); // 0x0000000180C6B810-0x0000000180C6B9F0
				[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
				void IEnumerator.Reset(); // 0x0000000180C6BAD0-0x0000000180C6BB20
				void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			}
	
			// Constructors
			public Platform_Stadia_Base(); // 0x0000000180363710-0x0000000180363720
	
			// Methods
			internal override bool Matches(BridgedControllerHWInfo BridgedControllerHWInfo, bool strictMatch, out int variantIndex, out Rewired.Data.Mapping.HardwareJoystickMap.Platform platformMap); // 0x0000000180C2EC00-0x0000000180C2EC60
			internal override IEnumerable<Axis> IterateAxes(); // 0x0000000180C7D730-0x0000000180C7D7B0
			internal override IEnumerable<Button> IterateButtons(); // 0x0000000180C7D7B0-0x0000000180C7D830
			internal override string[] GetAxisNames(ControllerElementIdentifier[] identifiers); // 0x0000000180C7C760-0x0000000180C7CA30
			internal override string[] GetEffectiveButtonNames(ControllerElementIdentifier[] identifiers); // 0x0000000180C7CC60-0x0000000180C7CF10
			internal override bool IsElementIdentifierMapped(int elementIdentifierId); // 0x0000000180C7D320-0x0000000180C7D730
			internal override void GetGameElementIdentifierIdMappings(out int[] buttons, out int[] axes); // 0x0000000180C7CF10-0x0000000180C7D320
			internal override AxisCalibrationData[] GetAxisCalibrationData(); // 0x0000000180C7BC80-0x0000000180C7C2A0
			internal override void GetAxisData(out AxisRange[] axisRanges, out HardwareAxisInfo[] axisInfos); // 0x0000000180C7C2A0-0x0000000180C7C760
			internal override void GetButtonData(out HardwareButtonInfo[] buttonInfos); // 0x0000000180C7CA30-0x0000000180C7CC60
			internal override ControllerElementType GetEffectiveElementIdentifierType(ControllerElementIdentifier elementIdentifier); // 0x000000018039BA80-0x000000018039BAA0
			internal override bool GetEffectiveAxisRange(ControllerElementIdentifier elementIdentifier, out AxisRange axisRange); // 0x000000018039B710-0x000000018039B740
			public override object DeepClone(); // 0x0000000180C7BC10-0x0000000180C7BC80
			internal override void CopyVars(Rewired.Data.Mapping.HardwareJoystickMap.Platform destination); // 0x0000000180C7BAD0-0x0000000180C7BC10
		}
	
		[Serializable]
		[CustomClassObfuscation] // 0x00000001800D0530-0x00000001800D0560
		public sealed class Platform_Stadia : Platform_Stadia_Base // TypeDefIndex: 6195
		{
			// Fields
			public Platform_Stadia_Base[] variants; // 0x40
	
			// Properties
			internal override IList<Rewired.Data.Mapping.HardwareJoystickMap.Platform> variants_base { get; } // 0x0000000180369B30-0x0000000180369B40 
	
			// Constructors
			public Platform_Stadia(); // 0x0000000180363710-0x0000000180363720
	
			// Methods
			internal override bool Matches(BridgedControllerHWInfo BridgedControllerHWInfo, bool strictMatch, out int variantIndex, out Rewired.Data.Mapping.HardwareJoystickMap.Platform platformMap); // 0x0000000180C7DE10-0x0000000180C7DFF0
			public override object DeepClone(); // 0x0000000180C7DDA0-0x0000000180C7DE10
			internal override void CopyVars(Rewired.Data.Mapping.HardwareJoystickMap.Platform destination); // 0x0000000180C7DBB0-0x0000000180C7DDA0
		}
	
		[Serializable]
		[CustomClassObfuscation] // 0x00000001800D0530-0x00000001800D0560
		public class Platform_InternalDriver_Base : Platform_Custom // TypeDefIndex: 6196
		{
			// Fields
			public MatchingCriteria matchingCriteria; // 0x18
			public Elements elements; // 0x20
			private Axis[] _axesOrigGame; // 0x28
			private Button[] _buttonsOrigGame; // 0x30
	
			// Properties
			public override int assignedButtonCount { get; } // 0x000000018039C420-0x000000018039C440 
			public override int assignedAxisCount { get; } // 0x000000018039C400-0x000000018039C420 
			internal override InputPlatform platform { get; } // 0x00000001809E81D0-0x00000001809E81E0 
			internal override Axis[] Axes { get; } // 0x0000000180C2EC60-0x0000000180C2EE40 
			internal override Button[] Buttons { get; } // 0x0000000180C2EE40-0x0000000180C2F000 
			internal Axis[] Axes_orig { get; } // 0x000000018039C3E0-0x000000018039C3F0 
			internal Button[] Buttons_orig { get; } // 0x000000018039C3F0-0x000000018039C400 
			internal override bool hasData { get; } // 0x0000000180C2F000-0x0000000180C2F070 
			internal override bool disabled { get; } // 0x000000018039C440-0x000000018039C450 
			internal override bool isAllowed { get; } // 0x000000018039C4C0-0x000000018039C500 
			internal override Elements_Base elements_base { get; } // 0x000000018036AC70-0x000000018036AC80 
			internal override IList<Rewired.Data.Mapping.HardwareJoystickMap.Platform> variants_base { get; } // 0x000000018035FCC0-0x000000018035FCD0 
	
			// Nested types
			[Serializable]
			[CustomClassObfuscation] // 0x00000001800D0530-0x00000001800D0560
			public sealed class MatchingCriteria : Platform_Custom.MatchingCriteria // TypeDefIndex: 6197
			{
				// Fields
				public bool productName_useRegex; // 0x30
				public string[] productName; // 0x38
				public VidPid[] vidPid; // 0x40
				public int hatCount; // 0x48
	
				// Properties
				internal override bool hasData { get; } // 0x0000000180C28360-0x0000000180C283E0 
				internal override bool isAllowed { get; } // 0x0000000180C284E0-0x0000000180C28510 
	
				// Constructors
				public MatchingCriteria(); // 0x000000018037E800-0x000000018037E810
	
				// Methods
				internal override bool Matches(BridgedControllerHWInfo bridgedControllerHWInfo, bool strictMatch); // 0x0000000180C273D0-0x0000000180C27780
				internal override bool ElementCountsMatch(BridgedControllerHWInfo bridgedControllerHWInfo, out bool alternateMatched); // 0x0000000180C27010-0x0000000180C27090
				public override object DeepClone(); // 0x0000000180C26E50-0x0000000180C26EC0
				internal override void CopyVars(MatchingCriteria_Base destination); // 0x0000000180C26920-0x0000000180C26AD0
				private bool ProductNameMatches(string name); // 0x0000000180C28260-0x0000000180C28360
			}
	
			[Serializable]
			[CustomClassObfuscation] // 0x00000001800D0530-0x00000001800D0560
			public sealed class Elements : Platform_Custom.Elements // TypeDefIndex: 6198
			{
				// Fields
				public Axis[] axes; // 0x10
				public Button[] buttons; // 0x18
	
				// Properties
				public override int buttonCount { get; } // 0x00000001803951A0-0x00000001803951B0 
				public override int axisCount { get; } // 0x0000000180395190-0x00000001803951A0 
	
				// Constructors
				public Elements(); // 0x000000018037E800-0x000000018037E810
	
				// Methods
				internal override ControllerElementType GetEffectiveElementIdentifierType(ControllerElementIdentifier elementIdentifier); // 0x0000000180C252D0-0x0000000180C254B0
				internal override bool GetEffectiveAxisRange(ControllerElementIdentifier elementIdentifier, out AxisRange axisRange); // 0x0000000180C23B70-0x0000000180C23EE0
				public override object DeepClone(); // 0x0000000180C23600-0x0000000180C23670
				internal override void CopyVars(Elements_Base destination); // 0x0000000180C23240-0x0000000180C23310
			}
	
			[Serializable]
			[CustomClassObfuscation] // 0x00000001800D0530-0x00000001800D0560
			public sealed class Button : Platform_Custom.Button // TypeDefIndex: 6199
			{
				// Fields
				public int sourceHat; // 0x60
				public HatDirection sourceHatDirection; // 0x64
				public HatType sourceHatType; // 0x68
	
				// Constructors
				public Button(); // 0x000000018036B6C0-0x000000018036B6D0
	
				// Methods
				public override object DeepClone(); // 0x0000000180C21DC0-0x0000000180C21E30
				internal override void CopyVars(Platform_Custom.Element destination); // 0x0000000180C21A80-0x0000000180C21B30
			}
	
			[Serializable]
			[CustomClassObfuscation] // 0x00000001800D0530-0x00000001800D0560
			public sealed class Axis : Platform_Custom.Axis // TypeDefIndex: 6200
			{
				// Fields
				public int sourceHat; // 0x68
				public AxisDirection sourceHatDirection; // 0x6C
				public HatType sourceHatType; // 0x70
				public AxisRange sourceHatRange; // 0x74
	
				// Constructors
				public Axis(); // 0x000000018036B6C0-0x000000018036B6D0
	
				// Methods
				public override object DeepClone(); // 0x0000000180C20F50-0x0000000180C20FC0
				internal override void CopyVars(Platform_Custom.Element destination); // 0x0000000180C20BE0-0x0000000180C20CD0
			}
	
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private sealed class DTwGUWcdtZLoYGgkpfHjNkVhJXaY : IEnumerable<Axis>, IEnumerator<Axis> // TypeDefIndex: 6201
			{
				// Fields
				private Platform_Custom.Axis aSrFEaALHwhGTdXfCdeUqgbwaZGO; // 0x10
				private int eLrUhJFgzEZElCzdKvcrgOLXLvL; // 0x18
				private int RQaeFqcJnaOYpZSBxtfUkVOjfOo; // 0x1C
				public Platform_InternalDriver_Base gKPmvKLRxdGbmXiMfUeDjGbezUo; // 0x20
				public int OKqDOIeGjuUmWPnbtTNDBwaJFkg; // 0x28
	
				// Properties
				Platform_Custom.Axis lmiaTpCsaXfKxySEjXIZoypgnjMr { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018036AC80-0x000000018036AC90 
				object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018036AC80-0x000000018036AC90 
	
				// Constructors
				[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
				public DTwGUWcdtZLoYGgkpfHjNkVhJXaY(int <>1__state); // 0x0000000180C22BA0-0x0000000180C22C10
	
				// Methods
				[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
				IEnumerator<Platform_Custom.Axis> System.Collections.Generic.IEnumerable<Rewired.Data.Mapping.HardwareJoystickMap.Platform_Custom.Axis>.GetEnumerator(); // 0x0000000180C229E0-0x0000000180C22B50
				[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
				IEnumerator IEnumerable.GetEnumerator(); // 0x0000000180C229E0-0x0000000180C22B50
				private bool MoveNext(); // 0x0000000180C22820-0x0000000180C229E0
				[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
				void IEnumerator.Reset(); // 0x0000000180C22B50-0x0000000180C22BA0
				void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			}
	
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private sealed class cEdIVWppmhuWZkBRUomjDjDWdHX : IEnumerable<Button>, IEnumerator<Button> // TypeDefIndex: 6202
			{
				// Fields
				private Platform_Custom.Button aSrFEaALHwhGTdXfCdeUqgbwaZGO; // 0x10
				private int eLrUhJFgzEZElCzdKvcrgOLXLvL; // 0x18
				private int RQaeFqcJnaOYpZSBxtfUkVOjfOo; // 0x1C
				public Platform_InternalDriver_Base gKPmvKLRxdGbmXiMfUeDjGbezUo; // 0x20
				public int MfWCXKDbkSvVWDfejeNcfleegxhD; // 0x28
	
				// Properties
				Platform_Custom.Button PlYXfEMpMbXcHXTJgpApbDPxYUh { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018036AC80-0x000000018036AC90 
				object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018036AC80-0x000000018036AC90 
	
				// Constructors
				[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
				public cEdIVWppmhuWZkBRUomjDjDWdHX(int <>1__state); // 0x0000000180393A20-0x0000000180393A70
	
				// Methods
				[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
				IEnumerator<Platform_Custom.Button> System.Collections.Generic.IEnumerable<Rewired.Data.Mapping.HardwareJoystickMap.Platform_Custom.Button>.GetEnumerator(); // 0x0000000180C36CB0-0x0000000180C36D90
				[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
				IEnumerator IEnumerable.GetEnumerator(); // 0x0000000180C36CB0-0x0000000180C36D90
				private bool MoveNext(); // 0x0000000180C36B00-0x0000000180C36CB0
				[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
				void IEnumerator.Reset(); // 0x0000000180C36D90-0x0000000180C36DE0
				void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			}
	
			// Constructors
			public Platform_InternalDriver_Base(); // 0x000000018037E800-0x000000018037E810
	
			// Methods
			internal override bool Matches(BridgedControllerHWInfo BridgedControllerHWInfo, bool strictMatch, out int variantIndex, out Rewired.Data.Mapping.HardwareJoystickMap.Platform platformMap); // 0x0000000180C2EC00-0x0000000180C2EC60
			internal override IEnumerable<Axis> IterateAxes(); // 0x0000000180C2EAD0-0x0000000180C2EB80
			internal override IEnumerable<Button> IterateButtons(); // 0x0000000180C2EB80-0x0000000180C2EC00
			internal override string[] GetAxisNames(ControllerElementIdentifier[] identifiers); // 0x0000000180C2DA10-0x0000000180C2DD10
			internal override string[] GetEffectiveButtonNames(ControllerElementIdentifier[] identifiers); // 0x0000000180C2DF40-0x0000000180C2E210
			internal override bool IsElementIdentifierMapped(int elementIdentifierId); // 0x0000000180C2E6A0-0x0000000180C2EAD0
			internal override void GetGameElementIdentifierIdMappings(out int[] buttons, out int[] axes); // 0x0000000180C2E210-0x0000000180C2E6A0
			internal override AxisCalibrationData[] GetAxisCalibrationData(); // 0x0000000180C2CEA0-0x0000000180C2D500
			internal override void GetAxisData(out AxisRange[] axisRanges, out HardwareAxisInfo[] axisInfos); // 0x0000000180C2D500-0x0000000180C2DA10
			internal override void GetButtonData(out HardwareButtonInfo[] buttonInfos); // 0x0000000180C2DD10-0x0000000180C2DF40
			internal override ControllerElementType GetEffectiveElementIdentifierType(ControllerElementIdentifier elementIdentifier); // 0x000000018039BA80-0x000000018039BAA0
			internal override bool GetEffectiveAxisRange(ControllerElementIdentifier elementIdentifier, out AxisRange axisRange); // 0x000000018039B710-0x000000018039B740
			public override object DeepClone(); // 0x0000000180C2CE30-0x0000000180C2CEA0
			internal override void CopyVars(Rewired.Data.Mapping.HardwareJoystickMap.Platform destination); // 0x0000000180C2CD60-0x0000000180C2CE30
		}
	
		[Serializable]
		[CustomClassObfuscation] // 0x00000001800D0530-0x00000001800D0560
		public sealed class Platform_InternalDriver : Platform_InternalDriver_Base // TypeDefIndex: 6203
		{
			// Fields
			public Platform_InternalDriver_Base[] variants; // 0x38
	
			// Properties
			internal override IList<Rewired.Data.Mapping.HardwareJoystickMap.Platform> variants_base { get; } // 0x0000000180369BB0-0x0000000180369BC0 
	
			// Constructors
			public Platform_InternalDriver(); // 0x000000018037E800-0x000000018037E810
	
			// Methods
			internal override bool Matches(BridgedControllerHWInfo BridgedControllerHWInfo, bool strictMatch, out int variantIndex, out Rewired.Data.Mapping.HardwareJoystickMap.Platform platformMap); // 0x0000000180C2F230-0x0000000180C2F410
			public override object DeepClone(); // 0x0000000180C2F1C0-0x0000000180C2F230
			internal override void CopyVars(Rewired.Data.Mapping.HardwareJoystickMap.Platform destination); // 0x0000000180C2F070-0x0000000180C2F1C0
		}
	
		[Serializable]
		[CustomClassObfuscation] // 0x00000001800D0530-0x00000001800D0560
		public class Platform_SDL2_Base : Rewired.Data.Mapping.HardwareJoystickMap.Platform // TypeDefIndex: 6204
		{
			// Fields
			public MatchingCriteria matchingCriteria; // 0x18
			public Elements elements; // 0x20
	
			// Properties
			internal override InputPlatform platform { get; } // 0x00000001809E8840-0x00000001809E8850 
			internal override bool hasData { get; } // 0x000000018039C450-0x000000018039C4C0 
			internal override bool disabled { get; } // 0x000000018039C440-0x000000018039C450 
			internal override bool isAllowed { get; } // 0x000000018039C4C0-0x000000018039C500 
			internal Axis[] Axes_orig { get; } // 0x000000018039C3E0-0x000000018039C3F0 
			internal Button[] Buttons_orig { get; } // 0x000000018039C3F0-0x000000018039C400 
			internal override IList<Rewired.Data.Mapping.HardwareJoystickMap.Platform> variants_base { get; } // 0x000000018035FCC0-0x000000018035FCD0 
			public override int assignedButtonCount { get; } // 0x000000018039C420-0x000000018039C440 
			public override int assignedAxisCount { get; } // 0x000000018039C400-0x000000018039C420 
			internal override Elements_Base elements_base { get; } // 0x000000018036AC70-0x000000018036AC80 
	
			// Nested types
			[Serializable]
			[CustomClassObfuscation] // 0x00000001800D0530-0x00000001800D0560
			public sealed class MatchingCriteria : MatchingCriteria_Base // TypeDefIndex: 6205
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
				internal override bool hasData { get; } // 0x0000000180C727D0-0x0000000180C72800 
				internal override bool isAllowed { get; } // 0x000000018039A1E0-0x000000018039A200 
				internal override int alternateElementCount { get; } // 0x000000018035FCC0-0x000000018035FCD0 
	
				// Nested types
				[Serializable]
				public sealed class ElementCount : MatchingCriteria_Base.ElementCount_Base // TypeDefIndex: 6206
				{
					// Fields
					public int hatCount; // 0x18
	
					// Constructors
					public ElementCount(); // 0x000000018037E800-0x000000018037E810
	
					// Methods
					public override object DeepClone(); // 0x0000000180C6C7A0-0x0000000180C6C810
					internal override void CopyVars(MatchingCriteria_Base.ElementCount_Base param_0000cf92); // 0x0000000180C6C630-0x0000000180C6C6A0
					internal override bool Matches(BridgedControllerHWInfo param_0000cf93); // 0x0000000180393E00-0x0000000180393E60
				}
	
				// Constructors
				public MatchingCriteria(); // 0x000000018037E800-0x000000018037E810
	
				// Methods
				internal override bool Matches(BridgedControllerHWInfo bridgedControllerHWInfo, bool strictMatch); // 0x0000000180C71F60-0x0000000180C72110
				internal override ElementCount_Base GetAlternateElementCount(int index); // 0x000000018035FCC0-0x000000018035FCD0
				internal override bool ElementCountsMatch(BridgedControllerHWInfo bridgedControllerHWInfo, out bool alternateMatched); // 0x0000000180C70D70-0x0000000180C70E10
				private bool AnyNameMatches(BridgedControllerHWInfo bridgedControllerHWInfo); // 0x0000000180C6F670-0x0000000180C6F900
				private bool NameMatches(string name, string[] names, bool useRegex); // 0x0000000180C72320-0x0000000180C72450
				public override object DeepClone(); // 0x0000000180C70AD0-0x0000000180C70B40
				internal override void CopyVars(MatchingCriteria_Base destination); // 0x0000000180C70620-0x0000000180C707C0
			}
	
			[Serializable]
			[CustomClassObfuscation] // 0x00000001800D0530-0x00000001800D0560
			public sealed class Elements : Elements_Base // TypeDefIndex: 6207
			{
				// Fields
				public Axis[] axes; // 0x10
				public Button[] buttons; // 0x18
	
				// Properties
				public override int buttonCount { get; } // 0x00000001803951A0-0x00000001803951B0 
				public override int axisCount { get; } // 0x0000000180395190-0x00000001803951A0 
				internal IEnumerable<Axis> Axes { get; } // 0x0000000180C6ED50-0x0000000180C6EDD0 
				internal IEnumerable<Button> Buttons { get; } // 0x0000000180C6EE50-0x0000000180C6EED0 
	
				// Nested types
				[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
				private sealed class VnyIlJGNxbzdhVKGDNSaJmvmjDt : IEnumerable<Axis>, IEnumerator<Axis> // TypeDefIndex: 6208
				{
					// Fields
					private Axis aSrFEaALHwhGTdXfCdeUqgbwaZGO; // 0x10
					private int eLrUhJFgzEZElCzdKvcrgOLXLvL; // 0x18
					private int RQaeFqcJnaOYpZSBxtfUkVOjfOo; // 0x1C
					public Elements gKPmvKLRxdGbmXiMfUeDjGbezUo; // 0x20
					public int RDIGNTEYsGGGcPnUoJaYatxMQIGu; // 0x28
	
					// Properties
					Axis dYrcdAbGekmCeefejhcyEnMgOPn { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018036AC80-0x000000018036AC90 
					object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018036AC80-0x000000018036AC90 
	
					// Constructors
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					public VnyIlJGNxbzdhVKGDNSaJmvmjDt(int <>1__state); // 0x0000000180393A20-0x0000000180393A70
	
					// Methods
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					IEnumerator<Axis> System.Collections.Generic.IEnumerable<Rewired.Data.Mapping.HardwareJoystickMap.Platform_SDL2_Base.Axis>.GetEnumerator(); // 0x0000000180C80FE0-0x0000000180C810D0
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					IEnumerator IEnumerable.GetEnumerator(); // 0x0000000180C80FE0-0x0000000180C810D0
					private bool MoveNext(); // 0x0000000180C80EA0-0x0000000180C80FE0
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					void IEnumerator.Reset(); // 0x0000000180C810D0-0x0000000180C81120
					void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
				}
	
				[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
				private sealed class rWVWNdyfOBDyrMOIZPcHEEFfvlI : IEnumerable<Button>, IEnumerator<Button> // TypeDefIndex: 6209
				{
					// Fields
					private Button aSrFEaALHwhGTdXfCdeUqgbwaZGO; // 0x10
					private int eLrUhJFgzEZElCzdKvcrgOLXLvL; // 0x18
					private int RQaeFqcJnaOYpZSBxtfUkVOjfOo; // 0x1C
					public Elements gKPmvKLRxdGbmXiMfUeDjGbezUo; // 0x20
					public int qhFhsQmEjLIJaKwmGYvMIDsdOYE; // 0x28
	
					// Properties
					Button aaCYadWUVvfTeqVLjUBuiXYVHCh { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018036AC80-0x000000018036AC90 
					object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018036AC80-0x000000018036AC90 
	
					// Constructors
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					public rWVWNdyfOBDyrMOIZPcHEEFfvlI(int <>1__state); // 0x0000000180393A20-0x0000000180393A70
	
					// Methods
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					IEnumerator<Button> System.Collections.Generic.IEnumerable<Rewired.Data.Mapping.HardwareJoystickMap.Platform_SDL2_Base.Button>.GetEnumerator(); // 0x0000000180C82BA0-0x0000000180C82C90
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					IEnumerator IEnumerable.GetEnumerator(); // 0x0000000180C82BA0-0x0000000180C82C90
					private bool MoveNext(); // 0x0000000180C82A20-0x0000000180C82BA0
					[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
					void IEnumerator.Reset(); // 0x0000000180C82C90-0x0000000180C82CE0
					void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
				}
	
				// Constructors
				public Elements(); // 0x000000018037E800-0x000000018037E810
	
				// Methods
				internal Axis GetAxis(int axisIndex); // 0x0000000180C6D040-0x0000000180C6D0B0
				internal override ControllerElementType GetEffectiveElementIdentifierType(ControllerElementIdentifier elementIdentifier); // 0x0000000180C6E9A0-0x0000000180C6EB60
				internal override bool GetEffectiveAxisRange(ControllerElementIdentifier elementIdentifier, out AxisRange axisRange); // 0x0000000180C6DF50-0x0000000180C6E2A0
				public override object DeepClone(); // 0x0000000180C6CFD0-0x0000000180C6D040
				internal override void CopyVars(Elements_Base destination); // 0x0000000180C6CAB0-0x0000000180C6CB50
			}
	
			[Serializable]
			[CustomClassObfuscation] // 0x00000001800D0530-0x00000001800D0560
			public abstract class Element : IDeepCloneable // TypeDefIndex: 6210
			{
				// Constructors
				protected Element(); // 0x000000018036B6C0-0x000000018036B6D0
	
				// Methods
				public abstract object DeepClone();
				protected virtual void ImportVars(Element source); // 0x00000001803581E0-0x00000001803581F0
			}
	
			[Serializable]
			[CustomClassObfuscation] // 0x00000001800D0530-0x00000001800D0560
			public class Button : Element // TypeDefIndex: 6211
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
				public Button(); // 0x0000000180392B20-0x0000000180392B40
	
				// Methods
				public override object DeepClone(); // 0x0000000180C6C140-0x0000000180C6C1B0
				protected override void ImportVars(Element source); // 0x0000000180C6C310-0x0000000180C6C520
			}
	
			[Serializable]
			[CustomClassObfuscation] // 0x00000001800D0530-0x00000001800D0560
			public class Axis : Element // TypeDefIndex: 6212
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
				public Axis(); // 0x0000000180392630-0x0000000180392650
	
				// Methods
				public override object DeepClone(); // 0x0000000180C6AC70-0x0000000180C6AD00
				protected override void ImportVars(Element source); // 0x0000000180C6B230-0x0000000180C6B4C0
			}
	
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private sealed class GEZFpgkKgRxPvcRLmPGEHqGGNIyc : IEnumerable<Axis>, IEnumerator<Axis> // TypeDefIndex: 6213
			{
				// Fields
				private Axis aSrFEaALHwhGTdXfCdeUqgbwaZGO; // 0x10
				private int eLrUhJFgzEZElCzdKvcrgOLXLvL; // 0x18
				private int RQaeFqcJnaOYpZSBxtfUkVOjfOo; // 0x1C
				public Platform_SDL2_Base gKPmvKLRxdGbmXiMfUeDjGbezUo; // 0x20
				public int MkYcyrMpguQVynujwUqgSecgjnS; // 0x28
				public int kUZavVxuoFGTXaGHdihJOfOTqSsz; // 0x2C
	
				// Properties
				Axis dYrcdAbGekmCeefejhcyEnMgOPn { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018036AC80-0x000000018036AC90 
				object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018036AC80-0x000000018036AC90 
	
				// Constructors
				[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
				public GEZFpgkKgRxPvcRLmPGEHqGGNIyc(int <>1__state); // 0x0000000180C6F280-0x0000000180C6F2F0
	
				// Methods
				[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
				IEnumerator<Axis> System.Collections.Generic.IEnumerable<Rewired.Data.Mapping.HardwareJoystickMap.Platform_SDL2_Base.Axis>.GetEnumerator(); // 0x0000000180C6F130-0x0000000180C6F230
				[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
				IEnumerator IEnumerable.GetEnumerator(); // 0x0000000180C6F130-0x0000000180C6F230
				private bool MoveNext(); // 0x0000000180C6EF70-0x0000000180C6F130
				[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
				void IEnumerator.Reset(); // 0x0000000180C6F230-0x0000000180C6F280
				void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			}
	
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private sealed class ZHCkLrFdlfcmUCXrRbhCljEycoGg : IEnumerable<Button>, IEnumerator<Button> // TypeDefIndex: 6214
			{
				// Fields
				private Button aSrFEaALHwhGTdXfCdeUqgbwaZGO; // 0x10
				private int eLrUhJFgzEZElCzdKvcrgOLXLvL; // 0x18
				private int RQaeFqcJnaOYpZSBxtfUkVOjfOo; // 0x1C
				public Platform_SDL2_Base gKPmvKLRxdGbmXiMfUeDjGbezUo; // 0x20
				public int zCKwvnmhCVYBIHPFuFdarPHRZRk; // 0x28
				public int FBMUfvOhXnFxnWWJOEscwbYbcwl; // 0x2C
	
				// Properties
				Button aaCYadWUVvfTeqVLjUBuiXYVHCh { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018036AC80-0x000000018036AC90 
				object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018036AC80-0x000000018036AC90 
	
				// Constructors
				[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
				public ZHCkLrFdlfcmUCXrRbhCljEycoGg(int <>1__state); // 0x0000000180C817A0-0x0000000180C81820
	
				// Methods
				[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
				IEnumerator<Button> System.Collections.Generic.IEnumerable<Rewired.Data.Mapping.HardwareJoystickMap.Platform_SDL2_Base.Button>.GetEnumerator(); // 0x0000000180C81620-0x0000000180C81750
				[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
				IEnumerator IEnumerable.GetEnumerator(); // 0x0000000180C81620-0x0000000180C81750
				private bool MoveNext(); // 0x0000000180C81460-0x0000000180C81620
				[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
				void IEnumerator.Reset(); // 0x0000000180C81750-0x0000000180C817A0
				void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			}
	
			// Constructors
			public Platform_SDL2_Base(); // 0x000000018037E800-0x000000018037E810
	
			// Methods
			internal override bool Matches(BridgedControllerHWInfo BridgedControllerHWInfo, bool strictMatch, out int variantIndex, out Rewired.Data.Mapping.HardwareJoystickMap.Platform platformMap); // 0x0000000180C2EC00-0x0000000180C2EC60
			internal override string[] GetAxisNames(ControllerElementIdentifier[] identifiers); // 0x0000000180C7A660-0x0000000180C7A970
			internal override string[] GetEffectiveButtonNames(ControllerElementIdentifier[] identifiers); // 0x0000000180C7ABE0-0x0000000180C7AEB0
			internal override bool IsElementIdentifierMapped(int elementIdentifierId); // 0x0000000180C7B2B0-0x0000000180C7B620
			internal override void GetGameElementIdentifierIdMappings(out int[] buttons, out int[] axes); // 0x0000000180C7AEB0-0x0000000180C7B2B0
			internal override AxisCalibrationData[] GetAxisCalibrationData(); // 0x0000000180C79B00-0x0000000180C7A120
			internal override void GetAxisData(out AxisRange[] axisRanges, out HardwareAxisInfo[] axisInfos); // 0x0000000180C7A120-0x0000000180C7A660
			internal override void GetButtonData(out HardwareButtonInfo[] buttonInfos); // 0x0000000180C7A970-0x0000000180C7AB90
			internal override ControllerElementType GetEffectiveElementIdentifierType(ControllerElementIdentifier elementIdentifier); // 0x000000018039BA80-0x000000018039BAA0
			internal override bool GetEffectiveAxisRange(ControllerElementIdentifier elementIdentifier, out AxisRange axisRange); // 0x0000000180C7AB90-0x0000000180C7ABE0
			internal IEnumerable<Axis> IterateAxes(); // 0x0000000180C7B620-0x0000000180C7B6C0
			internal IEnumerable<Button> IterateButtons(); // 0x0000000180C7B6C0-0x0000000180C7B730
			public override object DeepClone(); // 0x0000000180C79A90-0x0000000180C79B00
			internal override void CopyVars(Rewired.Data.Mapping.HardwareJoystickMap.Platform destination); // 0x0000000180C799D0-0x0000000180C79A90
		}
	
		[Serializable]
		[CustomClassObfuscation] // 0x00000001800D0530-0x00000001800D0560
		public sealed class Platform_SDL2 : Platform_SDL2_Base // TypeDefIndex: 6215
		{
			// Fields
			public Platform_SDL2_Base[] variants; // 0x28
	
			// Properties
			internal override IList<Rewired.Data.Mapping.HardwareJoystickMap.Platform> variants_base { get; } // 0x0000000180369B60-0x0000000180369B70 
	
			// Constructors
			public Platform_SDL2(); // 0x000000018037E800-0x000000018037E810
	
			// Methods
			internal override bool Matches(BridgedControllerHWInfo BridgedControllerHWInfo, bool strictMatch, out int variantIndex, out Rewired.Data.Mapping.HardwareJoystickMap.Platform platformMap); // 0x0000000180C7B8E0-0x0000000180C7BAD0
			public override object DeepClone(); // 0x0000000180C7B870-0x0000000180C7B8E0
			internal override void CopyVars(Rewired.Data.Mapping.HardwareJoystickMap.Platform destination); // 0x0000000180C7B730-0x0000000180C7B870
		}
	
		[Serializable]
		[CustomClassObfuscation] // 0x00000001800D0530-0x00000001800D0560
		public class Platform_Steam_Base : Rewired.Data.Mapping.HardwareJoystickMap.Platform // TypeDefIndex: 6216
		{
			// Fields
			public MatchingCriteria matchingCriteria; // 0x18
			public Elements elements; // 0x20
	
			// Properties
			public override int assignedButtonCount { get; } // 0x000000018039C420-0x000000018039C440 
			public override int assignedAxisCount { get; } // 0x000000018039C400-0x000000018039C420 
			internal override InputPlatform platform { get; } // 0x00000001809E6D30-0x00000001809E6D40 
			internal override bool hasData { get; } // 0x000000018039C450-0x000000018039C4C0 
			internal override bool disabled { get; } // 0x000000018039C440-0x000000018039C450 
			internal override bool isAllowed { get; } // 0x000000018039C4C0-0x000000018039C500 
			internal override Elements_Base elements_base { get; } // 0x000000018036AC70-0x000000018036AC80 
			internal override IList<Rewired.Data.Mapping.HardwareJoystickMap.Platform> variants_base { get; } // 0x000000018035FCC0-0x000000018035FCD0 
	
			// Nested types
			[Serializable]
			[CustomClassObfuscation] // 0x00000001800D0530-0x00000001800D0560
			public sealed class MatchingCriteria : MatchingCriteria_Base // TypeDefIndex: 6217
			{
				// Properties
				internal override bool hasData { get; } // 0x00000001803C29F0-0x00000001803C2A00 
				internal override bool isAllowed { get; } // 0x000000018039A1E0-0x000000018039A200 
				internal override int alternateElementCount { get; } // 0x000000018035FCC0-0x000000018035FCD0 
	
				// Constructors
				public MatchingCriteria(); // 0x000000018037E800-0x000000018037E810
	
				// Methods
				internal override bool Matches(BridgedControllerHWInfo bridgedControllerHWInfo, bool strictMatch); // 0x0000000180C71970-0x0000000180C71A20
				internal override ElementCount_Base GetAlternateElementCount(int index); // 0x000000018035FCC0-0x000000018035FCD0
				internal override bool ElementCountsMatch(BridgedControllerHWInfo bridgedControllerHWInfo, out bool alternateMatched); // 0x0000000180399A70-0x0000000180399A80
				public override object DeepClone(); // 0x0000000180C70C20-0x0000000180C70C90
				internal override void CopyVars(MatchingCriteria_Base destination); // 0x0000000180C70440-0x0000000180C70490
			}
	
			[Serializable]
			[CustomClassObfuscation] // 0x00000001800D0530-0x00000001800D0560
			public sealed class Elements : Elements_Base // TypeDefIndex: 6218
			{
				// Properties
				public override int buttonCount { get; } // 0x000000018035FCC0-0x000000018035FCD0 
				public override int axisCount { get; } // 0x000000018035FCC0-0x000000018035FCD0 
	
				// Constructors
				public Elements(); // 0x000000018037E800-0x000000018037E810
	
				// Methods
				public override object DeepClone(); // 0x0000000180C6CE10-0x0000000180C6CE80
				internal override void CopyVars(Elements_Base destination); // 0x0000000180C6CA60-0x0000000180C6CAB0
				internal override ControllerElementType GetEffectiveElementIdentifierType(ControllerElementIdentifier elementIdentifier); // 0x0000000180C6EB60-0x0000000180C6EB80
				internal override bool GetEffectiveAxisRange(ControllerElementIdentifier elementIdentifier, out AxisRange axisRange); // 0x0000000180C6D470-0x0000000180C6D480
			}
	
			// Constructors
			public Platform_Steam_Base(); // 0x000000018037E800-0x000000018037E810
	
			// Methods
			internal override bool Matches(BridgedControllerHWInfo BridgedControllerHWInfo, bool strictMatch, out int variantIndex, out Rewired.Data.Mapping.HardwareJoystickMap.Platform platformMap); // 0x0000000180C7E340-0x0000000180C7E3C0
			internal override string[] GetAxisNames(ControllerElementIdentifier[] identifiers); // 0x0000000180C7E220-0x0000000180C7E260
			internal override string[] GetEffectiveButtonNames(ControllerElementIdentifier[] identifiers); // 0x0000000180C7E2A0-0x0000000180C7E2E0
			internal override bool IsElementIdentifierMapped(int elementIdentifierId); // 0x00000001803C28F0-0x00000001803C2900
			internal override void GetGameElementIdentifierIdMappings(out int[] buttons, out int[] axes); // 0x0000000180C7E2E0-0x0000000180C7E340
			internal override AxisCalibrationData[] GetAxisCalibrationData(); // 0x0000000180C7E180-0x0000000180C7E1C0
			internal override void GetAxisData(out AxisRange[] axisRanges, out HardwareAxisInfo[] axisInfos); // 0x0000000180C7E1C0-0x0000000180C7E220
			internal override void GetButtonData(out HardwareButtonInfo[] buttonInfos); // 0x0000000180C7E260-0x0000000180C7E2A0
			internal override ControllerElementType GetEffectiveElementIdentifierType(ControllerElementIdentifier elementIdentifier); // 0x000000018039BA80-0x000000018039BAA0
			internal override bool GetEffectiveAxisRange(ControllerElementIdentifier elementIdentifier, out AxisRange axisRange); // 0x000000018039B710-0x000000018039B740
			public override object DeepClone(); // 0x0000000180C7E110-0x0000000180C7E180
			internal override void CopyVars(Rewired.Data.Mapping.HardwareJoystickMap.Platform destination); // 0x0000000180C7DFF0-0x0000000180C7E110
		}
	
		[Serializable]
		[CustomClassObfuscation] // 0x00000001800D0530-0x00000001800D0560
		public sealed class Platform_Steam : Platform_Steam_Base // TypeDefIndex: 6219
		{
			// Fields
			public Platform_Steam_Base[] variants; // 0x28
	
			// Properties
			internal override IList<Rewired.Data.Mapping.HardwareJoystickMap.Platform> variants_base { get; } // 0x0000000180369B60-0x0000000180369B70 
	
			// Constructors
			public Platform_Steam(); // 0x000000018037E800-0x000000018037E810
	
			// Methods
			internal override bool Matches(BridgedControllerHWInfo BridgedControllerHWInfo, bool strictMatch, out int variantIndex, out Rewired.Data.Mapping.HardwareJoystickMap.Platform platformMap); // 0x0000000180C7E5E0-0x0000000180C7E7A0
			public override object DeepClone(); // 0x0000000180C7E560-0x0000000180C7E5E0
			internal override void CopyVars(Rewired.Data.Mapping.HardwareJoystickMap.Platform destination); // 0x0000000180C7E3C0-0x0000000180C7E560
		}
	
		[Serializable]
		[CustomClassObfuscation] // 0x00000001800D0530-0x00000001800D0560
		public class Platform_WebGL_Base : Platform_Custom // TypeDefIndex: 6220
		{
			// Fields
			public MatchingCriteria matchingCriteria; // 0x18
			public Elements elements; // 0x20
			private Axis[] _axesOrigGame; // 0x28
			private Button[] _buttonsOrigGame; // 0x30
	
			// Properties
			public override int assignedButtonCount { get; } // 0x000000018039C420-0x000000018039C440 
			public override int assignedAxisCount { get; } // 0x000000018039C400-0x000000018039C420 
			internal override InputPlatform platform { get; } // 0x00000001809EA230-0x00000001809EA240 
			internal override Axis[] Axes { get; } // 0x0000000180C80660-0x0000000180C80860 
			internal override Button[] Buttons { get; } // 0x0000000180C80860-0x0000000180C80A60 
			internal Axis[] Axes_orig { get; } // 0x000000018039C3E0-0x000000018039C3F0 
			internal Button[] Buttons_orig { get; } // 0x000000018039C3F0-0x000000018039C400 
			internal override bool hasData { get; } // 0x0000000180C2F000-0x0000000180C2F070 
			internal override bool disabled { get; } // 0x000000018039C440-0x000000018039C450 
			internal override bool isAllowed { get; } // 0x0000000180C80A60-0x0000000180C80AB0 
			internal override Elements_Base elements_base { get; } // 0x000000018036AC70-0x000000018036AC80 
			internal override IList<Rewired.Data.Mapping.HardwareJoystickMap.Platform> variants_base { get; } // 0x000000018035FCC0-0x000000018035FCD0 
	
			// Nested types
			[Serializable]
			[CustomClassObfuscation] // 0x00000001800D0530-0x00000001800D0560
			public sealed class MatchingCriteria : Platform_Custom.MatchingCriteria // TypeDefIndex: 6221
			{
				// Fields
				public bool productName_useRegex; // 0x30
				public string[] productName; // 0x38
				public string[] productGUID; // 0x40
				public int[] mapping; // 0x48
				public ElementCount_Base[] elementCount; // 0x50
				public ClientInfo[] clientInfo; // 0x58
	
				// Properties
				internal override bool hasData { get; } // 0x0000000180C72710-0x0000000180C727D0 
				internal override bool isAllowed { get; } // 0x000000018039A200-0x000000018039A230 
	
				// Nested types
				[Serializable]
				public sealed class ClientInfo : IDeepCloneable // TypeDefIndex: 6222
				{
					// Fields
					public int browser; // 0x10
					public string browserVersionMin; // 0x18
					public string browserVersionMax; // 0x20
					public int os; // 0x28
					public string osVersionMin; // 0x30
					public string osVersionMax; // 0x38
	
					// Constructors
					public ClientInfo(); // 0x000000018036B6C0-0x000000018036B6D0
	
					// Methods
					public object DeepClone(); // 0x0000000180392B40-0x0000000180392C00
				}
	
				// Constructors
				public MatchingCriteria(); // 0x0000000180363710-0x0000000180363720
	
				// Methods
				internal override bool Matches(BridgedControllerHWInfo bridgedControllerHWInfo, bool strictMatch); // 0x0000000180C70EB0-0x0000000180C718C0
				private static bool CheckBrowserVersion(int browser, string versionMin, string versionMax, string[] currentVersion); // 0x0000000180C6F900-0x0000000180C6FEB0
				private static bool CheckOSVersion(string versionMin, string versionMax, string[] currentVersion); // 0x0000000180C6FEB0-0x0000000180C70440
				public override object DeepClone(); // 0x0000000180C70BB0-0x0000000180C70C20
				internal override void CopyVars(MatchingCriteria_Base destination); // 0x0000000180C70490-0x0000000180C70620
			}
	
			[Serializable]
			[CustomClassObfuscation] // 0x00000001800D0530-0x00000001800D0560
			public sealed class Elements : Platform_Custom.Elements // TypeDefIndex: 6223
			{
				// Fields
				public Axis[] axes; // 0x10
				public Button[] buttons; // 0x18
	
				// Properties
				public override int buttonCount { get; } // 0x00000001803951A0-0x00000001803951B0 
				public override int axisCount { get; } // 0x0000000180395190-0x00000001803951A0 
	
				// Constructors
				public Elements(); // 0x0000000180363710-0x0000000180363720
	
				// Methods
				internal override ControllerElementType GetEffectiveElementIdentifierType(ControllerElementIdentifier elementIdentifier); // 0x0000000180C6E7D0-0x0000000180C6E9A0
				internal override bool GetEffectiveAxisRange(ControllerElementIdentifier elementIdentifier, out AxisRange axisRange); // 0x0000000180C6D740-0x0000000180C6D9E0
				public override object DeepClone(); // 0x0000000180C6CE80-0x0000000180C6CEF0
				internal override void CopyVars(Elements_Base destination); // 0x0000000180C6CBE0-0x0000000180C6CCA0
			}
	
			[Serializable]
			[CustomClassObfuscation] // 0x00000001800D0530-0x00000001800D0560
			public sealed class Button : Platform_Custom.Button // TypeDefIndex: 6224
			{
				// Constructors
				public Button(); // 0x000000018037E800-0x000000018037E810
	
				// Methods
				public override object DeepClone(); // 0x0000000180C6BED0-0x0000000180C6BF40
				internal override void CopyVars(Platform_Custom.Element destination); // 0x0000000180C6BD00-0x0000000180C6BD50
			}
	
			[Serializable]
			[CustomClassObfuscation] // 0x00000001800D0530-0x00000001800D0560
			public sealed class Axis : Platform_Custom.Axis // TypeDefIndex: 6225
			{
				// Constructors
				public Axis(); // 0x000000018037E800-0x000000018037E810
	
				// Methods
				public override object DeepClone(); // 0x0000000180C6AED0-0x0000000180C6AF40
				internal override void CopyVars(Platform_Custom.Element destination); // 0x0000000180C6AB10-0x0000000180C6AB60
			}
	
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private sealed class tmBcGMhQxnjkGDfnIBFgECdDEcTp : IEnumerable<Axis>, IEnumerator<Axis> // TypeDefIndex: 6226
			{
				// Fields
				private Platform_Custom.Axis aSrFEaALHwhGTdXfCdeUqgbwaZGO; // 0x10
				private int eLrUhJFgzEZElCzdKvcrgOLXLvL; // 0x18
				private int RQaeFqcJnaOYpZSBxtfUkVOjfOo; // 0x1C
				public Platform_WebGL_Base gKPmvKLRxdGbmXiMfUeDjGbezUo; // 0x20
				public int RouWpZWgcGMaNYbSoGLLgSFGnac; // 0x28
	
				// Properties
				Platform_Custom.Axis lmiaTpCsaXfKxySEjXIZoypgnjMr { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018036AC80-0x000000018036AC90 
				object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018036AC80-0x000000018036AC90 
	
				// Constructors
				[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
				public tmBcGMhQxnjkGDfnIBFgECdDEcTp(int <>1__state); // 0x0000000180393A20-0x0000000180393A70
	
				// Methods
				[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
				IEnumerator<Platform_Custom.Axis> System.Collections.Generic.IEnumerable<Rewired.Data.Mapping.HardwareJoystickMap.Platform_Custom.Axis>.GetEnumerator(); // 0x00000001803C1160-0x00000001803C1260
				[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
				IEnumerator IEnumerable.GetEnumerator(); // 0x00000001803C1160-0x00000001803C1260
				private bool MoveNext(); // 0x00000001803C0FC0-0x00000001803C1160
				[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
				void IEnumerator.Reset(); // 0x00000001803C1260-0x00000001803C12B0
				void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			}
	
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private sealed class IwhbaTGEaCEzBRlaCpARhqtjKmQC : IEnumerable<Button>, IEnumerator<Button> // TypeDefIndex: 6227
			{
				// Fields
				private Platform_Custom.Button aSrFEaALHwhGTdXfCdeUqgbwaZGO; // 0x10
				private int eLrUhJFgzEZElCzdKvcrgOLXLvL; // 0x18
				private int RQaeFqcJnaOYpZSBxtfUkVOjfOo; // 0x1C
				public Platform_WebGL_Base gKPmvKLRxdGbmXiMfUeDjGbezUo; // 0x20
				public int hdYsEDGHUoTnnwMkZZXRWpgIwxb; // 0x28
	
				// Properties
				Platform_Custom.Button PlYXfEMpMbXcHXTJgpApbDPxYUh { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018036AC80-0x000000018036AC90 
				object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018036AC80-0x000000018036AC90 
	
				// Constructors
				[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
				public IwhbaTGEaCEzBRlaCpARhqtjKmQC(int <>1__state); // 0x0000000180C6F600-0x0000000180C6F670
	
				// Methods
				[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
				IEnumerator<Platform_Custom.Button> System.Collections.Generic.IEnumerable<Rewired.Data.Mapping.HardwareJoystickMap.Platform_Custom.Button>.GetEnumerator(); // 0x0000000180C6F480-0x0000000180C6F5B0
				[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
				IEnumerator IEnumerable.GetEnumerator(); // 0x0000000180C6F480-0x0000000180C6F5B0
				private bool MoveNext(); // 0x0000000180C6F2F0-0x0000000180C6F480
				[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
				void IEnumerator.Reset(); // 0x0000000180C6F5B0-0x0000000180C6F600
				void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			}
	
			// Constructors
			public Platform_WebGL_Base(); // 0x0000000180363710-0x0000000180363720
	
			// Methods
			internal override bool Matches(BridgedControllerHWInfo BridgedControllerHWInfo, bool strictMatch, out int variantIndex, out Rewired.Data.Mapping.HardwareJoystickMap.Platform platformMap); // 0x0000000180C805A0-0x0000000180C80660
			internal override IEnumerable<Axis> IterateAxes(); // 0x0000000180C80470-0x0000000180C80500
			internal override IEnumerable<Button> IterateButtons(); // 0x0000000180C80500-0x0000000180C805A0
			internal override string[] GetAxisNames(ControllerElementIdentifier[] identifiers); // 0x0000000180C7F440-0x0000000180C7F710
			internal override string[] GetEffectiveButtonNames(ControllerElementIdentifier[] identifiers); // 0x0000000180C7F960-0x0000000180C7FC60
			internal override bool IsElementIdentifierMapped(int elementIdentifierId); // 0x0000000180C80130-0x0000000180C80470
			internal override void GetGameElementIdentifierIdMappings(out int[] buttons, out int[] axes); // 0x0000000180C7FC60-0x0000000180C80130
			internal override AxisCalibrationData[] GetAxisCalibrationData(); // 0x0000000180C7E910-0x0000000180C7EF70
			internal override void GetAxisData(out AxisRange[] axisRanges, out HardwareAxisInfo[] axisInfos); // 0x0000000180C7EF70-0x0000000180C7F440
			internal override void GetButtonData(out HardwareButtonInfo[] buttonInfos); // 0x0000000180C7F710-0x0000000180C7F960
			internal override ControllerElementType GetEffectiveElementIdentifierType(ControllerElementIdentifier elementIdentifier); // 0x000000018039BA80-0x000000018039BAA0
			internal override bool GetEffectiveAxisRange(ControllerElementIdentifier elementIdentifier, out AxisRange axisRange); // 0x000000018039B710-0x000000018039B740
			public override object DeepClone(); // 0x0000000180C7E880-0x0000000180C7E910
			internal override void CopyVars(Rewired.Data.Mapping.HardwareJoystickMap.Platform destination); // 0x0000000180C7E7A0-0x0000000180C7E880
		}
	
		[Serializable]
		[CustomClassObfuscation] // 0x00000001800D0530-0x00000001800D0560
		public sealed class Platform_WebGL : Platform_WebGL_Base // TypeDefIndex: 6228
		{
			// Fields
			public Platform_WebGL_Base[] variants; // 0x38
	
			// Properties
			internal override IList<Rewired.Data.Mapping.HardwareJoystickMap.Platform> variants_base { get; } // 0x0000000180369BB0-0x0000000180369BC0 
	
			// Constructors
			public Platform_WebGL(); // 0x0000000180363710-0x0000000180363720
	
			// Methods
			internal override bool Matches(BridgedControllerHWInfo BridgedControllerHWInfo, bool strictMatch, out int variantIndex, out Rewired.Data.Mapping.HardwareJoystickMap.Platform platformMap); // 0x0000000180C80C80-0x0000000180C80EA0
			public override object DeepClone(); // 0x0000000180C80C10-0x0000000180C80C80
			internal override void CopyVars(Rewired.Data.Mapping.HardwareJoystickMap.Platform destination); // 0x0000000180C80AB0-0x0000000180C80C10
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class dGRMznpLGnCWObVzUPXeWKFSyQb : IEnumerable<Guid>, IEnumerator<Guid> // TypeDefIndex: 6229
		{
			// Fields
			private Guid aSrFEaALHwhGTdXfCdeUqgbwaZGO; // 0x10
			private int eLrUhJFgzEZElCzdKvcrgOLXLvL; // 0x20
			private int RQaeFqcJnaOYpZSBxtfUkVOjfOo; // 0x24
			public HardwareJoystickMap gKPmvKLRxdGbmXiMfUeDjGbezUo; // 0x28
			public int ZKnOmfdBGxPCzuiOaEmmaNwByyN; // 0x30
	
			// Properties
			Guid wPhFNVGruwsEitgnJFTcdPyIZsIV { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x00000001803C0030-0x00000001803C0040 
			object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x00000001803C0090-0x00000001803C00E0 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public dGRMznpLGnCWObVzUPXeWKFSyQb(int <>1__state); // 0x00000001803C00E0-0x00000001803C0130
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			IEnumerator<Guid> IEnumerable<Guid>.GetEnumerator(); // 0x00000001803BFF30-0x00000001803C0030
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			IEnumerator IEnumerable.GetEnumerator(); // 0x00000001803BFF30-0x00000001803C0030
			private bool MoveNext(); // 0x00000001803BFD60-0x00000001803BFF30
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x00000001803C0040-0x00000001803C0090
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class ySbjvvDALvBUwVngEYkutLawAYM : IEnumerable<ControllerElementIdentifier>, IEnumerator<ControllerElementIdentifier> // TypeDefIndex: 6230
		{
			// Fields
			private ControllerElementIdentifier aSrFEaALHwhGTdXfCdeUqgbwaZGO; // 0x10
			private int eLrUhJFgzEZElCzdKvcrgOLXLvL; // 0x18
			private int RQaeFqcJnaOYpZSBxtfUkVOjfOo; // 0x1C
			public HardwareJoystickMap gKPmvKLRxdGbmXiMfUeDjGbezUo; // 0x20
			public int PjYtuicjXGalARRYfcvVGxZVBdI; // 0x28
	
			// Properties
			ControllerElementIdentifier QmgYVYcGXUPSkQvXLtYdUlBXEfB { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018036AC80-0x000000018036AC90 
			object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018036AC80-0x000000018036AC90 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public ySbjvvDALvBUwVngEYkutLawAYM(int <>1__state); // 0x0000000180393A20-0x0000000180393A70
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			IEnumerator<ControllerElementIdentifier> IEnumerable<ControllerElementIdentifier>.GetEnumerator(); // 0x00000001803C1700-0x00000001803C1820
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			IEnumerator IEnumerable.GetEnumerator(); // 0x00000001803C1700-0x00000001803C1820
			private bool MoveNext(); // 0x00000001803C15B0-0x00000001803C1700
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x00000001803C1820-0x00000001803C18D0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class eFSWDCwnTJdZvbPDKOvWTjjZkVJd : IEnumerable<JoystickType>, IEnumerator<JoystickType> // TypeDefIndex: 6231
		{
			// Fields
			private JoystickType aSrFEaALHwhGTdXfCdeUqgbwaZGO; // 0x10
			private int eLrUhJFgzEZElCzdKvcrgOLXLvL; // 0x14
			private int RQaeFqcJnaOYpZSBxtfUkVOjfOo; // 0x18
			public HardwareJoystickMap gKPmvKLRxdGbmXiMfUeDjGbezUo; // 0x20
			public int IiqAOvtVNlCuKCmYJrKqAvSPedRP; // 0x28
	
			// Properties
			JoystickType hlflTucGxtvsPFCUNWteonLmNrf { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018036CFF0-0x000000018036D000 
			object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x00000001803C0400-0x00000001803C0450 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public eFSWDCwnTJdZvbPDKOvWTjjZkVJd(int <>1__state); // 0x00000001803C0450-0x00000001803C04A0
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			IEnumerator<JoystickType> IEnumerable<JoystickType>.GetEnumerator(); // 0x00000001803C0280-0x00000001803C03B0
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			IEnumerator IEnumerable.GetEnumerator(); // 0x00000001803C0280-0x00000001803C03B0
			private bool MoveNext(); // 0x00000001803C0130-0x00000001803C0280
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x00000001803C03B0-0x00000001803C0400
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class iWxdQKamXdhylHenKJlqqUxaoEG : IEnumerable<IControllerElementIdentifierCommon_Internal>, IEnumerator<IControllerElementIdentifierCommon_Internal> // TypeDefIndex: 6232
		{
			// Fields
			private IControllerElementIdentifierCommon_Internal aSrFEaALHwhGTdXfCdeUqgbwaZGO; // 0x10
			private int eLrUhJFgzEZElCzdKvcrgOLXLvL; // 0x18
			private int RQaeFqcJnaOYpZSBxtfUkVOjfOo; // 0x1C
			public HardwareJoystickMap gKPmvKLRxdGbmXiMfUeDjGbezUo; // 0x20
			public int CVuVYRUyKDQHENvKvQkTKDOtumC; // 0x28
	
			// Properties
			IControllerElementIdentifierCommon_Internal kPWOkKKCGAiizbmYmSqjRLfSZWGa { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018036AC80-0x000000018036AC90 
			object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018036AC80-0x000000018036AC90 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public iWxdQKamXdhylHenKJlqqUxaoEG(int <>1__state); // 0x0000000180393A20-0x0000000180393A70
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			IEnumerator<IControllerElementIdentifierCommon_Internal> IEnumerable<IControllerElementIdentifierCommon_Internal>.GetEnumerator(); // 0x00000001803C0600-0x00000001803C0720
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			IEnumerator IEnumerable.GetEnumerator(); // 0x00000001803C0600-0x00000001803C0720
			private bool MoveNext(); // 0x00000001803C04A0-0x00000001803C0600
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x00000001803C0720-0x00000001803C0770
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		}
	
		// Constructors
		public HardwareJoystickMap(); // 0x00000001805ED350-0x00000001805ED960
		public HardwareJoystickMap(HardwareJoystickMap source); // 0x00000001805ED960-0x00000001805EEE90
	
		// Methods
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		public string[] GetElementIdentifierNames(); // 0x00000001805EBE60-0x00000001805EBFD0
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		public int[] GetElementIdentifierIds(); // 0x00000001805EB870-0x00000001805EBA10
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		public ControllerElementIdentifier GetElementIdentifier(int id); // 0x00000001805EBFD0-0x00000001805EC060
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		public bool ContainsElementIdentifier(int id); // 0x00000001805E9EE0-0x00000001805E9F00
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		public int GetElementIdentifierInfo(ControllerElementType type, out string[] names, out int[] ids); // 0x00000001805EBA10-0x00000001805EBE60
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		public int GetMappableElementIdentifierInfo(out string[] names, out int[] ids); // 0x00000001805EC100-0x00000001805EC540
		internal HardwareJoystickMap Clone(); // 0x00000001805E9E80-0x00000001805E9EE0
		internal int IndexOfElementIdentifier(int id); // 0x00000001805ECA60-0x00000001805ECAE0
		internal ControllerElementType GetEffectiveElementIdentifierType(HardwareControllerMapIdentifier hardwareMapIdentifier, int elementIdentifierId, bool isDefaultMap); // 0x00000001805EB7D0-0x00000001805EB870
		internal bool GetEffectiveAxisRange(HardwareControllerMapIdentifier hardwareMapIdentifier, int elementIdentifierId, bool isDefaultMap, out AxisRange axisRange); // 0x00000001805EB730-0x00000001805EB7D0
		internal void GetElementIdentifiersForControllerElements(HardwareControllerMapIdentifier hardwareMapIdentifier, bool isDefaultMap, out int[] buttons, out int[] axes); // 0x00000001805EC060-0x00000001805EC100
		internal static bool Matches(Platform platform, BridgedControllerHWInfo bridgedControllerHWInfo, bool strictMatch, out int variantIndex, out Platform platformMap); // 0x00000001805ED280-0x00000001805ED2D0
		internal bool Matches(BridgedControllerHWInfo bridgedControllerHWInfo, bool strictMatch, bool isDefaultMap, out InputPlatform actualInputPlatform, out int variantIndex, out Platform platformMap); // 0x00000001805ECAE0-0x00000001805ED280
		internal HardwareJoystickMap_InputManager GetDefaultHardwareJoystickMap_InputManager(InputSource inputSource); // 0x00000001805EB1F0-0x00000001805EB730
		internal string[] GetTemplateGuidsOrig(); // 0x0000000180369BB0-0x0000000180369BC0
		IControllerElementIdentifierCommon_Internal IHardwareControllerMap_Internal.GetElementIdentifier(int id); // 0x00000001805ED2D0-0x00000001805ED2E0
		private Platform_Fallback_Base FindFallbackMatch(BridgedControllerHWInfo bridgedControllerHWInfo, bool strictMatch, bool isDefaultMap, out InputPlatform actualInputPlatform, out int variantIndex); // 0x00000001805EA750-0x00000001805EADD0
		private Platform_Fallback_Base FindFallbackMap(InputSource inputSource, bool isDefaultMap, out InputPlatform actualInputPlatform, out int variantIndex); // 0x00000001805E9F00-0x00000001805EA750
		private Platform_SDL2_Base FindSDL2Match(BridgedControllerHWInfo bridgedControllerHWInfo, bool strictMatch, bool isDefaultMap, out InputPlatform actualInputPlatform, out int variantIndex); // 0x00000001805EAFF0-0x00000001805EB1F0
		private Platform_SDL2_Base FindSDL2Map(InputSource inputSource, bool isDefaultMap, out InputPlatform actualInputPlatform, out int variantIndex); // 0x00000001805EADD0-0x00000001805EAFF0
		private T TryGetFirstValidMap<T>(T mainMap, bool isDefaultMap, ref InputPlatform actualInputPlatform, out int variantIndex)
			where T : Platform;
		private T TryGetFirstMatchingMap<T>(T mainMap, BridgedControllerHWInfo bridgedControllerHWInfo, bool strictMatch, bool isDefaultMap, ref InputPlatform actualInputPlatform, out int variantIndex)
			where T : Platform;
		private T GetUniversalDefaultMap<T>(out InputPlatform actualInputPlatform, out int variantIndex)
			where T : Platform;
		private T GetUniversalDefaultMapRoot<T>(Type type, out InputPlatform actualInputPlatform)
			where T : Platform;
		private Platform GetSpecificPlatformMap(HardwareControllerMapIdentifier hardwareMapIdentifier); // 0x00000001805EC540-0x00000001805EC630
		private Platform GetSpecificPlatformRoot(InputPlatform exactInputPlatform); // 0x00000001805EC630-0x00000001805ECA60
	}
}
