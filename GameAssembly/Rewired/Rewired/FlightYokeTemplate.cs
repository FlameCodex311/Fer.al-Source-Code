/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 79: Rewired.dll - Assembly: Rewired, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9355-9437

namespace Rewired
{
	public sealed class FlightYokeTemplate : ControllerTemplate, IFlightYokeTemplate // TypeDefIndex: 9365
	{
		// Fields
		public static readonly Guid typeGuid; // 0x00
		public const int elementId_rotateYoke = 0; // Metadata: 0x007795E7
		public const int elementId_yokeZ = 1; // Metadata: 0x007795EB
		public const int elementId_leftPaddle = 59; // Metadata: 0x007795EF
		public const int elementId_rightPaddle = 60; // Metadata: 0x007795F3
		public const int elementId_lever1Axis = 2; // Metadata: 0x007795F7
		public const int elementId_lever1MinDetent = 64; // Metadata: 0x007795FB
		public const int elementId_lever2Axis = 3; // Metadata: 0x007795FF
		public const int elementId_lever2MinDetent = 65; // Metadata: 0x00779603
		public const int elementId_lever3Axis = 4; // Metadata: 0x00779607
		public const int elementId_lever3MinDetent = 66; // Metadata: 0x0077960B
		public const int elementId_lever4Axis = 5; // Metadata: 0x0077960F
		public const int elementId_lever4MinDetent = 67; // Metadata: 0x00779613
		public const int elementId_lever5Axis = 6; // Metadata: 0x00779617
		public const int elementId_lever5MinDetent = 68; // Metadata: 0x0077961B
		public const int elementId_leftGripButton1 = 7; // Metadata: 0x0077961F
		public const int elementId_leftGripButton2 = 8; // Metadata: 0x00779623
		public const int elementId_leftGripButton3 = 9; // Metadata: 0x00779627
		public const int elementId_leftGripButton4 = 10; // Metadata: 0x0077962B
		public const int elementId_leftGripButton5 = 11; // Metadata: 0x0077962F
		public const int elementId_leftGripButton6 = 12; // Metadata: 0x00779633
		public const int elementId_rightGripButton1 = 13; // Metadata: 0x00779637
		public const int elementId_rightGripButton2 = 14; // Metadata: 0x0077963B
		public const int elementId_rightGripButton3 = 15; // Metadata: 0x0077963F
		public const int elementId_rightGripButton4 = 16; // Metadata: 0x00779643
		public const int elementId_rightGripButton5 = 17; // Metadata: 0x00779647
		public const int elementId_rightGripButton6 = 18; // Metadata: 0x0077964B
		public const int elementId_centerButton1 = 19; // Metadata: 0x0077964F
		public const int elementId_centerButton2 = 20; // Metadata: 0x00779653
		public const int elementId_centerButton3 = 21; // Metadata: 0x00779657
		public const int elementId_centerButton4 = 22; // Metadata: 0x0077965B
		public const int elementId_centerButton5 = 23; // Metadata: 0x0077965F
		public const int elementId_centerButton6 = 24; // Metadata: 0x00779663
		public const int elementId_centerButton7 = 25; // Metadata: 0x00779667
		public const int elementId_centerButton8 = 26; // Metadata: 0x0077966B
		public const int elementId_wheel1Up = 53; // Metadata: 0x0077966F
		public const int elementId_wheel1Down = 54; // Metadata: 0x00779673
		public const int elementId_wheel1Press = 55; // Metadata: 0x00779677
		public const int elementId_wheel2Up = 56; // Metadata: 0x0077967B
		public const int elementId_wheel2Down = 57; // Metadata: 0x0077967F
		public const int elementId_wheel2Press = 58; // Metadata: 0x00779683
		public const int elementId_leftGripHatUp = 27; // Metadata: 0x00779687
		public const int elementId_leftGripHatUpRight = 28; // Metadata: 0x0077968B
		public const int elementId_leftGripHatRight = 29; // Metadata: 0x0077968F
		public const int elementId_leftGripHatDownRight = 30; // Metadata: 0x00779693
		public const int elementId_leftGripHatDown = 31; // Metadata: 0x00779697
		public const int elementId_leftGripHatDownLeft = 32; // Metadata: 0x0077969B
		public const int elementId_leftGripHatLeft = 33; // Metadata: 0x0077969F
		public const int elementId_leftGripHatUpLeft = 34; // Metadata: 0x007796A3
		public const int elementId_rightGripHatUp = 35; // Metadata: 0x007796A7
		public const int elementId_rightGripHatUpRight = 36; // Metadata: 0x007796AB
		public const int elementId_rightGripHatRight = 37; // Metadata: 0x007796AF
		public const int elementId_rightGripHatDownRight = 38; // Metadata: 0x007796B3
		public const int elementId_rightGripHatDown = 39; // Metadata: 0x007796B7
		public const int elementId_rightGripHatDownLeft = 40; // Metadata: 0x007796BB
		public const int elementId_rightGripHatLeft = 41; // Metadata: 0x007796BF
		public const int elementId_rightGripHatUpLeft = 42; // Metadata: 0x007796C3
		public const int elementId_consoleButton1 = 43; // Metadata: 0x007796C7
		public const int elementId_consoleButton2 = 44; // Metadata: 0x007796CB
		public const int elementId_consoleButton3 = 45; // Metadata: 0x007796CF
		public const int elementId_consoleButton4 = 46; // Metadata: 0x007796D3
		public const int elementId_consoleButton5 = 47; // Metadata: 0x007796D7
		public const int elementId_consoleButton6 = 48; // Metadata: 0x007796DB
		public const int elementId_consoleButton7 = 49; // Metadata: 0x007796DF
		public const int elementId_consoleButton8 = 50; // Metadata: 0x007796E3
		public const int elementId_consoleButton9 = 51; // Metadata: 0x007796E7
		public const int elementId_consoleButton10 = 52; // Metadata: 0x007796EB
		public const int elementId_mode1 = 61; // Metadata: 0x007796EF
		public const int elementId_mode2 = 62; // Metadata: 0x007796F3
		public const int elementId_mode3 = 63; // Metadata: 0x007796F7
		public const int elementId_yoke = 69; // Metadata: 0x007796FB
		public const int elementId_lever1 = 70; // Metadata: 0x007796FF
		public const int elementId_lever2 = 71; // Metadata: 0x00779703
		public const int elementId_lever3 = 72; // Metadata: 0x00779707
		public const int elementId_lever4 = 73; // Metadata: 0x0077970B
		public const int elementId_lever5 = 74; // Metadata: 0x0077970F
		public const int elementId_leftGripHat = 75; // Metadata: 0x00779713
		public const int elementId_rightGripHat = 76; // Metadata: 0x00779717
	
