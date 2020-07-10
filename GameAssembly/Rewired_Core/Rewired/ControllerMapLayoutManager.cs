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

// Image 50: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5712-6954

namespace Rewired
{
	public sealed class ControllerMapLayoutManager // TypeDefIndex: 6496
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
		public bool enabled { get; set; } // 0x0000000180375540-0x0000000180375550 0x00000001809FE5C0-0x00000001809FE610
		public bool loadFromUserDataStore { get; set; } // 0x0000000180375550-0x0000000180375560 0x0000000180393640-0x0000000180393650
		public List<RuleSet> ruleSets { get; set; } // 0x0000000180397720-0x0000000180397730 0x00000001809FE610-0x00000001809FE6A0
	
		// Events
		internal event Action ApplyCalledEvent {
			add; // 0x00000001809FE4C0-0x00000001809FE540
			remove; // 0x00000001809FE540-0x00000001809FE5C0
		}
	
		// Nested types
		internal class StartingSettings // TypeDefIndex: 6497
		{
			// Fields
			public bool enabled; // 0x10
			public bool loadFromUserDataStore; // 0x11
			public MoWpPnIELFeSQuddbxIWcvZmvTK[] startingRuleSets; // 0x18
	
			// Constructors
			public StartingSettings(bool enabled, bool loadFromUserDataStore, MoWpPnIELFeSQuddbxIWcvZmvTK[] startingRuleSets); // 0x0000000180A11DD0-0x0000000180A11E20
		}
	
		[Serializable]
		[CustomClassObfuscation] // 0x000000018016F680-0x000000018016F6C0
		[Preserve] // 0x000000018016F680-0x000000018016F6C0
		public sealed class Rule : IDeepCloneable // TypeDefIndex: 6498
		{
			// Fields
			[Serialize] // 0x000000018016FAC0-0x000000018016FB10
			[SerializeField] // 0x000000018016FAC0-0x000000018016FB10
			private string _tag; // 0x10
			[Serialize] // 0x00000001801701C0-0x0000000180170210
			[SerializeField] // 0x00000001801701C0-0x0000000180170210
			private int[] _categoryIds; // 0x18
			[Serialize] // 0x0000000180174EB0-0x0000000180174F00
			[SerializeField] // 0x0000000180174EB0-0x0000000180174F00
			private int _layoutId; // 0x20
			[Serialize] // 0x0000000180170730-0x0000000180170780
			[SerializeField] // 0x0000000180170730-0x0000000180170780
			private ControllerSetSelector _controllerSetSelector; // 0x28
			[NonSerialized]
			private string[] _preInitCategoryNames; // 0x30
			[NonSerialized]
			private string _preInitLayoutName; // 0x38
	
			// Properties
			public string tag { get; set; } // 0x000000018036AC80-0x000000018036AC90 0x000000018036B1E0-0x000000018036B1F0
			public ControllerSetSelector controllerSetSelector { get; set; } // 0x0000000180A0EF60-0x0000000180A0EFF0 0x0000000180A10DB0-0x0000000180A10FB0
			public int categoryId { get; set; } // 0x0000000180A0E520-0x0000000180A0E5E0 0x0000000180A0FED0-0x0000000180A0FFF0
			public int[] categoryIds { get; set; } // 0x0000000180A0E630-0x0000000180A0E680 0x0000000180A10060-0x0000000180A100E0
			public int layoutId { get; set; } // 0x0000000180A0F6F0-0x0000000180A0F710 0x0000000180A11170-0x0000000180A111C0
			public string categoryName { get; set; } // 0x0000000180A0E880-0x0000000180A0EA40 0x0000000180A100E0-0x0000000180A10350
			public string[] categoryNames { get; set; } // 0x0000000180A0ECF0-0x0000000180A0EF60 0x0000000180A10A20-0x0000000180A10DB0
			public string layoutName { get; set; } // 0x0000000180A0F9C0-0x0000000180A0FB00 0x0000000180A11620-0x0000000180A11A10
			internal bool isValid { get; } // 0x0000000180A0F3E0-0x0000000180A0F650 
	
			// Constructors
			public Rule(); // 0x0000000180A0E0F0-0x0000000180A0E190
			public Rule(Rule source); // 0x0000000180A0E190-0x0000000180A0E290
			internal Rule(string tag, int[] categoryIds, int layoutId, ControllerSetSelector controllerSetSelector); // 0x0000000180A0E070-0x0000000180A0E0F0
	
			// Methods
			private void Initialize(); // 0x0000000180A0D220-0x0000000180A0D610
			object IDeepCloneable.DeepClone(); // 0x0000000180A0DEE0-0x0000000180A0E010
		}
	
