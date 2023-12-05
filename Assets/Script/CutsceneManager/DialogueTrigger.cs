using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueTrigger : MonoBehaviour
{
    //public List<Message> messages = new List<Message>();
    public Message[] messages;
    public Actor[] actors;

    public void StartDialogue()
    {
        FindObjectOfType<DialogueBoxManager>().OpenDialogue(messages, actors);
    }
}

[System.Serializable] 
public class Message //informasi dialog
{
    public int actorId; //id dari pembicara yang ingin dipanggil
    public string message; //isi dialog
}

[System.Serializable]
public class Actor //informasi pembicara dialog
{
    public string name; //nama pembicara
    //public Sprite sprite; //sprite pembicara
    public Sprite image;
    public AudioClip nextMessageSound; //suara
}
