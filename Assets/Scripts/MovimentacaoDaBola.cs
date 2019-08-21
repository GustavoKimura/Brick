using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentacaoDaBola: MonoBehaviour {
    [SerializeField] private float velocidadeX, velocidadeZ;
    private Transform transform;

    void Start() {
        this.transform = this.GetComponent<Transform>();
    }

    void Update() {
        this.transform.Translate(this.velocidadeX, 0, this.velocidadeZ);
    }
}
