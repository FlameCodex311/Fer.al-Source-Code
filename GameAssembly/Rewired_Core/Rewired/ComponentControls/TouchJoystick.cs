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

// Image 51: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5871-7113

namespace Rewired.ComponentControls
{
	[Serializable]
	[DisallowMultipleComponent] // 0x00000001801CDAD0-0x00000001801CDAE0
	public sealed class TouchJoystick : TouchInteractable // TypeDefIndex: 5987
	{
		// Fields
		private const float MAX_MOVE_SPEED = 20f; // Metadata: 0x00763929
		[CustomObfuscation] // 0x00000001801F4180-0x00000001801F41E0
		[SerializeField] // 0x00000001801F4180-0x00000001801F41E0
		[Tooltip] // 0x00000001801F4180-0x00000001801F41E0
		private CustomControllerElementTargetSetForFloat _horizontalAxisCustomControllerElement; // 0x128
		[CustomObfuscation] // 0x00000001801F4520-0x00000001801F4580
		[SerializeField] // 0x00000001801F4520-0x00000001801F4580
		[Tooltip] // 0x00000001801F4520-0x00000001801F4580
		private CustomControllerElementTargetSetForFloat _verticalAxisCustomControllerElement; // 0x130
		[CustomObfuscation] // 0x00000001801F4990-0x00000001801F49F0
		[SerializeField] // 0x00000001801F4990-0x00000001801F49F0
		[Tooltip] // 0x00000001801F4990-0x00000001801F49F0
		private CustomControllerElementTargetSetForBoolean _tapCustomControllerElement; // 0x138
		[CustomObfuscation] // 0x00000001801F5070-0x00000001801F50D0
		[SerializeField] // 0x00000001801F5070-0x00000001801F50D0
		[Tooltip] // 0x00000001801F5070-0x00000001801F50D0
		private RectTransform _stickTransform; // 0x140
		[CustomObfuscation] // 0x00000001801F5420-0x00000001801F5480
		[SerializeField] // 0x00000001801F5420-0x00000001801F5480
		[Tooltip] // 0x00000001801F5420-0x00000001801F5480
		private JoystickMode _joystickMode; // 0x148
		[CustomObfuscation] // 0x00000001801F5840-0x00000001801F58C0
		[Range] // 0x00000001801F5840-0x00000001801F58C0
		[SerializeField] // 0x00000001801F5840-0x00000001801F58C0
		[Tooltip] // 0x00000001801F5840-0x00000001801F58C0
		private float _digitalModeDeadZone; // 0x14C
		[CustomObfuscation] // 0x00000001801F5BC0-0x00000001801F5C40
		[Range] // 0x00000001801F5BC0-0x00000001801F5C40
		[SerializeField] // 0x00000001801F5BC0-0x00000001801F5C40
		[Tooltip] // 0x00000001801F5BC0-0x00000001801F5C40
		private float _stickRange; // 0x150
		[CustomObfuscation] // 0x00000001801F73B0-0x00000001801F7410
		[SerializeField] // 0x00000001801F73B0-0x00000001801F7410
		[Tooltip] // 0x00000001801F73B0-0x00000001801F7410
		private bool _scaleStickRange; // 0x154
		[CustomObfuscation] // 0x00000001801F7830-0x00000001801F7890
		[SerializeField] // 0x00000001801F7830-0x00000001801F7890
		[Tooltip] // 0x00000001801F7830-0x00000001801F7890
		private StickBounds _stickBounds; // 0x158
		[CustomObfuscation] // 0x00000001801F7A70-0x00000001801F7AD0
		[SerializeField] // 0x00000001801F7A70-0x00000001801F7AD0
		[Tooltip] // 0x00000001801F7A70-0x00000001801F7AD0
		private AxisDirection _axesToUse; // 0x15C
		[CustomObfuscation] // 0x00000001801F7DA0-0x00000001801F7E00
		[SerializeField] // 0x00000001801F7DA0-0x00000001801F7E00
		[Tooltip] // 0x00000001801F7DA0-0x00000001801F7E00
		private SnapDirections _snapDirections; // 0x160
		[CustomObfuscation] // 0x00000001801F9330-0x00000001801F9390
		[SerializeField] // 0x00000001801F9330-0x00000001801F9390
		[Tooltip] // 0x00000001801F9330-0x00000001801F9390
		private bool _snapStickToTouch; // 0x164
		[CustomObfuscation] // 0x00000001801F96C0-0x00000001801F9720
		[SerializeField] // 0x00000001801F96C0-0x00000001801F9720
		[Tooltip] // 0x00000001801F96C0-0x00000001801F9720
		private bool _centerStickOnRelease; // 0x165
		[CustomObfuscation] // 0x00000001801F9940-0x00000001801F99A0
		[SerializeField] // 0x00000001801F9940-0x00000001801F99A0
		[Tooltip] // 0x00000001801F9940-0x00000001801F99A0
		private StandaloneAxis2D _axis2D; // 0x168
		[CustomObfuscation] // 0x00000001801F9E20-0x00000001801F9E80
		[SerializeField] // 0x00000001801F9E20-0x00000001801F9E80
		[Tooltip] // 0x00000001801F9E20-0x00000001801F9E80
		private bool _activateOnSwipeIn; // 0x170
		[CustomObfuscation] // 0x00000001801FA300-0x00000001801FA360
		[SerializeField] // 0x00000001801FA300-0x00000001801FA360
		[Tooltip] // 0x00000001801FA300-0x00000001801FA360
		private bool _stayActiveOnSwipeOut; // 0x171
		[CustomObfuscation] // 0x00000001801FA6A0-0x00000001801FA700
		[SerializeField] // 0x00000001801FA6A0-0x00000001801FA700
		[Tooltip] // 0x00000001801FA6A0-0x00000001801FA700
		private bool _allowTap; // 0x172
		[CustomObfuscation] // 0x00000001801FA920-0x00000001801FA9A0
		[FieldRange] // 0x00000001801FA920-0x00000001801FA9A0
		[SerializeField] // 0x00000001801FA920-0x00000001801FA9A0
		[Tooltip] // 0x00000001801FA920-0x00000001801FA9A0
		private float _tapTimeout; // 0x174
		[CustomObfuscation] // 0x00000001801FACF0-0x00000001801FAD70
		[FieldRange] // 0x00000001801FACF0-0x00000001801FAD70
		[SerializeField] // 0x00000001801FACF0-0x00000001801FAD70
		[Tooltip] // 0x00000001801FACF0-0x00000001801FAD70
		private int _tapDistanceLimit; // 0x178
		[CustomObfuscation] // 0x00000001801FAFB0-0x00000001801FB010
		[SerializeField] // 0x00000001801FAFB0-0x00000001801FB010
		[Tooltip] // 0x00000001801FAFB0-0x00000001801FB010
		private TouchRegion _touchRegion; // 0x180
		[CustomObfuscation] // 0x00000001801FB350-0x00000001801FB3B0
		[SerializeField] // 0x00000001801FB350-0x00000001801FB3B0
		[Tooltip] // 0x00000001801FB350-0x00000001801FB3B0
		private bool _useTouchRegionOnly; // 0x188
		[CustomObfuscation] // 0x00000001801FB5A0-0x00000001801FB600
		[SerializeField] // 0x00000001801FB5A0-0x00000001801FB600
		[Tooltip] // 0x00000001801FB5A0-0x00000001801FB600
		private bool _moveToTouchPosition; // 0x189
		[CustomObfuscation] // 0x00000001801FCD20-0x00000001801FCD80
		[SerializeField] // 0x00000001801FCD20-0x00000001801FCD80
		[Tooltip] // 0x00000001801FCD20-0x00000001801FCD80
		private bool _returnOnRelease; // 0x18A
		[CustomObfuscation] // 0x00000001801FD1B0-0x00000001801FD210
		[SerializeField] // 0x00000001801FD1B0-0x00000001801FD210
		[Tooltip] // 0x00000001801FD1B0-0x00000001801FD210
		private bool _followTouchPosition; // 0x18B
		[CustomObfuscation] // 0x00000001801FD5B0-0x00000001801FD610
		[SerializeField] // 0x00000001801FD5B0-0x00000001801FD610
		[Tooltip] // 0x00000001801FD5B0-0x00000001801FD610
		private bool _animateOnMoveToTouch; // 0x18C
		[CustomObfuscation] // 0x00000001801FDAE0-0x00000001801FDB60
		[Range] // 0x00000001801FDAE0-0x00000001801FDB60
		[SerializeField] // 0x00000001801FDAE0-0x00000001801FDB60
		[Tooltip] // 0x00000001801FDAE0-0x00000001801FDB60
		private float _moveToTouchSpeed; // 0x190
		[CustomObfuscation] // 0x00000001801FDF50-0x00000001801FDFB0
		[SerializeField] // 0x00000001801FDF50-0x00000001801FDFB0
		[Tooltip] // 0x00000001801FDF50-0x00000001801FDFB0
		private bool _animateOnReturn; // 0x194
		[CustomObfuscation] // 0x00000001801FE380-0x00000001801FE400
		[Range] // 0x00000001801FE380-0x00000001801FE400
		[SerializeField] // 0x00000001801FE380-0x00000001801FE400
		[Tooltip] // 0x00000001801FE380-0x00000001801FE400
		private float _returnSpeed; // 0x198
		[CustomObfuscation] // 0x00000001801FE7F0-0x00000001801FE850
		[SerializeField] // 0x00000001801FE7F0-0x00000001801FE850
		[Tooltip] // 0x00000001801FE7F0-0x00000001801FE850
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
		[CustomObfuscation] // 0x00000001801FEAD0-0x00000001801FEB30
		[SerializeField] // 0x00000001801FEAD0-0x00000001801FEB30
		[Tooltip] // 0x00000001801FEAD0-0x00000001801FEB30
		private ValueChangedEventHandler _onValueChanged; // 0x230
		[CustomObfuscation] // 0x00000001801FEDE0-0x00000001801FEE40
		[SerializeField] // 0x00000001801FEDE0-0x00000001801FEE40
		[Tooltip] // 0x00000001801FEDE0-0x00000001801FEE40
		private ValueChangedEventHandler _onStickPositionChanged; // 0x238
		[CustomObfuscation] // 0x00000001801FF150-0x00000001801FF1B0
		[SerializeField] // 0x00000001801FF150-0x00000001801FF1B0
		[Tooltip] // 0x00000001801FF150-0x00000001801FF1B0
		private TouchStartedEventHandler _onTouchStarted; // 0x240
		[CustomObfuscation] // 0x00000001801D1070-0x00000001801D10B0
		[SerializeField] // 0x00000001801D1070-0x00000001801D10B0
		private TouchEndedEventHandler _onTouchEnded; // 0x248
		[CustomObfuscation] // 0x00000001801FF6C0-0x00000001801FF720
		[SerializeField] // 0x00000001801FF6C0-0x00000001801FF720
		[Tooltip] // 0x00000001801FF6C0-0x00000001801FF720
		private TapEventHandler _onTap; // 0x250
		private Dictionary<int, PointerEventData> __fakePointerEventData; // 0x258
		private static QGjnOCnHKfrjIqlAonYthHKMREQ.EventFunction<IValueChangedHandler, Vector2> __valueChangedHandlerDelegate; // 0x00
		private static QGjnOCnHKfrjIqlAonYthHKMREQ.EventFunction<IStickPositionChangedHandler, Vector2> __stickPositionChangedHandlerDelegate; // 0x08
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private static QGjnOCnHKfrjIqlAonYthHKMREQ.EventFunction<IValueChangedHandler, Vector2> CS$<>9__CachedAnonymousMethodDelegate8; // 0x10
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private static QGjnOCnHKfrjIqlAonYthHKMREQ.EventFunction<IStickPositionChangedHandler, Vector2> CS$<>9__CachedAnonymousMethodDelegatea; // 0x18
	
