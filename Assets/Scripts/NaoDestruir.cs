﻿using UnityEngine;

public class NaoDestruir: MonoBehaviour {
    void Awake() {
        DontDestroyOnLoad(this.gameObject);
    }
}
