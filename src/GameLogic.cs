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
	static class GameLogic
	{
		public static void Main()
		{
			//Opens a new Graphics Window
			SwinGame.OpenGraphicsWindow("Battle Ships", 800, 600);

			//Load Resources
			GameResources.LoadResources();

			SwinGame.PlayMusic(GameResources.GameMusic("Background"));

			//Game Loop
			do {
				GameController.HandleUserInput();
				GameController.DrawScreen();
			} while (!(SwinGame.WindowCloseRequested() == true | GameController.CurrentState == GameState.Quitting));

			SwinGame.StopMusic();

			//Free Resources and Close Audio, to end the program.
			GameResources.FreeResources();
		}
	}
}
