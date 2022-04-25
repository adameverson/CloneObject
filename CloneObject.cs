using System;
using System.Reflection;
/// <summary>
/// Copia as propriedades de um objeto para outro.
/// </summary>
public class CloneObject
{
    /// <summary>
    /// Copia o valor das propriedades de um objeto para outro.
    /// </summary>
    /// <param name="objOrigem">Objeto origem.</param>
    /// <param name="objDestino">Objeto destino.</param>
    /// <returns>Objeto cópia.</returns>
    public static object CopiaPropriedades(object objOrigem, object objDestino)
    {
        if (objOrigem != null &&
            objDestino != null &&
            objOrigem.GetType().Equals(objDestino.GetType()))
        {
            // Tipo
            Type pTipo = objOrigem.GetType();

            // Nome de todas as propriedades.
            PropertyInfo[] pNome = pTipo.GetProperties();

            // Move todos os dados
            foreach (PropertyInfo propriedade in pNome)
            {
                propriedade.SetValue(objDestino, propriedade.GetValue(objOrigem, null), null);
            }
        }
        else
        {
            objDestino = null;
        }
        return objDestino;
    }
}