		[Serializable]
		[CustomClassObfuscation] // 0x0000000180175520-0x00000001801755A0
		[Preserve] // 0x0000000180175520-0x00000001801755A0
		[SerializationType] // 0x0000000180175520-0x00000001801755A0
		public sealed class RuleSet : IDeepCloneable, IList<Rule> // TypeDefIndex: 6499
		{
			// Fields
			private const string className = "ControllerMapLayoutManager.RuleSet"; // Metadata: 0x0073016E
			[Serialize] // 0x00000001801710B0-0x00000001801710F0
			[SerializeField] // 0x00000001801710B0-0x00000001801710F0
			private bool _enabled; // 0x10
			[Serialize] // 0x00000001800B39D0-0x00000001800B3A10
			[SerializeField] // 0x00000001800B39D0-0x00000001800B3A10
			private string _tag; // 0x18
			[Serialize] // 0x00000001800B3C70-0x00000001800B3CB0
			[SerializeField] // 0x00000001800B3C70-0x00000001800B3CB0
			private List<Rule> _rules; // 0x20
	
			// Properties
			public bool enabled { get; set; } // 0x0000000180375540-0x0000000180375550 0x00000001803930B0-0x00000001803930C0
			public string tag { get; set; } // 0x000000018038B150-0x000000018038B160 0x000000018038B160-0x000000018038B170
			public List<Rule> rules { get; set; } // 0x000000018036AC70-0x000000018036AC80 0x0000000180A0CE50-0x0000000180A0CEC0
			public Rule this[int index] { get => default; set {} } // 0x0000000180A0CBF0-0x0000000180A0CCA0 0x0000000180A0CDA0-0x0000000180A0CE50
			public int Count { get; } // 0x0000000180A0CB50-0x0000000180A0CBF0 
			bool System.Collections.Generic.ICollection<Rewired.ControllerMapLayoutManager.Rule>.IsReadOnly { get; } // 0x0000000180A0C410-0x0000000180A0C4B0 
	
			// Constructors
			internal RuleSet(bool enabled, string tag, List<Rule> rules); // 0x0000000180A0C7B0-0x0000000180A0C880
			public RuleSet(); // 0x0000000180A0C980-0x0000000180A0C9F0
			public RuleSet(RuleSet source); // 0x0000000180A0C9F0-0x0000000180A0CB00
	
			// Methods
			public Rule Find(Predicate<Rule> predicate); // 0x0000000180A0B970-0x0000000180A0BB40
			public Rule FindLast(Predicate<Rule> predicate); // 0x0000000180A0B470-0x0000000180A0B610
			public int FindIndex(Predicate<Rule> predicate); // 0x0000000180A0ADB0-0x0000000180A0AF50
			public int FindLastIndex(Predicate<Rule> predicate); // 0x0000000180A0B2D0-0x0000000180A0B470
			public int IndexOf(Rule item); // 0x0000000180A0BC90-0x0000000180A0BD30
			public void Insert(int index, Rule item); // 0x0000000180A0BDF0-0x0000000180A0BEA0
			public void RemoveAt(int index); // 0x0000000180A0BF00-0x0000000180A0BFA0
			public void Add(Rule item); // 0x0000000180A0A890-0x0000000180A0A940
			public void Clear(); // 0x0000000180A0AAD0-0x0000000180A0AB70
			public bool Contains(Rule item); // 0x0000000180A0AB70-0x0000000180A0AC20
			public void CopyTo(Rule[] array, int arrayIndex); // 0x0000000180A0AC80-0x0000000180A0AD40
			public bool Remove(Rule item); // 0x0000000180A0BFA0-0x0000000180A0C050
			public IEnumerator<Rule> GetEnumerator(); // 0x0000000180A0BBC0-0x0000000180A0BC90
			IEnumerator IEnumerable.GetEnumerator(); // 0x0000000180A0C4B0-0x0000000180A0C580
			object IDeepCloneable.DeepClone(); // 0x0000000180A0C280-0x0000000180A0C3B0
			private void CheckList(); // 0x0000000180A0AA20-0x0000000180A0AA80
		}
	
		// Constructors
		internal ControllerMapLayoutManager(Player player, StartingSettings startingSettings); // 0x00000001809FE3C0-0x00000001809FE4C0
	
		// Methods
		public void Apply(); // 0x00000001809FC2B0-0x00000001809FD2D0
		public void LoadDefaults(); // 0x00000001809FDD40-0x00000001809FE040
		public string ToXmlString(); // 0x00000001809FE230-0x00000001809FE3C0
		public string ToJsonString(); // 0x00000001809FE040-0x00000001809FE230
		public bool ImportXml(string xmlString); // 0x00000001809FDA60-0x00000001809FDC40
		public bool ImportJson(string jsonString); // 0x00000001809FD8D0-0x00000001809FDA60
		private SerializedObject Export(); // 0x00000001809FD850-0x00000001809FD8D0
		private void ExportDataToSerializedObject(SerializedObject serializedObject); // 0x00000001809FD2D0-0x00000001809FD850
		private bool Import(SerializedObject serializedObject); // 0x00000001809FDC40-0x00000001809FDD40
	}
}
