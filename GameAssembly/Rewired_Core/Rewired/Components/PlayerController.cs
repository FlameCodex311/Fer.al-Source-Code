/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Rewired;
using Rewired.Utils.Attributes;
using UnityEngine;
using UnityEngine.Events;

// Image 51: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5871-7113

namespace Rewired.Components
{
	[Serializable]
	public class PlayerController : ComponentWrapper<PlayerController>, IPlayerController // TypeDefIndex: 6034
	{
		// Fields
		[CustomObfuscation] // 0x0000000180219490-0x00000001802194F0
		[SerializeField] // 0x0000000180219490-0x00000001802194F0
		[Tooltip] // 0x0000000180219490-0x00000001802194F0
		private InputManager_Base _rewiredInputManager; // 0x28
		[CustomObfuscation] // 0x000000018021AB10-0x000000018021AB70
		[SerializeField] // 0x000000018021AB10-0x000000018021AB70
		[Tooltip] // 0x000000018021AB10-0x000000018021AB70
		private int _playerId; // 0x30
		[CustomObfuscation] // 0x000000018021AEA0-0x000000018021AF00
		[SerializeField] // 0x000000018021AEA0-0x000000018021AF00
		[Tooltip] // 0x000000018021AEA0-0x000000018021AF00
		private List<ElementInfo> _elements; // 0x38
		[CustomObfuscation] // 0x000000018021B360-0x000000018021B3C0
		[SerializeField] // 0x000000018021B360-0x000000018021B3C0
		[Tooltip] // 0x000000018021B360-0x000000018021B3C0
		private ButtonStateChangedHandler _onButtonStateChanged; // 0x40
		[CustomObfuscation] // 0x000000018021B760-0x000000018021B7C0
		[SerializeField] // 0x000000018021B760-0x000000018021B7C0
		[Tooltip] // 0x000000018021B760-0x000000018021B7C0
		private AxisValueChangedHandler _onAxisValueChanged; // 0x48
		[CustomObfuscation] // 0x000000018021BB70-0x000000018021BBD0
		[SerializeField] // 0x000000018021BB70-0x000000018021BBD0
		[Tooltip] // 0x000000018021BB70-0x000000018021BBD0
		private EnabledStateChangedHandler _onEnabledStateChanged; // 0x50
	
		// Properties
		public int playerId { get; set; } // 0x00000001810AED80-0x00000001810AEDD0 0x00000001810AEFE0-0x00000001810AF1D0
		public IList<PlayerController.Button> buttons { get; } // 0x00000001810AEC70-0x00000001810AECD0 
		public IList<PlayerController.Axis> axes { get; } // 0x00000001810AEB70-0x00000001810AEBD0 
		public IList<PlayerController.Element> elements { get; } // 0x00000001810AED20-0x00000001810AED80 
		public int buttonCount { get; } // 0x00000001810AEC20-0x00000001810AEC70 
		public int axisCount { get; } // 0x00000001810AEBD0-0x00000001810AEC20 
		public int elementCount { get; } // 0x00000001810AECD0-0x00000001810AED20 
		bool IPlayerController.enabled { get; } // 0x00000001810AE5B0-0x00000001810AE5C0 
		bool IPlayerController.enabled { set; } // 0x00000001810AE5C0-0x00000001810AE5D0
	
		// Events
		public event Action<int, bool> ButtonStateChangedEvent {
			add; // 0x00000001810AEA20-0x00000001810AEA80
			remove; // 0x00000001810AEE30-0x00000001810AEEC0
		}
		public event Action<int, float> AxisValueChangedEvent {
			add; // 0x00000001810AE9C0-0x00000001810AEA20
			remove; // 0x00000001810AEDD0-0x00000001810AEE30
		}
		public event Action<bool> EnabledStateChangedEvent {
			add; // 0x00000001810AEA80-0x00000001810AEAE0
			remove; // 0x00000001810AEEC0-0x00000001810AEF40
		}
	
		// Nested types
		[Serializable]
		public class ButtonStateChangedHandler : UnityEvent<int, bool> // TypeDefIndex: 6035
		{
			// Constructors
			public ButtonStateChangedHandler(); // 0x00000001810ABE90-0x00000001810ABED0
		}
	
