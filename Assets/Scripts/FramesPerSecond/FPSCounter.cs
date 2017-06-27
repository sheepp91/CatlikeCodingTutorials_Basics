using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSCounter : MonoBehaviour {
    public int AverageFPS { get;  private set; }
    public int frameRange = 60;

    private int[] fpsBuffer;
    private int fpsBufferIndex;

    void Update () {
        AverageFPS = (int)(1f / Time.unscaledDeltaTime);
	}

    void InitializeBuffer() {
        if (frameRange <= 0) {
            frameRange = 1;
        }
        fpsBuffer = new int[frameRange];
        fpsBufferIndex = 0;
    }
}
