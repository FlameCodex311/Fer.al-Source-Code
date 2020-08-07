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
using Rewired.Data.Mapping;
using UnityEngine;

// Image 51: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5871-7113

namespace Rewired.Data
{
	[Serializable]
	public sealed class UserData // TypeDefIndex: 6423
	{
		// Fields
		[CustomObfuscation] // 0x00000001801D00E0-0x00000001801D0120
		[SerializeField] // 0x00000001801D00E0-0x00000001801D0120
		private ConfigVars configVars; // 0x10
		[CustomObfuscation] // 0x00000001801D1070-0x00000001801D10B0
		[SerializeField] // 0x00000001801D1070-0x00000001801D10B0
		private List<Player_Editor> players; // 0x18
		[CustomObfuscation] // 0x00000001801D1070-0x00000001801D10B0
		[SerializeField] // 0x00000001801D1070-0x00000001801D10B0
		private List<InputAction> actions; // 0x20
		[CustomObfuscation] // 0x00000001801D1070-0x00000001801D10B0
		[SerializeField] // 0x00000001801D1070-0x00000001801D10B0
		private List<InputCategory> actionCategories; // 0x28
		[CustomObfuscation] // 0x00000001801D1070-0x00000001801D10B0
		[SerializeField] // 0x00000001801D1070-0x00000001801D10B0
		private ActionCategoryMap actionCategoryMap; // 0x30
		[CustomObfuscation] // 0x00000001801D00E0-0x00000001801D0120
		[SerializeField] // 0x00000001801D00E0-0x00000001801D0120
		private List<InputBehavior> inputBehaviors; // 0x38
		[CustomObfuscation] // 0x00000001801D00E0-0x00000001801D0120
		[SerializeField] // 0x00000001801D00E0-0x00000001801D0120
		private List<InputMapCategory> mapCategories; // 0x40
		[CustomObfuscation] // 0x00000001801D00E0-0x00000001801D0120
		[SerializeField] // 0x00000001801D00E0-0x00000001801D0120
		private List<InputLayout> joystickLayouts; // 0x48
		[CustomObfuscation] // 0x00000001801D00E0-0x00000001801D0120
		[SerializeField] // 0x00000001801D00E0-0x00000001801D0120
		private List<InputLayout> keyboardLayouts; // 0x50
		[CustomObfuscation] // 0x00000001801D1070-0x00000001801D10B0
		[SerializeField] // 0x00000001801D1070-0x00000001801D10B0
		private List<InputLayout> mouseLayouts; // 0x58
		[CustomObfuscation] // 0x00000001801D1070-0x00000001801D10B0
		[SerializeField] // 0x00000001801D1070-0x00000001801D10B0
		private List<InputLayout> customControllerLayouts; // 0x60
		[CustomObfuscation] // 0x00000001801D1070-0x00000001801D10B0
		[SerializeField] // 0x00000001801D1070-0x00000001801D10B0
		private List<ControllerMap_Editor> joystickMaps; // 0x68
		[CustomObfuscation] // 0x00000001801D00E0-0x00000001801D0120
		[SerializeField] // 0x00000001801D00E0-0x00000001801D0120
		private List<ControllerMap_Editor> keyboardMaps; // 0x70
		[CustomObfuscation] // 0x00000001801D1070-0x00000001801D10B0
		[SerializeField] // 0x00000001801D1070-0x00000001801D10B0
		private List<ControllerMap_Editor> mouseMaps; // 0x78
		[CustomObfuscation] // 0x00000001801D1070-0x00000001801D10B0
		[SerializeField] // 0x00000001801D1070-0x00000001801D10B0
		private List<ControllerMap_Editor> customControllerMaps; // 0x80
		[CustomObfuscation] // 0x00000001801D1070-0x00000001801D10B0
		[SerializeField] // 0x00000001801D1070-0x00000001801D10B0
		private List<CustomController_Editor> customControllers; // 0x88
		[CustomObfuscation] // 0x00000001801D00E0-0x00000001801D0120
		[SerializeField] // 0x00000001801D00E0-0x00000001801D0120
		private List<ControllerMapLayoutManager_RuleSet_Editor> controllerMapLayoutManagerRuleSets; // 0x90
		[CustomObfuscation] // 0x00000001801D1070-0x00000001801D10B0
		[SerializeField] // 0x00000001801D1070-0x00000001801D10B0
		private List<ControllerMapEnabler_RuleSet_Editor> controllerMapEnablerRuleSets; // 0x98
		[CustomObfuscation] // 0x00000001801D1070-0x00000001801D10B0
		[SerializeField] // 0x00000001801D1070-0x00000001801D10B0
		private int playerIdCounter; // 0xA0
		[CustomObfuscation] // 0x00000001801D1070-0x00000001801D10B0
		[SerializeField] // 0x00000001801D1070-0x00000001801D10B0
		private int actionIdCounter; // 0xA4
		[CustomObfuscation] // 0x00000001801D00E0-0x00000001801D0120
		[SerializeField] // 0x00000001801D00E0-0x00000001801D0120
		private int actionCategoryIdCounter; // 0xA8
		[CustomObfuscation] // 0x00000001801D00E0-0x00000001801D0120
		[SerializeField] // 0x00000001801D00E0-0x00000001801D0120
		private int inputBehaviorIdCounter; // 0xAC
		[CustomObfuscation] // 0x00000001801D00E0-0x00000001801D0120
		[SerializeField] // 0x00000001801D00E0-0x00000001801D0120
		private int mapCategoryIdCounter; // 0xB0
		[CustomObfuscation] // 0x00000001801D1070-0x00000001801D10B0
		[SerializeField] // 0x00000001801D1070-0x00000001801D10B0
		private int joystickLayoutIdCounter; // 0xB4
		[CustomObfuscation] // 0x00000001801D1070-0x00000001801D10B0
		[SerializeField] // 0x00000001801D1070-0x00000001801D10B0
		private int keyboardLayoutIdCounter; // 0xB8
		[CustomObfuscation] // 0x00000001801D1070-0x00000001801D10B0
		[SerializeField] // 0x00000001801D1070-0x00000001801D10B0
		private int mouseLayoutIdCounter; // 0xBC
		[CustomObfuscation] // 0x00000001801D1070-0x00000001801D10B0
		[SerializeField] // 0x00000001801D1070-0x00000001801D10B0
		private int customControllerLayoutIdCounter; // 0xC0
		[CustomObfuscation] // 0x00000001801D1070-0x00000001801D10B0
		[SerializeField] // 0x00000001801D1070-0x00000001801D10B0
		private int joystickMapIdCounter; // 0xC4
		[CustomObfuscation] // 0x00000001801D1070-0x00000001801D10B0
		[SerializeField] // 0x00000001801D1070-0x00000001801D10B0
		private int keyboardMapIdCounter; // 0xC8
		[CustomObfuscation] // 0x00000001801D00E0-0x00000001801D0120
		[SerializeField] // 0x00000001801D00E0-0x00000001801D0120
		private int mouseMapIdCounter; // 0xCC
		[CustomObfuscation] // 0x00000001801D00E0-0x00000001801D0120
		[SerializeField] // 0x00000001801D00E0-0x00000001801D0120
		private int customControllerMapIdCounter; // 0xD0
		[CustomObfuscation] // 0x00000001801D1070-0x00000001801D10B0
		[SerializeField] // 0x00000001801D1070-0x00000001801D10B0
		private int customControllerIdCounter; // 0xD4
		[CustomObfuscation] // 0x00000001801D00E0-0x00000001801D0120
		[SerializeField] // 0x00000001801D00E0-0x00000001801D0120
		private int controllerMapLayoutManagerSetIdCounter; // 0xD8
		[CustomObfuscation] // 0x00000001801D00E0-0x00000001801D0120
		[SerializeField] // 0x00000001801D00E0-0x00000001801D0120
		private int controllerMapEnablerSetIdCounter; // 0xDC
		private Func<int, bool> containsActionDelegate; // 0xE0
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private IList<Player_Editor> <Players_readOnly>k__BackingField; // 0xE8
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private IList<InputAction> <Actions_readOnly>k__BackingField; // 0xF0
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private IList<InputCategory> <ActionCategories_readOnly>k__BackingField; // 0xF8
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private IList<InputBehavior> <InputBehaviors_readOnly>k__BackingField; // 0x100
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private IList<InputMapCategory> <MapCategories_readOnly>k__BackingField; // 0x108
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private IList<InputLayout> <JoystickLayouts_readOnly>k__BackingField; // 0x110
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private IList<InputLayout> <KeyboardLayouts_readOnly>k__BackingField; // 0x118
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private IList<InputLayout> <MouseLayouts_readOnly>k__BackingField; // 0x120
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private IList<InputLayout> <CustomControllerLayouts_readOnly>k__BackingField; // 0x128
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private IList<ControllerMap_Editor> <JoystickMaps_readOnly>k__BackingField; // 0x130
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private IList<ControllerMap_Editor> <KeyboardMaps_readOnly>k__BackingField; // 0x138
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private IList<ControllerMap_Editor> <MouseMaps_readOnly>k__BackingField; // 0x140
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private IList<ControllerMap_Editor> <CustomControllerMaps_readOnly>k__BackingField; // 0x148
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private IList<ControllerMapLayoutManager_RuleSet_Editor> <ControllerMapLayoutManagerRuleSets_readOnly>k__BackingField; // 0x150
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private IList<ControllerMapEnabler_RuleSet_Editor> <ControllerMapEnablerRuleSets_readOnly>k__BackingField; // 0x158
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private static Action<List<Player_Editor.Mapping>, int> CS$<>9__CachedAnonymousMethodDelegate60; // 0x00
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private static Action<List<Player_Editor.Mapping>, int> CS$<>9__CachedAnonymousMethodDelegate62; // 0x08
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private static Action<List<Player_Editor.Mapping>, int> CS$<>9__CachedAnonymousMethodDelegate64; // 0x10
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private static Action<List<Player_Editor.Mapping>, int> CS$<>9__CachedAnonymousMethodDelegate66; // 0x18
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private static Action<List<Player_Editor.Mapping>, int> CS$<>9__CachedAnonymousMethodDelegate68; // 0x20
	
