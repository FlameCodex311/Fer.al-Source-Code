/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 79: Rewired.dll - Assembly: Rewired, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9355-9437

namespace Rewired
{
	public sealed class HOTASTemplate : ControllerTemplate, IHOTASTemplate // TypeDefIndex: 9364
	{
		// Fields
		public static readonly Guid typeGuid; // 0x00
		public const int elementId_stickX = 0; // Metadata: 0x00779347
		public const int elementId_stickY = 1; // Metadata: 0x0077934B
		public const int elementId_stickRotate = 2; // Metadata: 0x0077934F
		public const int elementId_stickMiniStick1X = 78; // Metadata: 0x00779353
		public const int elementId_stickMiniStick1Y = 79; // Metadata: 0x00779357
		public const int elementId_stickMiniStick1Press = 80; // Metadata: 0x0077935B
		public const int elementId_stickMiniStick2X = 81; // Metadata: 0x0077935F
		public const int elementId_stickMiniStick2Y = 82; // Metadata: 0x00779363
		public const int elementId_stickMiniStick2Press = 83; // Metadata: 0x00779367
		public const int elementId_stickTrigger = 3; // Metadata: 0x0077936B
		public const int elementId_stickTriggerStage2 = 4; // Metadata: 0x0077936F
		public const int elementId_stickPinkyButton = 5; // Metadata: 0x00779373
		public const int elementId_stickPinkyTrigger = 154; // Metadata: 0x00779377
		public const int elementId_stickButton1 = 6; // Metadata: 0x0077937B
		public const int elementId_stickButton2 = 7; // Metadata: 0x0077937F
		public const int elementId_stickButton3 = 8; // Metadata: 0x00779383
		public const int elementId_stickButton4 = 9; // Metadata: 0x00779387
		public const int elementId_stickButton5 = 10; // Metadata: 0x0077938B
		public const int elementId_stickButton6 = 11; // Metadata: 0x0077938F
		public const int elementId_stickButton7 = 12; // Metadata: 0x00779393
		public const int elementId_stickButton8 = 13; // Metadata: 0x00779397
		public const int elementId_stickButton9 = 14; // Metadata: 0x0077939B
		public const int elementId_stickButton10 = 15; // Metadata: 0x0077939F
		public const int elementId_stickBaseButton1 = 18; // Metadata: 0x007793A3
		public const int elementId_stickBaseButton2 = 19; // Metadata: 0x007793A7
		public const int elementId_stickBaseButton3 = 20; // Metadata: 0x007793AB
		public const int elementId_stickBaseButton4 = 21; // Metadata: 0x007793AF
		public const int elementId_stickBaseButton5 = 22; // Metadata: 0x007793B3
		public const int elementId_stickBaseButton6 = 23; // Metadata: 0x007793B7
		public const int elementId_stickBaseButton7 = 24; // Metadata: 0x007793BB
		public const int elementId_stickBaseButton8 = 25; // Metadata: 0x007793BF
		public const int elementId_stickBaseButton9 = 26; // Metadata: 0x007793C3
		public const int elementId_stickBaseButton10 = 27; // Metadata: 0x007793C7
		public const int elementId_stickBaseButton11 = 161; // Metadata: 0x007793CB
		public const int elementId_stickBaseButton12 = 162; // Metadata: 0x007793CF
		public const int elementId_stickHat1Up = 28; // Metadata: 0x007793D3
		public const int elementId_stickHat1UpRight = 29; // Metadata: 0x007793D7
		public const int elementId_stickHat1Right = 30; // Metadata: 0x007793DB
		public const int elementId_stickHat1DownRight = 31; // Metadata: 0x007793DF
		public const int elementId_stickHat1Down = 32; // Metadata: 0x007793E3
		public const int elementId_stickHat1DownLeft = 33; // Metadata: 0x007793E7
		public const int elementId_stickHat1Left = 34; // Metadata: 0x007793EB
		public const int elementId_stickHat1Up_Left = 35; // Metadata: 0x007793EF
		public const int elementId_stickHat2Up = 36; // Metadata: 0x007793F3
		public const int elementId_stickHat2Up_right = 37; // Metadata: 0x007793F7
		public const int elementId_stickHat2Right = 38; // Metadata: 0x007793FB
		public const int elementId_stickHat2Down_Right = 39; // Metadata: 0x007793FF
		public const int elementId_stickHat2Down = 40; // Metadata: 0x00779403
		public const int elementId_stickHat2Down_Left = 41; // Metadata: 0x00779407
		public const int elementId_stickHat2Left = 42; // Metadata: 0x0077940B
		public const int elementId_stickHat2Up_Left = 43; // Metadata: 0x0077940F
		public const int elementId_stickHat3Up = 84; // Metadata: 0x00779413
		public const int elementId_stickHat3Up_Right = 85; // Metadata: 0x00779417
		public const int elementId_stickHat3Right = 86; // Metadata: 0x0077941B
		public const int elementId_stickHat3Down_Right = 87; // Metadata: 0x0077941F
		public const int elementId_stickHat3Down = 88; // Metadata: 0x00779423
		public const int elementId_stickHat3Down_Left = 89; // Metadata: 0x00779427
		public const int elementId_stickHat3Left = 90; // Metadata: 0x0077942B
		public const int elementId_stickHat3Up_Left = 91; // Metadata: 0x0077942F
		public const int elementId_stickHat4Up = 92; // Metadata: 0x00779433
		public const int elementId_stickHat4Up_Right = 93; // Metadata: 0x00779437
		public const int elementId_stickHat4Right = 94; // Metadata: 0x0077943B
		public const int elementId_stickHat4Down_Right = 95; // Metadata: 0x0077943F
		public const int elementId_stickHat4Down = 96; // Metadata: 0x00779443
		public const int elementId_stickHat4Down_Left = 97; // Metadata: 0x00779447
		public const int elementId_stickHat4Left = 98; // Metadata: 0x0077944B
		public const int elementId_stickHat4Up_Left = 99; // Metadata: 0x0077944F
		public const int elementId_mode1 = 44; // Metadata: 0x00779453
		public const int elementId_mode2 = 45; // Metadata: 0x00779457
		public const int elementId_mode3 = 46; // Metadata: 0x0077945B
		public const int elementId_throttle1Axis = 49; // Metadata: 0x0077945F
		public const int elementId_throttle2Axis = 155; // Metadata: 0x00779463
		public const int elementId_throttle1MinDetent = 166; // Metadata: 0x00779467
		public const int elementId_throttle2MinDetent = 167; // Metadata: 0x0077946B
		public const int elementId_throttleButton1 = 50; // Metadata: 0x0077946F
		public const int elementId_throttleButton2 = 51; // Metadata: 0x00779473
		public const int elementId_throttleButton3 = 52; // Metadata: 0x00779477
		public const int elementId_throttleButton4 = 53; // Metadata: 0x0077947B
		public const int elementId_throttleButton5 = 54; // Metadata: 0x0077947F
		public const int elementId_throttleButton6 = 55; // Metadata: 0x00779483
		public const int elementId_throttleButton7 = 56; // Metadata: 0x00779487
		public const int elementId_throttleButton8 = 57; // Metadata: 0x0077948B
		public const int elementId_throttleButton9 = 58; // Metadata: 0x0077948F
		public const int elementId_throttleButton10 = 59; // Metadata: 0x00779493
		public const int elementId_throttleBaseButton1 = 60; // Metadata: 0x00779497
		public const int elementId_throttleBaseButton2 = 61; // Metadata: 0x0077949B
		public const int elementId_throttleBaseButton3 = 62; // Metadata: 0x0077949F
		public const int elementId_throttleBaseButton4 = 63; // Metadata: 0x007794A3
		public const int elementId_throttleBaseButton5 = 64; // Metadata: 0x007794A7
		public const int elementId_throttleBaseButton6 = 65; // Metadata: 0x007794AB
		public const int elementId_throttleBaseButton7 = 66; // Metadata: 0x007794AF
		public const int elementId_throttleBaseButton8 = 67; // Metadata: 0x007794B3
		public const int elementId_throttleBaseButton9 = 68; // Metadata: 0x007794B7
		public const int elementId_throttleBaseButton10 = 69; // Metadata: 0x007794BB
		public const int elementId_throttleBaseButton11 = 132; // Metadata: 0x007794BF
		public const int elementId_throttleBaseButton12 = 133; // Metadata: 0x007794C3
		public const int elementId_throttleBaseButton13 = 134; // Metadata: 0x007794C7
		public const int elementId_throttleBaseButton14 = 135; // Metadata: 0x007794CB
		public const int elementId_throttleBaseButton15 = 136; // Metadata: 0x007794CF
		public const int elementId_throttleSlider1 = 70; // Metadata: 0x007794D3
		public const int elementId_throttleSlider2 = 71; // Metadata: 0x007794D7
		public const int elementId_throttleSlider3 = 72; // Metadata: 0x007794DB
		public const int elementId_throttleSlider4 = 73; // Metadata: 0x007794DF
		public const int elementId_throttleDial1 = 74; // Metadata: 0x007794E3
		public const int elementId_throttleDial2 = 142; // Metadata: 0x007794E7
		public const int elementId_throttleDial3 = 143; // Metadata: 0x007794EB
		public const int elementId_throttleDial4 = 144; // Metadata: 0x007794EF
		public const int elementId_throttleMiniStickX = 75; // Metadata: 0x007794F3
		public const int elementId_throttleMiniStickY = 76; // Metadata: 0x007794F7
		public const int elementId_throttleMiniStickPress = 77; // Metadata: 0x007794FB
		public const int elementId_throttleWheel1Forward = 145; // Metadata: 0x007794FF
		public const int elementId_throttleWheel1Back = 146; // Metadata: 0x00779503
		public const int elementId_throttleWheel1Press = 147; // Metadata: 0x00779507
		public const int elementId_throttleWheel2Forward = 148; // Metadata: 0x0077950B
		public const int elementId_throttleWheel2Back = 149; // Metadata: 0x0077950F
		public const int elementId_throttleWheel2Press = 150; // Metadata: 0x00779513
		public const int elementId_throttleWheel3Forward = 151; // Metadata: 0x00779517
		public const int elementId_throttleWheel3Back = 152; // Metadata: 0x0077951B
		public const int elementId_throttleWheel3Press = 153; // Metadata: 0x0077951F
		public const int elementId_throttleHat1Up = 100; // Metadata: 0x00779523
		public const int elementId_throttleHat1Up_Right = 101; // Metadata: 0x00779527
		public const int elementId_throttleHat1Right = 102; // Metadata: 0x0077952B
		public const int elementId_throttleHat1Down_Right = 103; // Metadata: 0x0077952F
		public const int elementId_throttleHat1Down = 104; // Metadata: 0x00779533
		public const int elementId_throttleHat1Down_Left = 105; // Metadata: 0x00779537
		public const int elementId_throttleHat1Left = 106; // Metadata: 0x0077953B
		public const int elementId_throttleHat1Up_Left = 107; // Metadata: 0x0077953F
		public const int elementId_throttleHat2Up = 108; // Metadata: 0x00779543
		public const int elementId_throttleHat2Up_Right = 109; // Metadata: 0x00779547
		public const int elementId_throttleHat2Right = 110; // Metadata: 0x0077954B
		public const int elementId_throttleHat2Down_Right = 111; // Metadata: 0x0077954F
		public const int elementId_throttleHat2Down = 112; // Metadata: 0x00779553
		public const int elementId_throttleHat2Down_Left = 113; // Metadata: 0x00779557
		public const int elementId_throttleHat2Left = 114; // Metadata: 0x0077955B
		public const int elementId_throttleHat2Up_Left = 115; // Metadata: 0x0077955F
		public const int elementId_throttleHat3Up = 116; // Metadata: 0x00779563
		public const int elementId_throttleHat3Up_Right = 117; // Metadata: 0x00779567
		public const int elementId_throttleHat3Right = 118; // Metadata: 0x0077956B
		public const int elementId_throttleHat3Down_Right = 119; // Metadata: 0x0077956F
		public const int elementId_throttleHat3Down = 120; // Metadata: 0x00779573
		public const int elementId_throttleHat3Down_Left = 121; // Metadata: 0x00779577
		public const int elementId_throttleHat3Left = 122; // Metadata: 0x0077957B
		public const int elementId_throttleHat3Up_Left = 123; // Metadata: 0x0077957F
		public const int elementId_throttleHat4Up = 124; // Metadata: 0x00779583
		public const int elementId_throttleHat4Up_Right = 125; // Metadata: 0x00779587
		public const int elementId_throttleHat4Right = 126; // Metadata: 0x0077958B
		public const int elementId_throttleHat4Down_Right = 127; // Metadata: 0x0077958F
		public const int elementId_throttleHat4Down = 128; // Metadata: 0x00779593
		public const int elementId_throttleHat4Down_Left = 129; // Metadata: 0x00779597
		public const int elementId_throttleHat4Left = 130; // Metadata: 0x0077959B
		public const int elementId_throttleHat4Up_Left = 131; // Metadata: 0x0077959F
		public const int elementId_leftPedal = 168; // Metadata: 0x007795A3
		public const int elementId_rightPedal = 169; // Metadata: 0x007795A7
		public const int elementId_slidePedals = 170; // Metadata: 0x007795AB
		public const int elementId_stick = 171; // Metadata: 0x007795AF
		public const int elementId_stickMiniStick1 = 172; // Metadata: 0x007795B3
		public const int elementId_stickMiniStick2 = 173; // Metadata: 0x007795B7
		public const int elementId_stickHat1 = 174; // Metadata: 0x007795BB
		public const int elementId_stickHat2 = 175; // Metadata: 0x007795BF
		public const int elementId_stickHat3 = 176; // Metadata: 0x007795C3
		public const int elementId_stickHat4 = 177; // Metadata: 0x007795C7
		public const int elementId_throttle1 = 178; // Metadata: 0x007795CB
		public const int elementId_throttle2 = 179; // Metadata: 0x007795CF
		public const int elementId_throttleMiniStick = 180; // Metadata: 0x007795D3
		public const int elementId_throttleHat1 = 181; // Metadata: 0x007795D7
		public const int elementId_throttleHat2 = 182; // Metadata: 0x007795DB
		public const int elementId_throttleHat3 = 183; // Metadata: 0x007795DF
		public const int elementId_throttleHat4 = 184; // Metadata: 0x007795E3
	
