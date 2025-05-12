using Unity.VisualScripting;
using UnityEngine;

public class Inimigo : Personagem
{
    
public enum ArmaDoinimigo
{
    ESPADA, MACHADO, ADAGA
}

public enum ArmaduraDoinimigo
{
    MADEIRA, COURO, BRONZE, AÇO
}

[ SerializeField ]
private ArmaduraDoinimigo armadura;
[ SerializeField ]
private ArmaDoinimigo arma;

public void AtribuirArmaduraDoinimigo(ArmaduraDoinimigo armadura)
{
    this.armadura = armadura;
}

public ArmaduraDoinimigo Armadura()
{
    return this.armadura;
}

public void AtribuirArmaDoInimigo(ArmaDoinimigo arma)
{
    this.arma = arma;
}

public ArmaDoinimigo Arma()
{
    return this.arma;
}

public int DanoDoInimigo()
{
    int dano = 0;

    switch (arma)
    {
        case ArmaDoinimigo.ESPADA:
            dano = Forca_Ataque() + 10;
            break;
        case ArmaDoinimigo.MACHADO:
            dano = Forca_Ataque() + 18;
            break;
        case ArmaDoinimigo.ADAGA:
            dano = Forca_Ataque() + 5;
            break;
    }

    // dano do ataque com a arma

    return dano;
}
void Start()
{
        
}
void Update()
{
        
}


public void AtribuirEnergia(int i)
{
    throw new System.NotImplementedException();
}

public void AtribuirForca_Ataque(int i)
{
    throw new System.NotImplementedException();
}

public void AtribuirForca_do_pulo(int i)
{
    throw new System.NotImplementedException();
}

public void AtribuirArma(object machado)
{
    throw new System.NotImplementedException();
}

public class ArmaDoInimigo
{
    public static object MACHADO;
}

public void AtribuirArmadura(object couro)
{
    throw new System.NotImplementedException();
}

public class ArmaduraDoInimigo
{
    public static object COURO;
}
}