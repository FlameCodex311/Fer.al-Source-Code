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

// Image 51: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5871-7113

namespace Rewired.Data
{
	[Serializable]
	[Browsable] // 0x0000000180210FD0-0x0000000180211010
	[EditorBrowsable] // 0x0000000180210FD0-0x0000000180211010
	public sealed class Player_Editor // TypeDefIndex: 6417
	{
		// Fields
		[CustomObfuscation] // 0x00000001801D1070-0x00000001801D10B0
		[SerializeField] // 0x00000001801D1070-0x00000001801D10B0
		private int _id; // 0x10
		[CustomObfuscation] // 0x00000001801D00E0-0x00000001801D0120
		[SerializeField] // 0x00000001801D00E0-0x00000001801D0120
		private string _name; // 0x18
		[CustomObfuscation] // 0x00000001801D1070-0x00000001801D10B0
		[SerializeField] // 0x00000001801D1070-0x00000001801D10B0
		private string _descriptiveName; // 0x20
		[CustomObfuscation] // 0x00000001801D1070-0x00000001801D10B0
		[SerializeField] // 0x00000001801D1070-0x00000001801D10B0
		private bool _startPlaying; // 0x28
		[CustomObfuscation] // 0x00000001801D1070-0x00000001801D10B0
		[SerializeField] // 0x00000001801D1070-0x00000001801D10B0
		private List<Mapping> _defaultJoystickMaps; // 0x30
		[CustomObfuscation] // 0x00000001801D00E0-0x00000001801D0120
		[SerializeField] // 0x00000001801D00E0-0x00000001801D0120
		private List<Mapping> _defaultMouseMaps; // 0x38
		[CustomObfuscation] // 0x00000001801D00E0-0x00000001801D0120
		[SerializeField] // 0x00000001801D00E0-0x00000001801D0120
		private List<Mapping> _defaultKeyboardMaps; // 0x40
		[CustomObfuscation] // 0x00000001801D1070-0x00000001801D10B0
		[SerializeField] // 0x00000001801D1070-0x00000001801D10B0
		private List<Mapping> _defaultCustomControllerMaps; // 0x48
		[CustomObfuscation] // 0x00000001801D00E0-0x00000001801D0120
		[SerializeField] // 0x00000001801D00E0-0x00000001801D0120
		private List<CreateControllerInfo> _startingCustomControllers; // 0x50
		[CustomObfuscation] // 0x00000001801D1070-0x00000001801D10B0
		[SerializeField] // 0x00000001801D1070-0x00000001801D10B0
		private bool _assignMouseOnStart; // 0x58
		[CustomObfuscation] // 0x00000001801D1070-0x00000001801D10B0
		[SerializeField] // 0x00000001801D1070-0x00000001801D10B0
		private bool _assignKeyboardOnStart; // 0x59
		[CustomObfuscation] // 0x00000001801D00E0-0x00000001801D0120
		[SerializeField] // 0x00000001801D00E0-0x00000001801D0120
		private bool _excludeFromControllerAutoAssignment; // 0x5A
		[CustomObfuscation] // 0x00000001801D1070-0x00000001801D10B0
		[SerializeField] // 0x00000001801D1070-0x00000001801D10B0
		private ControllerMapLayoutManagerSettings _controllerMapLayoutManagerSettings; // 0x60
		[CustomObfuscation] // 0x00000001801D00E0-0x00000001801D0120
		[SerializeField] // 0x00000001801D00E0-0x00000001801D0120
		private ControllerMapEnablerSettings _controllerMapEnablerSettings; // 0x68
	
