/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Rewired;
using Rewired.Utils.Interfaces;
using UnityEngine;

// Image 50: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5712-6954

namespace Rewired.Data
{
	[Serializable]
	[Browsable] // 0x00000001800D4F10-0x00000001800D4F50
	[EditorBrowsable] // 0x00000001800D4F10-0x00000001800D4F50
	public sealed class Player_Editor // TypeDefIndex: 6258
	{
		// Fields
		[CustomObfuscation] // 0x00000001800C5270-0x00000001800C52B0
		[SerializeField] // 0x00000001800C5270-0x00000001800C52B0
		private int _id; // 0x10
		[CustomObfuscation] // 0x00000001800C3DD0-0x00000001800C3E10
		[SerializeField] // 0x00000001800C3DD0-0x00000001800C3E10
		private string _name; // 0x18
		[CustomObfuscation] // 0x00000001800C5270-0x00000001800C52B0
		[SerializeField] // 0x00000001800C5270-0x00000001800C52B0
		private string _descriptiveName; // 0x20
		[CustomObfuscation] // 0x00000001800C5270-0x00000001800C52B0
		[SerializeField] // 0x00000001800C5270-0x00000001800C52B0
		private bool _startPlaying; // 0x28
		[CustomObfuscation] // 0x00000001800C5270-0x00000001800C52B0
		[SerializeField] // 0x00000001800C5270-0x00000001800C52B0
		private List<Mapping> _defaultJoystickMaps; // 0x30
		[CustomObfuscation] // 0x00000001800C3DD0-0x00000001800C3E10
		[SerializeField] // 0x00000001800C3DD0-0x00000001800C3E10
		private List<Mapping> _defaultMouseMaps; // 0x38
		[CustomObfuscation] // 0x00000001800C3DD0-0x00000001800C3E10
		[SerializeField] // 0x00000001800C3DD0-0x00000001800C3E10
		private List<Mapping> _defaultKeyboardMaps; // 0x40
		[CustomObfuscation] // 0x00000001800C5270-0x00000001800C52B0
		[SerializeField] // 0x00000001800C5270-0x00000001800C52B0
		private List<Mapping> _defaultCustomControllerMaps; // 0x48
		[CustomObfuscation] // 0x00000001800C3DD0-0x00000001800C3E10
		[SerializeField] // 0x00000001800C3DD0-0x00000001800C3E10
		private List<CreateControllerInfo> _startingCustomControllers; // 0x50
		[CustomObfuscation] // 0x00000001800C5270-0x00000001800C52B0
		[SerializeField] // 0x00000001800C5270-0x00000001800C52B0
		private bool _assignMouseOnStart; // 0x58
		[CustomObfuscation] // 0x00000001800C5270-0x00000001800C52B0
		[SerializeField] // 0x00000001800C5270-0x00000001800C52B0
		private bool _assignKeyboardOnStart; // 0x59
		[CustomObfuscation] // 0x00000001800C3DD0-0x00000001800C3E10
		[SerializeField] // 0x00000001800C3DD0-0x00000001800C3E10
		private bool _excludeFromControllerAutoAssignment; // 0x5A
		[CustomObfuscation] // 0x00000001800C5270-0x00000001800C52B0
		[SerializeField] // 0x00000001800C5270-0x00000001800C52B0
		private ControllerMapLayoutManagerSettings _controllerMapLayoutManagerSettings; // 0x60
		[CustomObfuscation] // 0x00000001800C3DD0-0x00000001800C3E10
		[SerializeField] // 0x00000001800C3DD0-0x00000001800C3E10
		private ControllerMapEnablerSettings _controllerMapEnablerSettings; // 0x68
	
