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

// Image 50: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5712-6954

namespace Rewired.Data
{
	[Serializable]
	public sealed class UserData // TypeDefIndex: 6264
	{
		// Fields
		[CustomObfuscation] // 0x00000001800C3DD0-0x00000001800C3E10
		[SerializeField] // 0x00000001800C3DD0-0x00000001800C3E10
		private ConfigVars configVars; // 0x10
		[CustomObfuscation] // 0x00000001800C5270-0x00000001800C52B0
		[SerializeField] // 0x00000001800C5270-0x00000001800C52B0
		private List<Player_Editor> players; // 0x18
		[CustomObfuscation] // 0x00000001800C5270-0x00000001800C52B0
		[SerializeField] // 0x00000001800C5270-0x00000001800C52B0
		private List<InputAction> actions; // 0x20
		[CustomObfuscation] // 0x00000001800C5270-0x00000001800C52B0
		[SerializeField] // 0x00000001800C5270-0x00000001800C52B0
		private List<InputCategory> actionCategories; // 0x28
		[CustomObfuscation] // 0x00000001800C5270-0x00000001800C52B0
		[SerializeField] // 0x00000001800C5270-0x00000001800C52B0
		private ActionCategoryMap actionCategoryMap; // 0x30
		[CustomObfuscation] // 0x00000001800C3DD0-0x00000001800C3E10
		[SerializeField] // 0x00000001800C3DD0-0x00000001800C3E10
		private List<InputBehavior> inputBehaviors; // 0x38
		[CustomObfuscation] // 0x00000001800C3DD0-0x00000001800C3E10
		[SerializeField] // 0x00000001800C3DD0-0x00000001800C3E10
		private List<InputMapCategory> mapCategories; // 0x40
		[CustomObfuscation] // 0x00000001800C3DD0-0x00000001800C3E10
		[SerializeField] // 0x00000001800C3DD0-0x00000001800C3E10
		private List<InputLayout> joystickLayouts; // 0x48
		[CustomObfuscation] // 0x00000001800C3DD0-0x00000001800C3E10
		[SerializeField] // 0x00000001800C3DD0-0x00000001800C3E10
		private List<InputLayout> keyboardLayouts; // 0x50
		[CustomObfuscation] // 0x00000001800C5270-0x00000001800C52B0
		[SerializeField] // 0x00000001800C5270-0x00000001800C52B0
		private List<InputLayout> mouseLayouts; // 0x58
		[CustomObfuscation] // 0x00000001800C5270-0x00000001800C52B0
		[SerializeField] // 0x00000001800C5270-0x00000001800C52B0
		private List<InputLayout> customControllerLayouts; // 0x60
		[CustomObfuscation] // 0x00000001800C5270-0x00000001800C52B0
		[SerializeField] // 0x00000001800C5270-0x00000001800C52B0
		private List<ControllerMap_Editor> joystickMaps; // 0x68
		[CustomObfuscation] // 0x00000001800C3DD0-0x00000001800C3E10
		[SerializeField] // 0x00000001800C3DD0-0x00000001800C3E10
		private List<ControllerMap_Editor> keyboardMaps; // 0x70
		[CustomObfuscation] // 0x00000001800C5270-0x00000001800C52B0
		[SerializeField] // 0x00000001800C5270-0x00000001800C52B0
		private List<ControllerMap_Editor> mouseMaps; // 0x78
		[CustomObfuscation] // 0x00000001800C5270-0x00000001800C52B0
		[SerializeField] // 0x00000001800C5270-0x00000001800C52B0
		private List<ControllerMap_Editor> customControllerMaps; // 0x80
		[CustomObfuscation] // 0x00000001800C5270-0x00000001800C52B0
		[SerializeField] // 0x00000001800C5270-0x00000001800C52B0
		private List<CustomController_Editor> customControllers; // 0x88
		[CustomObfuscation] // 0x00000001800C3DD0-0x00000001800C3E10
		[SerializeField] // 0x00000001800C3DD0-0x00000001800C3E10
		private List<ControllerMapLayoutManager_RuleSet_Editor> controllerMapLayoutManagerRuleSets; // 0x90
		[CustomObfuscation] // 0x00000001800C5270-0x00000001800C52B0
		[SerializeField] // 0x00000001800C5270-0x00000001800C52B0
		private List<ControllerMapEnabler_RuleSet_Editor> controllerMapEnablerRuleSets; // 0x98
		[CustomObfuscation] // 0x00000001800C5270-0x00000001800C52B0
		[SerializeField] // 0x00000001800C5270-0x00000001800C52B0
		private int playerIdCounter; // 0xA0
		[CustomObfuscation] // 0x00000001800C5270-0x00000001800C52B0
		[SerializeField] // 0x00000001800C5270-0x00000001800C52B0
		private int actionIdCounter; // 0xA4
		[CustomObfuscation] // 0x00000001800C3DD0-0x00000001800C3E10
		[SerializeField] // 0x00000001800C3DD0-0x00000001800C3E10
		private int actionCategoryIdCounter; // 0xA8
		[CustomObfuscation] // 0x00000001800C3DD0-0x00000001800C3E10
		[SerializeField] // 0x00000001800C3DD0-0x00000001800C3E10
		private int inputBehaviorIdCounter; // 0xAC
		[CustomObfuscation] // 0x00000001800C3DD0-0x00000001800C3E10
		[SerializeField] // 0x00000001800C3DD0-0x00000001800C3E10
		private int mapCategoryIdCounter; // 0xB0
		[CustomObfuscation] // 0x00000001800C5270-0x00000001800C52B0
		[SerializeField] // 0x00000001800C5270-0x00000001800C52B0
		private int joystickLayoutIdCounter; // 0xB4
		[CustomObfuscation] // 0x00000001800C5270-0x00000001800C52B0
		[SerializeField] // 0x00000001800C5270-0x00000001800C52B0
		private int keyboardLayoutIdCounter; // 0xB8
		[CustomObfuscation] // 0x00000001800C5270-0x00000001800C52B0
		[SerializeField] // 0x00000001800C5270-0x00000001800C52B0
		private int mouseLayoutIdCounter; // 0xBC
		[CustomObfuscation] // 0x00000001800C5270-0x00000001800C52B0
		[SerializeField] // 0x00000001800C5270-0x00000001800C52B0
		private int customControllerLayoutIdCounter; // 0xC0
		[CustomObfuscation] // 0x00000001800C5270-0x00000001800C52B0
		[SerializeField] // 0x00000001800C5270-0x00000001800C52B0
		private int joystickMapIdCounter; // 0xC4
		[CustomObfuscation] // 0x00000001800C5270-0x00000001800C52B0
		[SerializeField] // 0x00000001800C5270-0x00000001800C52B0
		private int keyboardMapIdCounter; // 0xC8
		[CustomObfuscation] // 0x00000001800C3DD0-0x00000001800C3E10
		[SerializeField] // 0x00000001800C3DD0-0x00000001800C3E10
		private int mouseMapIdCounter; // 0xCC
		[CustomObfuscation] // 0x00000001800C3DD0-0x00000001800C3E10
		[SerializeField] // 0x00000001800C3DD0-0x00000001800C3E10
		private int customControllerMapIdCounter; // 0xD0
		[CustomObfuscation] // 0x00000001800C5270-0x00000001800C52B0
		[SerializeField] // 0x00000001800C5270-0x00000001800C52B0
		private int customControllerIdCounter; // 0xD4
		[CustomObfuscation] // 0x00000001800C3DD0-0x00000001800C3E10
		[SerializeField] // 0x00000001800C3DD0-0x00000001800C3E10
		private int controllerMapLayoutManagerSetIdCounter; // 0xD8
		[CustomObfuscation] // 0x00000001800C3DD0-0x00000001800C3E10
		[SerializeField] // 0x00000001800C3DD0-0x00000001800C3E10
		private int controllerMapEnablerSetIdCounter; // 0xDC
		private Func<int, bool> containsActionDelegate; // 0xE0
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private IList<Player_Editor> <Players_readOnly>k__BackingField; // 0xE8
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private IList<InputAction> <Actions_readOnly>k__BackingField; // 0xF0
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private IList<InputCategory> <ActionCategories_readOnly>k__BackingField; // 0xF8
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private IList<InputBehavior> <InputBehaviors_readOnly>k__BackingField; // 0x100
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private IList<InputMapCategory> <MapCategories_readOnly>k__BackingField; // 0x108
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private IList<InputLayout> <JoystickLayouts_readOnly>k__BackingField; // 0x110
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private IList<InputLayout> <KeyboardLayouts_readOnly>k__BackingField; // 0x118
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private IList<InputLayout> <MouseLayouts_readOnly>k__BackingField; // 0x120
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private IList<InputLayout> <CustomControllerLayouts_readOnly>k__BackingField; // 0x128
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private IList<ControllerMap_Editor> <JoystickMaps_readOnly>k__BackingField; // 0x130
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private IList<ControllerMap_Editor> <KeyboardMaps_readOnly>k__BackingField; // 0x138
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private IList<ControllerMap_Editor> <MouseMaps_readOnly>k__BackingField; // 0x140
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private IList<ControllerMap_Editor> <CustomControllerMaps_readOnly>k__BackingField; // 0x148
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private IList<ControllerMapLayoutManager_RuleSet_Editor> <ControllerMapLayoutManagerRuleSets_readOnly>k__BackingField; // 0x150
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private IList<ControllerMapEnabler_RuleSet_Editor> <ControllerMapEnablerRuleSets_readOnly>k__BackingField; // 0x158
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private static Action<List<Player_Editor.Mapping>, int> CS$<>9__CachedAnonymousMethodDelegate60; // 0x00
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private static Action<List<Player_Editor.Mapping>, int> CS$<>9__CachedAnonymousMethodDelegate62; // 0x08
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private static Action<List<Player_Editor.Mapping>, int> CS$<>9__CachedAnonymousMethodDelegate64; // 0x10
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private static Action<List<Player_Editor.Mapping>, int> CS$<>9__CachedAnonymousMethodDelegate66; // 0x18
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private static Action<List<Player_Editor.Mapping>, int> CS$<>9__CachedAnonymousMethodDelegate68; // 0x20
	
