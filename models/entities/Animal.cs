using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Zoo.models.entities
{
   
    ///<sumary>
    ///Classe que da origem as características básicas de todos os animais 
    ///</sumary>
    public abstract class Animal
    {
        public Animal(string nome, int estimativaDeVida, double altura, double peso) {
            Nome = nome;
            EstimativaDeVida = estimativaDeVida;
            Altura = altura;
            Peso = peso;
        }
        public Animal() { 

        }

        public string Nome { get; set; }
        public int EstimativaDeVida { get; set; }
        public double Altura { get; set; }
        public double Peso { get; set; }
        /// <summary>
        /// Método que emite o som do animal escolhido
        /// </summary>
        public abstract void EmitirSom();
        
    }
}