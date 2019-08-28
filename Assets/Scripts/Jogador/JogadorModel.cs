using UnityEngine;

public class JogadorModel: MonoBehaviour {
    [SerializeField] private float vidas, tamanho, velocidade;

    public float Vidas {
        get => vidas;
        set => this.vidas = value;
    }

    public float Tamanho {
        get => tamanho;
        set => this.tamanho = value;
    }

    public float Velocidade {
        get => velocidade;
        set => this.velocidade = value;
    }
}
