/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
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
	[Browsable] // 0x00000001801D4BF0-0x00000001801D4C30
	[EditorBrowsable] // 0x00000001801D4BF0-0x00000001801D4C30
	public sealed class CustomController_Editor // TypeDefIndex: 6194
	{
		// Fields
		[CustomObfuscation] // 0x00000001801D00E0-0x00000001801D0120
		[SerializeField] // 0x00000001801D00E0-0x00000001801D0120
		private string _name; // 0x10
		[CustomObfuscation] // 0x00000001801D00E0-0x00000001801D0120
		[SerializeField] // 0x00000001801D00E0-0x00000001801D0120
		private string _descriptiveName; // 0x18
		[CustomObfuscation] // 0x00000001801D1070-0x00000001801D10B0
		[SerializeField] // 0x00000001801D1070-0x00000001801D10B0
		private int _id; // 0x20
		[CustomObfuscation] // 0x00000001801D00E0-0x00000001801D0120
		[SerializeField] // 0x00000001801D00E0-0x00000001801D0120
		private string _typeGuidString; // 0x28
		[CustomObfuscation] // 0x00000001801D1070-0x00000001801D10B0
		[SerializeField] // 0x00000001801D1070-0x00000001801D10B0
		private List<ControllerElementIdentifier> _elementIdentifiers; // 0x30
		[CustomObfuscation] // 0x00000001801D1070-0x00000001801D10B0
		[SerializeField] // 0x00000001801D1070-0x00000001801D10B0
		private List<Axis> _axes; // 0x38
		[CustomObfuscation] // 0x00000001801D1070-0x00000001801D10B0
		[SerializeField] // 0x00000001801D1070-0x00000001801D10B0
		private List<Button> _buttons; // 0x40
		[CustomObfuscation] // 0x00000001801D1070-0x00000001801D10B0
		[SerializeField] // 0x00000001801D1070-0x00000001801D10B0
		private int _elementIdentifierIdCounter; // 0x48
	
		// Properties
		public string name { get; internal set; } // 0x0000000180372440-0x0000000180372450 0x0000000180379F20-0x0000000180379F30
		public string descriptiveName { get; internal set; } // 0x0000000180372430-0x0000000180372440 0x0000000180379F30-0x0000000180379F40
		public int id { get; internal set; } // 0x00000001803FB670-0x00000001803FB680 0x00000001804556D0-0x00000001804556E0
		public Guid typeGuid { get; internal set; } // 0x0000000180D87E40-0x0000000180D87EC0 0x0000000180D82A90-0x0000000180D82AB0
		internal string typeGuidString { get; set; } // 0x00000001803745B0-0x00000001803745C0 0x00000001803FA0C0-0x00000001803FA0D0
		public List<ControllerElementIdentifier> elementIdentifiers { get; internal set; } // 0x00000001803745C0-0x00000001803745D0 0x00000001803FA0A0-0x00000001803FA0B0
		public List<Axis> axes { get; } // 0x00000001803743D0-0x00000001803743E0 
		public List<Button> buttons { get; } // 0x00000001803C7290-0x00000001803C72A0 
		public int buttonCount { get; } // 0x0000000180D87E00-0x0000000180D87E40 
		public int axisCount { get; } // 0x0000000180D87DC0-0x0000000180D87E00 
		public IEnumerable<ControllerElementIdentifier> ElementIdentifiers { get; } // 0x0000000180D87D40-0x0000000180D87DC0 
	
		// Nested types
		[Serializable]
		[Browsable] // 0x00000001801D4BF0-0x00000001801D4C30
		[EditorBrowsable] // 0x00000001801D4BF0-0x00000001801D4C30
		public abstract class Element // TypeDefIndex: 6195
		{
			// Fields
			public int elementIdentifierId; // 0x10
			public string name; // 0x18
	
			// Constructors
			public Element(); // 0x0000000180373240-0x0000000180373250
			public Element(string name, int elementIdentifierId); // 0x0000000180D78BB0-0x0000000180D78BF0
	
			// Methods
			public abstract Element Clone();
		}
	
		[Serializable]
		[Browsable] // 0x00000001801D4BF0-0x00000001801D4C30
		[EditorBrowsable] // 0x00000001801D4BF0-0x00000001801D4C30
		public sealed class Button : Element // TypeDefIndex: 6196
		{
			// Constructors
			public Button(); // 0x0000000180373240-0x0000000180373250
			public Button(string name); // 0x0000000180D78B30-0x0000000180D78B60
			public Button(string name, int elementIdentifierId); // 0x0000000180D78BB0-0x0000000180D78BF0
			public Button(Button source); // 0x0000000180D78B60-0x0000000180D78BB0
	
			// Methods
			public override Element Clone(); // 0x0000000180D78AB0-0x0000000180D78B30
		}
	
		[Serializable]
		[Browsable] // 0x00000001801D4BF0-0x00000001801D4C30
		[EditorBrowsable] // 0x00000001801D4BF0-0x00000001801D4C30
		public sealed class Axis : Element // TypeDefIndex: 6197
		{
			// Fields
			public AxisRange range; // 0x20
			public bool invert; // 0x24
			public float deadZone; // 0x28
			public float zero; // 0x2C
			public float min; // 0x30
			public float max; // 0x34
			public bool doNotCalibrateRange; // 0x38
			public AxisSensitivityType sensitivityType; // 0x3C
			public float sensitivity; // 0x40
			public AnimationCurve sensitivityCurve; // 0x48
			public HardwareAxisInfo axisInfo; // 0x50
	
			// Constructors
			public Axis(); // 0x0000000180D785C0-0x0000000180D78630
			public Axis(string name); // 0x0000000180D787E0-0x0000000180D78900
			[Obsolete] // 0x00000001802357D0-0x0000000180235800
			public Axis(string name, string positiveName, string negativeName, int elementIdentifierId, AxisRange range, bool invert, float deadZone, float zero, float min, float max, bool doNotCalibrateRange, HardwareAxisInfo axisInfo); // 0x0000000180D78900-0x0000000180D78AB0
			public Axis(Axis source); // 0x0000000180D78630-0x0000000180D787E0
	
			// Methods
			public override Element Clone(); // 0x0000000180D783E0-0x0000000180D785C0
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class mlYYiGTgTExFhJQTseGqnWMTKOx : IEnumerable<ControllerElementIdentifier>, IEnumerator<ControllerElementIdentifier> // TypeDefIndex: 6198
		{
			// Fields
			private ControllerElementIdentifier aSrFEaALHwhGTdXfCdeUqgbwaZGO; // 0x10
			private int eLrUhJFgzEZElCzdKvcrgOLXLvL; // 0x18
			private int RQaeFqcJnaOYpZSBxtfUkVOjfOo; // 0x1C
			public CustomController_Editor gKPmvKLRxdGbmXiMfUeDjGbezUo; // 0x20
			public int ZKnOmfdBGxPCzuiOaEmmaNwByyN; // 0x28
	
			// Properties
			ControllerElementIdentifier QmgYVYcGXUPSkQvXLtYdUlBXEfB { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372440-0x0000000180372450 
			object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372440-0x0000000180372450 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public mlYYiGTgTExFhJQTseGqnWMTKOx(int <>1__state); // 0x00000001805EDEC0-0x00000001805EDF10
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			IEnumerator<ControllerElementIdentifier> IEnumerable<ControllerElementIdentifier>.GetEnumerator(); // 0x0000000180D91290-0x0000000180D91380
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			IEnumerator IEnumerable.GetEnumerator(); // 0x0000000180D91290-0x0000000180D91380
			private bool MoveNext(); // 0x0000000180D91110-0x0000000180D91290
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000180D91380-0x0000000180D913D0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		}
	
		// Constructors
		public CustomController_Editor(); // 0x0000000180D87940-0x0000000180D879F0
		public CustomController_Editor(CustomController_Editor source); // 0x0000000180D879F0-0x0000000180D87D40
	
		// Methods
		public CustomController_Editor Clone(); // 0x0000000180D84800-0x0000000180D84860
		public string[] GetElementIdentifierNames(); // 0x0000000180D85B40-0x0000000180D85CC0
		public int[] GetElementIdentifierIds(); // 0x0000000180D85630-0x0000000180D85770
		public string[] GetElementIdentifierNamesTypeSorted(); // 0x0000000180D85770-0x0000000180D85B40
		public int[] GetElementIdentifierIdsTypeSorted(); // 0x0000000180D85330-0x0000000180D85630
		public ControllerElementIdentifier[] GetElementIdentifiersTypeSorted(); // 0x0000000180D85D40-0x0000000180D86150
		public bool ContainsElementIdentifier(int id); // 0x0000000180D84860-0x0000000180D84960
		public int IndexOfElementIdentifier(int id); // 0x0000000180D861E0-0x0000000180D862E0
		public ControllerElementIdentifier GetElementIdentifier(int id); // 0x0000000180D85CC0-0x0000000180D85D40
		internal ControllerElementType hGhgQvKnDTIVWxqxMxhXqbRHHudm(int param_0000cf27); // 0x0000000180D87EC0-0x0000000180D88090
		internal bool lSbrgXrclydwTcojyhHBHcbAQBdD(int param_0000cf28, out AxisRange param_0000cf29); // 0x0000000180D88090-0x0000000180D88260
		public string[] GetButtonNames(); // 0x0000000180D84F20-0x0000000180D85060
		public int[] GetButtonElementIdentifierIds(); // 0x0000000180D84E00-0x0000000180D84F20
		public string[] GetAxisNames(); // 0x0000000180D84C60-0x0000000180D84E00
		public int[] GetAxisElementIdentifierIds(); // 0x0000000180D84AF0-0x0000000180D84C60
		public string[] GetElementNames<T>()
			where T : Element;
		public string[] GetElementNames(ControllerElementType type); // 0x0000000180D86150-0x0000000180D861E0
		public int[] GetElementElementIdentifierIds(ControllerElementType type); // 0x0000000180D85060-0x0000000180D85330
		public T GetElement<T>(int index)
			where T : Element;
		public void AddElement(ControllerElementType type); // 0x0000000180D846F0-0x0000000180D84800
		public void AddAxis(); // 0x0000000180D845D0-0x0000000180D84660
		public void AddButton(); // 0x0000000180D84660-0x0000000180D846F0
		public void InsertElement(ControllerElementType type, int index); // 0x0000000180D864E0-0x0000000180D866D0
		public void InsertAxis(int index); // 0x0000000180D862E0-0x0000000180D863F0
		public void InsertButton(int index); // 0x0000000180D863F0-0x0000000180D864E0
		public void DeleteElement(ControllerElementType type, int index); // 0x0000000180D84960-0x0000000180D84A20
		public void DeleteElement<T>(int index)
			where T : Element;
		public bool ReorderElement(ControllerElementType type, int index, bool offsetDown, bool offsetNow); // 0x0000000180D874C0-0x0000000180D87600
		public void DuplicateElement(ControllerElementType type, int index); // 0x0000000180D84A20-0x0000000180D84AF0
		private void IBkhfPGXuQCObTKLeuxECeGTUYdg<T>(int param_0000cf3b, List<T> param_0000cf3c)
			where T : Element;
		private ControllerElementIdentifier VlKfKUdoYlcpTLYqPXVpNksMeoWC(int param_0000cf3d, string param_0000cf3e); // 0x0000000180D87600-0x0000000180D87940
		private Element NydclpceECiebAbzIHPdaAGYsynp(ControllerElementType param_0000cf3f); // 0x0000000180D87030-0x0000000180D873C0
		private ControllerElementIdentifier QjDFEfWTsnDshMbqLGuaWVpfnbC(ControllerElementType param_0000cf40, string param_0000cf41, string param_0000cf42, string param_0000cf43); // 0x0000000180D873C0-0x0000000180D874C0
		internal HardwareControllerMap_Game MFnHAHAIawNTxLntEWHpOpiXEWk(); // 0x0000000180D866D0-0x0000000180D87030
	}
}
