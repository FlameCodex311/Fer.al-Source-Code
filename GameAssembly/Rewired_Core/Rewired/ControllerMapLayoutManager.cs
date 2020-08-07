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
using Rewired.Utils.Attributes;
using Rewired.Utils.Classes.Data;
using Rewired.Utils.Interfaces;
using Rewired.Utils.Libraries.TinyJson;
using UnityEngine;

// Image 51: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5871-7113

namespace Rewired
{
	public sealed class ControllerMapLayoutManager // TypeDefIndex: 6655
	{
		// Fields
		private bool _enabled; // 0x10
		private bool _loadFromUserDataStore; // 0x11
		private Player _player; // 0x18
		private StartingSettings _startingSettings; // 0x20
		private readonly int _reInputId; // 0x28
		private List<RuleSet> _ruleSets; // 0x30
		private Action _ApplyCalledEvent; // 0x38
	
		// Properties
		public bool enabled { get; set; } // 0x00000001803FD450-0x00000001803FD460 0x000000018149DB40-0x000000018149DB90
		public bool loadFromUserDataStore { get; set; } // 0x0000000180400120-0x0000000180400130 0x0000000180400130-0x0000000180400140
		public List<RuleSet> ruleSets { get; set; } // 0x00000001803745C0-0x00000001803745D0 0x000000018149DB90-0x000000018149DC20
	
		// Events
		internal event Action ApplyCalledEvent {
			add; // 0x000000018149DA40-0x000000018149DAC0
			remove; // 0x000000018149DAC0-0x000000018149DB40
		}
	
		// Nested types
		internal class StartingSettings // TypeDefIndex: 6656
		{
			// Fields
			public bool enabled; // 0x10
			public bool loadFromUserDataStore; // 0x11
			public MoWpPnIELFeSQuddbxIWcvZmvTK[] startingRuleSets; // 0x18
	
			// Constructors
			public StartingSettings(bool enabled, bool loadFromUserDataStore, MoWpPnIELFeSQuddbxIWcvZmvTK[] startingRuleSets); // 0x00000001814B10D0-0x00000001814B1120
		}
	
		[Serializable]
		[CustomClassObfuscation] // 0x000000018020E0F0-0x000000018020E130
		[Preserve] // 0x000000018020E0F0-0x000000018020E130
		public sealed class Rule : IDeepCloneable // TypeDefIndex: 6657
		{
			// Fields
			[Serialize] // 0x000000018020E3C0-0x000000018020E410
			[SerializeField] // 0x000000018020E3C0-0x000000018020E410
			private string _tag; // 0x10
			[Serialize] // 0x000000018020FC50-0x000000018020FCA0
			[SerializeField] // 0x000000018020FC50-0x000000018020FCA0
			private int[] _categoryIds; // 0x18
			[Serialize] // 0x0000000180214490-0x00000001802144E0
			[SerializeField] // 0x0000000180214490-0x00000001802144E0
			private int _layoutId; // 0x20
			[Serialize] // 0x0000000180210500-0x0000000180210550
			[SerializeField] // 0x0000000180210500-0x0000000180210550
			private ControllerSetSelector _controllerSetSelector; // 0x28
			[NonSerialized]
			private string[] _preInitCategoryNames; // 0x30
			[NonSerialized]
			private string _preInitLayoutName; // 0x38
	
			// Properties
			public string tag { get; set; } // 0x0000000180372440-0x0000000180372450 0x0000000180379F20-0x0000000180379F30
			public ControllerSetSelector controllerSetSelector { get; set; } // 0x00000001814AE360-0x00000001814AE3F0 0x00000001814B0120-0x00000001814B0310
			public int categoryId { get; set; } // 0x00000001814AD980-0x00000001814ADA30 0x00000001814AF290-0x00000001814AF3B0
			public int[] categoryIds { get; set; } // 0x00000001814ADA80-0x00000001814ADAD0 0x00000001814AF420-0x00000001814AF4A0
			public int layoutId { get; set; } // 0x00000001814AEAD0-0x00000001814AEAF0 0x00000001814B04C0-0x00000001814B0510
			public string categoryName { get; set; } // 0x00000001814ADCC0-0x00000001814ADE70 0x00000001814AF4A0-0x00000001814AF700
			public string[] categoryNames { get; set; } // 0x00000001814AE110-0x00000001814AE360 0x00000001814AFDA0-0x00000001814B0120
			public string layoutName { get; set; } // 0x00000001814AED90-0x00000001814AEED0 0x00000001814B0960-0x00000001814B0D30
			internal bool isValid { get; } // 0x00000001814AE7D0-0x00000001814AEA30 
	
			// Constructors
			public Rule(); // 0x00000001814AD550-0x00000001814AD5F0
			public Rule(Rule source); // 0x00000001814AD5F0-0x00000001814AD6F0
			internal Rule(string tag, int[] categoryIds, int layoutId, ControllerSetSelector controllerSetSelector); // 0x00000001814AD4D0-0x00000001814AD550
	
