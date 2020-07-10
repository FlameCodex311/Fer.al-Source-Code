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

// Image 50: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5712-6954

namespace Rewired.Components
{
	[Serializable]
	public class PlayerController : ComponentWrapper<PlayerController>, IPlayerController // TypeDefIndex: 5875
	{
		// Fields
		[CustomObfuscation] // 0x00000001800B85B0-0x00000001800B8610
		[SerializeField] // 0x00000001800B85B0-0x00000001800B8610
		[Tooltip] // 0x00000001800B85B0-0x00000001800B8610
		private InputManager_Base _rewiredInputManager; // 0x28
		[CustomObfuscation] // 0x00000001800B89E0-0x00000001800B8A40
		[SerializeField] // 0x00000001800B89E0-0x00000001800B8A40
		[Tooltip] // 0x00000001800B89E0-0x00000001800B8A40
		private int _playerId; // 0x30
		[CustomObfuscation] // 0x00000001800B8CD0-0x00000001800B8D30
		[SerializeField] // 0x00000001800B8CD0-0x00000001800B8D30
		[Tooltip] // 0x00000001800B8CD0-0x00000001800B8D30
		private List<ElementInfo> _elements; // 0x38
		[CustomObfuscation] // 0x00000001800BA2F0-0x00000001800BA350
		[SerializeField] // 0x00000001800BA2F0-0x00000001800BA350
		[Tooltip] // 0x00000001800BA2F0-0x00000001800BA350
		private ButtonStateChangedHandler _onButtonStateChanged; // 0x40
		[CustomObfuscation] // 0x00000001800BA520-0x00000001800BA580
		[SerializeField] // 0x00000001800BA520-0x00000001800BA580
		[Tooltip] // 0x00000001800BA520-0x00000001800BA580
		private AxisValueChangedHandler _onAxisValueChanged; // 0x48
		[CustomObfuscation] // 0x00000001800BA7C0-0x00000001800BA820
		[SerializeField] // 0x00000001800BA7C0-0x00000001800BA820
		[Tooltip] // 0x00000001800BA7C0-0x00000001800BA820
		private EnabledStateChangedHandler _onEnabledStateChanged; // 0x50
	
		// Properties
		public int playerId { get; set; } // 0x0000000181908E50-0x0000000181908EA0 0x00000001819090B0-0x00000001819092A0
		public IList<PlayerController.Button> buttons { get; } // 0x0000000181908D40-0x0000000181908DA0 
		public IList<PlayerController.Axis> axes { get; } // 0x0000000181908C40-0x0000000181908CA0 
		public IList<PlayerController.Element> elements { get; } // 0x0000000181908DF0-0x0000000181908E50 
		public int buttonCount { get; } // 0x0000000181908CF0-0x0000000181908D40 
		public int axisCount { get; } // 0x0000000181908CA0-0x0000000181908CF0 
		public int elementCount { get; } // 0x0000000181908DA0-0x0000000181908DF0 
		bool IPlayerController.enabled { get; } // 0x00000001817D4210-0x00000001817D4220 
		bool IPlayerController.enabled { set; } // 0x0000000181908670-0x0000000181908680
	
		// Events
		public event Action<int, bool> ButtonStateChangedEvent {
			add; // 0x0000000181908AF0-0x0000000181908B50
			remove; // 0x0000000181908F00-0x0000000181908F90
		}
		public event Action<int, float> AxisValueChangedEvent {
			add; // 0x0000000181908A90-0x0000000181908AF0
			remove; // 0x0000000181908EA0-0x0000000181908F00
		}
		public event Action<bool> EnabledStateChangedEvent {
			add; // 0x0000000181908B50-0x0000000181908BB0
			remove; // 0x0000000181908F90-0x0000000181909010
		}
	
		// Nested types
		[Serializable]
		public class ButtonStateChangedHandler : UnityEvent<int, bool> // TypeDefIndex: 5876
		{
			// Constructors
			public ButtonStateChangedHandler(); // 0x0000000181905ED0-0x0000000181905F10
		}
	
