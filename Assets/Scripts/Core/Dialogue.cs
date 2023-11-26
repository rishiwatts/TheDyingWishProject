using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*This script stores every dialogue conversation in a public Dictionary.*/

public class Dialogue : MonoBehaviour
{

    public Dictionary<string, string[]> dialogue = new Dictionary<string, string[]>();

    void Start()
    {
        //Door
        dialogue.Add("LockedDoorA", new string[] {
            "A large door...",
            "Looks like it has a key hole!"
        });


        dialogue.Add("LockedDoorB", new string[] {
            "Key used!"
        });

        //NPC
        dialogue.Add("CharacterA", new string[] {
            "Hi there!",
            "I'm an NPC! This conversation is called 'npcA'...",
            "If you go and find me 80 coins, my dialogue will move on to 'npcB'!",
            "Feel free to edit my dialogue in the 'Dialogue.cs' file!",
            "To keep it simple, you can also ask me one, and only one, question...",
            "...Like you just did! And I'll just move on to the next sentence.",
            "I'll answer that question, but it won't change much about the game!",
            "You can always tweak the 'DialogueBox.cs' script to add more functionality!"
        });

        dialogue.Add("CharacterAChoice1", new string[] {
            "",
            "",
            "Let me go find some coins!",
        });

        dialogue.Add("CharacterAChoice2", new string[] {
            "",
            "",
            "What else can you do?"
        });

        dialogue.Add("CharacterB", new string[] {
            "Hey! You found 80 coins! That means 'npcB' is now being used inside 'Dialogue.cs'!",
            "After my dialogue completes, I'll take 80 coins, or however many you specify in the inspector...",
            "And I'll also give you a new ability!",
            "In this case, how about a generic DOWNWARD SMASH? Simply attack while pressing down in mid-air!"
        });

        dialogue.Add("ElevatorIntro", new string[] {
            "ROSE: Grandma told me that Grandpa's office was on the top of the plant. This elevator should be able to take me up."
        });

        dialogue.Add("MissingPageFoundA", new string[] {
            "ROSE: A missing page...The handwriting looks quite familiar...wait, IT'S GRANDPA'S HANDWRITING!",
            "\"I wish I was not writing this. But the plant may soon close.\" ",
            "\"The higher ups don't care about any of us. All they care about is for profits.\"",
            "\"I must do something in order to set things right...\"",
            "He sounds sad. I wondered what happened here...",
            "WHOAAA!!!"
        });

        dialogue.Add("MissingPageA", new string[] {
            ""
        });

        dialogue.Add("GhostIntro", new string[] {
            "GHOST: Well well well. Look who we have here. Why does a child like you wander you here? Answer!",
            "ROSE: I am the grand-daughter of this plant's last Head Chief. I'm here to get his diary.",
            "GHOST: Wait you're Chief's grandchild. Yeah, you do look familiar. I was the Manager here and I worked under your grandfather.",
            "GHOST: He was always good to me and I really liked him. His diary you say? It should be in his office. It was there when I read... checked I mean.",
            "ROSE: Okayyy. Will you help me get it or...?",
            "GHOST: I'll help you. Though not directly and not for free.",
            "GHOST: Those gems you have collected, the green ones. They hold great value to me. So, I'll take those off of you and in return I can give you some powers!",
            "ROSE: What kinds of powers?",
            "GHOST: Not too flashy or anything. I can increase your damage or health, give you potions and stuff. I can be like a shop for you in this plant",
            "ROSE: That sounds so out of place, but okay as long as you're helping me. Where will I find you exactly?",
            "GHOST: Oh you can find me whenever you're entering a new area. That way you can prepare yourself ahead of time. This plant is not very safe. So do watch out.",
            "ROSE: Cool. Do you have anything for exchange now?",
            "GHOST: See for yourself..."
        });



    }
}
