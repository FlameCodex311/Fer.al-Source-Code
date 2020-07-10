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
	public sealed class ControllerMapEnabler // TypeDefIndex: 6490
	{
		// Fields
		private bool RYgMGyqWnNNUOzFUBDIFjvchsBxb; // 0x10
		private Player ynTKxtAzNzOSGMpUVXFSwhkyvv; // 0x18
		private ZgESyvoCZDaaWJMTaxFmFrlTHlVN miqBKqhkUThElnqKkeIwpdnWqLmc; // 0x20
		private readonly int vSShldFHkaZKEuThltrSgFmPfc; // 0x28
		private List<RuleSet> nMpueEaWTJqSZWcblEgxDXnPgpDS; // 0x30
	
		// Properties
		public bool enabled { get; set; } // 0x0000000180375540-0x0000000180375550 0x00000001809FC1C0-0x00000001809FC1D0
		public List<RuleSet> ruleSets { get; set; } // 0x0000000180397720-0x0000000180397730 0x00000001809FC1D0-0x00000001809FC230
	
		// Nested types
		[Serializable]
		[CustomClassObfuscation] // 0x000000018016F680-0x000000018016F6C0
		[Preserve] // 0x000000018016F680-0x000000018016F6C0
		public sealed class Rule : IDeepCloneable // TypeDefIndex: 6491
		{
			// Fields
			[Serialize] // 0x000000018016FAC0-0x000000018016FB10
			[SerializeField] // 0x000000018016FAC0-0x000000018016FB10
			private string _tag; // 0x10
			[Serialize] // 0x000000018016FDD0-0x000000018016FE10
			[SerializeField] // 0x000000018016FDD0-0x000000018016FE10
			private bool _enable; // 0x18
			[Serialize] // 0x00000001801701C0-0x0000000180170210
			[SerializeField] // 0x00000001801701C0-0x0000000180170210
			private int[] _categoryIds; // 0x20
			[Serialize] // 0x00000001801703D0-0x0000000180170410
			[SerializeField] // 0x00000001801703D0-0x0000000180170410
			private int[] _layoutIds; // 0x28
			[Serialize] // 0x0000000180170730-0x0000000180170780
			[SerializeField] // 0x0000000180170730-0x0000000180170780
			private ControllerSetSelector _controllerSetSelector; // 0x30
			[NonSerialized]
			private string[] _preInitCategoryNames; // 0x38
			[NonSerialized]
			private string[] _preInitLayoutNames; // 0x40
	
			// Properties
			internal bool appliesToAllLayouts { get; } // 0x0000000180A0E460-0x0000000180A0E480 
			public string tag { get; set; } // 0x000000018036AC80-0x000000018036AC90 0x000000018036B1E0-0x000000018036B1F0
			public bool enable { get; set; } // 0x000000018041BAC0-0x000000018041BAD0 0x000000018048F590-0x000000018048F5A0
			public ControllerSetSelector controllerSetSelector { get; set; } // 0x0000000180A0EFF0-0x0000000180A0F080 0x0000000180A10FB0-0x0000000180A11040
			public int[] categoryIds { get; set; } // 0x0000000180A0E5E0-0x0000000180A0E630 0x0000000180A0FFF0-0x0000000180A10060
			public int[] layoutIds { get; set; } // 0x0000000180A0F710-0x0000000180A0F760 0x0000000180A111C0-0x0000000180A11270
			public int categoryId { get; set; } // 0x0000000180A0E480-0x0000000180A0E520 0x0000000180A0FDC0-0x0000000180A0FED0
			public int layoutId { get; set; } // 0x0000000180A0F650-0x0000000180A0F6F0 0x0000000180A11040-0x0000000180A11170
			public string[] categoryNames { get; set; } // 0x0000000180A0EA40-0x0000000180A0ECF0 0x0000000180A10680-0x0000000180A10A20
			public string[] layoutNames { get; set; } // 0x0000000180A0FB00-0x0000000180A0FDC0 0x0000000180A11A10-0x0000000180A11DD0
			public string categoryName { get; set; } // 0x0000000180A0E680-0x0000000180A0E880 0x0000000180A10350-0x0000000180A10680
			public string layoutName { get; set; } // 0x0000000180A0F760-0x0000000180A0F9C0 0x0000000180A11270-0x0000000180A11620
			internal bool isValid { get; } // 0x0000000180A0F080-0x0000000180A0F3E0 
	
			// Constructors
			public Rule(); // 0x0000000180A0E3B0-0x0000000180A0E460
			public Rule(Rule source); // 0x0000000180A0E290-0x0000000180A0E3B0
			internal Rule(string tag, bool enabled, int[] categoryIds, int[] layoutIds, ControllerSetSelector controllerSetSelector); // 0x0000000180A0E010-0x0000000180A0E070
	
			// Methods
			internal bool Matches(ControllerMap map); // 0x0000000180A0DC00-0x0000000180A0DD90
			private void Initialize(); // 0x0000000180A0D610-0x0000000180A0DC00
			private void CheckNoControllerTypeError(); // 0x0000000180A0CED0-0x0000000180A0D220
			object IDeepCloneable.DeepClone(); // 0x0000000180A0DD90-0x0000000180A0DEE0
		}
	
		[Serializable]
		[CustomClassObfuscation] // 0x0000000180170D20-0x0000000180170DA0
		[Preserve] // 0x0000000180170D20-0x0000000180170DA0
		[SerializationType] // 0x0000000180170D20-0x0000000180170DA0
		public sealed class RuleSet : IDeepCloneable, IList<Rule> // TypeDefIndex: 6492
		{
			// Fields
			private const string className = "ControllerMapEnabler.RuleSet"; // Metadata: 0x0073014E
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
			public List<Rule> rules { get; set; } // 0x000000018036AC70-0x000000018036AC80 0x0000000180A0CEC0-0x0000000180A0CED0
			public Rule this[int index] { get => default; set {} } // 0x0000000180A0CCA0-0x0000000180A0CD10 0x0000000180A0CD10-0x0000000180A0CDA0
			public int Count { get; } // 0x0000000180A0CB00-0x0000000180A0CB50 
			bool System.Collections.Generic.ICollection<Rewired.ControllerMapEnabler.Rule>.IsReadOnly { get; } // 0x0000000180A0C3B0-0x0000000180A0C410 
	
			// Constructors
			internal RuleSet(bool enabled, string tag, List<Rule> rules); // 0x0000000180A0C880-0x0000000180A0C910
			public RuleSet(); // 0x0000000180A0C910-0x0000000180A0C980
			public RuleSet(RuleSet source); // 0x0000000180A0C600-0x0000000180A0C7B0
	
			// Methods
			public Rule Find(Predicate<Rule> predicate); // 0x0000000180A0B7D0-0x0000000180A0B970
			public Rule FindLast(Predicate<Rule> predicate); // 0x0000000180A0B610-0x0000000180A0B7D0
			public int FindIndex(Predicate<Rule> predicate); // 0x0000000180A0AF50-0x0000000180A0B0F0
			public int FindLastIndex(Predicate<Rule> predicate); // 0x0000000180A0B0F0-0x0000000180A0B2D0
			public int IndexOf(Rule item); // 0x0000000180A0BD30-0x0000000180A0BD80
			public void Insert(int index, Rule item); // 0x0000000180A0BD80-0x0000000180A0BDF0
			public void RemoveAt(int index); // 0x0000000180A0BEA0-0x0000000180A0BF00
			public void Add(Rule item); // 0x0000000180A0A940-0x0000000180A0A9A0
			public void Clear(); // 0x0000000180A0AA80-0x0000000180A0AAD0
			public bool Contains(Rule item); // 0x0000000180A0AC20-0x0000000180A0AC80
			public void CopyTo(Rule[] array, int arrayIndex); // 0x0000000180A0AD40-0x0000000180A0ADB0
			public bool Remove(Rule item); // 0x0000000180A0C050-0x0000000180A0C0B0
			public IEnumerator<Rule> GetEnumerator(); // 0x0000000180A0BB40-0x0000000180A0BBC0
			IEnumerator IEnumerable.GetEnumerator(); // 0x0000000180A0C580-0x0000000180A0C600
			object IDeepCloneable.DeepClone(); // 0x0000000180A0C0B0-0x0000000180A0C280
			private void CheckList(); // 0x0000000180A0A9A0-0x0000000180A0AA20
		}
	
		internal class ZgESyvoCZDaaWJMTaxFmFrlTHlVN // TypeDefIndex: 6493
		{
			// Fields
			public bool XCmLqGiIjecniTtyESDfezXWsFX; // 0x10
			public MoWpPnIELFeSQuddbxIWcvZmvTK[] PRilaMdORVIUTsbFhylqHYDEvLm; // 0x18
	
			// Constructors
			public ZgESyvoCZDaaWJMTaxFmFrlTHlVN(bool enabled, MoWpPnIELFeSQuddbxIWcvZmvTK[] startingRuleSets); // 0x0000000180A125B0-0x0000000180A125F0
		}
	
		// Constructors
		internal ControllerMapEnabler(Player player, ZgESyvoCZDaaWJMTaxFmFrlTHlVN startingSettings); // 0x00000001809FC040-0x00000001809FC1C0
	
		// Methods
		public void Apply(); // 0x00000001809FA920-0x00000001809FB020
		public void LoadDefaults(); // 0x00000001809FB460-0x00000001809FB740
		public string ToXmlString(); // 0x00000001809FBEB0-0x00000001809FC040
		public string ToJsonString(); // 0x00000001809FBD20-0x00000001809FBEB0
		public bool ImportXml(string xmlString); // 0x00000001809FB2A0-0x00000001809FB460
		public bool ImportJson(string jsonString); // 0x00000001809FB0E0-0x00000001809FB2A0
		private SerializedObject uJZpqEBLkJUYeZxXRkMWiNxeekH(); // 0x00000001809FC230-0x00000001809FC2B0
		private void RKMnWkLYIShhsCAJrbDGpkKewIS(SerializedObject param_0000d842); // 0x00000001809FB740-0x00000001809FBD20
		private bool BxoFMvWmvalDyQMZPpCVmdbosOa(SerializedObject param_0000d843); // 0x00000001809FB020-0x00000001809FB0E0
	}
}
