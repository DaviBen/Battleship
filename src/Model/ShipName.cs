using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;
using System.Linq;
using System.Xml.Linq;
namespace BattleShip
{
	/// <summary>
	/// The names of all of the ships in the gam
	/// </summary>
	/// <remarks></remarks>
	public enum ShipName
	{
		None = 0,
		Tug = 1,
		Submarine = 2,
		Destroyer = 3,
		Battleship = 4,
		AircraftCarrier = 5
	}
}