		[Serializable]
		public class AxisValueChangedHandler : UnityEvent<int, float> // TypeDefIndex: 5877
		{
			// Constructors
			public AxisValueChangedHandler(); // 0x0000000181905E90-0x0000000181905ED0
		}
	
		[Serializable]
		public class EnabledStateChangedHandler : UnityEvent<bool> // TypeDefIndex: 5878
		{
			// Constructors
			public EnabledStateChangedHandler(); // 0x0000000181907150-0x0000000181907190
		}
	
		[Serializable]
		[CustomClassObfuscation] // 0x00000001800B82D0-0x00000001800B8320
		[CustomObfuscation] // 0x00000001800B82D0-0x00000001800B8320
		internal sealed class ElementWithSourceInfo // TypeDefIndex: 5879
		{
			// Fields
			[SerializeField] // 0x00000001800BAD80-0x00000001800BADC0
			[Tooltip] // 0x00000001800BAD80-0x00000001800BADC0
			private string _name; // 0x10
			[SerializeField] // 0x00000001800BAF30-0x00000001800BAF80
			[Tooltip] // 0x00000001800BAF30-0x00000001800BAF80
			private PlayerController.Element.TypeWithSource _elementType; // 0x18
			[SerializeField] // 0x00000001800BB090-0x00000001800BB0D0
			[Tooltip] // 0x00000001800BB090-0x00000001800BB0D0
			private bool _enabled; // 0x1C
			[SerializeField] // 0x00000001800BB390-0x00000001800BB3D0
			[Tooltip] // 0x00000001800BB390-0x00000001800BB3D0
			private int _actionId; // 0x20
			[SerializeField] // 0x00000001800BB590-0x00000001800BB5E0
			[Tooltip] // 0x00000001800BB590-0x00000001800BB5E0
			private AxisCoordinateMode _coordinateMode; // 0x24
			[FieldRange] // 0x00000001800BB6F0-0x00000001800BB760
			[SerializeField] // 0x00000001800BB6F0-0x00000001800BB760
			[Tooltip] // 0x00000001800BB6F0-0x00000001800BB760
			private float _absoluteToRelativeSensitivity; // 0x28
			[FieldRange] // 0x00000001800BCBB0-0x00000001800BCC10
			[SerializeField] // 0x00000001800BCBB0-0x00000001800BCC10
			[Tooltip] // 0x00000001800BCBB0-0x00000001800BCC10
			private float _repeatRate; // 0x2C
	
			// Properties
			public string name { get; set; } // 0x000000018036AC80-0x000000018036AC90 0x000000018036B1E0-0x000000018036B1F0
			public PlayerController.Element.TypeWithSource elementType { get; set; } // 0x0000000180367710-0x0000000180367720 0x000000018036B1F0-0x000000018036B200
			public bool enabled { get; set; } // 0x000000018036CB20-0x000000018036CB30 0x000000018036CBC0-0x000000018036CBD0
			public int actionId { get; set; } // 0x00000001803C2700-0x00000001803C2710 0x00000001804886F0-0x0000000180488700
			public AxisCoordinateMode coordinateMode { get; set; } // 0x00000001803C26F0-0x00000001803C2700 0x00000001804D0B90-0x00000001804D0BA0
			public float absoluteSourceSensitivity { get; set; } // 0x0000000180487D50-0x0000000180487D60 0x00000001805D90B0-0x00000001805D90C0
			public float repeatRate { get; set; } // 0x0000000180487D70-0x0000000180487D80 0x000000018139C3C0-0x000000018139C3D0
	
			// Constructors
			public ElementWithSourceInfo(); // 0x0000000181907130-0x0000000181907150
	
			// Methods
			public PlayerController.Element.Definition ToDefinition(); // 0x0000000181906EB0-0x0000000181907130
		}
	