		// Properties
		internal IList<Player_Editor> Players_readOnly { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x000000018037A250-0x000000018037A260 0x000000018037AA30-0x000000018037AA40
		internal IList<InputAction> Actions_readOnly { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x00000001803BD320-0x00000001803BD330 0x00000001803BE540-0x00000001803BE550
		internal IList<InputCategory> ActionCategories_readOnly { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x00000001803BD310-0x00000001803BD320 0x00000001803BE530-0x00000001803BE540
		internal IList<InputBehavior> InputBehaviors_readOnly { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x00000001803BD370-0x00000001803BD380 0x00000001803BE590-0x00000001803BE5A0
		internal IList<InputMapCategory> MapCategories_readOnly { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x00000001803BD3C0-0x00000001803BD3D0 0x00000001803BE5E0-0x00000001803BE5F0
		internal IList<InputLayout> JoystickLayouts_readOnly { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x00000001803BD380-0x00000001803BD390 0x00000001803BE5A0-0x00000001803BE5B0
		internal IList<InputLayout> KeyboardLayouts_readOnly { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x00000001803BD3A0-0x00000001803BD3B0 0x00000001803BE5C0-0x00000001803BE5D0
		internal IList<InputLayout> MouseLayouts_readOnly { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x00000001803BD3D0-0x00000001803BD3E0 0x00000001803BE5F0-0x00000001803BE600
		internal IList<InputLayout> CustomControllerLayouts_readOnly { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x00000001803BD350-0x00000001803BD360 0x00000001803BE570-0x00000001803BE580
		internal IList<ControllerMap_Editor> JoystickMaps_readOnly { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x00000001803BD390-0x00000001803BD3A0 0x00000001803BE5B0-0x00000001803BE5C0
		internal IList<ControllerMap_Editor> KeyboardMaps_readOnly { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x00000001803BD3B0-0x00000001803BD3C0 0x00000001803BE5D0-0x00000001803BE5E0
		internal IList<ControllerMap_Editor> MouseMaps_readOnly { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x00000001803BD3E0-0x00000001803BD3F0 0x00000001803BE600-0x00000001803BE610
		internal IList<ControllerMap_Editor> CustomControllerMaps_readOnly { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x00000001803BD360-0x00000001803BD370 0x00000001803BE580-0x00000001803BE590
		internal IList<ControllerMapLayoutManager_RuleSet_Editor> ControllerMapLayoutManagerRuleSets_readOnly { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x00000001803BD340-0x00000001803BD350 0x00000001803BE560-0x00000001803BE570
		internal IList<ControllerMapEnabler_RuleSet_Editor> ControllerMapEnablerRuleSets_readOnly { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x00000001803BD330-0x00000001803BD340 0x00000001803BE550-0x00000001803BE560
		public ConfigVars ConfigVars { get; } // 0x000000018036AC80-0x000000018036AC90 
		internal IEnumerable<InputMapCategory> UserAssignableMapCategories { get; } // 0x00000001803BD4D0-0x00000001803BD540 
		internal IEnumerable<InputCategory> UserAssignableActionCategories { get; } // 0x00000001803BD3F0-0x00000001803BD460 
		internal IEnumerable<InputAction> UserAssignableActions { get; } // 0x00000001803BD460-0x00000001803BD4D0 
		public int playerCount { get; } // 0x00000001803BD540-0x00000001803BD580 
	
		// Nested types
		private static class WDCkxipPONaHhgdmaWQxRbsIymV // TypeDefIndex: 6265
		{
			// Fields
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private static Func<InputCategory, int> hVCdaAYbEbQkTRhAUgdUmlNpPNb; // 0x00
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private static Func<InputCategory, string> fgXeCNxGDaBYeTfrhGBxAuYNRJg; // 0x08
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private static Func<InputCategory, IList<InputCategory>, int> uvGgkvJUIoNzyupYFGOPSAdLhWT; // 0x10
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private static Func<InputBehavior, int> difHMSEAuNkaNmmJzuoLlklwDeF; // 0x18
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private static Func<InputBehavior, string> DiSArBFFRHplnrHlRhYapDJlrge; // 0x20
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private static Func<InputBehavior, IList<InputBehavior>, int> CwcNnvBGsVyghKkdAUjLMVeDOAe; // 0x28
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private static Func<InputAction, int> FePAFjKMastYeCJRQVOdFBdQJiI; // 0x30
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private static Func<InputAction, string> YTkauklqwAXESImsRhWSukQBsTE; // 0x38
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private static Func<InputAction, IList<InputAction>, int> nbuEfYdrsOvicakvKAOuAiTEdoVp; // 0x40
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private static Func<InputMapCategory, int> noataZMhzclfAyEwXbyrHNvhqVGC; // 0x48
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private static Func<InputMapCategory, string> ZqpjhlVpmeejvgoHVEqtWcGjipsp; // 0x50
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private static Func<InputMapCategory, IList<InputMapCategory>, int> DNvkajYAOAaiSFSdLgWZZDzaGase; // 0x58
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private static Func<InputLayout, int> drlzpvtirglCiiAvTQhqpmGMOVW; // 0x60
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private static Func<InputLayout, string> lLbQtiycKpITIrdAgxOwBOzCVGJ; // 0x68
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private static Func<InputLayout, IList<InputLayout>, int> zWJyIDTgQSkOCJKrhxcXvUrvybp; // 0x70
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private static Func<InputLayout, int> XRSHQucUSsLjeDhiFakPkdRoBlUe; // 0x78
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private static Func<InputLayout, string> qRxNChlQCECUNdwCYhxNUOxvuhm; // 0x80
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private static Func<InputLayout, IList<InputLayout>, int> tqNQINenSMUATdTOOzSOxRAgEbi; // 0x88
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private static Func<InputLayout, int> mhIoohQKHLtRvnOkGOyhEaVZzEI; // 0x90
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private static Func<InputLayout, string> xLsnLVMSdomUJlraUjoaaJurhHn; // 0x98
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private static Func<InputLayout, IList<InputLayout>, int> LqpbqWhYLnPlrmeWYhUGvnoFNkYM; // 0xA0
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private static Func<InputLayout, int> nnpRHVINhHOVQHcgAExuBWHPHnOo; // 0xA8
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private static Func<InputLayout, string> zxFEUXSbZKUDkCYPKPrDQPuLYa; // 0xB0
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private static Func<InputLayout, IList<InputLayout>, int> tSKGafZuKoIXTDeAAVPnAoQePwV; // 0xB8
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private static Func<CustomController_Editor, int> FZcmyHrDsuLjiyBtuCiNFKLXWUT; // 0xC0
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private static Func<CustomController_Editor, string> gEVjltbvyTAySXMKFdlALQXkxIt; // 0xC8
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private static Func<CustomController_Editor, IList<CustomController_Editor>, int> RGwPVSQvadoFTsnuvZevEuBxqFv; // 0xD0
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private static Func<ControllerMapLayoutManager_RuleSet_Editor, int> kRzBuYuqDNRQAQzYTiKTRFUIlZR; // 0xD8
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private static Func<ControllerMapLayoutManager_RuleSet_Editor, string> YTDXselRzZVpizoVfBKjpYprnCc; // 0xE0
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private static Func<ControllerMapLayoutManager_RuleSet_Editor, IList<ControllerMapLayoutManager_RuleSet_Editor>, int> SRbLgqyjjCjVwyrwdgNpkcrjcSP; // 0xE8
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private static Func<ControllerMapEnabler_RuleSet_Editor, int> dGYlXMbdRTeMjDLVfLEJiaHAsUI; // 0xF0
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private static Func<ControllerMapEnabler_RuleSet_Editor, string> QyCbyENQJfXYbSiakrjLwQOnaWM; // 0xF8
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private static Func<ControllerMapEnabler_RuleSet_Editor, IList<ControllerMapEnabler_RuleSet_Editor>, int> QtuLwmrOMSNcLkBgWPMWjFpLszk; // 0x100
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private static Func<Player_Editor, int> ecgKKQybZWObvBjpbuhsQTyZnoG; // 0x108
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private static Func<Player_Editor, string> IxtywraAPUsGMBLtQsnfYzHymoF; // 0x110
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private static Func<Player_Editor, IList<Player_Editor>, int> CDXCKdkFyxMCCMhfYOnLgtYbVjcq; // 0x118
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private static Func<ControllerMap_Editor, int> vNvdrbCpbGxTrrulJVHEWcXqJtN; // 0x120
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private static Func<ControllerMap_Editor, string> VrbOpyZQdttjgAvvlUodzJUhLFX; // 0x128
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private static Func<ControllerMap_Editor, int> yNVTLfGiNLnrqceBSpszOVmPVrG; // 0x130
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private static Func<ControllerMap_Editor, string> MPvAxpRWkfFuERNHziwFwpQENdd; // 0x138
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private static Func<ControllerMap_Editor, int> iIGWvIbbErcCFspJPUggLMIOBYw; // 0x140
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private static Func<ControllerMap_Editor, string> tffUcbUNzgFQNSfQgNHZfyVJgiX; // 0x148
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private static Func<ControllerMap_Editor, int> QOJFlcAFsROycgkeJtRJqkcjpeRd; // 0x150
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private static Func<ControllerMap_Editor, string> KqdaWZWcOUmfENkUFKHZvzBkOHd; // 0x158
	
			// Nested types
			private class VpSQVhBuRqMlVCljYcqGAAdLguwf // TypeDefIndex: 6266
			{
				// Fields
				public int HNkDvSswkPQiCrSurnrdqybBpqj; // 0x10
				public int LTJNRAnEUfguHllYvFbaCElxLLFg; // 0x14
				public int aYAkGUiBrXgoYHThwtuyoFzShNal; // 0x18
	
				// Properties
				public int MWiOWGzUiqOkOMPKltvfuPDthis[mlVILKSMHUGlaxcXAfhLVeXJpju type] { get => default; set {} } // 0x00000001804076D0-0x0000000180407760 0x0000000180407760-0x0000000180407850
	
				// Nested types
				public enum mlVILKSMHUGlaxcXAfhLVeXJpju // TypeDefIndex: 6267
				{
					HNkDvSswkPQiCrSurnrdqybBpqj = 0,
					LTJNRAnEUfguHllYvFbaCElxLLFg = 1,
					aYAkGUiBrXgoYHThwtuyoFzShNal = 2
				}
	
				// Constructors
				public VpSQVhBuRqMlVCljYcqGAAdLguwf(int origId, int otherId, int finalId); // 0x0000000180407680-0x00000001804076D0
	
				// Methods
				public override string ToString(); // 0x0000000180407570-0x0000000180407680
			}
	
			private class YRmApjTmdXkDTXCkjsOjOfxSocI<T> // TypeDefIndex: 6268
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
	
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private sealed class olOemTamcYhQZcxSjzzljaXoAbGj // TypeDefIndex: 6269
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
				private sealed class IqddvcofkysNhxmYCAzhtYKKQZX // TypeDefIndex: 6270
				{
					// Fields
					public olOemTamcYhQZcxSjzzljaXoAbGj yxXrtTrHsgjCkIDOrignAwTmuxIg; // 0x10
					public YRmApjTmdXkDTXCkjsOjOfxSocI<InputAction> oMbAJnmIYmkoCgCmPFbtJMvsADOr; // 0x18
	
					// Constructors
					public IqddvcofkysNhxmYCAzhtYKKQZX(); // 0x000000018036B6C0-0x000000018036B6D0
	
					// Methods
					public bool HBkHTzDnWJJXfWWbkkkkWGpManL(VpSQVhBuRqMlVCljYcqGAAdLguwf param_0000d24b); // 0x0000000180403950-0x00000001804039C0
					public bool otwPSFlgWmTrjdeTjbWPTQieETOF(VpSQVhBuRqMlVCljYcqGAAdLguwf param_0000d24c); // 0x00000001804039C0-0x0000000180403A30
				}
	
				private sealed class dFVvnquOSsvjXZqOapPKnVwKrZT // TypeDefIndex: 6271
				{
					// Fields
					public YRmApjTmdXkDTXCkjsOjOfxSocI<ControllerMapLayoutManager_RuleSet_Editor> oMbAJnmIYmkoCgCmPFbtJMvsADOr; // 0x10
	
					// Constructors
					public dFVvnquOSsvjXZqOapPKnVwKrZT(); // 0x000000018036B6C0-0x000000018036B6D0
				}
	
				private sealed class ZZEZxJymTclupTNRcWgMbveiDWG // TypeDefIndex: 6272
				{
					// Fields
					public dFVvnquOSsvjXZqOapPKnVwKrZT BMwiGkLSoQeQEwEGlVQEiXXYljZ; // 0x10
					public olOemTamcYhQZcxSjzzljaXoAbGj yxXrtTrHsgjCkIDOrignAwTmuxIg; // 0x18
					public int YNCESWXMGJsyPKcvPaTAiIdkvey; // 0x20
	
					// Constructors
					public ZZEZxJymTclupTNRcWgMbveiDWG(); // 0x000000018036B6C0-0x000000018036B6D0
	
					// Methods
					public bool YCxQeQhCfPuoufXSMGIMCjNYTrU(VpSQVhBuRqMlVCljYcqGAAdLguwf param_0000d24d); // 0x00000001803ED9E0-0x00000001803EDA40
				}
	
				private sealed class AceGJisrZssVeWcjsQhBvtDYVUo // TypeDefIndex: 6273
				{
					// Fields
					public dFVvnquOSsvjXZqOapPKnVwKrZT BMwiGkLSoQeQEwEGlVQEiXXYljZ; // 0x10
					public olOemTamcYhQZcxSjzzljaXoAbGj yxXrtTrHsgjCkIDOrignAwTmuxIg; // 0x18
					public int YNCESWXMGJsyPKcvPaTAiIdkvey; // 0x20
	
					// Constructors
					public AceGJisrZssVeWcjsQhBvtDYVUo(); // 0x000000018036B6C0-0x000000018036B6D0
	
					// Methods
					public bool gGkPpnSoSmzKuCYnrveRobucXpA(VpSQVhBuRqMlVCljYcqGAAdLguwf param_0000d24e); // 0x00000001803ED9E0-0x00000001803EDA40
				}
	
				private sealed class KPSnzKNGoirZoFyQpSjzNZIbUgC // TypeDefIndex: 6274
				{
					// Fields
					public dFVvnquOSsvjXZqOapPKnVwKrZT BMwiGkLSoQeQEwEGlVQEiXXYljZ; // 0x10
					public olOemTamcYhQZcxSjzzljaXoAbGj yxXrtTrHsgjCkIDOrignAwTmuxIg; // 0x18
					public int YNCESWXMGJsyPKcvPaTAiIdkvey; // 0x20
	
					// Constructors
					public KPSnzKNGoirZoFyQpSjzNZIbUgC(); // 0x000000018036B6C0-0x000000018036B6D0
	
					// Methods
					public bool BRYsHfKfFTkghViKtseNpweKoMU(VpSQVhBuRqMlVCljYcqGAAdLguwf param_0000d24f); // 0x00000001803ED9E0-0x00000001803EDA40
				}
	
				private sealed class lYdgaoEjdcEqCOTwzBJwdEiJrpBF // TypeDefIndex: 6275
				{
					// Fields
					public YRmApjTmdXkDTXCkjsOjOfxSocI<ControllerMapEnabler_RuleSet_Editor> oMbAJnmIYmkoCgCmPFbtJMvsADOr; // 0x10
	
					// Constructors
					public lYdgaoEjdcEqCOTwzBJwdEiJrpBF(); // 0x000000018036B6C0-0x000000018036B6D0
				}
	
				private sealed class rnuLsNSGOZnlmiaAkRoqSFyHqJm // TypeDefIndex: 6276
				{
					// Fields
					public lYdgaoEjdcEqCOTwzBJwdEiJrpBF nalbcofEDzZkZHGFPoQNfOPXdXg; // 0x10
					public olOemTamcYhQZcxSjzzljaXoAbGj yxXrtTrHsgjCkIDOrignAwTmuxIg; // 0x18
					public int YNCESWXMGJsyPKcvPaTAiIdkvey; // 0x20
	
					// Constructors
					public rnuLsNSGOZnlmiaAkRoqSFyHqJm(); // 0x000000018036B6C0-0x000000018036B6D0
	
					// Methods
					public bool UCOOhMGFqoRBCafLJFkKcqPjAJfo(VpSQVhBuRqMlVCljYcqGAAdLguwf param_0000d250); // 0x00000001803ED9E0-0x00000001803EDA40
				}
	
				private sealed class EMRoEGtvBimkfJTaWRRHcTDNrCR // TypeDefIndex: 6277
				{
					// Fields
					public lYdgaoEjdcEqCOTwzBJwdEiJrpBF nalbcofEDzZkZHGFPoQNfOPXdXg; // 0x10
					public olOemTamcYhQZcxSjzzljaXoAbGj yxXrtTrHsgjCkIDOrignAwTmuxIg; // 0x18
					public int YNCESWXMGJsyPKcvPaTAiIdkvey; // 0x20
	
					// Constructors
					public EMRoEGtvBimkfJTaWRRHcTDNrCR(); // 0x000000018036B6C0-0x000000018036B6D0
	
					// Methods
					public bool pfYaMZyzlycoXubBqcbsTqSxMrK(VpSQVhBuRqMlVCljYcqGAAdLguwf param_0000d251); // 0x00000001803ED9E0-0x00000001803EDA40
				}
	
				private sealed class KayUbiEdcsvkwjtmlRaASfZRnuW // TypeDefIndex: 6278
				{
					// Fields
					public lYdgaoEjdcEqCOTwzBJwdEiJrpBF nalbcofEDzZkZHGFPoQNfOPXdXg; // 0x10
					public olOemTamcYhQZcxSjzzljaXoAbGj yxXrtTrHsgjCkIDOrignAwTmuxIg; // 0x18
					public int YNCESWXMGJsyPKcvPaTAiIdkvey; // 0x20
	
					// Constructors
					public KayUbiEdcsvkwjtmlRaASfZRnuW(); // 0x000000018036B6C0-0x000000018036B6D0
	
					// Methods
					public bool KNcaPutFCLMriFyLkaMmuYZhTKN(VpSQVhBuRqMlVCljYcqGAAdLguwf param_0000d252); // 0x00000001803ED9E0-0x00000001803EDA40
				}
	
				private sealed class UAEudbjGiMWCKtlxDbcpCYqZxyd // TypeDefIndex: 6279
				{
					// Fields
					public olOemTamcYhQZcxSjzzljaXoAbGj yxXrtTrHsgjCkIDOrignAwTmuxIg; // 0x10
					public YRmApjTmdXkDTXCkjsOjOfxSocI<Player_Editor> oMbAJnmIYmkoCgCmPFbtJMvsADOr; // 0x18
	
					// Nested types
					private sealed class rFWRPKDREPPhLysEDPtDTEIcyZt // TypeDefIndex: 6280
					{
						// Fields
						public UAEudbjGiMWCKtlxDbcpCYqZxyd ldLuojiYliHEBreTEFFUFEPzxkrQ; // 0x10
						public olOemTamcYhQZcxSjzzljaXoAbGj yxXrtTrHsgjCkIDOrignAwTmuxIg; // 0x18
						public Player_Editor.Mapping uZTykRibHjgKjWfZMZoXnLbwkRp; // 0x20
	
						// Constructors
						public rFWRPKDREPPhLysEDPtDTEIcyZt(); // 0x000000018036B6C0-0x000000018036B6D0
	
						// Methods
						public bool iFDQnVqOWSzQYPQpuJOlJGOhCEU(VpSQVhBuRqMlVCljYcqGAAdLguwf param_0000d255); // 0x0000000180412690-0x0000000180412700
						public bool MYDrHOCwkUwMHzDwRGFbXQNkRvH(VpSQVhBuRqMlVCljYcqGAAdLguwf param_0000d256); // 0x0000000180412620-0x0000000180412690
					}
	
					// Constructors
					public UAEudbjGiMWCKtlxDbcpCYqZxyd(); // 0x000000018036B6C0-0x000000018036B6D0
	
					// Methods
					public void HXJqdsgVqChvdvFIzalXQywQFaE(List<Player_Editor.Mapping> param_0000d253, List<VpSQVhBuRqMlVCljYcqGAAdLguwf> param_0000d254); // 0x0000000180407000-0x0000000180407240
				}
	
				private sealed class uJjgPZRjOBbhPhKLksXmFcdxhHov // TypeDefIndex: 6281
				{
					// Fields
					public UAEudbjGiMWCKtlxDbcpCYqZxyd ldLuojiYliHEBreTEFFUFEPzxkrQ; // 0x10
					public olOemTamcYhQZcxSjzzljaXoAbGj yxXrtTrHsgjCkIDOrignAwTmuxIg; // 0x18
					public Player_Editor.CreateControllerInfo INvimzVaioFjwNQRVBRIVLeIhgc; // 0x20
	
					// Constructors
					public uJjgPZRjOBbhPhKLksXmFcdxhHov(); // 0x000000018036B6C0-0x000000018036B6D0
	
					// Methods
					public bool MZtChwyVDIbzYPSdgENqyZZVswy(VpSQVhBuRqMlVCljYcqGAAdLguwf param_0000d257); // 0x00000001804132F0-0x0000000180413360
				}
	
				private sealed class PbchcdhiVpLXvrNDrZJvIAzYAQsC // TypeDefIndex: 6282
				{
					// Fields
					public UAEudbjGiMWCKtlxDbcpCYqZxyd ldLuojiYliHEBreTEFFUFEPzxkrQ; // 0x10
					public olOemTamcYhQZcxSjzzljaXoAbGj yxXrtTrHsgjCkIDOrignAwTmuxIg; // 0x18
					public int nowyFwjWnwrGQsPrcpSlPNkfVZu; // 0x20
	
					// Constructors
					public PbchcdhiVpLXvrNDrZJvIAzYAQsC(); // 0x000000018036B6C0-0x000000018036B6D0
	
					// Methods
					public bool NlVoIengdPswCMJkizDOuUUlJhR(VpSQVhBuRqMlVCljYcqGAAdLguwf param_0000d258); // 0x00000001804063E0-0x0000000180406440
				}
	
				private sealed class dXiDPvgBLVhkoebKgTGICTJyLyyY // TypeDefIndex: 6283
				{
					// Fields
					public UAEudbjGiMWCKtlxDbcpCYqZxyd ldLuojiYliHEBreTEFFUFEPzxkrQ; // 0x10
					public olOemTamcYhQZcxSjzzljaXoAbGj yxXrtTrHsgjCkIDOrignAwTmuxIg; // 0x18
					public int nowyFwjWnwrGQsPrcpSlPNkfVZu; // 0x20
	
					// Constructors
					public dXiDPvgBLVhkoebKgTGICTJyLyyY(); // 0x000000018036B6C0-0x000000018036B6D0
	
					// Methods
					public bool wfngJGwJLUWqqQRdDHpeLvYRrTb(VpSQVhBuRqMlVCljYcqGAAdLguwf param_0000d259); // 0x00000001804063E0-0x0000000180406440
				}
	
				// Constructors
				public olOemTamcYhQZcxSjzzljaXoAbGj(); // 0x000000018036B6C0-0x000000018036B6D0
	
				// Methods
				public InputCategory LCbhhFvChDTzFtWCgdmIrpRCauN(YRmApjTmdXkDTXCkjsOjOfxSocI<InputCategory> param_0000d23b); // 0x000000018040ED10-0x000000018040F090
				public InputBehavior BhxvUSlIgyhjwBCgbUqCVnPboWe(YRmApjTmdXkDTXCkjsOjOfxSocI<InputBehavior> param_0000d23c); // 0x000000018040D930-0x000000018040DCB0
				public InputAction MpIbJzZwkdHaXAnBOtQumdGiEFA(YRmApjTmdXkDTXCkjsOjOfxSocI<InputAction> param_0000d23d); // 0x000000018040F230-0x000000018040F7D0
				public InputLayout YMmSyMvcEbpSbVwrHMlhZoilfdpJ(YRmApjTmdXkDTXCkjsOjOfxSocI<InputLayout> param_0000d23e); // 0x000000018040FC70-0x000000018040FE30
				public InputLayout emggLpqwKzcgkgslYKfIKOBYNUNQ(YRmApjTmdXkDTXCkjsOjOfxSocI<InputLayout> param_0000d23f); // 0x0000000180410180-0x0000000180410320
				public InputLayout MiVmDibPDFzAUBjzWEEDJGVMvrVA(YRmApjTmdXkDTXCkjsOjOfxSocI<InputLayout> param_0000d240); // 0x000000018040F090-0x000000018040F230
				public InputLayout WKokUMhUUzbtYUrOgAQhZZdSKqw(YRmApjTmdXkDTXCkjsOjOfxSocI<InputLayout> param_0000d241); // 0x000000018040FA00-0x000000018040FBC0
				public List<VpSQVhBuRqMlVCljYcqGAAdLguwf> XeXQcfFKuaOiRlCKjIBfGucnAdt(ControllerType param_0000d242); // 0x000000018040FBC0-0x000000018040FC70
				public CustomController_Editor csrDpYHdOYchKdltMhijukGZYeG(YRmApjTmdXkDTXCkjsOjOfxSocI<CustomController_Editor> param_0000d243); // 0x000000018040FE30-0x0000000180410180
				public ControllerMapLayoutManager_RuleSet_Editor FmCwUSHsXZlBBHicmtwEOVOGkvV(YRmApjTmdXkDTXCkjsOjOfxSocI<ControllerMapLayoutManager_RuleSet_Editor> param_0000d244); // 0x000000018040DCB0-0x000000018040ED10
				public ControllerMapEnabler_RuleSet_Editor xvsoxOlQZQOonvOYmgYZaUtwSeT(YRmApjTmdXkDTXCkjsOjOfxSocI<ControllerMapEnabler_RuleSet_Editor> param_0000d245); // 0x00000001804115B0-0x0000000180412620
				public Player_Editor mENFQmcTjdGOUGnSjzqpkFlVncdk(YRmApjTmdXkDTXCkjsOjOfxSocI<Player_Editor> param_0000d246); // 0x0000000180410320-0x0000000180411450
				private static int PcflUYnlRxZHdgOQCCQQDpYFbMk(Player_Editor.Mapping param_0000d247, IList<Player_Editor.Mapping> param_0000d248); // 0x000000018040F7D0-0x000000018040FA00
				private static int ugpRQtYzhZSDzcPoibZmiAkeKaLE(Player_Editor.CreateControllerInfo param_0000d249, IList<Player_Editor.CreateControllerInfo> param_0000d24a); // 0x0000000180411450-0x00000001804115B0
			}
	
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private sealed class iBfWjotGUGkMPfZzmsDwKAmrFgw // TypeDefIndex: 6284
			{
				// Fields
				public olOemTamcYhQZcxSjzzljaXoAbGj yxXrtTrHsgjCkIDOrignAwTmuxIg; // 0x10
				public List<int> NmaxUNjSicrYDbfoZajaqMKzYDv; // 0x18
	
				// Constructors
				public iBfWjotGUGkMPfZzmsDwKAmrFgw(); // 0x000000018036B6C0-0x000000018036B6D0
	
				// Methods
				public InputMapCategory zHWxvltlZdMszLpFFvufQQTYaKb(YRmApjTmdXkDTXCkjsOjOfxSocI<InputMapCategory> param_0000d25a); // 0x000000018040B6E0-0x000000018040B9B0
			}
	
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private sealed class nrazoPTdsPXaDHvzKhMDYIfgoEz // TypeDefIndex: 6285
			{
				// Fields
				public iBfWjotGUGkMPfZzmsDwKAmrFgw GssoFubpNhkymxuGNhjcSWTtqsG; // 0x10
				public olOemTamcYhQZcxSjzzljaXoAbGj yxXrtTrHsgjCkIDOrignAwTmuxIg; // 0x18
				public int LTJNRAnEUfguHllYvFbaCElxLLFg; // 0x20
	
				// Constructors
				public nrazoPTdsPXaDHvzKhMDYIfgoEz(); // 0x000000018036B6C0-0x000000018036B6D0
	
				// Methods
				public bool RaQvEOvJakNCAoaAAUgkBscNaxd(VpSQVhBuRqMlVCljYcqGAAdLguwf param_0000d25b); // 0x000000018040D910-0x000000018040D930
			}
	
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private sealed class yMbLSeMKklCNPgOHqIIcfCeCWpK // TypeDefIndex: 6286
			{
				// Fields
				public olOemTamcYhQZcxSjzzljaXoAbGj yxXrtTrHsgjCkIDOrignAwTmuxIg; // 0x10
				public List<VpSQVhBuRqMlVCljYcqGAAdLguwf> GuEPzbzIYocYqPLtLfURFgXEZBi; // 0x18
				private static Func<ActionElementMap, IList<ActionElementMap>, int> mhZTsuhAQCfKJwvodgRIhFFqOVN; // 0x00
	
				// Nested types
				private sealed class dpMDEdqnyDZymeqidXggSIejkjw // TypeDefIndex: 6287
				{
					// Fields
					public yMbLSeMKklCNPgOHqIIcfCeCWpK qRFbbMGakdsMyoVnwWixmQUiEZNY; // 0x10
					public olOemTamcYhQZcxSjzzljaXoAbGj yxXrtTrHsgjCkIDOrignAwTmuxIg; // 0x18
					public ControllerMap_Editor INvimzVaioFjwNQRVBRIVLeIhgc; // 0x20
	
					// Constructors
					public dpMDEdqnyDZymeqidXggSIejkjw(); // 0x000000018036B6C0-0x000000018036B6D0
	
					// Methods
					public bool gNigBBXoUuAeGxnfoXhTRwDLLVc(VpSQVhBuRqMlVCljYcqGAAdLguwf param_0000d261); // 0x0000000180404940-0x0000000180404970
					public bool YiZtliDnccuCMPJvtWcpqgjOhmQ(VpSQVhBuRqMlVCljYcqGAAdLguwf param_0000d262); // 0x0000000180404910-0x0000000180404940
				}
	
				private sealed class IyQpnePtYJMWqZBwrxlafIDcSi // TypeDefIndex: 6288
				{
					// Fields
					public yMbLSeMKklCNPgOHqIIcfCeCWpK qRFbbMGakdsMyoVnwWixmQUiEZNY; // 0x10
					public olOemTamcYhQZcxSjzzljaXoAbGj yxXrtTrHsgjCkIDOrignAwTmuxIg; // 0x18
					public ControllerMap_Editor zogGTGVlKMWUAlosyoBDOlRrrmp; // 0x20
					public YRmApjTmdXkDTXCkjsOjOfxSocI<ControllerMap_Editor> oMbAJnmIYmkoCgCmPFbtJMvsADOr; // 0x28
	
					// Constructors
					public IyQpnePtYJMWqZBwrxlafIDcSi(); // 0x000000018036B6C0-0x000000018036B6D0
	
					// Methods
					public bool buadbDIDdKLgHXSqynsuDREsPNa(VpSQVhBuRqMlVCljYcqGAAdLguwf param_0000d263); // 0x0000000180402B80-0x0000000180402BE0
					public bool PUOJiwHhrUupNGnbiKFCuVgvgpm(VpSQVhBuRqMlVCljYcqGAAdLguwf param_0000d264); // 0x0000000180402B20-0x0000000180402B80
				}
	
				private sealed class gwxmVnVclCUYEcOcnqCEZjxUAQ // TypeDefIndex: 6289
				{
					// Fields
					public IyQpnePtYJMWqZBwrxlafIDcSi mJkhGYBoOnzvjniRVhNGVfIeDZb; // 0x10
					public yMbLSeMKklCNPgOHqIIcfCeCWpK qRFbbMGakdsMyoVnwWixmQUiEZNY; // 0x18
					public olOemTamcYhQZcxSjzzljaXoAbGj yxXrtTrHsgjCkIDOrignAwTmuxIg; // 0x20
					public ActionElementMap uZTykRibHjgKjWfZMZoXnLbwkRp; // 0x28
	
					// Constructors
					public gwxmVnVclCUYEcOcnqCEZjxUAQ(); // 0x000000018036B6C0-0x000000018036B6D0
	
					// Methods
					public bool ckPKTaeGtpCETBFhZjzhdCGiUZmK(VpSQVhBuRqMlVCljYcqGAAdLguwf param_0000d265); // 0x0000000180406370-0x00000001804063E0
				}
	
				// Constructors
				public yMbLSeMKklCNPgOHqIIcfCeCWpK(); // 0x000000018036B6C0-0x000000018036B6D0
	
				// Methods
				public int XqROlCoYnOBSbZgtwSlpYgELXY(ControllerMap_Editor param_0000d25c, IList<ControllerMap_Editor> param_0000d25d); // 0x0000000180413600-0x00000001804139C0
				public ControllerMap_Editor mprqMBTPSqghwIhofXxiFytrKQP(YRmApjTmdXkDTXCkjsOjOfxSocI<ControllerMap_Editor> param_0000d25e); // 0x00000001804139C0-0x0000000180414320
				private static int SCJdPSnzILOKSPpazgSkWXIxQVW(ActionElementMap param_0000d25f, IList<ActionElementMap> param_0000d260); // 0x0000000180413360-0x0000000180413600
			}
	
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private sealed class IyqvnVTCtVPDWtaxEKtgTjdsMMM // TypeDefIndex: 6290
			{
				// Fields
				public olOemTamcYhQZcxSjzzljaXoAbGj yxXrtTrHsgjCkIDOrignAwTmuxIg; // 0x10
				public List<VpSQVhBuRqMlVCljYcqGAAdLguwf> GuEPzbzIYocYqPLtLfURFgXEZBi; // 0x18
				private static Func<ActionElementMap, IList<ActionElementMap>, int> CeNaTgMaheIARQLdXGnbgpBrMIF; // 0x00
	
				// Nested types
				private sealed class PbfpqrIWsJlKefyFQfEkxWWnanf // TypeDefIndex: 6291
				{
					// Fields
					public IyqvnVTCtVPDWtaxEKtgTjdsMMM MlyAsKgrOKOXZiDmqbxKseBdKiHD; // 0x10
					public olOemTamcYhQZcxSjzzljaXoAbGj yxXrtTrHsgjCkIDOrignAwTmuxIg; // 0x18
					public ControllerMap_Editor INvimzVaioFjwNQRVBRIVLeIhgc; // 0x20
	
					// Constructors
					public PbfpqrIWsJlKefyFQfEkxWWnanf(); // 0x000000018036B6C0-0x000000018036B6D0
	
					// Methods
					public bool arEMArCbMpaluKrwXdNGWhzvecfl(VpSQVhBuRqMlVCljYcqGAAdLguwf param_0000d26b); // 0x0000000180404940-0x0000000180404970
					public bool dfxmGPkDJZaCQglIUPWEGIwUnqnd(VpSQVhBuRqMlVCljYcqGAAdLguwf param_0000d26c); // 0x0000000180404910-0x0000000180404940
				}
	
				private sealed class KGgGPxunFFaNLHjJrttfupsunXM // TypeDefIndex: 6292
				{
					// Fields
					public IyqvnVTCtVPDWtaxEKtgTjdsMMM MlyAsKgrOKOXZiDmqbxKseBdKiHD; // 0x10
					public olOemTamcYhQZcxSjzzljaXoAbGj yxXrtTrHsgjCkIDOrignAwTmuxIg; // 0x18
					public ControllerMap_Editor zogGTGVlKMWUAlosyoBDOlRrrmp; // 0x20
					public YRmApjTmdXkDTXCkjsOjOfxSocI<ControllerMap_Editor> oMbAJnmIYmkoCgCmPFbtJMvsADOr; // 0x28
	
					// Constructors
					public KGgGPxunFFaNLHjJrttfupsunXM(); // 0x000000018036B6C0-0x000000018036B6D0
	
					// Methods
					public bool yfYZjqsrxYQNvFxmIvYvYEtaFQr(VpSQVhBuRqMlVCljYcqGAAdLguwf param_0000d26d); // 0x0000000180402B80-0x0000000180402BE0
					public bool lzXxjVusFrRGFcNOWHyDAmOxIOTG(VpSQVhBuRqMlVCljYcqGAAdLguwf param_0000d26e); // 0x0000000180402B20-0x0000000180402B80
				}
	
				private sealed class PSNLrcivmxRDEdnvcvxoysvndTa // TypeDefIndex: 6293
				{
					// Fields
					public KGgGPxunFFaNLHjJrttfupsunXM YTshKjeubgeeTNcSviSmRozCpaP; // 0x10
					public IyqvnVTCtVPDWtaxEKtgTjdsMMM MlyAsKgrOKOXZiDmqbxKseBdKiHD; // 0x18
					public olOemTamcYhQZcxSjzzljaXoAbGj yxXrtTrHsgjCkIDOrignAwTmuxIg; // 0x20
					public ActionElementMap uZTykRibHjgKjWfZMZoXnLbwkRp; // 0x28
	
					// Constructors
					public PSNLrcivmxRDEdnvcvxoysvndTa(); // 0x000000018036B6C0-0x000000018036B6D0
	
					// Methods
					public bool mWnMdkpiJTvNCaaixkCzoqnBeRcB(VpSQVhBuRqMlVCljYcqGAAdLguwf param_0000d26f); // 0x0000000180406370-0x00000001804063E0
				}
	
				// Constructors
				public IyqvnVTCtVPDWtaxEKtgTjdsMMM(); // 0x000000018036B6C0-0x000000018036B6D0
	
				// Methods
				public int DJWNFOVjLVvCnemrvIRvsykXulb(ControllerMap_Editor param_0000d266, IList<ControllerMap_Editor> param_0000d267); // 0x0000000180403A30-0x0000000180403E00
				public ControllerMap_Editor JNLqTPkhXPQgsuGanUuSNAiPgMt(YRmApjTmdXkDTXCkjsOjOfxSocI<ControllerMap_Editor> param_0000d268); // 0x0000000180403E00-0x00000001804046E0
				private static int VxQNDGohLwSQERZWtTmmsgOBRlp(ActionElementMap param_0000d269, IList<ActionElementMap> param_0000d26a); // 0x00000001804046E0-0x00000001804048E0
			}
	
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private sealed class OlhNGrsJzHYzWWxiucCXKkLOtos // TypeDefIndex: 6294
			{
				// Fields
				public olOemTamcYhQZcxSjzzljaXoAbGj yxXrtTrHsgjCkIDOrignAwTmuxIg; // 0x10
				public List<VpSQVhBuRqMlVCljYcqGAAdLguwf> GuEPzbzIYocYqPLtLfURFgXEZBi; // 0x18
				private static Func<ActionElementMap, IList<ActionElementMap>, int> TiMslrQGsxDbTyQWpehOaHepasdB; // 0x00
	
				// Nested types
				private sealed class ijkKxvOrzNMKUnNCXjDWgGeDhoZB // TypeDefIndex: 6295
				{
					// Fields
					public OlhNGrsJzHYzWWxiucCXKkLOtos nVKqncEjZnPKDynFFVuzdddWOoC; // 0x10
					public olOemTamcYhQZcxSjzzljaXoAbGj yxXrtTrHsgjCkIDOrignAwTmuxIg; // 0x18
					public ControllerMap_Editor INvimzVaioFjwNQRVBRIVLeIhgc; // 0x20
	
					// Constructors
					public ijkKxvOrzNMKUnNCXjDWgGeDhoZB(); // 0x000000018036B6C0-0x000000018036B6D0
	
					// Methods
					public bool DMCGyHTXZKTscyQsRBBrZJJHcKig(VpSQVhBuRqMlVCljYcqGAAdLguwf param_0000d275); // 0x0000000180404940-0x0000000180404970
					public bool ryJMifpFjVigprNzBzcjMekPdJe(VpSQVhBuRqMlVCljYcqGAAdLguwf param_0000d276); // 0x0000000180404910-0x0000000180404940
				}
	
				private sealed class EmElBcoqzADZpVLsHzeUGUPeUiz // TypeDefIndex: 6296
				{
					// Fields
					public OlhNGrsJzHYzWWxiucCXKkLOtos nVKqncEjZnPKDynFFVuzdddWOoC; // 0x10
					public olOemTamcYhQZcxSjzzljaXoAbGj yxXrtTrHsgjCkIDOrignAwTmuxIg; // 0x18
					public ControllerMap_Editor zogGTGVlKMWUAlosyoBDOlRrrmp; // 0x20
					public YRmApjTmdXkDTXCkjsOjOfxSocI<ControllerMap_Editor> oMbAJnmIYmkoCgCmPFbtJMvsADOr; // 0x28
	
					// Constructors
					public EmElBcoqzADZpVLsHzeUGUPeUiz(); // 0x000000018036B6C0-0x000000018036B6D0
	
					// Methods
					public bool oyPQbFSKvaFNmeFrLyHbOqMeoFs(VpSQVhBuRqMlVCljYcqGAAdLguwf param_0000d277); // 0x0000000180402B80-0x0000000180402BE0
					public bool NepprnIlOHWzWuEWDMuXZuiTiH(VpSQVhBuRqMlVCljYcqGAAdLguwf param_0000d278); // 0x0000000180402B20-0x0000000180402B80
				}
	
				private sealed class ePSxekSPEcrVouCccDAmbfBEgaPR // TypeDefIndex: 6297
				{
					// Fields
					public EmElBcoqzADZpVLsHzeUGUPeUiz ojczbPabEhZpwcJTUdxBhrjeUJG; // 0x10
					public OlhNGrsJzHYzWWxiucCXKkLOtos nVKqncEjZnPKDynFFVuzdddWOoC; // 0x18
					public olOemTamcYhQZcxSjzzljaXoAbGj yxXrtTrHsgjCkIDOrignAwTmuxIg; // 0x20
					public ActionElementMap uZTykRibHjgKjWfZMZoXnLbwkRp; // 0x28
	
					// Constructors
					public ePSxekSPEcrVouCccDAmbfBEgaPR(); // 0x000000018036B6C0-0x000000018036B6D0
	
					// Methods
					public bool QiQCjyRzqsKrSbVtqfpYkYCwDsW(VpSQVhBuRqMlVCljYcqGAAdLguwf param_0000d279); // 0x0000000180406370-0x00000001804063E0
				}
	
				// Constructors
				public OlhNGrsJzHYzWWxiucCXKkLOtos(); // 0x000000018036B6C0-0x000000018036B6D0
	
				// Methods
				public int DbLcoixJXCihcKmCtFGfaaocrZPa(ControllerMap_Editor param_0000d270, IList<ControllerMap_Editor> param_0000d271); // 0x0000000180404970-0x0000000180404DA0
				public ControllerMap_Editor VAhAVdKAPicwZBbnYyQoerVLaraP(YRmApjTmdXkDTXCkjsOjOfxSocI<ControllerMap_Editor> param_0000d272); // 0x0000000180404DA0-0x0000000180405790
				private static int wnWQXvcpZFaiqYkjqARbjKrHpAzQ(ActionElementMap param_0000d273, IList<ActionElementMap> param_0000d274); // 0x0000000180405790-0x0000000180405AF0
			}
	
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private sealed class iizkHuQzeqPnmLDVoDpmRfMcjMP // TypeDefIndex: 6298
			{
				// Fields
				public olOemTamcYhQZcxSjzzljaXoAbGj yxXrtTrHsgjCkIDOrignAwTmuxIg; // 0x10
				public List<VpSQVhBuRqMlVCljYcqGAAdLguwf> GuEPzbzIYocYqPLtLfURFgXEZBi; // 0x18
				private static Func<ActionElementMap, IList<ActionElementMap>, int> QslbpqntEjHuMfAcyHyoPtoGKbz; // 0x00
	
				// Nested types
				private sealed class LOFcVnBcvXoMHepKIfFOSIZAMOUv // TypeDefIndex: 6299
				{
					// Fields
					public iizkHuQzeqPnmLDVoDpmRfMcjMP LMZcOeFRgHZcQJYfFxdWqNZSosHA; // 0x10
					public olOemTamcYhQZcxSjzzljaXoAbGj yxXrtTrHsgjCkIDOrignAwTmuxIg; // 0x18
					public ControllerMap_Editor INvimzVaioFjwNQRVBRIVLeIhgc; // 0x20
	
					// Constructors
					public LOFcVnBcvXoMHepKIfFOSIZAMOUv(); // 0x000000018036B6C0-0x000000018036B6D0
	
					// Methods
					public bool GtNOYVQAoHwhtZPADnLXjYBxslk(VpSQVhBuRqMlVCljYcqGAAdLguwf param_0000d27f); // 0x00000001804048E0-0x0000000180404910
					public bool diIeivsTReztMHMMHmoBtrXTTQp(VpSQVhBuRqMlVCljYcqGAAdLguwf param_0000d280); // 0x0000000180404940-0x0000000180404970
					public bool YGTkAicCGHYrbMAuhiSAZASJlsd(VpSQVhBuRqMlVCljYcqGAAdLguwf param_0000d281); // 0x0000000180404910-0x0000000180404940
				}
	
				private sealed class auTergtFGNsJOOfmqHKiptULtY // TypeDefIndex: 6300
				{
					// Fields
					public iizkHuQzeqPnmLDVoDpmRfMcjMP LMZcOeFRgHZcQJYfFxdWqNZSosHA; // 0x10
					public olOemTamcYhQZcxSjzzljaXoAbGj yxXrtTrHsgjCkIDOrignAwTmuxIg; // 0x18
					public ControllerMap_Editor zogGTGVlKMWUAlosyoBDOlRrrmp; // 0x20
					public YRmApjTmdXkDTXCkjsOjOfxSocI<ControllerMap_Editor> oMbAJnmIYmkoCgCmPFbtJMvsADOr; // 0x28
	
					// Constructors
					public auTergtFGNsJOOfmqHKiptULtY(); // 0x000000018036B6C0-0x000000018036B6D0
	
					// Methods
					public bool PWHDKKpcDrgzsbBKQWHTYGkBPVm(VpSQVhBuRqMlVCljYcqGAAdLguwf param_0000d282); // 0x000000018040AFF0-0x000000018040B050
					public bool FckeTAoFdmktxDSrnSURxYHEKyo(VpSQVhBuRqMlVCljYcqGAAdLguwf param_0000d283); // 0x0000000180402B80-0x0000000180402BE0
					public bool puqGsGONdUunubqNcnPsgNFnOzY(VpSQVhBuRqMlVCljYcqGAAdLguwf param_0000d284); // 0x0000000180402B20-0x0000000180402B80
				}
	
				private sealed class eghAqGfpYxXDPOQjhdWzkXLJtdm // TypeDefIndex: 6301
				{
					// Fields
					public auTergtFGNsJOOfmqHKiptULtY naeBeOlspIKcHEMfcpmyzXzPoRk; // 0x10
					public iizkHuQzeqPnmLDVoDpmRfMcjMP LMZcOeFRgHZcQJYfFxdWqNZSosHA; // 0x18
					public olOemTamcYhQZcxSjzzljaXoAbGj yxXrtTrHsgjCkIDOrignAwTmuxIg; // 0x20
					public ActionElementMap uZTykRibHjgKjWfZMZoXnLbwkRp; // 0x28
	
					// Constructors
					public eghAqGfpYxXDPOQjhdWzkXLJtdm(); // 0x000000018036B6C0-0x000000018036B6D0
	
					// Methods
					public bool SQdgqEZqLrhKWfZvtYdGMfmZjuKe(VpSQVhBuRqMlVCljYcqGAAdLguwf param_0000d285); // 0x0000000180406370-0x00000001804063E0
				}
	
				// Constructors
				public iizkHuQzeqPnmLDVoDpmRfMcjMP(); // 0x000000018036B6C0-0x000000018036B6D0
	
				// Methods
				public int oGldeOCPqsSKiVDPONnIfBYbGZkX(ControllerMap_Editor param_0000d27a, IList<ControllerMap_Editor> param_0000d27b); // 0x000000018040C550-0x000000018040CA80
				public ControllerMap_Editor SxgQOwNPpGHVRRoxJqcNZdlDhyi(YRmApjTmdXkDTXCkjsOjOfxSocI<ControllerMap_Editor> param_0000d27c); // 0x000000018040B9B0-0x000000018040C390
				private static int lcrjNVgxvNBjOMyRRngEdMyqcPxz(ActionElementMap param_0000d27d, IList<ActionElementMap> param_0000d27e); // 0x000000018040C390-0x000000018040C550
			}
	
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private sealed class EAkfIVTxjPjktHVoVrwkUKkfpLN<T> // TypeDefIndex: 6302
				where T : class
			{
				// Fields
				public Func<T, int> QichaXlPbUUzhplAaTyzSeoVkzD;
	
				// Constructors
				public EAkfIVTxjPjktHVoVrwkUKkfpLN();
			}
	
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private sealed class QqwdQiWCUocVYXvBRFIzCLcwLQbS<T> // TypeDefIndex: 6303
				where T : class
			{
				// Fields
				public EAkfIVTxjPjktHVoVrwkUKkfpLN<T> ZuyirqSzDfCjVPHBuPpuDGzdvcf;
				public T zogGTGVlKMWUAlosyoBDOlRrrmp;
	
				// Constructors
				public QqwdQiWCUocVYXvBRFIzCLcwLQbS();
	
				// Methods
				public bool eAwbAvMlXFTPeXNNHmcebDQJRrU(VpSQVhBuRqMlVCljYcqGAAdLguwf param_0000d286);
			}
	
			// Methods
			public static UserData HcoqOerGilrKrieuEKDeVDdkzor(UserData param_0000d1e6, UserData param_0000d1e7, bool param_0000d1e8); // 0x00000001804079C0-0x000000018040A440
			[Conditional] // 0x0000000180130460-0x0000000180130490
			private static void WZAIMFVqvgZMNfZYWwNIyxpdPCj(object param_0000d1e9); // 0x000000018040A780-0x000000018040A7D0
			private static void dWpMQMMHzNHYiZCgywuhGHVVDyke<T>(IList<T> param_0000d1ea, IList<T> param_0000d1eb, IList<T> param_0000d1ec, Func<T, IList<T>, int> param_0000d1ed);
			private static void CloexxVSEilDJARhwhQlAhzNfhT<T>(string param_0000d1ee, IList<T> param_0000d1ef, IList<T> param_0000d1f0, IList<T> param_0000d1f1, bool param_0000d1f2, List<VpSQVhBuRqMlVCljYcqGAAdLguwf> param_0000d1f3, Func<T, int> param_0000d1f4, Func<T, string> param_0000d1f5, Func<T, IList<T>, int> param_0000d1f6, Func<YRmApjTmdXkDTXCkjsOjOfxSocI<T>, T> param_0000d1f7)
				where T : class;
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private static int SAfYHbeuvNZNeZbCOdFeBCiLAeQ(InputCategory param_0000d1f8); // 0x000000018040A740-0x000000018040A760
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private static string bdXtbHMoHieLYnPXRFhvRcnuAjhe(InputCategory param_0000d1f9); // 0x0000000180407850-0x0000000180407870
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private static int rTFqwfZfUeqiIAiMhSujUCqEBAtd(InputCategory param_0000d1fa, IList<InputCategory> param_0000d1fb); // 0x000000018040ACC0-0x000000018040ADC0
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private static int XTeSiohJZYsYPtMIiemkFfduEqvD(InputBehavior param_0000d1fc); // 0x00000001804078B0-0x00000001804078D0
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private static string BsBgEnhcvqpwnNgSfDqbBzxWvcUW(InputBehavior param_0000d1fd); // 0x0000000180407890-0x00000001804078B0
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private static int iaHiWhtGUaqEnFLeZXhErTUBzxM(InputBehavior param_0000d1fe, IList<InputBehavior> param_0000d1ff); // 0x000000018040A9D0-0x000000018040AAC0
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private static int tRqpcuqPhKxOhYKrKRoEZzIzzyJ(InputAction param_0000d200); // 0x00000001804078B0-0x00000001804078D0
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private static string tGdQPDrjIAEFQgbltFxpBtoOQpC(InputAction param_0000d201); // 0x0000000180407890-0x00000001804078B0
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private static int uKPpcNSNYaLzLveWZopamEIhKCx(InputAction param_0000d202, IList<InputAction> param_0000d203); // 0x000000018040AED0-0x000000018040AFF0
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private static int yHxQZSlMMrJcbHmCihfVfxrbpQFQ(InputMapCategory param_0000d204); // 0x000000018040A740-0x000000018040A760
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private static string emDyWdGUlvGRfvAORJvaSLZFcUN(InputMapCategory param_0000d205); // 0x0000000180407850-0x0000000180407870
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private static int JQhhvnBGtqtktmcVDMTLjdbZQAg(InputMapCategory param_0000d206, IList<InputMapCategory> param_0000d207); // 0x000000018040A540-0x000000018040A630
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private static int VXdgHPFazTpMZquADGMwgmRtVfhE(InputLayout param_0000d208); // 0x000000018040A760-0x000000018040A780
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private static string MlUERnTiPIjPxjSbCGDrghGKEdxv(InputLayout param_0000d209); // 0x0000000180407850-0x0000000180407870
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private static int eJMhQqYUAvUgqqmYYLMBduwBgth(InputLayout param_0000d20a, IList<InputLayout> param_0000d20b); // 0x000000018040A8C0-0x000000018040A9D0
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private static int euAffMCIeUmodMVzJRhphHKEramO(InputLayout param_0000d20c); // 0x000000018040A760-0x000000018040A780
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private static string BEoAfvGAptmxFLtRbWYgTjiYqoR(InputLayout param_0000d20d); // 0x0000000180407850-0x0000000180407870
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private static int lMwmoZsVCyjCYJSsmQToZLEdBqL(InputLayout param_0000d20e, IList<InputLayout> param_0000d20f); // 0x000000018040AAC0-0x000000018040ABB0
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private static int yfiGKcbQrqEEPSbWqBorazHKnWGu(InputLayout param_0000d210); // 0x000000018040A760-0x000000018040A780
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private static string MubCqxgGoHCWQsivjuQVgsARYUV(InputLayout param_0000d211); // 0x0000000180407850-0x0000000180407870
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private static int LFcmuTzppSbeoaCBwbznxhnOmofa(InputLayout param_0000d212, IList<InputLayout> param_0000d213); // 0x000000018040A630-0x000000018040A740
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private static int atIflJLbDSyOskjmXzTKfmLgGtC(InputLayout param_0000d214); // 0x000000018040A760-0x000000018040A780
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private static string wpRSgTBPyNCOeaawkBpzkcPLauu(InputLayout param_0000d215); // 0x0000000180407850-0x0000000180407870
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private static int GkRflpuBJlDcSfwpMXliGXcAEESX(InputLayout param_0000d216, IList<InputLayout> param_0000d217); // 0x00000001804078D0-0x00000001804079C0
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private static int bKXGopXlJjkqhLCRVlWiAKaWNdt(CustomController_Editor param_0000d218); // 0x000000018040A760-0x000000018040A780
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private static string bICvtoJIKwEpgOKdgkkyTnvlEMva(CustomController_Editor param_0000d219); // 0x0000000180407850-0x0000000180407870
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private static int njektPnLJdhbCNEFYnhkEBsPjKr(CustomController_Editor param_0000d21a, IList<CustomController_Editor> param_0000d21b); // 0x000000018040ABB0-0x000000018040ACC0
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private static int EXZclYOQzagdXvfuQLxoaMGtryb(ControllerMapLayoutManager_RuleSet_Editor param_0000d21c); // 0x00000001804078B0-0x00000001804078D0
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private static string vvMROVdMyEwjaBLnOxqOkLhtcqo(ControllerMapLayoutManager_RuleSet_Editor param_0000d21d); // 0x0000000180407890-0x00000001804078B0
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private static int sQIdDFeTrqYliiuPFaXrojlXvcl(ControllerMapLayoutManager_RuleSet_Editor param_0000d21e, IList<ControllerMapLayoutManager_RuleSet_Editor> param_0000d21f); // 0x000000018040ADC0-0x000000018040AED0
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private static int UnSiObwrllAlpsfGIuwuTMxGvKr(ControllerMapEnabler_RuleSet_Editor param_0000d220); // 0x00000001804078B0-0x00000001804078D0
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private static string cqbRoxHKUdAoWXBdfXooCBopBlTD(ControllerMapEnabler_RuleSet_Editor param_0000d221); // 0x0000000180407890-0x00000001804078B0
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private static int HoWPzBNNQURNbBVWEjsRIrbGVPm(ControllerMapEnabler_RuleSet_Editor param_0000d222, IList<ControllerMapEnabler_RuleSet_Editor> param_0000d223); // 0x000000018040A440-0x000000018040A540
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private static int tqMJsfvZgAMPHvaZhJmDKhbeYtQ(Player_Editor param_0000d224); // 0x00000001804078B0-0x00000001804078D0
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private static string JbgAAqVDxTffmiDkTmXhcOjgrYTG(Player_Editor param_0000d225); // 0x0000000180407890-0x00000001804078B0
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private static int ZfWiUecxhwkxQivtUwmibuXjhDQJ(Player_Editor param_0000d226, IList<Player_Editor> param_0000d227); // 0x000000018040A7D0-0x000000018040A8C0
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private static int SuHgmwDRkRXKlDKtuqnNayNbJka(ControllerMap_Editor param_0000d228); // 0x00000001804078B0-0x00000001804078D0
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private static string nBRhLpZXKQoINGoSKyjRtyJVhaz(ControllerMap_Editor param_0000d229); // 0x0000000180407870-0x0000000180407890
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private static int OdPfHiGThOCaTiZZwlPPrIMuhzhJ(ControllerMap_Editor param_0000d22a); // 0x00000001804078B0-0x00000001804078D0
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private static string BHgCGcnkiopcIpEnEVQlvDnhSTt(ControllerMap_Editor param_0000d22b); // 0x0000000180407870-0x0000000180407890
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private static int znJegjYoZLoqijtjhDNupIMDImiD(ControllerMap_Editor param_0000d22c); // 0x00000001804078B0-0x00000001804078D0
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private static string XwHbQEErTqGeOHcGfaCdfDrayTEu(ControllerMap_Editor param_0000d22d); // 0x0000000180407870-0x0000000180407890
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private static int vFwlaoUbfBgEKDTuEnCrdkvfqaKl(ControllerMap_Editor param_0000d22e); // 0x00000001804078B0-0x00000001804078D0
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private static string ydBOgMoEIwrXsySdOPJvFAUHHRm(ControllerMap_Editor param_0000d22f); // 0x0000000180407870-0x0000000180407890
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class TCXjEymRXIIBAmpOuWITBxrikwp : IEnumerable<InputMapCategory>, IEnumerator<InputMapCategory> // TypeDefIndex: 6304
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
			InputMapCategory dDiPdxKJBJAagsAlXeBODIkONUR { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018036AC80-0x000000018036AC90 
			object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018036AC80-0x000000018036AC90 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public TCXjEymRXIIBAmpOuWITBxrikwp(int <>1__state); // 0x0000000180406F90-0x0000000180407000
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			IEnumerator<InputMapCategory> IEnumerable<InputMapCategory>.GetEnumerator(); // 0x0000000180406E20-0x0000000180406F40
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			IEnumerator IEnumerable.GetEnumerator(); // 0x0000000180406E20-0x0000000180406F40
			private bool MoveNext(); // 0x0000000180406BF0-0x0000000180406E20
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x0000000180406F40-0x0000000180406F90
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class HggAMhrrEToyVYZErtPBvanhHgt : IEnumerable<InputMapCategory>, IEnumerator<InputMapCategory> // TypeDefIndex: 6305
		{
			// Fields
			private InputMapCategory aSrFEaALHwhGTdXfCdeUqgbwaZGO; // 0x10
			private int eLrUhJFgzEZElCzdKvcrgOLXLvL; // 0x18
			private int RQaeFqcJnaOYpZSBxtfUkVOjfOo; // 0x1C
			public UserData gKPmvKLRxdGbmXiMfUeDjGbezUo; // 0x20
			public int PjYtuicjXGalARRYfcvVGxZVBdI; // 0x28
	
			// Properties
			InputMapCategory dDiPdxKJBJAagsAlXeBODIkONUR { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018036AC80-0x000000018036AC90 
			object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018036AC80-0x000000018036AC90 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public HggAMhrrEToyVYZErtPBvanhHgt(int <>1__state); // 0x0000000180393A20-0x0000000180393A70
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			IEnumerator<InputMapCategory> IEnumerable<InputMapCategory>.GetEnumerator(); // 0x00000001804037F0-0x0000000180403900
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			IEnumerator IEnumerable.GetEnumerator(); // 0x00000001804037F0-0x0000000180403900
			private bool MoveNext(); // 0x0000000180403620-0x00000001804037F0
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x0000000180403900-0x0000000180403950
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class tsMGbVoIHUIJZksZVFBCghjlxdtz : IEnumerable<InputMapCategory>, IEnumerator<InputMapCategory> // TypeDefIndex: 6306
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
			InputMapCategory dDiPdxKJBJAagsAlXeBODIkONUR { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018036AC80-0x000000018036AC90 
			object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018036AC80-0x000000018036AC90 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public tsMGbVoIHUIJZksZVFBCghjlxdtz(int <>1__state); // 0x0000000180393A20-0x0000000180393A70
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			IEnumerator<InputMapCategory> IEnumerable<InputMapCategory>.GetEnumerator(); // 0x0000000180413150-0x00000001804132A0
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			IEnumerator IEnumerable.GetEnumerator(); // 0x0000000180413150-0x00000001804132A0
			private bool MoveNext(); // 0x0000000180412E80-0x0000000180413150
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x00000001804132A0-0x00000001804132F0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class rbJoGYdMMhWRHOgSDmQGBfHidcVc : IEnumerable<InputCategory>, IEnumerator<InputCategory> // TypeDefIndex: 6307
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
			InputCategory YMQQVXUkbpeZKuuVmhbydiBLDcH { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018036AC80-0x000000018036AC90 
			object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018036AC80-0x000000018036AC90 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public rbJoGYdMMhWRHOgSDmQGBfHidcVc(int <>1__state); // 0x0000000180393A20-0x0000000180393A70
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			IEnumerator<InputCategory> IEnumerable<InputCategory>.GetEnumerator(); // 0x0000000180412D30-0x0000000180412E30
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			IEnumerator IEnumerable.GetEnumerator(); // 0x0000000180412D30-0x0000000180412E30
			private bool MoveNext(); // 0x0000000180412AF0-0x0000000180412D30
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x0000000180412E30-0x0000000180412E80
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class FHsYaALijDgklaaXzHwbNnuLMPA : IEnumerable<InputCategory>, IEnumerator<InputCategory> // TypeDefIndex: 6308
		{
			// Fields
			private InputCategory aSrFEaALHwhGTdXfCdeUqgbwaZGO; // 0x10
			private int eLrUhJFgzEZElCzdKvcrgOLXLvL; // 0x18
			private int RQaeFqcJnaOYpZSBxtfUkVOjfOo; // 0x1C
			public UserData gKPmvKLRxdGbmXiMfUeDjGbezUo; // 0x20
			public int jRtDhdAasfdeafpcDrRHOhcxcJfA; // 0x28
	
			// Properties
			InputCategory YMQQVXUkbpeZKuuVmhbydiBLDcH { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018036AC80-0x000000018036AC90 
			object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018036AC80-0x000000018036AC90 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public FHsYaALijDgklaaXzHwbNnuLMPA(int <>1__state); // 0x0000000180393A20-0x0000000180393A70
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			IEnumerator<InputCategory> IEnumerable<InputCategory>.GetEnumerator(); // 0x0000000180403390-0x0000000180403490
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			IEnumerator IEnumerable.GetEnumerator(); // 0x0000000180403390-0x0000000180403490
			private bool MoveNext(); // 0x0000000180403180-0x0000000180403390
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x0000000180403490-0x00000001804034E0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class rWxgzNoBfbuzxgbQIaTIjXKdlgF : IEnumerable<InputCategory>, IEnumerator<InputCategory> // TypeDefIndex: 6309
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
			InputCategory YMQQVXUkbpeZKuuVmhbydiBLDcH { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018036AC80-0x000000018036AC90 
			object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018036AC80-0x000000018036AC90 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public rWxgzNoBfbuzxgbQIaTIjXKdlgF(int <>1__state); // 0x0000000180393A20-0x0000000180393A70
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			IEnumerator<InputCategory> IEnumerable<InputCategory>.GetEnumerator(); // 0x0000000180412960-0x0000000180412AA0
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			IEnumerator IEnumerable.GetEnumerator(); // 0x0000000180412960-0x0000000180412AA0
			private bool MoveNext(); // 0x0000000180412700-0x0000000180412960
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x0000000180412AA0-0x0000000180412AF0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class iqnRDEKHNkujHbXnxqHaAYJPnpK : IEnumerable<InputAction>, IEnumerator<InputAction> // TypeDefIndex: 6310
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
			InputAction bkafzyccRhbzByXCAEYKgbbEmhX { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018036AC80-0x000000018036AC90 
			object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018036AC80-0x000000018036AC90 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public iqnRDEKHNkujHbXnxqHaAYJPnpK(int <>1__state); // 0x0000000180393A20-0x0000000180393A70
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			IEnumerator<InputAction> IEnumerable<InputAction>.GetEnumerator(); // 0x000000018040CC90-0x000000018040CD70
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			IEnumerator IEnumerable.GetEnumerator(); // 0x000000018040CC90-0x000000018040CD70
			private bool MoveNext(); // 0x000000018040CA80-0x000000018040CC90
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x000000018040CD70-0x000000018040CDC0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class PvRWbhaDEoIjMfWnRdrBHValSPn : IEnumerable<InputAction>, IEnumerator<InputAction> // TypeDefIndex: 6311
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
			InputAction bkafzyccRhbzByXCAEYKgbbEmhX { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018036AC80-0x000000018036AC90 
			object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018036AC80-0x000000018036AC90 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public PvRWbhaDEoIjMfWnRdrBHValSPn(int <>1__state); // 0x0000000180393A20-0x0000000180393A70
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			IEnumerator<InputAction> IEnumerable<InputAction>.GetEnumerator(); // 0x0000000180406820-0x0000000180406920
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			IEnumerator IEnumerable.GetEnumerator(); // 0x0000000180406820-0x0000000180406920
			private bool MoveNext(); // 0x0000000180406440-0x0000000180406820
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x0000000180406920-0x0000000180406970
			void IDisposable.Dispose(); // 0x0000000180406970-0x00000001804069E0
			private void VKmDDMOytQLNfriWWOZXtbWjcDj(); // 0x00000001804069E0-0x0000000180406B90
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class BJdYrZbajCBBmfbtijCWpXbUcHTE : IEnumerable<InputAction>, IEnumerator<InputAction> // TypeDefIndex: 6312
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
			InputAction bkafzyccRhbzByXCAEYKgbbEmhX { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018036AC80-0x000000018036AC90 
			object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018036AC80-0x000000018036AC90 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public BJdYrZbajCBBmfbtijCWpXbUcHTE(int <>1__state); // 0x00000001803EE140-0x00000001803EE1B0
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			IEnumerator<InputAction> IEnumerable<InputAction>.GetEnumerator(); // 0x00000001803EDF10-0x00000001803EE040
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			IEnumerator IEnumerable.GetEnumerator(); // 0x00000001803EDF10-0x00000001803EE040
			private bool MoveNext(); // 0x00000001803EDA40-0x00000001803EDF10
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x00000001803EE040-0x00000001803EE090
			void IDisposable.Dispose(); // 0x00000001803EE090-0x00000001803EE140
			private void dtbOvYPynYurhkKfWvWVrRXZTfI(); // 0x00000001803EE1B0-0x00000001803EE200
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class EwVkrrJxEDfxDugnkFDGJvXedJuf : IEnumerable<InputAction>, IEnumerator<InputAction> // TypeDefIndex: 6313
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
			InputAction bkafzyccRhbzByXCAEYKgbbEmhX { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018036AC80-0x000000018036AC90 
			object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018036AC80-0x000000018036AC90 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public EwVkrrJxEDfxDugnkFDGJvXedJuf(int <>1__state); // 0x0000000180403110-0x0000000180403180
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			IEnumerator<InputAction> IEnumerable<InputAction>.GetEnumerator(); // 0x0000000180402FA0-0x00000001804030C0
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			IEnumerator IEnumerable.GetEnumerator(); // 0x0000000180402FA0-0x00000001804030C0
			private bool MoveNext(); // 0x0000000180402BE0-0x0000000180402FA0
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x00000001804030C0-0x0000000180403110
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class BxvhqOFZhIOeOrQfVNUIOsFzSCr : IEnumerable<InputAction>, IEnumerator<InputAction> // TypeDefIndex: 6314
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
			InputAction bkafzyccRhbzByXCAEYKgbbEmhX { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018036AC80-0x000000018036AC90 
			object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018036AC80-0x000000018036AC90 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public BxvhqOFZhIOeOrQfVNUIOsFzSCr(int <>1__state); // 0x00000001803EE910-0x00000001803EE990
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			IEnumerator<InputAction> IEnumerable<InputAction>.GetEnumerator(); // 0x00000001803EE670-0x00000001803EE810
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			IEnumerator IEnumerable.GetEnumerator(); // 0x00000001803EE670-0x00000001803EE810
			private bool MoveNext(); // 0x00000001803EE200-0x00000001803EE670
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x00000001803EE810-0x00000001803EE860
			void IDisposable.Dispose(); // 0x00000001803EE860-0x00000001803EE910
			private void xfYseRgskGwCGumdDZbIcrZKBcL(); // 0x00000001803EE990-0x00000001803EE9E0
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class OxjfYzJXSnLHmLlVxbYndrXeJiel : IEnumerable<InputAction>, IEnumerator<InputAction> // TypeDefIndex: 6315
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
			InputAction bkafzyccRhbzByXCAEYKgbbEmhX { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018036AC80-0x000000018036AC90 
			object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018036AC80-0x000000018036AC90 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public OxjfYzJXSnLHmLlVxbYndrXeJiel(int <>1__state); // 0x0000000180393A20-0x0000000180393A70
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			IEnumerator<InputAction> IEnumerable<InputAction>.GetEnumerator(); // 0x0000000180406190-0x00000001804062B0
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			IEnumerator IEnumerable.GetEnumerator(); // 0x0000000180406190-0x00000001804062B0
			private bool MoveNext(); // 0x0000000180405C00-0x0000000180406190
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x00000001804062B0-0x0000000180406300
			void IDisposable.Dispose(); // 0x0000000180406300-0x0000000180406370
			private void LdBwxgmBwIVVSuoDzUQxUwcsIeG(); // 0x0000000180405AF0-0x0000000180405C00
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class jbXWTFrQRfSNxCldVhXMranTfAh : IEnumerable<string>, IEnumerator<string> // TypeDefIndex: 6316
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
			string AXzUXURUCJLBgmEajMlrzYVHPxg { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018036AC80-0x000000018036AC90 
			object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018036AC80-0x000000018036AC90 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public jbXWTFrQRfSNxCldVhXMranTfAh(int <>1__state); // 0x0000000180393A20-0x0000000180393A70
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			IEnumerator<string> IEnumerable<string>.GetEnumerator(); // 0x000000018040D700-0x000000018040D800
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			IEnumerator IEnumerable.GetEnumerator(); // 0x000000018040D700-0x000000018040D800
			private bool MoveNext(); // 0x000000018040D250-0x000000018040D600
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x000000018040D800-0x000000018040D850
			void IDisposable.Dispose(); // 0x000000018040D850-0x000000018040D910
			private void OOwWpculDngdTAOYoJYCqxpPmPeF(); // 0x000000018040D600-0x000000018040D700
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class jDoydkcCcHgIsdCqZivtCVZkwRH : IEnumerable<string>, IEnumerator<string> // TypeDefIndex: 6317
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
			string AXzUXURUCJLBgmEajMlrzYVHPxg { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018036AC80-0x000000018036AC90 
			object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018036AC80-0x000000018036AC90 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public jDoydkcCcHgIsdCqZivtCVZkwRH(int <>1__state); // 0x0000000180393A20-0x0000000180393A70
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			IEnumerator<string> IEnumerable<string>.GetEnumerator(); // 0x000000018040D000-0x000000018040D100
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			IEnumerator IEnumerable.GetEnumerator(); // 0x000000018040D000-0x000000018040D100
			private bool MoveNext(); // 0x000000018040CDC0-0x000000018040D000
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x000000018040D100-0x000000018040D150
			void IDisposable.Dispose(); // 0x000000018040D150-0x000000018040D200
			private void UrvYJVREDMdIzKRidCoIQbSVcHgB(); // 0x000000018040D200-0x000000018040D250
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class iAkHgICWyLACtjysdpzRpVGWFdgb : IEnumerable<int>, IEnumerator<int> // TypeDefIndex: 6318
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
			int WSBEdAEEtGKxuQineQbAxjcuTLP { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018036CFF0-0x000000018036D000 
			object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018040B590-0x000000018040B5E0 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public iAkHgICWyLACtjysdpzRpVGWFdgb(int <>1__state); // 0x00000001803C0450-0x00000001803C04A0
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			IEnumerator<int> IEnumerable<int>.GetEnumerator(); // 0x000000018040B3F0-0x000000018040B540
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			IEnumerator IEnumerable.GetEnumerator(); // 0x000000018040B3F0-0x000000018040B540
			private bool MoveNext(); // 0x000000018040B050-0x000000018040B3F0
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x000000018040B540-0x000000018040B590
			void IDisposable.Dispose(); // 0x000000018040B5E0-0x000000018040B690
			private void tXGyiPrFPdkRGJudEErptDcCewB(); // 0x000000018040B690-0x000000018040B6E0
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class FYSQkxUAMSsSPoQdTHsasfbMPLt // TypeDefIndex: 6319
		{
			// Fields
			public List<InputLayout> hEdGNgYBAStIzXkIWmUQqcbgBcY; // 0x10
	
			// Nested types
			private sealed class RkpUWBZZwKmQyhAqbKbozTDERPs // TypeDefIndex: 6320
			{
				// Fields
				public FYSQkxUAMSsSPoQdTHsasfbMPLt AQOOvZWlTIuMtIObvsdiYbaEMAh; // 0x10
				public ControllerMap_Editor jMeIpvfjZOxlpswPIuhuwRcOfdO; // 0x18
				public ControllerMap_Editor FgjvfzHcWabyGiXRtsKQNmtuoEKC; // 0x20
	
				// Constructors
				public RkpUWBZZwKmQyhAqbKbozTDERPs(); // 0x000000018036B6C0-0x000000018036B6D0
	
				// Methods
				public bool eFkAkVoWwADrEUvvoGkRHotipBkB(InputLayout param_0000d298); // 0x0000000180406BC0-0x0000000180406BF0
				public bool BjxfmbtTbqBFXbNYUpSKILskcCTH(InputLayout param_0000d299); // 0x0000000180406B90-0x0000000180406BC0
			}
	
			// Constructors
			public FYSQkxUAMSsSPoQdTHsasfbMPLt(); // 0x000000018036B6C0-0x000000018036B6D0
	
			// Methods
			public int barVXeXWOsQkZPnUHkhAiBObptp(ControllerMap_Editor param_0000d296, ControllerMap_Editor param_0000d297); // 0x00000001804034E0-0x0000000180403620
		}
	
		// Constructors
		public UserData(); // 0x00000001803BCF60-0x00000001803BCF70
		private UserData(bool init); // 0x00000001803BC990-0x00000001803BCF60
	
		// Methods
		internal IEnumerable<InputMapCategory> OohvgKceufDiepKaNueZGqjbhOU(string param_0000d06f); // 0x00000001803BB750-0x00000001803BB7D0
		internal IEnumerable<InputMapCategory> svjCqRACHsdRvscTwjZTBegCQLUd(string param_0000d070); // 0x00000001803BE680-0x00000001803BE700
		internal IEnumerable<InputCategory> yNGlNxtOQxMejVsLXMcznQIeSRb(string param_0000d071); // 0x00000001803BFC00-0x00000001803BFC80
		internal IEnumerable<InputCategory> OghwTUagjFJQRYpPnSvyUiDmemQH(string param_0000d072); // 0x00000001803BB580-0x00000001803BB600
		internal IEnumerable<InputAction> vxKpleRbaGncklSJxvtbDBmwtGE(int param_0000d073, bool param_0000d074); // 0x00000001803BE850-0x00000001803BE910
		internal IEnumerable<InputAction> vxKpleRbaGncklSJxvtbDBmwtGE(string param_0000d075, bool param_0000d076); // 0x00000001803BE7C0-0x00000001803BE850
		internal IEnumerable<InputAction> aYQTyvYHUstuHToNIoiVYToxvRx(string param_0000d077); // 0x00000001803BD030-0x00000001803BD0B0
		internal IEnumerable<InputAction> OiDEVfJzUhFqGqlLDOujmdLvcjYc(int param_0000d078, bool param_0000d079); // 0x00000001803BB600-0x00000001803BB6B0
		internal IEnumerable<InputAction> OiDEVfJzUhFqGqlLDOujmdLvcjYc(string param_0000d07a, bool param_0000d07b); // 0x00000001803BB6B0-0x00000001803BB750
		public List<InputAction> GetActions_Copy(); // 0x00000001803ACEB0-0x00000001803ACFD0
		public List<InputBehavior> GetInputBehaviors_Copy(); // 0x00000001803B1060-0x00000001803B1190
		public List<KeyboardMap> GetKeyboardMaps_Copy(); // 0x00000001803B32D0-0x00000001803B3420
		public List<MouseMap> GetMouseMaps_Copy(); // 0x00000001803B58F0-0x00000001803B5A40
		public void AddPlayer(); // 0x00000001803A36F0-0x00000001803A3750
		public void InsertPlayer(int index); // 0x00000001803BA950-0x00000001803BAA40
		public void DeletePlayer(int index); // 0x00000001803A7350-0x00000001803A7410
		public bool ReorderPlayer(int index, bool offsetDown, bool offsetNow); // 0x00000001803BBF20-0x00000001803BBF90
		public void DuplicatePlayer(int index); // 0x00000001803AA870-0x00000001803AAAA0
		public string[] GetPlayerNames(); // 0x00000001803B6210-0x00000001803B63A0
		public int GetPlayerNames(IList<string> results); // 0x00000001803B5F70-0x00000001803B6210
		public int[] GetPlayerIds(); // 0x00000001803B5CE0-0x00000001803B5E20
		public int[] GetPlayerRuntimeIds(); // 0x00000001803B66B0-0x00000001803B67C0
		public int GetPlayerRuntimeIds(IList<int> results); // 0x00000001803B63A0-0x00000001803B66B0
		public string GetPlayerNameById(int id); // 0x00000001803B5E20-0x00000001803B5F70
		public Player_Editor GetPlayer(int index); // 0x00000001803B67C0-0x00000001803B6830
		public int GetPlayerId(string name); // 0x00000001803B5B70-0x00000001803B5CE0
		public bool IsMouseAssigned(); // 0x00000001803BAB60-0x00000001803BAC60
		public void ClearMouseAssignments(); // 0x00000001803A3A90-0x00000001803A3B60
		public bool IsKeyboardAssigned(); // 0x00000001803BAA40-0x00000001803BAB60
		public void ClearKeyboardAssignments(); // 0x00000001803A3980-0x00000001803A3A90
		public void AddAction(int categoryId); // 0x00000001803A3170-0x00000001803A3210
		public void InsertAction(int categoryId, int actionId); // 0x00000001803B9FC0-0x00000001803BA100
		public void DeleteAction(int categoryId, int actionId); // 0x00000001803A4300-0x00000001803A43E0
		public bool ReorderAction(int categoryId, int actionId, bool offsetDown, bool offsetNow); // 0x00000001803BBAD0-0x00000001803BBB00
		public int DuplicateAction_FromButton(int categoryId, int actionId); // 0x00000001803A7A70-0x00000001803A7D00
		private int xAgcAQaADPZEEsBsMezluBrtQMgu(int param_0000d093, InputAction param_0000d094); // 0x00000001803BE910-0x00000001803BEA80
		public string[] GetActionNames(); // 0x00000001803ACBF0-0x00000001803ACD90
		public int GetActionNames(IList<string> results); // 0x00000001803AC960-0x00000001803ACBF0
		public int[] GetActionIds(); // 0x00000001803AC6B0-0x00000001803AC7F0
		public int GetActionIds(IList<int> results); // 0x00000001803AC420-0x00000001803AC6B0
		public string GetActionNameById(int id); // 0x00000001803AC7F0-0x00000001803AC960
		public InputAction GetAction(int index); // 0x00000001803ACE20-0x00000001803ACEB0
		public InputAction GetAction(string name); // 0x00000001803ACD90-0x00000001803ACE20
		public InputAction GetActionById(int id); // 0x00000001803AB940-0x00000001803ABA80
		public int GetActionId(string name); // 0x00000001803AC380-0x00000001803AC420
		public string[] GetSortedActionNamesInCategory(int id); // 0x00000001803B6D10-0x00000001803B6F20
		public IEnumerable<string> SortedActionNamesInCategory(int id); // 0x00000001803BC0B0-0x00000001803BC130
		public string[] GetSortedActionDescriptiveNamesInCategory(int id); // 0x00000001803B6830-0x00000001803B6B00
		public IEnumerable<string> SortedActionDescriptiveNamesInCategory(int id); // 0x00000001803BBF90-0x00000001803BC010
		public int[] GetSortedActionIdsInCategory(int id); // 0x00000001803B6B00-0x00000001803B6D10
		public IEnumerable<int> SortedActionIdsInCategory(int id); // 0x00000001803BC010-0x00000001803BC0B0
		public bool ContainsAction(int id); // 0x00000001803A3B70-0x00000001803A3B90
		public int IndexOfAction(int id); // 0x00000001803B84F0-0x00000001803B8600
		public int IndexOfAction(string name); // 0x00000001803B8600-0x00000001803B8760
		public void AddActionCategory(); // 0x00000001803A30E0-0x00000001803A3170
		public void InsertActionCategory(int index); // 0x00000001803B9EB0-0x00000001803B9FC0
		public void DeleteActionCategory(int index); // 0x00000001803A4060-0x00000001803A4300
		public bool ReorderActionCategory(int index, bool offsetDown, bool offsetNow); // 0x00000001803BBA20-0x00000001803BBAD0
		public void DuplicateActionCategory(int index, bool duplicateActions); // 0x00000001803A7410-0x00000001803A7A70
		public void ChangeActionCategory(int actionId, int newCategoryId); // 0x00000001803A3840-0x00000001803A3980
		public int GetActionCategoryCount(int id); // 0x00000001803ABB40-0x00000001803ABCA0
		public int GetActionCategoryIndex(int id); // 0x00000001803ABE90-0x00000001803ABF80
		public string[] GetActionCategoryNames(); // 0x00000001803AC0E0-0x00000001803AC250
		public int[] GetActionCategoryIds(); // 0x00000001803ABD40-0x00000001803ABE90
		public InputCategory GetActionCategory(int index); // 0x00000001803AC250-0x00000001803AC2F0
		public InputCategory GetActionCategory(string name); // 0x00000001803AC2F0-0x00000001803AC380
		public InputCategory GetActionCategoryById(int id); // 0x00000001803ABA80-0x00000001803ABB00
		public int GetActionCategoryId(string name); // 0x00000001803ABCA0-0x00000001803ABD40
		public string GetActionCategoryNameById(int id); // 0x00000001803ABF80-0x00000001803AC0E0
		public int IndexOfActionCategory(int id); // 0x00000001803B83F0-0x00000001803B84F0
		public int IndexOfActionCategory(string name); // 0x00000001803B82B0-0x00000001803B83F0
		public int GetActionCategoryCount(); // 0x00000001803ABB00-0x00000001803ABB40
		public void AddInputBehavior(); // 0x00000001803A3510-0x00000001803A3570
		public void InsertInputBehavior(int index); // 0x00000001803BA520-0x00000001803BA600
		public void DeleteInputBehavior(int index); // 0x00000001803A5690-0x00000001803A5900
		public bool ReorderInputBehavior(int index, bool offsetDown, bool offsetNow); // 0x00000001803BBCF0-0x00000001803BBD60
		public void DuplicateInputBehavior(int index); // 0x00000001803A8D70-0x00000001803A8FA0
		public string[] GetInputBehaviorNames(); // 0x00000001803B0DB0-0x00000001803B0F40
		public int[] GetInputBehaviorIds(); // 0x00000001803B0C50-0x00000001803B0DB0
		public InputBehavior GetInputBehavior(int index); // 0x00000001803B0FD0-0x00000001803B1060
		public InputBehavior GetInputBehavior(string name); // 0x00000001803B0F40-0x00000001803B0FD0
		public InputBehavior GetInputBehaviorById(int id); // 0x00000001803B0A60-0x00000001803B0BB0
		public int GetInputBehaviorId(string name); // 0x00000001803B0BB0-0x00000001803B0C50
		public int IndexOfInputBehavior(int id); // 0x00000001803B92C0-0x00000001803B93D0
		public int IndexOfInputBehavior(string name); // 0x00000001803B93D0-0x00000001803B9530
		public void AddMapCategory(); // 0x00000001803A3630-0x00000001803A3690
		public void InsertMapCategory(int index); // 0x00000001803BA780-0x00000001803BA860
		public void DeleteMapCategory(int index); // 0x00000001803A6240-0x00000001803A6DC0
		public bool ReorderMapCategory(int index, bool offsetDown, bool offsetNow); // 0x00000001803BBE40-0x00000001803BBEB0
		public void DuplicateMapCategory(int index, bool duplicateMaps); // 0x00000001803A99E0-0x00000001803AA2F0
		public int GetMapCategoryMapCount(int id); // 0x00000001803B4340-0x00000001803B4740
		public int GetMapCategoryIndex(int id); // 0x00000001803B4230-0x00000001803B4340
		public string[] GetMapCategoryNames(); // 0x00000001803B48A0-0x00000001803B4A20
		public int[] GetMapCategoryIds(); // 0x00000001803B40E0-0x00000001803B4230
		public InputMapCategory GetMapCategory(int index); // 0x00000001803B4A20-0x00000001803B4AB0
		public InputMapCategory GetMapCategory(string name); // 0x00000001803B4AB0-0x00000001803B4B40
		public InputMapCategory GetMapCategoryById(int id); // 0x00000001803B3F10-0x00000001803B4040
		public int GetMapCategoryId(string name); // 0x00000001803B4040-0x00000001803B40E0
		public string GetMapCategoryNameById(int id); // 0x00000001803B4740-0x00000001803B48A0
		public int IndexOfMapCategory(int id); // 0x00000001803B9B90-0x00000001803B9C80
		public int IndexOfMapCategory(string name); // 0x00000001803B9A20-0x00000001803B9B90
		public string[] GetLayoutNames(ControllerType controllerType); // 0x00000001803B3E50-0x00000001803B3F10
		public int[] GetLayoutIds(ControllerType controllerType); // 0x00000001803B3420-0x00000001803B3950
		public void AddJoystickLayout(); // 0x00000001803A3570-0x00000001803A35D0
		public void InsertJoystickLayout(int index); // 0x00000001803BA600-0x00000001803BA6C0
		public void DeleteJoystickLayout(int index); // 0x00000001803A5900-0x00000001803A5C80
		public bool ReorderJoystickLayout(int index, bool offsetDown, bool offsetNow); // 0x00000001803BBD60-0x00000001803BBDD0
		public void DuplicateJoystickLayout(int index, bool duplicateMaps); // 0x00000001803A8FA0-0x00000001803A9380
		public int GetJoystickLayoutMapCount(int id); // 0x00000001803B1640-0x00000001803B1790
		public int GetJoystickLayoutIndex(int id); // 0x00000001803B1530-0x00000001803B1640
		public string[] GetJoystickLayoutNames(); // 0x00000001803B1900-0x00000001803B1A90
		public int[] GetJoystickLayoutIds(); // 0x00000001803B13A0-0x00000001803B1530
		public InputLayout GetJoystickLayout(int index); // 0x00000001803B1B20-0x00000001803B1BC0
		public InputLayout GetJoystickLayout(string name); // 0x00000001803B1A90-0x00000001803B1B20
		public InputLayout GetJoystickLayoutById(int id); // 0x00000001803B1190-0x00000001803B1300
		public int GetJoystickLayoutId(string name); // 0x00000001803B1300-0x00000001803B13A0
		public int IndexOfJoystickLayout(int id); // 0x00000001803B9530-0x00000001803B9650
		public int IndexOfJoystickLayout(string name); // 0x00000001803B9650-0x00000001803B97A0
		public string GetJoystickLayoutNameById(int id); // 0x00000001803B1790-0x00000001803B1900
		public void AddKeyboardLayout(); // 0x00000001803A35D0-0x00000001803A3630
		public void InsertKeyboardLayout(int index); // 0x00000001803BA6C0-0x00000001803BA780
		public void DeleteKeyboardLayout(int index); // 0x00000001803A5DD0-0x00000001803A6150
		public bool ReorderKeyboardLayout(int index, bool offsetDown, bool offsetNow); // 0x00000001803BBDD0-0x00000001803BBE40
		public void DuplicateKeyboardLayout(int index, bool duplicateMaps); // 0x00000001803A94C0-0x00000001803A98E0
		public int GetKeyboardLayoutMapCount(int id); // 0x00000001803B28D0-0x00000001803B2A50
		public int GetKeyboardLayoutIndex(int id); // 0x00000001803B27B0-0x00000001803B28D0
		public string[] GetKeyboardLayoutNames(); // 0x00000001803B2B70-0x00000001803B2D00
		public int[] GetKeyboardLayoutIds(); // 0x00000001803B2650-0x00000001803B27B0
		public InputLayout GetKeyboardLayout(int index); // 0x00000001803B2D00-0x00000001803B2D90
		public InputLayout GetKeyboardLayout(string name); // 0x00000001803B2D90-0x00000001803B2E30
		public InputLayout GetKeyboardLayoutById(int id); // 0x00000001803B2430-0x00000001803B25B0
		public int GetKeyboardLayoutId(string name); // 0x00000001803B25B0-0x00000001803B2650
		public int IndexOfKeyboardLayout(int id); // 0x00000001803B9920-0x00000001803B9A20
		public int IndexOfKeyboardLayout(string name); // 0x00000001803B97A0-0x00000001803B9920
		public string GetKeyboardLayoutNameById(int id); // 0x00000001803B2A50-0x00000001803B2B70
		public void AddMouseLayout(); // 0x00000001803A3690-0x00000001803A36F0
		public void InsertMouseLayout(int index); // 0x00000001803BA860-0x00000001803BA950
		public void DeleteMouseLayout(int index); // 0x00000001803A6DC0-0x00000001803A7220
		public bool ReorderMouseLayout(int index, bool offsetDown, bool offsetNow); // 0x00000001803BBEB0-0x00000001803BBF20
		public void DuplicateMouseLayout(int index, bool duplicateMaps); // 0x00000001803AA2F0-0x00000001803AA770
		public int GetMouseLayoutMapCount(int id); // 0x00000001803B4F90-0x00000001803B50E0
		public int GetMouseLayoutIndex(int id); // 0x00000001803B4E80-0x00000001803B4F90
		public string[] GetMouseLayoutNames(); // 0x00000001803B5200-0x00000001803B5390
		public int[] GetMouseLayoutIds(); // 0x00000001803B4D40-0x00000001803B4E80
		public InputLayout GetMouseLayout(int index); // 0x00000001803B5420-0x00000001803B54C0
		public InputLayout GetMouseLayout(string name); // 0x00000001803B5390-0x00000001803B5420
		public InputLayout GetMouseLayoutById(int id); // 0x00000001803B4B40-0x00000001803B4CA0
		public int GetMouseLayoutId(string name); // 0x00000001803B4CA0-0x00000001803B4D40
		public int IndexOfMouseLayout(int id); // 0x00000001803B9C80-0x00000001803B9D70
		public int IndexOfMouseLayout(string name); // 0x00000001803B9D70-0x00000001803B9EB0
		public string GetMouseLayoutNameById(int id); // 0x00000001803B50E0-0x00000001803B5200
		public void AddCustomControllerLayout(); // 0x00000001803A32F0-0x00000001803A3350
		public void InsertCustomControllerLayout(int index); // 0x00000001803BA300-0x00000001803BA3F0
		public void DeleteCustomControllerLayout(int index); // 0x00000001803A4F70-0x00000001803A52E0
		public bool ReorderCustomControllerLayout(int index, bool offsetDown, bool offsetNow); // 0x00000001803BBC00-0x00000001803BBC70
		public void DuplicateCustomControllerLayout(int index, bool duplicateMaps); // 0x00000001803A8270-0x00000001803A8680
		public int GetCustomControllerLayoutMapCount(int id); // 0x00000001803AF8A0-0x00000001803AFA10
		public int GetCustomControllerLayoutIndex(int id); // 0x00000001803AF7B0-0x00000001803AF8A0
		public string[] GetCustomControllerLayoutNames(); // 0x00000001803AFB30-0x00000001803AFCB0
		public int[] GetCustomControllerLayoutIds(); // 0x00000001803AF650-0x00000001803AF7B0
		public InputLayout GetCustomControllerLayout(int index); // 0x00000001803AFD40-0x00000001803AFDD0
		public InputLayout GetCustomControllerLayout(string name); // 0x00000001803AFCB0-0x00000001803AFD40
		public InputLayout GetCustomControllerLayoutById(int id); // 0x00000001803AF440-0x00000001803AF580
		public int GetCustomControllerLayoutId(string name); // 0x00000001803AF580-0x00000001803AF650
		public int IndexOfCustomControllerLayout(int id); // 0x00000001803B8E10-0x00000001803B8F00
		public int IndexOfCustomControllerLayout(string name); // 0x00000001803B8CA0-0x00000001803B8E10
		public string GetCustomControllerLayoutNameById(int id); // 0x00000001803AFA10-0x00000001803AFB30
		public string GetLayoutNameById(ControllerType controllerType, int id); // 0x00000001803B3950-0x00000001803B3E50
		internal ControllerMap EOwoytsuxWtNKYwmHmCJQPHsTZI(Controller param_0000d117, int param_0000d118, int param_0000d119); // 0x00000001803AAAA0-0x00000001803AAF10
		public ControllerMap_Editor GetJoystickMap(int categoryId, Guid hardwareGuid, int layoutId); // 0x00000001803B1FC0-0x00000001803B2210
		public ControllerMap_Editor GetJoystickMapById(int id, out int joystickMapIndex); // 0x00000001803B1BC0-0x00000001803B1D20
		public List<ControllerMap_Editor> GetJoystickMaps(Guid hardwareGuid); // 0x00000001803B2210-0x00000001803B2430
		public int GetJoystickMapId(int categoryId, Guid hardwareGuid, int layoutId); // 0x00000001803B1D20-0x00000001803B1FC0
		public bool HasJoystickMap(int categoryId, Guid hardwareGuid, int layoutId); // 0x00000001803B76F0-0x00000001803B7980
		public bool HasJoystickMap(Guid hardwareGuid); // 0x00000001803B7550-0x00000001803B76F0
		public bool HasJoystickMapInCategory(Guid hardwareGuid, int categoryId); // 0x00000001803B7340-0x00000001803B7550
		public bool CreateJoystickMap(int categoryId, Guid joystickOrTemplateGuid, int layoutId); // 0x00000001803A3CF0-0x00000001803A3E10
		public void DeleteJoystickMap(int id); // 0x00000001803A5C80-0x00000001803A5DD0
		public int DuplicateJoystickMap(int index); // 0x00000001803A9380-0x00000001803A94C0
		internal JoystickMap YpJPZbuZGPdqkNaBIcofHiInTJhW(HardwareControllerMapIdentifier param_0000d12e, int param_0000d12f, int param_0000d130); // 0x00000001803BC8E0-0x00000001803BC990
		internal JoystickMap xdnItkCfoFccxjuXFxctPHWGIzYh(Joystick param_0000d131, int param_0000d132, int param_0000d133); // 0x00000001803BEF20-0x00000001803BEFB0
		private JoystickMap xdnItkCfoFccxjuXFxctPHWGIzYh(HardwareControllerMapIdentifier param_0000d134, int param_0000d135, int param_0000d136); // 0x00000001803BEFB0-0x00000001803BFC00
		private ControllerMap_Editor ndLQqrZEpaEeFJfFjDDduWYBJeLR(int param_0000d137, Guid param_0000d138, int param_0000d139, bool param_0000d13a); // 0x00000001803BDE00-0x00000001803BDE90
		private ControllerMap_Editor mPtxhjxlVFVqWTxdRHJhZSsEQrB(int param_0000d13b, Guid param_0000d13c, int param_0000d13d); // 0x00000001803BD920-0x00000001803BDBA0
		private JoystickMap xWJwxqAPumMvwMjOUGADtxdZhJkD(HardwareControllerMapIdentifier param_0000d13e, ControllerMap_Editor param_0000d13f, HardwareJoystickTemplateMap param_0000d140, HardwareJoystickMap param_0000d141, int param_0000d142, int param_0000d143); // 0x00000001803BEA80-0x00000001803BEF20
		private JoystickMap EpoZIaplrcKnAsrXHChOSpULxzE(JoystickMap param_0000d144, HardwareControllerMapIdentifier param_0000d145); // 0x00000001803AAF10-0x00000001803AB7A0
		public ControllerMap_Editor GetKeyboardMap(int categoryId, int layoutId); // 0x00000001803B3100-0x00000001803B32D0
		public int GetKeyboardMapId(int categoryId, int layoutId); // 0x00000001803B2F70-0x00000001803B3100
		public bool HasKeyboardMap(int categoryId, Guid hardwareGuid, int layoutId); // 0x00000001803B7BE0-0x00000001803B7E40
		public bool CreateKeyboardMap(int categoryId, int layoutId); // 0x00000001803A3E10-0x00000001803A3F70
		public void DeleteKeyboardMap(int id); // 0x00000001803A6150-0x00000001803A6240
		public int DuplicateKeyboardMap(int index); // 0x00000001803A98E0-0x00000001803A99E0
		public ControllerMap_Editor GetKeyboardMapById(int id, out int keyboardMapIndex); // 0x00000001803B2E30-0x00000001803B2F70
		public KeyboardMap FindKeyboardMap_Game(int categoryId, int layoutId); // 0x00000001803AB7A0-0x00000001803AB880
		public bool HasKeyboardMapInCategory(int categoryId); // 0x00000001803B7980-0x00000001803B7A90
		public bool HasKeyboardMapInLayout(int categoryId, int layoutId); // 0x00000001803B7A90-0x00000001803B7BE0
		public ControllerMap_Editor GetMouseMap(int categoryId, int layoutId); // 0x00000001803B5790-0x00000001803B58F0
		public int GetMouseMapId(int categoryId, int layoutId); // 0x00000001803B55F0-0x00000001803B5790
		public bool HasMouseMap(int categoryId, Guid hardwareGuid, int layoutId); // 0x00000001803B8080-0x00000001803B82B0
		public bool CreateMouseMap(int categoryId, int layoutId); // 0x00000001803A3F70-0x00000001803A4060
		public void DeleteMouseMap(int id); // 0x00000001803A7220-0x00000001803A7350
		public int DuplicateMouseMap(int index); // 0x00000001803AA770-0x00000001803AA870
		public ControllerMap_Editor GetMouseMapById(int id, out int mouseMapIndex); // 0x00000001803B54C0-0x00000001803B55F0
		public MouseMap FindMouseMap_Game(int categoryId, int layoutId); // 0x00000001803AB880-0x00000001803AB940
		public bool HasMouseMapInCategory(int categoryId); // 0x00000001803B7E40-0x00000001803B7F30
		public bool HasMouseMapInLayout(int categoryId, int layoutId); // 0x00000001803B7F30-0x00000001803B8080
		public ControllerMap_Editor GetCustomControllerMap(int categoryId, int controllerUid, int layoutId); // 0x00000001803B0290-0x00000001803B0450
		public ControllerMap_Editor GetCustomControllerMapById(int mapId, out int customControllerMapIndex); // 0x00000001803AFDD0-0x00000001803AFF30
		public List<ControllerMap_Editor> GetCustomControllerMaps(int controllerUid); // 0x00000001803B0450-0x00000001803B0620
		public int GetCustomControllerMapId(int categoryId, int controllerUid, int layoutId); // 0x00000001803B00B0-0x00000001803B0290
		public bool HasCustomControllerMap(int mapId, int categoryId, int layoutId); // 0x00000001803B7060-0x00000001803B7240
		public bool HasCustomControllerMap(int mapId); // 0x00000001803B7240-0x00000001803B7340
		public bool HasCustomControllerMapInCategory(int controllerUid, int categoryId); // 0x00000001803B6F20-0x00000001803B7060
		public bool CreateCustomControllerMap(int categoryId, int controllerUid, int layoutId); // 0x00000001803A3B90-0x00000001803A3CF0
		public void DeleteCustomControllerMap(int mapId); // 0x00000001803A52E0-0x00000001803A5440
		public int DuplicateCustomControllerMap(int index); // 0x00000001803A8680-0x00000001803A8870
		internal CustomControllerMap ARagziTwlApCZyMQCFSXAnskIdXr(Guid param_0000d17e, int param_0000d17f, int param_0000d180); // 0x00000001803A2EE0-0x00000001803A30E0
		internal CustomControllerMap ARagziTwlApCZyMQCFSXAnskIdXr(int param_0000d181, int param_0000d182, int param_0000d183); // 0x00000001803A2BD0-0x00000001803A2D60
		private CustomControllerMap ARagziTwlApCZyMQCFSXAnskIdXr(CustomController_Editor param_0000d184, int param_0000d185, int param_0000d186); // 0x00000001803A2D60-0x00000001803A2EE0
		private ControllerMap_Editor kVbbpwdMQAYYIbltrCknXBDGTYp(int param_0000d187, int param_0000d188, int param_0000d189, bool param_0000d18a); // 0x00000001803BD730-0x00000001803BD920
		private ControllerMap_Editor WxYEjbQGVzEHorCNfYMmDyOxqDD(int param_0000d18b, int param_0000d18c, int param_0000d18d); // 0x00000001803BC3E0-0x00000001803BC8E0
		public void DeleteControllerMap(ControllerType controllerType, int id); // 0x00000001803A4A40-0x00000001803A4F70
		public ControllerMap_Editor GetControllerMapByIndex(ControllerType controllerType, int index); // 0x00000001803AD4E0-0x00000001803AD5D0
		public ControllerMap_Editor GetControllerMapById(ControllerType controllerType, int id, out int controllerMapIndex); // 0x00000001803ACFD0-0x00000001803AD4E0
		public int DuplicateControllerMap(ControllerType controllerType, int index); // 0x00000001803A8180-0x00000001803A8270
		internal ControllerTemplateMap suUFvLntwhKbrtAyeagJKrjQEDq(Guid param_0000d197, int param_0000d198, int param_0000d199); // 0x00000001803BE610-0x00000001803BE680
		public void AddCustomController(); // 0x00000001803A3350-0x00000001803A3510
		public void InsertCustomController(int index); // 0x00000001803BA3F0-0x00000001803BA520
		public void DeleteCustomController(int index); // 0x00000001803A5440-0x00000001803A5690
		public bool ReorderCustomController(int index, bool offsetDown, bool offsetNow); // 0x00000001803BBC70-0x00000001803BBCF0
		public void DuplicateCustomController(int index, bool duplicateMaps); // 0x00000001803A8870-0x00000001803A8D70
		public int GetCustomControllerMapCount(int controllerUid); // 0x00000001803AFF30-0x00000001803B00B0
		public int GetCustomControllerIndex(int id); // 0x00000001803AF320-0x00000001803AF440
		public string[] GetCustomControllerNames(); // 0x00000001803B0770-0x00000001803B0940
		public int[] GetCustomControllerIds(); // 0x00000001803AF1E0-0x00000001803AF320
		public Guid[] GetCustomControllerGuids(); // 0x00000001803AEFB0-0x00000001803AF140
		public CustomController_Editor GetCustomController(int index); // 0x00000001803B09D0-0x00000001803B0A60
		public CustomController_Editor GetCustomController(string name); // 0x00000001803B0940-0x00000001803B09D0
		public CustomController_Editor GetCustomControllerById(int id); // 0x00000001803AEE30-0x00000001803AEFB0
		public CustomController_Editor GetCustomControllerByHardwareTypeGuid(Guid hardwareTypeGuid); // 0x00000001803AEC50-0x00000001803AEE30
		public int GetCustomControllerId(string name); // 0x00000001803AF140-0x00000001803AF1E0
		public int IndexOfCustomController(int id); // 0x00000001803B9050-0x00000001803B9150
		public int IndexOfCustomController(string name); // 0x00000001803B8F00-0x00000001803B9050
		public int IndexOfCustomController(Guid hardwareTypeGuid); // 0x00000001803B9150-0x00000001803B92C0
		public string GetCustomControllerNameById(int id); // 0x00000001803B0620-0x00000001803B0770
		public void AddControllerMapLayoutManagerRuleSet(); // 0x00000001803A3280-0x00000001803A32F0
		public void InsertControllerMapLayoutManagerRuleSet(int index); // 0x00000001803BA210-0x00000001803BA300
		public void DeleteControllerMapLayoutManagerRuleSet(int index); // 0x00000001803A4710-0x00000001803A4A40
		public bool ReorderControllerMapLayoutManagerRuleSet(int index, bool offsetDown, bool offsetNow); // 0x00000001803BBB80-0x00000001803BBC00
		public void DuplicateControllerMapLayoutManagerRuleSet(int index); // 0x00000001803A7F60-0x00000001803A8180
		public int GetControllerMapLayoutManagerRuleSetUsedCount(int id); // 0x00000001803AE920-0x00000001803AEB50
		public int GetControllerMapLayoutManagerRuleSetIndex(int id); // 0x00000001803AE4F0-0x00000001803AE620
		public string[] GetControllerMapLayoutManagerRuleSetNames(); // 0x00000001803AE780-0x00000001803AE920
		public int[] GetControllerMapLayoutManagerRuleSetIds(); // 0x00000001803AE3B0-0x00000001803AE4F0
		public ControllerMapLayoutManager_RuleSet_Editor GetControllerMapLayoutManagerRuleSet(int index); // 0x00000001803AEB50-0x00000001803AEBC0
		public ControllerMapLayoutManager_RuleSet_Editor GetControllerMapLayoutManagerRuleSet(string name); // 0x00000001803AEBC0-0x00000001803AEC50
		public ControllerMapLayoutManager_RuleSet_Editor GetControllerMapLayoutManagerRuleSetById(int id); // 0x00000001803AE140-0x00000001803AE2D0
		public int GetControllerMapLayoutManagerRuleSetId(string name); // 0x00000001803AE310-0x00000001803AE3B0
		public int IndexOfControllerMapLayoutManagerRuleSet(int id); // 0x00000001803B8B70-0x00000001803B8CA0
		public int IndexOfControllerMapLayoutManagerRuleSet(string name); // 0x00000001803B89E0-0x00000001803B8B70
		public string GetControllerMapLayoutManagerRuleSetNameById(int id); // 0x00000001803AE620-0x00000001803AE780
		public int GetControllerMapLayoutManagerRuleSetCount(); // 0x00000001803AE2D0-0x00000001803AE310
		public void AddControllerMapEnablerRuleSet(); // 0x00000001803A3210-0x00000001803A3280
		public void InsertControllerMapEnablerRuleSet(int index); // 0x00000001803BA100-0x00000001803BA210
		public void DeleteControllerMapEnablerRuleSet(int index); // 0x00000001803A43E0-0x00000001803A4710
		public bool ReorderControllerMapEnablerRuleSet(int index, bool offsetDown, bool offsetNow); // 0x00000001803BBB00-0x00000001803BBB80
		public void DuplicateControllerMapEnablerRuleSet(int index); // 0x00000001803A7D00-0x00000001803A7F60
		public int GetControllerMapEnablerRuleSetUsedCount(int id); // 0x00000001803ADDC0-0x00000001803AE040
		public int GetControllerMapEnablerRuleSetIndex(int id); // 0x00000001803AD9A0-0x00000001803ADAC0
		public string[] GetControllerMapEnablerRuleSetNames(); // 0x00000001803ADC10-0x00000001803ADDC0
		public int[] GetControllerMapEnablerRuleSetIds(); // 0x00000001803AD840-0x00000001803AD9A0
		public ControllerMapEnabler_RuleSet_Editor GetControllerMapEnablerRuleSet(int index); // 0x00000001803AE040-0x00000001803AE0B0
		public ControllerMapEnabler_RuleSet_Editor GetControllerMapEnablerRuleSet(string name); // 0x00000001803AE0B0-0x00000001803AE140
		public ControllerMapEnabler_RuleSet_Editor GetControllerMapEnablerRuleSetById(int id); // 0x00000001803AD5D0-0x00000001803AD760
		public int GetControllerMapEnablerRuleSetId(string name); // 0x00000001803AD7A0-0x00000001803AD840
		public int IndexOfControllerMapEnablerRuleSet(int id); // 0x00000001803B88D0-0x00000001803B89E0
		public int IndexOfControllerMapEnablerRuleSet(string name); // 0x00000001803B8760-0x00000001803B88D0
		public string GetControllerMapEnablerRuleSetNameById(int id); // 0x00000001803ADAC0-0x00000001803ADC10
		public int GetControllerMapEnablerRuleSetCount(); // 0x00000001803AD760-0x00000001803AD7A0
		public int GetNewPlayerId(); // 0x00000001803B5B60-0x00000001803B5B70
		public int GetNewActionId(); // 0x00000001803B5A50-0x00000001803B5A60
		public int GetNewActionCategoryId(); // 0x00000001803B5A40-0x00000001803B5A50
		public int GetNewInputBehaviorId(); // 0x00000001803B5AE0-0x00000001803B5AF0
		public int GetNewMapCategoryId(); // 0x00000001803B5B30-0x00000001803B5B40
		public int GetNewJoystickLayoutId(); // 0x00000001803B5AF0-0x00000001803B5B00
		public int GetNewKeyboardLayoutId(); // 0x00000001803B5B10-0x00000001803B5B20
		public int GetNewMouseLayoutId(); // 0x00000001803B5B40-0x00000001803B5B50
		public int GetNewCustomControllerLayoutId(); // 0x00000001803B5AC0-0x00000001803B5AD0
		public int GetNewJoystickMapId(); // 0x00000001803B5B00-0x00000001803B5B10
		public int GetNewKeyboardMapId(); // 0x00000001803B5B20-0x00000001803B5B30
		public int GetNewMouseMapId(); // 0x00000001803B5B50-0x00000001803B5B60
		public int GetNewCustomControllerMapId(); // 0x00000001803B5AD0-0x00000001803B5AE0
		public int GetNewCustomControllerId(); // 0x00000001803B5A80-0x00000001803B5AC0
		public int GetNewControllerMapLayoutManagerRuleSetId(); // 0x00000001803B5A70-0x00000001803B5A80
		public int GetNewControllerMapEnablerRuleSetId(); // 0x00000001803B5A60-0x00000001803B5A70
		private Player_Editor QWHDzZlTCcswdrBErdzWZjHDCgS(); // 0x00000001803BB7D0-0x00000001803BBA20
		private InputAction iClmbcIAebGtuWzgkzsXTZEwKHh(); // 0x00000001803BD660-0x00000001803BD730
		private InputCategory BlOLAqqsklgrrJjnVePhtpZwDJz(); // 0x00000001803A3750-0x00000001803A3840
		private InputBehavior msQiNXZpntCADLQypZWjQeIvStM(); // 0x00000001803BDBA0-0x00000001803BDE00
		private InputMapCategory aRRZkQbibAfeqtboQEjeDJqsCLX(); // 0x00000001803BCF70-0x00000001803BD030
		private InputLayout tffiJlHPSckjhLxLZEFnmJfXRiLe(); // 0x00000001803BE700-0x00000001803BE7C0
		private InputLayout OXOlRHvKOnFHLdnLYQUfmSyOQAt(); // 0x00000001803BB4C0-0x00000001803BB580
		private InputLayout odVcwomCUhldxQCiLbmsUDDjgaVd(); // 0x00000001803BDE90-0x00000001803BDF50
		private InputLayout psRmQHgHRVOWmmSyJXvfmQVEDUI(); // 0x00000001803BE140-0x00000001803BE200
		private CustomController_Editor pkWHkUynJrcctjvbGqRBCpVGtFNe(); // 0x00000001803BE010-0x00000001803BE140
		private ControllerMapLayoutManager_RuleSet_Editor pWsybvsmmQkxlqgwvRbHUvbDBuF(); // 0x00000001803BDF50-0x00000001803BE010
		private ControllerMapEnabler_RuleSet_Editor yYqfDqrfzbEHMJDeYeotdDvtgdJF(); // 0x00000001803BFC80-0x00000001803BFD60
		private ControllerMap_Editor cUkfTUEdeGdJPAVZiNiejnaoLFNO(List<ControllerMap_Editor> param_0000d1ca, int param_0000d1cb, int param_0000d1cc); // 0x00000001803BD0B0-0x00000001803BD200
		private ControllerMap_Editor IyhtNZkPhHhmMxMfbhJOMFFEbUm(List<ControllerMap_Editor> param_0000d1cd, List<InputLayout> param_0000d1ce, int param_0000d1cf, int param_0000d1d0, bool param_0000d1d1); // 0x00000001803BB080-0x00000001803BB240
		private ControllerMap_Editor rLLOzlhxnJLQFWpxFcBxtcOFmoM(List<ControllerMap_Editor> param_0000d1d2, List<InputLayout> param_0000d1d3, int param_0000d1d4, int param_0000d1d5); // 0x00000001803BE200-0x00000001803BE530
		private void gfJZYxyBTRoASASxDVylKmciAEV(List<ControllerMap_Editor> param_0000d1d6, List<InputLayout> param_0000d1d7); // 0x00000001803BD580-0x00000001803BD660
		internal void ItdhavHGXcUkAhyjaCFbIXENJheh(); // 0x00000001803BAC60-0x00000001803BB080
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		internal static UserData Merge(UserData orig, UserData other, bool preserveOrigIds); // 0x00000001803BB3A0-0x00000001803BB3B0
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		internal static UserData Compact(UserData orig); // 0x00000001803A3B60-0x00000001803A3B70
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private static void WKaKGNfMHeCdScZcerMBHvRQECn(List<Player_Editor.Mapping> param_0000d1dc, int param_0000d1dd); // 0x00000001803BC290-0x00000001803BC3E0
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private static void StefxDPlBjQaiHnNVLndCSwQYaB(List<Player_Editor.Mapping> param_0000d1de, int param_0000d1df); // 0x00000001803BC130-0x00000001803BC290
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private static void JqZsbOkJPHiKzOEQbwQhjgwxEqJI(List<Player_Editor.Mapping> param_0000d1e0, int param_0000d1e1); // 0x00000001803BB240-0x00000001803BB3A0
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private static void dpBcsqEaQaCZJrrxLzIXaZudUqz(List<Player_Editor.Mapping> param_0000d1e2, int param_0000d1e3); // 0x00000001803BD200-0x00000001803BD310
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private static void NslsOMnHJwNgQpCRpuMkJDkqUfa(List<Player_Editor.Mapping> param_0000d1e4, int param_0000d1e5); // 0x00000001803BB3B0-0x00000001803BB4C0
	}
}
