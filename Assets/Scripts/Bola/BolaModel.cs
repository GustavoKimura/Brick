using UnityEngine;

public class BolaModel: MonoBehaviour {
    [SerializeField] private Vector2 direcao;
    [SerializeField] private float velocidade, forca;

    public Vector2 Direcao {
        get => direcao;
        set => this.direcao = value;
    }

    public float Velocidade {
        get => velocidade;
        set => this.velocidade = value;
    }

    public float Forca {
        get => forca;
        set => this.forca = value;
    }
}