		// Properties
		public int id { get; internal set; } // 0x0000000180387590-0x0000000180387930 0x00000001803FEB70-0x00000001803FEB80
		public string name { get; internal set; } // 0x0000000180372430-0x0000000180372440 0x0000000180379F30-0x0000000180379F40
		public string descriptiveName { get; internal set; } // 0x0000000180374AF0-0x0000000180374B00 0x00000001803F70C0-0x00000001803F70D0
		public bool startPlaying { get; internal set; } // 0x00000001804C6790-0x00000001804C67A0 0x00000001804D9980-0x00000001804D9990
		public List<Mapping> defaultJoystickMaps { get; internal set; } // 0x00000001803745C0-0x00000001803745D0 0x00000001803FA0A0-0x00000001803FA0B0
		public List<Mapping> defaultMouseMaps { get; internal set; } // 0x00000001803743D0-0x00000001803743E0 0x00000001803FEB60-0x00000001803FEB70
		public List<Mapping> defaultKeyboardMaps { get; internal set; } // 0x00000001803C7290-0x00000001803C72A0 0x00000001804CD6C0-0x00000001804CD6D0
		public List<Mapping> defaultCustomControllerMaps { get; internal set; } // 0x00000001803743E0-0x00000001803743F0 0x00000001804ADAE0-0x00000001804ADAF0
		public List<CreateControllerInfo> startingCustomControllers { get; internal set; } // 0x0000000180378320-0x0000000180378330 0x00000001803F7B90-0x00000001803F7BA0
		public bool assignMouseOnStart { get; internal set; } // 0x0000000180379F00-0x0000000180379F10 0x00000001805FC5A0-0x00000001805FC5B0
		public bool assignKeyboardOnStart { get; internal set; } // 0x00000001805FC570-0x00000001805FC580 0x00000001805FC590-0x00000001805FC5A0
		public bool excludeFromControllerAutoAssignment { get; internal set; } // 0x00000001805FC580-0x00000001805FC590 0x00000001805FC5B0-0x00000001805FC5C0
		public ControllerMapLayoutManagerSettings controllerMapLayoutManagerSettings { get; set; } // 0x0000000180418970-0x0000000180418980 0x00000001804AF510-0x00000001804AF520
		public ControllerMapEnablerSettings controllerMapEnablerSettings { get; set; } // 0x00000001803765E0-0x00000001803765F0 0x00000001804ADAC0-0x00000001804ADAD0
	
		// Nested types
		[Serializable]
		[Browsable] // 0x00000001801D4BF0-0x00000001801D4C30
		[EditorBrowsable] // 0x00000001801D4BF0-0x00000001801D4C30
		public sealed class Mapping // TypeDefIndex: 6418
		{
			// Fields
			[CustomObfuscation] // 0x00000001801D1070-0x00000001801D10B0
			[SerializeField] // 0x00000001801D1070-0x00000001801D10B0
			private bool _enabled; // 0x10
			[CustomObfuscation] // 0x00000001801D00E0-0x00000001801D0120
			[SerializeField] // 0x00000001801D00E0-0x00000001801D0120
			private int _categoryId; // 0x14
			[CustomObfuscation] // 0x00000001801D1070-0x00000001801D10B0
			[SerializeField] // 0x00000001801D1070-0x00000001801D10B0
			private int _layoutId; // 0x18
	
			// Properties
			public int categoryId { get; internal set; } // 0x00000001803FD2F0-0x00000001803FD300 0x00000001803FD620-0x00000001803FD630
			public int layoutId { get; internal set; } // 0x00000001803F46B0-0x00000001803F46C0 0x00000001803F46C0-0x00000001803F46D0
			public bool enabled { get; internal set; } // 0x00000001803FD450-0x00000001803FD460 0x00000001803FD630-0x00000001803FD640
	
			// Constructors
			public Mapping(); // 0x00000001805F3620-0x00000001805F3640
			public Mapping(bool enabled, int categoryId, int layoutId); // 0x00000001805F3640-0x00000001805F3690
	
			// Methods
			public void Clear(); // 0x00000001805F3510-0x00000001805F3520
			public Mapping Clone(); // 0x00000001805F3520-0x00000001805F35A0
			internal VazWCJszjSvmMxSvRJnnBczpVoI EehxeDwcaGcprdQyuinMghJJemBp(); // 0x00000001805F35A0-0x00000001805F3620
		}
	
