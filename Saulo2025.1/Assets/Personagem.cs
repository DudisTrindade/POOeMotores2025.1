using UnityEngine;

public class Personagem : MonoBehaviour
{


    [SerializeField] private string nome;
    [SerializeField] private int energia;
    [SerializeField] private int forca_ataque;
    [SerializeField] private int forca_do_pulo;
    [SerializeField] private int velocidade;
    [SerializeField] private int numero_de_pes;
    [SerializeField] private int numero_de_maos;

    public void AtribuirNome(string nome)
    {
        this.nome = nome;
    }

    public string atribuirNome()
    {
        return this.nome;
    }

    public void Atribuirenergia(int energia)
    {
        this.energia = energia;
    }

    public int atribuirenergia()
    {
        return this.energia;
    }

    public void Atribuirforca_ataque(int forca_ataque)
    {
        this.forca_ataque = forca_ataque;
    }


    public int Forca_Ataque()
    {
        return this.forca_ataque;
    }

    public void Atribuirforca_do_pulo(int forca_do_pulo)
    {
        this.forca_do_pulo = forca_do_pulo;
    }

    public int atribuirforca_do_pulo()
    {
        return this.forca_do_pulo;
    }

    private int Atribuirvelocidade(int velocidade)
    {
        return this.velocidade = velocidade;
    }

    public int Velocidade()
    {
        return this.velocidade;
    }

    private void atribuirnumero_de_pes(int numero_de_pes)
    {
        this.numero_de_pes = numero_de_pes;
    }

    public int Numero_de_pes()
    {
        return this.numero_de_pes;
    }

    private void Atribuirnumero_de_maos(int numero_de_maos)
    {
        this.numero_de_maos = numero_de_maos;
    }

    public int atribuirnumero_de_maos(int numero_de_maos)
    {
        return this.numero_de_maos;
    }


    public void AtribuitNumero_de_pes(int i)
    {
        throw new System.NotImplementedException();
    }

    public void AtribuirVelocidade(int i)
    {
        throw new System.NotImplementedException();
    }

    public void AtribuitNumero_de_maos(int i)
    {
        throw new System.NotImplementedException();
    }

    public int Energia()
    {
        throw new System.NotImplementedException();
    }

    public string Nome()
    {
        throw new System.NotImplementedException();
    }
}
    

    
