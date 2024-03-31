using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inGameOptions : MonoBehaviour
{
  public GameObject menuObject;
  public GameObject gameEmptyObject;
  public GameObject consoleCanvas;
  public void backToMenu()
  {
    gameEmptyObject.SetActive(false);
    menuObject.SetActive(true);
  }

  public void OcultarHistoria()
  {
        consoleCanvas.SetActive(false);
  }
  public void MostrarHistoria()
  {
      consoleCanvas.SetActive(true);
  }
}