		[Serializable]
		[Browsable] // 0x00000001801D4BF0-0x00000001801D4C30
		[EditorBrowsable] // 0x00000001801D4BF0-0x00000001801D4C30
		public sealed class ControllerMapLayoutManagerSettings : IDeepCloneable // TypeDefIndex: 6419
		{
			// Fields
			[CustomObfuscation] // 0x00000001801D00E0-0x00000001801D0120
			[SerializeField] // 0x00000001801D00E0-0x00000001801D0120
			private bool _enabled; // 0x10
			[CustomObfuscation] // 0x00000001801D1070-0x00000001801D10B0
			[SerializeField] // 0x00000001801D1070-0x00000001801D10B0
			private bool _loadFromUserDataStore; // 0x11
			[CustomObfuscation] // 0x00000001801D1070-0x00000001801D10B0
			[SerializeField] // 0x00000001801D1070-0x00000001801D10B0
			private List<RuleSetMapping> _ruleSets; // 0x18
	
			// Properties
			public bool enabled { get; set; } // 0x00000001803FD450-0x00000001803FD460 0x00000001803FD630-0x00000001803FD640
			public bool loadFromUserDataStore { get; set; } // 0x0000000180400120-0x0000000180400130 0x0000000180400130-0x0000000180400140
			public List<RuleSetMapping> ruleSets { get; set; } // 0x0000000180372430-0x0000000180372440 0x00000001805EDB40-0x00000001805EDBB0
	
			// Constructors
			public ControllerMapLayoutManagerSettings(); // 0x00000001805EDAD0-0x00000001805EDB40
			public ControllerMapLayoutManagerSettings(ControllerMapLayoutManagerSettings source); // 0x00000001805ED9E0-0x00000001805EDAD0
	
			// Methods
			internal ControllerMapLayoutManager.StartingSettings RvdvIxzowteyskgMeqDfHhJQQrH(); // 0x00000001805ED750-0x00000001805ED7E0
			private MoWpPnIELFeSQuddbxIWcvZmvTK[] YIwTfelsdOSBRQKqbgCqZTPYzQn(); // 0x00000001805ED7E0-0x00000001805ED9E0
			object IDeepCloneable.DeepClone(); // 0x00000001805ED640-0x00000001805ED750
		}
	
		[Serializable]
		[Browsable] // 0x00000001801D4BF0-0x00000001801D4C30
		[EditorBrowsable] // 0x00000001801D4BF0-0x00000001801D4C30
		public sealed class ControllerMapEnablerSettings : IDeepCloneable // TypeDefIndex: 6420
		{
			// Fields
			[CustomObfuscation] // 0x00000001801D1070-0x00000001801D10B0
			[SerializeField] // 0x00000001801D1070-0x00000001801D10B0
			private bool _enabled; // 0x10
			[CustomObfuscation] // 0x00000001801D1070-0x00000001801D10B0
			[SerializeField] // 0x00000001801D1070-0x00000001801D10B0
			private List<RuleSetMapping> _ruleSets; // 0x18
	
			// Properties
			public bool enabled { get; set; } // 0x00000001803FD450-0x00000001803FD460 0x00000001803FD630-0x00000001803FD640
			public List<RuleSetMapping> ruleSets { get; set; } // 0x0000000180372430-0x0000000180372440 0x00000001805ED5D0-0x00000001805ED640
	
			// Constructors
			public ControllerMapEnablerSettings(); // 0x00000001805ED560-0x00000001805ED5D0
			public ControllerMapEnablerSettings(ControllerMapEnablerSettings source); // 0x00000001805ED480-0x00000001805ED560
	
			// Methods
			internal ControllerMapEnabler.ZgESyvoCZDaaWJMTaxFmFrlTHlVN RvdvIxzowteyskgMeqDfHhJQQrH(); // 0x00000001805ED230-0x00000001805ED2B0
			private MoWpPnIELFeSQuddbxIWcvZmvTK[] YIwTfelsdOSBRQKqbgCqZTPYzQn(); // 0x00000001805ED2B0-0x00000001805ED480
			object IDeepCloneable.DeepClone(); // 0x00000001805ED120-0x00000001805ED230
		}
	
