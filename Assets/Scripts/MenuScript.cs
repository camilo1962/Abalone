using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuScript : MonoBehaviour
{
  public GameManager gameManager;
  public ConsoleManager consoleManager;
  public BoardManager boardManager;

  public OptionsForLaunch options;
  GameObject menu;


  GameObject gameEmpty;

  void Start()
  {
    menu = GameObject.Find("Main Menu Canvas");
    gameEmpty = GameObject.Find("GameEmpty");
    Debug.Log(gameEmpty);
    gameEmpty.SetActive(false);


  }

  public void closeMenuAndShowGame()
  {
    menu.SetActive(false);
    consoleManager.sendMessageToConsole("El juego comenzó con estas opciones:");
    consoleManager.sendMessageToConsole("¿El blanco es IA? : " + options.isWhiteAnAgent());
    consoleManager.sendMessageToConsole("El negoro es IA? : " + options.isBlackAnAgent());
    consoleManager.sendMessageToConsole("Color: " + options.GetColor());
    consoleManager.sendMessageToConsole("Disposición: " + options.GetLayout());
    consoleManager.sendMessageToConsole("Tiempo Límite: " + options.getTimeLimit());
    consoleManager.sendMessageToConsole("Turnos Límites: " + options.getTurnLimit());
    gameEmpty.SetActive(true);
    gameManager.startGame();
  }

  public void exitGame()
  {
    Application.Quit();
  }

  // Update is called once per frame
}
