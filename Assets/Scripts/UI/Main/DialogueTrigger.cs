﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    [SerializeField] private Dialogue        dialogue;
    [SerializeField] private DialogueManager dialogueManager;

    public void TriggerDialogue()
    {
        if (dialogue != null && dialogueManager != null)
        {
            dialogueManager.StartDialogue(dialogue);
        }
    }
}
