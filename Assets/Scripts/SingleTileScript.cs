using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingleTileScript : MonoBehaviour
{
  public InputScript inputScript;
  public BoardColor tileColor;


  public void OnMouseDown()
  {
    Debug.Log("Ficha en la que se hizo clic:" + this.gameObject.name);
    inputScript.tryToSelectTile(this.gameObject);
  }

  public void setTileColor(BoardColor color)
  {
    tileColor = color;
  }

  public BoardColor getTileColor()
  {
    return tileColor;
  }
}