		[Serializable]
		public class AxisValueChangedHandler : UnityEvent<int, float> // TypeDefIndex: 6036
		{
			// Constructors
			public AxisValueChangedHandler(); // 0x00000001810ABE50-0x00000001810ABE90
		}
	
		[Serializable]
		public class EnabledStateChangedHandler : UnityEvent<bool> // TypeDefIndex: 6037
		{
			// Constructors
			public EnabledStateChangedHandler(); // 0x00000001810AD0C0-0x00000001810AD100
		}
	
		[Serializable]
		[CustomClassObfuscation] // 0x00000001801CE700-0x00000001801CE750
		[CustomObfuscation] // 0x00000001801CE700-0x00000001801CE750
		internal sealed class ElementWithSourceInfo // TypeDefIndex: 6038
		{
			// Fields
			[SerializeField] // 0x000000018021C230-0x000000018021C270
			[Tooltip] // 0x000000018021C230-0x000000018021C270
			private string _name; // 0x10
			[SerializeField] // 0x000000018021C400-0x000000018021C450
			[Tooltip] // 0x000000018021C400-0x000000018021C450
			private PlayerController.Element.TypeWithSource _elementType; // 0x18
			[SerializeField] // 0x000000018021C5E0-0x000000018021C620
			[Tooltip] // 0x000000018021C5E0-0x000000018021C620
			private bool _enabled; // 0x1C
			[SerializeField] // 0x000000018021C930-0x000000018021C970
			[Tooltip] // 0x000000018021C930-0x000000018021C970
			private int _actionId; // 0x20
			[SerializeField] // 0x000000018021CBE0-0x000000018021CC30
			[Tooltip] // 0x000000018021CBE0-0x000000018021CC30
			private AxisCoordinateMode _coordinateMode; // 0x24
			[FieldRange] // 0x000000018021D0C0-0x000000018021D130
			[SerializeField] // 0x000000018021D0C0-0x000000018021D130
			[Tooltip] // 0x000000018021D0C0-0x000000018021D130
			private float _absoluteToRelativeSensitivity; // 0x28
			[FieldRange] // 0x000000018021D4C0-0x000000018021D520
			[SerializeField] // 0x000000018021D4C0-0x000000018021D520
			[Tooltip] // 0x000000018021D4C0-0x000000018021D520
			private float _repeatRate; // 0x2C
	
			// Properties
			public string name { get; set; } // 0x0000000180372440-0x0000000180372450 0x0000000180379F20-0x0000000180379F30
			public PlayerController.Element.TypeWithSource elementType { get; set; } // 0x00000001803F46B0-0x00000001803F46C0 0x00000001803F46C0-0x00000001803F46D0
			public bool enabled { get; set; } // 0x000000018041B650-0x000000018041B660 0x000000018041B6E0-0x000000018041B6F0
			public int actionId { get; set; } // 0x00000001803FB670-0x00000001803FB680 0x00000001804556D0-0x00000001804556E0
			public AxisCoordinateMode coordinateMode { get; set; } // 0x0000000180491DB0-0x0000000180491DC0 0x0000000180569610-0x0000000180569620
			public float absoluteSourceSensitivity { get; set; } // 0x0000000180491DA0-0x0000000180491DB0 0x0000000180626240-0x0000000180626250
			public float repeatRate { get; set; } // 0x00000001807DDA30-0x00000001807DDA40 0x00000001807DDA40-0x00000001807DDA50
	
			// Constructors
			public ElementWithSourceInfo(); // 0x00000001810AD0A0-0x00000001810AD0C0
	
			// Methods
			public PlayerController.Element.Definition ToDefinition(); // 0x00000001810ACE20-0x00000001810AD0A0
		}
	
