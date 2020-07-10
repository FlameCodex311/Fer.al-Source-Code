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
using Rewired;
using Rewired.ComponentControls.Data;
using Rewired.Internal;
using Rewired.Utils.Attributes;
using Rewired.Utils.UI;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

// Image 50: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5712-6954

namespace Rewired.ComponentControls
{
	[Serializable]
	[DisallowMultipleComponent] // 0x00000001800B36B0-0x00000001800B36C0
	public sealed class TouchJoystick : TouchInteractable // TypeDefIndex: 5828
	{
		// Fields
		private const float MAX_MOVE_SPEED = 20f; // Metadata: 0x0072EC8C
		[CustomObfuscation] // 0x0000000180158990-0x00000001801589F0
		[SerializeField] // 0x0000000180158990-0x00000001801589F0
		[Tooltip] // 0x0000000180158990-0x00000001801589F0
		private CustomControllerElementTargetSetForFloat _horizontalAxisCustomControllerElement; // 0x128
		[CustomObfuscation] // 0x0000000180158C90-0x0000000180158CF0
		[SerializeField] // 0x0000000180158C90-0x0000000180158CF0
		[Tooltip] // 0x0000000180158C90-0x0000000180158CF0
		private CustomControllerElementTargetSetForFloat _verticalAxisCustomControllerElement; // 0x130
		[CustomObfuscation] // 0x0000000180158ED0-0x0000000180158F30
		[SerializeField] // 0x0000000180158ED0-0x0000000180158F30
		[Tooltip] // 0x0000000180158ED0-0x0000000180158F30
		private CustomControllerElementTargetSetForBoolean _tapCustomControllerElement; // 0x138
		[CustomObfuscation] // 0x00000001801592F0-0x0000000180159350
		[SerializeField] // 0x00000001801592F0-0x0000000180159350
		[Tooltip] // 0x00000001801592F0-0x0000000180159350
		private RectTransform _stickTransform; // 0x140
		[CustomObfuscation] // 0x0000000180159700-0x0000000180159760
		[SerializeField] // 0x0000000180159700-0x0000000180159760
		[Tooltip] // 0x0000000180159700-0x0000000180159760
		private JoystickMode _joystickMode; // 0x148
		[CustomObfuscation] // 0x0000000180159930-0x00000001801599B0
		[Range] // 0x0000000180159930-0x00000001801599B0
		[SerializeField] // 0x0000000180159930-0x00000001801599B0
		[Tooltip] // 0x0000000180159930-0x00000001801599B0
		private float _digitalModeDeadZone; // 0x14C
		[CustomObfuscation] // 0x0000000180159C00-0x0000000180159C80
		[Range] // 0x0000000180159C00-0x0000000180159C80
		[SerializeField] // 0x0000000180159C00-0x0000000180159C80
		[Tooltip] // 0x0000000180159C00-0x0000000180159C80
		private float _stickRange; // 0x150
		[CustomObfuscation] // 0x0000000180159DE0-0x0000000180159E40
		[SerializeField] // 0x0000000180159DE0-0x0000000180159E40
		[Tooltip] // 0x0000000180159DE0-0x0000000180159E40
		private bool _scaleStickRange; // 0x154
		[CustomObfuscation] // 0x000000018015A180-0x000000018015A1E0
		[SerializeField] // 0x000000018015A180-0x000000018015A1E0
		[Tooltip] // 0x000000018015A180-0x000000018015A1E0
		private StickBounds _stickBounds; // 0x158
		[CustomObfuscation] // 0x000000018015A5D0-0x000000018015A630
		[SerializeField] // 0x000000018015A5D0-0x000000018015A630
		[Tooltip] // 0x000000018015A5D0-0x000000018015A630
		private AxisDirection _axesToUse; // 0x15C
		[CustomObfuscation] // 0x000000018015A910-0x000000018015A970
		[SerializeField] // 0x000000018015A910-0x000000018015A970
		[Tooltip] // 0x000000018015A910-0x000000018015A970
		private SnapDirections _snapDirections; // 0x160
		[CustomObfuscation] // 0x000000018015AB40-0x000000018015ABA0
		[SerializeField] // 0x000000018015AB40-0x000000018015ABA0
		[Tooltip] // 0x000000018015AB40-0x000000018015ABA0
		private bool _snapStickToTouch; // 0x164
		[CustomObfuscation] // 0x000000018015AF10-0x000000018015AF70
		[SerializeField] // 0x000000018015AF10-0x000000018015AF70
		[Tooltip] // 0x000000018015AF10-0x000000018015AF70
		private bool _centerStickOnRelease; // 0x165
		[CustomObfuscation] // 0x000000018015B210-0x000000018015B270
		[SerializeField] // 0x000000018015B210-0x000000018015B270
		[Tooltip] // 0x000000018015B210-0x000000018015B270
		private StandaloneAxis2D _axis2D; // 0x168
		[CustomObfuscation] // 0x000000018015B470-0x000000018015B4D0
		[SerializeField] // 0x000000018015B470-0x000000018015B4D0
		[Tooltip] // 0x000000018015B470-0x000000018015B4D0
		private bool _activateOnSwipeIn; // 0x170
		[CustomObfuscation] // 0x000000018015BAA0-0x000000018015BB00
		[SerializeField] // 0x000000018015BAA0-0x000000018015BB00
		[Tooltip] // 0x000000018015BAA0-0x000000018015BB00
		private bool _stayActiveOnSwipeOut; // 0x171
		[CustomObfuscation] // 0x000000018015BEB0-0x000000018015BF10
		[SerializeField] // 0x000000018015BEB0-0x000000018015BF10
		[Tooltip] // 0x000000018015BEB0-0x000000018015BF10
		private bool _allowTap; // 0x172
		[CustomObfuscation] // 0x00000001800B3A10-0x00000001800B3A90
		[FieldRange] // 0x00000001800B3A10-0x00000001800B3A90
		[SerializeField] // 0x00000001800B3A10-0x00000001800B3A90
		[Tooltip] // 0x00000001800B3A10-0x00000001800B3A90
		private float _tapTimeout; // 0x174
		[CustomObfuscation] // 0x000000018015C650-0x000000018015C6D0
		[FieldRange] // 0x000000018015C650-0x000000018015C6D0
		[SerializeField] // 0x000000018015C650-0x000000018015C6D0
		[Tooltip] // 0x000000018015C650-0x000000018015C6D0
		private int _tapDistanceLimit; // 0x178
		[CustomObfuscation] // 0x000000018015CCD0-0x000000018015CD30
		[SerializeField] // 0x000000018015CCD0-0x000000018015CD30
		[Tooltip] // 0x000000018015CCD0-0x000000018015CD30
		private TouchRegion _touchRegion; // 0x180
		[CustomObfuscation] // 0x000000018015CF40-0x000000018015CFA0
		[SerializeField] // 0x000000018015CF40-0x000000018015CFA0
		[Tooltip] // 0x000000018015CF40-0x000000018015CFA0
		private bool _useTouchRegionOnly; // 0x188
		[CustomObfuscation] // 0x000000018015D250-0x000000018015D2B0
		[SerializeField] // 0x000000018015D250-0x000000018015D2B0
		[Tooltip] // 0x000000018015D250-0x000000018015D2B0
		private bool _moveToTouchPosition; // 0x189
		[CustomObfuscation] // 0x000000018015D520-0x000000018015D580
		[SerializeField] // 0x000000018015D520-0x000000018015D580
		[Tooltip] // 0x000000018015D520-0x000000018015D580
		private bool _returnOnRelease; // 0x18A
		[CustomObfuscation] // 0x000000018015D8E0-0x000000018015D940
		[SerializeField] // 0x000000018015D8E0-0x000000018015D940
		[Tooltip] // 0x000000018015D8E0-0x000000018015D940
		private bool _followTouchPosition; // 0x18B
		[CustomObfuscation] // 0x000000018015DD60-0x000000018015DDC0
		[SerializeField] // 0x000000018015DD60-0x000000018015DDC0
		[Tooltip] // 0x000000018015DD60-0x000000018015DDC0
		private bool _animateOnMoveToTouch; // 0x18C
		[CustomObfuscation] // 0x000000018015E0F0-0x000000018015E170
		[Range] // 0x000000018015E0F0-0x000000018015E170
		[SerializeField] // 0x000000018015E0F0-0x000000018015E170
		[Tooltip] // 0x000000018015E0F0-0x000000018015E170
		private float _moveToTouchSpeed; // 0x190
		[CustomObfuscation] // 0x000000018015E630-0x000000018015E690
		[SerializeField] // 0x000000018015E630-0x000000018015E690
		[Tooltip] // 0x000000018015E630-0x000000018015E690
		private bool _animateOnReturn; // 0x194
		[CustomObfuscation] // 0x000000018015E930-0x000000018015E9B0
		[Range] // 0x000000018015E930-0x000000018015E9B0
		[SerializeField] // 0x000000018015E930-0x000000018015E9B0
		[Tooltip] // 0x000000018015E930-0x000000018015E9B0
		private float _returnSpeed; // 0x198
		[CustomObfuscation] // 0x000000018015ED10-0x000000018015ED70
		[SerializeField] // 0x000000018015ED10-0x000000018015ED70
		[Tooltip] // 0x000000018015ED10-0x000000018015ED70
		private bool _manageRaycasting; // 0x19C
		private bool _useXAxis; // 0x19D
		private bool _useYAxis; // 0x19E
		private QGjnOCnHKfrjIqlAonYthHKMREQ.HierarchyEventHelper<IValueChangedHandler, Vector2> _hierarchyValueChangedHandlers; // 0x1A0
		private QGjnOCnHKfrjIqlAonYthHKMREQ.HierarchyEventHelper<IStickPositionChangedHandler, Vector2> _hierarchyStickPositionChangedHandlers; // 0x1A8
		private TouchRegion _workingTouchRegion; // 0x1B0
		private Vector2 _origAnchoredPosition; // 0x1B8
		private Vector2 _origStickAnchoredPosition; // 0x1C0
		private Vector2 _lastPressAnchoredPosition; // 0x1C8
		private bool _isMoving; // 0x1D0
		private bool _isMovedFromDefaultPosition; // 0x1D1
		private gcXbbdhodwurOwnETJBwcylSiar _moveDirection; // 0x1D4
		private int _pointerId; // 0x1D8
		private int _realMousePointerId; // 0x1DC
		[NonSerialized]
		private bool byeanBfvjEeOOwRBSBerFwsuBMBA; // 0x1E0
		[NonSerialized]
		private bool IXgubBiHZOnBAjLkDRcJjAfbtyr; // 0x1E1
		private bool _pointerDownIsFake; // 0x1E2
		private Vector2 _lastPressStartingValue; // 0x1E4
		private dQfHNopHjGTKEUqCqpYYwYyguiA _lastClaimSource; // 0x1EC
		private float _touchStartTime; // 0x1F0
		private Vector2 _touchStartPosition; // 0x1F4
		private IEnumerator _coroutineMove; // 0x200
		private FulEHeUoVkyNDHjDfouzidfyihgB _imageRaycastHelper; // 0x208
		private int _calculatedStickRange_lastUpdatedFrame; // 0x210
		private int _lastTapFrame; // 0x214
		private bool _isEligibleForTap; // 0x218
		private float __calculatedStickRange_cachedValue; // 0x21C
		private Action<gcXbbdhodwurOwnETJBwcylSiar> __moveStartedDelegate; // 0x220
		private Action<gcXbbdhodwurOwnETJBwcylSiar> __moveEndedDelegate; // 0x228
		[CustomObfuscation] // 0x000000018015EFA0-0x000000018015F000
		[SerializeField] // 0x000000018015EFA0-0x000000018015F000
		[Tooltip] // 0x000000018015EFA0-0x000000018015F000
		private ValueChangedEventHandler _onValueChanged; // 0x230
		[CustomObfuscation] // 0x000000018015F270-0x000000018015F2D0
		[SerializeField] // 0x000000018015F270-0x000000018015F2D0
		[Tooltip] // 0x000000018015F270-0x000000018015F2D0
		private ValueChangedEventHandler _onStickPositionChanged; // 0x238
		[CustomObfuscation] // 0x000000018015F690-0x000000018015F6F0
		[SerializeField] // 0x000000018015F690-0x000000018015F6F0
		[Tooltip] // 0x000000018015F690-0x000000018015F6F0
		private TouchStartedEventHandler _onTouchStarted; // 0x240
		[CustomObfuscation] // 0x00000001800C5270-0x00000001800C52B0
		[SerializeField] // 0x00000001800C5270-0x00000001800C52B0
		private TouchEndedEventHandler _onTouchEnded; // 0x248
		[CustomObfuscation] // 0x0000000180160E40-0x0000000180160EA0
		[SerializeField] // 0x0000000180160E40-0x0000000180160EA0
		[Tooltip] // 0x0000000180160E40-0x0000000180160EA0
		private TapEventHandler _onTap; // 0x250
		private Dictionary<int, PointerEventData> __fakePointerEventData; // 0x258
		private static QGjnOCnHKfrjIqlAonYthHKMREQ.EventFunction<IValueChangedHandler, Vector2> __valueChangedHandlerDelegate; // 0x00
		private static QGjnOCnHKfrjIqlAonYthHKMREQ.EventFunction<IStickPositionChangedHandler, Vector2> __stickPositionChangedHandlerDelegate; // 0x08
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private static QGjnOCnHKfrjIqlAonYthHKMREQ.EventFunction<IValueChangedHandler, Vector2> CS$<>9__CachedAnonymousMethodDelegate8; // 0x10
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private static QGjnOCnHKfrjIqlAonYthHKMREQ.EventFunction<IStickPositionChangedHandler, Vector2> CS$<>9__CachedAnonymousMethodDelegatea; // 0x18
	
