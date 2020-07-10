/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 78: Rewired.dll - Assembly: Rewired, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9189-9271

namespace Rewired
{
	public sealed class FlightYokeTemplate : ControllerTemplate, IFlightYokeTemplate // TypeDefIndex: 9199
	{
		// Fields
		public static readonly Guid typeGuid; // 0x00
		public const int elementId_rotateYoke = 0; // Metadata: 0x007448F9
		public const int elementId_yokeZ = 1; // Metadata: 0x007448FD
		public const int elementId_leftPaddle = 59; // Metadata: 0x00744901
		public const int elementId_rightPaddle = 60; // Metadata: 0x00744905
		public const int elementId_lever1Axis = 2; // Metadata: 0x00744909
		public const int elementId_lever1MinDetent = 64; // Metadata: 0x0074490D
		public const int elementId_lever2Axis = 3; // Metadata: 0x00744911
		public const int elementId_lever2MinDetent = 65; // Metadata: 0x00744915
		public const int elementId_lever3Axis = 4; // Metadata: 0x00744919
		public const int elementId_lever3MinDetent = 66; // Metadata: 0x0074491D
		public const int elementId_lever4Axis = 5; // Metadata: 0x00744921
		public const int elementId_lever4MinDetent = 67; // Metadata: 0x00744925
		public const int elementId_lever5Axis = 6; // Metadata: 0x00744929
		public const int elementId_lever5MinDetent = 68; // Metadata: 0x0074492D
		public const int elementId_leftGripButton1 = 7; // Metadata: 0x00744931
		public const int elementId_leftGripButton2 = 8; // Metadata: 0x00744935
		public const int elementId_leftGripButton3 = 9; // Metadata: 0x00744939
		public const int elementId_leftGripButton4 = 10; // Metadata: 0x0074493D
		public const int elementId_leftGripButton5 = 11; // Metadata: 0x00744941
		public const int elementId_leftGripButton6 = 12; // Metadata: 0x00744945
		public const int elementId_rightGripButton1 = 13; // Metadata: 0x00744949
		public const int elementId_rightGripButton2 = 14; // Metadata: 0x0074494D
		public const int elementId_rightGripButton3 = 15; // Metadata: 0x00744951
		public const int elementId_rightGripButton4 = 16; // Metadata: 0x00744955
		public const int elementId_rightGripButton5 = 17; // Metadata: 0x00744959
		public const int elementId_rightGripButton6 = 18; // Metadata: 0x0074495D
		public const int elementId_centerButton1 = 19; // Metadata: 0x00744961
		public const int elementId_centerButton2 = 20; // Metadata: 0x00744965
		public const int elementId_centerButton3 = 21; // Metadata: 0x00744969
		public const int elementId_centerButton4 = 22; // Metadata: 0x0074496D
		public const int elementId_centerButton5 = 23; // Metadata: 0x00744971
		public const int elementId_centerButton6 = 24; // Metadata: 0x00744975
		public const int elementId_centerButton7 = 25; // Metadata: 0x00744979
		public const int elementId_centerButton8 = 26; // Metadata: 0x0074497D
		public const int elementId_wheel1Up = 53; // Metadata: 0x00744981
		public const int elementId_wheel1Down = 54; // Metadata: 0x00744985
		public const int elementId_wheel1Press = 55; // Metadata: 0x00744989
		public const int elementId_wheel2Up = 56; // Metadata: 0x0074498D
		public const int elementId_wheel2Down = 57; // Metadata: 0x00744991
		public const int elementId_wheel2Press = 58; // Metadata: 0x00744995
		public const int elementId_leftGripHatUp = 27; // Metadata: 0x00744999
		public const int elementId_leftGripHatUpRight = 28; // Metadata: 0x0074499D
		public const int elementId_leftGripHatRight = 29; // Metadata: 0x007449A1
		public const int elementId_leftGripHatDownRight = 30; // Metadata: 0x007449A5
		public const int elementId_leftGripHatDown = 31; // Metadata: 0x007449A9
		public const int elementId_leftGripHatDownLeft = 32; // Metadata: 0x007449AD
		public const int elementId_leftGripHatLeft = 33; // Metadata: 0x007449B1
		public const int elementId_leftGripHatUpLeft = 34; // Metadata: 0x007449B5
		public const int elementId_rightGripHatUp = 35; // Metadata: 0x007449B9
		public const int elementId_rightGripHatUpRight = 36; // Metadata: 0x007449BD
		public const int elementId_rightGripHatRight = 37; // Metadata: 0x007449C1
		public const int elementId_rightGripHatDownRight = 38; // Metadata: 0x007449C5
		public const int elementId_rightGripHatDown = 39; // Metadata: 0x007449C9
		public const int elementId_rightGripHatDownLeft = 40; // Metadata: 0x007449CD
		public const int elementId_rightGripHatLeft = 41; // Metadata: 0x007449D1
		public const int elementId_rightGripHatUpLeft = 42; // Metadata: 0x007449D5
		public const int elementId_consoleButton1 = 43; // Metadata: 0x007449D9
		public const int elementId_consoleButton2 = 44; // Metadata: 0x007449DD
		public const int elementId_consoleButton3 = 45; // Metadata: 0x007449E1
		public const int elementId_consoleButton4 = 46; // Metadata: 0x007449E5
		public const int elementId_consoleButton5 = 47; // Metadata: 0x007449E9
		public const int elementId_consoleButton6 = 48; // Metadata: 0x007449ED
		public const int elementId_consoleButton7 = 49; // Metadata: 0x007449F1
		public const int elementId_consoleButton8 = 50; // Metadata: 0x007449F5
		public const int elementId_consoleButton9 = 51; // Metadata: 0x007449F9
		public const int elementId_consoleButton10 = 52; // Metadata: 0x007449FD
		public const int elementId_mode1 = 61; // Metadata: 0x00744A01
		public const int elementId_mode2 = 62; // Metadata: 0x00744A05
		public const int elementId_mode3 = 63; // Metadata: 0x00744A09
		public const int elementId_yoke = 69; // Metadata: 0x00744A0D
		public const int elementId_lever1 = 70; // Metadata: 0x00744A11
		public const int elementId_lever2 = 71; // Metadata: 0x00744A15
		public const int elementId_lever3 = 72; // Metadata: 0x00744A19
		public const int elementId_lever4 = 73; // Metadata: 0x00744A1D
		public const int elementId_lever5 = 74; // Metadata: 0x00744A21
		public const int elementId_leftGripHat = 75; // Metadata: 0x00744A25
		public const int elementId_rightGripHat = 76; // Metadata: 0x00744A29
	