		// Properties
		public int id { get; internal set; } // 0x000000018036CFF0-0x000000018036D000 0x000000018037AA40-0x000000018037AA50
		public string name { get; internal set; } // 0x000000018038B150-0x000000018038B160 0x000000018038B160-0x000000018038B170
		public string descriptiveName { get; internal set; } // 0x000000018036AC70-0x000000018036AC80 0x000000018036AC90-0x000000018036ACA0
		public bool startPlaying { get; internal set; } // 0x00000001803A2790-0x00000001803A27A0 0x00000001803A2840-0x00000001803A2850
		public List<Mapping> defaultJoystickMaps { get; internal set; } // 0x0000000180397720-0x0000000180397730 0x00000001803A2800-0x00000001803A2810
		public List<Mapping> defaultMouseMaps { get; internal set; } // 0x0000000180369BB0-0x0000000180369BC0 0x00000001803A2820-0x00000001803A2830
		public List<Mapping> defaultKeyboardMaps { get; internal set; } // 0x0000000180369B30-0x0000000180369B40 0x00000001803A2810-0x00000001803A2820
		public List<Mapping> defaultCustomControllerMaps { get; internal set; } // 0x0000000180369C40-0x0000000180369C50 0x00000001803A27F0-0x00000001803A2800
		public List<CreateControllerInfo> startingCustomControllers { get; internal set; } // 0x00000001803A27A0-0x00000001803A27B0 0x00000001803A2850-0x00000001803A2860
		public bool assignMouseOnStart { get; internal set; } // 0x0000000180369BC0-0x0000000180369BD0 0x00000001803A27C0-0x00000001803A27D0
		public bool assignKeyboardOnStart { get; internal set; } // 0x00000001803A2770-0x00000001803A2780 0x00000001803A27B0-0x00000001803A27C0
		public bool excludeFromControllerAutoAssignment { get; internal set; } // 0x00000001803A2780-0x00000001803A2790 0x00000001803A2830-0x00000001803A2840
		public ControllerMapLayoutManagerSettings controllerMapLayoutManagerSettings { get; set; } // 0x0000000180369B40-0x0000000180369B50 0x00000001803A27E0-0x00000001803A27F0
		public ControllerMapEnablerSettings controllerMapEnablerSettings { get; set; } // 0x0000000180358970-0x0000000180358980 0x00000001803A27D0-0x00000001803A27E0
	
		// Nested types
		[Serializable]
		[Browsable] // 0x00000001800D5150-0x00000001800D5190
		[EditorBrowsable] // 0x00000001800D5150-0x00000001800D5190
		public sealed class Mapping // TypeDefIndex: 6259
		{
			// Fields
			[CustomObfuscation] // 0x00000001800C5270-0x00000001800C52B0
			[SerializeField] // 0x00000001800C5270-0x00000001800C52B0
			private bool _enabled; // 0x10
			[CustomObfuscation] // 0x00000001800C3DD0-0x00000001800C3E10
			[SerializeField] // 0x00000001800C3DD0-0x00000001800C3E10
			private int _categoryId; // 0x14
			[CustomObfuscation] // 0x00000001800C5270-0x00000001800C52B0
			[SerializeField] // 0x00000001800C5270-0x00000001800C52B0
			private int _layoutId; // 0x18
	
			// Properties
			public int categoryId { get; internal set; } // 0x0000000180372360-0x0000000180372370 0x000000018036C6F0-0x000000018036C700
			public int layoutId { get; internal set; } // 0x0000000180367710-0x0000000180367720 0x000000018036B1F0-0x000000018036B200
			public bool enabled { get; internal set; } // 0x0000000180375540-0x0000000180375550 0x00000001803930B0-0x00000001803930C0
	
			// Constructors
			public Mapping(); // 0x0000000180399420-0x0000000180399440
			public Mapping(bool enabled, int categoryId, int layoutId); // 0x0000000180399440-0x0000000180399490
	
			// Methods
			public void Clear(); // 0x0000000180399310-0x0000000180399320
			public Mapping Clone(); // 0x0000000180399320-0x00000001803993A0
			internal VazWCJszjSvmMxSvRJnnBczpVoI EehxeDwcaGcprdQyuinMghJJemBp(); // 0x00000001803993A0-0x0000000180399420
		}
	