		// Properties
		public CustomControllerElementTargetSetForFloat horizontalAxisCustomControllerElement { get; } // 0x00000001803BD350-0x00000001803BD360 
		public CustomControllerElementTargetSetForFloat verticalAxisCustomControllerElement { get; } // 0x00000001803BD390-0x00000001803BD3A0 
		public CustomControllerElementTargetSetForBoolean tapCustomControllerElement { get; } // 0x00000001803BD3B0-0x00000001803BD3C0 
		public RectTransform stickTransform { get; set; } // 0x00000001803BD3E0-0x00000001803BD3F0 0x000000018191B110-0x000000018191B1D0
		public JoystickMode joystickMode { get; set; } // 0x0000000180A98E90-0x0000000180A98EA0 0x000000018191ABE0-0x000000018191AC00
		public float digitalModeDeadZone { get; set; } // 0x0000000181919BF0-0x0000000181919C00 0x000000018191AB20-0x000000018191AB70
		public float stickRange { get; set; } // 0x00000001810E2340-0x00000001810E2350 0x000000018191B080-0x000000018191B110
		public bool scaleStickRange { get; set; } // 0x0000000181441600-0x0000000181441610 0x000000018191AF20-0x000000018191AF50
		private StickBounds stickBounds { get; set; } // 0x0000000181919E90-0x0000000181919EA0 0x000000018191B060-0x000000018191B080
		public AxisDirection axesToUse { get; set; } // 0x0000000181919680-0x0000000181919690 0x000000018191AAC0-0x000000018191AB00
		public SnapDirections snapDirections { get; set; } // 0x000000018081D990-0x000000018081D9A0 0x000000018191AF50-0x000000018191AFC0
		public bool snapStickToTouch { get; set; } // 0x0000000181441660-0x0000000181441670 0x000000018191AFC0-0x000000018191AFF0
		public bool centerStickOnRelease { get; set; } // 0x0000000181919BE0-0x0000000181919BF0 0x000000018191AB00-0x000000018191AB20
		public bool activateOnSwipeIn { get; set; } // 0x0000000181919640-0x0000000181919650 0x000000018191AA10-0x000000018191AA30
		public bool stayActiveOnSwipeOut { get; set; } // 0x0000000181919E00-0x0000000181919E90 0x000000018191AFF0-0x000000018191B060
		public bool allowTap { get; set; } // 0x0000000181919650-0x0000000181919660 0x000000018191AA30-0x000000018191AA80
		public float tapTimeout { get; set; } // 0x0000000181919F90-0x0000000181919FA0 0x000000018191B250-0x000000018191B2A0
		public int tapDistanceLimit { get; set; } // 0x0000000180CB77D0-0x0000000180CB77E0 0x000000018191B1D0-0x000000018191B250
		public TouchRegion touchRegion { get; set; } // 0x000000018081E0E0-0x000000018081E0F0 0x000000018191B2A0-0x000000018191B340
		public bool useTouchRegionOnly { get; set; } // 0x000000018191A060-0x000000018191A070 0x000000018191B340-0x000000018191B390
		public bool moveToTouchPosition { get; set; } // 0x0000000181919DC0-0x0000000181919DD0 0x000000018191ADC0-0x000000018191ADF0
		public bool returnOnRelease { get; set; } // 0x0000000181919DF0-0x0000000181919E00 0x000000018191AE90-0x000000018191AEC0
		public bool followTouchPosition { get; set; } // 0x0000000181919C30-0x0000000181919C40 0x000000018191AB70-0x000000018191ABE0
		public bool animateOnMoveToTouch { get; set; } // 0x0000000181919660-0x0000000181919670 0x000000018191AA80-0x000000018191AAA0
		public float moveToTouchSpeed { get; set; } // 0x0000000181919DD0-0x0000000181919DE0 0x000000018191ADF0-0x000000018191AE80
		public bool animateOnReturn { get; set; } // 0x0000000181919670-0x0000000181919680 0x000000018191AAA0-0x000000018191AAC0
		public float returnSpeed { get; set; } // 0x0000000180F60230-0x0000000180F60240 0x000000018191AEC0-0x000000018191AF20
		public bool manageRaycasting { get; set; } // 0x0000000181919C90-0x0000000181919CA0 0x000000018191AC00-0x000000018191ADC0
		public AxisCalibration horizontalAxisCalibration { get; } // 0x0000000181919C50-0x0000000181919C90 
		public AxisCalibration verticalAxisCalibration { get; } // 0x000000018191A160-0x000000018191A1A0 
		[Obsolete] // 0x000000018014B020-0x000000018014B050
		public Axis2DCalibration deadZoneType { get; } // 0x0000000181919690-0x00000001819196C0 
		public Axis2DCalibration axis2DCalibration { get; } // 0x0000000181919690-0x00000001819196C0 
		public int pointerId { get; set; } // 0x0000000181919DE0-0x0000000181919DF0 0x000000018191AE80-0x000000018191AE90
		public bool hasPointer { get; } // 0x0000000181919C40-0x0000000181919C50 
		private bool tapValue { get; } // 0x0000000181919FA0-0x0000000181919FC0 
		internal StandaloneAxis2D axis2D { get; } // 0x00000001810E2310-0x00000001810E2320 
		private Action<gcXbbdhodwurOwnETJBwcylSiar> moveStartedDelegate { get; } // 0x0000000181919D40-0x0000000181919DC0 
		private Action<gcXbbdhodwurOwnETJBwcylSiar> moveEndedDelegate { get; } // 0x0000000181919CA0-0x0000000181919D40 
		private int effectivePointerId { get; } // 0x0000000181919C00-0x0000000181919C30 
		private RectTransform touchReferenceTransform { get; } // 0x0000000181919FC0-0x000000018191A060 
		private float calculatedStickRange { get; } // 0x00000001819196C0-0x0000000181919BE0 
		internal static QGjnOCnHKfrjIqlAonYthHKMREQ.EventFunction<IValueChangedHandler, Vector2> valueChangedHandlerDelegate { get; } // 0x000000018191A070-0x000000018191A160 
		internal static QGjnOCnHKfrjIqlAonYthHKMREQ.EventFunction<IStickPositionChangedHandler, Vector2> stickPositionChangedHandlerDelegate { get; } // 0x0000000181919EA0-0x0000000181919F90 
	