		// Properties
		IControllerTemplateButton IFlightYokeTemplate.leftPaddle { get; } // 0x0000000181BBDDD0-0x0000000181BBDE10 
		IControllerTemplateButton IFlightYokeTemplate.rightPaddle { get; } // 0x0000000181BBE1D0-0x0000000181BBE210 
		IControllerTemplateButton IFlightYokeTemplate.leftGripButton1 { get; } // 0x0000000181BBDC10-0x0000000181BBDC50 
		IControllerTemplateButton IFlightYokeTemplate.leftGripButton2 { get; } // 0x0000000181BBDC50-0x0000000181BBDC90 
		IControllerTemplateButton IFlightYokeTemplate.leftGripButton3 { get; } // 0x0000000181BBDC90-0x0000000181BBDCD0 
		IControllerTemplateButton IFlightYokeTemplate.leftGripButton4 { get; } // 0x0000000181BBDCD0-0x0000000181BBDD10 
		IControllerTemplateButton IFlightYokeTemplate.leftGripButton5 { get; } // 0x0000000181BBDD10-0x0000000181BBDD50 
		IControllerTemplateButton IFlightYokeTemplate.leftGripButton6 { get; } // 0x0000000181BBDD50-0x0000000181BBDD90 
		IControllerTemplateButton IFlightYokeTemplate.rightGripButton1 { get; } // 0x0000000181BBE010-0x0000000181BBE050 
		IControllerTemplateButton IFlightYokeTemplate.rightGripButton2 { get; } // 0x0000000181BBE050-0x0000000181BBE090 
		IControllerTemplateButton IFlightYokeTemplate.rightGripButton3 { get; } // 0x0000000181BBE090-0x0000000181BBE0D0 
		IControllerTemplateButton IFlightYokeTemplate.rightGripButton4 { get; } // 0x0000000181BBE0D0-0x0000000181BBE110 
		IControllerTemplateButton IFlightYokeTemplate.rightGripButton5 { get; } // 0x0000000181BBE110-0x0000000181BBE150 
		IControllerTemplateButton IFlightYokeTemplate.rightGripButton6 { get; } // 0x0000000181BBE150-0x0000000181BBE190 
		IControllerTemplateButton IFlightYokeTemplate.centerButton1 { get; } // 0x0000000181BBD790-0x0000000181BBD7D0 
		IControllerTemplateButton IFlightYokeTemplate.centerButton2 { get; } // 0x0000000181BBD7D0-0x0000000181BBD810 
		IControllerTemplateButton IFlightYokeTemplate.centerButton3 { get; } // 0x0000000181BBD810-0x0000000181BBD850 
		IControllerTemplateButton IFlightYokeTemplate.centerButton4 { get; } // 0x0000000181BBD850-0x0000000181BBD890 
		IControllerTemplateButton IFlightYokeTemplate.centerButton5 { get; } // 0x0000000181BBD890-0x0000000181BBD8D0 
		IControllerTemplateButton IFlightYokeTemplate.centerButton6 { get; } // 0x0000000181BBD8D0-0x0000000181BBD910 
		IControllerTemplateButton IFlightYokeTemplate.centerButton7 { get; } // 0x0000000181BBD910-0x0000000181BBD950 
		IControllerTemplateButton IFlightYokeTemplate.centerButton8 { get; } // 0x0000000181BBD950-0x0000000181BBD990 
		IControllerTemplateButton IFlightYokeTemplate.wheel1Up { get; } // 0x0000000181BBE290-0x0000000181BBE2D0 
		IControllerTemplateButton IFlightYokeTemplate.wheel1Down { get; } // 0x0000000181BBE210-0x0000000181BBE250 
		IControllerTemplateButton IFlightYokeTemplate.wheel1Press { get; } // 0x0000000181BBE250-0x0000000181BBE290 
		IControllerTemplateButton IFlightYokeTemplate.wheel2Up { get; } // 0x0000000181BBE350-0x0000000181BBE390 
		IControllerTemplateButton IFlightYokeTemplate.wheel2Down { get; } // 0x0000000181BBE2D0-0x0000000181BBE310 
		IControllerTemplateButton IFlightYokeTemplate.wheel2Press { get; } // 0x0000000181BBE310-0x0000000181BBE350 
		IControllerTemplateButton IFlightYokeTemplate.consoleButton1 { get; } // 0x0000000181BBD9D0-0x0000000181BBDA10 
		IControllerTemplateButton IFlightYokeTemplate.consoleButton2 { get; } // 0x0000000181BBDA10-0x0000000181BBDA50 
		IControllerTemplateButton IFlightYokeTemplate.consoleButton3 { get; } // 0x0000000181BBDA50-0x0000000181BBDA90 
		IControllerTemplateButton IFlightYokeTemplate.consoleButton4 { get; } // 0x0000000181BBDA90-0x0000000181BBDAD0 
		IControllerTemplateButton IFlightYokeTemplate.consoleButton5 { get; } // 0x0000000181BBDAD0-0x0000000181BBDB10 
		IControllerTemplateButton IFlightYokeTemplate.consoleButton6 { get; } // 0x0000000181BBDB10-0x0000000181BBDB50 
		IControllerTemplateButton IFlightYokeTemplate.consoleButton7 { get; } // 0x0000000181BBDB50-0x0000000181BBDB90 
		IControllerTemplateButton IFlightYokeTemplate.consoleButton8 { get; } // 0x0000000181BBDB90-0x0000000181BBDBD0 
		IControllerTemplateButton IFlightYokeTemplate.consoleButton9 { get; } // 0x0000000181BBDBD0-0x0000000181BBDC10 
		IControllerTemplateButton IFlightYokeTemplate.consoleButton10 { get; } // 0x0000000181BBD990-0x0000000181BBD9D0 
		IControllerTemplateButton IFlightYokeTemplate.mode1 { get; } // 0x0000000181BBDF50-0x0000000181BBDF90 
		IControllerTemplateButton IFlightYokeTemplate.mode2 { get; } // 0x0000000181BBDF90-0x0000000181BBDFD0 
		IControllerTemplateButton IFlightYokeTemplate.mode3 { get; } // 0x0000000181BBDFD0-0x0000000181BBE010 
		IControllerTemplateYoke IFlightYokeTemplate.yoke { get; } // 0x0000000181BBE390-0x0000000181BBE3D0 
		IControllerTemplateThrottle IFlightYokeTemplate.lever1 { get; } // 0x0000000181BBDE10-0x0000000181BBDE50 
		IControllerTemplateThrottle IFlightYokeTemplate.lever2 { get; } // 0x0000000181BBDE50-0x0000000181BBDE90 
		IControllerTemplateThrottle IFlightYokeTemplate.lever3 { get; } // 0x0000000181BBDE90-0x0000000181BBDED0 
		IControllerTemplateThrottle IFlightYokeTemplate.lever4 { get; } // 0x0000000181BBDED0-0x0000000181BBDF10 
		IControllerTemplateThrottle IFlightYokeTemplate.lever5 { get; } // 0x0000000181BBDF10-0x0000000181BBDF50 
		IControllerTemplateHat IFlightYokeTemplate.leftGripHat { get; } // 0x0000000181BBDD90-0x0000000181BBDDD0 
		IControllerTemplateHat IFlightYokeTemplate.rightGripHat { get; } // 0x0000000181BBE190-0x0000000181BBE1D0 
	
		// Constructors
		public FlightYokeTemplate(object payload); // 0x0000000181BBD780-0x0000000181BBD790
		static FlightYokeTemplate(); // 0x0000000181BBE3D0-0x0000000181BBE430
	}
}
