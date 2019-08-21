using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentacaoDoJogador: MonoBehaviour {
    [SerializeField] private float forca;
    private Transform transform;

    void Start() {
        this.transform = this.GetComponent<Transform>();
    }

    void Update() {
        this.transform.Translate(Input.GetAxis("Horizontal") * this.forca, 0, 0);
    }
}
