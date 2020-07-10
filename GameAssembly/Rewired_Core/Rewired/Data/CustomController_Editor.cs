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

// Image 50: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5712-6954

namespace Rewired.Data
{
	[Serializable]
	[Browsable] // 0x00000001800D5150-0x00000001800D5190
	[EditorBrowsable] // 0x00000001800D5150-0x00000001800D5190
	public sealed class CustomController_Editor // TypeDefIndex: 6035
	{
		// Fields
		[CustomObfuscation] // 0x00000001800C3DD0-0x00000001800C3E10
		[SerializeField] // 0x00000001800C3DD0-0x00000001800C3E10
		private string _name; // 0x10
		[CustomObfuscation] // 0x00000001800C3DD0-0x00000001800C3E10
		[SerializeField] // 0x00000001800C3DD0-0x00000001800C3E10
		private string _descriptiveName; // 0x18
		[CustomObfuscation] // 0x00000001800C5270-0x00000001800C52B0
		[SerializeField] // 0x00000001800C5270-0x00000001800C52B0
		private int _id; // 0x20
		[CustomObfuscation] // 0x00000001800C3DD0-0x00000001800C3E10
		[SerializeField] // 0x00000001800C3DD0-0x00000001800C3E10
		private string _typeGuidString; // 0x28
		[CustomObfuscation] // 0x00000001800C5270-0x00000001800C52B0
		[SerializeField] // 0x00000001800C5270-0x00000001800C52B0
		private List<ControllerElementIdentifier> _elementIdentifiers; // 0x30
		[CustomObfuscation] // 0x00000001800C5270-0x00000001800C52B0
		[SerializeField] // 0x00000001800C5270-0x00000001800C52B0
		private List<Axis> _axes; // 0x38
		[CustomObfuscation] // 0x00000001800C5270-0x00000001800C52B0
		[SerializeField] // 0x00000001800C5270-0x00000001800C52B0
		private List<Button> _buttons; // 0x40
		[CustomObfuscation] // 0x00000001800C5270-0x00000001800C52B0
		[SerializeField] // 0x00000001800C5270-0x00000001800C52B0
		private int _elementIdentifierIdCounter; // 0x48
	
		// Properties
		public string name { get; internal set; } // 0x000000018036AC80-0x000000018036AC90 0x000000018036B1E0-0x000000018036B1F0
		public string descriptiveName { get; internal set; } // 0x000000018038B150-0x000000018038B160 0x000000018038B160-0x000000018038B170
		public int id { get; internal set; } // 0x00000001803C2700-0x00000001803C2710 0x00000001804886F0-0x0000000180488700
		public Guid typeGuid { get; internal set; } // 0x00000001805E8D40-0x00000001805E8DC0 0x00000001805E37F0-0x00000001805E3810
		internal string typeGuidString { get; set; } // 0x0000000180369B60-0x0000000180369B70 0x0000000180422D30-0x0000000180422D40
		public List<ControllerElementIdentifier> elementIdentifiers { get; internal set; } // 0x0000000180397720-0x0000000180397730 0x00000001803A2800-0x00000001803A2810
		public List<Axis> axes { get; } // 0x0000000180369BB0-0x0000000180369BC0 
		public List<Button> buttons { get; } // 0x0000000180369B30-0x0000000180369B40 
		public int buttonCount { get; } // 0x00000001805E8D00-0x00000001805E8D40 
		public int axisCount { get; } // 0x00000001805E8CC0-0x00000001805E8D00 
		public IEnumerable<ControllerElementIdentifier> ElementIdentifiers { get; } // 0x00000001805E8C40-0x00000001805E8CC0 
	
		// Nested types
		[Serializable]
		[Browsable] // 0x00000001800D5150-0x00000001800D5190
		[EditorBrowsable] // 0x00000001800D5150-0x00000001800D5190
		public abstract class Element // TypeDefIndex: 6036
		{
			// Fields
			public int elementIdentifierId; // 0x10
			public string name; // 0x18
	
