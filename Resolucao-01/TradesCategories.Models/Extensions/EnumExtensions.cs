using System;
using System.ComponentModel;
using System.Linq;
using System.Text.RegularExpressions;

namespace TradesCategories.Models.Extensions
{
    public static class EnumExtensions
    {
        /// <summary>
        /// Recupera a descrição da opção do Enum, definida através do atributo Description.
        /// </summary>
        /// <param name="valor"></param>
        /// <returns></returns>
        public static string RecuperaDescricaoDoEnum(this Enum valor)
        {
            if (valor == null) return string.Empty;
            var descricao = valor.RecuperaAttributosDoEnum<DescriptionAttribute>().FirstOrDefault();
            return descricao != null ? descricao.Description : valor.ConverteEnumParaString();
        }

        /// <summary>
        /// Recupera a descrição da opção do Enum, considerando o próprio nome da opção.
        /// </summary>
        /// <param name="valor"></param>
        /// <returns></returns>
        public static string ConverteEnumParaString(this Enum valor)
        {
            if (valor == null) return string.Empty;
            var valorString = valor.ToString();
            var resultadoRegex = Regex.Matches(valorString, "[A-Z][a-z]+");
            return resultadoRegex.Count > 0 ?
                resultadoRegex.OfType<Match>()
                .Select(m => m.Value)
                .Aggregate((a, b) => a + " " + b)
                .TrimStart(' ')
                : valorString;
        }

        /// <summary>
        /// Recupera a lista de atributos associados à uma opção do Enum.
        /// </summary>
        /// <param name="valor"></param>
        /// <returns></returns>
        public static T[] RecuperaAttributosDoEnum<T>(this Enum valor)
        {
            if (valor == null) return new T[0];
            var informacoesDoCampo = valor.GetType().GetField(valor.ToString());
            return informacoesDoCampo.GetCustomAttributes(typeof(T), false) as T[];
        }
    }
}
