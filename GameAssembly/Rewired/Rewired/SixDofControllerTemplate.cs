/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 78: Rewired.dll - Assembly: Rewired, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9189-9271

namespace Rewired
{
	public sealed class SixDofControllerTemplate : ControllerTemplate, ISixDofControllerTemplate // TypeDefIndex: 9201
	{
		// Fields
		public static readonly Guid typeGuid; // 0x00
		public const int elementId_positionX = 1; // Metadata: 0x00744A39
		public const int elementId_positionY = 2; // Metadata: 0x00744A3D
		public const int elementId_positionZ = 0; // Metadata: 0x00744A41
		public const int elementId_rotationX = 3; // Metadata: 0x00744A45
		public const int elementId_rotationY = 5; // Metadata: 0x00744A49
		public const int elementId_rotationZ = 4; // Metadata: 0x00744A4D
		public const int elementId_throttle1Axis = 6; // Metadata: 0x00744A51
		public const int elementId_throttle1MinDetent = 50; // Metadata: 0x00744A55
		public const int elementId_throttle2Axis = 7; // Metadata: 0x00744A59
		public const int elementId_throttle2MinDetent = 51; // Metadata: 0x00744A5D
		public const int elementId_extraAxis1 = 8; // Metadata: 0x00744A61
		public const int elementId_extraAxis2 = 9; // Metadata: 0x00744A65
		public const int elementId_extraAxis3 = 10; // Metadata: 0x00744A69
		public const int elementId_extraAxis4 = 11; // Metadata: 0x00744A6D
		public const int elementId_button1 = 12; // Metadata: 0x00744A71
		public const int elementId_button2 = 13; // Metadata: 0x00744A75
		public const int elementId_button3 = 14; // Metadata: 0x00744A79
		public const int elementId_button4 = 15; // Metadata: 0x00744A7D
		public const int elementId_button5 = 16; // Metadata: 0x00744A81
		public const int elementId_button6 = 17; // Metadata: 0x00744A85
		public const int elementId_button7 = 18; // Metadata: 0x00744A89
		public const int elementId_button8 = 19; // Metadata: 0x00744A8D
		public const int elementId_button9 = 20; // Metadata: 0x00744A91
		public const int elementId_button10 = 21; // Metadata: 0x00744A95
		public const int elementId_button11 = 22; // Metadata: 0x00744A99
		public const int elementId_button12 = 23; // Metadata: 0x00744A9D
		public const int elementId_button13 = 24; // Metadata: 0x00744AA1
		public const int elementId_button14 = 25; // Metadata: 0x00744AA5
		public const int elementId_button15 = 26; // Metadata: 0x00744AA9
		public const int elementId_button16 = 27; // Metadata: 0x00744AAD
		public const int elementId_button17 = 28; // Metadata: 0x00744AB1
		public const int elementId_button18 = 29; // Metadata: 0x00744AB5
		public const int elementId_button19 = 30; // Metadata: 0x00744AB9
		public const int elementId_button20 = 31; // Metadata: 0x00744ABD
		public const int elementId_button21 = 55; // Metadata: 0x00744AC1
		public const int elementId_button22 = 56; // Metadata: 0x00744AC5
		public const int elementId_button23 = 57; // Metadata: 0x00744AC9
		public const int elementId_button24 = 58; // Metadata: 0x00744ACD
		public const int elementId_button25 = 59; // Metadata: 0x00744AD1
		public const int elementId_button26 = 60; // Metadata: 0x00744AD5
		public const int elementId_button27 = 61; // Metadata: 0x00744AD9
		public const int elementId_button28 = 62; // Metadata: 0x00744ADD
		public const int elementId_button29 = 63; // Metadata: 0x00744AE1
		public const int elementId_button30 = 64; // Metadata: 0x00744AE5
		public const int elementId_button31 = 65; // Metadata: 0x00744AE9
		public const int elementId_button32 = 66; // Metadata: 0x00744AED
		public const int elementId_hat1Up = 32; // Metadata: 0x00744AF1
		public const int elementId_hat1UpRight = 33; // Metadata: 0x00744AF5
		public const int elementId_hat1Right = 34; // Metadata: 0x00744AF9
		public const int elementId_hat1DownRight = 35; // Metadata: 0x00744AFD
		public const int elementId_hat1Down = 36; // Metadata: 0x00744B01
		public const int elementId_hat1DownLeft = 37; // Metadata: 0x00744B05
		public const int elementId_hat1Left = 38; // Metadata: 0x00744B09
		public const int elementId_hat1UpLeft = 39; // Metadata: 0x00744B0D
		public const int elementId_hat2Up = 40; // Metadata: 0x00744B11
		public const int elementId_hat2UpRight = 41; // Metadata: 0x00744B15
		public const int elementId_hat2Right = 42; // Metadata: 0x00744B19
		public const int elementId_hat2DownRight = 43; // Metadata: 0x00744B1D
		public const int elementId_hat2Down = 44; // Metadata: 0x00744B21
		public const int elementId_hat2DownLeft = 45; // Metadata: 0x00744B25
		public const int elementId_hat2Left = 46; // Metadata: 0x00744B29
		public const int elementId_hat2UpLeft = 47; // Metadata: 0x00744B2D
		public const int elementId_hat1 = 48; // Metadata: 0x00744B31
		public const int elementId_hat2 = 49; // Metadata: 0x00744B35
		public const int elementId_throttle1 = 52; // Metadata: 0x00744B39
		public const int elementId_throttle2 = 53; // Metadata: 0x00744B3D
		public const int elementId_stick = 54; // Metadata: 0x00744B41
	
