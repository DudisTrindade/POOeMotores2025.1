using UnityEngine;

public class Ataque : MonoBehaviour
{
    public Inimigo inimigo;
    private int ataque;
    

    public int AtaqueDoInimigo()
    {
        ataque = inimigo.DanoDoInimigo();
        Debug.Log("O Player levou " + Ataque + "de Dano Do Inimigo" );
        return ataque;
    }
}