		// Events
		public event UnityAction<Vector2> ValueChangedEvent {
			add; // 0x0000000181917800-0x0000000181917860
			remove; // 0x000000018191A9B0-0x000000018191AA10
		}
		public event UnityAction<Vector2> StickPositionChangedEvent {
			add; // 0x0000000181917710-0x0000000181917770
			remove; // 0x000000018191A8C0-0x000000018191A920
		}
		public event UnityAction TouchDownEvent {
			add; // 0x00000001819177A0-0x00000001819177D0
			remove; // 0x000000018191A950-0x000000018191A980
		}
		public event UnityAction TouchUpEvent {
			add; // 0x00000001819177D0-0x0000000181917800
			remove; // 0x000000018191A980-0x000000018191A9B0
		}
		public event UnityAction TapEvent {
			add; // 0x0000000181917770-0x00000001819177A0
			remove; // 0x000000018191A920-0x000000018191A950
		}
	
		// Nested types
		public enum AxisDirection // TypeDefIndex: 5829
		{
			Both = 0,
			Horizontal = 1,
			Vertical = 2
		}
	
		public enum JoystickMode // TypeDefIndex: 5830
		{
			Analog = 0,
			Digital = 1
		}
	
		public enum SnapDirections // TypeDefIndex: 5831
		{
			None = 0,
			Four = 4,
			Eight = 8,
			Sixteen = 16,
			ThirtyTwo = 32,
			SixtyFour = 64
		}
	