		[Serializable]
		[CustomClassObfuscation] // 0x00000001800BCF20-0x00000001800BCF70
		[CustomObfuscation] // 0x00000001800BCF20-0x00000001800BCF70
		internal sealed class ElementInfo // TypeDefIndex: 5880
		{
			// Fields
			[SerializeField] // 0x00000001800BAD80-0x00000001800BADC0
			[Tooltip] // 0x00000001800BAD80-0x00000001800BADC0
			private string _name; // 0x10
			[SerializeField] // 0x00000001800BD260-0x00000001800BD2A0
			[Tooltip] // 0x00000001800BD260-0x00000001800BD2A0
			private PlayerController.Element.Type _elementType; // 0x18
			[SerializeField] // 0x00000001800BB090-0x00000001800BB0D0
			[Tooltip] // 0x00000001800BB090-0x00000001800BB0D0
			private bool _enabled; // 0x1C
			[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
			private ElementWithSourceInfo[] _elements; // 0x20
	
			// Properties
			public string name { get; set; } // 0x000000018036AC80-0x000000018036AC90 0x000000018036B1E0-0x000000018036B1F0
			public PlayerController.Element.Type elementType { get; set; } // 0x0000000180367710-0x0000000180367720 0x000000018036B1F0-0x000000018036B200
			public bool enabled { get; set; } // 0x000000018036CB20-0x000000018036CB30 0x000000018036CBC0-0x000000018036CBD0
			public ElementWithSourceInfo[] elements { get; set; } // 0x000000018036AC70-0x000000018036AC80 0x000000018036AC90-0x000000018036ACA0
	
			// Constructors
			public ElementInfo(); // 0x0000000181906E60-0x0000000181906EB0
	
			// Methods
			public PlayerController.Element.Definition ToDefinition(); // 0x00000001819063E0-0x0000000181906E60
		}
	
		// Constructors
		public PlayerController(); // 0x0000000181908960-0x0000000181908A90
	
		// Methods
		public bool GetButton(int index); // 0x0000000181907E40-0x0000000181907EA0
		public bool GetButtonDown(int index); // 0x0000000181907D80-0x0000000181907DE0
		public bool GetButtonUp(int index); // 0x0000000181907DE0-0x0000000181907E40
		public float GetAxis(int index); // 0x0000000181907D10-0x0000000181907D80
		public float GetAxisRaw(int index); // 0x0000000181907CA0-0x0000000181907D10
		public PlayerController.Element GetElement(int index); // 0x0000000181907EA0-0x0000000181907F00
		public T GetElement<T>(int index)
			where T : PlayerController.Element;
		protected override void OnAwake(); // 0x0000000181908000-0x0000000181908050
		protected override void OnAwakeFinished(); // 0x0000000181907FA0-0x0000000181908000
		protected override void OnEnabled(); // 0x0000000181908150-0x0000000181908260
		protected override void OnDisabled(); // 0x0000000181908050-0x0000000181908150
		protected override void OnValidated(); // 0x0000000181908420-0x0000000181908670
		protected override void OnReset(); // 0x0000000181908260-0x0000000181908420
		protected override void Subscribe(); // 0x0000000181908680-0x0000000181908800
		protected override void Unsubscribe(); // 0x0000000181908800-0x0000000181908960
		protected override object GetCreateSourceArgs(); // 0x0000000180369BB0-0x0000000180369BC0
		protected override Rewired.PlayerController CreateSource(object args); // 0x00000001819078B0-0x0000000181907C30
		internal virtual List<ElementInfo> CreateDefaultElementInfos(); // 0x0000000181907220-0x00000001819078B0
		private void sPpozJpKoWGGnOfmDhaoQvukzPV(int param_0000c87c, bool param_0000c87d); // 0x0000000181909010-0x00000001819090B0
		private void NwZAfFRzJtqbomIKNDDNEtFbGxU(int param_0000c87e, float param_0000c87f); // 0x0000000181907F00-0x0000000181907FA0
		private void gKJTsKbajFnGIJBaNwoxsdNrBPc(bool param_0000c880); // 0x0000000181908BB0-0x0000000181908C40
		private void EJxVIulAFMaUhXXnieLQpmGoCsu(); // 0x0000000181907C30-0x0000000181907CA0
	}
}
