using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using UnityEngine;
using KModkit;

public class KillThemAllScript : MonoBehaviour
{

    public KMBombInfo Bomb;
    public KMAudio Audio;
    public KMBombModule Module;

    public KMSelectable nextButton;
    public TextMesh dayText;
    public KMSelectable[] wires;
    public Material[] ledColors,  wireColors;
    private static Material[] S_wireColors;
    public Material unlit;

    static int moduleIdCounter = 1;
    int moduleId;
    private bool moduleSolved;

    void Awake()
    {
        moduleId = moduleIdCounter++;
        S_wireColors = wireColors;
        for (int i = 0; i < 13; i++)
        {
            int ix = i;
        }

        //Button.OnInteract += delegate () { ButtonPress(); return false; };

    }

    void Start()
    {

    }

    void Update()
    {

    }

#pragma warning disable 414
    private readonly string TwitchHelpMessage = @"Use !{0} to do something.";
#pragma warning restore 414

    IEnumerator ProcessTwitchCommand(string Command)
    {
        yield return null;
    }

    IEnumerator TwitchHandleForcedSolve()
    {
        yield return null;
    }
}