		[Serializable]
		[Browsable] // 0x00000001800D5150-0x00000001800D5190
		[EditorBrowsable] // 0x00000001800D5150-0x00000001800D5190
		public sealed class ControllerMapLayoutManagerSettings : IDeepCloneable // TypeDefIndex: 6260
		{
			// Fields
			[CustomObfuscation] // 0x00000001800C3DD0-0x00000001800C3E10
			[SerializeField] // 0x00000001800C3DD0-0x00000001800C3E10
			private bool _enabled; // 0x10
			[CustomObfuscation] // 0x00000001800C5270-0x00000001800C52B0
			[SerializeField] // 0x00000001800C5270-0x00000001800C52B0
			private bool _loadFromUserDataStore; // 0x11
			[CustomObfuscation] // 0x00000001800C5270-0x00000001800C52B0
			[SerializeField] // 0x00000001800C5270-0x00000001800C52B0
			private List<RuleSetMapping> _ruleSets; // 0x18
	
			// Properties
			public bool enabled { get; set; } // 0x0000000180375540-0x0000000180375550 0x00000001803930B0-0x00000001803930C0
			public bool loadFromUserDataStore { get; set; } // 0x0000000180375550-0x0000000180375560 0x0000000180393640-0x0000000180393650
			public List<RuleSetMapping> ruleSets { get; set; } // 0x000000018038B150-0x000000018038B160 0x0000000180393650-0x00000001803936C0
	
			// Constructors
			public ControllerMapLayoutManagerSettings(); // 0x00000001803935D0-0x0000000180393640
			public ControllerMapLayoutManagerSettings(ControllerMapLayoutManagerSettings source); // 0x00000001803934E0-0x00000001803935D0
	
			// Methods
			internal ControllerMapLayoutManager.StartingSettings RvdvIxzowteyskgMeqDfHhJQQrH(); // 0x0000000180393250-0x00000001803932E0
			private MoWpPnIELFeSQuddbxIWcvZmvTK[] YIwTfelsdOSBRQKqbgCqZTPYzQn(); // 0x00000001803932E0-0x00000001803934E0
			object IDeepCloneable.DeepClone(); // 0x0000000180393130-0x0000000180393250
		}
	
		[Serializable]
		[Browsable] // 0x00000001800D5150-0x00000001800D5190
		[EditorBrowsable] // 0x00000001800D5150-0x00000001800D5190
		public sealed class ControllerMapEnablerSettings : IDeepCloneable // TypeDefIndex: 6261
		{
			// Fields
			[CustomObfuscation] // 0x00000001800C5270-0x00000001800C52B0
			[SerializeField] // 0x00000001800C5270-0x00000001800C52B0
			private bool _enabled; // 0x10
			[CustomObfuscation] // 0x00000001800C5270-0x00000001800C52B0
			[SerializeField] // 0x00000001800C5270-0x00000001800C52B0
			private List<RuleSetMapping> _ruleSets; // 0x18
	
			// Properties
			public bool enabled { get; set; } // 0x0000000180375540-0x0000000180375550 0x00000001803930B0-0x00000001803930C0
			public List<RuleSetMapping> ruleSets { get; set; } // 0x000000018038B150-0x000000018038B160 0x00000001803930C0-0x0000000180393130
	
			// Constructors
			public ControllerMapEnablerSettings(); // 0x0000000180393040-0x00000001803930B0
			public ControllerMapEnablerSettings(ControllerMapEnablerSettings source); // 0x0000000180392F60-0x0000000180393040
	
			// Methods
			internal ControllerMapEnabler.ZgESyvoCZDaaWJMTaxFmFrlTHlVN RvdvIxzowteyskgMeqDfHhJQQrH(); // 0x0000000180392D10-0x0000000180392D90
			private MoWpPnIELFeSQuddbxIWcvZmvTK[] YIwTfelsdOSBRQKqbgCqZTPYzQn(); // 0x0000000180392D90-0x0000000180392F60
			object IDeepCloneable.DeepClone(); // 0x0000000180392C00-0x0000000180392D10
		}
	