			// Constructors
			public Element(); // 0x000000018036B6C0-0x000000018036B6D0
			public Element(string name, int elementIdentifierId); // 0x00000001805D98B0-0x00000001805D98F0
	
			// Methods
			public abstract Element Clone();
		}
	
		[Serializable]
		[Browsable] // 0x00000001800D5150-0x00000001800D5190
		[EditorBrowsable] // 0x00000001800D5150-0x00000001800D5190
		public sealed class Button : Element // TypeDefIndex: 6037
		{
			// Constructors
			public Button(); // 0x000000018036B6C0-0x000000018036B6D0
			public Button(string name); // 0x00000001805D9830-0x00000001805D9860
			public Button(string name, int elementIdentifierId); // 0x00000001805D98B0-0x00000001805D98F0
			public Button(Button source); // 0x00000001805D9860-0x00000001805D98B0
	
			// Methods
			public override Element Clone(); // 0x00000001805D97B0-0x00000001805D9830
		}
	
		[Serializable]
		[Browsable] // 0x00000001800D5150-0x00000001800D5190
		[EditorBrowsable] // 0x00000001800D5150-0x00000001800D5190
		public sealed class Axis : Element // TypeDefIndex: 6038
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
			public Axis(); // 0x00000001805D92B0-0x00000001805D9320
			public Axis(string name); // 0x00000001805D94E0-0x00000001805D9600
			[Obsolete] // 0x00000001800D6DA0-0x00000001800D6DD0
			public Axis(string name, string positiveName, string negativeName, int elementIdentifierId, AxisRange range, bool invert, float deadZone, float zero, float min, float max, bool doNotCalibrateRange, HardwareAxisInfo axisInfo); // 0x00000001805D9600-0x00000001805D97B0
			public Axis(Axis source); // 0x00000001805D9320-0x00000001805D94E0
	