		[Serializable]
		[Browsable] // 0x00000001801D4BF0-0x00000001801D4C30
		[EditorBrowsable] // 0x00000001801D4BF0-0x00000001801D4C30
		public sealed class RuleSetMapping : IDeepCloneable // TypeDefIndex: 6421
		{
			// Fields
			[CustomObfuscation] // 0x00000001801D00E0-0x00000001801D0120
			[SerializeField] // 0x00000001801D00E0-0x00000001801D0120
			private bool _enabled; // 0x10
			[CustomObfuscation] // 0x00000001801D00E0-0x00000001801D0120
			[SerializeField] // 0x00000001801D00E0-0x00000001801D0120
			private int _id; // 0x14
	
			// Properties
			public int id { get; internal set; } // 0x00000001803FD2F0-0x00000001803FD300 0x00000001803FD620-0x00000001803FD630
			public bool enabled { get; internal set; } // 0x00000001803FD450-0x00000001803FD460 0x00000001803FD630-0x00000001803FD640
	
			// Constructors
			public RuleSetMapping(); // 0x00000001805FC800-0x00000001805FC830
			public RuleSetMapping(RuleSetMapping source); // 0x00000001805FC740-0x00000001805FC800
			public RuleSetMapping(bool enabled, int id); // 0x00000001805FC830-0x00000001805FC870
	
			// Methods
			public void Clear(); // 0x00000001805FC5C0-0x00000001805FC5D0
			public RuleSetMapping Clone(); // 0x00000001805FC5D0-0x00000001805FC640
			internal MoWpPnIELFeSQuddbxIWcvZmvTK lGlqqLKpgWtHsjamVbzJIaKUfzy(); // 0x00000001805FC870-0x00000001805FC8E0
			object IDeepCloneable.DeepClone(); // 0x00000001805FC640-0x00000001805FC740
		}
	
		[Serializable]
		[Browsable] // 0x00000001801D4BF0-0x00000001801D4C30
		[EditorBrowsable] // 0x00000001801D4BF0-0x00000001801D4C30
		public sealed class CreateControllerInfo // TypeDefIndex: 6422
		{
			// Fields
			[CustomObfuscation] // 0x00000001801D00E0-0x00000001801D0120
			[SerializeField] // 0x00000001801D00E0-0x00000001801D0120
			private int _sourceId; // 0x10
			[CustomObfuscation] // 0x00000001801D00E0-0x00000001801D0120
			[SerializeField] // 0x00000001801D00E0-0x00000001801D0120
			private string _tag; // 0x18
	
			// Properties
			public int sourceId { get; internal set; } // 0x0000000180387590-0x0000000180387930 0x00000001803FEB70-0x00000001803FEB80
			public string tag { get; internal set; } // 0x0000000180372430-0x0000000180372440 0x0000000180379F30-0x0000000180379F40
	
			// Constructors
			public CreateControllerInfo(); // 0x0000000180373240-0x0000000180373250
			public CreateControllerInfo(int sourceId, string tag); // 0x0000000180568A80-0x0000000180568AC0
			public CreateControllerInfo(CreateControllerInfo source); // 0x00000001805EDBB0-0x00000001805EDBF0
		}
	
		// Constructors
		public Player_Editor(); // 0x00000001805FBBD0-0x00000001805FBE20
		public Player_Editor(Player_Editor source); // 0x00000001805FBE20-0x00000001805FC570
	
		// Methods
		public Player_Editor Clone(); // 0x00000001805FB360-0x00000001805FB3C0
		internal VVLouGbEKulMPcFZiTUTqikUjEp EpfIttlsNHKfwEcDxUNaegzLSWO(); // 0x00000001805FB3C0-0x00000001805FBBD0
	}
}
