using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Clock : MonoBehaviour {

    public Transform hours, minutes, seconds;
    public bool analog;

    private const float hoursToDegrees = 360 / 12,
                        minutesToDegrees = 360 / 60,
                        secondsToDegrees = 360 / 60;
	
	void Update () {
        
        if (analog) {
            TimeSpan time = DateTime.Now.TimeOfDay;
            hours.localRotation = Quaternion.Euler(0, 0, (float) time.TotalHours * -hoursToDegrees);
            minutes.localRotation = Quaternion.Euler(0, 0, (float) time.TotalMinutes * -minutesToDegrees);
            seconds.localRotation = Quaternion.Euler(0, 0, (float) time.TotalSeconds * -secondsToDegrees);
        } else {
            DateTime time = DateTime.Now;
            hours.localRotation = Quaternion.Euler(0, 0, time.Hour * -hoursToDegrees);
            minutes.localRotation = Quaternion.Euler(0, 0, time.Minute * -minutesToDegrees);
            seconds.localRotation = Quaternion.Euler(0, 0, time.Second * -secondsToDegrees);
        }
    }
}