			// Methods
			public override Element Clone(); // 0x00000001805D90D0-0x00000001805D92B0
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class mlYYiGTgTExFhJQTseGqnWMTKOx : IEnumerable<ControllerElementIdentifier>, IEnumerator<ControllerElementIdentifier> // TypeDefIndex: 6039
		{
			// Fields
			private ControllerElementIdentifier aSrFEaALHwhGTdXfCdeUqgbwaZGO; // 0x10
			private int eLrUhJFgzEZElCzdKvcrgOLXLvL; // 0x18
			private int RQaeFqcJnaOYpZSBxtfUkVOjfOo; // 0x1C
			public CustomController_Editor gKPmvKLRxdGbmXiMfUeDjGbezUo; // 0x20
			public int ZKnOmfdBGxPCzuiOaEmmaNwByyN; // 0x28
	
			// Properties
			ControllerElementIdentifier QmgYVYcGXUPSkQvXLtYdUlBXEfB { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018036AC80-0x000000018036AC90 
			object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018036AC80-0x000000018036AC90 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public mlYYiGTgTExFhJQTseGqnWMTKOx(int <>1__state); // 0x0000000180393A20-0x0000000180393A70
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			IEnumerator<ControllerElementIdentifier> IEnumerable<ControllerElementIdentifier>.GetEnumerator(); // 0x00000001805F2450-0x00000001805F2550
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			IEnumerator IEnumerable.GetEnumerator(); // 0x00000001805F2450-0x00000001805F2550
			private bool MoveNext(); // 0x00000001805F22C0-0x00000001805F2450
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x00000001805F2550-0x00000001805F25A0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		}
	
		// Constructors
		public CustomController_Editor(); // 0x00000001805E8820-0x00000001805E88D0
		public CustomController_Editor(CustomController_Editor source); // 0x00000001805E88D0-0x00000001805E8C40
	
		// Methods
		public CustomController_Editor Clone(); // 0x00000001805E55C0-0x00000001805E5620
		public string[] GetElementIdentifierNames(); // 0x00000001805E6990-0x00000001805E6B10
		public int[] GetElementIdentifierIds(); // 0x00000001805E6450-0x00000001805E65A0
		public string[] GetElementIdentifierNamesTypeSorted(); // 0x00000001805E65A0-0x00000001805E6990
		public int[] GetElementIdentifierIdsTypeSorted(); // 0x00000001805E6140-0x00000001805E6450
		public ControllerElementIdentifier[] GetElementIdentifiersTypeSorted(); // 0x00000001805E6B90-0x00000001805E6FB0
		public bool ContainsElementIdentifier(int id); // 0x00000001805E5620-0x00000001805E5720
		public int IndexOfElementIdentifier(int id); // 0x00000001805E7040-0x00000001805E7140
		public ControllerElementIdentifier GetElementIdentifier(int id); // 0x00000001805E6B10-0x00000001805E6B90
		internal ControllerElementType hGhgQvKnDTIVWxqxMxhXqbRHHudm(int param_0000ccb7); // 0x00000001805E8DC0-0x00000001805E8FA0
		internal bool lSbrgXrclydwTcojyhHBHcbAQBdD(int param_0000ccb8, out AxisRange param_0000ccb9); // 0x00000001805E8FA0-0x00000001805E9180
		public string[] GetButtonNames(); // 0x00000001805E5D10-0x00000001805E5E60
		public int[] GetButtonElementIdentifierIds(); // 0x00000001805E5BE0-0x00000001805E5D10
		public string[] GetAxisNames(); // 0x00000001805E5A30-0x00000001805E5BE0
		public int[] GetAxisElementIdentifierIds(); // 0x00000001805E58B0-0x00000001805E5A30
		public string[] GetElementNames<T>()
			where T : Element;
		public string[] GetElementNames(ControllerElementType type); // 0x00000001805E6FB0-0x00000001805E7040
		public int[] GetElementElementIdentifierIds(ControllerElementType type); // 0x00000001805E5E60-0x00000001805E6140
		public T GetElement<T>(int index)
			where T : Element;
		public void AddElement(ControllerElementType type); // 0x00000001805E54B0-0x00000001805E55C0
		public void AddAxis(); // 0x00000001805E5390-0x00000001805E5420
		public void AddButton(); // 0x00000001805E5420-0x00000001805E54B0
		public void InsertElement(ControllerElementType type, int index); // 0x00000001805E7340-0x00000001805E7540
		public void InsertAxis(int index); // 0x00000001805E7140-0x00000001805E7250
		public void InsertButton(int index); // 0x00000001805E7250-0x00000001805E7340
		public void DeleteElement(ControllerElementType type, int index); // 0x00000001805E5720-0x00000001805E57E0
		public void DeleteElement<T>(int index)
			where T : Element;
		public bool ReorderElement(ControllerElementType type, int index, bool offsetDown, bool offsetNow); // 0x00000001805E8380-0x00000001805E84D0
		public void DuplicateElement(ControllerElementType type, int index); // 0x00000001805E57E0-0x00000001805E58B0
		private void IBkhfPGXuQCObTKLeuxECeGTUYdg<T>(int param_0000cccb, List<T> param_0000cccc)
			where T : Element;
		private ControllerElementIdentifier VlKfKUdoYlcpTLYqPXVpNksMeoWC(int param_0000cccd, string param_0000ccce); // 0x00000001805E84D0-0x00000001805E8820
		private Element NydclpceECiebAbzIHPdaAGYsynp(ControllerElementType param_0000cccf); // 0x00000001805E7EE0-0x00000001805E8280
		private ControllerElementIdentifier QjDFEfWTsnDshMbqLGuaWVpfnbC(ControllerElementType param_0000ccd0, string param_0000ccd1, string param_0000ccd2, string param_0000ccd3); // 0x00000001805E8280-0x00000001805E8380
		internal HardwareControllerMap_Game MFnHAHAIawNTxLntEWHpOpiXEWk(); // 0x00000001805E7540-0x00000001805E7EE0
	}
}