		private enum gcXbbdhodwurOwnETJBwcylSiar // TypeDefIndex: 5832
		{
			PoBZZNoYGVGuWkUBxQqhGBhFqWy = 0,
			mECSSpoPNQyVKtfFebLkjUXhvjOu = 1,
			PRJNKxHAbZjpzWKQNbgkjaPwroE = 2
		}
	
		private enum dQfHNopHjGTKEUqCqpYYwYyguiA // TypeDefIndex: 5833
		{
			IjuFlluoMybUtpSqFtBQAlMgUyR = 0,
			gNafaKVthTKHmnfzOTdmjsbShkI = 1
		}
	
		public enum StickBounds // TypeDefIndex: 5834
		{
			Circle = 0,
			Square = 1
		}
	
		[Serializable]
		public class ValueChangedEventHandler : UnityEvent<Vector2> // TypeDefIndex: 5835
		{
			// Constructors
			public ValueChangedEventHandler(); // 0x00000001819227B0-0x00000001819227F0
		}
	
		[Serializable]
		public class StickPositionChangedEventHandler : UnityEvent<Vector2> // TypeDefIndex: 5836
		{
			// Constructors
			public StickPositionChangedEventHandler(); // 0x000000018190C400-0x000000018190C440
		}
	
		[Serializable]
		public class TapEventHandler : UnityEvent // TypeDefIndex: 5837
		{
			// Constructors
			public TapEventHandler(); // 0x0000000180E3CEA0-0x0000000180E3CEB0
		}
	