		// Properties
		public CustomControllerElementTargetSetForFloat horizontalAxisCustomControllerElement { get; } // 0x00000001803EF180-0x00000001803EF190 
		public CustomControllerElementTargetSetForFloat verticalAxisCustomControllerElement { get; } // 0x0000000180383C00-0x0000000180383C10 
		public CustomControllerElementTargetSetForBoolean tapCustomControllerElement { get; } // 0x00000001803EF230-0x00000001803EF240 
		public RectTransform stickTransform { get; set; } // 0x00000001803EF170-0x00000001803EF180 0x00000001810C0E20-0x00000001810C0EE0
		public JoystickMode joystickMode { get; set; } // 0x00000001810600E0-0x00000001810600F0 0x00000001810C08F0-0x00000001810C0910
		public float digitalModeDeadZone { get; set; } // 0x00000001810BF910-0x00000001810BF920 0x00000001810C0830-0x00000001810C0880
		public float stickRange { get; set; } // 0x00000001810BFCA0-0x00000001810BFCB0 0x00000001810C0D90-0x00000001810C0E20
		public bool scaleStickRange { get; set; } // 0x000000018091EDD0-0x000000018091EDE0 0x00000001810C0C30-0x00000001810C0C60
		private StickBounds stickBounds { get; set; } // 0x00000001810BFBA0-0x00000001810BFBB0 0x00000001810C0D70-0x00000001810C0D90
		public AxisDirection axesToUse { get; set; } // 0x000000018058C410-0x000000018058C420 0x00000001810C07D0-0x00000001810C0810
		public SnapDirections snapDirections { get; set; } // 0x000000018051CEA0-0x000000018051CEB0 0x00000001810C0C60-0x00000001810C0CD0
		public bool snapStickToTouch { get; set; } // 0x000000018091EE40-0x000000018091EE50 0x00000001810C0CD0-0x00000001810C0D00
		public bool centerStickOnRelease { get; set; } // 0x00000001810BF900-0x00000001810BF910 0x00000001810C0810-0x00000001810C0830
		public bool activateOnSwipeIn { get; set; } // 0x00000001810BF380-0x00000001810BF390 0x00000001810C0720-0x00000001810C0740
		public bool stayActiveOnSwipeOut { get; set; } // 0x00000001810BFB10-0x00000001810BFBA0 0x00000001810C0D00-0x00000001810C0D70
		public bool allowTap { get; set; } // 0x00000001810BF390-0x00000001810BF3A0 0x00000001810C0740-0x00000001810C0790
		public float tapTimeout { get; set; } // 0x00000001810BFCC0-0x00000001810BFCD0 0x00000001810C0F60-0x00000001810C0FB0
		public int tapDistanceLimit { get; set; } // 0x00000001810BFCB0-0x00000001810BFCC0 0x00000001810C0EE0-0x00000001810C0F60
		public TouchRegion touchRegion { get; set; } // 0x00000001803EF210-0x00000001803EF220 0x00000001810C0FB0-0x00000001810C1050
		public bool useTouchRegionOnly { get; set; } // 0x00000001810BFD80-0x00000001810BFD90 0x00000001810C1050-0x00000001810C10A0
		public bool moveToTouchPosition { get; set; } // 0x00000001810BFAD0-0x00000001810BFAE0 0x00000001810C0AD0-0x00000001810C0B00
		public bool returnOnRelease { get; set; } // 0x00000001810BFB00-0x00000001810BFB10 0x00000001810C0BA0-0x00000001810C0BD0
		public bool followTouchPosition { get; set; } // 0x00000001810BF950-0x00000001810BF960 0x00000001810C0880-0x00000001810C08F0
		public bool animateOnMoveToTouch { get; set; } // 0x00000001810BF3A0-0x00000001810BF3B0 0x00000001810C0790-0x00000001810C07B0
		public float moveToTouchSpeed { get; set; } // 0x00000001810BFAE0-0x00000001810BFAF0 0x00000001810C0B00-0x00000001810C0B90
		public bool animateOnReturn { get; set; } // 0x00000001810BF3B0-0x00000001810BF3C0 0x00000001810C07B0-0x00000001810C07D0
		public float returnSpeed { get; set; } // 0x00000001806295D0-0x00000001806295E0 0x00000001810C0BD0-0x00000001810C0C30
		public bool manageRaycasting { get; set; } // 0x00000001810BF9A0-0x00000001810BF9B0 0x00000001810C0910-0x00000001810C0AD0
		public AxisCalibration horizontalAxisCalibration { get; } // 0x00000001810BF970-0x00000001810BF9A0 
		public AxisCalibration verticalAxisCalibration { get; } // 0x00000001810BFE80-0x00000001810BFEB0 
		[Obsolete] // 0x00000001801E8D70-0x00000001801E8DA0
		public Axis2DCalibration deadZoneType { get; } // 0x00000001810BF3C0-0x00000001810BF3E0 
		public Axis2DCalibration axis2DCalibration { get; } // 0x00000001810BF3C0-0x00000001810BF3E0 
		public int pointerId { get; set; } // 0x00000001810BFAF0-0x00000001810BFB00 0x00000001810C0B90-0x00000001810C0BA0
		public bool hasPointer { get; } // 0x00000001810BF960-0x00000001810BF970 
		private bool tapValue { get; } // 0x00000001810BFCD0-0x00000001810BFCF0 
		internal StandaloneAxis2D axis2D { get; } // 0x000000018058C840-0x000000018058C850 
		private Action<gcXbbdhodwurOwnETJBwcylSiar> moveStartedDelegate { get; } // 0x00000001810BFA50-0x00000001810BFAD0 
		private Action<gcXbbdhodwurOwnETJBwcylSiar> moveEndedDelegate { get; } // 0x00000001810BF9B0-0x00000001810BFA50 
		private int effectivePointerId { get; } // 0x00000001810BF920-0x00000001810BF950 
		private RectTransform touchReferenceTransform { get; } // 0x00000001810BFCF0-0x00000001810BFD80 
		private float calculatedStickRange { get; } // 0x00000001810BF3E0-0x00000001810BF900 
		internal static QGjnOCnHKfrjIqlAonYthHKMREQ.EventFunction<IValueChangedHandler, Vector2> valueChangedHandlerDelegate { get; } // 0x00000001810BFD90-0x00000001810BFE80 
		internal static QGjnOCnHKfrjIqlAonYthHKMREQ.EventFunction<IStickPositionChangedHandler, Vector2> stickPositionChangedHandlerDelegate { get; } // 0x00000001810BFBB0-0x00000001810BFCA0 
	
