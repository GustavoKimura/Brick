using UnityEngine;

public class BolaModel: MonoBehaviour {
    [SerializeField] private Vector2 direcao;
    [SerializeField] private float velocidade, forca;

    public Vector2 Direcao {
        get => direcao;
        set => direcao = value;
    }

    public float Velocidade {
        get => velocidade;
        set => velocidade = value;
    }

    public float Forca {
        get => forca;
        set => forca = value;
    }
}