		[Serializable]
		[Browsable] // 0x00000001800D5150-0x00000001800D5190
		[EditorBrowsable] // 0x00000001800D5150-0x00000001800D5190
		public sealed class RuleSetMapping : IDeepCloneable // TypeDefIndex: 6262
		{
			// Fields
			[CustomObfuscation] // 0x00000001800C3DD0-0x00000001800C3E10
			[SerializeField] // 0x00000001800C3DD0-0x00000001800C3E10
			private bool _enabled; // 0x10
			[CustomObfuscation] // 0x00000001800C3DD0-0x00000001800C3E10
			[SerializeField] // 0x00000001800C3DD0-0x00000001800C3E10
			private int _id; // 0x14
	
			// Properties
			public int id { get; internal set; } // 0x0000000180372360-0x0000000180372370 0x000000018036C6F0-0x000000018036C700
			public bool enabled { get; internal set; } // 0x0000000180375540-0x0000000180375550 0x00000001803930B0-0x00000001803930C0
	
			// Constructors
			public RuleSetMapping(); // 0x00000001803A2AB0-0x00000001803A2AE0
			public RuleSetMapping(RuleSetMapping source); // 0x00000001803A29E0-0x00000001803A2AB0
			public RuleSetMapping(bool enabled, int id); // 0x00000001803A2AE0-0x00000001803A2B20
	
			// Methods
			public void Clear(); // 0x00000001803A2860-0x00000001803A2870
			public RuleSetMapping Clone(); // 0x00000001803A2870-0x00000001803A28E0
			internal MoWpPnIELFeSQuddbxIWcvZmvTK lGlqqLKpgWtHsjamVbzJIaKUfzy(); // 0x00000001803A2B20-0x00000001803A2B90
			object IDeepCloneable.DeepClone(); // 0x00000001803A28E0-0x00000001803A29E0
		}
	
		[Serializable]
		[Browsable] // 0x00000001800D5150-0x00000001800D5190
		[EditorBrowsable] // 0x00000001800D5150-0x00000001800D5190
		public sealed class CreateControllerInfo // TypeDefIndex: 6263
		{
			// Fields
			[CustomObfuscation] // 0x00000001800C3DD0-0x00000001800C3E10
			[SerializeField] // 0x00000001800C3DD0-0x00000001800C3E10
			private int _sourceId; // 0x10
			[CustomObfuscation] // 0x00000001800C3DD0-0x00000001800C3E10
			[SerializeField] // 0x00000001800C3DD0-0x00000001800C3E10
			private string _tag; // 0x18
	
			// Properties
			public int sourceId { get; internal set; } // 0x000000018036CFF0-0x000000018036D000 0x000000018037AA40-0x000000018037AA50
			public string tag { get; internal set; } // 0x000000018038B150-0x000000018038B160 0x000000018038B160-0x000000018038B170
	
			// Constructors
			public CreateControllerInfo(); // 0x000000018036B6C0-0x000000018036B6D0
			public CreateControllerInfo(int sourceId, string tag); // 0x0000000180393700-0x0000000180393740
			public CreateControllerInfo(CreateControllerInfo source); // 0x00000001803936C0-0x0000000180393700
		}
	
		// Constructors
		public Player_Editor(); // 0x00000001803A1DA0-0x00000001803A1FF0
		public Player_Editor(Player_Editor source); // 0x00000001803A1FF0-0x00000001803A2770
	
		// Methods
		public Player_Editor Clone(); // 0x00000001803A1500-0x00000001803A1560
		internal VVLouGbEKulMPcFZiTUTqikUjEp EpfIttlsNHKfwEcDxUNaegzLSWO(); // 0x00000001803A1560-0x00000001803A1DA0
	}
}
