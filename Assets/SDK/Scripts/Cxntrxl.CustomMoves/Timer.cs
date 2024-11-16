using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[JsonTypeOverride("RUMBLE.Utilities.Timers.Timer, BucketheadEntertainment.Plugins")]
public class Timer : System.Object
{
    public delegate void OnTimerStart();

    public delegate void OnTimerFixedTick();

    public delegate void OnTimerTick();

    public delegate void OnTimerEnd();

    public bool Done;

    public float Elapsed;

    public bool IsPersistent;

    public bool MarkForCleanUp;

    public string Name;

    public OnTimerEnd OnTimerEnded;

    public OnTimerStart OnTimerStarted;

    public OnTimerTick OnTimerTicked;

    public float OriginalDuration;

    public bool Paused;

    public bool Recursive;
}
