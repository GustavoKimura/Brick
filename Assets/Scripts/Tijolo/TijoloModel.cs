using UnityEngine;

public class TijoloModel: MonoBehaviour {
    [SerializeField] private int vida;

    public int Vida {
        get => vida;
        set => this.vida = value;
    }
}
