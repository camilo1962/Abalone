using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ConsoleManager : MonoBehaviour
{

  public GameObject consolePanel, textObject;
  public static int maxMessages = 200;

  [SerializeField]
  public static List<Message> messageList = new List<Message>();

  void Start()
  {

  }
  void Update()
  {
    //If there is a new message
  }

  public static void debugPrintAllMessages()
  {
    foreach (Message message in messageList)
    {
      Debug.Log(message.text);
    }
  }

  public void printNotAPillarError()
  {
    sendMessageToConsole("Intentaste mover fichas que no estaban en un pilar. Movimiento no válido.");
  }

  public void sendMessageToConsole(string newMessage)
  {
    if (messageList.Count > maxMessages)
    {
      Destroy(messageList[0].textObject.gameObject);
      messageList.Remove(messageList[0]);
    }
    Debug.Log("Enviando " + newMessage + "A la lista de mensajes");
    Message message = new Message();
    message.text = newMessage;
    GameObject newText = Instantiate(textObject, consolePanel.transform);
    message.textObject = newText.GetComponent<Text>();
    message.textObject.text = message.text;
    messageList.Add(message);
  }
}

[System.Serializable]
public class Message
{
  public string text;
  public Text textObject;
}