			// Methods
			private void Initialize(); // 0x00000001814AC6D0-0x00000001814ACAA0
			object IDeepCloneable.DeepClone(); // 0x00000001814AD340-0x00000001814AD470
		}
	
		[Serializable]
		[CustomClassObfuscation] // 0x0000000180214A10-0x0000000180214A90
		[Preserve] // 0x0000000180214A10-0x0000000180214A90
		[SerializationType] // 0x0000000180214A10-0x0000000180214A90
		public sealed class RuleSet : IDeepCloneable, IList<Rule> // TypeDefIndex: 6658
		{
			// Fields
			private const string className = "ControllerMapLayoutManager.RuleSet"; // Metadata: 0x00764E0B
			[Serialize] // 0x0000000180210C60-0x0000000180210CA0
			[SerializeField] // 0x0000000180210C60-0x0000000180210CA0
			private bool _enabled; // 0x10
			[Serialize] // 0x0000000180210E00-0x0000000180210E40
			[SerializeField] // 0x0000000180210E00-0x0000000180210E40
			private string _tag; // 0x18
			[Serialize] // 0x0000000180210F90-0x0000000180210FD0
			[SerializeField] // 0x0000000180210F90-0x0000000180210FD0
			private List<Rule> _rules; // 0x20
	
			// Properties
			public bool enabled { get; set; } // 0x00000001803FD450-0x00000001803FD460 0x00000001803FD630-0x00000001803FD640
			public string tag { get; set; } // 0x0000000180372430-0x0000000180372440 0x0000000180379F30-0x0000000180379F40
			public List<Rule> rules { get; set; } // 0x0000000180374AF0-0x0000000180374B00 0x00000001814AC330-0x00000001814AC3A0
			public Rule this[int index] { get => default; set {} } // 0x00000001814AC0D0-0x00000001814AC180 0x00000001814AC280-0x00000001814AC330
			public int Count { get; } // 0x00000001814AC030-0x00000001814AC0D0 
			bool System.Collections.Generic.ICollection<Rewired.ControllerMapLayoutManager.Rule>.IsReadOnly { get; } // 0x00000001814AB900-0x00000001814AB9A0 
	
			// Constructors
			internal RuleSet(bool enabled, string tag, List<Rule> rules); // 0x00000001814ABC90-0x00000001814ABD60
			public RuleSet(); // 0x00000001814ABE60-0x00000001814ABED0
			public RuleSet(RuleSet source); // 0x00000001814ABED0-0x00000001814ABFE0
	
			// Methods
			public Rule Find(Predicate<Rule> predicate); // 0x00000001814AAE70-0x00000001814AB030
			public Rule FindLast(Predicate<Rule> predicate); // 0x00000001814AA980-0x00000001814AAB10
			public int FindIndex(Predicate<Rule> predicate); // 0x00000001814AA2F0-0x00000001814AA480
			public int FindLastIndex(Predicate<Rule> predicate); // 0x00000001814AA7E0-0x00000001814AA980
			public int IndexOf(Rule item); // 0x00000001814AB180-0x00000001814AB220
			public void Insert(int index, Rule item); // 0x00000001814AB2E0-0x00000001814AB390
			public void RemoveAt(int index); // 0x00000001814AB3F0-0x00000001814AB490
			public void Add(Rule item); // 0x00000001814A9DD0-0x00000001814A9E80
			public void Clear(); // 0x00000001814AA010-0x00000001814AA0B0
			public bool Contains(Rule item); // 0x00000001814AA0B0-0x00000001814AA160
			public void CopyTo(Rule[] array, int arrayIndex); // 0x00000001814AA1C0-0x00000001814AA280
			public bool Remove(Rule item); // 0x00000001814AB490-0x00000001814AB540
			public IEnumerator<Rule> GetEnumerator(); // 0x00000001814AB0B0-0x00000001814AB180
			IEnumerator IEnumerable.GetEnumerator(); // 0x00000001814AB9A0-0x00000001814ABA70
			object IDeepCloneable.DeepClone(); // 0x00000001814AB770-0x00000001814AB8A0
			private void CheckList(); // 0x00000001814A9F60-0x00000001814A9FC0
		}
	
		// Constructors
		internal ControllerMapLayoutManager(Player player, StartingSettings startingSettings); // 0x000000018149D950-0x000000018149DA40
	
		// Methods
		public void Apply(); // 0x000000018149B900-0x000000018149C8C0
		public void LoadDefaults(); // 0x000000018149D2E0-0x000000018149D5D0
		public string ToXmlString(); // 0x000000018149D7C0-0x000000018149D950
		public string ToJsonString(); // 0x000000018149D5D0-0x000000018149D7C0
		public bool ImportXml(string xmlString); // 0x000000018149D010-0x000000018149D1E0
		public bool ImportJson(string jsonString); // 0x000000018149CE80-0x000000018149D010
		private SerializedObject Export(); // 0x000000018149CE00-0x000000018149CE80
		private void ExportDataToSerializedObject(SerializedObject serializedObject); // 0x000000018149C8C0-0x000000018149CE00
		private bool Import(SerializedObject serializedObject); // 0x000000018149D1E0-0x000000018149D2E0
	}
}
