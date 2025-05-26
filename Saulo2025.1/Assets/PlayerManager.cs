using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public Animator animator;
    private Player movimentoPlayer;
    public float velocidadeDaAnimaçao = 1;

    void Start()
    {
        movimentoPlayer = gameObject.GetComponent<Player>();
    }

    void Uptade()
    {
        animator.SetBool("Andando", Player.Andando);
        animator.speed = velocidadeDaAnimaçao;
    }


}