		// Events
		public event UnityAction<Vector2> ValueChangedEvent {
			add; // 0x00000001810BD570-0x00000001810BD5D0
			remove; // 0x00000001810C06C0-0x00000001810C0720
		}
		public event UnityAction<Vector2> StickPositionChangedEvent {
			add; // 0x00000001810BD480-0x00000001810BD4E0
			remove; // 0x00000001810C05D0-0x00000001810C0630
		}
		public event UnityAction TouchDownEvent {
			add; // 0x00000001810BD510-0x00000001810BD540
			remove; // 0x00000001810C0660-0x00000001810C0690
		}
		public event UnityAction TouchUpEvent {
			add; // 0x00000001810BD540-0x00000001810BD570
			remove; // 0x00000001810C0690-0x00000001810C06C0
		}
		public event UnityAction TapEvent {
			add; // 0x00000001810BD4E0-0x00000001810BD510
			remove; // 0x00000001810C0630-0x00000001810C0660
		}
	
		// Nested types
		public enum AxisDirection // TypeDefIndex: 5988
		{
			Both = 0,
			Horizontal = 1,
			Vertical = 2
		}
	
		public enum JoystickMode // TypeDefIndex: 5989
		{
			Analog = 0,
			Digital = 1
		}
	
		public enum SnapDirections // TypeDefIndex: 5990
		{
			None = 0,
			Four = 4,
			Eight = 8,
			Sixteen = 16,
			ThirtyTwo = 32,
			SixtyFour = 64
		}
	