		// Properties
		IControllerTemplateButton IHOTASTemplate.stickTrigger { get; } // 0x000000018105EB50-0x000000018105EB90 
		IControllerTemplateButton IHOTASTemplate.stickTriggerStage2 { get; } // 0x000000018105EB10-0x000000018105EB50 
		IControllerTemplateButton IHOTASTemplate.stickPinkyButton { get; } // 0x000000018105EA90-0x000000018105EAD0 
		IControllerTemplateButton IHOTASTemplate.stickPinkyTrigger { get; } // 0x000000018105EAD0-0x000000018105EB10 
		IControllerTemplateButton IHOTASTemplate.stickButton1 { get; } // 0x000000018105E6D0-0x000000018105E710 
		IControllerTemplateButton IHOTASTemplate.stickButton2 { get; } // 0x000000018105E710-0x000000018105E750 
		IControllerTemplateButton IHOTASTemplate.stickButton3 { get; } // 0x000000018105E750-0x000000018105E790 
		IControllerTemplateButton IHOTASTemplate.stickButton4 { get; } // 0x000000018105E790-0x000000018105E7D0 
		IControllerTemplateButton IHOTASTemplate.stickButton5 { get; } // 0x000000018105E7D0-0x000000018105E810 
		IControllerTemplateButton IHOTASTemplate.stickButton6 { get; } // 0x000000018105E810-0x000000018105E850 
		IControllerTemplateButton IHOTASTemplate.stickButton7 { get; } // 0x000000018105E850-0x000000018105E890 
		IControllerTemplateButton IHOTASTemplate.stickButton8 { get; } // 0x000000018105E890-0x000000018105E8D0 
		IControllerTemplateButton IHOTASTemplate.stickButton9 { get; } // 0x000000018105E8D0-0x000000018105E910 
		IControllerTemplateButton IHOTASTemplate.stickButton10 { get; } // 0x000000018105E690-0x000000018105E6D0 
		IControllerTemplateButton IHOTASTemplate.stickBaseButton1 { get; } // 0x000000018105E450-0x000000018105E490 
		IControllerTemplateButton IHOTASTemplate.stickBaseButton2 { get; } // 0x000000018105E490-0x000000018105E4D0 
		IControllerTemplateButton IHOTASTemplate.stickBaseButton3 { get; } // 0x000000018105E4D0-0x000000018105E510 
		IControllerTemplateButton IHOTASTemplate.stickBaseButton4 { get; } // 0x000000018105E510-0x000000018105E550 
		IControllerTemplateButton IHOTASTemplate.stickBaseButton5 { get; } // 0x000000018105E550-0x000000018105E590 
		IControllerTemplateButton IHOTASTemplate.stickBaseButton6 { get; } // 0x000000018105E590-0x000000018105E5D0 
		IControllerTemplateButton IHOTASTemplate.stickBaseButton7 { get; } // 0x000000018105E5D0-0x000000018105E610 
		IControllerTemplateButton IHOTASTemplate.stickBaseButton8 { get; } // 0x000000018105E610-0x000000018105E650 
		IControllerTemplateButton IHOTASTemplate.stickBaseButton9 { get; } // 0x000000018105E650-0x000000018105E690 
		IControllerTemplateButton IHOTASTemplate.stickBaseButton10 { get; } // 0x000000018105E390-0x000000018105E3D0 
		IControllerTemplateButton IHOTASTemplate.stickBaseButton11 { get; } // 0x000000018105E3D0-0x000000018105E410 
		IControllerTemplateButton IHOTASTemplate.stickBaseButton12 { get; } // 0x000000018105E410-0x000000018105E450 
		IControllerTemplateButton IHOTASTemplate.mode1 { get; } // 0x000000018105E250-0x000000018105E290 
		IControllerTemplateButton IHOTASTemplate.mode2 { get; } // 0x000000018105E290-0x000000018105E2D0 
		IControllerTemplateButton IHOTASTemplate.mode3 { get; } // 0x000000018105E2D0-0x000000018105E310 
		IControllerTemplateButton IHOTASTemplate.throttleButton1 { get; } // 0x000000018105F050-0x000000018105F090 
		IControllerTemplateButton IHOTASTemplate.throttleButton2 { get; } // 0x000000018105F090-0x000000018105F0D0 
		IControllerTemplateButton IHOTASTemplate.throttleButton3 { get; } // 0x000000018105F0D0-0x000000018105F110 
		IControllerTemplateButton IHOTASTemplate.throttleButton4 { get; } // 0x000000018105F110-0x000000018105F150 
		IControllerTemplateButton IHOTASTemplate.throttleButton5 { get; } // 0x000000018105F150-0x000000018105F190 
		IControllerTemplateButton IHOTASTemplate.throttleButton6 { get; } // 0x000000018105F190-0x000000018105F1D0 
		IControllerTemplateButton IHOTASTemplate.throttleButton7 { get; } // 0x000000018105F1D0-0x000000018105F210 
		IControllerTemplateButton IHOTASTemplate.throttleButton8 { get; } // 0x000000018105F210-0x000000018105F250 
		IControllerTemplateButton IHOTASTemplate.throttleButton9 { get; } // 0x000000018105F250-0x000000018105F290 
		IControllerTemplateButton IHOTASTemplate.throttleButton10 { get; } // 0x000000018105F010-0x000000018105F050 
		IControllerTemplateButton IHOTASTemplate.throttleBaseButton1 { get; } // 0x000000018105EDD0-0x000000018105EE10 
		IControllerTemplateButton IHOTASTemplate.throttleBaseButton2 { get; } // 0x000000018105EE10-0x000000018105EE50 
		IControllerTemplateButton IHOTASTemplate.throttleBaseButton3 { get; } // 0x000000018105EE50-0x000000018105EE90 
		IControllerTemplateButton IHOTASTemplate.throttleBaseButton4 { get; } // 0x000000018105EE90-0x000000018105EED0 
		IControllerTemplateButton IHOTASTemplate.throttleBaseButton5 { get; } // 0x000000018105EED0-0x000000018105EF10 
		IControllerTemplateButton IHOTASTemplate.throttleBaseButton6 { get; } // 0x000000018105EF10-0x000000018105EF50 
		IControllerTemplateButton IHOTASTemplate.throttleBaseButton7 { get; } // 0x000000018105EF50-0x000000018105EF90 
		IControllerTemplateButton IHOTASTemplate.throttleBaseButton8 { get; } // 0x000000018105EF90-0x000000018105EFD0 
		IControllerTemplateButton IHOTASTemplate.throttleBaseButton9 { get; } // 0x000000018105EFD0-0x000000018105F010 
		IControllerTemplateButton IHOTASTemplate.throttleBaseButton10 { get; } // 0x000000018105EC50-0x000000018105EC90 
		IControllerTemplateButton IHOTASTemplate.throttleBaseButton11 { get; } // 0x000000018105EC90-0x000000018105ECD0 
		IControllerTemplateButton IHOTASTemplate.throttleBaseButton12 { get; } // 0x000000018105ECD0-0x000000018105ED10 
		IControllerTemplateButton IHOTASTemplate.throttleBaseButton13 { get; } // 0x000000018105ED10-0x000000018105ED50 
		IControllerTemplateButton IHOTASTemplate.throttleBaseButton14 { get; } // 0x000000018105ED50-0x000000018105ED90 
		IControllerTemplateButton IHOTASTemplate.throttleBaseButton15 { get; } // 0x000000018105ED90-0x000000018105EDD0 
		IControllerTemplateAxis IHOTASTemplate.throttleSlider1 { get; } // 0x000000018105F4D0-0x000000018105F510 
		IControllerTemplateAxis IHOTASTemplate.throttleSlider2 { get; } // 0x000000018105F510-0x000000018105F550 
		IControllerTemplateAxis IHOTASTemplate.throttleSlider3 { get; } // 0x000000018105F550-0x000000018105F590 
		IControllerTemplateAxis IHOTASTemplate.throttleSlider4 { get; } // 0x000000018105F590-0x000000018105F5D0 
		IControllerTemplateAxis IHOTASTemplate.throttleDial1 { get; } // 0x000000018105F290-0x000000018105F2D0 
		IControllerTemplateAxis IHOTASTemplate.throttleDial2 { get; } // 0x000000018105F2D0-0x000000018105F310 
		IControllerTemplateAxis IHOTASTemplate.throttleDial3 { get; } // 0x000000018105F310-0x000000018105F350 
		IControllerTemplateAxis IHOTASTemplate.throttleDial4 { get; } // 0x000000018105F350-0x000000018105F390 
		IControllerTemplateButton IHOTASTemplate.throttleWheel1Forward { get; } // 0x000000018105F610-0x000000018105F650 
		IControllerTemplateButton IHOTASTemplate.throttleWheel1Back { get; } // 0x000000018105F5D0-0x000000018105F610 
		IControllerTemplateButton IHOTASTemplate.throttleWheel1Press { get; } // 0x000000018105F650-0x000000018105F690 
		IControllerTemplateButton IHOTASTemplate.throttleWheel2Forward { get; } // 0x000000018105F6D0-0x000000018105F710 
		IControllerTemplateButton IHOTASTemplate.throttleWheel2Back { get; } // 0x000000018105F690-0x000000018105F6D0 
		IControllerTemplateButton IHOTASTemplate.throttleWheel2Press { get; } // 0x000000018105F710-0x000000018105F750 
		IControllerTemplateButton IHOTASTemplate.throttleWheel3Forward { get; } // 0x000000018105F790-0x000000018105F7D0 
		IControllerTemplateButton IHOTASTemplate.throttleWheel3Back { get; } // 0x000000018105F750-0x000000018105F790 
		IControllerTemplateButton IHOTASTemplate.throttleWheel3Press { get; } // 0x000000018105F7D0-0x000000018105F810 
		IControllerTemplateAxis IHOTASTemplate.leftPedal { get; } // 0x000000018105E210-0x000000018105E250 
		IControllerTemplateAxis IHOTASTemplate.rightPedal { get; } // 0x000000018105E310-0x000000018105E350 
		IControllerTemplateAxis IHOTASTemplate.slidePedals { get; } // 0x000000018105E350-0x000000018105E390 
		IControllerTemplateStick IHOTASTemplate.stick { get; } // 0x000000018105EB90-0x000000018105EBD0 
		IControllerTemplateThumbStick IHOTASTemplate.stickMiniStick1 { get; } // 0x000000018105EA10-0x000000018105EA50 
		IControllerTemplateThumbStick IHOTASTemplate.stickMiniStick2 { get; } // 0x000000018105EA50-0x000000018105EA90 
		IControllerTemplateHat IHOTASTemplate.stickHat1 { get; } // 0x000000018105E910-0x000000018105E950 
		IControllerTemplateHat IHOTASTemplate.stickHat2 { get; } // 0x000000018105E950-0x000000018105E990 
		IControllerTemplateHat IHOTASTemplate.stickHat3 { get; } // 0x000000018105E990-0x000000018105E9D0 
		IControllerTemplateHat IHOTASTemplate.stickHat4 { get; } // 0x000000018105E9D0-0x000000018105EA10 
		IControllerTemplateThrottle IHOTASTemplate.throttle1 { get; } // 0x000000018105EBD0-0x000000018105EC10 
		IControllerTemplateThrottle IHOTASTemplate.throttle2 { get; } // 0x000000018105EC10-0x000000018105EC50 
		IControllerTemplateThumbStick IHOTASTemplate.throttleMiniStick { get; } // 0x000000018105F490-0x000000018105F4D0 
		IControllerTemplateHat IHOTASTemplate.throttleHat1 { get; } // 0x000000018105F390-0x000000018105F3D0 
		IControllerTemplateHat IHOTASTemplate.throttleHat2 { get; } // 0x000000018105F3D0-0x000000018105F410 
		IControllerTemplateHat IHOTASTemplate.throttleHat3 { get; } // 0x000000018105F410-0x000000018105F450 
		IControllerTemplateHat IHOTASTemplate.throttleHat4 { get; } // 0x000000018105F450-0x000000018105F490 
	
		// Constructors
		public HOTASTemplate(object payload); // 0x000000018105CDC0-0x000000018105CDD0
		static HOTASTemplate(); // 0x000000018105F810-0x000000018105F870
	}
}