		[Serializable]
		[CustomClassObfuscation] // 0x00000001801DE5D0-0x00000001801DE620
		[CustomObfuscation] // 0x00000001801DE5D0-0x00000001801DE620
		internal sealed class ElementInfo // TypeDefIndex: 6039
		{
			// Fields
			[SerializeField] // 0x000000018021C230-0x000000018021C270
			[Tooltip] // 0x000000018021C230-0x000000018021C270
			private string _name; // 0x10
			[SerializeField] // 0x000000018021DE50-0x000000018021DE90
			[Tooltip] // 0x000000018021DE50-0x000000018021DE90
			private PlayerController.Element.Type _elementType; // 0x18
			[SerializeField] // 0x000000018021C5E0-0x000000018021C620
			[Tooltip] // 0x000000018021C5E0-0x000000018021C620
			private bool _enabled; // 0x1C
			[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
			private ElementWithSourceInfo[] _elements; // 0x20
	
			// Properties
			public string name { get; set; } // 0x0000000180372440-0x0000000180372450 0x0000000180379F20-0x0000000180379F30
			public PlayerController.Element.Type elementType { get; set; } // 0x00000001803F46B0-0x00000001803F46C0 0x00000001803F46C0-0x00000001803F46D0
			public bool enabled { get; set; } // 0x000000018041B650-0x000000018041B660 0x000000018041B6E0-0x000000018041B6F0
			public ElementWithSourceInfo[] elements { get; set; } // 0x0000000180374AF0-0x0000000180374B00 0x00000001803F70C0-0x00000001803F70D0
	
			// Constructors
			public ElementInfo(); // 0x00000001810ACDD0-0x00000001810ACE20
	
			// Methods
			public PlayerController.Element.Definition ToDefinition(); // 0x00000001810AC3A0-0x00000001810ACDD0
		}
	
		// Constructors
		public PlayerController(); // 0x00000001810AE890-0x00000001810AE9C0
	
		// Methods
		public bool GetButton(int index); // 0x00000001810ADD80-0x00000001810ADDE0
		public bool GetButtonDown(int index); // 0x00000001810ADCC0-0x00000001810ADD20
		public bool GetButtonUp(int index); // 0x00000001810ADD20-0x00000001810ADD80
		public float GetAxis(int index); // 0x00000001810ADC50-0x00000001810ADCC0
		public float GetAxisRaw(int index); // 0x00000001810ADBE0-0x00000001810ADC50
		public PlayerController.Element GetElement(int index); // 0x00000001810ADDE0-0x00000001810ADE40
		public T GetElement<T>(int index)
			where T : PlayerController.Element;
		protected override void OnAwake(); // 0x00000001810ADF40-0x00000001810ADF90
		protected override void OnAwakeFinished(); // 0x00000001810ADEE0-0x00000001810ADF40
		protected override void OnEnabled(); // 0x00000001810AE090-0x00000001810AE1A0
		protected override void OnDisabled(); // 0x00000001810ADF90-0x00000001810AE090
		protected override void OnValidated(); // 0x00000001810AE360-0x00000001810AE5B0
		protected override void OnReset(); // 0x00000001810AE1A0-0x00000001810AE360
		protected override void Subscribe(); // 0x00000001810AE5D0-0x00000001810AE740
		protected override void Unsubscribe(); // 0x00000001810AE740-0x00000001810AE890
		protected override object GetCreateSourceArgs(); // 0x00000001803743D0-0x00000001803743E0
		protected override Rewired.PlayerController CreateSource(object args); // 0x00000001810AD7F0-0x00000001810ADB70
		internal virtual List<ElementInfo> CreateDefaultElementInfos(); // 0x00000001810AD190-0x00000001810AD7F0
		private void sPpozJpKoWGGnOfmDhaoQvukzPV(int param_0000caec, bool param_0000caed); // 0x00000001810AEF40-0x00000001810AEFE0
		private void NwZAfFRzJtqbomIKNDDNEtFbGxU(int param_0000caee, float param_0000caef); // 0x00000001810ADE40-0x00000001810ADEE0
		private void gKJTsKbajFnGIJBaNwoxsdNrBPc(bool param_0000caf0); // 0x00000001810AEAE0-0x00000001810AEB70
		private void EJxVIulAFMaUhXXnieLQpmGoCsu(); // 0x00000001810ADB70-0x00000001810ADBE0
	}
}