		private enum gcXbbdhodwurOwnETJBwcylSiar // TypeDefIndex: 5991
		{
			PoBZZNoYGVGuWkUBxQqhGBhFqWy = 0,
			mECSSpoPNQyVKtfFebLkjUXhvjOu = 1,
			PRJNKxHAbZjpzWKQNbgkjaPwroE = 2
		}
	
		private enum dQfHNopHjGTKEUqCqpYYwYyguiA // TypeDefIndex: 5992
		{
			IjuFlluoMybUtpSqFtBQAlMgUyR = 0,
			gNafaKVthTKHmnfzOTdmjsbShkI = 1
		}
	
		public enum StickBounds // TypeDefIndex: 5993
		{
			Circle = 0,
			Square = 1
		}
	
		[Serializable]
		public class ValueChangedEventHandler : UnityEvent<Vector2> // TypeDefIndex: 5994
		{
			// Constructors
			public ValueChangedEventHandler(); // 0x00000001810C83E0-0x00000001810C8420
		}
	
		[Serializable]
		public class StickPositionChangedEventHandler : UnityEvent<Vector2> // TypeDefIndex: 5995
		{
			// Constructors
			public StickPositionChangedEventHandler(); // 0x00000001810B2260-0x00000001810B22A0
		}
	
		[Serializable]
		public class TapEventHandler : UnityEvent // TypeDefIndex: 5996
		{
			// Constructors
			public TapEventHandler(); // 0x0000000180372000-0x0000000180372010
		}
	