		[Serializable]
		public class TouchStartedEventHandler : UnityEvent // TypeDefIndex: 5838
		{
			// Constructors
			public TouchStartedEventHandler(); // 0x0000000180E3CEA0-0x0000000180E3CEB0
		}
	
		[Serializable]
		public class TouchEndedEventHandler : UnityEvent // TypeDefIndex: 5839
		{
			// Constructors
			public TouchEndedEventHandler(); // 0x0000000180E3CEA0-0x0000000180E3CEB0
		}
	
		public interface IValueChangedHandler // TypeDefIndex: 5840
		{
			// Methods
			void OnValueChanged(Vector2 value);
		}
	
		public interface IStickPositionChangedHandler // TypeDefIndex: 5841
		{
			// Methods
			void OnStickPositionChanged(Vector2 value);
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class ChhuqjKzjZEgtodzvsOdtfgDbpX : IEnumerator<object> // TypeDefIndex: 5842
		{
			// Fields
			private object aSrFEaALHwhGTdXfCdeUqgbwaZGO; // 0x10
			private int eLrUhJFgzEZElCzdKvcrgOLXLvL; // 0x18
			public TouchJoystick gKPmvKLRxdGbmXiMfUeDjGbezUo; // 0x20
			public Vector2 erbciXuQzvXBDMaFjGkagbhOrZjH; // 0x28
			public PositionType gsIBthPMxNSjTSPdlhOsjYocNQz; // 0x30
			public float zIXUTQwEaFVKXvZqArCygkLbdpS; // 0x34
			public gcXbbdhodwurOwnETJBwcylSiar TDpRDgoLGUwPwbAPrEacJremjSL; // 0x38
			public RectTransform KWiVBtYMAxLjNwJTcPuoiRyKorN; // 0x40
			public Vector2 mMVXZEGANgtlZZIVPpfpYBluCKn; // 0x48
			public float AHBcbxaWufAsomMWKiZtEejxYSEa; // 0x50
			public float fRhPQVHSPgpHFESwsOktBuoEJue; // 0x54
			public float DavKrllVkEGxMbICSXJqlYpthsH; // 0x58
	
			// Properties
			object QGqPetJmjramAjqiOgIAXgxEFKEb { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018036AC80-0x000000018036AC90 
			object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018036AC80-0x000000018036AC90 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public ChhuqjKzjZEgtodzvsOdtfgDbpX(int <>1__state); // 0x0000000181446CC0-0x0000000181446CF0
	
			// Methods
			private bool MoveNext(); // 0x0000000181905F50-0x0000000181906350
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x0000000181906350-0x00000001819063A0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		}
	
		// Constructors
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		private TouchJoystick(); // 0x00000001819174A0-0x0000000181917710
	
		// Methods
		public Vector2 GetValue(); // 0x0000000181912F70-0x0000000181912FB0
		public Vector2 GetRawValue(); // 0x0000000181912F30-0x0000000181912F70
		public void SetRawValue(Vector2 value); // 0x00000001819164F0-0x0000000181916800
		public void SetDefaultPosition(); // 0x0000000181916460-0x00000001819164F0
		private void dTXVOGLPClUVVAAKVYflcVbiQsm(Vector2 param_0000c757); // 0x0000000181918700-0x0000000181918710
		public void ReturnToDefaultPosition(bool instant); // 0x00000001819161F0-0x0000000181916270
		public void ReturnToDefaultPosition(); // 0x0000000181916270-0x00000001819162E0
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		internal override void Awake(); // 0x0000000181911D50-0x0000000181911EF0
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		internal override void OnEnable(); // 0x00000001819155E0-0x0000000181915710
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		internal override void OnDisable(); // 0x0000000181915470-0x00000001819154F0
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		internal override void OnValidate(); // 0x00000001819161A0-0x00000001819161F0
		internal override void OnUpdate(); // 0x0000000181916140-0x00000001819161A0
		internal override bool OnInitialize(); // 0x0000000181915870-0x00000001819158C0
		internal override void OnCustomControllerUpdate(); // 0x0000000181915260-0x0000000181915470
		internal override void OnSubscribeEvents(); // 0x0000000181916020-0x00000001819160B0
		internal override void OnUnsubscribeEvents(); // 0x00000001819160B0-0x0000000181916140
		internal override void OnSetProperty(); // 0x0000000181915FE0-0x0000000181916020
		internal override void OnClear(); // 0x0000000181915030-0x0000000181915260
		internal override void FindEventHandlers(); // 0x0000000181912C30-0x0000000181912F30
		public override void ClearValue(); // 0x0000000181911F70-0x0000000181912090
		internal override bool IsPressed(); // 0x0000000181913180-0x00000001819131B0
		internal override bool IsThisOrTouchRegionGameObject(GameObject param_0000c759); // 0x00000001819131B0-0x0000000181913350
		private new void LZtLIradkTZxeuvnkQoCvQBxNXr(); // 0x0000000181913350-0x0000000181913440
		private void NKNlCydnlBXQIccJquXuGYsvTVq(); // 0x0000000181914730-0x00000001819147A0
		private bool jhXSzEmmmcbBXISYrRykAelTKSy(); // 0x000000018191A590-0x000000018191A620
		private void WJRFWQuAuTbmrIPDuIrBAMWNGJy(TouchRegion param_0000c75a); // 0x0000000181916CA0-0x0000000181916F50
		private void YqUIagmZmDqhZOmwzYYjTAKNMXM(TouchRegion param_0000c75b); // 0x0000000181916F50-0x0000000181917260
		private void dolfYmltAUQEwCZveRlESRdKGhK(); // 0x00000001819187F0-0x00000001819188A0
		private void EJfFBWkyvJGCMjDZNhsCIYvpicRr(Vector2 param_0000c75c, bool param_0000c75d, float param_0000c75e, gcXbbdhodwurOwnETJBwcylSiar param_0000c75f); // 0x0000000181912090-0x00000001819123C0
		private void ETDmhjkAFEjajzDWGdMEpMSELEy(Vector2 param_0000c760, PositionType param_0000c761, bool param_0000c762, float param_0000c763, gcXbbdhodwurOwnETJBwcylSiar param_0000c764); // 0x00000001819123C0-0x0000000181912A20
		private IEnumerator MOcSsANHfuirGhceqnWqTPXDixq(Vector2 param_0000c765, PositionType param_0000c766, float param_0000c767, gcXbbdhodwurOwnETJBwcylSiar param_0000c768); // 0x0000000181913AD0-0x0000000181913B70
		private void ipDAEIEeQzEPxaXwvPCRTSQaTzs(gcXbbdhodwurOwnETJBwcylSiar param_0000c769, Vector2 param_0000c76a, PositionType param_0000c76b); // 0x000000018191A3B0-0x000000018191A590
		private void eVfAjyGWfOpyeqSVAiMULCjiULEV(gcXbbdhodwurOwnETJBwcylSiar param_0000c76c); // 0x0000000181919060-0x0000000181919290
		private void zSKRLImfJTUTUZRnAFIzkXGPEHJ(gcXbbdhodwurOwnETJBwcylSiar param_0000c76d); // 0x000000018191BC30-0x000000018191BED0
		private void CThRbRrJcLCZffvskgRNVWKvuHvv(); // 0x0000000181911EF0-0x0000000181911F70
		private void hYTALhDtqSGyQwuWJydLApykXsV(int param_0000c76e, Vector2 param_0000c76f, PositionType param_0000c770); // 0x000000018191A1A0-0x000000018191A3B0
		private void MsGuhXEMmfanqTAvXbqFjDUICT(); // 0x0000000181913B70-0x0000000181914730
		private void ZZYGIlXqqUsylsfQBQmTnvRyFpn(); // 0x0000000181917260-0x00000001819174A0
		private void zxcfAcvnwhOviPQlyJevzmGbgxl(ref Vector2 param_0000c771); // 0x000000018191BED0-0x000000018191C060
		private bool oXEQziPQfUdlQaIpThRiZSJBOXU(); // 0x000000018191A7D0-0x000000018191A860
		private void OZFNDbURhVZKFtFmWGnJgPfugYpe(); // 0x0000000181914EC0-0x0000000181914EE0
		private bool dhOQlLJinYpERxCGGhjOgbBZapAV(int param_0000c772); // 0x0000000181918710-0x00000001819187F0
		private PointerEventData LlGMCNteBCahnPiqWbTrHoAGivp(int param_0000c773, GameObject param_0000c774); // 0x0000000181913440-0x0000000181913AD0
		private PointerEventData IeozbiZwrTQxWvulmeRKsKBLdtja(int param_0000c775, GameObject param_0000c776); // 0x0000000181912FB0-0x0000000181913180
		private PointerEventData AMQXfcKdkhATGEHBZPeTJWJpfSUA(int param_0000c777); // 0x0000000181911B50-0x0000000181911D50
		private void cuuvieNpgXrCVXOlgxCyYFCjPIj(PointerEventData param_0000c778); // 0x0000000181917F10-0x0000000181917F70
		private void tKykQvIfDZdusfkIyNODKYFDRBzn(PointerEventData param_0000c779, dQfHNopHjGTKEUqCqpYYwYyguiA param_0000c77a); // 0x000000018191B390-0x000000018191B560
		private PointerEventData gEzDDiQGlFHTAMAVPqWluKHtuyP(int param_0000c77b); // 0x0000000181919290-0x0000000181919560
		private void ngSCpflbmnAmEnJEbHrUjRCLHCB(); // 0x000000018191A620-0x000000018191A7D0
		private void dzynYViRaRMlteHKPpYVKSjcRik(AxisDirection param_0000c77c); // 0x0000000181918990-0x0000000181918CB0
		private void RxEZUnGIHFENEtIpjktQHvdabdW(PointerEventData param_0000c77d, dQfHNopHjGTKEUqCqpYYwYyguiA param_0000c77e); // 0x00000001819162E0-0x0000000181916460
		private void uyQABlNHvFbAnbhXXlzvvLWQhYr(PointerEventData param_0000c77f, dQfHNopHjGTKEUqCqpYYwYyguiA param_0000c780); // 0x000000018191B660-0x000000018191B740
		private void cMtnsaxGhUfiDcRwjkYxflgBASiH(PointerEventData param_0000c781, dQfHNopHjGTKEUqCqpYYwYyguiA param_0000c782); // 0x0000000181917860-0x0000000181917F10
		private void EzJjjNAhQSmydhBVfCMGbRhVYoAK(PointerEventData param_0000c783, dQfHNopHjGTKEUqCqpYYwYyguiA param_0000c784); // 0x0000000181912A20-0x0000000181912C30
		private void NaxMXWWrcEDWOMwpOBVjxDXfhyc(PointerEventData param_0000c785, dQfHNopHjGTKEUqCqpYYwYyguiA param_0000c786); // 0x00000001819147A0-0x0000000181914890
		private void czKUQrdBFVztjcAEscNnkHonxUYG(PointerEventData param_0000c787, dQfHNopHjGTKEUqCqpYYwYyguiA param_0000c788); // 0x0000000181917F70-0x0000000181918700
		private void gYIxSjvLpDuDJzEvUgsIBEBNzaca(PointerEventData param_0000c789, dQfHNopHjGTKEUqCqpYYwYyguiA param_0000c78a); // 0x0000000181919560-0x0000000181919640
		private void eCctVKDNgyQGyeaOcqjOyVlLJqO(int param_0000c78b, Vector2 param_0000c78c, dQfHNopHjGTKEUqCqpYYwYyguiA param_0000c78d); // 0x0000000181918CB0-0x0000000181919060
		private void vFVybIPqofnIcLfQTuNwraHYvlu(); // 0x000000018191B740-0x000000018191BA10
		internal override void OnPointerUp(PointerEventData eventData); // 0x0000000181915E10-0x0000000181915FE0
		internal override void OnPointerDown(PointerEventData eventData); // 0x00000001819158C0-0x0000000181915B70
		internal override void OnPointerEnter(PointerEventData eventData); // 0x0000000181915B70-0x0000000181915CC0
		internal override void OnPointerExit(PointerEventData eventData); // 0x0000000181915CC0-0x0000000181915E10
		internal override void OnBeginDrag(PointerEventData eventData); // 0x0000000181914EE0-0x0000000181915030
		internal override void OnDrag(PointerEventData eventData); // 0x00000001819154F0-0x00000001819155E0
		internal override void OnEndDrag(PointerEventData eventData); // 0x0000000181915710-0x0000000181915870
		private void UNbcuuayGpcyfmiBZBuudIKuPfc(PointerEventData param_0000c795); // 0x00000001819169A0-0x0000000181916BE0
		private void dqhSGzzGTuUAkDceFrBwijGXgMqA(PointerEventData param_0000c796); // 0x00000001819188A0-0x0000000181918990
		private void tXfPLNiZkWIqEpphZBMXLxItsJO(PointerEventData param_0000c797); // 0x000000018191B560-0x000000018191B660
		private void wRoAvqliQBrNDpVMGkCGlhCaNXc(PointerEventData param_0000c798); // 0x000000018191BAD0-0x000000018191BBD0
		private void veoAvtETrmSVgFBRnPEzNfqYUnP(PointerEventData param_0000c799); // 0x000000018191BA10-0x000000018191BAD0
		private void VyQIRuOzDcNxlMozvtpmjYdwota(PointerEventData param_0000c79a); // 0x0000000181916BE0-0x0000000181916CA0
		private void ShGddjbrphbUjSnkvkwcNqVZYzF(PointerEventData param_0000c79b); // 0x0000000181916800-0x00000001819169A0
		private void NwZAfFRzJtqbomIKNDDNEtFbGxU(Vector2 param_0000c79c); // 0x0000000181914890-0x0000000181914EC0
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private static void xiDAyOOljHLvPHitOKirhftKRdS(IValueChangedHandler param_0000c79d, Vector2 param_0000c79e); // 0x000000018191BBD0-0x000000018191BC30
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private static void qtchySVbZFsyqXnAewCIpkJMuVz(IStickPositionChangedHandler param_0000c79f, Vector2 param_0000c7a0); // 0x000000018191A860-0x000000018191A8C0
	}
}