		// Properties
		internal IList<Player_Editor> Players_readOnly { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x000000018037DDD0-0x000000018037DDE0 0x00000001804296B0-0x00000001804296C0
		internal IList<InputAction> Actions_readOnly { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x000000018037DDB0-0x000000018037DDC0 0x00000001805AF740-0x00000001805AF750
		internal IList<InputCategory> ActionCategories_readOnly { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x000000018037E230-0x000000018037E240 0x0000000180617A50-0x0000000180617A60
		internal IList<InputBehavior> InputBehaviors_readOnly { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x000000018037F030-0x000000018037F040 0x0000000180617A70-0x0000000180617A80
		internal IList<InputMapCategory> MapCategories_readOnly { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x0000000180380B50-0x0000000180380B60 0x00000001803B50D0-0x00000001803B50E0
		internal IList<InputLayout> JoystickLayouts_readOnly { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x0000000180385320-0x0000000180385330 0x00000001804846D0-0x00000001804846E0
		internal IList<InputLayout> KeyboardLayouts_readOnly { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x00000001803916B0-0x00000001803916C0 0x0000000180617A80-0x0000000180617A90
		internal IList<InputLayout> MouseLayouts_readOnly { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x00000001803EF220-0x00000001803EF230 0x00000001803B7C20-0x00000001803B7C30
		internal IList<InputLayout> CustomControllerLayouts_readOnly { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x00000001803EF180-0x00000001803EF190 0x00000001805742A0-0x00000001805742B0
		internal IList<ControllerMap_Editor> JoystickMaps_readOnly { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x0000000180383C00-0x0000000180383C10 0x000000018057C5C0-0x000000018057C5D0
		internal IList<ControllerMap_Editor> KeyboardMaps_readOnly { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x00000001803EF230-0x00000001803EF240 0x0000000180617A90-0x0000000180617AA0
		internal IList<ControllerMap_Editor> MouseMaps_readOnly { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x00000001803EF170-0x00000001803EF180 0x0000000180617AA0-0x0000000180617AB0
		internal IList<ControllerMap_Editor> CustomControllerMaps_readOnly { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x0000000180616920-0x0000000180616930 0x000000018051D9F0-0x000000018051DA00
		internal IList<ControllerMapLayoutManager_RuleSet_Editor> ControllerMapLayoutManagerRuleSets_readOnly { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x0000000180449A60-0x0000000180449A70 0x0000000180617A60-0x0000000180617A70
		internal IList<ControllerMapEnabler_RuleSet_Editor> ControllerMapEnablerRuleSets_readOnly { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x00000001803EF160-0x00000001803EF170 0x00000001803EF2A0-0x00000001803EF2B0
		public ConfigVars ConfigVars { get; } // 0x0000000180372440-0x0000000180372450 
		internal IEnumerable<InputMapCategory> UserAssignableMapCategories { get; } // 0x0000000180616A10-0x0000000180616A80 
		internal IEnumerable<InputCategory> UserAssignableActionCategories { get; } // 0x0000000180616930-0x00000001806169A0 
		internal IEnumerable<InputAction> UserAssignableActions { get; } // 0x00000001806169A0-0x0000000180616A10 
		public int playerCount { get; } // 0x0000000180616A80-0x0000000180616AC0 
	
		// Nested types
		private static class WDCkxipPONaHhgdmaWQxRbsIymV // TypeDefIndex: 6424
		{
			// Fields
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private static Func<InputCategory, int> hVCdaAYbEbQkTRhAUgdUmlNpPNb; // 0x00
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private static Func<InputCategory, string> fgXeCNxGDaBYeTfrhGBxAuYNRJg; // 0x08
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private static Func<InputCategory, IList<InputCategory>, int> uvGgkvJUIoNzyupYFGOPSAdLhWT; // 0x10
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private static Func<InputBehavior, int> difHMSEAuNkaNmmJzuoLlklwDeF; // 0x18
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private static Func<InputBehavior, string> DiSArBFFRHplnrHlRhYapDJlrge; // 0x20
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private static Func<InputBehavior, IList<InputBehavior>, int> CwcNnvBGsVyghKkdAUjLMVeDOAe; // 0x28
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private static Func<InputAction, int> FePAFjKMastYeCJRQVOdFBdQJiI; // 0x30
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private static Func<InputAction, string> YTkauklqwAXESImsRhWSukQBsTE; // 0x38
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private static Func<InputAction, IList<InputAction>, int> nbuEfYdrsOvicakvKAOuAiTEdoVp; // 0x40
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private static Func<InputMapCategory, int> noataZMhzclfAyEwXbyrHNvhqVGC; // 0x48
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private static Func<InputMapCategory, string> ZqpjhlVpmeejvgoHVEqtWcGjipsp; // 0x50
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private static Func<InputMapCategory, IList<InputMapCategory>, int> DNvkajYAOAaiSFSdLgWZZDzaGase; // 0x58
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private static Func<InputLayout, int> drlzpvtirglCiiAvTQhqpmGMOVW; // 0x60
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private static Func<InputLayout, string> lLbQtiycKpITIrdAgxOwBOzCVGJ; // 0x68
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private static Func<InputLayout, IList<InputLayout>, int> zWJyIDTgQSkOCJKrhxcXvUrvybp; // 0x70
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private static Func<InputLayout, int> XRSHQucUSsLjeDhiFakPkdRoBlUe; // 0x78
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private static Func<InputLayout, string> qRxNChlQCECUNdwCYhxNUOxvuhm; // 0x80
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private static Func<InputLayout, IList<InputLayout>, int> tqNQINenSMUATdTOOzSOxRAgEbi; // 0x88
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private static Func<InputLayout, int> mhIoohQKHLtRvnOkGOyhEaVZzEI; // 0x90
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private static Func<InputLayout, string> xLsnLVMSdomUJlraUjoaaJurhHn; // 0x98
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private static Func<InputLayout, IList<InputLayout>, int> LqpbqWhYLnPlrmeWYhUGvnoFNkYM; // 0xA0
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private static Func<InputLayout, int> nnpRHVINhHOVQHcgAExuBWHPHnOo; // 0xA8
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private static Func<InputLayout, string> zxFEUXSbZKUDkCYPKPrDQPuLYa; // 0xB0
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private static Func<InputLayout, IList<InputLayout>, int> tSKGafZuKoIXTDeAAVPnAoQePwV; // 0xB8
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private static Func<CustomController_Editor, int> FZcmyHrDsuLjiyBtuCiNFKLXWUT; // 0xC0
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private static Func<CustomController_Editor, string> gEVjltbvyTAySXMKFdlALQXkxIt; // 0xC8
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private static Func<CustomController_Editor, IList<CustomController_Editor>, int> RGwPVSQvadoFTsnuvZevEuBxqFv; // 0xD0
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private static Func<ControllerMapLayoutManager_RuleSet_Editor, int> kRzBuYuqDNRQAQzYTiKTRFUIlZR; // 0xD8
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private static Func<ControllerMapLayoutManager_RuleSet_Editor, string> YTDXselRzZVpizoVfBKjpYprnCc; // 0xE0
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private static Func<ControllerMapLayoutManager_RuleSet_Editor, IList<ControllerMapLayoutManager_RuleSet_Editor>, int> SRbLgqyjjCjVwyrwdgNpkcrjcSP; // 0xE8
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private static Func<ControllerMapEnabler_RuleSet_Editor, int> dGYlXMbdRTeMjDLVfLEJiaHAsUI; // 0xF0
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private static Func<ControllerMapEnabler_RuleSet_Editor, string> QyCbyENQJfXYbSiakrjLwQOnaWM; // 0xF8
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private static Func<ControllerMapEnabler_RuleSet_Editor, IList<ControllerMapEnabler_RuleSet_Editor>, int> QtuLwmrOMSNcLkBgWPMWjFpLszk; // 0x100
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private static Func<Player_Editor, int> ecgKKQybZWObvBjpbuhsQTyZnoG; // 0x108
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private static Func<Player_Editor, string> IxtywraAPUsGMBLtQsnfYzHymoF; // 0x110
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private static Func<Player_Editor, IList<Player_Editor>, int> CDXCKdkFyxMCCMhfYOnLgtYbVjcq; // 0x118
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private static Func<ControllerMap_Editor, int> vNvdrbCpbGxTrrulJVHEWcXqJtN; // 0x120
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private static Func<ControllerMap_Editor, string> VrbOpyZQdttjgAvvlUodzJUhLFX; // 0x128
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private static Func<ControllerMap_Editor, int> yNVTLfGiNLnrqceBSpszOVmPVrG; // 0x130
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private static Func<ControllerMap_Editor, string> MPvAxpRWkfFuERNHziwFwpQENdd; // 0x138
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private static Func<ControllerMap_Editor, int> iIGWvIbbErcCFspJPUggLMIOBYw; // 0x140
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private static Func<ControllerMap_Editor, string> tffUcbUNzgFQNSfQgNHZfyVJgiX; // 0x148
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private static Func<ControllerMap_Editor, int> QOJFlcAFsROycgkeJtRJqkcjpeRd; // 0x150
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private static Func<ControllerMap_Editor, string> KqdaWZWcOUmfENkUFKHZvzBkOHd; // 0x158
	
			// Nested types
			private class VpSQVhBuRqMlVCljYcqGAAdLguwf // TypeDefIndex: 6425
			{
				// Fields
				public int HNkDvSswkPQiCrSurnrdqybBpqj; // 0x10
				public int LTJNRAnEUfguHllYvFbaCElxLLFg; // 0x14
				public int aYAkGUiBrXgoYHThwtuyoFzShNal; // 0x18
	
				// Properties
				public int MWiOWGzUiqOkOMPKltvfuPDthis[mlVILKSMHUGlaxcXAfhLVeXJpju type] { get => default; set {} } // 0x0000000180720BC0-0x0000000180720C50 0x0000000180720C50-0x0000000180720D40
	
				// Nested types
				public enum mlVILKSMHUGlaxcXAfhLVeXJpju // TypeDefIndex: 6426
				{
					HNkDvSswkPQiCrSurnrdqybBpqj = 0,
					LTJNRAnEUfguHllYvFbaCElxLLFg = 1,
					aYAkGUiBrXgoYHThwtuyoFzShNal = 2
				}
	
				// Constructors
				public VpSQVhBuRqMlVCljYcqGAAdLguwf(int origId, int otherId, int finalId); // 0x0000000180720B70-0x0000000180720BC0
	
				// Methods
				public override string ToString(); // 0x0000000180720A60-0x0000000180720B70
			}
	
			private class YRmApjTmdXkDTXCkjsOjOfxSocI<T> // TypeDefIndex: 6427
			{
				// Fields
				public T noIdTpiDbSsyoffYgtToZvpsUVw;
				public T cGNZHosBcmxRapzDydDbESKyrmr;
				public VpSQVhBuRqMlVCljYcqGAAdLguwf.mlVILKSMHUGlaxcXAfhLVeXJpju vuVxTdajAoeupFhnDJkUVoiMAEmd;
				public IList<T> IsIhVcNWYcdJhYEAKEvOAZurgAQa;
				public bool RArJWjEFIOJtzqJhBJVdRqQQkeZ;
	
				// Constructors
				public YRmApjTmdXkDTXCkjsOjOfxSocI(T otherItem, T finalItem, VpSQVhBuRqMlVCljYcqGAAdLguwf.mlVILKSMHUGlaxcXAfhLVeXJpju idType, IList<T> finalItems, bool isCollision);
			}
	
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private sealed class olOemTamcYhQZcxSjzzljaXoAbGj // TypeDefIndex: 6428
			{
				// Fields
				public UserData ofJiXKFqgEuSCzhdtELCKtrQYJH; // 0x10
				public List<VpSQVhBuRqMlVCljYcqGAAdLguwf> lhsRrDDnBxutGcVcGqKKLyTWLhb; // 0x18
				public List<VpSQVhBuRqMlVCljYcqGAAdLguwf> dTBFNNKYESWRGnftRQVtbIcrPxFF; // 0x20
				public List<VpSQVhBuRqMlVCljYcqGAAdLguwf> nrweVJIARsLelRYlSADRhGRvfrZ; // 0x28
				public List<VpSQVhBuRqMlVCljYcqGAAdLguwf> GSkvpcQPrWpYBotvHkfpFIjrFPw; // 0x30
				public List<VpSQVhBuRqMlVCljYcqGAAdLguwf> sJKOWmZxApcvKPQfsLMoAlDBdkeh; // 0x38
				public List<VpSQVhBuRqMlVCljYcqGAAdLguwf> cAvaWKikXllZEizpKNUCJkjJbqAt; // 0x40
				public List<VpSQVhBuRqMlVCljYcqGAAdLguwf> QcOQdrPBexvcYBTlxMMdlbkwjYqb; // 0x48
				public List<VpSQVhBuRqMlVCljYcqGAAdLguwf> XIBnRkAKtzynKYBixdWnCbctGBmO; // 0x50
				public Func<ControllerType, List<VpSQVhBuRqMlVCljYcqGAAdLguwf>> BAleIEVfubZwqXykNMuaQBtBkTq; // 0x58
				public List<VpSQVhBuRqMlVCljYcqGAAdLguwf> tdABAHpaMysTKhVJFieilfnlacs; // 0x60
				public List<VpSQVhBuRqMlVCljYcqGAAdLguwf> avgAzNPeKcyHfvtuopVrOgKUqhg; // 0x68
				public List<VpSQVhBuRqMlVCljYcqGAAdLguwf> hDQQmIReeSHrQnuYawymJEQMeVg; // 0x70
				private static Func<Player_Editor.Mapping, IList<Player_Editor.Mapping>, int> SiTpAunJHGGhacyYdZUWTxwsKmoH; // 0x00
				private static Func<Player_Editor.CreateControllerInfo, IList<Player_Editor.CreateControllerInfo>, int> HcqFTcPFRjmbvDJmBXVlVlVIbet; // 0x08
	
				// Nested types
				private sealed class IqddvcofkysNhxmYCAzhtYKKQZX // TypeDefIndex: 6429
				{
					// Fields
					public olOemTamcYhQZcxSjzzljaXoAbGj yxXrtTrHsgjCkIDOrignAwTmuxIg; // 0x10
					public YRmApjTmdXkDTXCkjsOjOfxSocI<InputAction> oMbAJnmIYmkoCgCmPFbtJMvsADOr; // 0x18
	
					// Constructors
					public IqddvcofkysNhxmYCAzhtYKKQZX(); // 0x0000000180373240-0x0000000180373250
	
					// Methods
					public bool HBkHTzDnWJJXfWWbkkkkWGpManL(VpSQVhBuRqMlVCljYcqGAAdLguwf param_0000d4bb); // 0x000000018071CFD0-0x000000018071D030
					public bool otwPSFlgWmTrjdeTjbWPTQieETOF(VpSQVhBuRqMlVCljYcqGAAdLguwf param_0000d4bc); // 0x000000018071D030-0x000000018071D090
				}
	
				private sealed class dFVvnquOSsvjXZqOapPKnVwKrZT // TypeDefIndex: 6430
				{
					// Fields
					public YRmApjTmdXkDTXCkjsOjOfxSocI<ControllerMapLayoutManager_RuleSet_Editor> oMbAJnmIYmkoCgCmPFbtJMvsADOr; // 0x10
	
					// Constructors
					public dFVvnquOSsvjXZqOapPKnVwKrZT(); // 0x0000000180373240-0x0000000180373250
				}
	
				private sealed class ZZEZxJymTclupTNRcWgMbveiDWG // TypeDefIndex: 6431
				{
					// Fields
					public dFVvnquOSsvjXZqOapPKnVwKrZT BMwiGkLSoQeQEwEGlVQEiXXYljZ; // 0x10
					public olOemTamcYhQZcxSjzzljaXoAbGj yxXrtTrHsgjCkIDOrignAwTmuxIg; // 0x18
					public int YNCESWXMGJsyPKcvPaTAiIdkvey; // 0x20
	
					// Constructors
					public ZZEZxJymTclupTNRcWgMbveiDWG(); // 0x0000000180373240-0x0000000180373250
	
					// Methods
					public bool YCxQeQhCfPuoufXSMGIMCjNYTrU(VpSQVhBuRqMlVCljYcqGAAdLguwf param_0000d4bd); // 0x0000000180707840-0x0000000180707890
				}
	
				private sealed class AceGJisrZssVeWcjsQhBvtDYVUo // TypeDefIndex: 6432
				{
					// Fields
					public dFVvnquOSsvjXZqOapPKnVwKrZT BMwiGkLSoQeQEwEGlVQEiXXYljZ; // 0x10
					public olOemTamcYhQZcxSjzzljaXoAbGj yxXrtTrHsgjCkIDOrignAwTmuxIg; // 0x18
					public int YNCESWXMGJsyPKcvPaTAiIdkvey; // 0x20
	
					// Constructors
					public AceGJisrZssVeWcjsQhBvtDYVUo(); // 0x0000000180373240-0x0000000180373250
	
					// Methods
					public bool gGkPpnSoSmzKuCYnrveRobucXpA(VpSQVhBuRqMlVCljYcqGAAdLguwf param_0000d4be); // 0x0000000180707840-0x0000000180707890
				}
	
				private sealed class KPSnzKNGoirZoFyQpSjzNZIbUgC // TypeDefIndex: 6433
				{
					// Fields
					public dFVvnquOSsvjXZqOapPKnVwKrZT BMwiGkLSoQeQEwEGlVQEiXXYljZ; // 0x10
					public olOemTamcYhQZcxSjzzljaXoAbGj yxXrtTrHsgjCkIDOrignAwTmuxIg; // 0x18
					public int YNCESWXMGJsyPKcvPaTAiIdkvey; // 0x20
	
					// Constructors
					public KPSnzKNGoirZoFyQpSjzNZIbUgC(); // 0x0000000180373240-0x0000000180373250
	
					// Methods
					public bool BRYsHfKfFTkghViKtseNpweKoMU(VpSQVhBuRqMlVCljYcqGAAdLguwf param_0000d4bf); // 0x0000000180707840-0x0000000180707890
				}
	
				private sealed class lYdgaoEjdcEqCOTwzBJwdEiJrpBF // TypeDefIndex: 6434
				{
					// Fields
					public YRmApjTmdXkDTXCkjsOjOfxSocI<ControllerMapEnabler_RuleSet_Editor> oMbAJnmIYmkoCgCmPFbtJMvsADOr; // 0x10
	
					// Constructors
					public lYdgaoEjdcEqCOTwzBJwdEiJrpBF(); // 0x0000000180373240-0x0000000180373250
				}
	
				private sealed class rnuLsNSGOZnlmiaAkRoqSFyHqJm // TypeDefIndex: 6435
				{
					// Fields
					public lYdgaoEjdcEqCOTwzBJwdEiJrpBF nalbcofEDzZkZHGFPoQNfOPXdXg; // 0x10
					public olOemTamcYhQZcxSjzzljaXoAbGj yxXrtTrHsgjCkIDOrignAwTmuxIg; // 0x18
					public int YNCESWXMGJsyPKcvPaTAiIdkvey; // 0x20
	
					// Constructors
					public rnuLsNSGOZnlmiaAkRoqSFyHqJm(); // 0x0000000180373240-0x0000000180373250
	
					// Methods
					public bool UCOOhMGFqoRBCafLJFkKcqPjAJfo(VpSQVhBuRqMlVCljYcqGAAdLguwf param_0000d4c0); // 0x0000000180707840-0x0000000180707890
				}
	
				private sealed class EMRoEGtvBimkfJTaWRRHcTDNrCR // TypeDefIndex: 6436
				{
					// Fields
					public lYdgaoEjdcEqCOTwzBJwdEiJrpBF nalbcofEDzZkZHGFPoQNfOPXdXg; // 0x10
					public olOemTamcYhQZcxSjzzljaXoAbGj yxXrtTrHsgjCkIDOrignAwTmuxIg; // 0x18
					public int YNCESWXMGJsyPKcvPaTAiIdkvey; // 0x20
	
					// Constructors
					public EMRoEGtvBimkfJTaWRRHcTDNrCR(); // 0x0000000180373240-0x0000000180373250
	
					// Methods
					public bool pfYaMZyzlycoXubBqcbsTqSxMrK(VpSQVhBuRqMlVCljYcqGAAdLguwf param_0000d4c1); // 0x0000000180707840-0x0000000180707890
				}
	
				private sealed class KayUbiEdcsvkwjtmlRaASfZRnuW // TypeDefIndex: 6437
				{
					// Fields
					public lYdgaoEjdcEqCOTwzBJwdEiJrpBF nalbcofEDzZkZHGFPoQNfOPXdXg; // 0x10
					public olOemTamcYhQZcxSjzzljaXoAbGj yxXrtTrHsgjCkIDOrignAwTmuxIg; // 0x18
					public int YNCESWXMGJsyPKcvPaTAiIdkvey; // 0x20
	
					// Constructors
					public KayUbiEdcsvkwjtmlRaASfZRnuW(); // 0x0000000180373240-0x0000000180373250
	
					// Methods
					public bool KNcaPutFCLMriFyLkaMmuYZhTKN(VpSQVhBuRqMlVCljYcqGAAdLguwf param_0000d4c2); // 0x0000000180707840-0x0000000180707890
				}
	
				private sealed class UAEudbjGiMWCKtlxDbcpCYqZxyd // TypeDefIndex: 6438
				{
					// Fields
					public olOemTamcYhQZcxSjzzljaXoAbGj yxXrtTrHsgjCkIDOrignAwTmuxIg; // 0x10
					public YRmApjTmdXkDTXCkjsOjOfxSocI<Player_Editor> oMbAJnmIYmkoCgCmPFbtJMvsADOr; // 0x18
	
					// Nested types
					private sealed class rFWRPKDREPPhLysEDPtDTEIcyZt // TypeDefIndex: 6439
					{
						// Fields
						public UAEudbjGiMWCKtlxDbcpCYqZxyd ldLuojiYliHEBreTEFFUFEPzxkrQ; // 0x10
						public olOemTamcYhQZcxSjzzljaXoAbGj yxXrtTrHsgjCkIDOrignAwTmuxIg; // 0x18
						public Player_Editor.Mapping uZTykRibHjgKjWfZMZoXnLbwkRp; // 0x20
	
						// Constructors
						public rFWRPKDREPPhLysEDPtDTEIcyZt(); // 0x0000000180373240-0x0000000180373250
	
						// Methods
						public bool iFDQnVqOWSzQYPQpuJOlJGOhCEU(VpSQVhBuRqMlVCljYcqGAAdLguwf param_0000d4c5); // 0x000000018072B740-0x000000018072B7A0
						public bool MYDrHOCwkUwMHzDwRGFbXQNkRvH(VpSQVhBuRqMlVCljYcqGAAdLguwf param_0000d4c6); // 0x000000018072B6E0-0x000000018072B740
					}
	
					// Constructors
					public UAEudbjGiMWCKtlxDbcpCYqZxyd(); // 0x0000000180373240-0x0000000180373250
	
					// Methods
					public void HXJqdsgVqChvdvFIzalXQywQFaE(List<Player_Editor.Mapping> param_0000d4c3, List<VpSQVhBuRqMlVCljYcqGAAdLguwf> param_0000d4c4); // 0x0000000180720520-0x0000000180720750
				}
	
				private sealed class uJjgPZRjOBbhPhKLksXmFcdxhHov // TypeDefIndex: 6440
				{
					// Fields
					public UAEudbjGiMWCKtlxDbcpCYqZxyd ldLuojiYliHEBreTEFFUFEPzxkrQ; // 0x10
					public olOemTamcYhQZcxSjzzljaXoAbGj yxXrtTrHsgjCkIDOrignAwTmuxIg; // 0x18
					public Player_Editor.CreateControllerInfo INvimzVaioFjwNQRVBRIVLeIhgc; // 0x20
	
					// Constructors
					public uJjgPZRjOBbhPhKLksXmFcdxhHov(); // 0x0000000180373240-0x0000000180373250
	
					// Methods
					public bool MZtChwyVDIbzYPSdgENqyZZVswy(VpSQVhBuRqMlVCljYcqGAAdLguwf param_0000d4c7); // 0x000000018072C350-0x000000018072C3B0
				}
	
				private sealed class PbchcdhiVpLXvrNDrZJvIAzYAQsC // TypeDefIndex: 6441
				{
					// Fields
					public UAEudbjGiMWCKtlxDbcpCYqZxyd ldLuojiYliHEBreTEFFUFEPzxkrQ; // 0x10
					public olOemTamcYhQZcxSjzzljaXoAbGj yxXrtTrHsgjCkIDOrignAwTmuxIg; // 0x18
					public int nowyFwjWnwrGQsPrcpSlPNkfVZu; // 0x20
	
					// Constructors
					public PbchcdhiVpLXvrNDrZJvIAzYAQsC(); // 0x0000000180373240-0x0000000180373250
	
					// Methods
					public bool NlVoIengdPswCMJkizDOuUUlJhR(VpSQVhBuRqMlVCljYcqGAAdLguwf param_0000d4c8); // 0x000000018071F920-0x000000018071F970
				}
	
				private sealed class dXiDPvgBLVhkoebKgTGICTJyLyyY // TypeDefIndex: 6442
				{
					// Fields
					public UAEudbjGiMWCKtlxDbcpCYqZxyd ldLuojiYliHEBreTEFFUFEPzxkrQ; // 0x10
					public olOemTamcYhQZcxSjzzljaXoAbGj yxXrtTrHsgjCkIDOrignAwTmuxIg; // 0x18
					public int nowyFwjWnwrGQsPrcpSlPNkfVZu; // 0x20
	
					// Constructors
					public dXiDPvgBLVhkoebKgTGICTJyLyyY(); // 0x0000000180373240-0x0000000180373250
	
					// Methods
					public bool wfngJGwJLUWqqQRdDHpeLvYRrTb(VpSQVhBuRqMlVCljYcqGAAdLguwf param_0000d4c9); // 0x000000018071F920-0x000000018071F970
				}
	
				// Constructors
				public olOemTamcYhQZcxSjzzljaXoAbGj(); // 0x0000000180373240-0x0000000180373250
	
				// Methods
				public InputCategory LCbhhFvChDTzFtWCgdmIrpRCauN(YRmApjTmdXkDTXCkjsOjOfxSocI<InputCategory> param_0000d4ab); // 0x0000000180727F50-0x00000001807282C0
				public InputBehavior BhxvUSlIgyhjwBCgbUqCVnPboWe(YRmApjTmdXkDTXCkjsOjOfxSocI<InputBehavior> param_0000d4ac); // 0x0000000180726C00-0x0000000180726F70
				public InputAction MpIbJzZwkdHaXAnBOtQumdGiEFA(YRmApjTmdXkDTXCkjsOjOfxSocI<InputAction> param_0000d4ad); // 0x0000000180728450-0x00000001807289D0
				public InputLayout YMmSyMvcEbpSbVwrHMlhZoilfdpJ(YRmApjTmdXkDTXCkjsOjOfxSocI<InputLayout> param_0000d4ae); // 0x0000000180728E40-0x0000000180728FF0
				public InputLayout emggLpqwKzcgkgslYKfIKOBYNUNQ(YRmApjTmdXkDTXCkjsOjOfxSocI<InputLayout> param_0000d4af); // 0x0000000180729330-0x00000001807294C0
				public InputLayout MiVmDibPDFzAUBjzWEEDJGVMvrVA(YRmApjTmdXkDTXCkjsOjOfxSocI<InputLayout> param_0000d4b0); // 0x00000001807282C0-0x0000000180728450
				public InputLayout WKokUMhUUzbtYUrOgAQhZZdSKqw(YRmApjTmdXkDTXCkjsOjOfxSocI<InputLayout> param_0000d4b1); // 0x0000000180728BF0-0x0000000180728D90
				public List<VpSQVhBuRqMlVCljYcqGAAdLguwf> XeXQcfFKuaOiRlCKjIBfGucnAdt(ControllerType param_0000d4b2); // 0x0000000180728D90-0x0000000180728E40
				public CustomController_Editor csrDpYHdOYchKdltMhijukGZYeG(YRmApjTmdXkDTXCkjsOjOfxSocI<CustomController_Editor> param_0000d4b3); // 0x0000000180728FF0-0x0000000180729330
				public ControllerMapLayoutManager_RuleSet_Editor FmCwUSHsXZlBBHicmtwEOVOGkvV(YRmApjTmdXkDTXCkjsOjOfxSocI<ControllerMapLayoutManager_RuleSet_Editor> param_0000d4b4); // 0x0000000180726F70-0x0000000180727F50
				public ControllerMapEnabler_RuleSet_Editor xvsoxOlQZQOonvOYmgYZaUtwSeT(YRmApjTmdXkDTXCkjsOjOfxSocI<ControllerMapEnabler_RuleSet_Editor> param_0000d4b5); // 0x000000018072A6E0-0x000000018072B6E0
				public Player_Editor mENFQmcTjdGOUGnSjzqpkFlVncdk(YRmApjTmdXkDTXCkjsOjOfxSocI<Player_Editor> param_0000d4b6); // 0x00000001807294C0-0x000000018072A590
				private static int PcflUYnlRxZHdgOQCCQQDpYFbMk(Player_Editor.Mapping param_0000d4b7, IList<Player_Editor.Mapping> param_0000d4b8); // 0x00000001807289D0-0x0000000180728BF0
				private static int ugpRQtYzhZSDzcPoibZmiAkeKaLE(Player_Editor.CreateControllerInfo param_0000d4b9, IList<Player_Editor.CreateControllerInfo> param_0000d4ba); // 0x000000018072A590-0x000000018072A6E0
			}
	
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private sealed class iBfWjotGUGkMPfZzmsDwKAmrFgw // TypeDefIndex: 6443
			{
				// Fields
				public olOemTamcYhQZcxSjzzljaXoAbGj yxXrtTrHsgjCkIDOrignAwTmuxIg; // 0x10
				public List<int> NmaxUNjSicrYDbfoZajaqMKzYDv; // 0x18
	
				// Constructors
				public iBfWjotGUGkMPfZzmsDwKAmrFgw(); // 0x0000000180373240-0x0000000180373250
	
				// Methods
				public InputMapCategory zHWxvltlZdMszLpFFvufQQTYaKb(YRmApjTmdXkDTXCkjsOjOfxSocI<InputMapCategory> param_0000d4ca); // 0x0000000180724A90-0x0000000180724D40
			}
	
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private sealed class nrazoPTdsPXaDHvzKhMDYIfgoEz // TypeDefIndex: 6444
			{
				// Fields
				public iBfWjotGUGkMPfZzmsDwKAmrFgw GssoFubpNhkymxuGNhjcSWTtqsG; // 0x10
				public olOemTamcYhQZcxSjzzljaXoAbGj yxXrtTrHsgjCkIDOrignAwTmuxIg; // 0x18
				public int LTJNRAnEUfguHllYvFbaCElxLLFg; // 0x20
	
				// Constructors
				public nrazoPTdsPXaDHvzKhMDYIfgoEz(); // 0x0000000180373240-0x0000000180373250
	
				// Methods
				public bool RaQvEOvJakNCAoaAAUgkBscNaxd(VpSQVhBuRqMlVCljYcqGAAdLguwf param_0000d4cb); // 0x0000000180726BE0-0x0000000180726C00
			}
	
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private sealed class yMbLSeMKklCNPgOHqIIcfCeCWpK // TypeDefIndex: 6445
			{
				// Fields
				public olOemTamcYhQZcxSjzzljaXoAbGj yxXrtTrHsgjCkIDOrignAwTmuxIg; // 0x10
				public List<VpSQVhBuRqMlVCljYcqGAAdLguwf> GuEPzbzIYocYqPLtLfURFgXEZBi; // 0x18
				private static Func<ActionElementMap, IList<ActionElementMap>, int> mhZTsuhAQCfKJwvodgRIhFFqOVN; // 0x00
	
				// Nested types
				private sealed class dpMDEdqnyDZymeqidXggSIejkjw // TypeDefIndex: 6446
				{
					// Fields
					public yMbLSeMKklCNPgOHqIIcfCeCWpK qRFbbMGakdsMyoVnwWixmQUiEZNY; // 0x10
					public olOemTamcYhQZcxSjzzljaXoAbGj yxXrtTrHsgjCkIDOrignAwTmuxIg; // 0x18
					public ControllerMap_Editor INvimzVaioFjwNQRVBRIVLeIhgc; // 0x20
	
					// Constructors
					public dpMDEdqnyDZymeqidXggSIejkjw(); // 0x0000000180373240-0x0000000180373250
	
					// Methods
					public bool gNigBBXoUuAeGxnfoXhTRwDLLVc(VpSQVhBuRqMlVCljYcqGAAdLguwf param_0000d4d1); // 0x000000018071DF40-0x000000018071DF70
					public bool YiZtliDnccuCMPJvtWcpqgjOhmQ(VpSQVhBuRqMlVCljYcqGAAdLguwf param_0000d4d2); // 0x000000018071DF10-0x000000018071DF40
				}
	
				private sealed class IyQpnePtYJMWqZBwrxlafIDcSi // TypeDefIndex: 6447
				{
					// Fields
					public yMbLSeMKklCNPgOHqIIcfCeCWpK qRFbbMGakdsMyoVnwWixmQUiEZNY; // 0x10
					public olOemTamcYhQZcxSjzzljaXoAbGj yxXrtTrHsgjCkIDOrignAwTmuxIg; // 0x18
					public ControllerMap_Editor zogGTGVlKMWUAlosyoBDOlRrrmp; // 0x20
					public YRmApjTmdXkDTXCkjsOjOfxSocI<ControllerMap_Editor> oMbAJnmIYmkoCgCmPFbtJMvsADOr; // 0x28
	
					// Constructors
					public IyQpnePtYJMWqZBwrxlafIDcSi(); // 0x0000000180373240-0x0000000180373250
	
					// Methods
					public bool buadbDIDdKLgHXSqynsuDREsPNa(VpSQVhBuRqMlVCljYcqGAAdLguwf param_0000d4d3); // 0x000000018071C250-0x000000018071C2A0
					public bool PUOJiwHhrUupNGnbiKFCuVgvgpm(VpSQVhBuRqMlVCljYcqGAAdLguwf param_0000d4d4); // 0x000000018071C200-0x000000018071C250
				}
	
				private sealed class gwxmVnVclCUYEcOcnqCEZjxUAQ // TypeDefIndex: 6448
				{
					// Fields
					public IyQpnePtYJMWqZBwrxlafIDcSi mJkhGYBoOnzvjniRVhNGVfIeDZb; // 0x10
					public yMbLSeMKklCNPgOHqIIcfCeCWpK qRFbbMGakdsMyoVnwWixmQUiEZNY; // 0x18
					public olOemTamcYhQZcxSjzzljaXoAbGj yxXrtTrHsgjCkIDOrignAwTmuxIg; // 0x20
					public ActionElementMap uZTykRibHjgKjWfZMZoXnLbwkRp; // 0x28
	
					// Constructors
					public gwxmVnVclCUYEcOcnqCEZjxUAQ(); // 0x0000000180373240-0x0000000180373250
	
					// Methods
					public bool ckPKTaeGtpCETBFhZjzhdCGiUZmK(VpSQVhBuRqMlVCljYcqGAAdLguwf param_0000d4d5); // 0x000000018071F8C0-0x000000018071F920
				}
	
				// Constructors
				public yMbLSeMKklCNPgOHqIIcfCeCWpK(); // 0x0000000180373240-0x0000000180373250
	
				// Methods
				public int XqROlCoYnOBSbZgtwSlpYgELXY(ControllerMap_Editor param_0000d4cc, IList<ControllerMap_Editor> param_0000d4cd); // 0x000000018072C630-0x000000018072C9D0
				public ControllerMap_Editor mprqMBTPSqghwIhofXxiFytrKQP(YRmApjTmdXkDTXCkjsOjOfxSocI<ControllerMap_Editor> param_0000d4ce); // 0x000000018072C9D0-0x000000018072D2E0
				private static int SCJdPSnzILOKSPpazgSkWXIxQVW(ActionElementMap param_0000d4cf, IList<ActionElementMap> param_0000d4d0); // 0x000000018072C3B0-0x000000018072C630
			}
	
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private sealed class IyqvnVTCtVPDWtaxEKtgTjdsMMM // TypeDefIndex: 6449
			{
				// Fields
				public olOemTamcYhQZcxSjzzljaXoAbGj yxXrtTrHsgjCkIDOrignAwTmuxIg; // 0x10
				public List<VpSQVhBuRqMlVCljYcqGAAdLguwf> GuEPzbzIYocYqPLtLfURFgXEZBi; // 0x18
				private static Func<ActionElementMap, IList<ActionElementMap>, int> CeNaTgMaheIARQLdXGnbgpBrMIF; // 0x00
	
				// Nested types
				private sealed class PbfpqrIWsJlKefyFQfEkxWWnanf // TypeDefIndex: 6450
				{
					// Fields
					public IyqvnVTCtVPDWtaxEKtgTjdsMMM MlyAsKgrOKOXZiDmqbxKseBdKiHD; // 0x10
					public olOemTamcYhQZcxSjzzljaXoAbGj yxXrtTrHsgjCkIDOrignAwTmuxIg; // 0x18
					public ControllerMap_Editor INvimzVaioFjwNQRVBRIVLeIhgc; // 0x20
	
					// Constructors
					public PbfpqrIWsJlKefyFQfEkxWWnanf(); // 0x0000000180373240-0x0000000180373250
	
					// Methods
					public bool arEMArCbMpaluKrwXdNGWhzvecfl(VpSQVhBuRqMlVCljYcqGAAdLguwf param_0000d4db); // 0x000000018071DF40-0x000000018071DF70
					public bool dfxmGPkDJZaCQglIUPWEGIwUnqnd(VpSQVhBuRqMlVCljYcqGAAdLguwf param_0000d4dc); // 0x000000018071DF10-0x000000018071DF40
				}
	
				private sealed class KGgGPxunFFaNLHjJrttfupsunXM // TypeDefIndex: 6451
				{
					// Fields
					public IyqvnVTCtVPDWtaxEKtgTjdsMMM MlyAsKgrOKOXZiDmqbxKseBdKiHD; // 0x10
					public olOemTamcYhQZcxSjzzljaXoAbGj yxXrtTrHsgjCkIDOrignAwTmuxIg; // 0x18
					public ControllerMap_Editor zogGTGVlKMWUAlosyoBDOlRrrmp; // 0x20
					public YRmApjTmdXkDTXCkjsOjOfxSocI<ControllerMap_Editor> oMbAJnmIYmkoCgCmPFbtJMvsADOr; // 0x28
	
					// Constructors
					public KGgGPxunFFaNLHjJrttfupsunXM(); // 0x0000000180373240-0x0000000180373250
	
					// Methods
					public bool yfYZjqsrxYQNvFxmIvYvYEtaFQr(VpSQVhBuRqMlVCljYcqGAAdLguwf param_0000d4dd); // 0x000000018071C250-0x000000018071C2A0
					public bool lzXxjVusFrRGFcNOWHyDAmOxIOTG(VpSQVhBuRqMlVCljYcqGAAdLguwf param_0000d4de); // 0x000000018071C200-0x000000018071C250
				}
	
				private sealed class PSNLrcivmxRDEdnvcvxoysvndTa // TypeDefIndex: 6452
				{
					// Fields
					public KGgGPxunFFaNLHjJrttfupsunXM YTshKjeubgeeTNcSviSmRozCpaP; // 0x10
					public IyqvnVTCtVPDWtaxEKtgTjdsMMM MlyAsKgrOKOXZiDmqbxKseBdKiHD; // 0x18
					public olOemTamcYhQZcxSjzzljaXoAbGj yxXrtTrHsgjCkIDOrignAwTmuxIg; // 0x20
					public ActionElementMap uZTykRibHjgKjWfZMZoXnLbwkRp; // 0x28
	
					// Constructors
					public PSNLrcivmxRDEdnvcvxoysvndTa(); // 0x0000000180373240-0x0000000180373250
	
					// Methods
					public bool mWnMdkpiJTvNCaaixkCzoqnBeRcB(VpSQVhBuRqMlVCljYcqGAAdLguwf param_0000d4df); // 0x000000018071F8C0-0x000000018071F920
				}
	
				// Constructors
				public IyqvnVTCtVPDWtaxEKtgTjdsMMM(); // 0x0000000180373240-0x0000000180373250
	
				// Methods
				public int DJWNFOVjLVvCnemrvIRvsykXulb(ControllerMap_Editor param_0000d4d6, IList<ControllerMap_Editor> param_0000d4d7); // 0x000000018071D090-0x000000018071D450
				public ControllerMap_Editor JNLqTPkhXPQgsuGanUuSNAiPgMt(YRmApjTmdXkDTXCkjsOjOfxSocI<ControllerMap_Editor> param_0000d4d8); // 0x000000018071D450-0x000000018071DCF0
				private static int VxQNDGohLwSQERZWtTmmsgOBRlp(ActionElementMap param_0000d4d9, IList<ActionElementMap> param_0000d4da); // 0x000000018071DCF0-0x000000018071DEE0
			}
	
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private sealed class OlhNGrsJzHYzWWxiucCXKkLOtos // TypeDefIndex: 6453
			{
				// Fields
				public olOemTamcYhQZcxSjzzljaXoAbGj yxXrtTrHsgjCkIDOrignAwTmuxIg; // 0x10
				public List<VpSQVhBuRqMlVCljYcqGAAdLguwf> GuEPzbzIYocYqPLtLfURFgXEZBi; // 0x18
				private static Func<ActionElementMap, IList<ActionElementMap>, int> TiMslrQGsxDbTyQWpehOaHepasdB; // 0x00
	
				// Nested types
				private sealed class ijkKxvOrzNMKUnNCXjDWgGeDhoZB // TypeDefIndex: 6454
				{
					// Fields
					public OlhNGrsJzHYzWWxiucCXKkLOtos nVKqncEjZnPKDynFFVuzdddWOoC; // 0x10
					public olOemTamcYhQZcxSjzzljaXoAbGj yxXrtTrHsgjCkIDOrignAwTmuxIg; // 0x18
					public ControllerMap_Editor INvimzVaioFjwNQRVBRIVLeIhgc; // 0x20
	
					// Constructors
					public ijkKxvOrzNMKUnNCXjDWgGeDhoZB(); // 0x0000000180373240-0x0000000180373250
	
					// Methods
					public bool DMCGyHTXZKTscyQsRBBrZJJHcKig(VpSQVhBuRqMlVCljYcqGAAdLguwf param_0000d4e5); // 0x000000018071DF40-0x000000018071DF70
					public bool ryJMifpFjVigprNzBzcjMekPdJe(VpSQVhBuRqMlVCljYcqGAAdLguwf param_0000d4e6); // 0x000000018071DF10-0x000000018071DF40
				}
	
				private sealed class EmElBcoqzADZpVLsHzeUGUPeUiz // TypeDefIndex: 6455
				{
					// Fields
					public OlhNGrsJzHYzWWxiucCXKkLOtos nVKqncEjZnPKDynFFVuzdddWOoC; // 0x10
					public olOemTamcYhQZcxSjzzljaXoAbGj yxXrtTrHsgjCkIDOrignAwTmuxIg; // 0x18
					public ControllerMap_Editor zogGTGVlKMWUAlosyoBDOlRrrmp; // 0x20
					public YRmApjTmdXkDTXCkjsOjOfxSocI<ControllerMap_Editor> oMbAJnmIYmkoCgCmPFbtJMvsADOr; // 0x28
	
					// Constructors
					public EmElBcoqzADZpVLsHzeUGUPeUiz(); // 0x0000000180373240-0x0000000180373250
	
					// Methods
					public bool oyPQbFSKvaFNmeFrLyHbOqMeoFs(VpSQVhBuRqMlVCljYcqGAAdLguwf param_0000d4e7); // 0x000000018071C250-0x000000018071C2A0
					public bool NepprnIlOHWzWuEWDMuXZuiTiH(VpSQVhBuRqMlVCljYcqGAAdLguwf param_0000d4e8); // 0x000000018071C200-0x000000018071C250
				}
	
				private sealed class ePSxekSPEcrVouCccDAmbfBEgaPR // TypeDefIndex: 6456
				{
					// Fields
					public EmElBcoqzADZpVLsHzeUGUPeUiz ojczbPabEhZpwcJTUdxBhrjeUJG; // 0x10
					public OlhNGrsJzHYzWWxiucCXKkLOtos nVKqncEjZnPKDynFFVuzdddWOoC; // 0x18
					public olOemTamcYhQZcxSjzzljaXoAbGj yxXrtTrHsgjCkIDOrignAwTmuxIg; // 0x20
					public ActionElementMap uZTykRibHjgKjWfZMZoXnLbwkRp; // 0x28
	
					// Constructors
					public ePSxekSPEcrVouCccDAmbfBEgaPR(); // 0x0000000180373240-0x0000000180373250
	
					// Methods
					public bool QiQCjyRzqsKrSbVtqfpYkYCwDsW(VpSQVhBuRqMlVCljYcqGAAdLguwf param_0000d4e9); // 0x000000018071F8C0-0x000000018071F920
				}
	
				// Constructors
				public OlhNGrsJzHYzWWxiucCXKkLOtos(); // 0x0000000180373240-0x0000000180373250
	
				// Methods
				public int DbLcoixJXCihcKmCtFGfaaocrZPa(ControllerMap_Editor param_0000d4e0, IList<ControllerMap_Editor> param_0000d4e1); // 0x000000018071DF70-0x000000018071E390
				public ControllerMap_Editor VAhAVdKAPicwZBbnYyQoerVLaraP(YRmApjTmdXkDTXCkjsOjOfxSocI<ControllerMap_Editor> param_0000d4e2); // 0x000000018071E390-0x000000018071ED20
				private static int wnWQXvcpZFaiqYkjqARbjKrHpAzQ(ActionElementMap param_0000d4e3, IList<ActionElementMap> param_0000d4e4); // 0x000000018071ED20-0x000000018071F070
			}
	
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private sealed class iizkHuQzeqPnmLDVoDpmRfMcjMP // TypeDefIndex: 6457
			{
				// Fields
				public olOemTamcYhQZcxSjzzljaXoAbGj yxXrtTrHsgjCkIDOrignAwTmuxIg; // 0x10
				public List<VpSQVhBuRqMlVCljYcqGAAdLguwf> GuEPzbzIYocYqPLtLfURFgXEZBi; // 0x18
				private static Func<ActionElementMap, IList<ActionElementMap>, int> QslbpqntEjHuMfAcyHyoPtoGKbz; // 0x00
	
				// Nested types
				private sealed class LOFcVnBcvXoMHepKIfFOSIZAMOUv // TypeDefIndex: 6458
				{
					// Fields
					public iizkHuQzeqPnmLDVoDpmRfMcjMP LMZcOeFRgHZcQJYfFxdWqNZSosHA; // 0x10
					public olOemTamcYhQZcxSjzzljaXoAbGj yxXrtTrHsgjCkIDOrignAwTmuxIg; // 0x18
					public ControllerMap_Editor INvimzVaioFjwNQRVBRIVLeIhgc; // 0x20
	
					// Constructors
					public LOFcVnBcvXoMHepKIfFOSIZAMOUv(); // 0x0000000180373240-0x0000000180373250
	
					// Methods
					public bool GtNOYVQAoHwhtZPADnLXjYBxslk(VpSQVhBuRqMlVCljYcqGAAdLguwf param_0000d4ef); // 0x000000018071DEE0-0x000000018071DF10
					public bool diIeivsTReztMHMMHmoBtrXTTQp(VpSQVhBuRqMlVCljYcqGAAdLguwf param_0000d4f0); // 0x000000018071DF40-0x000000018071DF70
					public bool YGTkAicCGHYrbMAuhiSAZASJlsd(VpSQVhBuRqMlVCljYcqGAAdLguwf param_0000d4f1); // 0x000000018071DF10-0x000000018071DF40
				}
	
				private sealed class auTergtFGNsJOOfmqHKiptULtY // TypeDefIndex: 6459
				{
					// Fields
					public iizkHuQzeqPnmLDVoDpmRfMcjMP LMZcOeFRgHZcQJYfFxdWqNZSosHA; // 0x10
					public olOemTamcYhQZcxSjzzljaXoAbGj yxXrtTrHsgjCkIDOrignAwTmuxIg; // 0x18
					public ControllerMap_Editor zogGTGVlKMWUAlosyoBDOlRrrmp; // 0x20
					public YRmApjTmdXkDTXCkjsOjOfxSocI<ControllerMap_Editor> oMbAJnmIYmkoCgCmPFbtJMvsADOr; // 0x28
	
					// Constructors
					public auTergtFGNsJOOfmqHKiptULtY(); // 0x0000000180373240-0x0000000180373250
	
					// Methods
					public bool PWHDKKpcDrgzsbBKQWHTYGkBPVm(VpSQVhBuRqMlVCljYcqGAAdLguwf param_0000d4f2); // 0x00000001807243C0-0x0000000180724410
					public bool FckeTAoFdmktxDSrnSURxYHEKyo(VpSQVhBuRqMlVCljYcqGAAdLguwf param_0000d4f3); // 0x000000018071C250-0x000000018071C2A0
					public bool puqGsGONdUunubqNcnPsgNFnOzY(VpSQVhBuRqMlVCljYcqGAAdLguwf param_0000d4f4); // 0x000000018071C200-0x000000018071C250
				}
	
				private sealed class eghAqGfpYxXDPOQjhdWzkXLJtdm // TypeDefIndex: 6460
				{
					// Fields
					public auTergtFGNsJOOfmqHKiptULtY naeBeOlspIKcHEMfcpmyzXzPoRk; // 0x10
					public iizkHuQzeqPnmLDVoDpmRfMcjMP LMZcOeFRgHZcQJYfFxdWqNZSosHA; // 0x18
					public olOemTamcYhQZcxSjzzljaXoAbGj yxXrtTrHsgjCkIDOrignAwTmuxIg; // 0x20
					public ActionElementMap uZTykRibHjgKjWfZMZoXnLbwkRp; // 0x28
	
					// Constructors
					public eghAqGfpYxXDPOQjhdWzkXLJtdm(); // 0x0000000180373240-0x0000000180373250
	
					// Methods
					public bool SQdgqEZqLrhKWfZvtYdGMfmZjuKe(VpSQVhBuRqMlVCljYcqGAAdLguwf param_0000d4f5); // 0x000000018071F8C0-0x000000018071F920
				}
	
				// Constructors
				public iizkHuQzeqPnmLDVoDpmRfMcjMP(); // 0x0000000180373240-0x0000000180373250
	
				// Methods
				public int oGldeOCPqsSKiVDPONnIfBYbGZkX(ControllerMap_Editor param_0000d4ea, IList<ControllerMap_Editor> param_0000d4eb); // 0x0000000180725870-0x0000000180725D90
				public ControllerMap_Editor SxgQOwNPpGHVRRoxJqcNZdlDhyi(YRmApjTmdXkDTXCkjsOjOfxSocI<ControllerMap_Editor> param_0000d4ec); // 0x0000000180724D40-0x00000001807256C0
				private static int lcrjNVgxvNBjOMyRRngEdMyqcPxz(ActionElementMap param_0000d4ed, IList<ActionElementMap> param_0000d4ee); // 0x00000001807256C0-0x0000000180725870
			}
	
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private sealed class EAkfIVTxjPjktHVoVrwkUKkfpLN<T> // TypeDefIndex: 6461
				where T : class
			{
				// Fields
				public Func<T, int> QichaXlPbUUzhplAaTyzSeoVkzD;
	
				// Constructors
				public EAkfIVTxjPjktHVoVrwkUKkfpLN();
			}
	
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private sealed class QqwdQiWCUocVYXvBRFIzCLcwLQbS<T> // TypeDefIndex: 6462
				where T : class
			{
				// Fields
				public EAkfIVTxjPjktHVoVrwkUKkfpLN<T> ZuyirqSzDfCjVPHBuPpuDGzdvcf;
				public T zogGTGVlKMWUAlosyoBDOlRrrmp;
	
				// Constructors
				public QqwdQiWCUocVYXvBRFIzCLcwLQbS();
	
				// Methods
				public bool eAwbAvMlXFTPeXNNHmcebDQJRrU(VpSQVhBuRqMlVCljYcqGAAdLguwf param_0000d4f6);
			}
	
			// Methods
			public static UserData HcoqOerGilrKrieuEKDeVDdkzor(UserData param_0000d456, UserData param_0000d457, bool param_0000d458); // 0x0000000180720E80-0x0000000180723870
			[Conditional] // 0x0000000180295770-0x00000001802957A0
			private static void WZAIMFVqvgZMNfZYWwNIyxpdPCj(object param_0000d459); // 0x0000000180723B90-0x0000000180723BE0
			private static void dWpMQMMHzNHYiZCgywuhGHVVDyke<T>(IList<T> param_0000d45a, IList<T> param_0000d45b, IList<T> param_0000d45c, Func<T, IList<T>, int> param_0000d45d);
			private static void CloexxVSEilDJARhwhQlAhzNfhT<T>(string param_0000d45e, IList<T> param_0000d45f, IList<T> param_0000d460, IList<T> param_0000d461, bool param_0000d462, List<VpSQVhBuRqMlVCljYcqGAAdLguwf> param_0000d463, Func<T, int> param_0000d464, Func<T, string> param_0000d465, Func<T, IList<T>, int> param_0000d466, Func<YRmApjTmdXkDTXCkjsOjOfxSocI<T>, T> param_0000d467)
				where T : class;
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private static int SAfYHbeuvNZNeZbCOdFeBCiLAeQ(InputCategory param_0000d468); // 0x0000000180723B50-0x0000000180723B70
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private static string bdXtbHMoHieLYnPXRFhvRcnuAjhe(InputCategory param_0000d469); // 0x000000018049FDD0-0x000000018049FDF0
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private static int rTFqwfZfUeqiIAiMhSujUCqEBAtd(InputCategory param_0000d46a, IList<InputCategory> param_0000d46b); // 0x00000001807240A0-0x00000001807241A0
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private static int XTeSiohJZYsYPtMIiemkFfduEqvD(InputBehavior param_0000d46c); // 0x0000000180720D80-0x0000000180720DA0
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private static string BsBgEnhcvqpwnNgSfDqbBzxWvcUW(InputBehavior param_0000d46d); // 0x0000000180720D60-0x0000000180720D80
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private static int iaHiWhtGUaqEnFLeZXhErTUBzxM(InputBehavior param_0000d46e, IList<InputBehavior> param_0000d46f); // 0x0000000180723DD0-0x0000000180723EB0
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private static int tRqpcuqPhKxOhYKrKRoEZzIzzyJ(InputAction param_0000d470); // 0x0000000180720D80-0x0000000180720DA0
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private static string tGdQPDrjIAEFQgbltFxpBtoOQpC(InputAction param_0000d471); // 0x0000000180720D60-0x0000000180720D80
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private static int uKPpcNSNYaLzLveWZopamEIhKCx(InputAction param_0000d472, IList<InputAction> param_0000d473); // 0x00000001807242B0-0x00000001807243C0
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private static int yHxQZSlMMrJcbHmCihfVfxrbpQFQ(InputMapCategory param_0000d474); // 0x0000000180723B50-0x0000000180723B70
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private static string emDyWdGUlvGRfvAORJvaSLZFcUN(InputMapCategory param_0000d475); // 0x000000018049FDD0-0x000000018049FDF0
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private static int JQhhvnBGtqtktmcVDMTLjdbZQAg(InputMapCategory param_0000d476, IList<InputMapCategory> param_0000d477); // 0x0000000180723960-0x0000000180723A40
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private static int VXdgHPFazTpMZquADGMwgmRtVfhE(InputLayout param_0000d478); // 0x0000000180723B70-0x0000000180723B90
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private static string MlUERnTiPIjPxjSbCGDrghGKEdxv(InputLayout param_0000d479); // 0x000000018049FDD0-0x000000018049FDF0
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private static int eJMhQqYUAvUgqqmYYLMBduwBgth(InputLayout param_0000d47a, IList<InputLayout> param_0000d47b); // 0x0000000180723CC0-0x0000000180723DD0
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private static int euAffMCIeUmodMVzJRhphHKEramO(InputLayout param_0000d47c); // 0x0000000180723B70-0x0000000180723B90
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private static string BEoAfvGAptmxFLtRbWYgTjiYqoR(InputLayout param_0000d47d); // 0x000000018049FDD0-0x000000018049FDF0
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private static int lMwmoZsVCyjCYJSsmQToZLEdBqL(InputLayout param_0000d47e, IList<InputLayout> param_0000d47f); // 0x0000000180723EB0-0x0000000180723F90
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private static int yfiGKcbQrqEEPSbWqBorazHKnWGu(InputLayout param_0000d480); // 0x0000000180723B70-0x0000000180723B90
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private static string MubCqxgGoHCWQsivjuQVgsARYUV(InputLayout param_0000d481); // 0x000000018049FDD0-0x000000018049FDF0
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private static int LFcmuTzppSbeoaCBwbznxhnOmofa(InputLayout param_0000d482, IList<InputLayout> param_0000d483); // 0x0000000180723A40-0x0000000180723B50
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private static int atIflJLbDSyOskjmXzTKfmLgGtC(InputLayout param_0000d484); // 0x0000000180723B70-0x0000000180723B90
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private static string wpRSgTBPyNCOeaawkBpzkcPLauu(InputLayout param_0000d485); // 0x000000018049FDD0-0x000000018049FDF0
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private static int GkRflpuBJlDcSfwpMXliGXcAEESX(InputLayout param_0000d486, IList<InputLayout> param_0000d487); // 0x0000000180720DA0-0x0000000180720E80
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private static int bKXGopXlJjkqhLCRVlWiAKaWNdt(CustomController_Editor param_0000d488); // 0x0000000180723B70-0x0000000180723B90
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private static string bICvtoJIKwEpgOKdgkkyTnvlEMva(CustomController_Editor param_0000d489); // 0x000000018049FDD0-0x000000018049FDF0
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private static int njektPnLJdhbCNEFYnhkEBsPjKr(CustomController_Editor param_0000d48a, IList<CustomController_Editor> param_0000d48b); // 0x0000000180723F90-0x00000001807240A0
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private static int EXZclYOQzagdXvfuQLxoaMGtryb(ControllerMapLayoutManager_RuleSet_Editor param_0000d48c); // 0x0000000180720D80-0x0000000180720DA0
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private static string vvMROVdMyEwjaBLnOxqOkLhtcqo(ControllerMapLayoutManager_RuleSet_Editor param_0000d48d); // 0x0000000180720D60-0x0000000180720D80
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private static int sQIdDFeTrqYliiuPFaXrojlXvcl(ControllerMapLayoutManager_RuleSet_Editor param_0000d48e, IList<ControllerMapLayoutManager_RuleSet_Editor> param_0000d48f); // 0x00000001807241A0-0x00000001807242B0
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private static int UnSiObwrllAlpsfGIuwuTMxGvKr(ControllerMapEnabler_RuleSet_Editor param_0000d490); // 0x0000000180720D80-0x0000000180720DA0
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private static string cqbRoxHKUdAoWXBdfXooCBopBlTD(ControllerMapEnabler_RuleSet_Editor param_0000d491); // 0x0000000180720D60-0x0000000180720D80
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private static int HoWPzBNNQURNbBVWEjsRIrbGVPm(ControllerMapEnabler_RuleSet_Editor param_0000d492, IList<ControllerMapEnabler_RuleSet_Editor> param_0000d493); // 0x0000000180723870-0x0000000180723960
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private static int tqMJsfvZgAMPHvaZhJmDKhbeYtQ(Player_Editor param_0000d494); // 0x0000000180720D80-0x0000000180720DA0
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private static string JbgAAqVDxTffmiDkTmXhcOjgrYTG(Player_Editor param_0000d495); // 0x0000000180720D60-0x0000000180720D80
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private static int ZfWiUecxhwkxQivtUwmibuXjhDQJ(Player_Editor param_0000d496, IList<Player_Editor> param_0000d497); // 0x0000000180723BE0-0x0000000180723CC0
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private static int SuHgmwDRkRXKlDKtuqnNayNbJka(ControllerMap_Editor param_0000d498); // 0x0000000180720D80-0x0000000180720DA0
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private static string nBRhLpZXKQoINGoSKyjRtyJVhaz(ControllerMap_Editor param_0000d499); // 0x0000000180720D40-0x0000000180720D60
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private static int OdPfHiGThOCaTiZZwlPPrIMuhzhJ(ControllerMap_Editor param_0000d49a); // 0x0000000180720D80-0x0000000180720DA0
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private static string BHgCGcnkiopcIpEnEVQlvDnhSTt(ControllerMap_Editor param_0000d49b); // 0x0000000180720D40-0x0000000180720D60
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private static int znJegjYoZLoqijtjhDNupIMDImiD(ControllerMap_Editor param_0000d49c); // 0x0000000180720D80-0x0000000180720DA0
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private static string XwHbQEErTqGeOHcGfaCdfDrayTEu(ControllerMap_Editor param_0000d49d); // 0x0000000180720D40-0x0000000180720D60
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private static int vFwlaoUbfBgEKDTuEnCrdkvfqaKl(ControllerMap_Editor param_0000d49e); // 0x0000000180720D80-0x0000000180720DA0
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private static string ydBOgMoEIwrXsySdOPJvFAUHHRm(ControllerMap_Editor param_0000d49f); // 0x0000000180720D40-0x0000000180720D60
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class TCXjEymRXIIBAmpOuWITBxrikwp : IEnumerable<InputMapCategory>, IEnumerator<InputMapCategory> // TypeDefIndex: 6463
		{
			// Fields
			private InputMapCategory aSrFEaALHwhGTdXfCdeUqgbwaZGO; // 0x10
			private int eLrUhJFgzEZElCzdKvcrgOLXLvL; // 0x18
			private int RQaeFqcJnaOYpZSBxtfUkVOjfOo; // 0x1C
			public UserData gKPmvKLRxdGbmXiMfUeDjGbezUo; // 0x20
			public string JCGCpUCurghuUXdSOPksvsnnAI; // 0x28
			public string iChHPeLmpCAwLCogWFyCXOCrZna; // 0x30
			public int ZKnOmfdBGxPCzuiOaEmmaNwByyN; // 0x38
	
			// Properties
			InputMapCategory dDiPdxKJBJAagsAlXeBODIkONUR { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372440-0x0000000180372450 
			object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372440-0x0000000180372450 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public TCXjEymRXIIBAmpOuWITBxrikwp(int <>1__state); // 0x00000001807204B0-0x0000000180720520
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			IEnumerator<InputMapCategory> IEnumerable<InputMapCategory>.GetEnumerator(); // 0x0000000180720340-0x0000000180720460
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			IEnumerator IEnumerable.GetEnumerator(); // 0x0000000180720340-0x0000000180720460
			private bool MoveNext(); // 0x0000000180720110-0x0000000180720340
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000180720460-0x00000001807204B0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class HggAMhrrEToyVYZErtPBvanhHgt : IEnumerable<InputMapCategory>, IEnumerator<InputMapCategory> // TypeDefIndex: 6464
		{
			// Fields
			private InputMapCategory aSrFEaALHwhGTdXfCdeUqgbwaZGO; // 0x10
			private int eLrUhJFgzEZElCzdKvcrgOLXLvL; // 0x18
			private int RQaeFqcJnaOYpZSBxtfUkVOjfOo; // 0x1C
			public UserData gKPmvKLRxdGbmXiMfUeDjGbezUo; // 0x20
			public int PjYtuicjXGalARRYfcvVGxZVBdI; // 0x28
	
			// Properties
			InputMapCategory dDiPdxKJBJAagsAlXeBODIkONUR { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372440-0x0000000180372450 
			object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372440-0x0000000180372450 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public HggAMhrrEToyVYZErtPBvanhHgt(int <>1__state); // 0x00000001805EDEC0-0x00000001805EDF10
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			IEnumerator<InputMapCategory> IEnumerable<InputMapCategory>.GetEnumerator(); // 0x000000018071CE70-0x000000018071CF80
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			IEnumerator IEnumerable.GetEnumerator(); // 0x000000018071CE70-0x000000018071CF80
			private bool MoveNext(); // 0x000000018071CCA0-0x000000018071CE70
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x000000018071CF80-0x000000018071CFD0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class tsMGbVoIHUIJZksZVFBCghjlxdtz : IEnumerable<InputMapCategory>, IEnumerator<InputMapCategory> // TypeDefIndex: 6465
		{
			// Fields
			private InputMapCategory aSrFEaALHwhGTdXfCdeUqgbwaZGO; // 0x10
			private int eLrUhJFgzEZElCzdKvcrgOLXLvL; // 0x18
			private int RQaeFqcJnaOYpZSBxtfUkVOjfOo; // 0x1C
			public UserData gKPmvKLRxdGbmXiMfUeDjGbezUo; // 0x20
			public string JCGCpUCurghuUXdSOPksvsnnAI; // 0x28
			public string iChHPeLmpCAwLCogWFyCXOCrZna; // 0x30
			public int IiqAOvtVNlCuKCmYJrKqAvSPedRP; // 0x38
	
			// Properties
			InputMapCategory dDiPdxKJBJAagsAlXeBODIkONUR { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372440-0x0000000180372450 
			object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372440-0x0000000180372450 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public tsMGbVoIHUIJZksZVFBCghjlxdtz(int <>1__state); // 0x00000001805EDEC0-0x00000001805EDF10
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			IEnumerator<InputMapCategory> IEnumerable<InputMapCategory>.GetEnumerator(); // 0x000000018072C1B0-0x000000018072C300
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			IEnumerator IEnumerable.GetEnumerator(); // 0x000000018072C1B0-0x000000018072C300
			private bool MoveNext(); // 0x000000018072BF00-0x000000018072C1B0
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x000000018072C300-0x000000018072C350
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class rbJoGYdMMhWRHOgSDmQGBfHidcVc : IEnumerable<InputCategory>, IEnumerator<InputCategory> // TypeDefIndex: 6466
		{
			// Fields
			private InputCategory aSrFEaALHwhGTdXfCdeUqgbwaZGO; // 0x10
			private int eLrUhJFgzEZElCzdKvcrgOLXLvL; // 0x18
			private int RQaeFqcJnaOYpZSBxtfUkVOjfOo; // 0x1C
			public UserData gKPmvKLRxdGbmXiMfUeDjGbezUo; // 0x20
			public string JCGCpUCurghuUXdSOPksvsnnAI; // 0x28
			public string iChHPeLmpCAwLCogWFyCXOCrZna; // 0x30
			public int CVuVYRUyKDQHENvKvQkTKDOtumC; // 0x38
	
			// Properties
			InputCategory YMQQVXUkbpeZKuuVmhbydiBLDcH { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372440-0x0000000180372450 
			object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372440-0x0000000180372450 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public rbJoGYdMMhWRHOgSDmQGBfHidcVc(int <>1__state); // 0x00000001805EDEC0-0x00000001805EDF10
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			IEnumerator<InputCategory> IEnumerable<InputCategory>.GetEnumerator(); // 0x000000018072BDB0-0x000000018072BEB0
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			IEnumerator IEnumerable.GetEnumerator(); // 0x000000018072BDB0-0x000000018072BEB0
			private bool MoveNext(); // 0x000000018072BB80-0x000000018072BDB0
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x000000018072BEB0-0x000000018072BF00
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class FHsYaALijDgklaaXzHwbNnuLMPA : IEnumerable<InputCategory>, IEnumerator<InputCategory> // TypeDefIndex: 6467
		{
			// Fields
			private InputCategory aSrFEaALHwhGTdXfCdeUqgbwaZGO; // 0x10
			private int eLrUhJFgzEZElCzdKvcrgOLXLvL; // 0x18
			private int RQaeFqcJnaOYpZSBxtfUkVOjfOo; // 0x1C
			public UserData gKPmvKLRxdGbmXiMfUeDjGbezUo; // 0x20
			public int jRtDhdAasfdeafpcDrRHOhcxcJfA; // 0x28
	
			// Properties
			InputCategory YMQQVXUkbpeZKuuVmhbydiBLDcH { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372440-0x0000000180372450 
			object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372440-0x0000000180372450 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public FHsYaALijDgklaaXzHwbNnuLMPA(int <>1__state); // 0x00000001805EDEC0-0x00000001805EDF10
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			IEnumerator<InputCategory> IEnumerable<InputCategory>.GetEnumerator(); // 0x000000018071CA20-0x000000018071CB20
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			IEnumerator IEnumerable.GetEnumerator(); // 0x000000018071CA20-0x000000018071CB20
			private bool MoveNext(); // 0x000000018071C820-0x000000018071CA20
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x000000018071CB20-0x000000018071CB70
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class rWxgzNoBfbuzxgbQIaTIjXKdlgF : IEnumerable<InputCategory>, IEnumerator<InputCategory> // TypeDefIndex: 6468
		{
			// Fields
			private InputCategory aSrFEaALHwhGTdXfCdeUqgbwaZGO; // 0x10
			private int eLrUhJFgzEZElCzdKvcrgOLXLvL; // 0x18
			private int RQaeFqcJnaOYpZSBxtfUkVOjfOo; // 0x1C
			public UserData gKPmvKLRxdGbmXiMfUeDjGbezUo; // 0x20
			public string JCGCpUCurghuUXdSOPksvsnnAI; // 0x28
			public string iChHPeLmpCAwLCogWFyCXOCrZna; // 0x30
			public int GislVEIIWhvuFIBvluQVCtNFtAT; // 0x38
	
			// Properties
			InputCategory YMQQVXUkbpeZKuuVmhbydiBLDcH { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372440-0x0000000180372450 
			object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372440-0x0000000180372450 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public rWxgzNoBfbuzxgbQIaTIjXKdlgF(int <>1__state); // 0x00000001805EDEC0-0x00000001805EDF10
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			IEnumerator<InputCategory> IEnumerable<InputCategory>.GetEnumerator(); // 0x000000018072B9F0-0x000000018072BB30
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			IEnumerator IEnumerable.GetEnumerator(); // 0x000000018072B9F0-0x000000018072BB30
			private bool MoveNext(); // 0x000000018072B7A0-0x000000018072B9F0
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x000000018072BB30-0x000000018072BB80
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class iqnRDEKHNkujHbXnxqHaAYJPnpK : IEnumerable<InputAction>, IEnumerator<InputAction> // TypeDefIndex: 6469
		{
			// Fields
			private InputAction aSrFEaALHwhGTdXfCdeUqgbwaZGO; // 0x10
			private int eLrUhJFgzEZElCzdKvcrgOLXLvL; // 0x18
			private int RQaeFqcJnaOYpZSBxtfUkVOjfOo; // 0x1C
			public UserData gKPmvKLRxdGbmXiMfUeDjGbezUo; // 0x20
			public int CcbHWnYKugNrIuHSDWojKnRPOwB; // 0x28
			public InputAction BFYtfVGGNedvAKqSrDojCjBpyGQ; // 0x30
			public InputCategory EREkVskbKdXCUMqFuOCrpmDjOHS; // 0x38
	
			// Properties
			InputAction bkafzyccRhbzByXCAEYKgbbEmhX { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372440-0x0000000180372450 
			object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372440-0x0000000180372450 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public iqnRDEKHNkujHbXnxqHaAYJPnpK(int <>1__state); // 0x00000001805EDEC0-0x00000001805EDF10
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			IEnumerator<InputAction> IEnumerable<InputAction>.GetEnumerator(); // 0x0000000180725F90-0x0000000180726070
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			IEnumerator IEnumerable.GetEnumerator(); // 0x0000000180725F90-0x0000000180726070
			private bool MoveNext(); // 0x0000000180725D90-0x0000000180725F90
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000180726070-0x00000001807260C0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class PvRWbhaDEoIjMfWnRdrBHValSPn : IEnumerable<InputAction>, IEnumerator<InputAction> // TypeDefIndex: 6470
		{
			// Fields
			private InputAction aSrFEaALHwhGTdXfCdeUqgbwaZGO; // 0x10
			private int eLrUhJFgzEZElCzdKvcrgOLXLvL; // 0x18
			private int RQaeFqcJnaOYpZSBxtfUkVOjfOo; // 0x1C
			public UserData gKPmvKLRxdGbmXiMfUeDjGbezUo; // 0x20
			public int HhgmAUXrIUwifbpOtxdGCJxuQVW; // 0x28
			public int ngibtskfHlPvnmGmpOKZmmdunhis; // 0x2C
			public bool mTOTACPwpAtFAHTikaimwnpkljK; // 0x30
			public bool eyiUPSZDRdDZZDwSzbBDBoBxKjw; // 0x31
			public int YLgyfSVNUyYfxyGbWBewLSzEDfFE; // 0x34
			public InputAction RsjTndmjeRMNNIclTShuaQBAHIf; // 0x38
			public int VKvkBbBTFhVmMOfYFCAQiouOITD; // 0x40
			public IEnumerator<int> bnNEEHuWNwBTzziJZIOqcZokanAH; // 0x48
	
			// Properties
			InputAction bkafzyccRhbzByXCAEYKgbbEmhX { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372440-0x0000000180372450 
			object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372440-0x0000000180372450 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public PvRWbhaDEoIjMfWnRdrBHValSPn(int <>1__state); // 0x00000001805EDEC0-0x00000001805EDF10
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			IEnumerator<InputAction> IEnumerable<InputAction>.GetEnumerator(); // 0x000000018071FD40-0x000000018071FE40
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			IEnumerator IEnumerable.GetEnumerator(); // 0x000000018071FD40-0x000000018071FE40
			private bool MoveNext(); // 0x000000018071F970-0x000000018071FD40
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x000000018071FE40-0x000000018071FE90
			void IDisposable.Dispose(); // 0x000000018071FE90-0x000000018071FF00
			private void VKmDDMOytQLNfriWWOZXtbWjcDj(); // 0x000000018071FF00-0x00000001807200B0
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class BJdYrZbajCBBmfbtijCWpXbUcHTE : IEnumerable<InputAction>, IEnumerator<InputAction> // TypeDefIndex: 6471
		{
			// Fields
			private InputAction aSrFEaALHwhGTdXfCdeUqgbwaZGO; // 0x10
			private int eLrUhJFgzEZElCzdKvcrgOLXLvL; // 0x18
			private int RQaeFqcJnaOYpZSBxtfUkVOjfOo; // 0x1C
			public UserData gKPmvKLRxdGbmXiMfUeDjGbezUo; // 0x20
			public string eFkrsLCLicTuVsfETjVmfqXWOsyd; // 0x28
			public string nnENPIPMfPFhJjqtBiEdAGAeQnhY; // 0x30
			public bool mTOTACPwpAtFAHTikaimwnpkljK; // 0x38
			public bool eyiUPSZDRdDZZDwSzbBDBoBxKjw; // 0x39
			public int mgTurPfjYnAJCsdbUHhJPweegvWF; // 0x3C
			public InputCategory RiPjEdOfKScHKFyCcCgCioanWLVb; // 0x40
			public int paEsMuMaoFJTCJldMospTXUiFvu; // 0x48
			public InputAction uenqWxAwpjWzzoXnhrdtGdnHQYu; // 0x50
			public int dYAIUmxOtnsZWcYuYMHXBJUkLNT; // 0x58
			public IEnumerator<int> uXUyVOvrUJBiqaSzqHjixjGjexm; // 0x60
	
			// Properties
			InputAction bkafzyccRhbzByXCAEYKgbbEmhX { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372440-0x0000000180372450 
			object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372440-0x0000000180372450 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public BJdYrZbajCBBmfbtijCWpXbUcHTE(int <>1__state); // 0x0000000180707F70-0x0000000180707FE0
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			IEnumerator<InputAction> IEnumerable<InputAction>.GetEnumerator(); // 0x0000000180707D40-0x0000000180707E70
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			IEnumerator IEnumerable.GetEnumerator(); // 0x0000000180707D40-0x0000000180707E70
			private bool MoveNext(); // 0x0000000180707890-0x0000000180707D40
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000180707E70-0x0000000180707EC0
			void IDisposable.Dispose(); // 0x0000000180707EC0-0x0000000180707F70
			private void dtbOvYPynYurhkKfWvWVrRXZTfI(); // 0x0000000180707FE0-0x0000000180708030
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class EwVkrrJxEDfxDugnkFDGJvXedJuf : IEnumerable<InputAction>, IEnumerator<InputAction> // TypeDefIndex: 6472
		{
			// Fields
			private InputAction aSrFEaALHwhGTdXfCdeUqgbwaZGO; // 0x10
			private int eLrUhJFgzEZElCzdKvcrgOLXLvL; // 0x18
			private int RQaeFqcJnaOYpZSBxtfUkVOjfOo; // 0x1C
			public UserData gKPmvKLRxdGbmXiMfUeDjGbezUo; // 0x20
			public string JCGCpUCurghuUXdSOPksvsnnAI; // 0x28
			public string iChHPeLmpCAwLCogWFyCXOCrZna; // 0x30
			public int RjmRfPqlBNeQpzLctPuHcPRuiKz; // 0x38
			public int LMLrHKJhfSfjnJDFqMzrDFLEtSah; // 0x3C
			public InputCategory WjtNJiNNncucmOJbjhzPClAIjcQj; // 0x40
			public int FsiGyEJFUBzSevDkCARJZiIkOSy; // 0x48
	
			// Properties
			InputAction bkafzyccRhbzByXCAEYKgbbEmhX { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372440-0x0000000180372450 
			object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372440-0x0000000180372450 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public EwVkrrJxEDfxDugnkFDGJvXedJuf(int <>1__state); // 0x000000018071C7B0-0x000000018071C820
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			IEnumerator<InputAction> IEnumerable<InputAction>.GetEnumerator(); // 0x000000018071C640-0x000000018071C760
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			IEnumerator IEnumerable.GetEnumerator(); // 0x000000018071C640-0x000000018071C760
			private bool MoveNext(); // 0x000000018071C2A0-0x000000018071C640
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x000000018071C760-0x000000018071C7B0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class BxvhqOFZhIOeOrQfVNUIOsFzSCr : IEnumerable<InputAction>, IEnumerator<InputAction> // TypeDefIndex: 6473
		{
			// Fields
			private InputAction aSrFEaALHwhGTdXfCdeUqgbwaZGO; // 0x10
			private int eLrUhJFgzEZElCzdKvcrgOLXLvL; // 0x18
			private int RQaeFqcJnaOYpZSBxtfUkVOjfOo; // 0x1C
			public UserData gKPmvKLRxdGbmXiMfUeDjGbezUo; // 0x20
			public int HhgmAUXrIUwifbpOtxdGCJxuQVW; // 0x28
			public int ngibtskfHlPvnmGmpOKZmmdunhis; // 0x2C
			public bool mTOTACPwpAtFAHTikaimwnpkljK; // 0x30
			public bool eyiUPSZDRdDZZDwSzbBDBoBxKjw; // 0x31
			public InputCategory NiYujIJhrQuLlNGPJgaAUCrlYrB; // 0x38
			public int LurlQnkGLbufCnQeyEJWtmobFJR; // 0x40
			public InputAction SjVbTDFyxorVSaKPzBzrVBLuSpU; // 0x48
			public int xfCMKYvfPoZlxORLRgmIUZiDCmJ; // 0x50
			public InputAction EsAHmvExrQNZgtjBLNBOQAjvByz; // 0x58
			public IEnumerator<int> RezkdFOopsWXtWHtrnMjSGaNoiM; // 0x60
	
			// Properties
			InputAction bkafzyccRhbzByXCAEYKgbbEmhX { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372440-0x0000000180372450 
			object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372440-0x0000000180372450 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public BxvhqOFZhIOeOrQfVNUIOsFzSCr(int <>1__state); // 0x0000000180708710-0x0000000180708790
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			IEnumerator<InputAction> IEnumerable<InputAction>.GetEnumerator(); // 0x0000000180708480-0x0000000180708610
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			IEnumerator IEnumerable.GetEnumerator(); // 0x0000000180708480-0x0000000180708610
			private bool MoveNext(); // 0x0000000180708030-0x0000000180708480
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000180708610-0x0000000180708660
			void IDisposable.Dispose(); // 0x0000000180708660-0x0000000180708710
			private void xfYseRgskGwCGumdDZbIcrZKBcL(); // 0x0000000180708790-0x00000001807087E0
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class OxjfYzJXSnLHmLlVxbYndrXeJiel : IEnumerable<InputAction>, IEnumerator<InputAction> // TypeDefIndex: 6474
		{
			// Fields
			private InputAction aSrFEaALHwhGTdXfCdeUqgbwaZGO; // 0x10
			private int eLrUhJFgzEZElCzdKvcrgOLXLvL; // 0x18
			private int RQaeFqcJnaOYpZSBxtfUkVOjfOo; // 0x1C
			public UserData gKPmvKLRxdGbmXiMfUeDjGbezUo; // 0x20
			public string CcbsoKCfUfhLYvrtJwxwZACbqny; // 0x28
			public string eMcqJPPfstKyKVIWusAWFzQWvmg; // 0x30
			public bool mTOTACPwpAtFAHTikaimwnpkljK; // 0x38
			public bool eyiUPSZDRdDZZDwSzbBDBoBxKjw; // 0x39
			public InputCategory LzVXzobrxUcGCYTmndskadPibht; // 0x40
			public int EHcBJzUKjEpPVqKYLIpXWRizbwe; // 0x48
			public InputAction WPDchPURrRXDhfCKDjnPauMCFp; // 0x50
			public int oqPIMSGkWTcQRaDPjqNORsqyrTB; // 0x58
			public InputAction WQjsVSVhyPLZHKmhMqQthrShfIz; // 0x60
			public IEnumerator<int> OMugyzfrEAAXQCZDRzXaQFNqgJp; // 0x68
	
			// Properties
			InputAction bkafzyccRhbzByXCAEYKgbbEmhX { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372440-0x0000000180372450 
			object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372440-0x0000000180372450 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public OxjfYzJXSnLHmLlVxbYndrXeJiel(int <>1__state); // 0x00000001805EDEC0-0x00000001805EDF10
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			IEnumerator<InputAction> IEnumerable<InputAction>.GetEnumerator(); // 0x000000018071F6F0-0x000000018071F800
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			IEnumerator IEnumerable.GetEnumerator(); // 0x000000018071F6F0-0x000000018071F800
			private bool MoveNext(); // 0x000000018071F180-0x000000018071F6F0
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x000000018071F800-0x000000018071F850
			void IDisposable.Dispose(); // 0x000000018071F850-0x000000018071F8C0
			private void LdBwxgmBwIVVSuoDzUQxUwcsIeG(); // 0x000000018071F070-0x000000018071F180
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class jbXWTFrQRfSNxCldVhXMranTfAh : IEnumerable<string>, IEnumerator<string> // TypeDefIndex: 6475
		{
			// Fields
			private string aSrFEaALHwhGTdXfCdeUqgbwaZGO; // 0x10
			private int eLrUhJFgzEZElCzdKvcrgOLXLvL; // 0x18
			private int RQaeFqcJnaOYpZSBxtfUkVOjfOo; // 0x1C
			public UserData gKPmvKLRxdGbmXiMfUeDjGbezUo; // 0x20
			public int nowyFwjWnwrGQsPrcpSlPNkfVZu; // 0x28
			public int XrgNeBhnlEDrBIgJfLFCTkAqbQF; // 0x2C
			public int eiGudzyamfFyHGkSATFNEVSNbZng; // 0x30
			public InputAction YkHnnEGcQLGECxUjWNaPtvXIuTE; // 0x38
			public IEnumerator<int> VAKyJWebqWYoNZcQIucCIKwQFyU; // 0x40
	
			// Properties
			string AXzUXURUCJLBgmEajMlrzYVHPxg { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372440-0x0000000180372450 
			object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372440-0x0000000180372450 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public jbXWTFrQRfSNxCldVhXMranTfAh(int <>1__state); // 0x00000001805EDEC0-0x00000001805EDF10
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			IEnumerator<string> IEnumerable<string>.GetEnumerator(); // 0x00000001807269E0-0x0000000180726AE0
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			IEnumerator IEnumerable.GetEnumerator(); // 0x00000001807269E0-0x0000000180726AE0
			private bool MoveNext(); // 0x0000000180726540-0x00000001807268E0
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000180726AE0-0x0000000180726B30
			void IDisposable.Dispose(); // 0x0000000180726B30-0x0000000180726BE0
			private void OOwWpculDngdTAOYoJYCqxpPmPeF(); // 0x00000001807268E0-0x00000001807269E0
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class jDoydkcCcHgIsdCqZivtCVZkwRH : IEnumerable<string>, IEnumerator<string> // TypeDefIndex: 6476
		{
			// Fields
			private string aSrFEaALHwhGTdXfCdeUqgbwaZGO; // 0x10
			private int eLrUhJFgzEZElCzdKvcrgOLXLvL; // 0x18
			private int RQaeFqcJnaOYpZSBxtfUkVOjfOo; // 0x1C
			public UserData gKPmvKLRxdGbmXiMfUeDjGbezUo; // 0x20
			public int nowyFwjWnwrGQsPrcpSlPNkfVZu; // 0x28
			public int XrgNeBhnlEDrBIgJfLFCTkAqbQF; // 0x2C
			public int gzPBUshzKGizDgyPKHRgUZgdAOre; // 0x30
			public InputAction SDKCbwhjjWCxrkfESjXycagbwUA; // 0x38
			public IEnumerator<int> FvYAMRTUvsMUpgFZUmfjCbmhqlc; // 0x40
	
			// Properties
			string AXzUXURUCJLBgmEajMlrzYVHPxg { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372440-0x0000000180372450 
			object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372440-0x0000000180372450 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public jDoydkcCcHgIsdCqZivtCVZkwRH(int <>1__state); // 0x00000001805EDEC0-0x00000001805EDF10
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			IEnumerator<string> IEnumerable<string>.GetEnumerator(); // 0x00000001807262F0-0x00000001807263F0
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			IEnumerator IEnumerable.GetEnumerator(); // 0x00000001807262F0-0x00000001807263F0
			private bool MoveNext(); // 0x00000001807260C0-0x00000001807262F0
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x00000001807263F0-0x0000000180726440
			void IDisposable.Dispose(); // 0x0000000180726440-0x00000001807264F0
			private void UrvYJVREDMdIzKRidCoIQbSVcHgB(); // 0x00000001807264F0-0x0000000180726540
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class iAkHgICWyLACtjysdpzRpVGWFdgb : IEnumerable<int>, IEnumerator<int> // TypeDefIndex: 6477
		{
			// Fields
			private int aSrFEaALHwhGTdXfCdeUqgbwaZGO; // 0x10
			private int eLrUhJFgzEZElCzdKvcrgOLXLvL; // 0x14
			private int RQaeFqcJnaOYpZSBxtfUkVOjfOo; // 0x18
			public UserData gKPmvKLRxdGbmXiMfUeDjGbezUo; // 0x20
			public int nowyFwjWnwrGQsPrcpSlPNkfVZu; // 0x28
			public int XrgNeBhnlEDrBIgJfLFCTkAqbQF; // 0x2C
			public int smZeZGfKwpdBtoYGkmSenURBTFO; // 0x30
			public IEnumerator<int> AJpqjcjdiejnmanvFCwuFsAbGEqI; // 0x38
	
			// Properties
			int WSBEdAEEtGKxuQineQbAxjcuTLP { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180387590-0x0000000180387930 
			object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180724940-0x0000000180724990 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public iAkHgICWyLACtjysdpzRpVGWFdgb(int <>1__state); // 0x0000000180619870-0x00000001806198C0
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			IEnumerator<int> IEnumerable<int>.GetEnumerator(); // 0x00000001807247A0-0x00000001807248F0
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			IEnumerator IEnumerable.GetEnumerator(); // 0x00000001807247A0-0x00000001807248F0
			private bool MoveNext(); // 0x0000000180724410-0x00000001807247A0
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x00000001807248F0-0x0000000180724940
			void IDisposable.Dispose(); // 0x0000000180724990-0x0000000180724A40
			private void tXGyiPrFPdkRGJudEErptDcCewB(); // 0x0000000180724A40-0x0000000180724A90
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class FYSQkxUAMSsSPoQdTHsasfbMPLt // TypeDefIndex: 6478
		{
			// Fields
			public List<InputLayout> hEdGNgYBAStIzXkIWmUQqcbgBcY; // 0x10
	
			// Nested types
			private sealed class RkpUWBZZwKmQyhAqbKbozTDERPs // TypeDefIndex: 6479
			{
				// Fields
				public FYSQkxUAMSsSPoQdTHsasfbMPLt AQOOvZWlTIuMtIObvsdiYbaEMAh; // 0x10
				public ControllerMap_Editor jMeIpvfjZOxlpswPIuhuwRcOfdO; // 0x18
				public ControllerMap_Editor FgjvfzHcWabyGiXRtsKQNmtuoEKC; // 0x20
	
				// Constructors
				public RkpUWBZZwKmQyhAqbKbozTDERPs(); // 0x0000000180373240-0x0000000180373250
	
				// Methods
				public bool eFkAkVoWwADrEUvvoGkRHotipBkB(InputLayout param_0000d508); // 0x00000001807200E0-0x0000000180720110
				public bool BjxfmbtTbqBFXbNYUpSKILskcCTH(InputLayout param_0000d509); // 0x00000001807200B0-0x00000001807200E0
			}
	
			// Constructors
			public FYSQkxUAMSsSPoQdTHsasfbMPLt(); // 0x0000000180373240-0x0000000180373250
	
			// Methods
			public int barVXeXWOsQkZPnUHkhAiBObptp(ControllerMap_Editor param_0000d506, ControllerMap_Editor param_0000d507); // 0x000000018071CB70-0x000000018071CCA0
		}
	
		// Constructors
		public UserData(); // 0x0000000180616570-0x0000000180616580
		private UserData(bool init); // 0x0000000180615FB0-0x0000000180616570
	
		// Methods
		internal IEnumerable<InputMapCategory> OohvgKceufDiepKaNueZGqjbhOU(string param_0000d2df); // 0x0000000180614DA0-0x0000000180614E20
		internal IEnumerable<InputMapCategory> svjCqRACHsdRvscTwjZTBegCQLUd(string param_0000d2e0); // 0x0000000180617B20-0x0000000180617BA0
		internal IEnumerable<InputCategory> yNGlNxtOQxMejVsLXMcznQIeSRb(string param_0000d2e1); // 0x0000000180619030-0x00000001806190B0
		internal IEnumerable<InputCategory> OghwTUagjFJQRYpPnSvyUiDmemQH(string param_0000d2e2); // 0x0000000180614BD0-0x0000000180614C50
		internal IEnumerable<InputAction> vxKpleRbaGncklSJxvtbDBmwtGE(int param_0000d2e3, bool param_0000d2e4); // 0x0000000180617CF0-0x0000000180617DB0
		internal IEnumerable<InputAction> vxKpleRbaGncklSJxvtbDBmwtGE(string param_0000d2e5, bool param_0000d2e6); // 0x0000000180617C60-0x0000000180617CF0
		internal IEnumerable<InputAction> aYQTyvYHUstuHToNIoiVYToxvRx(string param_0000d2e7); // 0x0000000180616640-0x00000001806166C0
		internal IEnumerable<InputAction> OiDEVfJzUhFqGqlLDOujmdLvcjYc(int param_0000d2e8, bool param_0000d2e9); // 0x0000000180614C50-0x0000000180614D00
		internal IEnumerable<InputAction> OiDEVfJzUhFqGqlLDOujmdLvcjYc(string param_0000d2ea, bool param_0000d2eb); // 0x0000000180614D00-0x0000000180614DA0
		public List<InputAction> GetActions_Copy(); // 0x00000001806068D0-0x00000001806069E0
		public List<InputBehavior> GetInputBehaviors_Copy(); // 0x000000018060A960-0x000000018060AA80
		public List<KeyboardMap> GetKeyboardMaps_Copy(); // 0x000000018060CB50-0x000000018060CC90
		public List<MouseMap> GetMouseMaps_Copy(); // 0x000000018060F0B0-0x000000018060F200
		public void AddPlayer(); // 0x00000001805FD3F0-0x00000001805FD450
		public void InsertPlayer(int index); // 0x0000000180613FC0-0x00000001806140A0
		public void DeletePlayer(int index); // 0x0000000180600F60-0x0000000180601010
		public bool ReorderPlayer(int index, bool offsetDown, bool offsetNow); // 0x0000000180615560-0x00000001806155D0
		public void DuplicatePlayer(int index); // 0x0000000180604360-0x0000000180604580
		public string[] GetPlayerNames(); // 0x000000018060F9B0-0x000000018060FB30
		public int GetPlayerNames(IList<string> results); // 0x000000018060F720-0x000000018060F9B0
		public int[] GetPlayerIds(); // 0x000000018060F4A0-0x000000018060F5E0
		public int[] GetPlayerRuntimeIds(); // 0x000000018060FE30-0x000000018060FF40
		public int GetPlayerRuntimeIds(IList<int> results); // 0x000000018060FB30-0x000000018060FE30
		public string GetPlayerNameById(int id); // 0x000000018060F5E0-0x000000018060F720
		public Player_Editor GetPlayer(int index); // 0x000000018060FF40-0x000000018060FFB0
		public int GetPlayerId(string name); // 0x000000018060F330-0x000000018060F4A0
		public bool IsMouseAssigned(); // 0x00000001806141C0-0x00000001806142C0
		public void ClearMouseAssignments(); // 0x00000001805FD780-0x00000001805FD850
		public bool IsKeyboardAssigned(); // 0x00000001806140A0-0x00000001806141C0
		public void ClearKeyboardAssignments(); // 0x00000001805FD670-0x00000001805FD780
		public void AddAction(int categoryId); // 0x00000001805FCEA0-0x00000001805FCF40
		public void InsertAction(int categoryId, int actionId); // 0x0000000180613680-0x00000001806137C0
		public void DeleteAction(int categoryId, int actionId); // 0x00000001805FDFD0-0x00000001805FE0B0
		public bool ReorderAction(int categoryId, int actionId, bool offsetDown, bool offsetNow); // 0x0000000180615110-0x0000000180615140
		public int DuplicateAction_FromButton(int categoryId, int actionId); // 0x0000000180601660-0x00000001806018F0
		private int xAgcAQaADPZEEsBsMezluBrtQMgu(int param_0000d303, InputAction param_0000d304); // 0x0000000180617DB0-0x0000000180617F20
		public string[] GetActionNames(); // 0x0000000180606620-0x00000001806067B0
		public int GetActionNames(IList<string> results); // 0x00000001806063A0-0x0000000180606620
		public int[] GetActionIds(); // 0x0000000180606100-0x0000000180606230
		public int GetActionIds(IList<int> results); // 0x0000000180605E80-0x0000000180606100
		public string GetActionNameById(int id); // 0x0000000180606230-0x00000001806063A0
		public InputAction GetAction(int index); // 0x0000000180606840-0x00000001806068D0
		public InputAction GetAction(string name); // 0x00000001806067B0-0x0000000180606840
		public InputAction GetActionById(int id); // 0x00000001806053D0-0x0000000180605500
		public int GetActionId(string name); // 0x0000000180605DE0-0x0000000180605E80
		public string[] GetSortedActionNamesInCategory(int id); // 0x0000000180610470-0x0000000180610670
		public IEnumerable<string> SortedActionNamesInCategory(int id); // 0x00000001806156F0-0x0000000180615770
		public string[] GetSortedActionDescriptiveNamesInCategory(int id); // 0x000000018060FFB0-0x0000000180610270
		public IEnumerable<string> SortedActionDescriptiveNamesInCategory(int id); // 0x00000001806155D0-0x0000000180615650
		public int[] GetSortedActionIdsInCategory(int id); // 0x0000000180610270-0x0000000180610470
		public IEnumerable<int> SortedActionIdsInCategory(int id); // 0x0000000180615650-0x00000001806156F0
		public bool ContainsAction(int id); // 0x00000001805FD860-0x00000001805FD880
		public int IndexOfAction(int id); // 0x0000000180611C30-0x0000000180611D30
		public int IndexOfAction(string name); // 0x0000000180611D30-0x0000000180611E90
		public void AddActionCategory(); // 0x00000001805FCE10-0x00000001805FCEA0
		public void InsertActionCategory(int index); // 0x0000000180613570-0x0000000180613680
		public void DeleteActionCategory(int index); // 0x00000001805FDD40-0x00000001805FDFD0
		public bool ReorderActionCategory(int index, bool offsetDown, bool offsetNow); // 0x0000000180615060-0x0000000180615110
		public void DuplicateActionCategory(int index, bool duplicateActions); // 0x0000000180601010-0x0000000180601660
		public void ChangeActionCategory(int actionId, int newCategoryId); // 0x00000001805FD540-0x00000001805FD670
		public int GetActionCategoryCount(int id); // 0x00000001806055C0-0x0000000180605720
		public int GetActionCategoryIndex(int id); // 0x0000000180605900-0x00000001806059F0
		public string[] GetActionCategoryNames(); // 0x0000000180605B40-0x0000000180605CB0
		public int[] GetActionCategoryIds(); // 0x00000001806057C0-0x0000000180605900
		public InputCategory GetActionCategory(int index); // 0x0000000180605CB0-0x0000000180605D50
		public InputCategory GetActionCategory(string name); // 0x0000000180605D50-0x0000000180605DE0
		public InputCategory GetActionCategoryById(int id); // 0x0000000180605500-0x0000000180605580
		public int GetActionCategoryId(string name); // 0x0000000180605720-0x00000001806057C0
		public string GetActionCategoryNameById(int id); // 0x00000001806059F0-0x0000000180605B40
		public int IndexOfActionCategory(int id); // 0x0000000180611B30-0x0000000180611C30
		public int IndexOfActionCategory(string name); // 0x00000001806119F0-0x0000000180611B30
		public int GetActionCategoryCount(); // 0x0000000180605580-0x00000001806055C0
		public void AddInputBehavior(); // 0x00000001805FD210-0x00000001805FD270
		public void InsertInputBehavior(int index); // 0x0000000180613BC0-0x0000000180613CA0
		public void DeleteInputBehavior(int index); // 0x00000001805FF320-0x00000001805FF580
		public bool ReorderInputBehavior(int index, bool offsetDown, bool offsetNow); // 0x0000000180615330-0x00000001806153A0
		public void DuplicateInputBehavior(int index); // 0x0000000180602900-0x0000000180602B20
		public string[] GetInputBehaviorNames(); // 0x000000018060A6C0-0x000000018060A840
		public int[] GetInputBehaviorIds(); // 0x000000018060A570-0x000000018060A6C0
		public InputBehavior GetInputBehavior(int index); // 0x000000018060A8D0-0x000000018060A960
		public InputBehavior GetInputBehavior(string name); // 0x000000018060A840-0x000000018060A8D0
		public InputBehavior GetInputBehaviorById(int id); // 0x000000018060A380-0x000000018060A4D0
		public int GetInputBehaviorId(string name); // 0x000000018060A4D0-0x000000018060A570
		public int IndexOfInputBehavior(int id); // 0x00000001806129C0-0x0000000180612AD0
		public int IndexOfInputBehavior(string name); // 0x0000000180612AD0-0x0000000180612C30
		public void AddMapCategory(); // 0x00000001805FD330-0x00000001805FD390
		public void InsertMapCategory(int index); // 0x0000000180613E00-0x0000000180613EE0
		public void DeleteMapCategory(int index); // 0x00000001805FFEB0-0x00000001806009F0
		public bool ReorderMapCategory(int index, bool offsetDown, bool offsetNow); // 0x0000000180615480-0x00000001806154F0
		public void DuplicateMapCategory(int index, bool duplicateMaps); // 0x0000000180603520-0x0000000180603E00
		public int GetMapCategoryMapCount(int id); // 0x000000018060DB70-0x000000018060DF60
		public int GetMapCategoryIndex(int id); // 0x000000018060DA60-0x000000018060DB70
		public string[] GetMapCategoryNames(); // 0x000000018060E0B0-0x000000018060E220
		public int[] GetMapCategoryIds(); // 0x000000018060D910-0x000000018060DA60
		public InputMapCategory GetMapCategory(int index); // 0x000000018060E220-0x000000018060E2B0
		public InputMapCategory GetMapCategory(string name); // 0x000000018060E2B0-0x000000018060E340
		public InputMapCategory GetMapCategoryById(int id); // 0x000000018060D740-0x000000018060D870
		public int GetMapCategoryId(string name); // 0x000000018060D870-0x000000018060D910
		public string GetMapCategoryNameById(int id); // 0x000000018060DF60-0x000000018060E0B0
		public int IndexOfMapCategory(int id); // 0x0000000180613250-0x0000000180613340
		public int IndexOfMapCategory(string name); // 0x00000001806130F0-0x0000000180613250
		public string[] GetLayoutNames(ControllerType controllerType); // 0x000000018060D680-0x000000018060D740
		public int[] GetLayoutIds(ControllerType controllerType); // 0x000000018060CC90-0x000000018060D190
		public void AddJoystickLayout(); // 0x00000001805FD270-0x00000001805FD2D0
		public void InsertJoystickLayout(int index); // 0x0000000180613CA0-0x0000000180613D50
		public void DeleteJoystickLayout(int index); // 0x00000001805FF580-0x00000001805FF8F0
		public bool ReorderJoystickLayout(int index, bool offsetDown, bool offsetNow); // 0x00000001806153A0-0x0000000180615410
		public void DuplicateJoystickLayout(int index, bool duplicateMaps); // 0x0000000180602B20-0x0000000180602EF0
		public int GetJoystickLayoutMapCount(int id); // 0x000000018060AF30-0x000000018060B080
		public int GetJoystickLayoutIndex(int id); // 0x000000018060AE20-0x000000018060AF30
		public string[] GetJoystickLayoutNames(); // 0x000000018060B1F0-0x000000018060B370
		public int[] GetJoystickLayoutIds(); // 0x000000018060AC90-0x000000018060AE20
		public InputLayout GetJoystickLayout(int index); // 0x000000018060B400-0x000000018060B4A0
		public InputLayout GetJoystickLayout(string name); // 0x000000018060B370-0x000000018060B400
		public InputLayout GetJoystickLayoutById(int id); // 0x000000018060AA80-0x000000018060ABF0
		public int GetJoystickLayoutId(string name); // 0x000000018060ABF0-0x000000018060AC90
		public int IndexOfJoystickLayout(int id); // 0x0000000180612C30-0x0000000180612D50
		public int IndexOfJoystickLayout(string name); // 0x0000000180612D50-0x0000000180612E90
		public string GetJoystickLayoutNameById(int id); // 0x000000018060B080-0x000000018060B1F0
		public void AddKeyboardLayout(); // 0x00000001805FD2D0-0x00000001805FD330
		public void InsertKeyboardLayout(int index); // 0x0000000180613D50-0x0000000180613E00
		public void DeleteKeyboardLayout(int index); // 0x00000001805FFA40-0x00000001805FFDC0
		public bool ReorderKeyboardLayout(int index, bool offsetDown, bool offsetNow); // 0x0000000180615410-0x0000000180615480
		public void DuplicateKeyboardLayout(int index, bool duplicateMaps); // 0x0000000180603020-0x0000000180603420
		public int GetKeyboardLayoutMapCount(int id); // 0x000000018060C180-0x000000018060C300
		public int GetKeyboardLayoutIndex(int id); // 0x000000018060C070-0x000000018060C180
		public string[] GetKeyboardLayoutNames(); // 0x000000018060C420-0x000000018060C5A0
		public int[] GetKeyboardLayoutIds(); // 0x000000018060BF20-0x000000018060C070
		public InputLayout GetKeyboardLayout(int index); // 0x000000018060C5A0-0x000000018060C630
		public InputLayout GetKeyboardLayout(string name); // 0x000000018060C630-0x000000018060C6D0
		public InputLayout GetKeyboardLayoutById(int id); // 0x000000018060BD00-0x000000018060BE80
		public int GetKeyboardLayoutId(string name); // 0x000000018060BE80-0x000000018060BF20
		public int IndexOfKeyboardLayout(int id); // 0x0000000180613000-0x00000001806130F0
		public int IndexOfKeyboardLayout(string name); // 0x0000000180612E90-0x0000000180613000
		public string GetKeyboardLayoutNameById(int id); // 0x000000018060C300-0x000000018060C420
		public void AddMouseLayout(); // 0x00000001805FD390-0x00000001805FD3F0
		public void InsertMouseLayout(int index); // 0x0000000180613EE0-0x0000000180613FC0
		public void DeleteMouseLayout(int index); // 0x00000001806009F0-0x0000000180600E40
		public bool ReorderMouseLayout(int index, bool offsetDown, bool offsetNow); // 0x00000001806154F0-0x0000000180615560
		public void DuplicateMouseLayout(int index, bool duplicateMaps); // 0x0000000180603E00-0x0000000180604260
		public int GetMouseLayoutMapCount(int id); // 0x000000018060E770-0x000000018060E8C0
		public int GetMouseLayoutIndex(int id); // 0x000000018060E670-0x000000018060E770
		public string[] GetMouseLayoutNames(); // 0x000000018060E9E0-0x000000018060EB60
		public int[] GetMouseLayoutIds(); // 0x000000018060E530-0x000000018060E670
		public InputLayout GetMouseLayout(int index); // 0x000000018060EBF0-0x000000018060EC90
		public InputLayout GetMouseLayout(string name); // 0x000000018060EB60-0x000000018060EBF0
		public InputLayout GetMouseLayoutById(int id); // 0x000000018060E340-0x000000018060E490
		public int GetMouseLayoutId(string name); // 0x000000018060E490-0x000000018060E530
		public int IndexOfMouseLayout(int id); // 0x0000000180613340-0x0000000180613430
		public int IndexOfMouseLayout(string name); // 0x0000000180613430-0x0000000180613570
		public string GetMouseLayoutNameById(int id); // 0x000000018060E8C0-0x000000018060E9E0
		public void AddCustomControllerLayout(); // 0x00000001805FD000-0x00000001805FD060
		public void InsertCustomControllerLayout(int index); // 0x00000001806139B0-0x0000000180613A90
		public void DeleteCustomControllerLayout(int index); // 0x00000001805FEC10-0x00000001805FEF70
		public bool ReorderCustomControllerLayout(int index, bool offsetDown, bool offsetNow); // 0x0000000180615240-0x00000001806152B0
		public void DuplicateCustomControllerLayout(int index, bool duplicateMaps); // 0x0000000180601E40-0x0000000180602240
		public int GetCustomControllerLayoutMapCount(int id); // 0x0000000180609210-0x0000000180609380
		public int GetCustomControllerLayoutIndex(int id); // 0x0000000180609120-0x0000000180609210
		public string[] GetCustomControllerLayoutNames(); // 0x00000001806094A0-0x0000000180609610
		public int[] GetCustomControllerLayoutIds(); // 0x0000000180608FD0-0x0000000180609120
		public InputLayout GetCustomControllerLayout(int index); // 0x00000001806096A0-0x0000000180609730
		public InputLayout GetCustomControllerLayout(string name); // 0x0000000180609610-0x00000001806096A0
		public InputLayout GetCustomControllerLayoutById(int id); // 0x0000000180608DC0-0x0000000180608F00
		public int GetCustomControllerLayoutId(string name); // 0x0000000180608F00-0x0000000180608FD0
		public int IndexOfCustomControllerLayout(int id); // 0x0000000180612520-0x0000000180612610
		public int IndexOfCustomControllerLayout(string name); // 0x00000001806123C0-0x0000000180612520
		public string GetCustomControllerLayoutNameById(int id); // 0x0000000180609380-0x00000001806094A0
		public string GetLayoutNameById(ControllerType controllerType, int id); // 0x000000018060D190-0x000000018060D680
		internal ControllerMap EOwoytsuxWtNKYwmHmCJQPHsTZI(Controller param_0000d387, int param_0000d388, int param_0000d389); // 0x0000000180604580-0x00000001806049E0
		public ControllerMap_Editor GetJoystickMap(int categoryId, Guid hardwareGuid, int layoutId); // 0x000000018060B890-0x000000018060BAE0
		public ControllerMap_Editor GetJoystickMapById(int id, out int joystickMapIndex); // 0x000000018060B4A0-0x000000018060B600
		public List<ControllerMap_Editor> GetJoystickMaps(Guid hardwareGuid); // 0x000000018060BAE0-0x000000018060BD00
		public int GetJoystickMapId(int categoryId, Guid hardwareGuid, int layoutId); // 0x000000018060B600-0x000000018060B890
		public bool HasJoystickMap(int categoryId, Guid hardwareGuid, int layoutId); // 0x0000000180610E40-0x00000001806110D0
		public bool HasJoystickMap(Guid hardwareGuid); // 0x0000000180610CA0-0x0000000180610E40
		public bool HasJoystickMapInCategory(Guid hardwareGuid, int categoryId); // 0x0000000180610A90-0x0000000180610CA0
		public bool CreateJoystickMap(int categoryId, Guid joystickOrTemplateGuid, int layoutId); // 0x00000001805FD9E0-0x00000001805FDB00
		public void DeleteJoystickMap(int id); // 0x00000001805FF8F0-0x00000001805FFA40
		public int DuplicateJoystickMap(int index); // 0x0000000180602EF0-0x0000000180603020
		internal JoystickMap YpJPZbuZGPdqkNaBIcofHiInTJhW(HardwareControllerMapIdentifier param_0000d39e, int param_0000d39f, int param_0000d3a0); // 0x0000000180615F00-0x0000000180615FB0
		internal JoystickMap xdnItkCfoFccxjuXFxctPHWGIzYh(Joystick param_0000d3a1, int param_0000d3a2, int param_0000d3a3); // 0x0000000180618390-0x0000000180618420
		private JoystickMap xdnItkCfoFccxjuXFxctPHWGIzYh(HardwareControllerMapIdentifier param_0000d3a4, int param_0000d3a5, int param_0000d3a6); // 0x0000000180618420-0x0000000180619030
		private ControllerMap_Editor ndLQqrZEpaEeFJfFjDDduWYBJeLR(int param_0000d3a7, Guid param_0000d3a8, int param_0000d3a9, bool param_0000d3aa); // 0x0000000180617340-0x00000001806173D0
		private ControllerMap_Editor mPtxhjxlVFVqWTxdRHJhZSsEQrB(int param_0000d3ab, Guid param_0000d3ac, int param_0000d3ad); // 0x0000000180616E60-0x00000001806170E0
		private JoystickMap xWJwxqAPumMvwMjOUGADtxdZhJkD(HardwareControllerMapIdentifier param_0000d3ae, ControllerMap_Editor param_0000d3af, HardwareJoystickTemplateMap param_0000d3b0, HardwareJoystickMap param_0000d3b1, int param_0000d3b2, int param_0000d3b3); // 0x0000000180617F20-0x0000000180618390
		private JoystickMap EpoZIaplrcKnAsrXHChOSpULxzE(JoystickMap param_0000d3b4, HardwareControllerMapIdentifier param_0000d3b5); // 0x00000001806049E0-0x0000000180605240
		public ControllerMap_Editor GetKeyboardMap(int categoryId, int layoutId); // 0x000000018060C990-0x000000018060CB50
		public int GetKeyboardMapId(int categoryId, int layoutId); // 0x000000018060C810-0x000000018060C990
		public bool HasKeyboardMap(int categoryId, Guid hardwareGuid, int layoutId); // 0x0000000180611330-0x0000000180611590
		public bool CreateKeyboardMap(int categoryId, int layoutId); // 0x00000001805FDB00-0x00000001805FDC50
		public void DeleteKeyboardMap(int id); // 0x00000001805FFDC0-0x00000001805FFEB0
		public int DuplicateKeyboardMap(int index); // 0x0000000180603420-0x0000000180603520
		public ControllerMap_Editor GetKeyboardMapById(int id, out int keyboardMapIndex); // 0x000000018060C6D0-0x000000018060C810
		public KeyboardMap FindKeyboardMap_Game(int categoryId, int layoutId); // 0x0000000180605240-0x0000000180605320
		public bool HasKeyboardMapInCategory(int categoryId); // 0x00000001806110D0-0x00000001806111E0
		public bool HasKeyboardMapInLayout(int categoryId, int layoutId); // 0x00000001806111E0-0x0000000180611330
		public ControllerMap_Editor GetMouseMap(int categoryId, int layoutId); // 0x000000018060EF50-0x000000018060F0B0
		public int GetMouseMapId(int categoryId, int layoutId); // 0x000000018060EDC0-0x000000018060EF50
		public bool HasMouseMap(int categoryId, Guid hardwareGuid, int layoutId); // 0x00000001806117D0-0x00000001806119F0
		public bool CreateMouseMap(int categoryId, int layoutId); // 0x00000001805FDC50-0x00000001805FDD40
		public void DeleteMouseMap(int id); // 0x0000000180600E40-0x0000000180600F60
		public int DuplicateMouseMap(int index); // 0x0000000180604260-0x0000000180604360
		public ControllerMap_Editor GetMouseMapById(int id, out int mouseMapIndex); // 0x000000018060EC90-0x000000018060EDC0
		public MouseMap FindMouseMap_Game(int categoryId, int layoutId); // 0x0000000180605320-0x00000001806053D0
		public bool HasMouseMapInCategory(int categoryId); // 0x0000000180611590-0x0000000180611680
		public bool HasMouseMapInLayout(int categoryId, int layoutId); // 0x0000000180611680-0x00000001806117D0
		public ControllerMap_Editor GetCustomControllerMap(int categoryId, int controllerUid, int layoutId); // 0x0000000180609BE0-0x0000000180609DA0
		public ControllerMap_Editor GetCustomControllerMapById(int mapId, out int customControllerMapIndex); // 0x0000000180609730-0x0000000180609890
		public List<ControllerMap_Editor> GetCustomControllerMaps(int controllerUid); // 0x0000000180609DA0-0x0000000180609F60
		public int GetCustomControllerMapId(int categoryId, int controllerUid, int layoutId); // 0x0000000180609A10-0x0000000180609BE0
		public bool HasCustomControllerMap(int mapId, int categoryId, int layoutId); // 0x00000001806107B0-0x0000000180610990
		public bool HasCustomControllerMap(int mapId); // 0x0000000180610990-0x0000000180610A90
		public bool HasCustomControllerMapInCategory(int controllerUid, int categoryId); // 0x0000000180610670-0x00000001806107B0
		public bool CreateCustomControllerMap(int categoryId, int controllerUid, int layoutId); // 0x00000001805FD880-0x00000001805FD9E0
		public void DeleteCustomControllerMap(int mapId); // 0x00000001805FEF70-0x00000001805FF0D0
		public int DuplicateCustomControllerMap(int index); // 0x0000000180602240-0x0000000180602420
		internal CustomControllerMap ARagziTwlApCZyMQCFSXAnskIdXr(Guid param_0000d3ee, int param_0000d3ef, int param_0000d3f0); // 0x00000001805FCC20-0x00000001805FCE10
		internal CustomControllerMap ARagziTwlApCZyMQCFSXAnskIdXr(int param_0000d3f1, int param_0000d3f2, int param_0000d3f3); // 0x00000001805FC910-0x00000001805FCAA0
		private CustomControllerMap ARagziTwlApCZyMQCFSXAnskIdXr(CustomController_Editor param_0000d3f4, int param_0000d3f5, int param_0000d3f6); // 0x00000001805FCAA0-0x00000001805FCC20
		private ControllerMap_Editor kVbbpwdMQAYYIbltrCknXBDGTYp(int param_0000d3f7, int param_0000d3f8, int param_0000d3f9, bool param_0000d3fa); // 0x0000000180616C70-0x0000000180616E60
		private ControllerMap_Editor WxYEjbQGVzEHorCNfYMmDyOxqDD(int param_0000d3fb, int param_0000d3fc, int param_0000d3fd); // 0x0000000180615A20-0x0000000180615F00
		public void DeleteControllerMap(ControllerType controllerType, int id); // 0x00000001805FE6F0-0x00000001805FEC10
		public ControllerMap_Editor GetControllerMapByIndex(ControllerType controllerType, int index); // 0x0000000180606EE0-0x0000000180606FD0
		public ControllerMap_Editor GetControllerMapById(ControllerType controllerType, int id, out int controllerMapIndex); // 0x00000001806069E0-0x0000000180606EE0
		public int DuplicateControllerMap(ControllerType controllerType, int index); // 0x0000000180601D50-0x0000000180601E40
		internal ControllerTemplateMap suUFvLntwhKbrtAyeagJKrjQEDq(Guid param_0000d407, int param_0000d408, int param_0000d409); // 0x0000000180617AB0-0x0000000180617B20
		public void AddCustomController(); // 0x00000001805FD060-0x00000001805FD210
		public void InsertCustomController(int index); // 0x0000000180613A90-0x0000000180613BC0
		public void DeleteCustomController(int index); // 0x00000001805FF0D0-0x00000001805FF320
		public bool ReorderCustomController(int index, bool offsetDown, bool offsetNow); // 0x00000001806152B0-0x0000000180615330
		public void DuplicateCustomController(int index, bool duplicateMaps); // 0x0000000180602420-0x0000000180602900
		public int GetCustomControllerMapCount(int controllerUid); // 0x0000000180609890-0x0000000180609A10
		public int GetCustomControllerIndex(int id); // 0x0000000180608CA0-0x0000000180608DC0
		public string[] GetCustomControllerNames(); // 0x000000018060A0A0-0x000000018060A260
		public int[] GetCustomControllerIds(); // 0x0000000180608B70-0x0000000180608CA0
		public Guid[] GetCustomControllerGuids(); // 0x0000000180608940-0x0000000180608AD0
		public CustomController_Editor GetCustomController(int index); // 0x000000018060A2F0-0x000000018060A380
		public CustomController_Editor GetCustomController(string name); // 0x000000018060A260-0x000000018060A2F0
		public CustomController_Editor GetCustomControllerById(int id); // 0x00000001806087C0-0x0000000180608940
		public CustomController_Editor GetCustomControllerByHardwareTypeGuid(Guid hardwareTypeGuid); // 0x00000001806085F0-0x00000001806087C0
		public int GetCustomControllerId(string name); // 0x0000000180608AD0-0x0000000180608B70
		public int IndexOfCustomController(int id); // 0x0000000180612760-0x0000000180612860
		public int IndexOfCustomController(string name); // 0x0000000180612610-0x0000000180612760
		public int IndexOfCustomController(Guid hardwareTypeGuid); // 0x0000000180612860-0x00000001806129C0
		public string GetCustomControllerNameById(int id); // 0x0000000180609F60-0x000000018060A0A0
		public void AddControllerMapLayoutManagerRuleSet(); // 0x00000001805FCFA0-0x00000001805FD000
		public void InsertControllerMapLayoutManagerRuleSet(int index); // 0x00000001806138C0-0x00000001806139B0
		public void DeleteControllerMapLayoutManagerRuleSet(int index); // 0x00000001805FE3D0-0x00000001805FE6F0
		public bool ReorderControllerMapLayoutManagerRuleSet(int index, bool offsetDown, bool offsetNow); // 0x00000001806151C0-0x0000000180615240
		public void DuplicateControllerMapLayoutManagerRuleSet(int index); // 0x0000000180601B40-0x0000000180601D50
		public int GetControllerMapLayoutManagerRuleSetUsedCount(int id); // 0x00000001806082C0-0x00000001806084F0
		public int GetControllerMapLayoutManagerRuleSetIndex(int id); // 0x0000000180607EA0-0x0000000180607FD0
		public string[] GetControllerMapLayoutManagerRuleSetNames(); // 0x0000000180608130-0x00000001806082C0
		public int[] GetControllerMapLayoutManagerRuleSetIds(); // 0x0000000180607D60-0x0000000180607EA0
		public ControllerMapLayoutManager_RuleSet_Editor GetControllerMapLayoutManagerRuleSet(int index); // 0x00000001806084F0-0x0000000180608560
		public ControllerMapLayoutManager_RuleSet_Editor GetControllerMapLayoutManagerRuleSet(string name); // 0x0000000180608560-0x00000001806085F0
		public ControllerMapLayoutManager_RuleSet_Editor GetControllerMapLayoutManagerRuleSetById(int id); // 0x0000000180607B00-0x0000000180607C80
		public int GetControllerMapLayoutManagerRuleSetId(string name); // 0x0000000180607CC0-0x0000000180607D60
		public int IndexOfControllerMapLayoutManagerRuleSet(int id); // 0x0000000180612290-0x00000001806123C0
		public int IndexOfControllerMapLayoutManagerRuleSet(string name); // 0x0000000180612100-0x0000000180612290
		public string GetControllerMapLayoutManagerRuleSetNameById(int id); // 0x0000000180607FD0-0x0000000180608130
		public int GetControllerMapLayoutManagerRuleSetCount(); // 0x0000000180607C80-0x0000000180607CC0
		public void AddControllerMapEnablerRuleSet(); // 0x00000001805FCF40-0x00000001805FCFA0
		public void InsertControllerMapEnablerRuleSet(int index); // 0x00000001806137C0-0x00000001806138C0
		public void DeleteControllerMapEnablerRuleSet(int index); // 0x00000001805FE0B0-0x00000001805FE3D0
		public bool ReorderControllerMapEnablerRuleSet(int index, bool offsetDown, bool offsetNow); // 0x0000000180615140-0x00000001806151C0
		public void DuplicateControllerMapEnablerRuleSet(int index); // 0x00000001806018F0-0x0000000180601B40
		public int GetControllerMapEnablerRuleSetUsedCount(int id); // 0x0000000180607790-0x0000000180607A00
		public int GetControllerMapEnablerRuleSetIndex(int id); // 0x0000000180607380-0x00000001806074A0
		public string[] GetControllerMapEnablerRuleSetNames(); // 0x00000001806075F0-0x0000000180607790
		public int[] GetControllerMapEnablerRuleSetIds(); // 0x0000000180607230-0x0000000180607380
		public ControllerMapEnabler_RuleSet_Editor GetControllerMapEnablerRuleSet(int index); // 0x0000000180607A00-0x0000000180607A70
		public ControllerMapEnabler_RuleSet_Editor GetControllerMapEnablerRuleSet(string name); // 0x0000000180607A70-0x0000000180607B00
		public ControllerMapEnabler_RuleSet_Editor GetControllerMapEnablerRuleSetById(int id); // 0x0000000180606FD0-0x0000000180607150
		public int GetControllerMapEnablerRuleSetId(string name); // 0x0000000180607190-0x0000000180607230
		public int IndexOfControllerMapEnablerRuleSet(int id); // 0x0000000180611FF0-0x0000000180612100
		public int IndexOfControllerMapEnablerRuleSet(string name); // 0x0000000180611E90-0x0000000180611FF0
		public string GetControllerMapEnablerRuleSetNameById(int id); // 0x00000001806074A0-0x00000001806075F0
		public int GetControllerMapEnablerRuleSetCount(); // 0x0000000180607150-0x0000000180607190
		public int GetNewPlayerId(); // 0x000000018060F320-0x000000018060F330
		public int GetNewActionId(); // 0x000000018060F210-0x000000018060F220
		public int GetNewActionCategoryId(); // 0x000000018060F200-0x000000018060F210
		public int GetNewInputBehaviorId(); // 0x000000018060F2A0-0x000000018060F2B0
		public int GetNewMapCategoryId(); // 0x000000018060F2F0-0x000000018060F300
		public int GetNewJoystickLayoutId(); // 0x000000018060F2B0-0x000000018060F2C0
		public int GetNewKeyboardLayoutId(); // 0x000000018060F2D0-0x000000018060F2E0
		public int GetNewMouseLayoutId(); // 0x000000018060F300-0x000000018060F310
		public int GetNewCustomControllerLayoutId(); // 0x000000018060F280-0x000000018060F290
		public int GetNewJoystickMapId(); // 0x000000018060F2C0-0x000000018060F2D0
		public int GetNewKeyboardMapId(); // 0x000000018060F2E0-0x000000018060F2F0
		public int GetNewMouseMapId(); // 0x000000018060F310-0x000000018060F320
		public int GetNewCustomControllerMapId(); // 0x000000018060F290-0x000000018060F2A0
		public int GetNewCustomControllerId(); // 0x000000018060F240-0x000000018060F280
		public int GetNewControllerMapLayoutManagerRuleSetId(); // 0x000000018060F230-0x000000018060F240
		public int GetNewControllerMapEnablerRuleSetId(); // 0x000000018060F220-0x000000018060F230
		private Player_Editor QWHDzZlTCcswdrBErdzWZjHDCgS(); // 0x0000000180614E20-0x0000000180615060
		private InputAction iClmbcIAebGtuWzgkzsXTZEwKHh(); // 0x0000000180616BA0-0x0000000180616C70
		private InputCategory BlOLAqqsklgrrJjnVePhtpZwDJz(); // 0x00000001805FD450-0x00000001805FD540
		private InputBehavior msQiNXZpntCADLQypZWjQeIvStM(); // 0x00000001806170E0-0x0000000180617340
		private InputMapCategory aRRZkQbibAfeqtboQEjeDJqsCLX(); // 0x0000000180616580-0x0000000180616640
		private InputLayout tffiJlHPSckjhLxLZEFnmJfXRiLe(); // 0x0000000180617BA0-0x0000000180617C60
		private InputLayout OXOlRHvKOnFHLdnLYQUfmSyOQAt(); // 0x0000000180614B10-0x0000000180614BD0
		private InputLayout odVcwomCUhldxQCiLbmsUDDjgaVd(); // 0x00000001806173D0-0x0000000180617490
		private InputLayout psRmQHgHRVOWmmSyJXvfmQVEDUI(); // 0x0000000180617670-0x0000000180617730
		private CustomController_Editor pkWHkUynJrcctjvbGqRBCpVGtFNe(); // 0x0000000180617550-0x0000000180617670
		private ControllerMapLayoutManager_RuleSet_Editor pWsybvsmmQkxlqgwvRbHUvbDBuF(); // 0x0000000180617490-0x0000000180617550
		private ControllerMapEnabler_RuleSet_Editor yYqfDqrfzbEHMJDeYeotdDvtgdJF(); // 0x00000001806190B0-0x0000000180619190
		private ControllerMap_Editor cUkfTUEdeGdJPAVZiNiejnaoLFNO(List<ControllerMap_Editor> param_0000d43a, int param_0000d43b, int param_0000d43c); // 0x00000001806166C0-0x0000000180616810
		private ControllerMap_Editor IyhtNZkPhHhmMxMfbhJOMFFEbUm(List<ControllerMap_Editor> param_0000d43d, List<InputLayout> param_0000d43e, int param_0000d43f, int param_0000d440, bool param_0000d441); // 0x00000001806146E0-0x00000001806148A0
		private ControllerMap_Editor rLLOzlhxnJLQFWpxFcBxtcOFmoM(List<ControllerMap_Editor> param_0000d442, List<InputLayout> param_0000d443, int param_0000d444, int param_0000d445); // 0x0000000180617730-0x0000000180617A50
		private void gfJZYxyBTRoASASxDVylKmciAEV(List<ControllerMap_Editor> param_0000d446, List<InputLayout> param_0000d447); // 0x0000000180616AC0-0x0000000180616BA0
		internal void ItdhavHGXcUkAhyjaCFbIXENJheh(); // 0x00000001806142C0-0x00000001806146E0
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		internal static UserData Merge(UserData orig, UserData other, bool preserveOrigIds); // 0x00000001806149F0-0x0000000180614A00
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		internal static UserData Compact(UserData orig); // 0x00000001805FD850-0x00000001805FD860
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private static void WKaKGNfMHeCdScZcerMBHvRQECn(List<Player_Editor.Mapping> param_0000d44c, int param_0000d44d); // 0x00000001806158D0-0x0000000180615A20
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private static void StefxDPlBjQaiHnNVLndCSwQYaB(List<Player_Editor.Mapping> param_0000d44e, int param_0000d44f); // 0x0000000180615770-0x00000001806158D0
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private static void JqZsbOkJPHiKzOEQbwQhjgwxEqJI(List<Player_Editor.Mapping> param_0000d450, int param_0000d451); // 0x00000001806148A0-0x00000001806149F0
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private static void dpBcsqEaQaCZJrrxLzIXaZudUqz(List<Player_Editor.Mapping> param_0000d452, int param_0000d453); // 0x0000000180616810-0x0000000180616920
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private static void NslsOMnHJwNgQpCRpuMkJDkqUfa(List<Player_Editor.Mapping> param_0000d454, int param_0000d455); // 0x0000000180614A00-0x0000000180614B10
	}
}
