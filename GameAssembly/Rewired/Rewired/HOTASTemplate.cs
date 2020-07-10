/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 78: Rewired.dll - Assembly: Rewired, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9189-9271

namespace Rewired
{
	public sealed class HOTASTemplate : ControllerTemplate, IHOTASTemplate // TypeDefIndex: 9198
	{
		// Fields
		public static readonly Guid typeGuid; // 0x00
		public const int elementId_stickX = 0; // Metadata: 0x00744659
		public const int elementId_stickY = 1; // Metadata: 0x0074465D
		public const int elementId_stickRotate = 2; // Metadata: 0x00744661
		public const int elementId_stickMiniStick1X = 78; // Metadata: 0x00744665
		public const int elementId_stickMiniStick1Y = 79; // Metadata: 0x00744669
		public const int elementId_stickMiniStick1Press = 80; // Metadata: 0x0074466D
		public const int elementId_stickMiniStick2X = 81; // Metadata: 0x00744671
		public const int elementId_stickMiniStick2Y = 82; // Metadata: 0x00744675
		public const int elementId_stickMiniStick2Press = 83; // Metadata: 0x00744679
		public const int elementId_stickTrigger = 3; // Metadata: 0x0074467D
		public const int elementId_stickTriggerStage2 = 4; // Metadata: 0x00744681
		public const int elementId_stickPinkyButton = 5; // Metadata: 0x00744685
		public const int elementId_stickPinkyTrigger = 154; // Metadata: 0x00744689
		public const int elementId_stickButton1 = 6; // Metadata: 0x0074468D
		public const int elementId_stickButton2 = 7; // Metadata: 0x00744691
		public const int elementId_stickButton3 = 8; // Metadata: 0x00744695
		public const int elementId_stickButton4 = 9; // Metadata: 0x00744699
		public const int elementId_stickButton5 = 10; // Metadata: 0x0074469D
		public const int elementId_stickButton6 = 11; // Metadata: 0x007446A1
		public const int elementId_stickButton7 = 12; // Metadata: 0x007446A5
		public const int elementId_stickButton8 = 13; // Metadata: 0x007446A9
		public const int elementId_stickButton9 = 14; // Metadata: 0x007446AD
		public const int elementId_stickButton10 = 15; // Metadata: 0x007446B1
		public const int elementId_stickBaseButton1 = 18; // Metadata: 0x007446B5
		public const int elementId_stickBaseButton2 = 19; // Metadata: 0x007446B9
		public const int elementId_stickBaseButton3 = 20; // Metadata: 0x007446BD
		public const int elementId_stickBaseButton4 = 21; // Metadata: 0x007446C1
		public const int elementId_stickBaseButton5 = 22; // Metadata: 0x007446C5
		public const int elementId_stickBaseButton6 = 23; // Metadata: 0x007446C9
		public const int elementId_stickBaseButton7 = 24; // Metadata: 0x007446CD
		public const int elementId_stickBaseButton8 = 25; // Metadata: 0x007446D1
		public const int elementId_stickBaseButton9 = 26; // Metadata: 0x007446D5
		public const int elementId_stickBaseButton10 = 27; // Metadata: 0x007446D9
		public const int elementId_stickBaseButton11 = 161; // Metadata: 0x007446DD
		public const int elementId_stickBaseButton12 = 162; // Metadata: 0x007446E1
		public const int elementId_stickHat1Up = 28; // Metadata: 0x007446E5
		public const int elementId_stickHat1UpRight = 29; // Metadata: 0x007446E9
		public const int elementId_stickHat1Right = 30; // Metadata: 0x007446ED
		public const int elementId_stickHat1DownRight = 31; // Metadata: 0x007446F1
		public const int elementId_stickHat1Down = 32; // Metadata: 0x007446F5
		public const int elementId_stickHat1DownLeft = 33; // Metadata: 0x007446F9
		public const int elementId_stickHat1Left = 34; // Metadata: 0x007446FD
		public const int elementId_stickHat1Up_Left = 35; // Metadata: 0x00744701
		public const int elementId_stickHat2Up = 36; // Metadata: 0x00744705
		public const int elementId_stickHat2Up_right = 37; // Metadata: 0x00744709
		public const int elementId_stickHat2Right = 38; // Metadata: 0x0074470D
		public const int elementId_stickHat2Down_Right = 39; // Metadata: 0x00744711
		public const int elementId_stickHat2Down = 40; // Metadata: 0x00744715
		public const int elementId_stickHat2Down_Left = 41; // Metadata: 0x00744719
		public const int elementId_stickHat2Left = 42; // Metadata: 0x0074471D
		public const int elementId_stickHat2Up_Left = 43; // Metadata: 0x00744721
		public const int elementId_stickHat3Up = 84; // Metadata: 0x00744725
		public const int elementId_stickHat3Up_Right = 85; // Metadata: 0x00744729
		public const int elementId_stickHat3Right = 86; // Metadata: 0x0074472D
		public const int elementId_stickHat3Down_Right = 87; // Metadata: 0x00744731
		public const int elementId_stickHat3Down = 88; // Metadata: 0x00744735
		public const int elementId_stickHat3Down_Left = 89; // Metadata: 0x00744739
		public const int elementId_stickHat3Left = 90; // Metadata: 0x0074473D
		public const int elementId_stickHat3Up_Left = 91; // Metadata: 0x00744741
		public const int elementId_stickHat4Up = 92; // Metadata: 0x00744745
		public const int elementId_stickHat4Up_Right = 93; // Metadata: 0x00744749
		public const int elementId_stickHat4Right = 94; // Metadata: 0x0074474D
		public const int elementId_stickHat4Down_Right = 95; // Metadata: 0x00744751
		public const int elementId_stickHat4Down = 96; // Metadata: 0x00744755
		public const int elementId_stickHat4Down_Left = 97; // Metadata: 0x00744759
		public const int elementId_stickHat4Left = 98; // Metadata: 0x0074475D
		public const int elementId_stickHat4Up_Left = 99; // Metadata: 0x00744761
		public const int elementId_mode1 = 44; // Metadata: 0x00744765
		public const int elementId_mode2 = 45; // Metadata: 0x00744769
		public const int elementId_mode3 = 46; // Metadata: 0x0074476D
		public const int elementId_throttle1Axis = 49; // Metadata: 0x00744771
		public const int elementId_throttle2Axis = 155; // Metadata: 0x00744775
		public const int elementId_throttle1MinDetent = 166; // Metadata: 0x00744779
		public const int elementId_throttle2MinDetent = 167; // Metadata: 0x0074477D
		public const int elementId_throttleButton1 = 50; // Metadata: 0x00744781
		public const int elementId_throttleButton2 = 51; // Metadata: 0x00744785
		public const int elementId_throttleButton3 = 52; // Metadata: 0x00744789
		public const int elementId_throttleButton4 = 53; // Metadata: 0x0074478D
		public const int elementId_throttleButton5 = 54; // Metadata: 0x00744791
		public const int elementId_throttleButton6 = 55; // Metadata: 0x00744795
		public const int elementId_throttleButton7 = 56; // Metadata: 0x00744799
		public const int elementId_throttleButton8 = 57; // Metadata: 0x0074479D
		public const int elementId_throttleButton9 = 58; // Metadata: 0x007447A1
		public const int elementId_throttleButton10 = 59; // Metadata: 0x007447A5
		public const int elementId_throttleBaseButton1 = 60; // Metadata: 0x007447A9
		public const int elementId_throttleBaseButton2 = 61; // Metadata: 0x007447AD
		public const int elementId_throttleBaseButton3 = 62; // Metadata: 0x007447B1
		public const int elementId_throttleBaseButton4 = 63; // Metadata: 0x007447B5
		public const int elementId_throttleBaseButton5 = 64; // Metadata: 0x007447B9
		public const int elementId_throttleBaseButton6 = 65; // Metadata: 0x007447BD
		public const int elementId_throttleBaseButton7 = 66; // Metadata: 0x007447C1
		public const int elementId_throttleBaseButton8 = 67; // Metadata: 0x007447C5
		public const int elementId_throttleBaseButton9 = 68; // Metadata: 0x007447C9
		public const int elementId_throttleBaseButton10 = 69; // Metadata: 0x007447CD
		public const int elementId_throttleBaseButton11 = 132; // Metadata: 0x007447D1
		public const int elementId_throttleBaseButton12 = 133; // Metadata: 0x007447D5
		public const int elementId_throttleBaseButton13 = 134; // Metadata: 0x007447D9
		public const int elementId_throttleBaseButton14 = 135; // Metadata: 0x007447DD
		public const int elementId_throttleBaseButton15 = 136; // Metadata: 0x007447E1
		public const int elementId_throttleSlider1 = 70; // Metadata: 0x007447E5
		public const int elementId_throttleSlider2 = 71; // Metadata: 0x007447E9
		public const int elementId_throttleSlider3 = 72; // Metadata: 0x007447ED
		public const int elementId_throttleSlider4 = 73; // Metadata: 0x007447F1
		public const int elementId_throttleDial1 = 74; // Metadata: 0x007447F5
		public const int elementId_throttleDial2 = 142; // Metadata: 0x007447F9
		public const int elementId_throttleDial3 = 143; // Metadata: 0x007447FD
		public const int elementId_throttleDial4 = 144; // Metadata: 0x00744801
		public const int elementId_throttleMiniStickX = 75; // Metadata: 0x00744805
		public const int elementId_throttleMiniStickY = 76; // Metadata: 0x00744809
		public const int elementId_throttleMiniStickPress = 77; // Metadata: 0x0074480D
		public const int elementId_throttleWheel1Forward = 145; // Metadata: 0x00744811
		public const int elementId_throttleWheel1Back = 146; // Metadata: 0x00744815
		public const int elementId_throttleWheel1Press = 147; // Metadata: 0x00744819
		public const int elementId_throttleWheel2Forward = 148; // Metadata: 0x0074481D
		public const int elementId_throttleWheel2Back = 149; // Metadata: 0x00744821
		public const int elementId_throttleWheel2Press = 150; // Metadata: 0x00744825
		public const int elementId_throttleWheel3Forward = 151; // Metadata: 0x00744829
		public const int elementId_throttleWheel3Back = 152; // Metadata: 0x0074482D
		public const int elementId_throttleWheel3Press = 153; // Metadata: 0x00744831
		public const int elementId_throttleHat1Up = 100; // Metadata: 0x00744835
		public const int elementId_throttleHat1Up_Right = 101; // Metadata: 0x00744839
		public const int elementId_throttleHat1Right = 102; // Metadata: 0x0074483D
		public const int elementId_throttleHat1Down_Right = 103; // Metadata: 0x00744841
		public const int elementId_throttleHat1Down = 104; // Metadata: 0x00744845
		public const int elementId_throttleHat1Down_Left = 105; // Metadata: 0x00744849
		public const int elementId_throttleHat1Left = 106; // Metadata: 0x0074484D
		public const int elementId_throttleHat1Up_Left = 107; // Metadata: 0x00744851
		public const int elementId_throttleHat2Up = 108; // Metadata: 0x00744855
		public const int elementId_throttleHat2Up_Right = 109; // Metadata: 0x00744859
		public const int elementId_throttleHat2Right = 110; // Metadata: 0x0074485D
		public const int elementId_throttleHat2Down_Right = 111; // Metadata: 0x00744861
		public const int elementId_throttleHat2Down = 112; // Metadata: 0x00744865
		public const int elementId_throttleHat2Down_Left = 113; // Metadata: 0x00744869
		public const int elementId_throttleHat2Left = 114; // Metadata: 0x0074486D
		public const int elementId_throttleHat2Up_Left = 115; // Metadata: 0x00744871
		public const int elementId_throttleHat3Up = 116; // Metadata: 0x00744875
		public const int elementId_throttleHat3Up_Right = 117; // Metadata: 0x00744879
		public const int elementId_throttleHat3Right = 118; // Metadata: 0x0074487D
		public const int elementId_throttleHat3Down_Right = 119; // Metadata: 0x00744881
		public const int elementId_throttleHat3Down = 120; // Metadata: 0x00744885
		public const int elementId_throttleHat3Down_Left = 121; // Metadata: 0x00744889
		public const int elementId_throttleHat3Left = 122; // Metadata: 0x0074488D
		public const int elementId_throttleHat3Up_Left = 123; // Metadata: 0x00744891
		public const int elementId_throttleHat4Up = 124; // Metadata: 0x00744895
		public const int elementId_throttleHat4Up_Right = 125; // Metadata: 0x00744899
		public const int elementId_throttleHat4Right = 126; // Metadata: 0x0074489D
		public const int elementId_throttleHat4Down_Right = 127; // Metadata: 0x007448A1
		public const int elementId_throttleHat4Down = 128; // Metadata: 0x007448A5
		public const int elementId_throttleHat4Down_Left = 129; // Metadata: 0x007448A9
		public const int elementId_throttleHat4Left = 130; // Metadata: 0x007448AD
		public const int elementId_throttleHat4Up_Left = 131; // Metadata: 0x007448B1
		public const int elementId_leftPedal = 168; // Metadata: 0x007448B5
		public const int elementId_rightPedal = 169; // Metadata: 0x007448B9
		public const int elementId_slidePedals = 170; // Metadata: 0x007448BD
		public const int elementId_stick = 171; // Metadata: 0x007448C1
		public const int elementId_stickMiniStick1 = 172; // Metadata: 0x007448C5
		public const int elementId_stickMiniStick2 = 173; // Metadata: 0x007448C9
		public const int elementId_stickHat1 = 174; // Metadata: 0x007448CD
		public const int elementId_stickHat2 = 175; // Metadata: 0x007448D1
		public const int elementId_stickHat3 = 176; // Metadata: 0x007448D5
		public const int elementId_stickHat4 = 177; // Metadata: 0x007448D9
		public const int elementId_throttle1 = 178; // Metadata: 0x007448DD
		public const int elementId_throttle2 = 179; // Metadata: 0x007448E1
		public const int elementId_throttleMiniStick = 180; // Metadata: 0x007448E5
		public const int elementId_throttleHat1 = 181; // Metadata: 0x007448E9
		public const int elementId_throttleHat2 = 182; // Metadata: 0x007448ED
		public const int elementId_throttleHat3 = 183; // Metadata: 0x007448F1
		public const int elementId_throttleHat4 = 184; // Metadata: 0x007448F5
	