		// Properties
		IControllerTemplateAxis ISixDofControllerTemplate.extraAxis1 { get; } // 0x0000000181BCB290-0x0000000181BCB2D0 
		IControllerTemplateAxis ISixDofControllerTemplate.extraAxis2 { get; } // 0x0000000181BCB2D0-0x0000000181BCB310 
		IControllerTemplateAxis ISixDofControllerTemplate.extraAxis3 { get; } // 0x0000000181BCB310-0x0000000181BCB350 
		IControllerTemplateAxis ISixDofControllerTemplate.extraAxis4 { get; } // 0x0000000181BCB350-0x0000000181BCB390 
		IControllerTemplateButton ISixDofControllerTemplate.button1 { get; } // 0x0000000181BCAD10-0x0000000181BCAD50 
		IControllerTemplateButton ISixDofControllerTemplate.button2 { get; } // 0x0000000181BCAFD0-0x0000000181BCB010 
		IControllerTemplateButton ISixDofControllerTemplate.button3 { get; } // 0x0000000181BCB0D0-0x0000000181BCB110 
		IControllerTemplateButton ISixDofControllerTemplate.button4 { get; } // 0x0000000181BCB110-0x0000000181BCB150 
		IControllerTemplateButton ISixDofControllerTemplate.button5 { get; } // 0x0000000181BCB150-0x0000000181BCB190 
		IControllerTemplateButton ISixDofControllerTemplate.button6 { get; } // 0x0000000181BCB190-0x0000000181BCB1D0 
		IControllerTemplateButton ISixDofControllerTemplate.button7 { get; } // 0x0000000181BCB1D0-0x0000000181BCB210 
		IControllerTemplateButton ISixDofControllerTemplate.button8 { get; } // 0x0000000181BCB210-0x0000000181BCB250 
		IControllerTemplateButton ISixDofControllerTemplate.button9 { get; } // 0x0000000181BCB250-0x0000000181BCB290 
		IControllerTemplateButton ISixDofControllerTemplate.button10 { get; } // 0x0000000181BCAA90-0x0000000181BCAAD0 
		IControllerTemplateButton ISixDofControllerTemplate.button11 { get; } // 0x0000000181BCAAD0-0x0000000181BCAB10 
		IControllerTemplateButton ISixDofControllerTemplate.button12 { get; } // 0x0000000181BCAB10-0x0000000181BCAB50 
		IControllerTemplateButton ISixDofControllerTemplate.button13 { get; } // 0x0000000181BCAB50-0x0000000181BCAB90 
		IControllerTemplateButton ISixDofControllerTemplate.button14 { get; } // 0x0000000181BCAB90-0x0000000181BCABD0 
		IControllerTemplateButton ISixDofControllerTemplate.button15 { get; } // 0x0000000181BCABD0-0x0000000181BCAC10 
		IControllerTemplateButton ISixDofControllerTemplate.button16 { get; } // 0x0000000181BCAC10-0x0000000181BCAC50 
		IControllerTemplateButton ISixDofControllerTemplate.button17 { get; } // 0x0000000181BCAC50-0x0000000181BCAC90 
		IControllerTemplateButton ISixDofControllerTemplate.button18 { get; } // 0x0000000181BCAC90-0x0000000181BCACD0 
		IControllerTemplateButton ISixDofControllerTemplate.button19 { get; } // 0x0000000181BCACD0-0x0000000181BCAD10 
		IControllerTemplateButton ISixDofControllerTemplate.button20 { get; } // 0x0000000181BCAD50-0x0000000181BCAD90 
		IControllerTemplateButton ISixDofControllerTemplate.button21 { get; } // 0x0000000181BCAD90-0x0000000181BCADD0 
		IControllerTemplateButton ISixDofControllerTemplate.button22 { get; } // 0x0000000181BCADD0-0x0000000181BCAE10 
		IControllerTemplateButton ISixDofControllerTemplate.button23 { get; } // 0x0000000181BCAE10-0x0000000181BCAE50 
		IControllerTemplateButton ISixDofControllerTemplate.button24 { get; } // 0x0000000181BCAE50-0x0000000181BCAE90 
		IControllerTemplateButton ISixDofControllerTemplate.button25 { get; } // 0x0000000181BCAE90-0x0000000181BCAED0 
		IControllerTemplateButton ISixDofControllerTemplate.button26 { get; } // 0x0000000181BCAED0-0x0000000181BCAF10 
		IControllerTemplateButton ISixDofControllerTemplate.button27 { get; } // 0x0000000181BCAF10-0x0000000181BCAF50 
		IControllerTemplateButton ISixDofControllerTemplate.button28 { get; } // 0x0000000181BCAF50-0x0000000181BCAF90 
		IControllerTemplateButton ISixDofControllerTemplate.button29 { get; } // 0x0000000181BCAF90-0x0000000181BCAFD0 
		IControllerTemplateButton ISixDofControllerTemplate.button30 { get; } // 0x0000000181BCB010-0x0000000181BCB050 
		IControllerTemplateButton ISixDofControllerTemplate.button31 { get; } // 0x0000000181BCB050-0x0000000181BCB090 
		IControllerTemplateButton ISixDofControllerTemplate.button32 { get; } // 0x0000000181BCB090-0x0000000181BCB0D0 
		IControllerTemplateHat ISixDofControllerTemplate.hat1 { get; } // 0x0000000181BCB390-0x0000000181BCB3D0 
		IControllerTemplateHat ISixDofControllerTemplate.hat2 { get; } // 0x0000000181BCB3D0-0x0000000181BCB410 
		IControllerTemplateThrottle ISixDofControllerTemplate.throttle1 { get; } // 0x0000000181BCB450-0x0000000181BCB490 
		IControllerTemplateThrottle ISixDofControllerTemplate.throttle2 { get; } // 0x0000000181BCB490-0x0000000181BCB4D0 
		IControllerTemplateStick6D ISixDofControllerTemplate.stick { get; } // 0x0000000181BCB410-0x0000000181BCB450 
	
		// Constructors
		public SixDofControllerTemplate(object payload); // 0x0000000181BBD780-0x0000000181BBD790
		static SixDofControllerTemplate(); // 0x0000000181BCB4D0-0x0000000181BCB530
	}
}
