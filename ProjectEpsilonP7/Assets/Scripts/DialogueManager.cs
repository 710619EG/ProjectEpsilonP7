using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialogueManager : MonoBehaviour
{
    public TextMeshProUGUI nameText;
    public TextMeshProUGUI dialogueText;

    public float typingSpeed;
    public bool isTalking;

    public Animator animator;
    public Queue<string> sentences;
    void Start()
    {
        sentences = new Queue<string> ();
    }

    public void StartDialogue(Dialogue dialogue)
    {
        animator.SetBool("IsOpen", true);
        nameText.text = dialogue.name;

        sentences.Clear();

        foreach (string sentence in dialogue.sentences)
        {
            sentences.Enqueue (sentence);
        }

        DisplayNextSentence();
    }

    public void DisplayNextSentence()
    {
        if (sentences.Count == 0)
        {
            EndDialogue();
            return;
        }
        typingSpeed = 0.02f;
        isTalking = true;
        string sentence = sentences.Dequeue();
        StopAllCoroutines();
        StartCoroutine(TypeSentence(sentence));

    }

    IEnumerator TypeSentence (string sentence)
    {
        dialogueText.text = "";
        foreach (char letter in sentence.ToCharArray())
        {
            dialogueText.text += letter;
            yield return new WaitForSecondsRealtime(typingSpeed);
        }
        isTalking = false;
    }

    void Update()
    {
        if (Input.GetKeyDown("e"))
        {
            typingSpeed = 0f;

            if (!isTalking)
            {
                DisplayNextSentence ();
            }
        }
    }

    void EndDialogue()
    {
        animator.SetBool("IsOpen", false);
    }
}
