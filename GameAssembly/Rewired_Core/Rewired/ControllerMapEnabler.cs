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
	public sealed class ControllerMapEnabler // TypeDefIndex: 6649
	{
		// Fields
		private bool RYgMGyqWnNNUOzFUBDIFjvchsBxb; // 0x10
		private Player ynTKxtAzNzOSGMpUVXFSwhkyvv; // 0x18
		private ZgESyvoCZDaaWJMTaxFmFrlTHlVN miqBKqhkUThElnqKkeIwpdnWqLmc; // 0x20
		private readonly int vSShldFHkaZKEuThltrSgFmPfc; // 0x28
		private List<RuleSet> nMpueEaWTJqSZWcblEgxDXnPgpDS; // 0x30
	
		// Properties
		public bool enabled { get; set; } // 0x00000001803FD450-0x00000001803FD460 0x000000018149B810-0x000000018149B820
		public List<RuleSet> ruleSets { get; set; } // 0x00000001803745C0-0x00000001803745D0 0x000000018149B820-0x000000018149B880
	
		// Nested types
		[Serializable]
		[CustomClassObfuscation] // 0x000000018020E0F0-0x000000018020E130
		[Preserve] // 0x000000018020E0F0-0x000000018020E130
		public sealed class Rule : IDeepCloneable // TypeDefIndex: 6650
		{
			// Fields
			[Serialize] // 0x000000018020E3C0-0x000000018020E410
			[SerializeField] // 0x000000018020E3C0-0x000000018020E410
			private string _tag; // 0x10
			[Serialize] // 0x000000018020E740-0x000000018020E780
			[SerializeField] // 0x000000018020E740-0x000000018020E780
			private bool _enable; // 0x18
			[Serialize] // 0x000000018020FC50-0x000000018020FCA0
			[SerializeField] // 0x000000018020FC50-0x000000018020FCA0
			private int[] _categoryIds; // 0x20
			[Serialize] // 0x0000000180210170-0x00000001802101B0
			[SerializeField] // 0x0000000180210170-0x00000001802101B0
			private int[] _layoutIds; // 0x28
			[Serialize] // 0x0000000180210500-0x0000000180210550
			[SerializeField] // 0x0000000180210500-0x0000000180210550
			private ControllerSetSelector _controllerSetSelector; // 0x30
			[NonSerialized]
			private string[] _preInitCategoryNames; // 0x38
			[NonSerialized]
			private string[] _preInitLayoutNames; // 0x40
	
			// Properties
			internal bool appliesToAllLayouts { get; } // 0x00000001814AD8C0-0x00000001814AD8E0 
			public string tag { get; set; } // 0x0000000180372440-0x0000000180372450 0x0000000180379F20-0x0000000180379F30
			public bool enable { get; set; } // 0x00000001803F6D30-0x00000001803F6D40 0x00000001803F6D40-0x00000001803F6D50
			public ControllerSetSelector controllerSetSelector { get; set; } // 0x00000001814AE3F0-0x00000001814AE480 0x00000001814B0310-0x00000001814B03A0
			public int[] categoryIds { get; set; } // 0x00000001814ADA30-0x00000001814ADA80 0x00000001814AF3B0-0x00000001814AF420
			public int[] layoutIds { get; set; } // 0x00000001814AEAF0-0x00000001814AEB40 0x00000001814B0510-0x00000001814B05C0
			public int categoryId { get; set; } // 0x00000001814AD8E0-0x00000001814AD980 0x00000001814AF180-0x00000001814AF290
			public int layoutId { get; set; } // 0x00000001814AEA30-0x00000001814AEAD0 0x00000001814B03A0-0x00000001814B04C0
			public string[] categoryNames { get; set; } // 0x00000001814ADE70-0x00000001814AE110 0x00000001814AFA20-0x00000001814AFDA0
			public string[] layoutNames { get; set; } // 0x00000001814AEED0-0x00000001814AF180 0x00000001814B0D30-0x00000001814B10D0
			public string categoryName { get; set; } // 0x00000001814ADAD0-0x00000001814ADCC0 0x00000001814AF700-0x00000001814AFA20
			public string layoutName { get; set; } // 0x00000001814AEB40-0x00000001814AED90 0x00000001814B05C0-0x00000001814B0960
			internal bool isValid { get; } // 0x00000001814AE480-0x00000001814AE7D0 
	
			// Constructors
			public Rule(); // 0x00000001814AD810-0x00000001814AD8C0
			public Rule(Rule source); // 0x00000001814AD6F0-0x00000001814AD810
			internal Rule(string tag, bool enabled, int[] categoryIds, int[] layoutIds, ControllerSetSelector controllerSetSelector); // 0x00000001814AD470-0x00000001814AD4D0
	
			// Methods
			internal bool Matches(ControllerMap map); // 0x00000001814AD070-0x00000001814AD1F0
			private void Initialize(); // 0x00000001814ACAA0-0x00000001814AD070
			private void CheckNoControllerTypeError(); // 0x00000001814AC3B0-0x00000001814AC6D0
			object IDeepCloneable.DeepClone(); // 0x00000001814AD1F0-0x00000001814AD340
		}
	
		[Serializable]
		[CustomClassObfuscation] // 0x0000000180210810-0x0000000180210890
		[Preserve] // 0x0000000180210810-0x0000000180210890
		[SerializationType] // 0x0000000180210810-0x0000000180210890
		public sealed class RuleSet : IDeepCloneable, IList<Rule> // TypeDefIndex: 6651
		{
			// Fields
			private const string className = "ControllerMapEnabler.RuleSet"; // Metadata: 0x00764DEB
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
			public List<Rule> rules { get; set; } // 0x0000000180374AF0-0x0000000180374B00 0x00000001814AC3A0-0x00000001814AC3B0
			public Rule this[int index] { get => default; set {} } // 0x00000001814AC180-0x00000001814AC1F0 0x00000001814AC1F0-0x00000001814AC280
			public int Count { get; } // 0x00000001814ABFE0-0x00000001814AC030 
			bool System.Collections.Generic.ICollection<Rewired.ControllerMapEnabler.Rule>.IsReadOnly { get; } // 0x00000001814AB8A0-0x00000001814AB900 
	
			// Constructors
			internal RuleSet(bool enabled, string tag, List<Rule> rules); // 0x00000001814ABD60-0x00000001814ABDF0
			public RuleSet(); // 0x00000001814ABDF0-0x00000001814ABE60
			public RuleSet(RuleSet source); // 0x00000001814ABAF0-0x00000001814ABC90
	
			// Methods
			public Rule Find(Predicate<Rule> predicate); // 0x00000001814AACD0-0x00000001814AAE70
			public Rule FindLast(Predicate<Rule> predicate); // 0x00000001814AAB10-0x00000001814AACD0
			public int FindIndex(Predicate<Rule> predicate); // 0x00000001814AA480-0x00000001814AA610
			public int FindLastIndex(Predicate<Rule> predicate); // 0x00000001814AA610-0x00000001814AA7E0
			public int IndexOf(Rule item); // 0x00000001814AB220-0x00000001814AB270
			public void Insert(int index, Rule item); // 0x00000001814AB270-0x00000001814AB2E0
			public void RemoveAt(int index); // 0x00000001814AB390-0x00000001814AB3F0
			public void Add(Rule item); // 0x00000001814A9E80-0x00000001814A9EE0
			public void Clear(); // 0x00000001814A9FC0-0x00000001814AA010
			public bool Contains(Rule item); // 0x00000001814AA160-0x00000001814AA1C0
			public void CopyTo(Rule[] array, int arrayIndex); // 0x00000001814AA280-0x00000001814AA2F0
			public bool Remove(Rule item); // 0x00000001814AB540-0x00000001814AB5A0
			public IEnumerator<Rule> GetEnumerator(); // 0x00000001814AB030-0x00000001814AB0B0
			IEnumerator IEnumerable.GetEnumerator(); // 0x00000001814ABA70-0x00000001814ABAF0
			object IDeepCloneable.DeepClone(); // 0x00000001814AB5A0-0x00000001814AB770
			private void CheckList(); // 0x00000001814A9EE0-0x00000001814A9F60
		}
	
		internal class ZgESyvoCZDaaWJMTaxFmFrlTHlVN // TypeDefIndex: 6652
		{
			// Fields
			public bool XCmLqGiIjecniTtyESDfezXWsFX; // 0x10
			public MoWpPnIELFeSQuddbxIWcvZmvTK[] PRilaMdORVIUTsbFhylqHYDEvLm; // 0x18
	
			// Constructors
			public ZgESyvoCZDaaWJMTaxFmFrlTHlVN(bool enabled, MoWpPnIELFeSQuddbxIWcvZmvTK[] startingRuleSets); // 0x0000000180509910-0x0000000180509950
		}
	
		// Constructors
		internal ControllerMapEnabler(Player player, ZgESyvoCZDaaWJMTaxFmFrlTHlVN startingSettings); // 0x000000018149B690-0x000000018149B810
	
		// Methods
		public void Apply(); // 0x0000000181499FE0-0x000000018149A6C0
		public void LoadDefaults(); // 0x000000018149AB00-0x000000018149ADD0
		public string ToXmlString(); // 0x000000018149B500-0x000000018149B690
		public string ToJsonString(); // 0x000000018149B370-0x000000018149B500
		public bool ImportXml(string xmlString); // 0x000000018149A940-0x000000018149AB00
		public bool ImportJson(string jsonString); // 0x000000018149A780-0x000000018149A940
		private SerializedObject uJZpqEBLkJUYeZxXRkMWiNxeekH(); // 0x000000018149B880-0x000000018149B900
		private void RKMnWkLYIShhsCAJrbDGpkKewIS(SerializedObject param_0000dab2); // 0x000000018149ADD0-0x000000018149B370
		private bool BxoFMvWmvalDyQMZPpCVmdbosOa(SerializedObject param_0000dab3); // 0x000000018149A6C0-0x000000018149A780
	}
}
