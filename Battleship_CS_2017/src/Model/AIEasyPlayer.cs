using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
//using System.Data;
using System.Diagnostics;
/// <summary>
/// The AIEasyPlayer is a type of AIPlayer where it will pick squares at random
/// </summary>

public class AIEasyPlayer : AIPlayer
{
	public AIEasyPlayer(BattleShipsGame controller) : base(controller)
	{
	}
	/// <summary>
	/// Generate a valid row, column to shoot at
	/// </summary>
	/// <param name="row">output the row for the next shot</param>
	/// <param name="column">output the column for the next show</param>
	protected override void GenerateCoords(ref int row, ref int column)
	{
		do {
			row = _Random.Next(0, EnemyGrid.Height);
			column = _Random.Next(0, EnemyGrid.Width);
		} while ((row < 0 || column < 0 || row >= EnemyGrid.Height || column >= EnemyGrid.Width || EnemyGrid[row, column] != TileView.Sea));
		//while inside the grid and not a sea tile do the search
	}

	/// <summary>
	/// The last shot had the following result. Child classes can use this
	/// to prepare for the next shot.
	/// </summary>
	/// <param name="result">The result of the shot</param>
	/// <param name="row">the row shot</param>
	/// <param name="col">the column shot</param>
	protected override void ProcessShot(int row, int col, AttackResult result)
	{
		if (result.Value == ResultOfAttack.Hit) {
			do {
				row = _Random.Next(0, EnemyGrid.Height);
				col = _Random.Next(0, EnemyGrid.Width);
			} while ((row < 0 || col < 0 || row >= EnemyGrid.Height || col >= EnemyGrid.Width || EnemyGrid[row, col] != TileView.Sea));
		} else if (result.Value == ResultOfAttack.ShotAlready) {
			throw new ApplicationException("Error in AI");
		}
	}
}