		// Properties
		IControllerTemplateButton IFlightYokeTemplate.leftPaddle { get; } // 0x000000018105D410-0x000000018105D450 
		IControllerTemplateButton IFlightYokeTemplate.rightPaddle { get; } // 0x000000018105D810-0x000000018105D850 
		IControllerTemplateButton IFlightYokeTemplate.leftGripButton1 { get; } // 0x000000018105D250-0x000000018105D290 
		IControllerTemplateButton IFlightYokeTemplate.leftGripButton2 { get; } // 0x000000018105D290-0x000000018105D2D0 
		IControllerTemplateButton IFlightYokeTemplate.leftGripButton3 { get; } // 0x000000018105D2D0-0x000000018105D310 
		IControllerTemplateButton IFlightYokeTemplate.leftGripButton4 { get; } // 0x000000018105D310-0x000000018105D350 
		IControllerTemplateButton IFlightYokeTemplate.leftGripButton5 { get; } // 0x000000018105D350-0x000000018105D390 
		IControllerTemplateButton IFlightYokeTemplate.leftGripButton6 { get; } // 0x000000018105D390-0x000000018105D3D0 
		IControllerTemplateButton IFlightYokeTemplate.rightGripButton1 { get; } // 0x000000018105D650-0x000000018105D690 
		IControllerTemplateButton IFlightYokeTemplate.rightGripButton2 { get; } // 0x000000018105D690-0x000000018105D6D0 
		IControllerTemplateButton IFlightYokeTemplate.rightGripButton3 { get; } // 0x000000018105D6D0-0x000000018105D710 
		IControllerTemplateButton IFlightYokeTemplate.rightGripButton4 { get; } // 0x000000018105D710-0x000000018105D750 
		IControllerTemplateButton IFlightYokeTemplate.rightGripButton5 { get; } // 0x000000018105D750-0x000000018105D790 
		IControllerTemplateButton IFlightYokeTemplate.rightGripButton6 { get; } // 0x000000018105D790-0x000000018105D7D0 
		IControllerTemplateButton IFlightYokeTemplate.centerButton1 { get; } // 0x000000018105CDD0-0x000000018105CE10 
		IControllerTemplateButton IFlightYokeTemplate.centerButton2 { get; } // 0x000000018105CE10-0x000000018105CE50 
		IControllerTemplateButton IFlightYokeTemplate.centerButton3 { get; } // 0x000000018105CE50-0x000000018105CE90 
		IControllerTemplateButton IFlightYokeTemplate.centerButton4 { get; } // 0x000000018105CE90-0x000000018105CED0 
		IControllerTemplateButton IFlightYokeTemplate.centerButton5 { get; } // 0x000000018105CED0-0x000000018105CF10 
		IControllerTemplateButton IFlightYokeTemplate.centerButton6 { get; } // 0x000000018105CF10-0x000000018105CF50 
		IControllerTemplateButton IFlightYokeTemplate.centerButton7 { get; } // 0x000000018105CF50-0x000000018105CF90 
		IControllerTemplateButton IFlightYokeTemplate.centerButton8 { get; } // 0x000000018105CF90-0x000000018105CFD0 
		IControllerTemplateButton IFlightYokeTemplate.wheel1Up { get; } // 0x000000018105D8D0-0x000000018105D910 
		IControllerTemplateButton IFlightYokeTemplate.wheel1Down { get; } // 0x000000018105D850-0x000000018105D890 
		IControllerTemplateButton IFlightYokeTemplate.wheel1Press { get; } // 0x000000018105D890-0x000000018105D8D0 
		IControllerTemplateButton IFlightYokeTemplate.wheel2Up { get; } // 0x000000018105D990-0x000000018105D9D0 
		IControllerTemplateButton IFlightYokeTemplate.wheel2Down { get; } // 0x000000018105D910-0x000000018105D950 
		IControllerTemplateButton IFlightYokeTemplate.wheel2Press { get; } // 0x000000018105D950-0x000000018105D990 
		IControllerTemplateButton IFlightYokeTemplate.consoleButton1 { get; } // 0x000000018105D010-0x000000018105D050 
		IControllerTemplateButton IFlightYokeTemplate.consoleButton2 { get; } // 0x000000018105D050-0x000000018105D090 
		IControllerTemplateButton IFlightYokeTemplate.consoleButton3 { get; } // 0x000000018105D090-0x000000018105D0D0 
		IControllerTemplateButton IFlightYokeTemplate.consoleButton4 { get; } // 0x000000018105D0D0-0x000000018105D110 
		IControllerTemplateButton IFlightYokeTemplate.consoleButton5 { get; } // 0x000000018105D110-0x000000018105D150 
		IControllerTemplateButton IFlightYokeTemplate.consoleButton6 { get; } // 0x000000018105D150-0x000000018105D190 
		IControllerTemplateButton IFlightYokeTemplate.consoleButton7 { get; } // 0x000000018105D190-0x000000018105D1D0 
		IControllerTemplateButton IFlightYokeTemplate.consoleButton8 { get; } // 0x000000018105D1D0-0x000000018105D210 
		IControllerTemplateButton IFlightYokeTemplate.consoleButton9 { get; } // 0x000000018105D210-0x000000018105D250 
		IControllerTemplateButton IFlightYokeTemplate.consoleButton10 { get; } // 0x000000018105CFD0-0x000000018105D010 
		IControllerTemplateButton IFlightYokeTemplate.mode1 { get; } // 0x000000018105D590-0x000000018105D5D0 
		IControllerTemplateButton IFlightYokeTemplate.mode2 { get; } // 0x000000018105D5D0-0x000000018105D610 
		IControllerTemplateButton IFlightYokeTemplate.mode3 { get; } // 0x000000018105D610-0x000000018105D650 
		IControllerTemplateYoke IFlightYokeTemplate.yoke { get; } // 0x000000018105D9D0-0x000000018105DA10 
		IControllerTemplateThrottle IFlightYokeTemplate.lever1 { get; } // 0x000000018105D450-0x000000018105D490 
		IControllerTemplateThrottle IFlightYokeTemplate.lever2 { get; } // 0x000000018105D490-0x000000018105D4D0 
		IControllerTemplateThrottle IFlightYokeTemplate.lever3 { get; } // 0x000000018105D4D0-0x000000018105D510 
		IControllerTemplateThrottle IFlightYokeTemplate.lever4 { get; } // 0x000000018105D510-0x000000018105D550 
		IControllerTemplateThrottle IFlightYokeTemplate.lever5 { get; } // 0x000000018105D550-0x000000018105D590 
		IControllerTemplateHat IFlightYokeTemplate.leftGripHat { get; } // 0x000000018105D3D0-0x000000018105D410 
		IControllerTemplateHat IFlightYokeTemplate.rightGripHat { get; } // 0x000000018105D7D0-0x000000018105D810 
	
		// Constructors
		public FlightYokeTemplate(object payload); // 0x000000018105CDC0-0x000000018105CDD0
		static FlightYokeTemplate(); // 0x000000018105DA10-0x000000018105DA70
	}
}