		// Properties
		IControllerTemplateButton IHOTASTemplate.stickTrigger { get; } // 0x0000000181BBF510-0x0000000181BBF550 
		IControllerTemplateButton IHOTASTemplate.stickTriggerStage2 { get; } // 0x0000000181BBF4D0-0x0000000181BBF510 
		IControllerTemplateButton IHOTASTemplate.stickPinkyButton { get; } // 0x0000000181BBF450-0x0000000181BBF490 
		IControllerTemplateButton IHOTASTemplate.stickPinkyTrigger { get; } // 0x0000000181BBF490-0x0000000181BBF4D0 
		IControllerTemplateButton IHOTASTemplate.stickButton1 { get; } // 0x0000000181BBF090-0x0000000181BBF0D0 
		IControllerTemplateButton IHOTASTemplate.stickButton2 { get; } // 0x0000000181BBF0D0-0x0000000181BBF110 
		IControllerTemplateButton IHOTASTemplate.stickButton3 { get; } // 0x0000000181BBF110-0x0000000181BBF150 
		IControllerTemplateButton IHOTASTemplate.stickButton4 { get; } // 0x0000000181BBF150-0x0000000181BBF190 
		IControllerTemplateButton IHOTASTemplate.stickButton5 { get; } // 0x0000000181BBF190-0x0000000181BBF1D0 
		IControllerTemplateButton IHOTASTemplate.stickButton6 { get; } // 0x0000000181BBF1D0-0x0000000181BBF210 
		IControllerTemplateButton IHOTASTemplate.stickButton7 { get; } // 0x0000000181BBF210-0x0000000181BBF250 
		IControllerTemplateButton IHOTASTemplate.stickButton8 { get; } // 0x0000000181BBF250-0x0000000181BBF290 
		IControllerTemplateButton IHOTASTemplate.stickButton9 { get; } // 0x0000000181BBF290-0x0000000181BBF2D0 
		IControllerTemplateButton IHOTASTemplate.stickButton10 { get; } // 0x0000000181BBF050-0x0000000181BBF090 
		IControllerTemplateButton IHOTASTemplate.stickBaseButton1 { get; } // 0x0000000181BBEE10-0x0000000181BBEE50 
		IControllerTemplateButton IHOTASTemplate.stickBaseButton2 { get; } // 0x0000000181BBEE50-0x0000000181BBEE90 
		IControllerTemplateButton IHOTASTemplate.stickBaseButton3 { get; } // 0x0000000181BBEE90-0x0000000181BBEED0 
		IControllerTemplateButton IHOTASTemplate.stickBaseButton4 { get; } // 0x0000000181BBEED0-0x0000000181BBEF10 
		IControllerTemplateButton IHOTASTemplate.stickBaseButton5 { get; } // 0x0000000181BBEF10-0x0000000181BBEF50 
		IControllerTemplateButton IHOTASTemplate.stickBaseButton6 { get; } // 0x0000000181BBEF50-0x0000000181BBEF90 
		IControllerTemplateButton IHOTASTemplate.stickBaseButton7 { get; } // 0x0000000181BBEF90-0x0000000181BBEFD0 
		IControllerTemplateButton IHOTASTemplate.stickBaseButton8 { get; } // 0x0000000181BBEFD0-0x0000000181BBF010 
		IControllerTemplateButton IHOTASTemplate.stickBaseButton9 { get; } // 0x0000000181BBF010-0x0000000181BBF050 
		IControllerTemplateButton IHOTASTemplate.stickBaseButton10 { get; } // 0x0000000181BBED50-0x0000000181BBED90 
		IControllerTemplateButton IHOTASTemplate.stickBaseButton11 { get; } // 0x0000000181BBED90-0x0000000181BBEDD0 
		IControllerTemplateButton IHOTASTemplate.stickBaseButton12 { get; } // 0x0000000181BBEDD0-0x0000000181BBEE10 
		IControllerTemplateButton IHOTASTemplate.mode1 { get; } // 0x0000000181BBEC10-0x0000000181BBEC50 
		IControllerTemplateButton IHOTASTemplate.mode2 { get; } // 0x0000000181BBEC50-0x0000000181BBEC90 
		IControllerTemplateButton IHOTASTemplate.mode3 { get; } // 0x0000000181BBEC90-0x0000000181BBECD0 
		IControllerTemplateButton IHOTASTemplate.throttleButton1 { get; } // 0x0000000181BBFA10-0x0000000181BBFA50 
		IControllerTemplateButton IHOTASTemplate.throttleButton2 { get; } // 0x0000000181BBFA50-0x0000000181BBFA90 
		IControllerTemplateButton IHOTASTemplate.throttleButton3 { get; } // 0x0000000181BBFA90-0x0000000181BBFAD0 
		IControllerTemplateButton IHOTASTemplate.throttleButton4 { get; } // 0x0000000181BBFAD0-0x0000000181BBFB10 
		IControllerTemplateButton IHOTASTemplate.throttleButton5 { get; } // 0x0000000181BBFB10-0x0000000181BBFB50 
		IControllerTemplateButton IHOTASTemplate.throttleButton6 { get; } // 0x0000000181BBFB50-0x0000000181BBFB90 
		IControllerTemplateButton IHOTASTemplate.throttleButton7 { get; } // 0x0000000181BBFB90-0x0000000181BBFBD0 
		IControllerTemplateButton IHOTASTemplate.throttleButton8 { get; } // 0x0000000181BBFBD0-0x0000000181BBFC10 
		IControllerTemplateButton IHOTASTemplate.throttleButton9 { get; } // 0x0000000181BBFC10-0x0000000181BBFC50 
		IControllerTemplateButton IHOTASTemplate.throttleButton10 { get; } // 0x0000000181BBF9D0-0x0000000181BBFA10 
		IControllerTemplateButton IHOTASTemplate.throttleBaseButton1 { get; } // 0x0000000181BBF790-0x0000000181BBF7D0 
		IControllerTemplateButton IHOTASTemplate.throttleBaseButton2 { get; } // 0x0000000181BBF7D0-0x0000000181BBF810 
		IControllerTemplateButton IHOTASTemplate.throttleBaseButton3 { get; } // 0x0000000181BBF810-0x0000000181BBF850 
		IControllerTemplateButton IHOTASTemplate.throttleBaseButton4 { get; } // 0x0000000181BBF850-0x0000000181BBF890 
		IControllerTemplateButton IHOTASTemplate.throttleBaseButton5 { get; } // 0x0000000181BBF890-0x0000000181BBF8D0 
		IControllerTemplateButton IHOTASTemplate.throttleBaseButton6 { get; } // 0x0000000181BBF8D0-0x0000000181BBF910 
		IControllerTemplateButton IHOTASTemplate.throttleBaseButton7 { get; } // 0x0000000181BBF910-0x0000000181BBF950 
		IControllerTemplateButton IHOTASTemplate.throttleBaseButton8 { get; } // 0x0000000181BBF950-0x0000000181BBF990 
		IControllerTemplateButton IHOTASTemplate.throttleBaseButton9 { get; } // 0x0000000181BBF990-0x0000000181BBF9D0 
		IControllerTemplateButton IHOTASTemplate.throttleBaseButton10 { get; } // 0x0000000181BBF610-0x0000000181BBF650 
		IControllerTemplateButton IHOTASTemplate.throttleBaseButton11 { get; } // 0x0000000181BBF650-0x0000000181BBF690 
		IControllerTemplateButton IHOTASTemplate.throttleBaseButton12 { get; } // 0x0000000181BBF690-0x0000000181BBF6D0 
		IControllerTemplateButton IHOTASTemplate.throttleBaseButton13 { get; } // 0x0000000181BBF6D0-0x0000000181BBF710 
		IControllerTemplateButton IHOTASTemplate.throttleBaseButton14 { get; } // 0x0000000181BBF710-0x0000000181BBF750 
		IControllerTemplateButton IHOTASTemplate.throttleBaseButton15 { get; } // 0x0000000181BBF750-0x0000000181BBF790 
		IControllerTemplateAxis IHOTASTemplate.throttleSlider1 { get; } // 0x0000000181BBFE90-0x0000000181BBFED0 
		IControllerTemplateAxis IHOTASTemplate.throttleSlider2 { get; } // 0x0000000181BBFED0-0x0000000181BBFF10 
		IControllerTemplateAxis IHOTASTemplate.throttleSlider3 { get; } // 0x0000000181BBFF10-0x0000000181BBFF50 
		IControllerTemplateAxis IHOTASTemplate.throttleSlider4 { get; } // 0x0000000181BBFF50-0x0000000181BBFF90 
		IControllerTemplateAxis IHOTASTemplate.throttleDial1 { get; } // 0x0000000181BBFC50-0x0000000181BBFC90 
		IControllerTemplateAxis IHOTASTemplate.throttleDial2 { get; } // 0x0000000181BBFC90-0x0000000181BBFCD0 
		IControllerTemplateAxis IHOTASTemplate.throttleDial3 { get; } // 0x0000000181BBFCD0-0x0000000181BBFD10 
		IControllerTemplateAxis IHOTASTemplate.throttleDial4 { get; } // 0x0000000181BBFD10-0x0000000181BBFD50 
		IControllerTemplateButton IHOTASTemplate.throttleWheel1Forward { get; } // 0x0000000181BBFFD0-0x0000000181BC0010 
		IControllerTemplateButton IHOTASTemplate.throttleWheel1Back { get; } // 0x0000000181BBFF90-0x0000000181BBFFD0 
		IControllerTemplateButton IHOTASTemplate.throttleWheel1Press { get; } // 0x0000000181BC0010-0x0000000181BC0050 
		IControllerTemplateButton IHOTASTemplate.throttleWheel2Forward { get; } // 0x0000000181BC0090-0x0000000181BC00D0 
		IControllerTemplateButton IHOTASTemplate.throttleWheel2Back { get; } // 0x0000000181BC0050-0x0000000181BC0090 
		IControllerTemplateButton IHOTASTemplate.throttleWheel2Press { get; } // 0x0000000181BC00D0-0x0000000181BC0110 
		IControllerTemplateButton IHOTASTemplate.throttleWheel3Forward { get; } // 0x0000000181BC0150-0x0000000181BC0190 
		IControllerTemplateButton IHOTASTemplate.throttleWheel3Back { get; } // 0x0000000181BC0110-0x0000000181BC0150 
		IControllerTemplateButton IHOTASTemplate.throttleWheel3Press { get; } // 0x0000000181BC0190-0x0000000181BC01D0 
		IControllerTemplateAxis IHOTASTemplate.leftPedal { get; } // 0x0000000181BBEBD0-0x0000000181BBEC10 
		IControllerTemplateAxis IHOTASTemplate.rightPedal { get; } // 0x0000000181BBECD0-0x0000000181BBED10 
		IControllerTemplateAxis IHOTASTemplate.slidePedals { get; } // 0x0000000181BBED10-0x0000000181BBED50 
		IControllerTemplateStick IHOTASTemplate.stick { get; } // 0x0000000181BBF550-0x0000000181BBF590 
		IControllerTemplateThumbStick IHOTASTemplate.stickMiniStick1 { get; } // 0x0000000181BBF3D0-0x0000000181BBF410 
		IControllerTemplateThumbStick IHOTASTemplate.stickMiniStick2 { get; } // 0x0000000181BBF410-0x0000000181BBF450 
		IControllerTemplateHat IHOTASTemplate.stickHat1 { get; } // 0x0000000181BBF2D0-0x0000000181BBF310 
		IControllerTemplateHat IHOTASTemplate.stickHat2 { get; } // 0x0000000181BBF310-0x0000000181BBF350 
		IControllerTemplateHat IHOTASTemplate.stickHat3 { get; } // 0x0000000181BBF350-0x0000000181BBF390 
		IControllerTemplateHat IHOTASTemplate.stickHat4 { get; } // 0x0000000181BBF390-0x0000000181BBF3D0 
		IControllerTemplateThrottle IHOTASTemplate.throttle1 { get; } // 0x0000000181BBF590-0x0000000181BBF5D0 
		IControllerTemplateThrottle IHOTASTemplate.throttle2 { get; } // 0x0000000181BBF5D0-0x0000000181BBF610 
		IControllerTemplateThumbStick IHOTASTemplate.throttleMiniStick { get; } // 0x0000000181BBFE50-0x0000000181BBFE90 
		IControllerTemplateHat IHOTASTemplate.throttleHat1 { get; } // 0x0000000181BBFD50-0x0000000181BBFD90 
		IControllerTemplateHat IHOTASTemplate.throttleHat2 { get; } // 0x0000000181BBFD90-0x0000000181BBFDD0 
		IControllerTemplateHat IHOTASTemplate.throttleHat3 { get; } // 0x0000000181BBFDD0-0x0000000181BBFE10 
		IControllerTemplateHat IHOTASTemplate.throttleHat4 { get; } // 0x0000000181BBFE10-0x0000000181BBFE50 
	
		// Constructors
		public HOTASTemplate(object payload); // 0x0000000181BBD780-0x0000000181BBD790
		static HOTASTemplate(); // 0x0000000181BC01D0-0x0000000181BC0230
	}
}