		[Serializable]
		public class TouchStartedEventHandler : UnityEvent // TypeDefIndex: 5997
		{
			// Constructors
			public TouchStartedEventHandler(); // 0x0000000180372000-0x0000000180372010
		}
	
		[Serializable]
		public class TouchEndedEventHandler : UnityEvent // TypeDefIndex: 5998
		{
			// Constructors
			public TouchEndedEventHandler(); // 0x0000000180372000-0x0000000180372010
		}
	
		public interface IValueChangedHandler // TypeDefIndex: 5999
		{
			// Methods
			void OnValueChanged(Vector2 value);
		}
	
		public interface IStickPositionChangedHandler // TypeDefIndex: 6000
		{
			// Methods
			void OnStickPositionChanged(Vector2 value);
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class ChhuqjKzjZEgtodzvsOdtfgDbpX : IEnumerator<object> // TypeDefIndex: 6001
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
			object QGqPetJmjramAjqiOgIAXgxEFKEb { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372440-0x0000000180372450 
			object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372440-0x0000000180372450 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public ChhuqjKzjZEgtodzvsOdtfgDbpX(int <>1__state); // 0x0000000180924460-0x0000000180924490
	
			// Methods
			private bool MoveNext(); // 0x00000001810ABF10-0x00000001810AC310
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x00000001810AC310-0x00000001810AC360
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		}
	
