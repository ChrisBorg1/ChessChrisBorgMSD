using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chessman : MonoBehaviour
{
  //References
    public GameObject controller;
    public GameObject movePlate;

  //Positions
  private int xBoard = -1;
  private int yBoard = -1;

  //Variable to keep track of player 1 and player 2
  private string player;

  //References for all the sprites that the chess piece can be
  public Sprite black_queen, black_knight, black_bishop, black_king, black_rook, black_pawn;
public Sprite white_queen, white_knight, white_bishop, white_king, white_rook, white_pawn;

}