		// Constructors
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		private TouchJoystick(); // 0x00000001810BD210-0x00000001810BD480
	
		// Methods
		public Vector2 GetValue(); // 0x00000001810B8D20-0x00000001810B8D60
		public Vector2 GetRawValue(); // 0x00000001810B8CE0-0x00000001810B8D20
		public void SetRawValue(Vector2 value); // 0x00000001810BC270-0x00000001810BC580
		public void SetDefaultPosition(); // 0x00000001810BC1E0-0x00000001810BC270
		private void dTXVOGLPClUVVAAKVYflcVbiQsm(Vector2 param_0000c9c7); // 0x00000001810BE460-0x00000001810BE470
		public void ReturnToDefaultPosition(bool instant); // 0x00000001810BBF70-0x00000001810BBFF0
		public void ReturnToDefaultPosition(); // 0x00000001810BBFF0-0x00000001810BC060
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		internal override void Awake(); // 0x00000001810B7B20-0x00000001810B7CC0
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		internal override void OnEnable(); // 0x00000001810BB360-0x00000001810BB490
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		internal override void OnDisable(); // 0x00000001810BB1F0-0x00000001810BB270
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		internal override void OnValidate(); // 0x00000001810BBF20-0x00000001810BBF70
		internal override void OnUpdate(); // 0x00000001810BBEC0-0x00000001810BBF20
		internal override bool OnInitialize(); // 0x00000001810BB5F0-0x00000001810BB640
		internal override void OnCustomControllerUpdate(); // 0x00000001810BAFE0-0x00000001810BB1F0
		internal override void OnSubscribeEvents(); // 0x00000001810BBDA0-0x00000001810BBE30
		internal override void OnUnsubscribeEvents(); // 0x00000001810BBE30-0x00000001810BBEC0
		internal override void OnSetProperty(); // 0x00000001810BBD60-0x00000001810BBDA0
		internal override void OnClear(); // 0x00000001810BADB0-0x00000001810BAFE0
		internal override void FindEventHandlers(); // 0x00000001810B89E0-0x00000001810B8CE0
		public override void ClearValue(); // 0x00000001810B7D40-0x00000001810B7E60
		internal override bool IsPressed(); // 0x00000001810B8F30-0x00000001810B8F60
		internal override bool IsThisOrTouchRegionGameObject(GameObject param_0000c9c9); // 0x00000001810B8F60-0x00000001810B9100
		private new void LZtLIradkTZxeuvnkQoCvQBxNXr(); // 0x00000001810B9100-0x00000001810B91F0
		private void NKNlCydnlBXQIccJquXuGYsvTVq(); // 0x00000001810BA4C0-0x00000001810BA530
		private bool jhXSzEmmmcbBXISYrRykAelTKSy(); // 0x00000001810C02A0-0x00000001810C0330
		private void WJRFWQuAuTbmrIPDuIrBAMWNGJy(TouchRegion param_0000c9ca); // 0x00000001810BCA10-0x00000001810BCCC0
		private void YqUIagmZmDqhZOmwzYYjTAKNMXM(TouchRegion param_0000c9cb); // 0x00000001810BCCC0-0x00000001810BCFD0
		private void dolfYmltAUQEwCZveRlESRdKGhK(); // 0x00000001810BE550-0x00000001810BE600
		private void EJfFBWkyvJGCMjDZNhsCIYvpicRr(Vector2 param_0000c9cc, bool param_0000c9cd, float param_0000c9ce, gcXbbdhodwurOwnETJBwcylSiar param_0000c9cf); // 0x00000001810B7E60-0x00000001810B8190
		private void ETDmhjkAFEjajzDWGdMEpMSELEy(Vector2 param_0000c9d0, PositionType param_0000c9d1, bool param_0000c9d2, float param_0000c9d3, gcXbbdhodwurOwnETJBwcylSiar param_0000c9d4); // 0x00000001810B8190-0x00000001810B87E0
		private IEnumerator MOcSsANHfuirGhceqnWqTPXDixq(Vector2 param_0000c9d5, PositionType param_0000c9d6, float param_0000c9d7, gcXbbdhodwurOwnETJBwcylSiar param_0000c9d8); // 0x00000001810B9870-0x00000001810B9910
		private void ipDAEIEeQzEPxaXwvPCRTSQaTzs(gcXbbdhodwurOwnETJBwcylSiar param_0000c9d9, Vector2 param_0000c9da, PositionType param_0000c9db); // 0x00000001810C00C0-0x00000001810C02A0
		private void eVfAjyGWfOpyeqSVAiMULCjiULEV(gcXbbdhodwurOwnETJBwcylSiar param_0000c9dc); // 0x00000001810BEDB0-0x00000001810BEFE0
		private void zSKRLImfJTUTUZRnAFIzkXGPEHJ(gcXbbdhodwurOwnETJBwcylSiar param_0000c9dd); // 0x00000001810C1930-0x00000001810C1BD0
		private void CThRbRrJcLCZffvskgRNVWKvuHvv(); // 0x00000001810B7CC0-0x00000001810B7D40
		private void hYTALhDtqSGyQwuWJydLApykXsV(int param_0000c9de, Vector2 param_0000c9df, PositionType param_0000c9e0); // 0x00000001810BFEB0-0x00000001810C00C0
		private void MsGuhXEMmfanqTAvXbqFjDUICT(); // 0x00000001810B9910-0x00000001810BA4C0
		private void ZZYGIlXqqUsylsfQBQmTnvRyFpn(); // 0x00000001810BCFD0-0x00000001810BD210
		private void zxcfAcvnwhOviPQlyJevzmGbgxl(ref Vector2 param_0000c9e1); // 0x00000001810C1BD0-0x00000001810C1D60
		private bool oXEQziPQfUdlQaIpThRiZSJBOXU(); // 0x00000001810C04E0-0x00000001810C0570
		private void OZFNDbURhVZKFtFmWGnJgPfugYpe(); // 0x00000001810BAC40-0x00000001810BAC60
		private bool dhOQlLJinYpERxCGGhjOgbBZapAV(int param_0000c9e2); // 0x00000001810BE470-0x00000001810BE550
		private PointerEventData LlGMCNteBCahnPiqWbTrHoAGivp(int param_0000c9e3, GameObject param_0000c9e4); // 0x00000001810B91F0-0x00000001810B9870
		private PointerEventData IeozbiZwrTQxWvulmeRKsKBLdtja(int param_0000c9e5, GameObject param_0000c9e6); // 0x00000001810B8D60-0x00000001810B8F30
		private PointerEventData AMQXfcKdkhATGEHBZPeTJWJpfSUA(int param_0000c9e7); // 0x00000001810B7930-0x00000001810B7B20
		private void cuuvieNpgXrCVXOlgxCyYFCjPIj(PointerEventData param_0000c9e8); // 0x00000001810BDC70-0x00000001810BDCD0
		private void tKykQvIfDZdusfkIyNODKYFDRBzn(PointerEventData param_0000c9e9, dQfHNopHjGTKEUqCqpYYwYyguiA param_0000c9ea); // 0x00000001810C10A0-0x00000001810C1270
		private PointerEventData gEzDDiQGlFHTAMAVPqWluKHtuyP(int param_0000c9eb); // 0x00000001810BEFE0-0x00000001810BF2A0
		private void ngSCpflbmnAmEnJEbHrUjRCLHCB(); // 0x00000001810C0330-0x00000001810C04E0
		private void dzynYViRaRMlteHKPpYVKSjcRik(AxisDirection param_0000c9ec); // 0x00000001810BE6F0-0x00000001810BEA00
		private void RxEZUnGIHFENEtIpjktQHvdabdW(PointerEventData param_0000c9ed, dQfHNopHjGTKEUqCqpYYwYyguiA param_0000c9ee); // 0x00000001810BC060-0x00000001810BC1E0
		private void uyQABlNHvFbAnbhXXlzvvLWQhYr(PointerEventData param_0000c9ef, dQfHNopHjGTKEUqCqpYYwYyguiA param_0000c9f0); // 0x00000001810C1360-0x00000001810C1440
		private void cMtnsaxGhUfiDcRwjkYxflgBASiH(PointerEventData param_0000c9f1, dQfHNopHjGTKEUqCqpYYwYyguiA param_0000c9f2); // 0x00000001810BD5D0-0x00000001810BDC70
		private void EzJjjNAhQSmydhBVfCMGbRhVYoAK(PointerEventData param_0000c9f3, dQfHNopHjGTKEUqCqpYYwYyguiA param_0000c9f4); // 0x00000001810B87E0-0x00000001810B89E0
		private void NaxMXWWrcEDWOMwpOBVjxDXfhyc(PointerEventData param_0000c9f5, dQfHNopHjGTKEUqCqpYYwYyguiA param_0000c9f6); // 0x00000001810BA530-0x00000001810BA620
		private void czKUQrdBFVztjcAEscNnkHonxUYG(PointerEventData param_0000c9f7, dQfHNopHjGTKEUqCqpYYwYyguiA param_0000c9f8); // 0x00000001810BDCD0-0x00000001810BE460
		private void gYIxSjvLpDuDJzEvUgsIBEBNzaca(PointerEventData param_0000c9f9, dQfHNopHjGTKEUqCqpYYwYyguiA param_0000c9fa); // 0x00000001810BF2A0-0x00000001810BF380
		private void eCctVKDNgyQGyeaOcqjOyVlLJqO(int param_0000c9fb, Vector2 param_0000c9fc, dQfHNopHjGTKEUqCqpYYwYyguiA param_0000c9fd); // 0x00000001810BEA00-0x00000001810BEDB0
		private void vFVybIPqofnIcLfQTuNwraHYvlu(); // 0x00000001810C1440-0x00000001810C1710
		internal override void OnPointerUp(PointerEventData eventData); // 0x00000001810BBB90-0x00000001810BBD60
		internal override void OnPointerDown(PointerEventData eventData); // 0x00000001810BB640-0x00000001810BB8F0
		internal override void OnPointerEnter(PointerEventData eventData); // 0x00000001810BB8F0-0x00000001810BBA40
		internal override void OnPointerExit(PointerEventData eventData); // 0x00000001810BBA40-0x00000001810BBB90
		internal override void OnBeginDrag(PointerEventData eventData); // 0x00000001810BAC60-0x00000001810BADB0
		internal override void OnDrag(PointerEventData eventData); // 0x00000001810BB270-0x00000001810BB360
		internal override void OnEndDrag(PointerEventData eventData); // 0x00000001810BB490-0x00000001810BB5F0
		private void UNbcuuayGpcyfmiBZBuudIKuPfc(PointerEventData param_0000ca05); // 0x00000001810BC720-0x00000001810BC950
		private void dqhSGzzGTuUAkDceFrBwijGXgMqA(PointerEventData param_0000ca06); // 0x00000001810BE600-0x00000001810BE6F0
		private void tXfPLNiZkWIqEpphZBMXLxItsJO(PointerEventData param_0000ca07); // 0x00000001810C1270-0x00000001810C1360
		private void wRoAvqliQBrNDpVMGkCGlhCaNXc(PointerEventData param_0000ca08); // 0x00000001810C17D0-0x00000001810C18D0
		private void veoAvtETrmSVgFBRnPEzNfqYUnP(PointerEventData param_0000ca09); // 0x00000001810C1710-0x00000001810C17D0
		private void VyQIRuOzDcNxlMozvtpmjYdwota(PointerEventData param_0000ca0a); // 0x00000001810BC950-0x00000001810BCA10
		private void ShGddjbrphbUjSnkvkwcNqVZYzF(PointerEventData param_0000ca0b); // 0x00000001810BC580-0x00000001810BC720
		private void NwZAfFRzJtqbomIKNDDNEtFbGxU(Vector2 param_0000ca0c); // 0x00000001810BA620-0x00000001810BAC40
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private static void xiDAyOOljHLvPHitOKirhftKRdS(IValueChangedHandler param_0000ca0d, Vector2 param_0000ca0e); // 0x00000001810C18D0-0x00000001810C1930
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private static void qtchySVbZFsyqXnAewCIpkJMuVz(IStickPositionChangedHandler param_0000ca0f, Vector2 param_0000ca10); // 0x00000001810C0570-0x00000001810C05D0
	}
}
